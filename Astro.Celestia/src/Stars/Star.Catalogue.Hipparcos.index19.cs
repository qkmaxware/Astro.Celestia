using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_19() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10039"},
        {"Hipparcos Number", "HIP 7537"},
        {"Geneva Identification System", "GEN# +1.00010039"},
        {"Smithsonian Astrophysical Observation", "SAO 215583"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.28128168),
        dec: Angle.Degrees(-48.29083339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163327"},
        {"Hipparcos Number", "HIP 87950"},
        {"Smithsonian Astrophysical Observation", "SAO 228577"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.49881801),
        dec: Angle.Degrees(-48.29067558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24223"},
        {"Hipparcos Number", "HIP 17853"},
        {"Smithsonian Astrophysical Observation", "SAO 216502"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.30032420),
        dec: Angle.Degrees(-48.29037660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110756"},
        {"Hipparcos Number", "HIP 62186"},
        {"Smithsonian Astrophysical Observation", "SAO 223642"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.16956769),
        dec: Angle.Degrees(-48.28741287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81347"},
        {"Hipparcos Number", "HIP 46045"},
        {"Geneva Identification System", "GEN# +1.00081347"},
        {"Smithsonian Astrophysical Observation", "SAO 221126"},
        {"Wilson Evans Batten Catalogue", "WEB 8723"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.85573902),
        dec: Angle.Degrees(-48.28695730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37511"},
        {"Hipparcos Number", "HIP 26347"},
        {"Geneva Identification System", "GEN# +1.00037511"},
        {"Smithsonian Astrophysical Observation", "SAO 217427"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.15071345),
        dec: Angle.Degrees(-48.28466116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176037"},
        {"Hipparcos Number", "HIP 93338"},
        {"Smithsonian Astrophysical Observation", "SAO 229432"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.15933750),
        dec: Angle.Degrees(-48.28435490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31505"},
        {"Smithsonian Astrophysical Observation", "SAO 218051"},
    },
    visualMagnitude: 9.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.96779474),
        dec: Angle.Degrees(-48.28227688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188032"},
        {"Hipparcos Number", "HIP 98040"},
        {"Geneva Identification System", "GEN# +1.00188032"},
        {"Smithsonian Astrophysical Observation", "SAO 229923"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83503803),
        dec: Angle.Degrees(-48.28218834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40670"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.53821566),
        dec: Angle.Degrees(-48.28080784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47408"},
        {"Hipparcos Number", "HIP 31506"},
        {"Smithsonian Astrophysical Observation", "SAO 218052"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.96958344),
        dec: Angle.Degrees(-48.27985894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66061"},
        {"Hipparcos Number", "HIP 39076"},
        {"Geneva Identification System", "GEN# +1.00066061"},
        {"Smithsonian Astrophysical Observation", "SAO 219263"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.92401758),
        dec: Angle.Degrees(-48.27938312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27393"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.01694704),
        dec: Angle.Degrees(-48.27659879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133503"},
        {"Hipparcos Number", "HIP 73947"},
        {"Smithsonian Astrophysical Observation", "SAO 225444"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.66313487),
        dec: Angle.Degrees(-48.27600579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223171"},
        {"Hipparcos Number", "HIP 117320"},
        {"Cincinnati Publication", "Ci 20 1452"},
        {"Geneva Identification System", "GEN# +1.00223171"},
        {"Smithsonian Astrophysical Observation", "SAO 231781"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.83818106),
        dec: Angle.Degrees(-48.27506847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -383.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120413"},
        {"Hipparcos Number", "HIP 67538"},
        {"Fundamental Katalog 5th Edition", "FK5 5222"},
        {"Geneva Identification System", "GEN# +1.00120413"},
        {"Smithsonian Astrophysical Observation", "SAO 224477"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.58308916),
        dec: Angle.Degrees(-48.27395393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81651"},
        {"Hipparcos Number", "HIP 46216"},
        {"Smithsonian Astrophysical Observation", "SAO 221156"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.33380320),
        dec: Angle.Degrees(-48.27381951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93206"},
        {"Cincinnati Publication", "Ci 20 1119"},
        {"Geneva Identification System", "GEN# -0.04812818"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.78052202),
        dec: Angle.Degrees(-48.27326531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -494.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14954"},
        {"Hipparcos Number", "HIP 11128"},
        {"Smithsonian Astrophysical Observation", "SAO 215888"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.80316989),
        dec: Angle.Degrees(-48.27240848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117919"},
        {"Hipparcos Number", "HIP 66236"},
        {"Geneva Identification System", "GEN# +1.00117919J"},
        {"Smithsonian Astrophysical Observation", "SAO 224254"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.62077514),
        dec: Angle.Degrees(-48.27214554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56456"},
        {"Hipparcos Number", "HIP 35020"},
        {"Geneva Identification System", "GEN# +1.00056456A"},
        {"Smithsonian Astrophysical Observation", "SAO 218567"},
        {"Wilson Evans Batten Catalogue", "WEB 7004"},
    },
    visualMagnitude: 4.75,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.65893526),
        dec: Angle.Degrees(-48.27192832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72695"},
        {"Hipparcos Number", "HIP 41866"},
        {"Geneva Identification System", "GEN# +1.00072695"},
        {"Smithsonian Astrophysical Observation", "SAO 220064"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.04941547),
        dec: Angle.Degrees(-48.27189034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26941"},
        {"Hipparcos Number", "HIP 19705"},
        {"Smithsonian Astrophysical Observation", "SAO 216704"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.32085584),
        dec: Angle.Degrees(-48.27178042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56420"},
    },
    visualMagnitude: 11.56,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.51727550),
        dec: Angle.Degrees(-48.27091751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209267"},
        {"Hipparcos Number", "HIP 108866"},
        {"Smithsonian Astrophysical Observation", "SAO 230960"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.81371056),
        dec: Angle.Degrees(-48.27008012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85836"},
        {"Hipparcos Number", "HIP 48487"},
        {"Smithsonian Astrophysical Observation", "SAO 221576"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.32277744),
        dec: Angle.Degrees(-48.26902082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103196"},
        {"Hipparcos Number", "HIP 57933"},
        {"Smithsonian Astrophysical Observation", "SAO 223082"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22351532),
        dec: Angle.Degrees(-48.26884330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165983"},
        {"Hipparcos Number", "HIP 89094"},
        {"Smithsonian Astrophysical Observation", "SAO 228770"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.76324146),
        dec: Angle.Degrees(-48.26849857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34921"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.38296401),
        dec: Angle.Degrees(-48.26790913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46213"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.32971966),
        dec: Angle.Degrees(-48.26739372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172995"},
        {"Hipparcos Number", "HIP 92039"},
        {"Geneva Identification System", "GEN# +1.00172995"},
        {"Smithsonian Astrophysical Observation", "SAO 229248"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.40478176),
        dec: Angle.Degrees(-48.26404705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36542"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.74940803),
        dec: Angle.Degrees(-48.26154862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123360"},
        {"Hipparcos Number", "HIP 69072"},
        {"Geneva Identification System", "GEN# +2.54600004"},
        {"Smithsonian Astrophysical Observation", "SAO 224715"},
        {"New General Catalogue", "NGC 5460 4"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.08709664),
        dec: Angle.Degrees(-48.26106277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88015"},
        {"Hipparcos Number", "HIP 49619"},
        {"Geneva Identification System", "GEN# +1.00088015"},
        {"Smithsonian Astrophysical Observation", "SAO 221792"},
        {"Wilson Evans Batten Catalogue", "WEB 9150"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.89887481),
        dec: Angle.Degrees(-48.26083007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1276"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.00847381),
        dec: Angle.Degrees(-48.26027238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97980"},
        {"Hipparcos Number", "HIP 54989"},
        {"Geneva Identification System", "GEN# +1.00097980"},
        {"Smithsonian Astrophysical Observation", "SAO 222679"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.89809732),
        dec: Angle.Degrees(-48.25851191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40664"},
        {"Hipparcos Number", "HIP 28217"},
        {"Smithsonian Astrophysical Observation", "SAO 217644"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.42777989),
        dec: Angle.Degrees(-48.25653942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198506"},
        {"Hipparcos Number", "HIP 103038"},
        {"Smithsonian Astrophysical Observation", "SAO 230410"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.13515527),
        dec: Angle.Degrees(-48.25516445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7526"},
        {"Hipparcos Number", "HIP 5809"},
        {"Geneva Identification System", "GEN# +1.00007526"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.63498952),
        dec: Angle.Degrees(-48.25203275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38212"},
        {"Hipparcos Number", "HIP 26805"},
        {"Smithsonian Astrophysical Observation", "SAO 217479"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.38605963),
        dec: Angle.Degrees(-48.25065997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54505"},
        {"Hipparcos Number", "HIP 34293"},
        {"Smithsonian Astrophysical Observation", "SAO 218459"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.64115017),
        dec: Angle.Degrees(-48.25061420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116650"},
        {"Hipparcos Number", "HIP 65517"},
        {"Geneva Identification System", "GEN# +1.00116650"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.44944598),
        dec: Angle.Degrees(-48.24935778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154387"},
        {"Hipparcos Number", "HIP 83797"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.88071583),
        dec: Angle.Degrees(-48.24823393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165141"},
        {"Hipparcos Number", "HIP 88743"},
        {"Smithsonian Astrophysical Observation", "SAO 228707"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.75102658),
        dec: Angle.Degrees(-48.24730670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130933"},
        {"Hipparcos Number", "HIP 72763"},
        {"Smithsonian Astrophysical Observation", "SAO 225261"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12231119),
        dec: Angle.Degrees(-48.24706246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46383"},
        {"Hipparcos Number", "HIP 31022"},
        {"Smithsonian Astrophysical Observation", "SAO 217984"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.64058284),
        dec: Angle.Degrees(-48.24643612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161564"},
        {"Hipparcos Number", "HIP 87185"},
        {"Smithsonian Astrophysical Observation", "SAO 228434"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.18108215),
        dec: Angle.Degrees(-48.24471348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74436"},
        {"Hipparcos Number", "HIP 42698"},
        {"Celescope Catalog", "CEL 2799"},
        {"Geneva Identification System", "GEN# +3.23950006"},
        {"Smithsonian Astrophysical Observation", "SAO 220306"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.53149739),
        dec: Angle.Degrees(-48.24467482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221210"},
        {"Hipparcos Number", "HIP 116013"},
        {"Smithsonian Astrophysical Observation", "SAO 231635"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.58483850),
        dec: Angle.Degrees(-48.24247445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41004"},
        {"Hipparcos Number", "HIP 28393"},
        {"Geneva Identification System", "GEN# +1.00041004"},
        {"Smithsonian Astrophysical Observation", "SAO 217660"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.95702627),
        dec: Angle.Degrees(-48.23984973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93049"},
        {"Hipparcos Number", "HIP 52485"},
        {"Smithsonian Astrophysical Observation", "SAO 222277"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.95559616),
        dec: Angle.Degrees(-48.23901256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23285"},
        {"Hipparcos Number", "HIP 17260"},
        {"Smithsonian Astrophysical Observation", "SAO 216446"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45591929),
        dec: Angle.Degrees(-48.23898327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102339"},
        {"Hipparcos Number", "HIP 57448"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64840080),
        dec: Angle.Degrees(-48.23860745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83852"},
        {"Hipparcos Number", "HIP 47412"},
        {"Geneva Identification System", "GEN# +1.00083852"},
        {"Smithsonian Astrophysical Observation", "SAO 221385"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.91883378),
        dec: Angle.Degrees(-48.23707634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142711"},
        {"Hipparcos Number", "HIP 78202"},
        {"Smithsonian Astrophysical Observation", "SAO 226405"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.53149781),
        dec: Angle.Degrees(-48.23519243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132098"},
        {"Hipparcos Number", "HIP 73324"},
        {"Smithsonian Astrophysical Observation", "SAO 225339"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.75746249),
        dec: Angle.Degrees(-48.23473350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56662"},
        {"Hipparcos Number", "HIP 35096"},
        {"Geneva Identification System", "GEN# +1.00056662"},
        {"Smithsonian Astrophysical Observation", "SAO 218576"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87181151),
        dec: Angle.Degrees(-48.23040183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100854"},
        {"Hipparcos Number", "HIP 56588"},
        {"Smithsonian Astrophysical Observation", "SAO 222897"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.02520450),
        dec: Angle.Degrees(-48.22936726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92139"},
        {"Henry Draper 2", "HD 92140"},
        {"Hipparcos Number", "HIP 51986"},
        {"Geneva Identification System", "GEN# +1.00092139J"},
        {"Renson", "Renson 26490"},
        {"Smithsonian Astrophysical Observation", "SAO 222199"},
        {"Wilson Evans Batten Catalogue", "WEB 9482"},
    },
    visualMagnitude: 3.84,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.32606984),
        dec: Angle.Degrees(-48.22561631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74234"},
        {"Hipparcos Number", "HIP 42595"},
        {"Celescope Catalog", "CEL 2775"},
        {"Geneva Identification System", "GEN# +3.23950002"},
        {"Smithsonian Astrophysical Observation", "SAO 220276"},
        {"Wilson Evans Batten Catalogue", "WEB 8225"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.22251741),
        dec: Angle.Degrees(-48.22551417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97578"},
        {"Hipparcos Number", "HIP 54806"},
        {"Geneva Identification System", "GEN# +1.00097578"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.30137037),
        dec: Angle.Degrees(-48.22506037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11040"},
        {"Hipparcos Number", "HIP 8326"},
        {"Smithsonian Astrophysical Observation", "SAO 215653"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.83982900),
        dec: Angle.Degrees(-48.22476617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198010"},
        {"Hipparcos Number", "HIP 102759"},
        {"Smithsonian Astrophysical Observation", "SAO 230388"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31147213),
        dec: Angle.Degrees(-48.22453127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146800"},
        {"Hipparcos Number", "HIP 80043"},
        {"Cincinnati Publication", "Ci 20 979"},
        {"Geneva Identification System", "GEN# +1.00146800"},
        {"Smithsonian Astrophysical Observation", "SAO 226667"},
        {"Wilson Evans Batten Catalogue", "WEB 13552"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.07634699),
        dec: Angle.Degrees(-48.22389406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -403.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -786.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48907"},
        {"Hipparcos Number", "HIP 32192"},
        {"Smithsonian Astrophysical Observation", "SAO 218155"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80799703),
        dec: Angle.Degrees(-48.22334557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100260"},
        {"Hipparcos Number", "HIP 56251"},
        {"Smithsonian Astrophysical Observation", "SAO 222850"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.95987615),
        dec: Angle.Degrees(-48.22234721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37863"},
        {"Hipparcos Number", "HIP 26578"},
        {"Smithsonian Astrophysical Observation", "SAO 217457"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.75414144),
        dec: Angle.Degrees(-48.22180317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47973"},
        {"Hipparcos Number", "HIP 31765"},
        {"Geneva Identification System", "GEN# +1.00047973A"},
        {"Smithsonian Astrophysical Observation", "SAO 218093"},
        {"Wilson Evans Batten Catalogue", "WEB 6376"},
    },
    visualMagnitude: 5.05,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.65680209),
        dec: Angle.Degrees(-48.22023129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134597"},
        {"Hipparcos Number", "HIP 74418"},
        {"Geneva Identification System", "GEN# +1.00134597"},
        {"Smithsonian Astrophysical Observation", "SAO 225533"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.13010521),
        dec: Angle.Degrees(-48.21889226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51264"},
        {"Hipparcos Number", "HIP 33155"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53937063),
        dec: Angle.Degrees(-48.21860255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2726"},
        {"Hipparcos Number", "HIP 2383"},
        {"Geneva Identification System", "GEN# +1.00002726"},
        {"Smithsonian Astrophysical Observation", "SAO 215119"},
        {"Wilson Evans Batten Catalogue", "WEB 438"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.60822774),
        dec: Angle.Degrees(-48.21469821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103161"},
        {"Geneva Identification System", "GEN# -0.04813714"},
        {"Wilson Evans Batten Catalogue", "WEB 18738"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.51200293),
        dec: Angle.Degrees(-48.21438248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32492"},
        {"Hipparcos Number", "HIP 23325"},
        {"Smithsonian Astrophysical Observation", "SAO 217120"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.26052556),
        dec: Angle.Degrees(-48.21130631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208996"},
        {"Hipparcos Number", "HIP 108716"},
        {"Smithsonian Astrophysical Observation", "SAO 230940"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.33794424),
        dec: Angle.Degrees(-48.21095980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18897"},
        {"Hipparcos Number", "HIP 14027"},
        {"Smithsonian Astrophysical Observation", "SAO 216133"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15637138),
        dec: Angle.Degrees(-48.21081697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26404"},
        {"Hipparcos Number", "HIP 19309"},
        {"Smithsonian Astrophysical Observation", "SAO 216666"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.08858760),
        dec: Angle.Degrees(-48.21079449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102102"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.37034461),
        dec: Angle.Degrees(-48.21077830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97910"},
        {"Hipparcos Number", "HIP 54955"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.80795395),
        dec: Angle.Degrees(-48.21005111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70950"},
        {"Hipparcos Number", "HIP 41057"},
        {"Celescope Catalog", "CEL 2447"},
        {"Geneva Identification System", "GEN# +1.00070950"},
        {"Smithsonian Astrophysical Observation", "SAO 219852"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.66986541),
        dec: Angle.Degrees(-48.21001716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171377"},
        {"Hipparcos Number", "HIP 91270"},
        {"Geneva Identification System", "GEN# +1.00171377"},
        {"Smithsonian Astrophysical Observation", "SAO 229142"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.25784684),
        dec: Angle.Degrees(-48.20935725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104473"},
        {"Hipparcos Number", "HIP 58664"},
        {"Smithsonian Astrophysical Observation", "SAO 223176"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43674332),
        dec: Angle.Degrees(-48.20826449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57086"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.54279574),
        dec: Angle.Degrees(-48.20809526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79071"},
        {"Hipparcos Number", "HIP 45013"},
        {"Fundamental Katalog 5th Edition", "FK5 4817"},
        {"Geneva Identification System", "GEN# +1.00079071"},
        {"Smithsonian Astrophysical Observation", "SAO 220915"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.52289559),
        dec: Angle.Degrees(-48.20640818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76915"},
        {"Hipparcos Number", "HIP 43978"},
        {"Celescope Catalog", "CEL 3102"},
        {"Geneva Identification System", "GEN# +1.00076915"},
        {"Smithsonian Astrophysical Observation", "SAO 220695"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.33576652),
        dec: Angle.Degrees(-48.20496433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185850"},
        {"Hipparcos Number", "HIP 97047"},
        {"Smithsonian Astrophysical Observation", "SAO 229830"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.84746701),
        dec: Angle.Degrees(-48.20430863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220608"},
        {"Hipparcos Number", "HIP 115630"},
        {"Smithsonian Astrophysical Observation", "SAO 231603"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.36013176),
        dec: Angle.Degrees(-48.20310824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199289"},
        {"Hipparcos Number", "HIP 103498"},
        {"Geneva Identification System", "GEN# +1.00199289"},
        {"Smithsonian Astrophysical Observation", "SAO 230461"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.53490183),
        dec: Angle.Degrees(-48.20304710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58987"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.41049107),
        dec: Angle.Degrees(-48.20251552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185747"},
        {"Hipparcos Number", "HIP 96987"},
        {"Smithsonian Astrophysical Observation", "SAO 229823"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70354143),
        dec: Angle.Degrees(-48.20244829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6208"},
        {"Hipparcos Number", "HIP 4861"},
        {"Geneva Identification System", "GEN# +1.00006208"},
        {"Smithsonian Astrophysical Observation", "SAO 215340"},
        {"Wilson Evans Batten Catalogue", "WEB 942"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.62575471),
        dec: Angle.Degrees(-48.20116801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58988"},
    },
    visualMagnitude: 13.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.41122416),
        dec: Angle.Degrees(-48.19892834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58474"},
        {"Hipparcos Number", "HIP 35832"},
        {"Smithsonian Astrophysical Observation", "SAO 218689"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.84254921),
        dec: Angle.Degrees(-48.19849891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70309"},
        {"Hipparcos Number", "HIP 40749"},
        {"Celescope Catalog", "CEL 2368"},
        {"Geneva Identification System", "GEN# +1.00070309A"},
        {"Smithsonian Astrophysical Observation", "SAO 219785"},
        {"Wilson Evans Batten Catalogue", "WEB 7911"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.77332023),
        dec: Angle.Degrees(-48.19787583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96205"},
        {"Hipparcos Number", "HIP 54180"},
        {"Geneva Identification System", "GEN# +1.00096205"},
        {"Smithsonian Astrophysical Observation", "SAO 222546"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.24304623),
        dec: Angle.Degrees(-48.19718870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170554"},
        {"Hipparcos Number", "HIP 90899"},
        {"Smithsonian Astrophysical Observation", "SAO 229099"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.11441308),
        dec: Angle.Degrees(-48.19714472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78023"},
        {"Hipparcos Number", "HIP 44521"},
        {"Geneva Identification System", "GEN# +1.00078023"},
        {"Smithsonian Astrophysical Observation", "SAO 220805"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.06410791),
        dec: Angle.Degrees(-48.19704960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220754"},
        {"Hipparcos Number", "HIP 115726"},
        {"Smithsonian Astrophysical Observation", "SAO 231611"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68265510),
        dec: Angle.Degrees(-48.19699775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104664"},
        {"Hipparcos Number", "HIP 58765"},
        {"Geneva Identification System", "GEN# +1.00104664"},
        {"Smithsonian Astrophysical Observation", "SAO 223191"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.77786660),
        dec: Angle.Degrees(-48.19493564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82695"},
        {"Hipparcos Number", "HIP 46782"},
        {"Geneva Identification System", "GEN# +1.00082695"},
        {"Smithsonian Astrophysical Observation", "SAO 221260"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00677890),
        dec: Angle.Degrees(-48.19483398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185112"},
        {"Hipparcos Number", "HIP 96725"},
        {"Geneva Identification System", "GEN# +1.00185112"},
        {"Smithsonian Astrophysical Observation", "SAO 229798"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.94110569),
        dec: Angle.Degrees(-48.19274420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76004"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.83211450),
        dec: Angle.Degrees(-48.19215288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34708"},
        {"Hipparcos Number", "HIP 24624"},
        {"Smithsonian Astrophysical Observation", "SAO 217271"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.22615361),
        dec: Angle.Degrees(-48.19143928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72090"},
        {"Hipparcos Number", "HIP 41601"},
        {"Smithsonian Astrophysical Observation", "SAO 219979"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.21769497),
        dec: Angle.Degrees(-48.19045514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67705"},
        {"Hipparcos Number", "HIP 39717"},
        {"Smithsonian Astrophysical Observation", "SAO 219439"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.77366221),
        dec: Angle.Degrees(-48.18964690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206379"},
        {"Hipparcos Number", "HIP 107231"},
        {"Geneva Identification System", "GEN# +1.00206379"},
        {"Smithsonian Astrophysical Observation", "SAO 230806"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.76783928),
        dec: Angle.Degrees(-48.18944822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147001"},
        {"Hipparcos Number", "HIP 80142"},
        {"Geneva Identification System", "GEN# +1.00147001"},
        {"Smithsonian Astrophysical Observation", "SAO 226678"},
        {"Wilson Evans Batten Catalogue", "WEB 13565"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.36268261),
        dec: Angle.Degrees(-48.18856856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68515"},
        {"Hipparcos Number", "HIP 40027"},
        {"Geneva Identification System", "GEN# +1.00068515"},
        {"Smithsonian Astrophysical Observation", "SAO 219542"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.63687891),
        dec: Angle.Degrees(-48.18736650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123224"},
        {"Hipparcos Number", "HIP 69006"},
        {"Geneva Identification System", "GEN# +2.54600002"},
        {"Geneva Identification System 2", "GEN# +2.54600050"},
        {"Smithsonian Astrophysical Observation", "SAO 224701"},
        {"New General Catalogue", "NGC 5460 2"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.90783600),
        dec: Angle.Degrees(-48.18601059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71631"},
        {"Hipparcos Number", "HIP 41374"},
        {"Smithsonian Astrophysical Observation", "SAO 219922"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.61280250),
        dec: Angle.Degrees(-48.18496565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172463"},
        {"Hipparcos Number", "HIP 91767"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.69407422),
        dec: Angle.Degrees(-48.18469553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74621"},
        {"Hipparcos Number", "HIP 42787"},
        {"Geneva Identification System", "GEN# +3.23950009"},
        {"Smithsonian Astrophysical Observation", "SAO 220342"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.76810298),
        dec: Angle.Degrees(-48.18434509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98478"},
        {"Hipparcos Number", "HIP 55270"},
        {"Geneva Identification System", "GEN# +1.00098478"},
        {"Smithsonian Astrophysical Observation", "SAO 222711"},
        {"Wilson Evans Batten Catalogue", "WEB 9956"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.79348740),
        dec: Angle.Degrees(-48.18182455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91137"},
        {"Hipparcos Number", "HIP 51439"},
        {"Smithsonian Astrophysical Observation", "SAO 222106"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.58549597),
        dec: Angle.Degrees(-48.18060863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45572"},
        {"Hipparcos Number", "HIP 30591"},
        {"Geneva Identification System", "GEN# +1.00045572"},
        {"Renson", "Renson 12110"},
        {"Smithsonian Astrophysical Observation", "SAO 217922"},
        {"Wilson Evans Batten Catalogue", "WEB 6101"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.43189775),
        dec: Angle.Degrees(-48.17684903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214876"},
        {"Hipparcos Number", "HIP 112081"},
        {"Smithsonian Astrophysical Observation", "SAO 231254"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.53317682),
        dec: Angle.Degrees(-48.17558905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153247"},
        {"Hipparcos Number", "HIP 83231"},
        {"Smithsonian Astrophysical Observation", "SAO 227545"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.13969782),
        dec: Angle.Degrees(-48.17376560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101749"},
        {"Hipparcos Number", "HIP 57100"},
        {"Smithsonian Astrophysical Observation", "SAO 222970"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.57854023),
        dec: Angle.Degrees(-48.17311260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76121"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.20313006),
        dec: Angle.Degrees(-48.17251255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120030"},
        {"Hipparcos Number", "HIP 67331"},
        {"Smithsonian Astrophysical Observation", "SAO 224436"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.00191536),
        dec: Angle.Degrees(-48.17200515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133277"},
        {"Hipparcos Number", "HIP 73833"},
        {"Smithsonian Astrophysical Observation", "SAO 225431"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33948831),
        dec: Angle.Degrees(-48.17148874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124829"},
        {"Hipparcos Number", "HIP 69797"},
        {"Smithsonian Astrophysical Observation", "SAO 224813"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.27319108),
        dec: Angle.Degrees(-48.17113947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110838"},
        {"Hipparcos Number", "HIP 62241"},
        {"Geneva Identification System", "GEN# +1.00110838"},
        {"Smithsonian Astrophysical Observation", "SAO 223644"},
        {"Wilson Evans Batten Catalogue", "WEB 11056"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.34792310),
        dec: Angle.Degrees(-48.17050930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25222"},
        {"Hipparcos Number", "HIP 18556"},
        {"Smithsonian Astrophysical Observation", "SAO 216582"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.56441414),
        dec: Angle.Degrees(-48.17044518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69799"},
        {"Smithsonian Astrophysical Observation", "SAO 224814"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.27593257),
        dec: Angle.Degrees(-48.16841290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59103"},
        {"Hipparcos Number", "HIP 36084"},
        {"Smithsonian Astrophysical Observation", "SAO 218720"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.52481113),
        dec: Angle.Degrees(-48.16785958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210527"},
        {"Hipparcos Number", "HIP 109593"},
        {"Smithsonian Astrophysical Observation", "SAO 231023"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.00974202),
        dec: Angle.Degrees(-48.16728718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201370"},
        {"Hipparcos Number", "HIP 104563"},
        {"Smithsonian Astrophysical Observation", "SAO 230560"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.72642362),
        dec: Angle.Degrees(-48.16689981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74531"},
        {"Hipparcos Number", "HIP 42738"},
        {"Geneva Identification System", "GEN# +3.23950003"},
        {"Smithsonian Astrophysical Observation", "SAO 220319"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.64516973),
        dec: Angle.Degrees(-48.16359975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203586"},
        {"Hipparcos Number", "HIP 105716"},
        {"Smithsonian Astrophysical Observation", "SAO 230669"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.17296137),
        dec: Angle.Degrees(-48.16230034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142529"},
        {"Hipparcos Number", "HIP 78117"},
        {"Geneva Identification System", "GEN# +1.00142529"},
        {"Smithsonian Astrophysical Observation", "SAO 226392"},
        {"Wilson Evans Batten Catalogue", "WEB 13210"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.26645246),
        dec: Angle.Degrees(-48.16191945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186560"},
        {"Hipparcos Number", "HIP 97368"},
        {"Smithsonian Astrophysical Observation", "SAO 229863"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.85286746),
        dec: Angle.Degrees(-48.16168150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1380"},
        {"Hipparcos Number", "HIP 1418"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.44005901),
        dec: Angle.Degrees(-48.16141030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120870"},
        {"Hipparcos Number", "HIP 67794"},
        {"Smithsonian Astrophysical Observation", "SAO 224508"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.32417931),
        dec: Angle.Degrees(-48.16109222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140352"},
        {"Hipparcos Number", "HIP 77148"},
        {"Smithsonian Astrophysical Observation", "SAO 226144"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.27276990),
        dec: Angle.Degrees(-48.16069873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189952"},
        {"Hipparcos Number", "HIP 98877"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19381425),
        dec: Angle.Degrees(-48.16066732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162765"},
        {"Hipparcos Number", "HIP 87723"},
        {"Geneva Identification System", "GEN# +1.00162765"},
        {"Smithsonian Astrophysical Observation", "SAO 228537"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.78352625),
        dec: Angle.Degrees(-48.15825829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30043"},
        {"Hipparcos Number", "HIP 21836"},
        {"Smithsonian Astrophysical Observation", "SAO 216937"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.41406445),
        dec: Angle.Degrees(-48.15682946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148444"},
        {"Hipparcos Number", "HIP 80832"},
        {"Smithsonian Astrophysical Observation", "SAO 226826"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.61249624),
        dec: Angle.Degrees(-48.15652230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8062"},
        {"Hipparcos Number", "HIP 6168"},
        {"Smithsonian Astrophysical Observation", "SAO 215455"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.78433241),
        dec: Angle.Degrees(-48.15602135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18117"},
        {"Hipparcos Number", "HIP 13425"},
        {"Smithsonian Astrophysical Observation", "SAO 216083"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.21723870),
        dec: Angle.Degrees(-48.15307147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117485"},
        {"Hipparcos Number", "HIP 65975"},
        {"Smithsonian Astrophysical Observation", "SAO 224218"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.89984940),
        dec: Angle.Degrees(-48.15303044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28182"},
        {"Hipparcos Number", "HIP 20571"},
        {"Smithsonian Astrophysical Observation", "SAO 216788"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.10547984),
        dec: Angle.Degrees(-48.15189161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171039"},
        {"Hipparcos Number", "HIP 91098"},
        {"Smithsonian Astrophysical Observation", "SAO 229126"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.73530447),
        dec: Angle.Degrees(-48.15118806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6075"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.49661488),
        dec: Angle.Degrees(-48.15055596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124364"},
        {"Hipparcos Number", "HIP 69570"},
        {"Geneva Identification System", "GEN# +1.00124364"},
        {"Smithsonian Astrophysical Observation", "SAO 224784"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.60381501),
        dec: Angle.Degrees(-48.14634043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 621"},
        {"Hipparcos Number", "HIP 844"},
        {"Smithsonian Astrophysical Observation", "SAO 214989"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.58889481),
        dec: Angle.Degrees(-48.14358093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65895"},
        {"Hipparcos Number", "HIP 38988"},
        {"Smithsonian Astrophysical Observation", "SAO 219235"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.68984067),
        dec: Angle.Degrees(-48.14047500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78786"},
        {"Hipparcos Number", "HIP 44852"},
        {"Smithsonian Astrophysical Observation", "SAO 220886"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.07653697),
        dec: Angle.Degrees(-48.13749556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22028"},
        {"Hipparcos Number", "HIP 16387"},
        {"Smithsonian Astrophysical Observation", "SAO 216362"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.76559284),
        dec: Angle.Degrees(-48.13712692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183117"},
        {"Hipparcos Number", "HIP 95897"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.54116266),
        dec: Angle.Degrees(-48.13532889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47268"},
        {"Hipparcos Number", "HIP 31440"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.80979481),
        dec: Angle.Degrees(-48.13499110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121141"},
        {"Hipparcos Number", "HIP 67928"},
        {"Geneva Identification System", "GEN# +1.00121141"},
        {"Smithsonian Astrophysical Observation", "SAO 224526"},
        {"Wilson Evans Batten Catalogue", "WEB 11933"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67448294),
        dec: Angle.Degrees(-48.13452815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188581"},
        {"Hipparcos Number", "HIP 98274"},
        {"Smithsonian Astrophysical Observation", "SAO 229955"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.51783361),
        dec: Angle.Degrees(-48.13366885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19505"},
        {"Geneva Identification System", "GEN# -0.01800767"},
        {"Smithsonian Astrophysical Observation", "SAO 149432"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67701803),
        dec: Angle.Degrees(-17.78371175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113451"},
        {"Hipparcos Number", "HIP 63795"},
        {"Geneva Identification System", "GEN# +1.00113451"},
        {"Smithsonian Astrophysical Observation", "SAO 223877"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.12545065),
        dec: Angle.Degrees(-48.13280267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173359"},
        {"Hipparcos Number", "HIP 92181"},
        {"Geneva Identification System", "GEN# +1.00173359"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.81884345),
        dec: Angle.Degrees(-48.13125461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108405"},
        {"Hipparcos Number", "HIP 60779"},
        {"Geneva Identification System", "GEN# +1.00108405"},
        {"Smithsonian Astrophysical Observation", "SAO 223449"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.86965306),
        dec: Angle.Degrees(-48.13080522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -321.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97430"},
        {"Hipparcos Number", "HIP 54720"},
        {"Smithsonian Astrophysical Observation", "SAO 222636"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04444234),
        dec: Angle.Degrees(-48.13074502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206151B"},
        {"Hipparcos Number", "HIP 107094"},
        {"Smithsonian Astrophysical Observation", "SAO 230793"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.38701144),
        dec: Angle.Degrees(-48.12995792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206151"},
        {"Hipparcos Number", "HIP 107092"},
        {"Smithsonian Astrophysical Observation", "SAO 230792"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.38209231),
        dec: Angle.Degrees(-48.12868211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91529"},
        {"Hipparcos Number", "HIP 51655"},
        {"Smithsonian Astrophysical Observation", "SAO 222141"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.30045912),
        dec: Angle.Degrees(-48.12685260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225167"},
        {"Hipparcos Number", "HIP 313"},
        {"Smithsonian Astrophysical Observation", "SAO 214947"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.99110213),
        dec: Angle.Degrees(-48.12518732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68208"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.46152490),
        dec: Angle.Degrees(-48.12151662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17629"},
        {"Hipparcos Number", "HIP 13070"},
        {"Smithsonian Astrophysical Observation", "SAO 216052"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.99788857),
        dec: Angle.Degrees(-48.12103885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169405"},
        {"Hipparcos Number", "HIP 90414"},
        {"Geneva Identification System", "GEN# +1.00169405"},
        {"Smithsonian Astrophysical Observation", "SAO 229021"},
        {"Wilson Evans Batten Catalogue", "WEB 15483"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.72503769),
        dec: Angle.Degrees(-48.11710875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22531"},
        {"Hipparcos Number", "HIP 16741"},
        {"Smithsonian Astrophysical Observation", "SAO 216396"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.83812126),
        dec: Angle.Degrees(-48.11496480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219665"},
        {"Hipparcos Number", "HIP 115042"},
        {"Geneva Identification System", "GEN# +1.00219665"},
        {"Smithsonian Astrophysical Observation", "SAO 231538"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.50186415),
        dec: Angle.Degrees(-48.11302674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224445"},
        {"Hipparcos Number", "HIP 118153"},
        {"Smithsonian Astrophysical Observation", "SAO 231871"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.50407267),
        dec: Angle.Degrees(-48.11230428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63451"},
        {"Hipparcos Number", "HIP 37950"},
        {"Smithsonian Astrophysical Observation", "SAO 218988"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.68292675),
        dec: Angle.Degrees(-48.11217585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148937"},
        {"Hipparcos Number", "HIP 81100"},
        {"Geneva Identification System", "GEN# +1.00148937J"},
        {"Smithsonian Astrophysical Observation", "SAO 226891"},
        {"Wilson Evans Batten Catalogue", "WEB 13713"},
        {"New General Catalogue", "NGC 6164"},
        {"New General Catalogue 2", "NGC 6165"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.46828056),
        dec: Angle.Degrees(-48.11123470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24490"},
        {"Hipparcos Number", "HIP 18054"},
        {"Smithsonian Astrophysical Observation", "SAO 216525"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.88436831),
        dec: Angle.Degrees(-48.10888104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40030"},
        {"Hipparcos Number", "HIP 27866"},
        {"Smithsonian Astrophysical Observation", "SAO 217607"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.44316065),
        dec: Angle.Degrees(-48.10821503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84448"},
        {"Hipparcos Number", "HIP 47743"},
        {"Smithsonian Astrophysical Observation", "SAO 221435"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.98594984),
        dec: Angle.Degrees(-48.10802131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210204"},
        {"Hipparcos Number", "HIP 109408"},
        {"Geneva Identification System", "GEN# +1.00210204"},
        {"Smithsonian Astrophysical Observation", "SAO 231005"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.49091875),
        dec: Angle.Degrees(-48.10750848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17866"},
        {"Hipparcos Number", "HIP 13243"},
        {"Smithsonian Astrophysical Observation", "SAO 216063"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.60959761),
        dec: Angle.Degrees(-48.10699847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49876"},
        {"Hipparcos Number", "HIP 32598"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.00808232),
        dec: Angle.Degrees(-48.10687443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110159"},
        {"Hipparcos Number", "HIP 61848"},
        {"Smithsonian Astrophysical Observation", "SAO 223589"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.13439454),
        dec: Angle.Degrees(-48.10600201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83780"},
        {"Hipparcos Number", "HIP 47385"},
        {"Geneva Identification System", "GEN# +1.00083780"},
        {"Smithsonian Astrophysical Observation", "SAO 221374"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.80969888),
        dec: Angle.Degrees(-48.10586282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206628"},
        {"Hipparcos Number", "HIP 107360"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.17620264),
        dec: Angle.Degrees(-48.10415991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152318"},
        {"Hipparcos Number", "HIP 82769"},
        {"Smithsonian Astrophysical Observation", "SAO 227406"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.73128004),
        dec: Angle.Degrees(-48.10296544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64760"},
        {"Hipparcos Number", "HIP 38518"},
        {"Celescope Catalog", "CEL 2083"},
        {"Geneva Identification System", "GEN# +1.00064760"},
        {"Smithsonian Astrophysical Observation", "SAO 219111"},
        {"Wilson Evans Batten Catalogue", "WEB 7570"},
    },
    visualMagnitude: 4.22,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.32567862),
        dec: Angle.Degrees(-48.10294824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111671"},
        {"Hipparcos Number", "HIP 62744"},
        {"Geneva Identification System", "GEN# +1.00111671"},
        {"Smithsonian Astrophysical Observation", "SAO 223713"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.84611073),
        dec: Angle.Degrees(-48.10252092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199460"},
        {"Hipparcos Number", "HIP 103578"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.78527122),
        dec: Angle.Degrees(-48.10044026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53099"},
        {"Hipparcos Number", "HIP 33826"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.33688882),
        dec: Angle.Degrees(-48.09992190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184127"},
        {"Hipparcos Number", "HIP 96341"},
        {"Fundamental Katalog 5th Edition", "FK5 735"},
        {"Geneva Identification System", "GEN# +1.00184127"},
        {"Smithsonian Astrophysical Observation", "SAO 229751"},
        {"Wilson Evans Batten Catalogue", "WEB 16892"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.80414074),
        dec: Angle.Degrees(-48.09911061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74455"},
        {"Hipparcos Number", "HIP 42712"},
        {"Celescope Catalog", "CEL 2801"},
        {"Smithsonian Astrophysical Observation", "SAO 220313"},
        {"Wilson Evans Batten Catalogue", "WEB 8251"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.56748955),
        dec: Angle.Degrees(-48.09909900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220248"},
        {"Hipparcos Number", "HIP 115402"},
        {"Smithsonian Astrophysical Observation", "SAO 231574"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.65773581),
        dec: Angle.Degrees(-48.09626243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13515"},
        {"Hipparcos Number", "HIP 10148"},
        {"Geneva Identification System", "GEN# +1.00013515"},
        {"Smithsonian Astrophysical Observation", "SAO 215800"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.63912097),
        dec: Angle.Degrees(-48.09442575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172223"},
        {"Hipparcos Number", "HIP 91662"},
        {"Geneva Identification System", "GEN# +1.00172223"},
        {"Smithsonian Astrophysical Observation", "SAO 229194"},
        {"Wilson Evans Batten Catalogue", "WEB 15764"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.37789502),
        dec: Angle.Degrees(-48.09440735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111775"},
        {"Hipparcos Number", "HIP 62799"},
        {"Geneva Identification System", "GEN# +1.00111775"},
        {"Smithsonian Astrophysical Observation", "SAO 223720"},
        {"Wilson Evans Batten Catalogue", "WEB 11134"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.02279636),
        dec: Angle.Degrees(-48.09429527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53312"},
        {"Hipparcos Number", "HIP 33899"},
        {"Renson", "Renson 14680"},
        {"Smithsonian Astrophysical Observation", "SAO 218398"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.54070713),
        dec: Angle.Degrees(-48.09224933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181979"},
        {"Hipparcos Number", "HIP 95437"},
        {"Smithsonian Astrophysical Observation", "SAO 229665"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.20167565),
        dec: Angle.Degrees(-48.09209431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112179"},
        {"Hipparcos Number", "HIP 63050"},
        {"Smithsonian Astrophysical Observation", "SAO 223754"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.78529465),
        dec: Angle.Degrees(-48.09159318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94840"},
        {"Hipparcos Number", "HIP 53462"},
        {"Smithsonian Astrophysical Observation", "SAO 222436"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.04917366),
        dec: Angle.Degrees(-48.09105339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68871"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54385223),
        dec: Angle.Degrees(-48.09086368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126563"},
        {"Hipparcos Number", "HIP 70704"},
        {"Geneva Identification System", "GEN# +1.00126563"},
        {"Smithsonian Astrophysical Observation", "SAO 224938"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.92389561),
        dec: Angle.Degrees(-48.09022969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143905"},
        {"Hipparcos Number", "HIP 78795"},
        {"Smithsonian Astrophysical Observation", "SAO 226489"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.28830081),
        dec: Angle.Degrees(-48.08917425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105715"},
        {"Hipparcos Number", "HIP 59325"},
        {"Geneva Identification System", "GEN# +1.00105715"},
        {"Smithsonian Astrophysical Observation", "SAO 223256"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.55409755),
        dec: Angle.Degrees(-48.08774461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90561"},
        {"Hipparcos Number", "HIP 51093"},
        {"Smithsonian Astrophysical Observation", "SAO 222053"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.58571895),
        dec: Angle.Degrees(-48.08638994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212917"},
        {"Hipparcos Number", "HIP 110956"},
        {"Smithsonian Astrophysical Observation", "SAO 231152"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20201033),
        dec: Angle.Degrees(-48.08556585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83219"},
        {"Hipparcos Number", "HIP 47051"},
        {"Celescope Catalog", "CEL 3334"},
        {"Smithsonian Astrophysical Observation", "SAO 221308"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.82683667),
        dec: Angle.Degrees(-48.08284944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223442"},
        {"Hipparcos Number", "HIP 117504"},
        {"Smithsonian Astrophysical Observation", "SAO 231798"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.42289202),
        dec: Angle.Degrees(-48.08035415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94227"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.72713179),
        dec: Angle.Degrees(-48.07984582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176814"},
        {"Hipparcos Number", "HIP 93663"},
        {"Smithsonian Astrophysical Observation", "SAO 229470"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.09475211),
        dec: Angle.Degrees(-48.07850786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94223"},
    },
    visualMagnitude: 10.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.71922957),
        dec: Angle.Degrees(-48.07808902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -519.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6672"},
        {"Hipparcos Number", "HIP 5222"},
        {"Smithsonian Astrophysical Observation", "SAO 215370"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.69332576),
        dec: Angle.Degrees(-48.07797413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175196"},
        {"Hipparcos Number", "HIP 92985"},
        {"Smithsonian Astrophysical Observation", "SAO 229385"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.15733687),
        dec: Angle.Degrees(-48.07568819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135235"},
        {"Hipparcos Number", "HIP 74696"},
        {"Geneva Identification System", "GEN# +1.00135235J"},
        {"Renson", "Renson 38380"},
        {"Smithsonian Astrophysical Observation", "SAO 225590"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.97358944),
        dec: Angle.Degrees(-48.07364079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217709"},
        {"Hipparcos Number", "HIP 113836"},
        {"Smithsonian Astrophysical Observation", "SAO 231411"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.79120108),
        dec: Angle.Degrees(-48.07236444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125599"},
        {"Hipparcos Number", "HIP 70202"},
        {"Smithsonian Astrophysical Observation", "SAO 224862"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.45138888),
        dec: Angle.Degrees(-48.07183066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94241"},
        {"Hipparcos Number", "HIP 53102"},
        {"Smithsonian Astrophysical Observation", "SAO 222382"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.95489375),
        dec: Angle.Degrees(-48.07073992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186217"},
        {"Hipparcos Number", "HIP 97200"},
        {"Smithsonian Astrophysical Observation", "SAO 229848"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31852479),
        dec: Angle.Degrees(-48.07002710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202429"},
        {"Hipparcos Number", "HIP 105095"},
        {"Geneva Identification System", "GEN# +1.00202429"},
        {"Smithsonian Astrophysical Observation", "SAO 230611"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.33856407),
        dec: Angle.Degrees(-48.06907874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186835"},
        {"Hipparcos Number", "HIP 97497"},
        {"Smithsonian Astrophysical Observation", "SAO 229879"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.24750656),
        dec: Angle.Degrees(-48.06808966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74251"},
        {"Hipparcos Number", "HIP 42605"},
        {"Celescope Catalog", "CEL 2777"},
        {"Geneva Identification System", "GEN# +3.23950004"},
        {"Smithsonian Astrophysical Observation", "SAO 220279"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.25658562),
        dec: Angle.Degrees(-48.06750071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68477"},
        {"Hipparcos Number", "HIP 40019"},
        {"Celescope Catalog", "CEL 2208"},
        {"Geneva Identification System", "GEN# +1.00068477"},
        {"Smithsonian Astrophysical Observation", "SAO 219539"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.59896786),
        dec: Angle.Degrees(-48.06568500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41156"},
        {"Hipparcos Number", "HIP 28471"},
        {"Smithsonian Astrophysical Observation", "SAO 217669"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.16333225),
        dec: Angle.Degrees(-48.06505073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1379"},
        {"Hipparcos Number", "HIP 1426"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.45606981),
        dec: Angle.Degrees(-48.06271968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31172"},
        {"Hipparcos Number", "HIP 22547"},
        {"Smithsonian Astrophysical Observation", "SAO 217042"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.79454723),
        dec: Angle.Degrees(-48.06259769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92299"},
        {"Hipparcos Number", "HIP 52083"},
        {"Smithsonian Astrophysical Observation", "SAO 222216"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.63731577),
        dec: Angle.Degrees(-48.06228066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112121"},
        {"Hipparcos Number", "HIP 63009"},
        {"Geneva Identification System", "GEN# +1.00112121"},
        {"Smithsonian Astrophysical Observation", "SAO 223749"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.66685171),
        dec: Angle.Degrees(-48.06175587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23670"},
        {"Hipparcos Number", "HIP 17493"},
        {"Geneva Identification System", "GEN# +1.00023670"},
        {"Smithsonian Astrophysical Observation", "SAO 216469"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21027530),
        dec: Angle.Degrees(-48.06111837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103921"},
        {"Hipparcos Number", "HIP 58347"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49202108),
        dec: Angle.Degrees(-48.06058522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94996"},
        {"Hipparcos Number", "HIP 53555"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.33274363),
        dec: Angle.Degrees(-48.05806590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45922"},
        {"Hipparcos Number", "HIP 30763"},
        {"Smithsonian Astrophysical Observation", "SAO 217943"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.96298784),
        dec: Angle.Degrees(-48.05678168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58352"},
    },
    visualMagnitude: 12.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49686919),
        dec: Angle.Degrees(-48.05638300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107437"},
        {"Hipparcos Number", "HIP 60245"},
        {"Geneva Identification System", "GEN# +1.00107437"},
        {"Smithsonian Astrophysical Observation", "SAO 223369"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29893982),
        dec: Angle.Degrees(-48.05531014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2707"},
        {"Hipparcos Number", "HIP 2376"},
        {"Smithsonian Astrophysical Observation", "SAO 215118"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.58214290),
        dec: Angle.Degrees(-48.05368168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81636"},
        {"Hipparcos Number", "HIP 46206"},
        {"Smithsonian Astrophysical Observation", "SAO 221154"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.31533332),
        dec: Angle.Degrees(-48.05177912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84901"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.26549482),
        dec: Angle.Degrees(-48.04761444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110205"},
        {"Hipparcos Number", "HIP 61868"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.18224485),
        dec: Angle.Degrees(-48.04711971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159555"},
        {"Hipparcos Number", "HIP 86280"},
        {"Smithsonian Astrophysical Observation", "SAO 228208"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.44766117),
        dec: Angle.Degrees(-48.04586750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135310"},
        {"Hipparcos Number", "HIP 74725"},
        {"Smithsonian Astrophysical Observation", "SAO 225601"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.07129430),
        dec: Angle.Degrees(-48.04460741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147894"},
        {"Hipparcos Number", "HIP 80557"},
        {"Geneva Identification System", "GEN# +1.00147894J"},
        {"Smithsonian Astrophysical Observation", "SAO 226767"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.70770053),
        dec: Angle.Degrees(-48.04429358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65272"},
        {"Hipparcos Number", "HIP 38729"},
        {"Geneva Identification System", "GEN# +1.00065272"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.93667973),
        dec: Angle.Degrees(-48.04174184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44277"},
        {"Hipparcos Number", "HIP 29963"},
        {"Smithsonian Astrophysical Observation", "SAO 217838"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.61222202),
        dec: Angle.Degrees(-48.03863581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208338"},
        {"Hipparcos Number", "HIP 108332"},
        {"Smithsonian Astrophysical Observation", "SAO 230907"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.22372205),
        dec: Angle.Degrees(-48.03850801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13107"},
        {"Hipparcos Number", "HIP 9863"},
        {"Geneva Identification System", "GEN# +1.00013107"},
        {"Renson", "Renson 3400"},
        {"Smithsonian Astrophysical Observation", "SAO 215774"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.72514351),
        dec: Angle.Degrees(-48.03651982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92680"},
        {"Hipparcos Number", "HIP 52300"},
        {"Smithsonian Astrophysical Observation", "SAO 222258"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.29337216),
        dec: Angle.Degrees(-48.03551937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30517"},
        {"Hipparcos Number", "HIP 22142"},
        {"Geneva Identification System", "GEN# +1.00030517"},
        {"Smithsonian Astrophysical Observation", "SAO 216985"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.47472303),
        dec: Angle.Degrees(-48.03541947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63809"},
        {"Hipparcos Number", "HIP 38105"},
        {"Geneva Identification System", "GEN# +1.00063809"},
        {"Smithsonian Astrophysical Observation", "SAO 219023"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.13354007),
        dec: Angle.Degrees(-48.03541604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34727"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.85796092),
        dec: Angle.Degrees(-48.03540458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112263"},
        {"Hipparcos Number", "HIP 63120"},
        {"Geneva Identification System", "GEN# +1.00112263"},
        {"Smithsonian Astrophysical Observation", "SAO 223763"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.00037645),
        dec: Angle.Degrees(-48.03517885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211587"},
        {"Hipparcos Number", "HIP 110188"},
        {"Smithsonian Astrophysical Observation", "SAO 231077"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.78689146),
        dec: Angle.Degrees(-48.03493156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55615"},
        {"Hipparcos Number", "HIP 34699"},
        {"Smithsonian Astrophysical Observation", "SAO 218516"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.81017720),
        dec: Angle.Degrees(-48.03350870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64661"},
        {"Hipparcos Number", "HIP 38466"},
        {"Smithsonian Astrophysical Observation", "SAO 219100"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19062219),
        dec: Angle.Degrees(-48.03104693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180837"},
        {"Hipparcos Number", "HIP 95041"},
        {"Smithsonian Astrophysical Observation", "SAO 229622"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.07443150),
        dec: Angle.Degrees(-48.02927725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119896"},
        {"Hipparcos Number", "HIP 67256"},
        {"Geneva Identification System", "GEN# +1.00119896"},
        {"Smithsonian Astrophysical Observation", "SAO 224416"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.78287214),
        dec: Angle.Degrees(-48.02871266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274735"},
        {"Hipparcos Number", "HIP 24928"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.11268588),
        dec: Angle.Degrees(-48.02828608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72253"},
        {"Hipparcos Number", "HIP 41668"},
        {"Celescope Catalog", "CEL 2574"},
        {"Geneva Identification System", "GEN# +1.00072253"},
        {"Smithsonian Astrophysical Observation", "SAO 220008"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.43177983),
        dec: Angle.Degrees(-48.02629264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330123"},
        {"Hipparcos Number", "HIP 78091"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17402409),
        dec: Angle.Degrees(-48.02512223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92626"},
        {"Hipparcos Number", "HIP 52271"},
        {"Geneva Identification System", "GEN# +1.00092626"},
        {"Smithsonian Astrophysical Observation", "SAO 222254"},
        {"Wilson Evans Batten Catalogue", "WEB 9518"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.20838835),
        dec: Angle.Degrees(-48.02510767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146573"},
        {"Hipparcos Number", "HIP 79950"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.79341317),
        dec: Angle.Degrees(-48.02487340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128344"},
        {"Hipparcos Number", "HIP 71538"},
        {"Geneva Identification System", "GEN# +1.00128344"},
        {"Smithsonian Astrophysical Observation", "SAO 225073"},
        {"Wilson Evans Batten Catalogue", "WEB 12338"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.47874475),
        dec: Angle.Degrees(-48.02353154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330798"},
        {"Hipparcos Number", "HIP 80728"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.22344525),
        dec: Angle.Degrees(-48.02320461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90783"},
        {"Hipparcos Number", "HIP 51236"},
        {"Geneva Identification System", "GEN# +1.00090783"},
        {"Smithsonian Astrophysical Observation", "SAO 222079"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.98271407),
        dec: Angle.Degrees(-48.02097114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19716"},
        {"Hipparcos Number", "HIP 14609"},
        {"Geneva Identification System", "GEN# +1.00019716"},
        {"Smithsonian Astrophysical Observation", "SAO 216182"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.16757228),
        dec: Angle.Degrees(-48.01641309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88876"},
        {"Hipparcos Number", "HIP 50111"},
        {"Smithsonian Astrophysical Observation", "SAO 221884"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46272111),
        dec: Angle.Degrees(-48.01617391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184842"},
        {"Hipparcos Number", "HIP 96613"},
        {"Smithsonian Astrophysical Observation", "SAO 229786"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.62757065),
        dec: Angle.Degrees(-48.01575285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170283"},
        {"Hipparcos Number", "HIP 90743"},
        {"Geneva Identification System", "GEN# +1.00170283"},
        {"Smithsonian Astrophysical Observation", "SAO 229077"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.73456523),
        dec: Angle.Degrees(-48.01476179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88382"},
        {"Hipparcos Number", "HIP 49823"},
        {"Smithsonian Astrophysical Observation", "SAO 221826"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.56013378),
        dec: Angle.Degrees(-48.01404716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154250"},
        {"Hipparcos Number", "HIP 83722"},
        {"Geneva Identification System", "GEN# +1.00154250"},
        {"Smithsonian Astrophysical Observation", "SAO 227625"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.67077401),
        dec: Angle.Degrees(-48.01207914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222182"},
        {"Hipparcos Number", "HIP 116663"},
        {"Smithsonian Astrophysical Observation", "SAO 231711"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.63139928),
        dec: Angle.Degrees(-48.01080366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195142"},
        {"Hipparcos Number", "HIP 101264"},
        {"Smithsonian Astrophysical Observation", "SAO 230252"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.88687633),
        dec: Angle.Degrees(-48.00838243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161254"},
        {"Hipparcos Number", "HIP 87018"},
        {"Smithsonian Astrophysical Observation", "SAO 228399"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71265215),
        dec: Angle.Degrees(-48.00823691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3302"},
        {"Hipparcos Number", "HIP 2802"},
        {"Geneva Identification System", "GEN# +1.00003302"},
        {"Smithsonian Astrophysical Observation", "SAO 215157"},
        {"Wilson Evans Batten Catalogue", "WEB 504"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.92139531),
        dec: Angle.Degrees(-48.00066027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73478"},
        {"Hipparcos Number", "HIP 42242"},
        {"Celescope Catalog", "CEL 2703"},
        {"Geneva Identification System", "GEN# +1.00073478"},
        {"Smithsonian Astrophysical Observation", "SAO 220182"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.17815084),
        dec: Angle.Degrees(-47.99841700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204304"},
        {"Hipparcos Number", "HIP 106076"},
        {"Smithsonian Astrophysical Observation", "SAO 230707"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.30402461),
        dec: Angle.Degrees(-47.99746365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9629"},
        {"Hipparcos Number", "HIP 7258"},
        {"Smithsonian Astrophysical Observation", "SAO 215558"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.38490935),
        dec: Angle.Degrees(-47.99534399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188706"},
        {"Hipparcos Number", "HIP 98330"},
        {"Smithsonian Astrophysical Observation", "SAO 229957"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.66773522),
        dec: Angle.Degrees(-47.99486637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211691"},
        {"Hipparcos Number", "HIP 110243"},
        {"Smithsonian Astrophysical Observation", "SAO 231082"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.96054408),
        dec: Angle.Degrees(-47.99296179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216292"},
        {"Hipparcos Number", "HIP 112940"},
        {"Smithsonian Astrophysical Observation", "SAO 231333"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.11291856),
        dec: Angle.Degrees(-47.99287613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89094"},
        {"Hipparcos Number", "HIP 50243"},
        {"Smithsonian Astrophysical Observation", "SAO 221911"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.88514031),
        dec: Angle.Degrees(-47.99285139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126759"},
        {"Hipparcos Number", "HIP 70809"},
        {"Geneva Identification System", "GEN# +1.00126759"},
        {"Renson", "Renson 36090"},
        {"Smithsonian Astrophysical Observation", "SAO 224950"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.21636257),
        dec: Angle.Degrees(-47.99203907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4575"},
        {"Hipparcos Number", "HIP 3686"},
        {"Smithsonian Astrophysical Observation", "SAO 215238"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.81023441),
        dec: Angle.Degrees(-47.99043698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149098"},
        {"Hipparcos Number", "HIP 81180"},
        {"Smithsonian Astrophysical Observation", "SAO 226920"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.71869235),
        dec: Angle.Degrees(-47.98978142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4140"},
        {"Hipparcos Number", "HIP 3404"},
        {"Geneva Identification System", "GEN# +1.00004140"},
        {"Smithsonian Astrophysical Observation", "SAO 215210"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.83781588),
        dec: Angle.Degrees(-47.98939664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167732"},
        {"Hipparcos Number", "HIP 89752"},
        {"Smithsonian Astrophysical Observation", "SAO 228897"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.74230334),
        dec: Angle.Degrees(-47.98929368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222537"},
        {"Hipparcos Number", "HIP 116890"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.39524674),
        dec: Angle.Degrees(-47.98912279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133612"},
        {"Hipparcos Number", "HIP 73988"},
        {"Geneva Identification System", "GEN# +1.00133612"},
        {"Smithsonian Astrophysical Observation", "SAO 225453"},
        {"Wilson Evans Batten Catalogue", "WEB 12634"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.80807155),
        dec: Angle.Degrees(-47.98819167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140264"},
        {"Hipparcos Number", "HIP 77107"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.16596122),
        dec: Angle.Degrees(-47.98786799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68728"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.03050973),
        dec: Angle.Degrees(-47.98764603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74853"},
        {"Hipparcos Number", "HIP 42900"},
        {"Fundamental Katalog 5th Edition", "FK5 4784"},
        {"Geneva Identification System", "GEN# +1.00074853"},
        {"Smithsonian Astrophysical Observation", "SAO 220382"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.13150418),
        dec: Angle.Degrees(-47.98595063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103583"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.81821169),
        dec: Angle.Degrees(-47.98316534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35689"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.45865646),
        dec: Angle.Degrees(-47.98171036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28825"},
        {"Hipparcos Number", "HIP 21001"},
        {"Smithsonian Astrophysical Observation", "SAO 216841"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.55590355),
        dec: Angle.Degrees(-47.97851795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133117"},
        {"Hipparcos Number", "HIP 73742"},
        {"Smithsonian Astrophysical Observation", "SAO 225415"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.10786837),
        dec: Angle.Degrees(-47.97700187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103975"},
        {"Hipparcos Number", "HIP 58380"},
        {"Geneva Identification System", "GEN# +1.00103975"},
        {"Smithsonian Astrophysical Observation", "SAO 223138"},
        {"Wilson Evans Batten Catalogue", "WEB 10437"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.56550630),
        dec: Angle.Degrees(-47.97689113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207314"},
        {"Hipparcos Number", "HIP 107731"},
        {"Geneva Identification System", "GEN# +1.00207314"},
        {"Smithsonian Astrophysical Observation", "SAO 230852"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.35315809),
        dec: Angle.Degrees(-47.97662586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -355.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100120"},
        {"Hipparcos Number", "HIP 56169"},
        {"Smithsonian Astrophysical Observation", "SAO 222831"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72040963),
        dec: Angle.Degrees(-47.97623987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26761"},
        {"Hipparcos Number", "HIP 19580"},
        {"Geneva Identification System", "GEN# +1.00026761"},
        {"Smithsonian Astrophysical Observation", "SAO 216686"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.94325974),
        dec: Angle.Degrees(-47.97619778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99151"},
        {"Hipparcos Number", "HIP 55659"},
        {"Smithsonian Astrophysical Observation", "SAO 222771"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.05605608),
        dec: Angle.Degrees(-47.97584118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2249"},
        {"Hipparcos Number", "HIP 2065"},
        {"Smithsonian Astrophysical Observation", "SAO 215091"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.53351253),
        dec: Angle.Degrees(-47.97439645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60731"},
        {"Hipparcos Number", "HIP 36763"},
        {"Smithsonian Astrophysical Observation", "SAO 218800"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.41175831),
        dec: Angle.Degrees(-47.97396321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117313"},
        {"Hipparcos Number", "HIP 65888"},
        {"Smithsonian Astrophysical Observation", "SAO 224198"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.59485682),
        dec: Angle.Degrees(-47.97285396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90034B"},
        {"Hipparcos Number", "HIP 50798"},
        {"Smithsonian Astrophysical Observation", "SAO 221999"},
    },
    visualMagnitude: 11.49,
    bvColour: 3.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.58281140),
        dec: Angle.Degrees(-47.97281127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90034"},
        {"Hipparcos Number", "HIP 50804"},
        {"Smithsonian Astrophysical Observation", "SAO 222001"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.59157956),
        dec: Angle.Degrees(-47.97150730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150910"},
        {"Hipparcos Number", "HIP 82106"},
        {"Smithsonian Astrophysical Observation", "SAO 227174"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56867402),
        dec: Angle.Degrees(-47.97122463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221374"},
        {"Hipparcos Number", "HIP 116137"},
        {"Smithsonian Astrophysical Observation", "SAO 231646"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.97363462),
        dec: Angle.Degrees(-47.97120311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101990"},
        {"Hipparcos Number", "HIP 57233"},
        {"Smithsonian Astrophysical Observation", "SAO 222985"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01810368),
        dec: Angle.Degrees(-47.97041496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85452"},
        {"Hipparcos Number", "HIP 48277"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62919022),
        dec: Angle.Degrees(-47.97040827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112193"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.84907573),
        dec: Angle.Degrees(-47.96963065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37509"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.46870660),
        dec: Angle.Degrees(-47.96948615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216823"},
        {"Hipparcos Number", "HIP 113307"},
        {"Fundamental Katalog 5th Edition", "FK5 3832"},
        {"Geneva Identification System", "GEN# +1.00216823"},
        {"Renson", "Renson 59850"},
        {"Smithsonian Astrophysical Observation", "SAO 231364"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.19925894),
        dec: Angle.Degrees(-47.96922586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80572"},
        {"Hipparcos Number", "HIP 45703"},
        {"Geneva Identification System", "GEN# +1.00080572"},
        {"Smithsonian Astrophysical Observation", "SAO 221060"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.75172619),
        dec: Angle.Degrees(-47.96826116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144383"},
        {"Hipparcos Number", "HIP 79023"},
        {"Smithsonian Astrophysical Observation", "SAO 226520"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93994044),
        dec: Angle.Degrees(-47.96657202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83803"},
        {"Smithsonian Astrophysical Observation", "SAO 160292"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.89822001),
        dec: Angle.Degrees(-17.41355261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37572"},
        {"Hipparcos Number", "HIP 26373"},
        {"Geneva Identification System", "GEN# +1.00037572"},
        {"Smithsonian Astrophysical Observation", "SAO 217430"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.23680224),
        dec: Angle.Degrees(-47.96468727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56898"},
        {"Geneva Identification System", "GEN# -0.04707032"},
        {"Wilson Evans Batten Catalogue", "WEB 10247"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.95977046),
        dec: Angle.Degrees(-47.96422276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26369"},
        {"Smithsonian Astrophysical Observation", "SAO 217429"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22945424),
        dec: Angle.Degrees(-47.96338316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194251"},
        {"Hipparcos Number", "HIP 100825"},
        {"Smithsonian Astrophysical Observation", "SAO 230202"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.65959404),
        dec: Angle.Degrees(-47.96167019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89681"},
        {"Hipparcos Number", "HIP 50574"},
        {"Smithsonian Astrophysical Observation", "SAO 221961"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.96569567),
        dec: Angle.Degrees(-47.96123685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200248"},
        {"Hipparcos Number", "HIP 103988"},
        {"Smithsonian Astrophysical Observation", "SAO 230501"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.03378113),
        dec: Angle.Degrees(-47.96088224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213173"},
        {"Hipparcos Number", "HIP 111107"},
        {"Smithsonian Astrophysical Observation", "SAO 231169"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.62852582),
        dec: Angle.Degrees(-47.96076868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220417"},
        {"Hipparcos Number", "HIP 115515"},
        {"Smithsonian Astrophysical Observation", "SAO 231589"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.99606897),
        dec: Angle.Degrees(-47.96060302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132121"},
        {"Hipparcos Number", "HIP 73329"},
        {"Smithsonian Astrophysical Observation", "SAO 225340"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.77226258),
        dec: Angle.Degrees(-47.95756639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36903"},
        {"Hipparcos Number", "HIP 25968"},
        {"Smithsonian Astrophysical Observation", "SAO 217389"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.10032845),
        dec: Angle.Degrees(-47.95732761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39918"},
        {"Hipparcos Number", "HIP 27818"},
        {"Smithsonian Astrophysical Observation", "SAO 217598"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28985829),
        dec: Angle.Degrees(-47.95523910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205369"},
        {"Hipparcos Number", "HIP 106652"},
        {"Smithsonian Astrophysical Observation", "SAO 230745"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.04103138),
        dec: Angle.Degrees(-47.95514617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58492"},
        {"Hipparcos Number", "HIP 35853"},
        {"Geneva Identification System", "GEN# +1.00058492"},
        {"Smithsonian Astrophysical Observation", "SAO 218692"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.87860104),
        dec: Angle.Degrees(-47.95486165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166751"},
        {"Hipparcos Number", "HIP 89386"},
        {"Smithsonian Astrophysical Observation", "SAO 228831"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.61103373),
        dec: Angle.Degrees(-47.95445172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82578"},
        {"Hipparcos Number", "HIP 46709"},
        {"Geneva Identification System", "GEN# +1.00082578"},
        {"Smithsonian Astrophysical Observation", "SAO 221246"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.82911315),
        dec: Angle.Degrees(-47.95253268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73332"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.78317165),
        dec: Angle.Degrees(-47.94970675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155408"},
        {"Hipparcos Number", "HIP 84278"},
        {"Smithsonian Astrophysical Observation", "SAO 227724"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.42170052),
        dec: Angle.Degrees(-47.94891287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106473"},
        {"Hipparcos Number", "HIP 59724"},
        {"Geneva Identification System", "GEN# +1.00106473"},
        {"Smithsonian Astrophysical Observation", "SAO 223304"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.73496437),
        dec: Angle.Degrees(-47.94846327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85356"},
        {"Hipparcos Number", "HIP 48228"},
        {"Geneva Identification System", "GEN# +1.00085356"},
        {"Smithsonian Astrophysical Observation", "SAO 221525"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.49514360),
        dec: Angle.Degrees(-47.94766194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96426"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.06166353),
        dec: Angle.Degrees(-47.94745593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -367.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89356"},
        {"Hipparcos Number", "HIP 50407"},
        {"Smithsonian Astrophysical Observation", "SAO 221936"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.38892662),
        dec: Angle.Degrees(-47.94726457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224196"},
        {"Hipparcos Number", "HIP 117992"},
        {"Smithsonian Astrophysical Observation", "SAO 231852"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.00184636),
        dec: Angle.Degrees(-47.94359586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116197"},
        {"Hipparcos Number", "HIP 65288"},
        {"Geneva Identification System", "GEN# +1.00116197J"},
        {"Smithsonian Astrophysical Observation", "SAO 224095"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.71874490),
        dec: Angle.Degrees(-47.94321927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109880"},
        {"Hipparcos Number", "HIP 61670"},
        {"Geneva Identification System", "GEN# +1.00109880"},
        {"Smithsonian Astrophysical Observation", "SAO 223565"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.63293621),
        dec: Angle.Degrees(-47.94284513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192861"},
        {"Hipparcos Number", "HIP 100177"},
        {"Smithsonian Astrophysical Observation", "SAO 230148"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79390243),
        dec: Angle.Degrees(-47.94275953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132840"},
        {"Hipparcos Number", "HIP 73622"},
        {"Fundamental Katalog 5th Edition", "FK5 5337"},
        {"Smithsonian Astrophysical Observation", "SAO 225399"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.73928007),
        dec: Angle.Degrees(-47.94196263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157723"},
        {"Hipparcos Number", "HIP 85424"},
        {"Smithsonian Astrophysical Observation", "SAO 227979"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.83912324),
        dec: Angle.Degrees(-47.94140014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6413"},
        {"Hipparcos Number", "HIP 5026"},
        {"Geneva Identification System", "GEN# +1.00006413"},
        {"Smithsonian Astrophysical Observation", "SAO 215353"},
        {"Wilson Evans Batten Catalogue", "WEB 1028"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.09960224),
        dec: Angle.Degrees(-47.94036979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9176"},
        {"Hipparcos Number", "HIP 6935"},
        {"Smithsonian Astrophysical Observation", "SAO 215523"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.34287885),
        dec: Angle.Degrees(-47.93963061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68324"},
        {"Hipparcos Number", "HIP 39970"},
        {"Celescope Catalog", "CEL 2195"},
        {"Geneva Identification System", "GEN# +1.00068324"},
        {"Smithsonian Astrophysical Observation", "SAO 219515"},
        {"Smithsonian Astrophysical Observation 2", "SAO 219513"},
        {"Wilson Evans Batten Catalogue", "WEB 7793"},
    },
    visualMagnitude: 5.23,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.42983160),
        dec: Angle.Degrees(-47.93721650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274939"},
        {"Hipparcos Number", "HIP 26040"},
        {"Geneva Identification System", "GEN# +1.00274939"},
        {"Smithsonian Astrophysical Observation", "SAO 217399"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32478265),
        dec: Angle.Degrees(-47.93687603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209630"},
        {"Hipparcos Number", "HIP 109109"},
        {"Smithsonian Astrophysical Observation", "SAO 230974"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.52020079),
        dec: Angle.Degrees(-47.93526443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21387"},
        {"Hipparcos Number", "HIP 15921"},
        {"Smithsonian Astrophysical Observation", "SAO 216308"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.25400557),
        dec: Angle.Degrees(-47.93508878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10162"},
        {"Hipparcos Number", "HIP 7628"},
        {"Geneva Identification System", "GEN# +1.00010162"},
        {"Smithsonian Astrophysical Observation", "SAO 215591"},
        {"Wilson Evans Batten Catalogue", "WEB 1631"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.56723464),
        dec: Angle.Degrees(-47.93487501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204064"},
        {"Hipparcos Number", "HIP 105961"},
        {"Smithsonian Astrophysical Observation", "SAO 230696"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.88664529),
        dec: Angle.Degrees(-47.93313599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83595"},
        {"Hipparcos Number", "HIP 47290"},
        {"Smithsonian Astrophysical Observation", "SAO 221358"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55732820),
        dec: Angle.Degrees(-47.93308338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15772"},
        {"Hipparcos Number", "HIP 11676"},
        {"Smithsonian Astrophysical Observation", "SAO 215926"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.65487612),
        dec: Angle.Degrees(-47.93120896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7395"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.83503217),
        dec: Angle.Degrees(-47.93050567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72108"},
        {"Hipparcos Number", "HIP 41616"},
        {"Celescope Catalog", "CEL 2557"},
        {"Geneva Identification System", "GEN# +1.00072108J"},
        {"Smithsonian Astrophysical Observation", "SAO 219985"},
        {"Wilson Evans Batten Catalogue", "WEB 8032"},
    },
    visualMagnitude: 5.33,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.26982565),
        dec: Angle.Degrees(-47.92893948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136351"},
        {"Hipparcos Number", "HIP 75206"},
        {"Fundamental Katalog 5th Edition", "FK5 3211"},
        {"Geneva Identification System", "GEN# +1.00136351"},
        {"Smithsonian Astrophysical Observation", "SAO 225703"},
        {"Wilson Evans Batten Catalogue", "WEB 12828"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.53497528),
        dec: Angle.Degrees(-47.92746963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17157"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.12209173),
        dec: Angle.Degrees(-47.92538868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98022"},
        {"Hipparcos Number", "HIP 55019"},
        {"Geneva Identification System", "GEN# +1.00098022"},
        {"Smithsonian Astrophysical Observation", "SAO 222682"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97373976),
        dec: Angle.Degrees(-47.92083433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136466"},
        {"Hipparcos Number", "HIP 75255"},
        {"Cincinnati Publication", "Ci 20 928"},
        {"Geneva Identification System", "GEN# +1.00136466J"},
        {"Smithsonian Astrophysical Observation", "SAO 225709"},
        {"Wilson Evans Batten Catalogue", "WEB 12834"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65328107),
        dec: Angle.Degrees(-47.92042125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -364.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137958"},
        {"Hipparcos Number", "HIP 75980"},
        {"Geneva Identification System", "GEN# +1.00137958"},
        {"Smithsonian Astrophysical Observation", "SAO 225853"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.74535951),
        dec: Angle.Degrees(-47.92029659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69973"},
        {"Hipparcos Number", "HIP 40600"},
        {"Celescope Catalog", "CEL 2325"},
        {"Geneva Identification System", "GEN# +1.00069973"},
        {"Smithsonian Astrophysical Observation", "SAO 219740"},
        {"Wilson Evans Batten Catalogue", "WEB 7896"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.33159413),
        dec: Angle.Degrees(-47.92010179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88755"},
        {"Hipparcos Number", "HIP 50047"},
        {"Smithsonian Astrophysical Observation", "SAO 221869"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.27032718),
        dec: Angle.Degrees(-47.91960479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78459"},
        {"Hipparcos Number", "HIP 44709"},
        {"Smithsonian Astrophysical Observation", "SAO 220860"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.64366987),
        dec: Angle.Degrees(-47.91929679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198531"},
        {"Hipparcos Number", "HIP 103056"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18947522),
        dec: Angle.Degrees(-47.91840253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15049"},
        {"Hipparcos Number", "HIP 11181"},
        {"Geneva Identification System", "GEN# +1.00015049"},
        {"Smithsonian Astrophysical Observation", "SAO 215889"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.99901115),
        dec: Angle.Degrees(-47.91805055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183807"},
        {"Hipparcos Number", "HIP 96190"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.37817492),
        dec: Angle.Degrees(-47.91549618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17611"},
        {"Hipparcos Number", "HIP 13060"},
        {"Smithsonian Astrophysical Observation", "SAO 216050"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.96448094),
        dec: Angle.Degrees(-47.91435791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157597"},
        {"Hipparcos Number", "HIP 85358"},
        {"Smithsonian Astrophysical Observation", "SAO 227960"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.63807485),
        dec: Angle.Degrees(-47.91429093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144899"},
        {"Hipparcos Number", "HIP 79240"},
        {"Geneva Identification System", "GEN# +1.00144899"},
        {"Smithsonian Astrophysical Observation", "SAO 226553"},
        {"Wilson Evans Batten Catalogue", "WEB 13396"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.57306745),
        dec: Angle.Degrees(-47.91407602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196842"},
        {"Hipparcos Number", "HIP 102136"},
        {"Smithsonian Astrophysical Observation", "SAO 230326"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.45193831),
        dec: Angle.Degrees(-47.91268482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10400"},
        {"Hipparcos Number", "HIP 7800"},
        {"Smithsonian Astrophysical Observation", "SAO 215611"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09525156),
        dec: Angle.Degrees(-47.91267020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85185"},
        {"Hipparcos Number", "HIP 48155"},
        {"Smithsonian Astrophysical Observation", "SAO 221509"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.23564470),
        dec: Angle.Degrees(-47.91252523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87539"},
        {"Hipparcos Number", "HIP 49346"},
        {"Smithsonian Astrophysical Observation", "SAO 221750"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.10513177),
        dec: Angle.Degrees(-47.91218540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155571"},
        {"Hipparcos Number", "HIP 84361"},
        {"Smithsonian Astrophysical Observation", "SAO 227739"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.70898207),
        dec: Angle.Degrees(-47.91102575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218192"},
        {"Hipparcos Number", "HIP 114109"},
        {"Smithsonian Astrophysical Observation", "SAO 231441"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.65881832),
        dec: Angle.Degrees(-47.91030791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91993"},
        {"Hipparcos Number", "HIP 51916"},
        {"Smithsonian Astrophysical Observation", "SAO 222189"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09105182),
        dec: Angle.Degrees(-47.91026610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171819"},
        {"Hipparcos Number", "HIP 91461"},
        {"Fundamental Katalog 5th Edition", "FK5 3482"},
        {"Geneva Identification System", "GEN# +1.00171819"},
        {"Renson", "Renson 48150"},
        {"Smithsonian Astrophysical Observation", "SAO 229165"},
        {"Wilson Evans Batten Catalogue", "WEB 15720"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.80946248),
        dec: Angle.Degrees(-47.90980354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75150"},
        {"Hipparcos Number", "HIP 43069"},
        {"Geneva Identification System", "GEN# +1.00075150"},
        {"Smithsonian Astrophysical Observation", "SAO 220438"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59438449),
        dec: Angle.Degrees(-47.90912667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201622"},
        {"Hipparcos Number", "HIP 104693"},
        {"Smithsonian Astrophysical Observation", "SAO 230576"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.11062245),
        dec: Angle.Degrees(-47.90905223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20915"},
        {"Hipparcos Number", "HIP 15559"},
        {"Smithsonian Astrophysical Observation", "SAO 216272"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.11158728),
        dec: Angle.Degrees(-47.90867158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222911"},
        {"Hipparcos Number", "HIP 117149"},
        {"Smithsonian Astrophysical Observation", "SAO 231762"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.24464469),
        dec: Angle.Degrees(-47.90302063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75287"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.72956103),
        dec: Angle.Degrees(-47.90087150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135669"},
        {"Hipparcos Number", "HIP 74876"},
        {"Geneva Identification System", "GEN# +1.00135669"},
        {"Smithsonian Astrophysical Observation", "SAO 225627"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54081000),
        dec: Angle.Degrees(-47.89995355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179033"},
        {"Hipparcos Number", "HIP 94446"},
        {"Smithsonian Astrophysical Observation", "SAO 229556"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.32688428),
        dec: Angle.Degrees(-47.89974209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84898"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.26025636),
        dec: Angle.Degrees(-47.89858602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8821"},
        {"Hipparcos Number", "HIP 6693"},
        {"Geneva Identification System", "GEN# +1.00008821"},
        {"Smithsonian Astrophysical Observation", "SAO 215503"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.48385548),
        dec: Angle.Degrees(-47.89856863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217708"},
        {"Hipparcos Number", "HIP 113833"},
        {"Smithsonian Astrophysical Observation", "SAO 231410"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.78086623),
        dec: Angle.Degrees(-47.89663211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23870"},
        {"Hipparcos Number", "HIP 17606"},
        {"Smithsonian Astrophysical Observation", "SAO 216482"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.57638843),
        dec: Angle.Degrees(-47.89432492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190373"},
        {"Hipparcos Number", "HIP 99071"},
        {"Smithsonian Astrophysical Observation", "SAO 230042"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69465604),
        dec: Angle.Degrees(-47.89346961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65598"},
        {"Hipparcos Number", "HIP 38879"},
        {"Celescope Catalog", "CEL 2113"},
        {"Geneva Identification System", "GEN# +1.00065598J"},
        {"Smithsonian Astrophysical Observation", "SAO 219200"},
        {"Wilson Evans Batten Catalogue", "WEB 7615"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.33365125),
        dec: Angle.Degrees(-47.89072855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116337"},
        {"Hipparcos Number", "HIP 65373"},
        {"Geneva Identification System", "GEN# +1.00116337"},
        {"Smithsonian Astrophysical Observation", "SAO 224106"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.96965759),
        dec: Angle.Degrees(-47.89048851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273763"},
        {"Hipparcos Number", "HIP 23691"},
        {"Geneva Identification System", "GEN# +1.00273763"},
        {"Renson", "Renson 8460"},
        {"Wilson Evans Batten Catalogue", "WEB 4622"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.37387086),
        dec: Angle.Degrees(-47.88965599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143138"},
        {"Hipparcos Number", "HIP 78432"},
        {"Geneva Identification System", "GEN# +1.00143138"},
        {"Smithsonian Astrophysical Observation", "SAO 226438"},
        {"Wilson Evans Batten Catalogue", "WEB 13256"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.18184583),
        dec: Angle.Degrees(-47.88936356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111969"},
        {"Hipparcos Number", "HIP 62903"},
        {"Smithsonian Astrophysical Observation", "SAO 223736"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.38279322),
        dec: Angle.Degrees(-47.88840705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92138"},
        {"Hipparcos Number", "HIP 51981"},
        {"Smithsonian Astrophysical Observation", "SAO 222198"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.31533754),
        dec: Angle.Degrees(-47.88821721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4170"},
        {"Hipparcos Number", "HIP 3425"},
        {"Smithsonian Astrophysical Observation", "SAO 215213"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.90698703),
        dec: Angle.Degrees(-47.88598417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182750"},
        {"Hipparcos Number", "HIP 95742"},
        {"Smithsonian Astrophysical Observation", "SAO 229696"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.10628440),
        dec: Angle.Degrees(-47.88218775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1041"},
        {"Hipparcos Number", "HIP 1165"},
        {"Smithsonian Astrophysical Observation", "SAO 215014"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.64570122),
        dec: Angle.Degrees(-47.88140617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159041"},
        {"Hipparcos Number", "HIP 86026"},
        {"Smithsonian Astrophysical Observation", "SAO 228140"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.71279537),
        dec: Angle.Degrees(-47.87917752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131657"},
        {"Hipparcos Number", "HIP 73111"},
        {"Celescope Catalog", "CEL 4327"},
        {"Geneva Identification System", "GEN# +1.00131657"},
        {"Smithsonian Astrophysical Observation", "SAO 225306"},
        {"Wilson Evans Batten Catalogue", "WEB 12532"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.13366538),
        dec: Angle.Degrees(-47.87914321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135748"},
        {"Hipparcos Number", "HIP 74915"},
        {"Geneva Identification System", "GEN# +1.00135748"},
        {"Smithsonian Astrophysical Observation", "SAO 225639"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.64084875),
        dec: Angle.Degrees(-47.87913291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181897"},
        {"Hipparcos Number", "HIP 95411"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.13240520),
        dec: Angle.Degrees(-47.87899742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137657"},
        {"Hipparcos Number", "HIP 75800"},
        {"Smithsonian Astrophysical Observation", "SAO 225823"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28452884),
        dec: Angle.Degrees(-47.87855339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125399"},
        {"Hipparcos Number", "HIP 70086"},
        {"Smithsonian Astrophysical Observation", "SAO 224840"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13482292),
        dec: Angle.Degrees(-47.87739567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117193"},
        {"Hipparcos Number", "HIP 65822"},
        {"Smithsonian Astrophysical Observation", "SAO 224179"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.40076249),
        dec: Angle.Degrees(-47.87578396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179522"},
        {"Hipparcos Number", "HIP 94614"},
        {"Geneva Identification System", "GEN# +1.00179522"},
        {"Smithsonian Astrophysical Observation", "SAO 229577"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.80813489),
        dec: Angle.Degrees(-47.87573381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135734"},
        {"Hipparcos Number", "HIP 74911"},
        {"Celescope Catalog", "CEL 4361"},
        {"Geneva Identification System", "GEN# +1.00135734J"},
        {"Smithsonian Astrophysical Observation", "SAO 225638"},
        {"Wilson Evans Batten Catalogue", "WEB 12776"},
    },
    visualMagnitude: 4.27,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63353586),
        dec: Angle.Degrees(-47.87519201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34245"},
        {"Hipparcos Number", "HIP 24346"},
        {"Smithsonian Astrophysical Observation", "SAO 217244"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.37168438),
        dec: Angle.Degrees(-47.87517231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39822"},
        {"Hipparcos Number", "HIP 27756"},
        {"Smithsonian Astrophysical Observation", "SAO 217590"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11848334),
        dec: Angle.Degrees(-47.87514816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40922"},
        {"Hipparcos Number", "HIP 28352"},
        {"Smithsonian Astrophysical Observation", "SAO 217654"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.86298784),
        dec: Angle.Degrees(-47.87310047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218050"},
        {"Hipparcos Number", "HIP 114040"},
        {"Geneva Identification System", "GEN# +1.00218050"},
        {"Smithsonian Astrophysical Observation", "SAO 231430"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.41526893),
        dec: Angle.Degrees(-47.87304012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 253.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67699"},
        {"Smithsonian Astrophysical Observation", "SAO 224496"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.00907846),
        dec: Angle.Degrees(-47.87183242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28301"},
        {"Hipparcos Number", "HIP 20654"},
        {"Smithsonian Astrophysical Observation", "SAO 216796"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.38608305),
        dec: Angle.Degrees(-47.87092498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72485"},
        {"Hipparcos Number", "HIP 41781"},
        {"Celescope Catalog", "CEL 2599"},
        {"Geneva Identification System", "GEN# +1.00072485"},
        {"Smithsonian Astrophysical Observation", "SAO 220039"},
        {"Wilson Evans Batten Catalogue", "WEB 8046"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.79432795),
        dec: Angle.Degrees(-47.86664025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136764"},
        {"Hipparcos Number", "HIP 75400"},
        {"Smithsonian Astrophysical Observation", "SAO 225740"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.09232080),
        dec: Angle.Degrees(-47.86612957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120675"},
        {"Hipparcos Number", "HIP 67700"},
        {"Smithsonian Astrophysical Observation", "SAO 224497"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.01216374),
        dec: Angle.Degrees(-47.86569099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208995"},
        {"Hipparcos Number", "HIP 108717"},
        {"Smithsonian Astrophysical Observation", "SAO 230941"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.34309420),
        dec: Angle.Degrees(-47.86561364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121292"},
        {"Hipparcos Number", "HIP 68017"},
        {"Geneva Identification System", "GEN# +1.00121292"},
        {"Smithsonian Astrophysical Observation", "SAO 224545"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.92457768),
        dec: Angle.Degrees(-47.86554132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135430"},
        {"Hipparcos Number", "HIP 74769"},
        {"Smithsonian Astrophysical Observation", "SAO 225613"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.21601775),
        dec: Angle.Degrees(-47.86449697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139615"},
        {"Hipparcos Number", "HIP 76823"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.27565979),
        dec: Angle.Degrees(-47.86221644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25860"},
        {"Hipparcos Number", "HIP 18950"},
        {"Geneva Identification System", "GEN# +1.00025860"},
        {"Smithsonian Astrophysical Observation", "SAO 216625"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91416499),
        dec: Angle.Degrees(-47.86191862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91555"},
        {"Hipparcos Number", "HIP 51678"},
        {"Smithsonian Astrophysical Observation", "SAO 222144"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.36456006),
        dec: Angle.Degrees(-47.85908249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54238"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45478960),
        dec: Angle.Degrees(-47.85907599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160195"},
        {"Hipparcos Number", "HIP 86531"},
        {"Geneva Identification System", "GEN# +1.00160195"},
        {"Smithsonian Astrophysical Observation", "SAO 228275"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.25018425),
        dec: Angle.Degrees(-47.85889909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19263"},
        {"Hipparcos Number", "HIP 14284"},
        {"Smithsonian Astrophysical Observation", "SAO 216158"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.03439411),
        dec: Angle.Degrees(-47.85678799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209805"},
        {"Hipparcos Number", "HIP 109194"},
        {"Smithsonian Astrophysical Observation", "SAO 230986"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.80231336),
        dec: Angle.Degrees(-47.85271595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154249"},
        {"Hipparcos Number", "HIP 83720"},
        {"Smithsonian Astrophysical Observation", "SAO 227624"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.66704324),
        dec: Angle.Degrees(-47.85183578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101247"},
        {"Hipparcos Number", "HIP 56814"},
        {"Smithsonian Astrophysical Observation", "SAO 222932"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.69923030),
        dec: Angle.Degrees(-47.85121038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103994"},
        {"Hipparcos Number", "HIP 58399"},
        {"Smithsonian Astrophysical Observation", "SAO 223141"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.61724766),
        dec: Angle.Degrees(-47.85055559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91981"},
        {"Hipparcos Number", "HIP 51908"},
        {"Geneva Identification System", "GEN# +1.00091981"},
        {"Smithsonian Astrophysical Observation", "SAO 222188"},
        {"Wilson Evans Batten Catalogue", "WEB 9474"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.07378209),
        dec: Angle.Degrees(-47.84993972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138676"},
        {"Hipparcos Number", "HIP 76328"},
        {"Geneva Identification System", "GEN# +1.00138676"},
        {"Smithsonian Astrophysical Observation", "SAO 225940"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.86809050),
        dec: Angle.Degrees(-47.84908750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60774"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.85900444),
        dec: Angle.Degrees(-47.84837334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217670"},
        {"Hipparcos Number", "HIP 113821"},
        {"Geneva Identification System", "GEN# +1.00217670"},
        {"Smithsonian Astrophysical Observation", "SAO 231409"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.73651542),
        dec: Angle.Degrees(-47.84828850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154221"},
        {"Hipparcos Number", "HIP 83707"},
        {"Geneva Identification System", "GEN# +1.00154221"},
        {"Smithsonian Astrophysical Observation", "SAO 227621"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62041256),
        dec: Angle.Degrees(-47.84569141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218390"},
        {"Hipparcos Number", "HIP 114241"},
        {"Smithsonian Astrophysical Observation", "SAO 231451"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.06333003),
        dec: Angle.Degrees(-47.84326490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117508"},
        {"Hipparcos Number", "HIP 65981"},
        {"Smithsonian Astrophysical Observation", "SAO 224219"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.91466765),
        dec: Angle.Degrees(-47.84098928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124326"},
        {"Hipparcos Number", "HIP 69557"},
        {"Smithsonian Astrophysical Observation", "SAO 224781"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.57152438),
        dec: Angle.Degrees(-47.84011675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25547"},
        {"Hipparcos Number", "HIP 18773"},
        {"Smithsonian Astrophysical Observation", "SAO 216603"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.32710363),
        dec: Angle.Degrees(-47.83713384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26044"},
        {"Hipparcos Number", "HIP 19071"},
        {"Smithsonian Astrophysical Observation", "SAO 216636"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.31343904),
        dec: Angle.Degrees(-47.83233337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154981"},
        {"Hipparcos Number", "HIP 84065"},
        {"Smithsonian Astrophysical Observation", "SAO 227691"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.79515919),
        dec: Angle.Degrees(-47.83168836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194293"},
        {"Hipparcos Number", "HIP 100850"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.71826894),
        dec: Angle.Degrees(-47.83161399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62295"},
        {"Hipparcos Number", "HIP 37432"},
        {"Smithsonian Astrophysical Observation", "SAO 218899"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.25462956),
        dec: Angle.Degrees(-47.83113569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107143"},
        {"Hipparcos Number", "HIP 60084"},
        {"Geneva Identification System", "GEN# +1.00107143"},
        {"Smithsonian Astrophysical Observation", "SAO 223351"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.81928413),
        dec: Angle.Degrees(-47.82999290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43901"},
        {"Hipparcos Number", "HIP 29781"},
        {"Geneva Identification System", "GEN# +1.00043901"},
        {"Renson", "Renson 11660"},
        {"Smithsonian Astrophysical Observation", "SAO 217823"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.05801718),
        dec: Angle.Degrees(-47.82948550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3869"},
        {"Hipparcos Number", "HIP 3207"},
        {"Smithsonian Astrophysical Observation", "SAO 215190"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.20669289),
        dec: Angle.Degrees(-47.82909577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11936"},
        {"Hipparcos Number", "HIP 8994"},
        {"Smithsonian Astrophysical Observation", "SAO 215705"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.96896455),
        dec: Angle.Degrees(-47.82797777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30065"},
        {"Hipparcos Number", "HIP 21849"},
        {"Smithsonian Astrophysical Observation", "SAO 216942"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.46583361),
        dec: Angle.Degrees(-47.82595220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97624"},
        {"Hipparcos Number", "HIP 54836"},
        {"Geneva Identification System", "GEN# +1.00097624"},
        {"Smithsonian Astrophysical Observation", "SAO 222651"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.39608778),
        dec: Angle.Degrees(-47.82365792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38459"},
        {"Hipparcos Number", "HIP 26973"},
        {"Geneva Identification System", "GEN# +1.00038459"},
        {"Smithsonian Astrophysical Observation", "SAO 217491"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.86004480),
        dec: Angle.Degrees(-47.82349630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 214.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45815"},
        {"Hipparcos Number", "HIP 30708"},
        {"Renson", "Renson 12220"},
        {"Smithsonian Astrophysical Observation", "SAO 217936"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.78791899),
        dec: Angle.Degrees(-47.82129294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207615"},
        {"Hipparcos Number", "HIP 107894"},
        {"Smithsonian Astrophysical Observation", "SAO 230868"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.90820219),
        dec: Angle.Degrees(-47.81910623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5011"},
        {"Hipparcos Number", "HIP 4018"},
        {"Smithsonian Astrophysical Observation", "SAO 215266"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.87595298),
        dec: Angle.Degrees(-47.81902310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68395"},
        {"Hipparcos Number", "HIP 39992"},
        {"Celescope Catalog", "CEL 2198"},
        {"Geneva Identification System", "GEN# +1.00068395"},
        {"Smithsonian Astrophysical Observation", "SAO 219529"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.50743785),
        dec: Angle.Degrees(-47.81830963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11332"},
        {"Hipparcos Number", "HIP 8552"},
        {"Geneva Identification System", "GEN# +1.00011332"},
        {"Smithsonian Astrophysical Observation", "SAO 215673"},
        {"Wilson Evans Batten Catalogue", "WEB 1818"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.58367053),
        dec: Angle.Degrees(-47.81650912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162089"},
        {"Hipparcos Number", "HIP 87397"},
        {"Geneva Identification System", "GEN# +1.00162089"},
        {"Smithsonian Astrophysical Observation", "SAO 228487"},
    },
    visualMagnitude: 9.26,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.90527045),
        dec: Angle.Degrees(-47.81613663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67041"},
        {"Hipparcos Number", "HIP 39461"},
        {"Geneva Identification System", "GEN# +1.00067041"},
        {"Smithsonian Astrophysical Observation", "SAO 219367"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.98349532),
        dec: Angle.Degrees(-47.81583720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79820"},
        {"Hipparcos Number", "HIP 45358"},
        {"Smithsonian Astrophysical Observation", "SAO 220986"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.64837855),
        dec: Angle.Degrees(-47.81388108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214124"},
        {"Hipparcos Number", "HIP 111645"},
        {"Smithsonian Astrophysical Observation", "SAO 231216"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.25070933),
        dec: Angle.Degrees(-47.81104926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224047"},
        {"Hipparcos Number", "HIP 117895"},
        {"Geneva Identification System", "GEN# +1.00224047"},
        {"Smithsonian Astrophysical Observation", "SAO 231843"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.70862965),
        dec: Angle.Degrees(-47.80806261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121804"},
        {"Hipparcos Number", "HIP 68298"},
        {"Smithsonian Astrophysical Observation", "SAO 224587"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.71763830),
        dec: Angle.Degrees(-47.80699936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49614"},
        {"Hipparcos Number", "HIP 32481"},
        {"Geneva Identification System", "GEN# +1.00049614J"},
        {"Smithsonian Astrophysical Observation", "SAO 218186"},
        {"Wilson Evans Batten Catalogue", "WEB 6550"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.68598642),
        dec: Angle.Degrees(-47.80450289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165254"},
        {"Hipparcos Number", "HIP 88787"},
        {"Smithsonian Astrophysical Observation", "SAO 228715"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.86769437),
        dec: Angle.Degrees(-47.80343113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13085"},
        {"Hipparcos Number", "HIP 9845"},
        {"Smithsonian Astrophysical Observation", "SAO 215773"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67168885),
        dec: Angle.Degrees(-47.80262970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107265"},
        {"Hipparcos Number", "HIP 60148"},
        {"Smithsonian Astrophysical Observation", "SAO 223359"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.01922842),
        dec: Angle.Degrees(-47.79882262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13147"},
        {"Hipparcos Number", "HIP 9883"},
        {"Geneva Identification System", "GEN# +1.00013147"},
        {"Smithsonian Astrophysical Observation", "SAO 215775"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.79232399),
        dec: Angle.Degrees(-47.79834549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130393"},
        {"Hipparcos Number", "HIP 72503"},
        {"Geneva Identification System", "GEN# +1.00130393"},
        {"Smithsonian Astrophysical Observation", "SAO 225210"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36756258),
        dec: Angle.Degrees(-47.79766743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67704"},
        {"Hipparcos Number", "HIP 39716"},
        {"Geneva Identification System", "GEN# +1.00067704"},
        {"Smithsonian Astrophysical Observation", "SAO 219438"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.77313733),
        dec: Angle.Degrees(-47.79389129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224864"},
        {"Hipparcos Number", "HIP 101"},
        {"Smithsonian Astrophysical Observation", "SAO 231897"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.31976150),
        dec: Angle.Degrees(-47.79382994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10685"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.37785321),
        dec: Angle.Degrees(-47.79087000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73884"},
        {"Hipparcos Number", "HIP 42399"},
        {"Geneva Identification System", "GEN# +1.00073884"},
        {"Smithsonian Astrophysical Observation", "SAO 220233"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.68048307),
        dec: Angle.Degrees(-47.78787934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173467"},
        {"Hipparcos Number", "HIP 92229"},
        {"Smithsonian Astrophysical Observation", "SAO 229283"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.94342689),
        dec: Angle.Degrees(-47.78655965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218166"},
        {"Hipparcos Number", "HIP 114085"},
        {"Smithsonian Astrophysical Observation", "SAO 231439"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.59160065),
        dec: Angle.Degrees(-47.78550847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157785"},
        {"Hipparcos Number", "HIP 85447"},
        {"Geneva Identification System", "GEN# +1.00157785"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.92924210),
        dec: Angle.Degrees(-47.78513098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20217"},
        {"Hipparcos Number", "HIP 14987"},
        {"Smithsonian Astrophysical Observation", "SAO 216216"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.29145641),
        dec: Angle.Degrees(-47.78450052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149901"},
        {"Hipparcos Number", "HIP 81606"},
        {"Smithsonian Astrophysical Observation", "SAO 227020"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.98699652),
        dec: Angle.Degrees(-47.78344178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70851"},
        {"Hipparcos Number", "HIP 41013"},
        {"Celescope Catalog", "CEL 2433"},
        {"Geneva Identification System", "GEN# +1.00070851"},
        {"Smithsonian Astrophysical Observation", "SAO 219843"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.55175218),
        dec: Angle.Degrees(-47.78273652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59368"},
        {"Hipparcos Number", "HIP 36202"},
        {"Geneva Identification System", "GEN# +1.00059368"},
        {"Smithsonian Astrophysical Observation", "SAO 218735"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.83574296),
        dec: Angle.Degrees(-47.78273629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13862"},
        {"Hipparcos Number", "HIP 10380"},
        {"Geneva Identification System", "GEN# +1.00013862"},
        {"Smithsonian Astrophysical Observation", "SAO 215825"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.42350028),
        dec: Angle.Degrees(-47.78055274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136844"},
        {"Hipparcos Number", "HIP 75442"},
        {"Smithsonian Astrophysical Observation", "SAO 225747"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.19260001),
        dec: Angle.Degrees(-47.78004460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173994"},
        {"Hipparcos Number", "HIP 92470"},
        {"Geneva Identification System", "GEN# +1.00173994"},
        {"Smithsonian Astrophysical Observation", "SAO 229311"},
        {"Wilson Evans Batten Catalogue", "WEB 15976"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.67239777),
        dec: Angle.Degrees(-47.77973284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30809"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.09334542),
        dec: Angle.Degrees(-47.77788756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21011"},
        {"Hipparcos Number", "HIP 15655"},
        {"Geneva Identification System", "GEN# +1.00021011"},
        {"Smithsonian Astrophysical Observation", "SAO 216278"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.38927921),
        dec: Angle.Degrees(-47.77662913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23274"},
        {"Hipparcos Number", "HIP 17256"},
        {"Geneva Identification System", "GEN# +1.00023274"},
        {"Smithsonian Astrophysical Observation", "SAO 216445"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.43987167),
        dec: Angle.Degrees(-47.77580834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207193"},
        {"Hipparcos Number", "HIP 107669"},
        {"Geneva Identification System", "GEN# +1.00207193"},
        {"Smithsonian Astrophysical Observation", "SAO 230848"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.14473244),
        dec: Angle.Degrees(-47.77562859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163615"},
        {"Hipparcos Number", "HIP 88087"},
        {"Smithsonian Astrophysical Observation", "SAO 228599"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86196944),
        dec: Angle.Degrees(-47.77396945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14534"},
        {"Hipparcos Number", "HIP 10839"},
        {"Smithsonian Astrophysical Observation", "SAO 215862"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.87548420),
        dec: Angle.Degrees(-47.77347048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24990"},
        {"Hipparcos Number", "HIP 18402"},
        {"Smithsonian Astrophysical Observation", "SAO 216558"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.02304502),
        dec: Angle.Degrees(-47.77293150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208061"},
        {"Hipparcos Number", "HIP 108168"},
        {"Geneva Identification System", "GEN# +1.00208061"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.72832525),
        dec: Angle.Degrees(-47.77190544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123732"},
        {"Hipparcos Number", "HIP 69256"},
        {"Geneva Identification System", "GEN# +1.00123732"},
        {"Smithsonian Astrophysical Observation", "SAO 224743"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.67223749),
        dec: Angle.Degrees(-47.76896779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78344"},
        {"Hipparcos Number", "HIP 44647"},
        {"Geneva Identification System", "GEN# +1.00078344"},
        {"Wilson Evans Batten Catalogue", "WEB 8542"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.46389241),
        dec: Angle.Degrees(-47.76857175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139652"},
        {"Hipparcos Number", "HIP 76838"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.32356234),
        dec: Angle.Degrees(-47.76725036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12189"},
        {"Hipparcos Number", "HIP 9206"},
        {"Smithsonian Astrophysical Observation", "SAO 215719"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60882156),
        dec: Angle.Degrees(-47.76699519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93938"},
        {"Hipparcos Number", "HIP 52953"},
        {"Smithsonian Astrophysical Observation", "SAO 222364"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.45375905),
        dec: Angle.Degrees(-47.76602077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330772"},
        {"Hipparcos Number", "HIP 80580"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.79314014),
        dec: Angle.Degrees(-47.76539597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75534"},
        {"Hipparcos Number", "HIP 43260"},
        {"Celescope Catalog", "CEL 2945"},
        {"Geneva Identification System", "GEN# +1.00075534"},
        {"Smithsonian Astrophysical Observation", "SAO 220513"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.18665388),
        dec: Angle.Degrees(-47.76337905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81783"},
        {"Hipparcos Number", "HIP 46277"},
        {"Geneva Identification System", "GEN# +1.00081783"},
        {"Smithsonian Astrophysical Observation", "SAO 221165"},
        {"Wilson Evans Batten Catalogue", "WEB 8753"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.53406956),
        dec: Angle.Degrees(-47.76305490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64832"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.36173998),
        dec: Angle.Degrees(-47.76186108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99602"},
        {"Hipparcos Number", "HIP 55869"},
        {"Smithsonian Astrophysical Observation", "SAO 222804"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.77104617),
        dec: Angle.Degrees(-47.76118777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172416"},
        {"Hipparcos Number", "HIP 91732"},
        {"Geneva Identification System", "GEN# +1.00172416"},
        {"Smithsonian Astrophysical Observation", "SAO 229208"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.59385484),
        dec: Angle.Degrees(-47.76089140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218545"},
        {"Hipparcos Number", "HIP 114339"},
        {"Geneva Identification System", "GEN# +1.00218545"},
        {"Smithsonian Astrophysical Observation", "SAO 231461"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.35729379),
        dec: Angle.Degrees(-47.76083317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136187"},
        {"Hipparcos Number", "HIP 75122"},
        {"Geneva Identification System", "GEN# +1.00136187"},
        {"Smithsonian Astrophysical Observation", "SAO 225685"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.26943098),
        dec: Angle.Degrees(-47.76031521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86332"},
        {"Hipparcos Number", "HIP 48729"},
        {"Geneva Identification System", "GEN# +1.00086332"},
        {"Smithsonian Astrophysical Observation", "SAO 221625"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.09060108),
        dec: Angle.Degrees(-47.75391427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25830"},
        {"Hipparcos Number", "HIP 18930"},
        {"Smithsonian Astrophysical Observation", "SAO 216620"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.86953892),
        dec: Angle.Degrees(-47.75358791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169404"},
        {"Hipparcos Number", "HIP 90412"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.71988960),
        dec: Angle.Degrees(-47.75212709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20640"},
        {"Hipparcos Number", "HIP 15305"},
        {"Fundamental Katalog 5th Edition", "FK5 2233"},
        {"Geneva Identification System", "GEN# +1.00020640"},
        {"Smithsonian Astrophysical Observation", "SAO 216246"},
        {"Wilson Evans Batten Catalogue", "WEB 2945"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.36084175),
        dec: Angle.Degrees(-47.75173770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127363"},
        {"Hipparcos Number", "HIP 71101"},
        {"Smithsonian Astrophysical Observation", "SAO 225003"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.09803902),
        dec: Angle.Degrees(-47.75170285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93773"},
        {"Hipparcos Number", "HIP 52865"},
        {"Geneva Identification System", "GEN# +1.00093773"},
        {"Smithsonian Astrophysical Observation", "SAO 222347"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.17306205),
        dec: Angle.Degrees(-47.74996896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215022"},
        {"Hipparcos Number", "HIP 112164"},
        {"Smithsonian Astrophysical Observation", "SAO 231261"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75925375),
        dec: Angle.Degrees(-47.74770701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101067"},
        {"Hipparcos Number", "HIP 56700"},
        {"Geneva Identification System", "GEN# +1.00101067"},
        {"Smithsonian Astrophysical Observation", "SAO 222917"},
        {"Wilson Evans Batten Catalogue", "WEB 10198"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39187576),
        dec: Angle.Degrees(-47.74737759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150083"},
        {"Hipparcos Number", "HIP 81678"},
        {"Geneva Identification System", "GEN# +1.00150083J"},
        {"Smithsonian Astrophysical Observation", "SAO 227044"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.27331575),
        dec: Angle.Degrees(-47.74610561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49613"},
        {"Hipparcos Number", "HIP 32485"},
        {"Smithsonian Astrophysical Observation", "SAO 218189"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.69437246),
        dec: Angle.Degrees(-47.74601497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32777"},
        {"Hipparcos Number", "HIP 23501"},
        {"Smithsonian Astrophysical Observation", "SAO 217148"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.79168444),
        dec: Angle.Degrees(-47.74456031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214563"},
        {"Hipparcos Number", "HIP 111894"},
        {"Smithsonian Astrophysical Observation", "SAO 231238"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.98667874),
        dec: Angle.Degrees(-47.74439148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188247"},
        {"Hipparcos Number", "HIP 98114"},
        {"Smithsonian Astrophysical Observation", "SAO 229936"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.09416071),
        dec: Angle.Degrees(-47.73762413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139599"},
        {"Hipparcos Number", "HIP 76809"},
        {"Geneva Identification System", "GEN# +1.00139599"},
        {"Smithsonian Astrophysical Observation", "SAO 226059"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.24274992),
        dec: Angle.Degrees(-47.73598709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80281"},
        {"Hipparcos Number", "HIP 45562"},
        {"Geneva Identification System", "GEN# +1.00080281"},
        {"Smithsonian Astrophysical Observation", "SAO 221027"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.29557636),
        dec: Angle.Degrees(-47.73546652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207792"},
        {"Hipparcos Number", "HIP 108006"},
        {"Smithsonian Astrophysical Observation", "SAO 230881"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.23092674),
        dec: Angle.Degrees(-47.73522961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127195"},
        {"Hipparcos Number", "HIP 71018"},
        {"Smithsonian Astrophysical Observation", "SAO 224989"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.87192379),
        dec: Angle.Degrees(-47.72975379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75713"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.01373999),
        dec: Angle.Degrees(-47.72581203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207400"},
        {"Hipparcos Number", "HIP 107775"},
        {"Smithsonian Astrophysical Observation", "SAO 230858"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.50805959),
        dec: Angle.Degrees(-47.72511102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152544"},
        {"Hipparcos Number", "HIP 82875"},
        {"Renson", "Renson 43210"},
        {"Smithsonian Astrophysical Observation", "SAO 227451"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06027613),
        dec: Angle.Degrees(-47.72444770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221795"},
        {"Hipparcos Number", "HIP 116415"},
        {"Smithsonian Astrophysical Observation", "SAO 231676"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.85540005),
        dec: Angle.Degrees(-47.72416586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168424"},
        {"Hipparcos Number", "HIP 90008"},
        {"Smithsonian Astrophysical Observation", "SAO 228948"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.48216847),
        dec: Angle.Degrees(-47.72378368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164567"},
        {"Hipparcos Number", "HIP 88491"},
        {"Smithsonian Astrophysical Observation", "SAO 228664"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.03721828),
        dec: Angle.Degrees(-47.72017817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151337"},
        {"Hipparcos Number", "HIP 82302"},
        {"Geneva Identification System", "GEN# +1.00151337"},
        {"Smithsonian Astrophysical Observation", "SAO 227251"},
        {"Wilson Evans Batten Catalogue", "WEB 13893"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.24770543),
        dec: Angle.Degrees(-47.71869147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29127"},
        {"Hipparcos Number", "HIP 21204"},
        {"Smithsonian Astrophysical Observation", "SAO 216871"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.20187860),
        dec: Angle.Degrees(-47.71693365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89736"},
        {"Hipparcos Number", "HIP 50609"},
        {"Fundamental Katalog 5th Edition", "FK5 2831"},
        {"Geneva Identification System", "GEN# +1.00089736"},
        {"Smithsonian Astrophysical Observation", "SAO 221970"},
        {"Wilson Evans Batten Catalogue", "WEB 9282"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.06967962),
        dec: Angle.Degrees(-47.69910004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1722"},
        {"Hipparcos Number", "HIP 1693"},
        {"Smithsonian Astrophysical Observation", "SAO 215058"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.30594136),
        dec: Angle.Degrees(-47.71571422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31214"},
    },
    visualMagnitude: 12.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.21672447),
        dec: Angle.Degrees(-47.71449409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37719"},
        {"Hipparcos Number", "HIP 26499"},
        {"Smithsonian Astrophysical Observation", "SAO 217446"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.53731370),
        dec: Angle.Degrees(-47.71432111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191732"},
        {"Hipparcos Number", "HIP 99666"},
        {"Smithsonian Astrophysical Observation", "SAO 230106"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.38492057),
        dec: Angle.Degrees(-47.71312980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192827"},
        {"Hipparcos Number", "HIP 100151"},
        {"Fundamental Katalog 5th Edition", "FK5 1528"},
        {"Geneva Identification System", "GEN# +1.00192827"},
        {"Smithsonian Astrophysical Observation", "SAO 230144"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.73319265),
        dec: Angle.Degrees(-47.71076925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214389"},
        {"Hipparcos Number", "HIP 111794"},
        {"Smithsonian Astrophysical Observation", "SAO 231232"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.65289774),
        dec: Angle.Degrees(-47.71005199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8416"},
        {"Hipparcos Number", "HIP 6422"},
        {"Smithsonian Astrophysical Observation", "SAO 215480"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.61210795),
        dec: Angle.Degrees(-47.70942972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165732"},
        {"Hipparcos Number", "HIP 88992"},
        {"Smithsonian Astrophysical Observation", "SAO 228754"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.45911463),
        dec: Angle.Degrees(-47.70876320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116980"},
        {"Hipparcos Number", "HIP 65685"},
        {"Geneva Identification System", "GEN# +2.51390005"},
        {"Smithsonian Astrophysical Observation", "SAO 224155"},
        {"New General Catalogue", "NGC 5139 5"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.01916987),
        dec: Angle.Degrees(-47.70501995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15371"},
        {"Hipparcos Number", "HIP 11407"},
        {"Fundamental Katalog 5th Edition", "FK5 86"},
        {"Geneva Identification System", "GEN# +1.00015371"},
        {"Smithsonian Astrophysical Observation", "SAO 215906"},
        {"Wilson Evans Batten Catalogue", "WEB 2382"},
    },
    visualMagnitude: 4.24,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.74627081),
        dec: Angle.Degrees(-47.70382692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54178"},
        {"Hipparcos Number", "HIP 34197"},
        {"Smithsonian Astrophysical Observation", "SAO 218444"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.37908748),
        dec: Angle.Degrees(-47.70302516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161635"},
        {"Hipparcos Number", "HIP 87214"},
        {"Smithsonian Astrophysical Observation", "SAO 228442"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.27104774),
        dec: Angle.Degrees(-47.70257695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195266"},
        {"Hipparcos Number", "HIP 101317"},
    },
    visualMagnitude: 9.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.03654530),
        dec: Angle.Degrees(-47.70148388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77402"},
        {"Hipparcos Number", "HIP 44234"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13438764),
        dec: Angle.Degrees(-47.70117639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154044"},
        {"Hipparcos Number", "HIP 83621"},
        {"Smithsonian Astrophysical Observation", "SAO 227606"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.35060571),
        dec: Angle.Degrees(-47.70100064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217292"},
        {"Hipparcos Number", "HIP 113580"},
        {"Smithsonian Astrophysical Observation", "SAO 231385"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08002537),
        dec: Angle.Degrees(-47.69938525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86304"},
        {"Hipparcos Number", "HIP 48721"},
        {"Smithsonian Astrophysical Observation", "SAO 221622"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.06124572),
        dec: Angle.Degrees(-47.69878606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186170"},
        {"Hipparcos Number", "HIP 97181"},
        {"Geneva Identification System", "GEN# +1.00186170"},
        {"Smithsonian Astrophysical Observation", "SAO 229846"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.27687771),
        dec: Angle.Degrees(-47.69768071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135375"},
        {"Hipparcos Number", "HIP 74748"},
        {"Smithsonian Astrophysical Observation", "SAO 225603"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.14415011),
        dec: Angle.Degrees(-47.69694640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129719"},
        {"Hipparcos Number", "HIP 72166"},
        {"Smithsonian Astrophysical Observation", "SAO 225169"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.40713074),
        dec: Angle.Degrees(-47.69538705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112540"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.92015874),
        dec: Angle.Degrees(-47.69349658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76455"},
        {"Hipparcos Number", "HIP 43734"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.61082570),
        dec: Angle.Degrees(-47.69282828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49560"},
        {"Hipparcos Number", "HIP 32462"},
        {"Smithsonian Astrophysical Observation", "SAO 218184"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63266215),
        dec: Angle.Degrees(-47.69272885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108952"},
        {"Hipparcos Number", "HIP 61112"},
        {"Smithsonian Astrophysical Observation", "SAO 223486"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.87355986),
        dec: Angle.Degrees(-47.69252518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196936"},
        {"Hipparcos Number", "HIP 102191"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.58509203),
        dec: Angle.Degrees(-47.69158420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63344"},
        {"Hipparcos Number", "HIP 37916"},
        {"Smithsonian Astrophysical Observation", "SAO 218978"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.55576510),
        dec: Angle.Degrees(-47.69008983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114006"},
        {"Hipparcos Number", "HIP 64101"},
        {"Smithsonian Astrophysical Observation", "SAO 223922"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.04833243),
        dec: Angle.Degrees(-47.68948155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37004"},
        {"Hipparcos Number", "HIP 25998"},
        {"Geneva Identification System", "GEN# +1.00037004"},
        {"Smithsonian Astrophysical Observation", "SAO 217394"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.23498097),
        dec: Angle.Degrees(-47.68903334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112361"},
        {"Hipparcos Number", "HIP 63182"},
        {"Geneva Identification System", "GEN# +1.00112361"},
        {"Smithsonian Astrophysical Observation", "SAO 223774"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16505973),
        dec: Angle.Degrees(-47.68623196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148850"},
        {"Hipparcos Number", "HIP 81045"},
        {"Smithsonian Astrophysical Observation", "SAO 226876"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.29586463),
        dec: Angle.Degrees(-47.68333276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96406"},
        {"Hipparcos Number", "HIP 54277"},
        {"Geneva Identification System", "GEN# +1.00096406"},
        {"Smithsonian Astrophysical Observation", "SAO 222566"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.55029090),
        dec: Angle.Degrees(-47.68326004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2499"},
        {"Geneva Identification System", "GEN# +6.00001559"},
    },
    visualMagnitude: 12.41,
    bvColour: -0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.92346886),
        dec: Angle.Degrees(-47.42216728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130734"},
        {"Hipparcos Number", "HIP 72667"},
        {"Smithsonian Astrophysical Observation", "SAO 225243"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.86642859),
        dec: Angle.Degrees(-47.68317972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65905"},
        {"Hipparcos Number", "HIP 38993"},
        {"Celescope Catalog", "CEL 2123"},
        {"Geneva Identification System", "GEN# +1.00065905J"},
        {"Smithsonian Astrophysical Observation", "SAO 219237"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.70983847),
        dec: Angle.Degrees(-47.68293365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224390"},
        {"Hipparcos Number", "HIP 118110"},
        {"Smithsonian Astrophysical Observation", "SAO 231866"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.37810728),
        dec: Angle.Degrees(-47.68132282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11600"},
        {"Hipparcos Number", "HIP 8755"},
        {"Smithsonian Astrophysical Observation", "SAO 215691"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.15567080),
        dec: Angle.Degrees(-47.68127890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70451"},
        {"Hipparcos Number", "HIP 40825"},
        {"Celescope Catalog", "CEL 2384"},
        {"Smithsonian Astrophysical Observation", "SAO 219799"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99137663),
        dec: Angle.Degrees(-47.68004615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96113"},
        {"Hipparcos Number", "HIP 54137"},
        {"Fundamental Katalog 5th Edition", "FK5 2884"},
        {"Geneva Identification System", "GEN# +1.00096113"},
        {"Smithsonian Astrophysical Observation", "SAO 222538"},
        {"Wilson Evans Batten Catalogue", "WEB 9784"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.13042166),
        dec: Angle.Degrees(-47.67918306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183293"},
        {"Hipparcos Number", "HIP 95984"},
        {"Smithsonian Astrophysical Observation", "SAO 229724"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.76313557),
        dec: Angle.Degrees(-47.67906367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12101"},
    },
    visualMagnitude: 12.55,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.98228848),
        dec: Angle.Degrees(-47.67525410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48403"},
        {"Hipparcos Number", "HIP 31966"},
        {"Geneva Identification System", "GEN# +1.00048403"},
        {"Smithsonian Astrophysical Observation", "SAO 218124"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.20610976),
        dec: Angle.Degrees(-47.67466151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71874"},
        {"Hipparcos Number", "HIP 41498"},
        {"Celescope Catalog", "CEL 2541"},
        {"Geneva Identification System", "GEN# +1.00071874"},
        {"Smithsonian Astrophysical Observation", "SAO 219959"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.94824989),
        dec: Angle.Degrees(-47.67422083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81259"},
        {"Hipparcos Number", "HIP 46006"},
        {"Geneva Identification System", "GEN# +1.00081259"},
        {"Smithsonian Astrophysical Observation", "SAO 221118"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.74305919),
        dec: Angle.Degrees(-47.67355477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10218"},
        {"Hipparcos Number", "HIP 7688"},
        {"Smithsonian Astrophysical Observation", "SAO 215599"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.74110763),
        dec: Angle.Degrees(-47.67048550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185034"},
        {"Hipparcos Number", "HIP 96698"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.87424010),
        dec: Angle.Degrees(-47.66764418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41784"},
        {"Geneva Identification System", "GEN# -0.04704047"},
        {"Smithsonian Astrophysical Observation", "SAO 220040"},
        {"Wilson Evans Batten Catalogue", "WEB 8047"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.79703239),
        dec: Angle.Degrees(-47.66595594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69934"},
        {"Hipparcos Number", "HIP 40586"},
        {"Celescope Catalog", "CEL 2320"},
        {"Geneva Identification System", "GEN# +1.00069934"},
        {"Smithsonian Astrophysical Observation", "SAO 219734"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.30237032),
        dec: Angle.Degrees(-47.66555953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105714"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.17044308),
        dec: Angle.Degrees(-47.66289827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37046"},
        {"Hipparcos Number", "HIP 26022"},
        {"Geneva Identification System", "GEN# +1.00037046"},
        {"Smithsonian Astrophysical Observation", "SAO 217397"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28418259),
        dec: Angle.Degrees(-47.66259086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106122"},
        {"Hipparcos Number", "HIP 59547"},
        {"Smithsonian Astrophysical Observation", "SAO 223280"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.18288167),
        dec: Angle.Degrees(-47.66138345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330611"},
        {"Hipparcos Number", "HIP 80104"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.27884703),
        dec: Angle.Degrees(-47.66053963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70464"},
        {"Hipparcos Number", "HIP 40851"},
        {"Geneva Identification System", "GEN# +1.00070464"},
        {"Renson", "Renson 19440"},
        {"Smithsonian Astrophysical Observation", "SAO 219804"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.03386821),
        dec: Angle.Degrees(-47.66023132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110255"},
        {"Hipparcos Number", "HIP 61907"},
        {"Geneva Identification System", "GEN# +1.00110255"},
        {"Smithsonian Astrophysical Observation", "SAO 223597"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.30219264),
        dec: Angle.Degrees(-47.66005419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90611"},
        {"Hipparcos Number", "HIP 51130"},
        {"Smithsonian Astrophysical Observation", "SAO 222057"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.68311645),
        dec: Angle.Degrees(-47.65968025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 330605"},
        {"Hipparcos Number", "HIP 80253"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.75666065),
        dec: Angle.Degrees(-47.65894443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29454"},
        {"Hipparcos Number", "HIP 21425"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.00094892),
        dec: Angle.Degrees(-47.65513881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80998"},
        {"Hipparcos Number", "HIP 45893"},
        {"Smithsonian Astrophysical Observation", "SAO 221097"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35563372),
        dec: Angle.Degrees(-47.65303824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223328"},
        {"Hipparcos Number", "HIP 117444"},
        {"Smithsonian Astrophysical Observation", "SAO 231788"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.20042319),
        dec: Angle.Degrees(-47.65000973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57855"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.98151838),
        dec: Angle.Degrees(-47.64885305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140677"},
        {"Hipparcos Number", "HIP 77298"},
        {"Smithsonian Astrophysical Observation", "SAO 226182"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.71797858),
        dec: Angle.Degrees(-47.64788965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274727"},
        {"Hipparcos Number", "HIP 25042"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.43308256),
        dec: Angle.Degrees(-47.64649218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115989"},
        {"Hipparcos Number", "HIP 65185"},
        {"Smithsonian Astrophysical Observation", "SAO 224084"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.38026805),
        dec: Angle.Degrees(-47.64457996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40199"},
        {"Hipparcos Number", "HIP 27950"},
        {"Smithsonian Astrophysical Observation", "SAO 217615"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71360613),
        dec: Angle.Degrees(-47.64256416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100825"},
        {"Hipparcos Number", "HIP 56573"},
        {"Fundamental Katalog 5th Edition", "FK5 435"},
        {"Geneva Identification System", "GEN# +1.00100825"},
        {"Renson", "Renson 29010"},
        {"Smithsonian Astrophysical Observation", "SAO 222895"},
        {"Wilson Evans Batten Catalogue", "WEB 10169"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.98148244),
        dec: Angle.Degrees(-47.64152017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116586"},
        {"Hipparcos Number", "HIP 65493"},
        {"Geneva Identification System", "GEN# +1.00116586"},
        {"Geneva Identification System 2", "GEN# +2.51390003"},
        {"Smithsonian Astrophysical Observation", "SAO 224127"},
        {"New General Catalogue", "NGC 5139 3"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.34491117),
        dec: Angle.Degrees(-47.63325644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93437"},
        {"Hipparcos Number", "HIP 52696"},
        {"Smithsonian Astrophysical Observation", "SAO 222315"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.61623611),
        dec: Angle.Degrees(-47.63267840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64019"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.77073974),
        dec: Angle.Degrees(-47.63164682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138177"},
        {"Hipparcos Number", "HIP 76090"},
        {"Smithsonian Astrophysical Observation", "SAO 225879"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.09941434),
        dec: Angle.Degrees(-47.63139347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204885"},
        {"Hipparcos Number", "HIP 106399"},
        {"Smithsonian Astrophysical Observation", "SAO 230734"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.25205840),
        dec: Angle.Degrees(-47.62873751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119405"},
        {"Hipparcos Number", "HIP 67017"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.01998775),
        dec: Angle.Degrees(-47.62725550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37118"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.40269069),
        dec: Angle.Degrees(-47.62377088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24122"},
        {"Hipparcos Number", "HIP 17788"},
        {"Smithsonian Astrophysical Observation", "SAO 216497"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.10928276),
        dec: Angle.Degrees(-47.62342707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110303"},
        {"Hipparcos Number", "HIP 61926"},
        {"Smithsonian Astrophysical Observation", "SAO 223602"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.37038661),
        dec: Angle.Degrees(-47.62319927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48402"},
        {"Hipparcos Number", "HIP 31962"},
        {"Geneva Identification System", "GEN# +1.00048402"},
        {"Smithsonian Astrophysical Observation", "SAO 218123"},
        {"Wilson Evans Batten Catalogue", "WEB 6430"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.19772437),
        dec: Angle.Degrees(-47.62154519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148987"},
        {"Hipparcos Number", "HIP 81121"},
        {"Smithsonian Astrophysical Observation", "SAO 226898"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52000947),
        dec: Angle.Degrees(-47.61748023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88221"},
        {"Hipparcos Number", "HIP 49736"},
        {"Smithsonian Astrophysical Observation", "SAO 221812"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.30063455),
        dec: Angle.Degrees(-47.61550254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191797"},
        {"Hipparcos Number", "HIP 99695"},
        {"Geneva Identification System", "GEN# +1.00191797"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.45751248),
        dec: Angle.Degrees(-47.61533621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106389"},
        {"Hipparcos Number", "HIP 59693"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.61944823),
        dec: Angle.Degrees(-47.61278487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134236"},
        {"Hipparcos Number", "HIP 74252"},
        {"Smithsonian Astrophysical Observation", "SAO 225504"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.62735694),
        dec: Angle.Degrees(-47.61190397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172062"},
        {"Hipparcos Number", "HIP 91577"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.10337348),
        dec: Angle.Degrees(-47.60887727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329879"},
        {"Hipparcos Number", "HIP 77518"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.40952424),
        dec: Angle.Degrees(-47.60851789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -393.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178531"},
        {"Hipparcos Number", "HIP 94262"},
        {"Smithsonian Astrophysical Observation", "SAO 229538"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.80024094),
        dec: Angle.Degrees(-47.60719253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110356"},
        {"Hipparcos Number", "HIP 61965"},
        {"Fundamental Katalog 5th Edition", "FK5 5118"},
        {"Smithsonian Astrophysical Observation", "SAO 223608"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.48263232),
        dec: Angle.Degrees(-47.60609447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72800"},
        {"Hipparcos Number", "HIP 41928"},
        {"Celescope Catalog", "CEL 2636"},
        {"Geneva Identification System", "GEN# +1.00072800"},
        {"Smithsonian Astrophysical Observation", "SAO 220085"},
        {"Wilson Evans Batten Catalogue", "WEB 8070"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22408456),
        dec: Angle.Degrees(-47.60552656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214751"},
        {"Hipparcos Number", "HIP 111994"},
        {"Geneva Identification System", "GEN# +1.00214751"},
        {"Smithsonian Astrophysical Observation", "SAO 231249"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.27705656),
        dec: Angle.Degrees(-47.60495523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82455"},
        {"Hipparcos Number", "HIP 46631"},
        {"Geneva Identification System", "GEN# +1.00082455"},
        {"Smithsonian Astrophysical Observation", "SAO 221236"},
        {"Wilson Evans Batten Catalogue", "WEB 8800"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.63875611),
        dec: Angle.Degrees(-47.60451340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297014"},
        {"Hipparcos Number", "HIP 47871"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.34726609),
        dec: Angle.Degrees(-47.60445040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32426"},
        {"Hipparcos Number", "HIP 23308"},
        {"Smithsonian Astrophysical Observation", "SAO 217115"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.19083793),
        dec: Angle.Degrees(-47.60380602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213755"},
        {"Hipparcos Number", "HIP 111445"},
        {"Smithsonian Astrophysical Observation", "SAO 231197"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.65715443),
        dec: Angle.Degrees(-47.59691086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69569"},
        {"Hipparcos Number", "HIP 40445"},
        {"Geneva Identification System", "GEN# +1.00069569"},
        {"Smithsonian Astrophysical Observation", "SAO 219689"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.87081208),
        dec: Angle.Degrees(-47.59649430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108842"},
        {"Hipparcos Number", "HIP 61041"},
        {"Smithsonian Astrophysical Observation", "SAO 223479"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.65812235),
        dec: Angle.Degrees(-47.59643182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6630"},
        {"Hipparcos Number", "HIP 5188"},
        {"Geneva Identification System", "GEN# +1.00006630"},
        {"Renson", "Renson 1710"},
        {"Smithsonian Astrophysical Observation", "SAO 215368"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.59742756),
        dec: Angle.Degrees(-47.59516235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206074"},
        {"Hipparcos Number", "HIP 107057"},
        {"Smithsonian Astrophysical Observation", "SAO 230790"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.24129938),
        dec: Angle.Degrees(-47.59356658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76536"},
        {"Hipparcos Number", "HIP 43778"},
        {"Geneva Identification System", "GEN# +1.00076536"},
        {"Smithsonian Astrophysical Observation", "SAO 220658"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74654600),
        dec: Angle.Degrees(-47.59241876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108308"},
        {"Hipparcos Number", "HIP 60741"},
        {"Smithsonian Astrophysical Observation", "SAO 223444"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.73399844),
        dec: Angle.Degrees(-47.59220178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13603"},
        {"Hipparcos Number", "HIP 10219"},
        {"Smithsonian Astrophysical Observation", "SAO 215806"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.84914849),
        dec: Angle.Degrees(-47.59125070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188117"},
        {"Hipparcos Number", "HIP 98062"},
        {"Smithsonian Astrophysical Observation", "SAO 229929"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.93667178),
        dec: Angle.Degrees(-47.59086270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58588"},
    },
    visualMagnitude: 10.28,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21744680),
        dec: Angle.Degrees(-47.59062013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151097"},
        {"Hipparcos Number", "HIP 82195"},
        {"Geneva Identification System", "GEN# +1.00151097"},
        {"Smithsonian Astrophysical Observation", "SAO 227209"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.87904188),
        dec: Angle.Degrees(-47.59044437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115415"},
        {"Hipparcos Number", "HIP 64867"},
        {"Geneva Identification System", "GEN# +1.00115415"},
        {"Smithsonian Astrophysical Observation", "SAO 224043"},
        {"Wilson Evans Batten Catalogue", "WEB 11466"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.43609601),
        dec: Angle.Degrees(-47.58992392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123112"},
        {"Hipparcos Number", "HIP 68958"},
        {"Geneva Identification System", "GEN# +1.00123112"},
        {"Renson", "Renson 35270"},
        {"Smithsonian Astrophysical Observation", "SAO 224687"},
        {"Wilson Evans Batten Catalogue", "WEB 12051"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.74274882),
        dec: Angle.Degrees(-47.58916740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223909"},
        {"Hipparcos Number", "HIP 117816"},
        {"Smithsonian Astrophysical Observation", "SAO 231832"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.41655546),
        dec: Angle.Degrees(-47.58912419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222346"},
        {"Hipparcos Number", "HIP 116767"},
        {"Smithsonian Astrophysical Observation", "SAO 231725"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.97859953),
        dec: Angle.Degrees(-47.58854571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147436"},
        {"Hipparcos Number", "HIP 80358"},
        {"Geneva Identification System", "GEN# +1.00147436"},
        {"Smithsonian Astrophysical Observation", "SAO 226716"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.05686865),
        dec: Angle.Degrees(-47.58737583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34269"},
        {"Geneva Identification System", "GEN# -0.04702804"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.55774072),
        dec: Angle.Degrees(-47.58683143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181"},
        {"Hipparcos Number", "HIP 541"},
        {"Geneva Identification System", "GEN# +1.00000181"},
        {"Smithsonian Astrophysical Observation", "SAO 214964"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.64849601),
        dec: Angle.Degrees(-47.58474443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195583"},
        {"Hipparcos Number", "HIP 101504"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.53965454),
        dec: Angle.Degrees(-47.58300055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61388"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.69912238),
        dec: Angle.Degrees(-47.58189243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182968"},
        {"Hipparcos Number", "HIP 95825"},
        {"Smithsonian Astrophysical Observation", "SAO 229709"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.35350690),
        dec: Angle.Degrees(-47.58065934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192886"},
        {"Hipparcos Number", "HIP 100184"},
        {"Geneva Identification System", "GEN# +1.00192886"},
        {"Smithsonian Astrophysical Observation", "SAO 230150"},
        {"Wilson Evans Batten Catalogue", "WEB 18049"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.82368720),
        dec: Angle.Degrees(-47.57984541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211877"},
        {"Hipparcos Number", "HIP 110366"},
        {"Smithsonian Astrophysical Observation", "SAO 231093"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.30354288),
        dec: Angle.Degrees(-47.57972228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175303"},
        {"Hipparcos Number", "HIP 93035"},
        {"Smithsonian Astrophysical Observation", "SAO 229394"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27693259),
        dec: Angle.Degrees(-47.57854266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96098"},
        {"Hipparcos Number", "HIP 54126"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.11362063),
        dec: Angle.Degrees(-47.57763450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75064"},
        {"Hipparcos Number", "HIP 43011"},
        {"Celescope Catalog", "CEL 2876"},
        {"Geneva Identification System", "GEN# +1.00075064"},
        {"Smithsonian Astrophysical Observation", "SAO 220418"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.47968866),
        dec: Angle.Degrees(-47.57621022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3358"},
        {"Hipparcos Number", "HIP 2849"},
        {"Smithsonian Astrophysical Observation", "SAO 215162"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.01647993),
        dec: Angle.Degrees(-47.57531415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216281"},
        {"Hipparcos Number", "HIP 112930"},
        {"Geneva Identification System", "GEN# +1.00216281"},
        {"Smithsonian Astrophysical Observation", "SAO 231332"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.07701893),
        dec: Angle.Degrees(-47.57517483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94785"},
        {"Hipparcos Number", "HIP 53436"},
        {"Smithsonian Astrophysical Observation", "SAO 222429"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.96954920),
        dec: Angle.Degrees(-47.57463833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145971"},
        {"Hipparcos Number", "HIP 79694"},
        {"Geneva Identification System", "GEN# +1.00145971"},
        {"Smithsonian Astrophysical Observation", "SAO 226610"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.96640144),
        dec: Angle.Degrees(-47.57407426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221229"},
        {"Hipparcos Number", "HIP 116019"},
        {"Smithsonian Astrophysical Observation", "SAO 231636"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.61903942),
        dec: Angle.Degrees(-47.57048739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129281"},
        {"Hipparcos Number", "HIP 71975"},
        {"Geneva Identification System", "GEN# +1.00129281"},
        {"Smithsonian Astrophysical Observation", "SAO 225145"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.81391919),
        dec: Angle.Degrees(-47.57048264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212453"},
        {"Hipparcos Number", "HIP 110674"},
        {"Smithsonian Astrophysical Observation", "SAO 231132"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.32027140),
        dec: Angle.Degrees(-47.56970233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78"},
        {"Hipparcos Number", "HIP 467"},
        {"Smithsonian Astrophysical Observation", "SAO 214960"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.39643718),
        dec: Angle.Degrees(-47.56931860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88091"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86897032),
        dec: Angle.Degrees(-47.56846555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27603"},
        {"Hipparcos Number", "HIP 20145"},
        {"Smithsonian Astrophysical Observation", "SAO 216748"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.78030237),
        dec: Angle.Degrees(-47.56776025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80859"},
        {"Hipparcos Number", "HIP 45823"},
        {"Smithsonian Astrophysical Observation", "SAO 221084"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.14487670),
        dec: Angle.Degrees(-47.56681207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89800"},
        {"Hipparcos Number", "HIP 50664"},
        {"Smithsonian Astrophysical Observation", "SAO 221977"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20127870),
        dec: Angle.Degrees(-47.56589364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17263"},
        {"Smithsonian Astrophysical Observation", "SAO 149119"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45887924),
        dec: Angle.Degrees(-17.05158607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26864"},
        {"Hipparcos Number", "HIP 19658"},
        {"Smithsonian Astrophysical Observation", "SAO 216700"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.18212618),
        dec: Angle.Degrees(-47.56576624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186060"},
        {"Hipparcos Number", "HIP 97129"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.10861980),
        dec: Angle.Degrees(-47.56533424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5647"},
        {"Hipparcos Number", "HIP 4492"},
        {"Smithsonian Astrophysical Observation", "SAO 215301"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.39313155),
        dec: Angle.Degrees(-47.56469796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78629"},
        {"Hipparcos Number", "HIP 44782"},
        {"Geneva Identification System", "GEN# +1.00078629"},
        {"Smithsonian Astrophysical Observation", "SAO 220875"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.91055423),
        dec: Angle.Degrees(-47.56241887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7152"},
        {"Hipparcos Number", "HIP 5545"},
        {"Geneva Identification System", "GEN# +1.00007152"},
        {"Smithsonian Astrophysical Observation", "SAO 215401"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.78228439),
        dec: Angle.Degrees(-47.56201801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67642"},
        {"Hipparcos Number", "HIP 39699"},
        {"Geneva Identification System", "GEN# +1.00067642"},
        {"Smithsonian Astrophysical Observation", "SAO 219432"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.70910926),
        dec: Angle.Degrees(-47.56050623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19029"},
        {"Hipparcos Number", "HIP 14106"},
        {"Geneva Identification System", "GEN# +1.00019029"},
        {"Smithsonian Astrophysical Observation", "SAO 216143"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.47089891),
        dec: Angle.Degrees(-47.55907011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87702"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.71372467),
        dec: Angle.Degrees(-47.55862442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187086"},
        {"Hipparcos Number", "HIP 97598"},
        {"Geneva Identification System", "GEN# +1.00187086"},
        {"Smithsonian Astrophysical Observation", "SAO 229887"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.55855107),
        dec: Angle.Degrees(-47.55736033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6809"},
        {"Hipparcos Number", "HIP 5318"},
        {"Smithsonian Astrophysical Observation", "SAO 215378"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.00302161),
        dec: Angle.Degrees(-47.55690734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209372"},
        {"Hipparcos Number", "HIP 108937"},
        {"Smithsonian Astrophysical Observation", "SAO 230963"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.04806314),
        dec: Angle.Degrees(-47.55687588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114231"},
        {"Hipparcos Number", "HIP 64236"},
        {"Smithsonian Astrophysical Observation", "SAO 223945"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.48523196),
        dec: Angle.Degrees(-47.55570061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147971"},
        {"Hipparcos Number", "HIP 80582"},
        {"Geneva Identification System", "GEN# +1.00147971"},
        {"Smithsonian Astrophysical Observation", "SAO 226773"},
        {"Wilson Evans Batten Catalogue", "WEB 13632"},
    },
    visualMagnitude: 4.46,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.79603256),
        dec: Angle.Degrees(-47.55473590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102596"},
        {"Hipparcos Number", "HIP 57598"},
        {"Geneva Identification System", "GEN# +1.00102596"},
        {"Smithsonian Astrophysical Observation", "SAO 223035"},
        {"Wilson Evans Batten Catalogue", "WEB 10341"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.12752696),
        dec: Angle.Degrees(-47.55457208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163761"},
        {"Hipparcos Number", "HIP 88152"},
        {"Smithsonian Astrophysical Observation", "SAO 228612"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06737686),
        dec: Angle.Degrees(-47.55377360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61782"},
        {"Hipparcos Number", "HIP 37218"},
        {"Smithsonian Astrophysical Observation", "SAO 218861"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.67752138),
        dec: Angle.Degrees(-47.55337737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220493"},
        {"Hipparcos Number", "HIP 115564"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.13206086),
        dec: Angle.Degrees(-47.55313497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150197"},
        {"Hipparcos Number", "HIP 81736"},
        {"Geneva Identification System", "GEN# +1.00150197"},
        {"Smithsonian Astrophysical Observation", "SAO 227062"},
        {"Wilson Evans Batten Catalogue", "WEB 13810"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.43036070),
        dec: Angle.Degrees(-47.55309903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4391"},
        {"Hipparcos Number", "HIP 3583"},
        {"Geneva Identification System", "GEN# +1.00004391"},
        {"Smithsonian Astrophysical Observation", "SAO 215232"},
        {"Wilson Evans Batten Catalogue", "WEB 633"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.43930832),
        dec: Angle.Degrees(-47.55217573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201789"},
        {"Hipparcos Number", "HIP 104773"},
        {"Fundamental Katalog 5th Edition", "FK5 5872"},
        {"Smithsonian Astrophysical Observation", "SAO 230581"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.37267212),
        dec: Angle.Degrees(-47.55069301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75129"},
        {"Hipparcos Number", "HIP 43057"},
        {"Celescope Catalog", "CEL 2887"},
        {"Geneva Identification System", "GEN# +1.00075129"},
        {"Smithsonian Astrophysical Observation", "SAO 220436"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58089635),
        dec: Angle.Degrees(-47.54989551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147970"},
        {"Hipparcos Number", "HIP 80579"},
        {"Geneva Identification System", "GEN# +1.00147970"},
        {"Smithsonian Astrophysical Observation", "SAO 226772"},
        {"Wilson Evans Batten Catalogue", "WEB 13631"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)27, 10.1300),
        dec: Angle.DegreesMinutesSeconds((int)-47, (int)32, 56.700)
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
    primaryId: "HIP 93698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176908"},
        {"Hipparcos Number", "HIP 93698"},
        {"Smithsonian Astrophysical Observation", "SAO 229473"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.20107414),
        dec: Angle.Degrees(-47.54874631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61965"},
        {"Hipparcos Number", "HIP 37306"},
        {"Smithsonian Astrophysical Observation", "SAO 218876"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.88089941),
        dec: Angle.Degrees(-47.54821337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208495"},
        {"Hipparcos Number", "HIP 108421"},
        {"Smithsonian Astrophysical Observation", "SAO 230915"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46314603),
        dec: Angle.Degrees(-47.54685448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38469"},
        {"Hipparcos Number", "HIP 26983"},
        {"Smithsonian Astrophysical Observation", "SAO 217495"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.87918567),
        dec: Angle.Degrees(-47.54620052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219914"},
        {"Hipparcos Number", "HIP 115197"},
        {"Smithsonian Astrophysical Observation", "SAO 231553"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.99884218),
        dec: Angle.Degrees(-47.54015885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78306"},
        {"Hipparcos Number", "HIP 44631"},
        {"Smithsonian Astrophysical Observation", "SAO 220838"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.41750303),
        dec: Angle.Degrees(-47.53968265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118356"},
        {"Hipparcos Number", "HIP 66451"},
        {"Geneva Identification System", "GEN# +1.00118356"},
        {"Smithsonian Astrophysical Observation", "SAO 224280"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.34320876),
        dec: Angle.Degrees(-47.53770536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202896"},
        {"Hipparcos Number", "HIP 105362"},
        {"Smithsonian Astrophysical Observation", "SAO 230639"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.11332437),
        dec: Angle.Degrees(-47.53530595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177523"},
        {"Hipparcos Number", "HIP 93915"},
        {"Smithsonian Astrophysical Observation", "SAO 229500"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.84344111),
        dec: Angle.Degrees(-47.53253556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87057"},
        {"Hipparcos Number", "HIP 49106"},
        {"Smithsonian Astrophysical Observation", "SAO 221703"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.32789330),
        dec: Angle.Degrees(-47.53248425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152100"},
        {"Hipparcos Number", "HIP 82643"},
        {"Geneva Identification System", "GEN# +1.00152100"},
        {"Smithsonian Astrophysical Observation", "SAO 227352"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39936359),
        dec: Angle.Degrees(-47.53196978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100092"},
        {"Hipparcos Number", "HIP 56159"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.67849035),
        dec: Angle.Degrees(-47.53152290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8270"},
        {"Hipparcos Number", "HIP 6322"},
        {"Smithsonian Astrophysical Observation", "SAO 215468"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.29170225),
        dec: Angle.Degrees(-47.53083991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127140"},
        {"Hipparcos Number", "HIP 70994"},
        {"Smithsonian Astrophysical Observation", "SAO 224984"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80606045),
        dec: Angle.Degrees(-47.52955132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147657"},
        {"Hipparcos Number", "HIP 80456"},
        {"Geneva Identification System", "GEN# +1.00147657"},
        {"Smithsonian Astrophysical Observation", "SAO 226743"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.34549794),
        dec: Angle.Degrees(-47.52843308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96960"},
        {"Hipparcos Number", "HIP 54520"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.32163788),
        dec: Angle.Degrees(-47.52755885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116663"},
        {"Hipparcos Number", "HIP 65519"},
        {"Geneva Identification System", "GEN# +1.00116663"},
        {"Geneva Identification System 2", "GEN# +2.51390004"},
        {"Smithsonian Astrophysical Observation", "SAO 224135"},
        {"New General Catalogue", "NGC 5139 4"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.45421537),
        dec: Angle.Degrees(-47.52508536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58675"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.47146417),
        dec: Angle.Degrees(-47.52444855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56946"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11719718),
        dec: Angle.Degrees(-47.52326656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83622"},
        {"Hipparcos Number", "HIP 47306"},
        {"Smithsonian Astrophysical Observation", "SAO 221360"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59924349),
        dec: Angle.Degrees(-47.52303600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184559"},
        {"Hipparcos Number", "HIP 96521"},
        {"Smithsonian Astrophysical Observation", "SAO 229773"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.33783178),
        dec: Angle.Degrees(-47.52296382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125849"},
        {"Hipparcos Number", "HIP 70339"},
        {"Geneva Identification System", "GEN# +1.00125849"},
    },
    visualMagnitude: 9.50,
    bvColour: 2.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.86540381),
        dec: Angle.Degrees(-47.52241494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74496"},
        {"Hipparcos Number", "HIP 42728"},
        {"Celescope Catalog", "CEL 2805"},
        {"Geneva Identification System", "GEN# +1.00074496"},
        {"Renson", "Renson 20760"},
        {"Smithsonian Astrophysical Observation", "SAO 220317"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.61797403),
        dec: Angle.Degrees(-47.52120914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54917"},
        {"Hipparcos Number", "HIP 34445"},
        {"Smithsonian Astrophysical Observation", "SAO 218480"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.10221106),
        dec: Angle.Degrees(-47.52093671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76360"},
        {"Hipparcos Number", "HIP 43671"},
        {"Celescope Catalog", "CEL 3055"},
        {"Geneva Identification System", "GEN# +1.00076360J"},
        {"Renson", "Renson 21440"},
        {"Smithsonian Astrophysical Observation", "SAO 220636"},
        {"Wilson Evans Batten Catalogue", "WEB 8407"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46083652),
        dec: Angle.Degrees(-47.52071984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220234"},
        {"Hipparcos Number", "HIP 115392"},
        {"Smithsonian Astrophysical Observation", "SAO 231573"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.63030110),
        dec: Angle.Degrees(-47.52033962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115069"},
        {"Hipparcos Number", "HIP 64681"},
        {"Smithsonian Astrophysical Observation", "SAO 224008"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.85502982),
        dec: Angle.Degrees(-47.51921502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126523"},
        {"Hipparcos Number", "HIP 70683"},
        {"Geneva Identification System", "GEN# +1.00126523"},
        {"Smithsonian Astrophysical Observation", "SAO 224931"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.85607333),
        dec: Angle.Degrees(-47.51907020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107506"},
        {"Hipparcos Number", "HIP 60279"},
        {"Smithsonian Astrophysical Observation", "SAO 223378"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.40731621),
        dec: Angle.Degrees(-47.51861430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35182"},
        {"Hipparcos Number", "HIP 24931"},
        {"Geneva Identification System", "GEN# +1.00035182"},
        {"Smithsonian Astrophysical Observation", "SAO 217293"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.12434782),
        dec: Angle.Degrees(-47.51758198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62674"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.63852106),
        dec: Angle.Degrees(-47.51533781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184923"},
        {"Hipparcos Number", "HIP 96640"},
        {"Smithsonian Astrophysical Observation", "SAO 229788"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.72218953),
        dec: Angle.Degrees(-47.51465185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180805"},
        {"Hipparcos Number", "HIP 95034"},
        {"Smithsonian Astrophysical Observation", "SAO 229621"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.04726570),
        dec: Angle.Degrees(-47.51386766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 857"},
        {"Hipparcos Number", "HIP 1029"},
        {"Smithsonian Astrophysical Observation", "SAO 215003"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.20765780),
        dec: Angle.Degrees(-47.51351954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93897"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.79732336),
        dec: Angle.Degrees(-47.51339750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166006"},
        {"Hipparcos Number", "HIP 89096"},
        {"Geneva Identification System", "GEN# +1.00166006"},
        {"Smithsonian Astrophysical Observation", "SAO 228774"},
        {"Wilson Evans Batten Catalogue", "WEB 15125"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.76836410),
        dec: Angle.Degrees(-47.51304791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160355"},
        {"Hipparcos Number", "HIP 86602"},
        {"Geneva Identification System", "GEN# +1.00160355"},
        {"Smithsonian Astrophysical Observation", "SAO 228292"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.45977597),
        dec: Angle.Degrees(-47.51251590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124255"},
        {"Hipparcos Number", "HIP 69501"},
        {"Smithsonian Astrophysical Observation", "SAO 224775"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42947950),
        dec: Angle.Degrees(-47.51215742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11551"},
        {"Hipparcos Number", "HIP 8727"},
        {"Geneva Identification System", "GEN# +1.00011551"},
        {"Smithsonian Astrophysical Observation", "SAO 215686"},
        {"Wilson Evans Batten Catalogue", "WEB 1840"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.06204148),
        dec: Angle.Degrees(-47.51177125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18371"},
        {"Smithsonian Astrophysical Observation", "SAO 216554"},
    },
    visualMagnitude: 9.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91057842),
        dec: Angle.Degrees(-47.50977356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72938"},
        {"Hipparcos Number", "HIP 42004"},
        {"Geneva Identification System", "GEN# +1.00072938"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.41375710),
        dec: Angle.Degrees(-47.50849256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99190"},
        {"Hipparcos Number", "HIP 55672"},
        {"Smithsonian Astrophysical Observation", "SAO 222774"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.10561842),
        dec: Angle.Degrees(-47.50597038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23771"},
        {"Hipparcos Number", "HIP 17564"},
        {"Smithsonian Astrophysical Observation", "SAO 216473"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.41925355),
        dec: Angle.Degrees(-47.50545925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151537"},
        {"Hipparcos Number", "HIP 82399"},
        {"Smithsonian Astrophysical Observation", "SAO 227276"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.55618922),
        dec: Angle.Degrees(-47.50276362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46115"},
        {"Hipparcos Number", "HIP 30885"},
        {"Smithsonian Astrophysical Observation", "SAO 217964"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.24839740),
        dec: Angle.Degrees(-47.50164187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204019"},
        {"Hipparcos Number", "HIP 105929"},
        {"Smithsonian Astrophysical Observation", "SAO 230693"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.81232407),
        dec: Angle.Degrees(-47.50160274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75228"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59184158),
        dec: Angle.Degrees(-47.50159697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73461"},
        {"Hipparcos Number", "HIP 42240"},
        {"Celescope Catalog", "CEL 2702"},
        {"Geneva Identification System", "GEN# +1.00073461J"},
        {"Smithsonian Astrophysical Observation", "SAO 220180"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.17085478),
        dec: Angle.Degrees(-47.49987511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51705"},
        {"Hipparcos Number", "HIP 33338"},
        {"Smithsonian Astrophysical Observation", "SAO 218318"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.00181562),
        dec: Angle.Degrees(-47.49560581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11391"},
        {"Hipparcos Number", "HIP 8583"},
        {"Smithsonian Astrophysical Observation", "SAO 215675"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.69369210),
        dec: Angle.Degrees(-47.49550384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206322"},
        {"Hipparcos Number", "HIP 107187"},
        {"Smithsonian Astrophysical Observation", "SAO 230801"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66336740),
        dec: Angle.Degrees(-47.49475576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98477"},
        {"Hipparcos Number", "HIP 55276"},
        {"Geneva Identification System", "GEN# +1.00098477"},
        {"Smithsonian Astrophysical Observation", "SAO 222714"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.81254292),
        dec: Angle.Degrees(-47.49462642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206095"},
        {"Hipparcos Number", "HIP 107073"},
        {"Smithsonian Astrophysical Observation", "SAO 230791"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.28285672),
        dec: Angle.Degrees(-47.49346885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94579"},
        {"Hipparcos Number", "HIP 53322"},
        {"Smithsonian Astrophysical Observation", "SAO 222411"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.59918795),
        dec: Angle.Degrees(-47.49155158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30832"},
        {"Hipparcos Number", "HIP 22332"},
        {"Smithsonian Astrophysical Observation", "SAO 217005"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14519487),
        dec: Angle.Degrees(-47.48975302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86699"},
        {"Hipparcos Number", "HIP 48929"},
        {"Geneva Identification System", "GEN# +1.00086699"},
        {"Smithsonian Astrophysical Observation", "SAO 221658"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.73126811),
        dec: Angle.Degrees(-47.48942553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141911"},
        {"Hipparcos Number", "HIP 77832"},
        {"Geneva Identification System", "GEN# +1.00141911"},
        {"Smithsonian Astrophysical Observation", "SAO 226337"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.38545544),
        dec: Angle.Degrees(-47.48498797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216619"},
        {"Hipparcos Number", "HIP 113170"},
        {"Smithsonian Astrophysical Observation", "SAO 231350"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74952374),
        dec: Angle.Degrees(-47.48486041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41743"},
        {"Hipparcos Number", "HIP 28768"},
        {"Geneva Identification System", "GEN# +1.00041743"},
        {"Smithsonian Astrophysical Observation", "SAO 217704"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12655437),
        dec: Angle.Degrees(-47.48086166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84583"},
        {"Hipparcos Number", "HIP 47822"},
        {"Geneva Identification System", "GEN# +1.00084583"},
        {"Smithsonian Astrophysical Observation", "SAO 221448"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22122062),
        dec: Angle.Degrees(-47.48038705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193506"},
        {"Hipparcos Number", "HIP 100479"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.64325581),
        dec: Angle.Degrees(-47.47931066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95286"},
        {"Hipparcos Number", "HIP 53714"},
        {"Smithsonian Astrophysical Observation", "SAO 222476"},
    },
    visualMagnitude: 9.39,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.85780272),
        dec: Angle.Degrees(-47.47858371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79039"},
        {"Hipparcos Number", "HIP 44996"},
        {"Geneva Identification System", "GEN# +1.00079039"},
        {"Smithsonian Astrophysical Observation", "SAO 220912"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.47014750),
        dec: Angle.Degrees(-47.47621660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143700"},
        {"Hipparcos Number", "HIP 78706"},
        {"Geneva Identification System", "GEN# +1.00143700"},
        {"Smithsonian Astrophysical Observation", "SAO 226469"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.00909183),
        dec: Angle.Degrees(-47.47608227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88746"},
        {"Henry Draper 2", "HD 88746A"},
        {"Hipparcos Number", "HIP 50036"},
        {"Geneva Identification System", "GEN# +1.00088746"},
        {"Smithsonian Astrophysical Observation", "SAO 221866"},
        {"Wilson Evans Batten Catalogue", "WEB 9199"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.23377267),
        dec: Angle.Degrees(-47.47568273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36889"},
        {"Hipparcos Number", "HIP 25963"},
        {"Geneva Identification System", "GEN# +1.00036889"},
        {"Smithsonian Astrophysical Observation", "SAO 217387"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.08569030),
        dec: Angle.Degrees(-47.47533353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123550"},
        {"Hipparcos Number", "HIP 69175"},
        {"Smithsonian Astrophysical Observation", "SAO 224730"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.39760990),
        dec: Angle.Degrees(-47.47388453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66406"},
        {"Hipparcos Number", "HIP 39205"},
        {"Smithsonian Astrophysical Observation", "SAO 219309"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.29873177),
        dec: Angle.Degrees(-47.47307418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102385"},
        {"Hipparcos Number", "HIP 57471"},
        {"Smithsonian Astrophysical Observation", "SAO 223023"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.71110566),
        dec: Angle.Degrees(-47.47289615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138164"},
        {"Hipparcos Number", "HIP 76077"},
        {"Geneva Identification System", "GEN# +1.00138164"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.06926793),
        dec: Angle.Degrees(-47.47051244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85081"},
        {"Hipparcos Number", "HIP 48086"},
        {"Geneva Identification System", "GEN# +1.00085081"},
        {"Smithsonian Astrophysical Observation", "SAO 221501"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.04956834),
        dec: Angle.Degrees(-47.47014620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191465"},
        {"Hipparcos Number", "HIP 99548"},
        {"Smithsonian Astrophysical Observation", "SAO 230094"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02891583),
        dec: Angle.Degrees(-47.46830014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157042"},
        {"Hipparcos Number", "HIP 85079"},
        {"Celescope Catalog", "CEL 4507"},
        {"Fundamental Katalog 5th Edition", "FK5 3379"},
        {"Geneva Identification System", "GEN# +1.00157042A"},
        {"Smithsonian Astrophysical Observation", "SAO 227886"},
        {"Wilson Evans Batten Catalogue", "WEB 14363"},
    },
    visualMagnitude: 5.21,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.81700400),
        dec: Angle.Degrees(-47.46815380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34569"},
        {"Hipparcos Number", "HIP 24554"},
        {"Smithsonian Astrophysical Observation", "SAO 217261"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.01152208),
        dec: Angle.Degrees(-47.46814317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221909"},
        {"Hipparcos Number", "HIP 116489"},
        {"Smithsonian Astrophysical Observation", "SAO 231686"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.07330151),
        dec: Angle.Degrees(-47.46603685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191913"},
        {"Hipparcos Number", "HIP 99744"},
        {"Smithsonian Astrophysical Observation", "SAO 230114"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.57731304),
        dec: Angle.Degrees(-47.46332651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141407"},
        {"Hipparcos Number", "HIP 77626"},
        {"Geneva Identification System", "GEN# +1.00141407"},
        {"Smithsonian Astrophysical Observation", "SAO 226279"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.72176701),
        dec: Angle.Degrees(-47.46027906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93336"},
        {"Hipparcos Number", "HIP 52622"},
        {"Smithsonian Astrophysical Observation", "SAO 222303"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.42103489),
        dec: Angle.Degrees(-47.45981597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182072"},
        {"Hipparcos Number", "HIP 95469"},
        {"Geneva Identification System", "GEN# +1.00182072"},
        {"Smithsonian Astrophysical Observation", "SAO 229667"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.29247306),
        dec: Angle.Degrees(-47.45668266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105207"},
        {"Hipparcos Number", "HIP 59071"},
        {"Smithsonian Astrophysical Observation", "SAO 223221"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.70893621),
        dec: Angle.Degrees(-47.45571859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107392"},
        {"Hipparcos Number", "HIP 60219"},
        {"Geneva Identification System", "GEN# +1.00107392"},
        {"Smithsonian Astrophysical Observation", "SAO 223364"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.22571699),
        dec: Angle.Degrees(-47.45465013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223518"},
        {"Hipparcos Number", "HIP 117547"},
        {"Smithsonian Astrophysical Observation", "SAO 231802"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.57695943),
        dec: Angle.Degrees(-47.45376862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115870"},
    },
    visualMagnitude: 11.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.13087814),
        dec: Angle.Degrees(-47.45358939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163027"},
        {"Hipparcos Number", "HIP 87826"},
        {"Smithsonian Astrophysical Observation", "SAO 228560"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10481177),
        dec: Angle.Degrees(-47.45181540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52521"},
        {"Hipparcos Number", "HIP 33625"},
        {"Smithsonian Astrophysical Observation", "SAO 218368"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.78835673),
        dec: Angle.Degrees(-47.45106658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93102"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50181614),
        dec: Angle.Degrees(-47.45058125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197357"},
        {"Hipparcos Number", "HIP 102392"},
        {"Smithsonian Astrophysical Observation", "SAO 230346"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.23754355),
        dec: Angle.Degrees(-47.44934807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88304"},
        {"Hipparcos Number", "HIP 49788"},
        {"Smithsonian Astrophysical Observation", "SAO 221816"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.45087766),
        dec: Angle.Degrees(-47.44621193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41670"},
        {"Hipparcos Number", "HIP 28724"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.01242285),
        dec: Angle.Degrees(-47.44606398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199302"},
        {"Hipparcos Number", "HIP 103497"},
        {"Smithsonian Astrophysical Observation", "SAO 230462"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.52871503),
        dec: Angle.Degrees(-47.44561015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96338"},
        {"Hipparcos Number", "HIP 54231"},
        {"Geneva Identification System", "GEN# +1.00096338"},
        {"Smithsonian Astrophysical Observation", "SAO 222560"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.44069977),
        dec: Angle.Degrees(-47.44229047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78005"},
        {"Hipparcos Number", "HIP 44509"},
        {"Geneva Identification System", "GEN# +1.00078005"},
        {"Smithsonian Astrophysical Observation", "SAO 220802"},
        {"Wilson Evans Batten Catalogue", "WEB 8525"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.02412427),
        dec: Angle.Degrees(-47.44146376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15800"},
        {"Hipparcos Number", "HIP 11704"},
        {"Smithsonian Astrophysical Observation", "SAO 215929"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.74965135),
        dec: Angle.Degrees(-47.44137153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129858"},
        {"Hipparcos Number", "HIP 72250"},
        {"Geneva Identification System", "GEN# +1.00129858"},
        {"Smithsonian Astrophysical Observation", "SAO 225178"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.62094963),
        dec: Angle.Degrees(-47.44107999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160844"},
        {"Hipparcos Number", "HIP 86829"},
        {"Smithsonian Astrophysical Observation", "SAO 228353"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.13427125),
        dec: Angle.Degrees(-47.44066667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72017"},
        {"Hipparcos Number", "HIP 41566"},
        {"Geneva Identification System", "GEN# +1.00072017"},
        {"Smithsonian Astrophysical Observation", "SAO 219973"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.13286350),
        dec: Angle.Degrees(-47.43923422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91488"},
        {"Hipparcos Number", "HIP 51634"},
        {"Smithsonian Astrophysical Observation", "SAO 222135"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.23158062),
        dec: Angle.Degrees(-47.43577067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219761"},
        {"Hipparcos Number", "HIP 115098"},
        {"Fundamental Katalog 5th Edition", "FK5 3866"},
        {"Geneva Identification System", "GEN# +1.00219761"},
        {"Smithsonian Astrophysical Observation", "SAO 231542"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.69179570),
        dec: Angle.Degrees(-47.43537493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47352"},
        {"Hipparcos Number", "HIP 31487"},
        {"Smithsonian Astrophysical Observation", "SAO 218048"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.91379615),
        dec: Angle.Degrees(-47.43347673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1398"},
        {"Geneva Identification System", "GEN# +6.20145159"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.37534847),
        dec: Angle.Degrees(-47.43322991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26522"},
        {"Hipparcos Number", "HIP 19419"},
        {"Smithsonian Astrophysical Observation", "SAO 216673"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.38337968),
        dec: Angle.Degrees(-47.43016620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33761"},
        {"Hipparcos Number", "HIP 24039"},
        {"Smithsonian Astrophysical Observation", "SAO 217211"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51117802),
        dec: Angle.Degrees(-47.42798120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162619"},
        {"Hipparcos Number", "HIP 87660"},
        {"Fundamental Katalog 5th Edition", "FK5 5573"},
        {"Geneva Identification System", "GEN# +1.00162619"},
        {"Smithsonian Astrophysical Observation", "SAO 228529"},
        {"Wilson Evans Batten Catalogue", "WEB 14795"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.57611940),
        dec: Angle.Degrees(-47.42682959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89550"},
    },
    visualMagnitude: 11.76,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.08639971),
        dec: Angle.Degrees(-47.42445053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137235"},
        {"Hipparcos Number", "HIP 75596"},
        {"Fundamental Katalog 5th Edition", "FK5 5368"},
        {"Geneva Identification System", "GEN# +1.00137235"},
        {"Smithsonian Astrophysical Observation", "SAO 225781"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.68200960),
        dec: Angle.Degrees(-47.42150308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82185"},
        {"Hipparcos Number", "HIP 46489"},
        {"Smithsonian Astrophysical Observation", "SAO 221207"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.22620230),
        dec: Angle.Degrees(-47.41932716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79792"},
        {"Hipparcos Number", "HIP 45338"},
        {"Smithsonian Astrophysical Observation", "SAO 220981"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59210273),
        dec: Angle.Degrees(-47.41888352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117600"},
        {"Hipparcos Number", "HIP 66032"},
        {"Geneva Identification System", "GEN# +1.00117600"},
        {"Smithsonian Astrophysical Observation", "SAO 224225"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.06767787),
        dec: Angle.Degrees(-47.41835564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18851"},
        {"Hipparcos Number", "HIP 13987"},
        {"Geneva Identification System", "GEN# +1.00018851"},
        {"Smithsonian Astrophysical Observation", "SAO 216131"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.03258013),
        dec: Angle.Degrees(-47.41705002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125809"},
        {"Hipparcos Number", "HIP 70320"},
        {"Geneva Identification System", "GEN# +1.00125809"},
        {"Smithsonian Astrophysical Observation", "SAO 224881"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.81399394),
        dec: Angle.Degrees(-47.41695068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41369"},
        {"Hipparcos Number", "HIP 28603"},
        {"Geneva Identification System", "GEN# +1.00041369"},
        {"Smithsonian Astrophysical Observation", "SAO 217687"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.55885011),
        dec: Angle.Degrees(-47.41683885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10239"},
        {"Hipparcos Number", "HIP 7703"},
        {"Smithsonian Astrophysical Observation", "SAO 215600"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78487546),
        dec: Angle.Degrees(-47.41414016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59446"},
        {"Hipparcos Number", "HIP 36234"},
        {"Celescope Catalog", "CEL 1873"},
        {"Geneva Identification System", "GEN# +1.00059446"},
        {"Smithsonian Astrophysical Observation", "SAO 218743"},
        {"Wilson Evans Batten Catalogue", "WEB 7217"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.92825633),
        dec: Angle.Degrees(-47.41402132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4773"},
        {"Hipparcos Number", "HIP 3835"},
        {"Smithsonian Astrophysical Observation", "SAO 215247"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.30990403),
        dec: Angle.Degrees(-47.41337196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30361"},
        {"Hipparcos Number", "HIP 22062"},
        {"Geneva Identification System", "GEN# +1.00030361"},
        {"Smithsonian Astrophysical Observation", "SAO 216977"},
        {"Wilson Evans Batten Catalogue", "WEB 4240"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.17911300),
        dec: Angle.Degrees(-47.41165673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 249.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30479"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.10459296),
        dec: Angle.Degrees(-47.40629155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130717"},
        {"Hipparcos Number", "HIP 72654"},
        {"Smithsonian Astrophysical Observation", "SAO 225239"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.82017916),
        dec: Angle.Degrees(-47.40589709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5388"},
        {"Hipparcos Number", "HIP 4311"},
        {"Geneva Identification System", "GEN# +1.00005388"},
        {"Smithsonian Astrophysical Observation", "SAO 215291"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79982952),
        dec: Angle.Degrees(-47.40553270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221260"},
        {"Hipparcos Number", "HIP 116045"},
        {"Smithsonian Astrophysical Observation", "SAO 231640"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.70559932),
        dec: Angle.Degrees(-47.40506203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90671"},
        {"Hipparcos Number", "HIP 51180"},
        {"Smithsonian Astrophysical Observation", "SAO 222066"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.80513303),
        dec: Angle.Degrees(-47.40448531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77904"},
        {"Hipparcos Number", "HIP 44462"},
        {"Geneva Identification System", "GEN# +1.00077904"},
        {"Smithsonian Astrophysical Observation", "SAO 220793"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.87449276),
        dec: Angle.Degrees(-47.40418158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55798"},
        {"Hipparcos Number", "HIP 34790"},
        {"Smithsonian Astrophysical Observation", "SAO 218527"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.03207657),
        dec: Angle.Degrees(-47.40384405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206855"},
        {"Hipparcos Number", "HIP 107485"},
        {"Fundamental Katalog 5th Edition", "FK5 5922"},
        {"Smithsonian Astrophysical Observation", "SAO 230832"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.56079644),
        dec: Angle.Degrees(-47.40312354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74712"},
        {"Hipparcos Number", "HIP 42831"},
        {"Geneva Identification System", "GEN# +1.00074712"},
        {"Smithsonian Astrophysical Observation", "SAO 220356"},
        {"Wilson Evans Batten Catalogue", "WEB 8274"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.91122542),
        dec: Angle.Degrees(-47.40312305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38326"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77388657),
        dec: Angle.Degrees(-47.40177457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149742"},
        {"Hipparcos Number", "HIP 81511"},
        {"Smithsonian Astrophysical Observation", "SAO 226995"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.74026526),
        dec: Angle.Degrees(-47.40083340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68275"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.65823599),
        dec: Angle.Degrees(-47.40016421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73949"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.67644996),
        dec: Angle.Degrees(-47.39786987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189307"},
        {"Hipparcos Number", "HIP 98577"},
        {"Geneva Identification System", "GEN# +1.00189307J"},
        {"Smithsonian Astrophysical Observation", "SAO 229991"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.35501567),
        dec: Angle.Degrees(-47.39732722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113524"},
        {"Hipparcos Number", "HIP 63836"},
        {"Smithsonian Astrophysical Observation", "SAO 223883"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.24779843),
        dec: Angle.Degrees(-47.39677239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108307"},
        {"Hipparcos Number", "HIP 60743"},
        {"Smithsonian Astrophysical Observation", "SAO 223446"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.73578592),
        dec: Angle.Degrees(-47.39672455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98517"},
        {"Hipparcos Number", "HIP 55303"},
        {"Smithsonian Astrophysical Observation", "SAO 222718"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.88458043),
        dec: Angle.Degrees(-47.39637921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189857"},
        {"Hipparcos Number", "HIP 98837"},
        {"Smithsonian Astrophysical Observation", "SAO 230021"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.06480175),
        dec: Angle.Degrees(-47.39590397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55350"},
        {"Hipparcos Number", "HIP 34623"},
        {"Smithsonian Astrophysical Observation", "SAO 218501"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.55817841),
        dec: Angle.Degrees(-47.39579716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75103"},
        {"Hipparcos Number", "HIP 43037"},
        {"Celescope Catalog", "CEL 2882"},
        {"Geneva Identification System", "GEN# +1.00075103"},
        {"Smithsonian Astrophysical Observation", "SAO 220429"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.53687224),
        dec: Angle.Degrees(-47.39536708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76186"},
        {"Hipparcos Number", "HIP 43602"},
        {"Celescope Catalog", "CEL 3031"},
        {"Geneva Identification System", "GEN# +1.00076186"},
        {"Smithsonian Astrophysical Observation", "SAO 220612"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19897543),
        dec: Angle.Degrees(-47.39429993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26429"},
        {"Hipparcos Number", "HIP 19351"},
        {"Smithsonian Astrophysical Observation", "SAO 216668"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.18414753),
        dec: Angle.Degrees(-47.39422009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21892"},
        {"Hipparcos Number", "HIP 16272"},
        {"Geneva Identification System", "GEN# +1.00021892"},
        {"Smithsonian Astrophysical Observation", "SAO 216348"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.44750841),
        dec: Angle.Degrees(-47.39291594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65817"},
        {"Hipparcos Number", "HIP 38974"},
        {"Celescope Catalog", "CEL 2122"},
        {"Geneva Identification System", "GEN# +1.00065817"},
        {"Smithsonian Astrophysical Observation", "SAO 219230"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.62855925),
        dec: Angle.Degrees(-47.39212329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16529"},
        {"Hipparcos Number", "HIP 12236"},
        {"Smithsonian Astrophysical Observation", "SAO 215970"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.38373806),
        dec: Angle.Degrees(-47.39209406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6157"},
        {"Hipparcos Number", "HIP 4831"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.51860700),
        dec: Angle.Degrees(-47.39065436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117273"},
        {"Hipparcos Number", "HIP 65869"},
        {"Smithsonian Astrophysical Observation", "SAO 224193"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.51288149),
        dec: Angle.Degrees(-47.38903509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83584"},
        {"Hipparcos Number", "HIP 47283"},
        {"Geneva Identification System", "GEN# +1.00083584"},
        {"Smithsonian Astrophysical Observation", "SAO 221357"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.53917045),
        dec: Angle.Degrees(-47.38818825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129056"},
        {"Hipparcos Number", "HIP 71860"},
        {"Fundamental Katalog 5th Edition", "FK5 541"},
        {"Geneva Identification System", "GEN# +1.00129056"},
        {"Smithsonian Astrophysical Observation", "SAO 225128"},
        {"Wilson Evans Batten Catalogue", "WEB 12374"},
    },
    visualMagnitude: 2.30,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48239101),
        dec: Angle.Degrees(-47.38814127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109670"},
    },
    visualMagnitude: 11.48,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.24839767),
        dec: Angle.Degrees(-47.38618788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12055"},
        {"Hipparcos Number", "HIP 9095"},
        {"Geneva Identification System", "GEN# +1.00012055"},
        {"Smithsonian Astrophysical Observation", "SAO 215715"},
        {"Wilson Evans Batten Catalogue", "WEB 1910"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.29163705),
        dec: Angle.Degrees(-47.38529869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13925"},
        {"Hipparcos Number", "HIP 10410"},
        {"Smithsonian Astrophysical Observation", "SAO 215830"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.53014363),
        dec: Angle.Degrees(-47.38484483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82516"},
        {"Hipparcos Number", "HIP 46677"},
        {"Cincinnati Publication", "Ci 20 535"},
        {"Geneva Identification System", "GEN# +1.00082516"},
        {"Smithsonian Astrophysical Observation", "SAO 221240"},
        {"Wilson Evans Batten Catalogue", "WEB 8807"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.74566736),
        dec: Angle.Degrees(-47.38321821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 372.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128414"},
        {"Hipparcos Number", "HIP 71569"},
        {"Smithsonian Astrophysical Observation", "SAO 225077"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.55373845),
        dec: Angle.Degrees(-47.38253484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329545"},
        {"Hipparcos Number", "HIP 83893"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19398666),
        dec: Angle.Degrees(-47.36788159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38761"},
        {"Hipparcos Number", "HIP 27174"},
        {"Smithsonian Astrophysical Observation", "SAO 217516"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.39444292),
        dec: Angle.Degrees(-47.38246232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99096"},
        {"Hipparcos Number", "HIP 55631"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.95094430),
        dec: Angle.Degrees(-47.37863128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62275"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.42774617),
        dec: Angle.Degrees(-47.37826580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223549"},
        {"Hipparcos Number", "HIP 117571"},
        {"Smithsonian Astrophysical Observation", "SAO 231804"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.64846531),
        dec: Angle.Degrees(-47.37701473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95238"},
        {"Hipparcos Number", "HIP 53692"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.78057956),
        dec: Angle.Degrees(-47.37597467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213828"},
        {"Hipparcos Number", "HIP 111482"},
        {"Smithsonian Astrophysical Observation", "SAO 231204"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.80229136),
        dec: Angle.Degrees(-47.37586047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21981"},
        {"Hipparcos Number", "HIP 16339"},
        {"Fundamental Katalog 5th Edition", "FK5 2250"},
        {"Geneva Identification System", "GEN# +1.00021981"},
        {"Smithsonian Astrophysical Observation", "SAO 216357"},
        {"Wilson Evans Batten Catalogue", "WEB 3126"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65374344),
        dec: Angle.Degrees(-47.37517410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168062"},
        {"Hipparcos Number", "HIP 89866"},
        {"Smithsonian Astrophysical Observation", "SAO 228921"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08102791),
        dec: Angle.Degrees(-47.37346840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107931"},
        {"Hipparcos Number", "HIP 60517"},
        {"Geneva Identification System", "GEN# +1.00107931"},
        {"Smithsonian Astrophysical Observation", "SAO 223411"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.08927767),
        dec: Angle.Degrees(-47.37293131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100733"},
        {"Hipparcos Number", "HIP 56518"},
        {"Geneva Identification System", "GEN# +1.00100733"},
        {"Smithsonian Astrophysical Observation", "SAO 222887"},
        {"Wilson Evans Batten Catalogue", "WEB 10158"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.80565752),
        dec: Angle.Degrees(-47.37256106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145842"},
        {"Hipparcos Number", "HIP 79653"},
        {"Geneva Identification System", "GEN# +1.00145842"},
        {"Smithsonian Astrophysical Observation", "SAO 226600"},
        {"Wilson Evans Batten Catalogue", "WEB 13478"},
    },
    visualMagnitude: 5.13,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81394732),
        dec: Angle.Degrees(-47.37190984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67637"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.87965948),
        dec: Angle.Degrees(-47.37152339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87783"},
        {"Hipparcos Number", "HIP 49485"},
        {"Geneva Identification System", "GEN# +1.00087783J"},
        {"Smithsonian Astrophysical Observation", "SAO 221773"},
        {"Wilson Evans Batten Catalogue", "WEB 9135"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.54675512),
        dec: Angle.Degrees(-47.36986491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120275"},
        {"Hipparcos Number", "HIP 67468"},
        {"Geneva Identification System", "GEN# +1.00120275"},
        {"Smithsonian Astrophysical Observation", "SAO 224468"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.39312295),
        dec: Angle.Degrees(-47.36930643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64195"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.35601760),
        dec: Angle.Degrees(-47.36826725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44146"},
        {"Hipparcos Number", "HIP 29908"},
        {"Smithsonian Astrophysical Observation", "SAO 217833"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.45822383),
        dec: Angle.Degrees(-47.36724355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104807"},
        {"Hipparcos Number", "HIP 58842"},
        {"Smithsonian Astrophysical Observation", "SAO 223201"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02300781),
        dec: Angle.Degrees(-47.36702522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160650"},
        {"Hipparcos Number", "HIP 86745"},
        {"Smithsonian Astrophysical Observation", "SAO 228329"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.88392574),
        dec: Angle.Degrees(-47.36587778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165023"},
        {"Hipparcos Number", "HIP 88690"},
        {"Geneva Identification System", "GEN# +1.00165023"},
        {"Smithsonian Astrophysical Observation", "SAO 228694"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.58581362),
        dec: Angle.Degrees(-47.36546254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73678"},
        {"Hipparcos Number", "HIP 42321"},
        {"Geneva Identification System", "GEN# +1.00073678"},
        {"Smithsonian Astrophysical Observation", "SAO 220208"},
        {"Wilson Evans Batten Catalogue", "WEB 8135"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.42013506),
        dec: Angle.Degrees(-47.36197787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23719"},
        {"Hipparcos Number", "HIP 17534"},
        {"Geneva Identification System", "GEN# +1.00023719"},
        {"Smithsonian Astrophysical Observation", "SAO 216470"},
        {"Wilson Evans Batten Catalogue", "WEB 3326"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.31616344),
        dec: Angle.Degrees(-47.35945424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63301"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.58769969),
        dec: Angle.Degrees(-47.35937309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89967"},
        {"Hipparcos Number", "HIP 50761"},
        {"Smithsonian Astrophysical Observation", "SAO 221988"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.48462228),
        dec: Angle.Degrees(-47.35912367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98637"},
        {"Hipparcos Number", "HIP 55386"},
        {"Smithsonian Astrophysical Observation", "SAO 222731"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.12252506),
        dec: Angle.Degrees(-47.35863912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93067"},
        {"Hipparcos Number", "HIP 52499"},
        {"Smithsonian Astrophysical Observation", "SAO 222280"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.00647819),
        dec: Angle.Degrees(-47.35846137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96518"},
        {"Hipparcos Number", "HIP 54324"},
        {"Smithsonian Astrophysical Observation", "SAO 222574"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.70089668),
        dec: Angle.Degrees(-47.35729275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159285"},
        {"Hipparcos Number", "HIP 86139"},
        {"Geneva Identification System", "GEN# +1.00159285"},
        {"Smithsonian Astrophysical Observation", "SAO 228170"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.05285136),
        dec: Angle.Degrees(-47.35585277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91099"},
        {"Hipparcos Number", "HIP 51416"},
        {"Smithsonian Astrophysical Observation", "SAO 222103"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52115691),
        dec: Angle.Degrees(-47.35427050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87025"},
        {"Hipparcos Number", "HIP 49085"},
        {"Geneva Identification System", "GEN# +1.00087025"},
        {"Smithsonian Astrophysical Observation", "SAO 221700"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.27085945),
        dec: Angle.Degrees(-47.35280773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43547"},
        {"Hipparcos Number", "HIP 29610"},
        {"Geneva Identification System", "GEN# +1.00043547"},
        {"Smithsonian Astrophysical Observation", "SAO 217798"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.59945301),
        dec: Angle.Degrees(-47.34490872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222910"},
        {"Hipparcos Number", "HIP 117144"},
        {"Geneva Identification System", "GEN# +1.00222910"},
        {"Smithsonian Astrophysical Observation", "SAO 231761"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.22602622),
        dec: Angle.Degrees(-47.34457670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61007"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54936456),
        dec: Angle.Degrees(-47.34159354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35689"},
        {"Hipparcos Number", "HIP 25256"},
        {"Geneva Identification System", "GEN# +1.00035689"},
        {"Smithsonian Astrophysical Observation", "SAO 217320"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.02214177),
        dec: Angle.Degrees(-47.34047445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201426"},
        {"Hipparcos Number", "HIP 104578"},
        {"Smithsonian Astrophysical Observation", "SAO 230563"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.76309173),
        dec: Angle.Degrees(-47.33971500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79621"},
        {"Hipparcos Number", "HIP 45270"},
        {"Celescope Catalog", "CEL 3230"},
        {"Geneva Identification System", "GEN# +1.00079621"},
        {"Smithsonian Astrophysical Observation", "SAO 220965"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.39364708),
        dec: Angle.Degrees(-47.33843989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39953",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Regor"},
        {"Henry Draper", "HD 68273"},
        {"Hipparcos Number", "HIP 39953"},
        {"Celescope Catalog", "CEL 2193"},
        {"Fundamental Katalog 5th Edition", "FK5 309"},
        {"Geneva Identification System", "GEN# +1.00068273"},
        {"Smithsonian Astrophysical Observation", "SAO 219504"},
        {"Wilson Evans Batten Catalogue", "WEB 7786"},
    },
    visualMagnitude: 1.75,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.38314727),
        dec: Angle.Degrees(-47.33661177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53443"},
        {"Hipparcos Number", "HIP 33950"},
        {"Smithsonian Astrophysical Observation", "SAO 218402"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.67177812),
        dec: Angle.Degrees(-47.33545749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191119"},
        {"Hipparcos Number", "HIP 99380"},
        {"Smithsonian Astrophysical Observation", "SAO 230079"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.56622989),
        dec: Angle.Degrees(-47.33187288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84713"},
        {"Hipparcos Number", "HIP 47901"},
        {"Geneva Identification System", "GEN# +1.00084713"},
        {"Smithsonian Astrophysical Observation", "SAO 221468"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.43785765),
        dec: Angle.Degrees(-47.33161072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93223"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.83983800),
        dec: Angle.Degrees(-47.32984772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110685"},
        {"Hipparcos Number", "HIP 62142"},
        {"Smithsonian Astrophysical Observation", "SAO 223631"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.05434978),
        dec: Angle.Degrees(-47.32831684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72631"},
        {"Hipparcos Number", "HIP 41855"},
        {"Geneva Identification System", "GEN# +1.00072631"},
        {"Smithsonian Astrophysical Observation", "SAO 220059"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.00762174),
        dec: Angle.Degrees(-47.32774806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199833"},
        {"Hipparcos Number", "HIP 103741"},
        {"Smithsonian Astrophysical Observation", "SAO 230483"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.34068428),
        dec: Angle.Degrees(-47.32743282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158988"},
        {"Hipparcos Number", "HIP 86002"},
        {"Smithsonian Astrophysical Observation", "SAO 228136"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.65966078),
        dec: Angle.Degrees(-47.32709839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222363"},
        {"Hipparcos Number", "HIP 116774"},
        {"Smithsonian Astrophysical Observation", "SAO 231726"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.99941122),
        dec: Angle.Degrees(-47.32649420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50503"},
        {"Hipparcos Number", "HIP 32883"},
        {"Fundamental Katalog 5th Edition", "FK5 4626"},
        {"Geneva Identification System", "GEN# +1.00050503"},
        {"Smithsonian Astrophysical Observation", "SAO 218251"},
        {"Wilson Evans Batten Catalogue", "WEB 6617"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.77958309),
        dec: Angle.Degrees(-47.32615047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83707"},
        {"Hipparcos Number", "HIP 47357"},
        {"Smithsonian Astrophysical Observation", "SAO 221368"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.73947270),
        dec: Angle.Degrees(-47.32284963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32170"},
        {"Hipparcos Number", "HIP 23142"},
        {"Smithsonian Astrophysical Observation", "SAO 217095"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.69071785),
        dec: Angle.Degrees(-47.32223595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157100"},
        {"Hipparcos Number", "HIP 85102"},
        {"Geneva Identification System", "GEN# +1.00157100"},
        {"Smithsonian Astrophysical Observation", "SAO 227894"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.88843274),
        dec: Angle.Degrees(-47.32183029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26778"},
        {"Hipparcos Number", "HIP 19599"},
        {"Smithsonian Astrophysical Observation", "SAO 216688"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99784168),
        dec: Angle.Degrees(-47.32090575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155389"},
        {"Hipparcos Number", "HIP 84267"},
        {"Celescope Catalog", "CEL 4489"},
        {"Geneva Identification System", "GEN# +1.00155389"},
        {"Smithsonian Astrophysical Observation", "SAO 227721"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.38449839),
        dec: Angle.Degrees(-47.31934768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200855"},
        {"Hipparcos Number", "HIP 104289"},
        {"Cincinnati Publication", "Ci 20 1258"},
        {"Geneva Identification System", "GEN# +1.00200855"},
        {"Smithsonian Astrophysical Observation", "SAO 230531"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.91306291),
        dec: Angle.Degrees(-47.31839792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -555.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74272"},
        {"Hipparcos Number", "HIP 42624"},
        {"Celescope Catalog", "CEL 2782"},
        {"Geneva Identification System", "GEN# +1.00074272"},
        {"Smithsonian Astrophysical Observation", "SAO 220284"},
        {"Wilson Evans Batten Catalogue", "WEB 8229"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.30475030),
        dec: Angle.Degrees(-47.31714129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24500"},
        {"Hipparcos Number", "HIP 18066"},
        {"Geneva Identification System", "GEN# +1.00024500"},
        {"Smithsonian Astrophysical Observation", "SAO 216527"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.92411252),
        dec: Angle.Degrees(-47.31693365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65360"},
        {"Hipparcos Number", "HIP 38766"},
        {"Celescope Catalog", "CEL 2105"},
        {"Geneva Identification System", "GEN# +1.00065360"},
        {"Smithsonian Astrophysical Observation", "SAO 219168"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.03826202),
        dec: Angle.Degrees(-47.31642568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59132"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.88609448),
        dec: Angle.Degrees(-47.31545746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37434"},
        {"Hipparcos Number", "HIP 26300"},
        {"Geneva Identification System", "GEN# +1.00037434"},
        {"Smithsonian Astrophysical Observation", "SAO 217422"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.01188868),
        dec: Angle.Degrees(-47.31372679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65188"},
        {"Hipparcos Number", "HIP 38700"},
        {"Fundamental Katalog 5th Edition", "FK5 4712"},
        {"Smithsonian Astrophysical Observation", "SAO 219150"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.85020038),
        dec: Angle.Degrees(-47.31308512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193940"},
        {"Hipparcos Number", "HIP 100695"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.21250212),
        dec: Angle.Degrees(-47.31110709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149782"},
        {"Hipparcos Number", "HIP 81533"},
        {"Geneva Identification System", "GEN# +1.00149782"},
        {"Smithsonian Astrophysical Observation", "SAO 227000"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.80188010),
        dec: Angle.Degrees(-47.30991180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92188"},
        {"Hipparcos Number", "HIP 52024"},
        {"Geneva Identification System", "GEN# +1.00092188"},
        {"Smithsonian Astrophysical Observation", "SAO 222205"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.43502598),
        dec: Angle.Degrees(-47.30835133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9608"},
        {"Hipparcos Number", "HIP 7237"},
        {"Geneva Identification System", "GEN# +1.00009608"},
        {"Smithsonian Astrophysical Observation", "SAO 215555"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31727503),
        dec: Angle.Degrees(-47.30657686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 208.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98037"},
        {"Hipparcos Number", "HIP 55038"},
        {"Fundamental Katalog 5th Edition", "FK5 4991"},
        {"Smithsonian Astrophysical Observation", "SAO 222683"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.00066616),
        dec: Angle.Degrees(-47.30569717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101066"},
        {"Hipparcos Number", "HIP 56696"},
        {"Geneva Identification System", "GEN# +1.00101066"},
        {"Smithsonian Astrophysical Observation", "SAO 222916"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.38240249),
        dec: Angle.Degrees(-47.30471415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66079"},
        {"Hipparcos Number", "HIP 39084"},
        {"Celescope Catalog", "CEL 2131"},
        {"Geneva Identification System", "GEN# +1.00066079J"},
        {"Smithsonian Astrophysical Observation", "SAO 219265"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.94138074),
        dec: Angle.Degrees(-47.30354719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207129"},
        {"Hipparcos Number", "HIP 107649"},
        {"Fundamental Katalog 5th Edition", "FK5 1573"},
        {"Geneva Identification System", "GEN# +1.00207129"},
        {"Smithsonian Astrophysical Observation", "SAO 230846"},
        {"Wilson Evans Batten Catalogue", "WEB 19421"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.06503724),
        dec: Angle.Degrees(-47.30289790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58540"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.06687043),
        dec: Angle.Degrees(-47.30259459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66462"},
        {"Hipparcos Number", "HIP 39234"},
        {"Smithsonian Astrophysical Observation", "SAO 219316"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.37070971),
        dec: Angle.Degrees(-47.30058735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118253"},
        {"Hipparcos Number", "HIP 66381"},
        {"Smithsonian Astrophysical Observation", "SAO 224272"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.14759727),
        dec: Angle.Degrees(-47.29925808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148809"},
        {"Hipparcos Number", "HIP 81025"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.22769906),
        dec: Angle.Degrees(-47.29841782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202895"},
        {"Hipparcos Number", "HIP 105353"},
        {"Geneva Identification System", "GEN# +1.00202895"},
        {"Smithsonian Astrophysical Observation", "SAO 230638"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.09085921),
        dec: Angle.Degrees(-47.29813533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69057"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.02760356),
        dec: Angle.Degrees(-47.29694498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188519"},
        {"Hipparcos Number", "HIP 98224"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.41189351),
        dec: Angle.Degrees(-47.29692719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36671"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.16004351),
        dec: Angle.Degrees(-47.29639214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48291"},
        {"Hipparcos Number", "HIP 31920"},
        {"Smithsonian Astrophysical Observation", "SAO 218119"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.06402730),
        dec: Angle.Degrees(-47.29633017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39083"},
        {"Smithsonian Astrophysical Observation", "SAO 219264"},
    },
    visualMagnitude: 9.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.93951403),
        dec: Angle.Degrees(-47.29564462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20555"},
        {"Hipparcos Number", "HIP 15240"},
        {"Geneva Identification System", "GEN# +1.00020555"},
        {"Smithsonian Astrophysical Observation", "SAO 216238"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.13769066),
        dec: Angle.Degrees(-47.29535457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8411"},
        {"Hipparcos Number", "HIP 6415"},
        {"Geneva Identification System", "GEN# +1.00008411"},
        {"Smithsonian Astrophysical Observation", "SAO 215479"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.59519080),
        dec: Angle.Degrees(-47.29476677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113932"},
        {"Hipparcos Number", "HIP 64060"},
        {"Smithsonian Astrophysical Observation", "SAO 223918"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.93116449),
        dec: Angle.Degrees(-47.29251095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8106"},
        {"Hipparcos Number", "HIP 6207"},
        {"Fundamental Katalog 5th Edition", "FK5 4118"},
        {"Geneva Identification System", "GEN# +1.00008106"},
        {"Smithsonian Astrophysical Observation", "SAO 215460"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.89144175),
        dec: Angle.Degrees(-47.29229544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196171"},
        {"Hipparcos Number", "HIP 101772"},
        {"Fundamental Katalog 5th Edition", "FK5 769"},
        {"Geneva Identification System", "GEN# +1.00196171"},
        {"Smithsonian Astrophysical Observation", "SAO 230300"},
        {"Wilson Evans Batten Catalogue", "WEB 18387"},
    },
    visualMagnitude: 3.11,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.39162365),
        dec: Angle.Degrees(-47.29166239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61406"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72583111),
        dec: Angle.Degrees(-47.28858038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -388.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121263"},
        {"Hipparcos Number", "HIP 68002"},
        {"Fundamental Katalog 5th Edition", "FK5 512"},
        {"Geneva Identification System", "GEN# +1.00121263"},
        {"Smithsonian Astrophysical Observation", "SAO 224538"},
        {"Wilson Evans Batten Catalogue", "WEB 11943"},
    },
    visualMagnitude: 2.55,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.88514539),
        dec: Angle.Degrees(-47.28826634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6236"},
        {"Hipparcos Number", "HIP 4882"},
        {"Geneva Identification System", "GEN# +1.00006236"},
        {"Smithsonian Astrophysical Observation", "SAO 215342"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.68345889),
        dec: Angle.Degrees(-47.28725845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113030"},
        {"Hipparcos Number", "HIP 63557"},
        {"Smithsonian Astrophysical Observation", "SAO 223844"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.35287800),
        dec: Angle.Degrees(-47.28587251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25005"},
        {"Hipparcos Number", "HIP 18416"},
        {"Smithsonian Astrophysical Observation", "SAO 216561"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.05977497),
        dec: Angle.Degrees(-47.28548981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61668"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.62476388),
        dec: Angle.Degrees(-47.28348807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197386"},
        {"Hipparcos Number", "HIP 102408"},
        {"Smithsonian Astrophysical Observation", "SAO 230348"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.28716744),
        dec: Angle.Degrees(-47.28317303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155809"},
        {"Hipparcos Number", "HIP 84471"},
        {"Smithsonian Astrophysical Observation", "SAO 227758"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03957026),
        dec: Angle.Degrees(-47.28309704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72537"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.45939368),
        dec: Angle.Degrees(-47.28219553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47351"},
        {"Hipparcos Number", "HIP 31494"},
        {"Smithsonian Astrophysical Observation", "SAO 218049"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.94030172),
        dec: Angle.Degrees(-47.28204919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35569"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.11896443),
        dec: Angle.Degrees(-47.28076713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62226"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.29466043),
        dec: Angle.Degrees(-47.27998595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63463"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.07001874),
        dec: Angle.Degrees(-47.27609124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63707"},
        {"Hipparcos Number", "HIP 38075"},
        {"Geneva Identification System", "GEN# +1.00063707"},
        {"Smithsonian Astrophysical Observation", "SAO 219013"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.03809070),
        dec: Angle.Degrees(-47.27567865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174691"},
        {"Hipparcos Number", "HIP 92750"},
        {"Smithsonian Astrophysical Observation", "SAO 229354"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.50671087),
        dec: Angle.Degrees(-47.27428374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34025"},
        {"Hipparcos Number", "HIP 24215"},
        {"Smithsonian Astrophysical Observation", "SAO 217233"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.99642261),
        dec: Angle.Degrees(-47.27408415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94702"},
    },
    visualMagnitude: 12.29,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.05124303),
        dec: Angle.Degrees(-47.27371179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329305"},
        {"Hipparcos Number", "HIP 82992"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.39793246),
        dec: Angle.Degrees(-47.27243540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31974"},
        {"Hipparcos Number", "HIP 23051"},
        {"Geneva Identification System", "GEN# +1.00031974"},
        {"Smithsonian Astrophysical Observation", "SAO 217084"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.40890505),
        dec: Angle.Degrees(-47.27233675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66047",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dofida"},
        {"Henry Draper", "HD 117618"},
        {"Hipparcos Number", "HIP 66047"},
        {"Geneva Identification System", "GEN# +1.00117618"},
        {"Smithsonian Astrophysical Observation", "SAO 224228"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.10639192),
        dec: Angle.Degrees(-47.27105993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216923"},
        {"Hipparcos Number", "HIP 113376"},
        {"Smithsonian Astrophysical Observation", "SAO 231367"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.42504952),
        dec: Angle.Degrees(-47.27023497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16691"},
        {"Geneva Identification System", "GEN# -0.04701087"},
        {"Wilson Evans Batten Catalogue", "WEB 3179"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.68445459),
        dec: Angle.Degrees(-47.27019148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107477"},
        {"Hipparcos Number", "HIP 60267"},
        {"Smithsonian Astrophysical Observation", "SAO 223375"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.36710617),
        dec: Angle.Degrees(-47.26921377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82631"},
        {"Hipparcos Number", "HIP 46747"},
        {"Smithsonian Astrophysical Observation", "SAO 221251"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.92535831),
        dec: Angle.Degrees(-47.26700039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9350"},
        {"Hipparcos Number", "HIP 7063"},
        {"Smithsonian Astrophysical Observation", "SAO 215534"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.75877561),
        dec: Angle.Degrees(-47.26424460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3461"},
        {"Hipparcos Number", "HIP 2931"},
        {"Geneva Identification System", "GEN# +1.00003461"},
        {"Smithsonian Astrophysical Observation", "SAO 215168"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.29074966),
        dec: Angle.Degrees(-47.26401600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9566"},
        {"Hipparcos Number", "HIP 7207"},
        {"Geneva Identification System", "GEN# +1.00009566"},
        {"Smithsonian Astrophysical Observation", "SAO 215552"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21237384),
        dec: Angle.Degrees(-47.26345175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212554"},
        {"Hipparcos Number", "HIP 110748"},
        {"Smithsonian Astrophysical Observation", "SAO 231137"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.54854716),
        dec: Angle.Degrees(-47.26333800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174713"},
        {"Hipparcos Number", "HIP 92760"},
        {"Fundamental Katalog 5th Edition", "FK5 5666"},
        {"Smithsonian Astrophysical Observation", "SAO 229356"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.53803461),
        dec: Angle.Degrees(-47.26312848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106043"},
        {"Geneva Identification System", "GEN# +6.20145081"},
    },
    visualMagnitude: 12.20,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.18516207),
        dec: Angle.Degrees(-47.26156242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154744"},
        {"Hipparcos Number", "HIP 83943"},
        {"Celescope Catalog", "CEL 4480"},
        {"Geneva Identification System", "GEN# +1.00154744"},
        {"Smithsonian Astrophysical Observation", "SAO 227672"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.37474959),
        dec: Angle.Degrees(-47.26083255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30042"},
        {"Hipparcos Number", "HIP 21843"},
        {"Geneva Identification System", "GEN# +1.00030042"},
        {"Smithsonian Astrophysical Observation", "SAO 216939"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.44227164),
        dec: Angle.Degrees(-47.26002393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46434"},
        {"Hipparcos Number", "HIP 31051"},
        {"Smithsonian Astrophysical Observation", "SAO 217988"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.73762043),
        dec: Angle.Degrees(-47.25757951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42667"},
        {"Hipparcos Number", "HIP 29191"},
        {"Smithsonian Astrophysical Observation", "SAO 217745"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.36507344),
        dec: Angle.Degrees(-47.25535218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161516"},
        {"Hipparcos Number", "HIP 87146"},
        {"Smithsonian Astrophysical Observation", "SAO 228428"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.07199273),
        dec: Angle.Degrees(-47.25512361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217726"},
        {"Hipparcos Number", "HIP 113839"},
        {"Geneva Identification System", "GEN# +1.00217726"},
        {"Smithsonian Astrophysical Observation", "SAO 231412"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.79818011),
        dec: Angle.Degrees(-47.25509141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92040"},
        {"Hipparcos Number", "HIP 51947"},
        {"Geneva Identification System", "GEN# +1.00092040"},
        {"Smithsonian Astrophysical Observation", "SAO 222191"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.18359834),
        dec: Angle.Degrees(-47.25497250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67820"},
        {"Hipparcos Number", "HIP 39768"},
        {"Geneva Identification System", "GEN# +1.00067820"},
        {"Smithsonian Astrophysical Observation", "SAO 219449"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.91983075),
        dec: Angle.Degrees(-47.25490513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155365"},
        {"Hipparcos Number", "HIP 84258"},
        {"Fundamental Katalog 5th Edition", "FK5 5520"},
        {"Smithsonian Astrophysical Observation", "SAO 227720"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.36222456),
        dec: Angle.Degrees(-47.25259133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77511"},
        {"Hipparcos Number", "HIP 44282"},
        {"Geneva Identification System", "GEN# +1.00077511"},
        {"Renson", "Renson 21910"},
        {"Smithsonian Astrophysical Observation", "SAO 220759"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.28518044),
        dec: Angle.Degrees(-47.25146612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27769"},
        {"Hipparcos Number", "HIP 20280"},
        {"Smithsonian Astrophysical Observation", "SAO 216756"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.20263052),
        dec: Angle.Degrees(-47.25116972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119119"},
        {"Hipparcos Number", "HIP 66876"},
        {"Geneva Identification System", "GEN# +1.00119119"},
        {"Smithsonian Astrophysical Observation", "SAO 224354"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.58967440),
        dec: Angle.Degrees(-47.25007780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146779"},
        {"Hipparcos Number", "HIP 80031"},
        {"Smithsonian Astrophysical Observation", "SAO 226664"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.05059753),
        dec: Angle.Degrees(-47.24923665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73546"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.47219021),
        dec: Angle.Degrees(-47.24791681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73550"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.47812320),
        dec: Angle.Degrees(-47.24621027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117896"},
        {"Hipparcos Number", "HIP 66209"},
        {"Geneva Identification System", "GEN# +1.00117896"},
        {"Smithsonian Astrophysical Observation", "SAO 224248"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.55496272),
        dec: Angle.Degrees(-47.24392404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195349"},
        {"Hipparcos Number", "HIP 101361"},
        {"Smithsonian Astrophysical Observation", "SAO 230263"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.15236304),
        dec: Angle.Degrees(-47.24281921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61290"},
        {"Hipparcos Number", "HIP 37008"},
        {"Smithsonian Astrophysical Observation", "SAO 218835"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.09587988),
        dec: Angle.Degrees(-47.24214671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165584"},
        {"Hipparcos Number", "HIP 88917"},
        {"Smithsonian Astrophysical Observation", "SAO 228739"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.25022399),
        dec: Angle.Degrees(-47.24195526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72555"},
        {"Hipparcos Number", "HIP 41828"},
        {"Celescope Catalog", "CEL 2611"},
        {"Geneva Identification System", "GEN# +1.00072555"},
        {"Smithsonian Astrophysical Observation", "SAO 220051"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.91521078),
        dec: Angle.Degrees(-47.24104812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151988"},
        {"Hipparcos Number", "HIP 82594"},
        {"Smithsonian Astrophysical Observation", "SAO 227338"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.26571690),
        dec: Angle.Degrees(-47.24025919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74529"},
        {"Hipparcos Number", "HIP 42747"},
        {"Geneva Identification System", "GEN# +1.00074529"},
        {"Smithsonian Astrophysical Observation", "SAO 220323"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.68099135),
        dec: Angle.Degrees(-47.24025589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105956"},
        {"Hipparcos Number", "HIP 59453"},
        {"Geneva Identification System", "GEN# +1.00105956"},
        {"Smithsonian Astrophysical Observation", "SAO 223270"},
        {"Wilson Evans Batten Catalogue", "WEB 10568"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.91860940),
        dec: Angle.Degrees(-47.24003168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213111"},
        {"Hipparcos Number", "HIP 111070"},
        {"Smithsonian Astrophysical Observation", "SAO 231165"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.52085826),
        dec: Angle.Degrees(-47.23778296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173466"},
        {"Hipparcos Number", "HIP 92232"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.94699242),
        dec: Angle.Degrees(-47.23693981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77140"},
        {"Hipparcos Number", "HIP 44093"},
        {"Celescope Catalog", "CEL 3125"},
        {"Geneva Identification System", "GEN# +1.00077140A"},
        {"Renson", "Renson 21760"},
        {"Smithsonian Astrophysical Observation", "SAO 220717"},
        {"Wilson Evans Batten Catalogue", "WEB 8471"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.71844252),
        dec: Angle.Degrees(-47.23482313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204769"},
        {"Hipparcos Number", "HIP 106348"},
        {"Renson", "Renson 57010"},
        {"Smithsonian Astrophysical Observation", "SAO 230728"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.08088618),
        dec: Angle.Degrees(-47.23337687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329868"},
        {"Hipparcos Number", "HIP 77268"},
        {"Cincinnati Publication", "Ci 20 943"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.63422693),
        dec: Angle.Degrees(-47.23252006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -403.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161858"},
        {"Hipparcos Number", "HIP 87302"},
        {"Geneva Identification System", "GEN# +1.00161858"},
        {"Smithsonian Astrophysical Observation", "SAO 228464"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.57859129),
        dec: Angle.Degrees(-47.23050740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126240"},
        {"Hipparcos Number", "HIP 70537"},
        {"Smithsonian Astrophysical Observation", "SAO 224912"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.44284388),
        dec: Angle.Degrees(-47.22969087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112843"},
        {"Geneva Identification System", "GEN# +6.20145118"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.75790017),
        dec: Angle.Degrees(-47.22658787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174201"},
        {"Hipparcos Number", "HIP 92560"},
        {"Smithsonian Astrophysical Observation", "SAO 229325"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.92222135),
        dec: Angle.Degrees(-47.22577294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79996"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.95121430),
        dec: Angle.Degrees(-47.22391668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53665"},
        {"Geneva Identification System", "GEN# -0.04606608"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.69622597),
        dec: Angle.Degrees(-47.22312920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49260"},
        {"Hipparcos Number", "HIP 32354"},
        {"Celescope Catalog", "CEL 1377"},
        {"Geneva Identification System", "GEN# +1.00049260"},
        {"Smithsonian Astrophysical Observation", "SAO 218170"},
        {"Wilson Evans Batten Catalogue", "WEB 6526"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.29370355),
        dec: Angle.Degrees(-47.22273354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111535"},
        {"Hipparcos Number", "HIP 62665"},
        {"Geneva Identification System", "GEN# +1.00111535"},
        {"Smithsonian Astrophysical Observation", "SAO 223699"},
        {"Wilson Evans Batten Catalogue", "WEB 11117"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.60679932),
        dec: Angle.Degrees(-47.22225493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26043"},
        {"Hipparcos Number", "HIP 19073"},
        {"Geneva Identification System", "GEN# +1.00026043"},
        {"Smithsonian Astrophysical Observation", "SAO 216635"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.31444475),
        dec: Angle.Degrees(-47.22224565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30218"},
        {"Hipparcos Number", "HIP 21969"},
        {"Smithsonian Astrophysical Observation", "SAO 216956"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.83484961),
        dec: Angle.Degrees(-47.22156450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170069"},
        {"Hipparcos Number", "HIP 90662"},
        {"Geneva Identification System", "GEN# +1.00170069"},
        {"Smithsonian Astrophysical Observation", "SAO 229064"},
        {"Wilson Evans Batten Catalogue", "WEB 15523"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.48298947),
        dec: Angle.Degrees(-47.22051319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92847"},
        {"Hipparcos Number", "HIP 52378"},
        {"Fundamental Katalog 5th Edition", "FK5 2857"},
        {"Smithsonian Astrophysical Observation", "SAO 222268"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.59162676),
        dec: Angle.Degrees(-47.22024387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146711"},
        {"Hipparcos Number", "HIP 79997"},
        {"Geneva Identification System", "GEN# +1.00146711"},
        {"Smithsonian Astrophysical Observation", "SAO 226660"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.95384945),
        dec: Angle.Degrees(-47.21869232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114529"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.96610224),
        dec: Angle.Degrees(-47.21862237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136937"},
        {"Hipparcos Number", "HIP 75482"},
        {"Geneva Identification System", "GEN# +1.00136937"},
        {"Smithsonian Astrophysical Observation", "SAO 225754"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.29662822),
        dec: Angle.Degrees(-47.21742515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49444"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.41593367),
        dec: Angle.Degrees(-16.94232443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -334.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119510"},
        {"Hipparcos Number", "HIP 67066"},
        {"Geneva Identification System", "GEN# +1.00119510"},
        {"Smithsonian Astrophysical Observation", "SAO 224387"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.16000019),
        dec: Angle.Degrees(-47.21719964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87562"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.32413791),
        dec: Angle.Degrees(-47.21703822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64318"},
        {"Hipparcos Number", "HIP 38345"},
        {"Celescope Catalog", "CEL 2065"},
        {"Geneva Identification System", "GEN# +1.00064318"},
        {"Smithsonian Astrophysical Observation", "SAO 219071"},
        {"Wilson Evans Batten Catalogue", "WEB 7541"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80823867),
        dec: Angle.Degrees(-47.21643402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208936"},
        {"Hipparcos Number", "HIP 108673"},
        {"Smithsonian Astrophysical Observation", "SAO 230937"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.22965283),
        dec: Angle.Degrees(-47.21319551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69214"},
        {"Hipparcos Number", "HIP 40309"},
        {"Geneva Identification System", "GEN# +1.00069214"},
        {"Smithsonian Astrophysical Observation", "SAO 219638"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.46933117),
        dec: Angle.Degrees(-47.21174091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70251"},
        {"Hipparcos Number", "HIP 40742"},
        {"Celescope Catalog", "CEL 2365"},
        {"Geneva Identification System", "GEN# +1.00070251"},
        {"Smithsonian Astrophysical Observation", "SAO 219781"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.74297743),
        dec: Angle.Degrees(-47.21094327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193113"},
        {"Hipparcos Number", "HIP 100298"},
        {"Smithsonian Astrophysical Observation", "SAO 230162"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.13266263),
        dec: Angle.Degrees(-47.21079948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80997"},
        {"Hipparcos Number", "HIP 45899"},
        {"Smithsonian Astrophysical Observation", "SAO 221099"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.37083726),
        dec: Angle.Degrees(-47.21073145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214953"},
        {"Henry Draper 2", "HD 214953A"},
        {"Hipparcos Number", "HIP 112117"},
        {"Geneva Identification System", "GEN# +1.00214953A"},
        {"Smithsonian Astrophysical Observation", "SAO 231257"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.65365518),
        dec: Angle.Degrees(-47.21000778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -331.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44591"},
        {"Hipparcos Number", "HIP 30106"},
        {"Smithsonian Astrophysical Observation", "SAO 217860"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.03149530),
        dec: Angle.Degrees(-47.20987580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29113"},
        {"Hipparcos Number", "HIP 21199"},
        {"Smithsonian Astrophysical Observation", "SAO 216870"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.17881833),
        dec: Angle.Degrees(-47.20982687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215455"},
        {"Hipparcos Number", "HIP 112403"},
        {"Smithsonian Astrophysical Observation", "SAO 231282"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.51127876),
        dec: Angle.Degrees(-47.20722954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112437"},
        {"Hipparcos Number", "HIP 63219"},
        {"Geneva Identification System", "GEN# +1.00112437"},
        {"Smithsonian Astrophysical Observation", "SAO 223784"},
        {"Wilson Evans Batten Catalogue", "WEB 11206"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.29574797),
        dec: Angle.Degrees(-47.20703086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80528"},
        {"Hipparcos Number", "HIP 45681"},
        {"Celescope Catalog", "CEL 3263"},
        {"Smithsonian Astrophysical Observation", "SAO 221052"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.69505184),
        dec: Angle.Degrees(-47.20480099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17989"},
        {"Hipparcos Number", "HIP 13346"},
        {"Smithsonian Astrophysical Observation", "SAO 216075"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.93632706),
        dec: Angle.Degrees(-47.20352334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219532"},
        {"Hipparcos Number", "HIP 114945"},
        {"Smithsonian Astrophysical Observation", "SAO 231534"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.22952287),
        dec: Angle.Degrees(-47.20240278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127445"},
        {"Hipparcos Number", "HIP 71133"},
        {"Geneva Identification System", "GEN# +1.00127445"},
        {"Smithsonian Astrophysical Observation", "SAO 225009"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.21537299),
        dec: Angle.Degrees(-47.20128291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37636"},
        {"Hipparcos Number", "HIP 26428"},
        {"Smithsonian Astrophysical Observation", "SAO 217435"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.36553616),
        dec: Angle.Degrees(-47.20114696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22609"},
        {"Hipparcos Number", "HIP 16800"},
        {"Smithsonian Astrophysical Observation", "SAO 216401"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.06162532),
        dec: Angle.Degrees(-47.20089274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36610"},
        {"Hipparcos Number", "HIP 25797"},
        {"Smithsonian Astrophysical Observation", "SAO 217370"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.63056412),
        dec: Angle.Degrees(-47.20061056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34436"},
        {"Hipparcos Number", "HIP 24460"},
        {"Geneva Identification System", "GEN# +1.00034436"},
        {"Smithsonian Astrophysical Observation", "SAO 217254"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.73022261),
        dec: Angle.Degrees(-47.19622639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219106"},
        {"Hipparcos Number", "HIP 114673"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.45651371),
        dec: Angle.Degrees(-47.19432650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20252"},
        {"Hipparcos Number", "HIP 15018"},
        {"Smithsonian Astrophysical Observation", "SAO 216220"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.39586782),
        dec: Angle.Degrees(-47.19356837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4066"},
        {"Hipparcos Number", "HIP 3343"},
        {"Geneva Identification System", "GEN# +1.00004066"},
        {"Smithsonian Astrophysical Observation", "SAO 215203"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.65205546),
        dec: Angle.Degrees(-47.19344510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74485"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.30448294),
        dec: Angle.Degrees(-47.18995679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178677"},
        {"Hipparcos Number", "HIP 94307"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.93420713),
        dec: Angle.Degrees(-47.18796308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40079"},
        {"Hipparcos Number", "HIP 27898"},
        {"Smithsonian Astrophysical Observation", "SAO 217610"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.55103055),
        dec: Angle.Degrees(-47.18544889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97530"},
        {"Hipparcos Number", "HIP 54787"},
        {"Smithsonian Astrophysical Observation", "SAO 222644"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.24585968),
        dec: Angle.Degrees(-47.18247114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
