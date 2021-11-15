using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_54() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173034"},
        {"Hipparcos Number", "HIP 91851"},
        {"Geneva Identification System", "GEN# +1.00173034"},
        {"Smithsonian Astrophysical Observation", "SAO 142549"},
        {"Wilson Evans Batten Catalogue", "WEB 15808"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.89241772),
        dec: Angle.Degrees(-08.36823908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146233"},
        {"Hipparcos Number", "HIP 79672"},
        {"Cincinnati Publication", "Ci 20 976"},
        {"Geneva Identification System", "GEN# +1.00146233"},
        {"Smithsonian Astrophysical Observation", "SAO 141066"},
        {"Wilson Evans Batten Catalogue", "WEB 13483"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.90472242),
        dec: Angle.Degrees(-08.36823651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -495.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11089"},
        {"Hipparcos Number", "HIP 8446"},
        {"Smithsonian Astrophysical Observation", "SAO 129515"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.22160428),
        dec: Angle.Degrees(-08.36306272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204280"},
        {"Hipparcos Number", "HIP 105970"},
        {"Smithsonian Astrophysical Observation", "SAO 145411"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.93757414),
        dec: Angle.Degrees(-08.35981722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14293"},
        {"Hipparcos Number", "HIP 10761"},
        {"Geneva Identification System", "GEN# +1.00014293"},
        {"Smithsonian Astrophysical Observation", "SAO 129815"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.61657193),
        dec: Angle.Degrees(-08.35934828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 702"},
        {"Hipparcos Number", "HIP 921"},
        {"Geneva Identification System", "GEN# +1.00000702"},
        {"Geneva Identification System 2", "GEN# +1.00000701"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.85188723),
        dec: Angle.Degrees(-08.35911945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128130"},
        {"Hipparcos Number", "HIP 71344"},
        {"Smithsonian Astrophysical Observation", "SAO 140017"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.85613548),
        dec: Angle.Degrees(-08.35893114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11517"},
        {"Wilson Evans Batten Catalogue", "WEB 2405"},
    },
    visualMagnitude: 11.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.13510620),
        dec: Angle.Degrees(-08.35836448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201824"},
        {"Hipparcos Number", "HIP 104684"},
        {"Geneva Identification System", "GEN# +1.00201824"},
        {"Smithsonian Astrophysical Observation", "SAO 145194"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.07322546),
        dec: Angle.Degrees(-08.35693337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124802"},
        {"Hipparcos Number", "HIP 69678"},
        {"Smithsonian Astrophysical Observation", "SAO 139819"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.94823477),
        dec: Angle.Degrees(-08.35569460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80394"},
        {"Hipparcos Number", "HIP 45730"},
        {"Geneva Identification System", "GEN# +1.00080394"},
        {"Smithsonian Astrophysical Observation", "SAO 136755"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.84398118),
        dec: Angle.Degrees(-08.35376624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202281"},
        {"Hipparcos Number", "HIP 104904"},
        {"Geneva Identification System", "GEN# +1.00202281"},
        {"Smithsonian Astrophysical Observation", "SAO 145234"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.74247358),
        dec: Angle.Degrees(-08.35272519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2195"},
        {"Hipparcos Number", "HIP 2038"},
        {"Smithsonian Astrophysical Observation", "SAO 128758"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.46916176),
        dec: Angle.Degrees(-08.35144497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7270 AB"},
        {"Henry Draper", "HD 79825"},
        {"Hipparcos Number", "HIP 45482"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.01845471),
        dec: Angle.Degrees(-08.35035850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113122"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.62432008),
        dec: Angle.Degrees(-08.34982599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64654"},
        {"Hipparcos Number", "HIP 38627"},
        {"Smithsonian Astrophysical Observation", "SAO 135243"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.64535516),
        dec: Angle.Degrees(-08.34910550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122206"},
        {"Hipparcos Number", "HIP 68430"},
        {"Smithsonian Astrophysical Observation", "SAO 139671"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.13569988),
        dec: Angle.Degrees(-08.34904127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60759"},
        {"Hipparcos Number", "HIP 36950"},
        {"Smithsonian Astrophysical Observation", "SAO 134871"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.94867757),
        dec: Angle.Degrees(-08.34686552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132935"},
        {"Hipparcos Number", "HIP 73565"},
        {"Geneva Identification System", "GEN# +1.00132935"},
        {"Smithsonian Astrophysical Observation", "SAO 140280"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.51773088),
        dec: Angle.Degrees(-08.34476814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16315"},
        {"Hipparcos Number", "HIP 12180"},
        {"Smithsonian Astrophysical Observation", "SAO 130016"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.23726353),
        dec: Angle.Degrees(-08.34343133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14528 AB"},
        {"Henry Draper", "HD 199976"},
        {"Hipparcos Number", "HIP 103699"},
        {"Cincinnati Publication", "Ci 18 2716"},
        {"Smithsonian Astrophysical Observation", "SAO 145026"},
        {"Wilson Evans Batten Catalogue", "WEB 18873"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.20365147),
        dec: Angle.Degrees(-08.34293465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173203"},
        {"Hipparcos Number", "HIP 91923"},
        {"Geneva Identification System", "GEN# +1.00173203"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.09125991),
        dec: Angle.Degrees(-08.34290833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137206"},
        {"Hipparcos Number", "HIP 75464"},
        {"Geneva Identification System", "GEN# +1.00137206"},
        {"Smithsonian Astrophysical Observation", "SAO 140516"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.24539018),
        dec: Angle.Degrees(-08.34250384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118100"},
        {"Hipparcos Number", "HIP 66252"},
        {"Geneva Identification System", "GEN# +1.00118100"},
        {"Smithsonian Astrophysical Observation", "SAO 139419"},
        {"Wilson Evans Batten Catalogue", "WEB 11708"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.68072978),
        dec: Angle.Degrees(-08.34181579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164789"},
        {"Hipparcos Number", "HIP 88403"},
        {"Geneva Identification System", "GEN# +1.00164789"},
        {"Smithsonian Astrophysical Observation", "SAO 142049"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.76809678),
        dec: Angle.Degrees(-08.34023826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25519"},
        {"Smithsonian Astrophysical Observation", "SAO 132127"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.85736053),
        dec: Angle.Degrees(-08.33645922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152751"},
        {"Hipparcos Number", "HIP 82817"},
        {"Cincinnati Publication", "Ci 20 1013"},
        {"Geneva Identification System", "GEN# +1.00152751"},
        {"Smithsonian Astrophysical Observation", "SAO 141439"},
        {"Wilson Evans Batten Catalogue", "WEB 13999"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.87184972),
        dec: Angle.Degrees(-08.33420783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -829.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -878.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51335"},
        {"Hipparcos Number", "HIP 33385"},
        {"Geneva Identification System", "GEN# +1.00051335"},
        {"Smithsonian Astrophysical Observation", "SAO 133924"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14592739),
        dec: Angle.Degrees(-08.33372390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4394"},
        {"Hipparcos Number", "HIP 3609"},
        {"Smithsonian Astrophysical Observation", "SAO 128944"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.55446081),
        dec: Angle.Degrees(-08.33158521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186159"},
        {"Hipparcos Number", "HIP 97022"},
        {"Geneva Identification System", "GEN# +1.00186159"},
        {"Smithsonian Astrophysical Observation", "SAO 143724"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.77884929),
        dec: Angle.Degrees(-08.32949937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221383"},
        {"Hipparcos Number", "HIP 116124"},
        {"Smithsonian Astrophysical Observation", "SAO 146755"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.94316406),
        dec: Angle.Degrees(-08.32860072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97662"},
        {"Hipparcos Number", "HIP 54877"},
        {"Smithsonian Astrophysical Observation", "SAO 138076"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.55353112),
        dec: Angle.Degrees(-08.32781983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38801"},
        {"Hipparcos Number", "HIP 27384"},
        {"Smithsonian Astrophysical Observation", "SAO 132543"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.99670528),
        dec: Angle.Degrees(-08.32751645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35929"},
        {"Hipparcos Number", "HIP 25546"},
        {"Geneva Identification System", "GEN# +1.00035929"},
        {"Smithsonian Astrophysical Observation", "SAO 132136"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.92829703),
        dec: Angle.Degrees(-08.32733450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165402"},
        {"Hipparcos Number", "HIP 88670"},
        {"Fundamental Katalog 5th Edition", "FK5 3436"},
        {"Geneva Identification System", "GEN# +1.00165402"},
        {"Smithsonian Astrophysical Observation", "SAO 142083"},
        {"Wilson Evans Batten Catalogue", "WEB 15022"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.53083743),
        dec: Angle.Degrees(-08.32391503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5835"},
        {"Hipparcos Number", "HIP 4657"},
        {"Geneva Identification System", "GEN# +1.00005835"},
        {"Smithsonian Astrophysical Observation", "SAO 129070"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.96211029),
        dec: Angle.Degrees(-08.32324752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82809"},
        {"Geneva Identification System", "GEN# +6.00106750"},
        {"Geneva Identification System 2", "GEN# +1.00152751C"},
        {"Geneva Identification System 3", "GEN# +6.10010643"},
        {"Wilson Evans Batten Catalogue", "WEB 14000"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.85710273),
        dec: Angle.Degrees(-08.32039997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -813.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -895.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39616"},
        {"Hipparcos Number", "HIP 27831"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.33220763),
        dec: Angle.Degrees(-08.31946264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7377"},
        {"Hipparcos Number", "HIP 5741"},
        {"Smithsonian Astrophysical Observation", "SAO 129186"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43699068),
        dec: Angle.Degrees(-08.31581127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85320"},
        {"Hipparcos Number", "HIP 48306"},
        {"Smithsonian Astrophysical Observation", "SAO 137180"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.72200349),
        dec: Angle.Degrees(-08.31553542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52965"},
        {"Hipparcos Number", "HIP 33963"},
        {"Geneva Identification System", "GEN# +2.23230003"},
        {"Renson", "Renson 14540"},
        {"Smithsonian Astrophysical Observation", "SAO 134105"},
        {"New General Catalogue", "NGC 2323 3"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.70779763),
        dec: Angle.Degrees(-08.31350997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174109"},
        {"Hipparcos Number", "HIP 92351"},
        {"Smithsonian Astrophysical Observation", "SAO 142654"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.33249809),
        dec: Angle.Degrees(-08.31250970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207502"},
        {"Hipparcos Number", "HIP 107743"},
        {"Smithsonian Astrophysical Observation", "SAO 145689"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.38909985),
        dec: Angle.Degrees(-08.31205025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16208 AB"},
        {"Henry Draper", "HD 215114"},
        {"Hipparcos Number", "HIP 112168"},
        {"Geneva Identification System", "GEN# +1.00215114"},
        {"Smithsonian Astrophysical Observation", "SAO 146271"},
        {"Wilson Evans Batten Catalogue", "WEB 20018"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76418447),
        dec: Angle.Degrees(-08.31143105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60853"},
        {"Hipparcos Number", "HIP 37000"},
        {"Geneva Identification System", "GEN# +1.00060853"},
        {"Smithsonian Astrophysical Observation", "SAO 134883"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06945503),
        dec: Angle.Degrees(-08.31131007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49610"},
        {"Hipparcos Number", "HIP 32667"},
        {"Smithsonian Astrophysical Observation", "SAO 133711"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.20541627),
        dec: Angle.Degrees(-08.31024742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150381"},
        {"Hipparcos Number", "HIP 81663"},
        {"Smithsonian Astrophysical Observation", "SAO 141307"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23506622),
        dec: Angle.Degrees(-08.30962635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41177"},
        {"Hipparcos Number", "HIP 28653"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.75662710),
        dec: Angle.Degrees(-08.30906402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63653"},
        {"Hipparcos Number", "HIP 38214"},
        {"Geneva Identification System", "GEN# +1.00063653"},
        {"Smithsonian Astrophysical Observation", "SAO 135146"},
        {"Wilson Evans Batten Catalogue", "WEB 7527"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.43149812),
        dec: Angle.Degrees(-08.30841976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5199"},
        {"Hipparcos Number", "HIP 4211"},
        {"Smithsonian Astrophysical Observation", "SAO 129016"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.42895083),
        dec: Angle.Degrees(-08.30806736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3567"},
        {"Hipparcos Number", "HIP 3026"},
        {"Geneva Identification System", "GEN# +1.00003567"},
        {"Smithsonian Astrophysical Observation", "SAO 128872"},
        {"Wilson Evans Batten Catalogue", "WEB 541"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63306283),
        dec: Angle.Degrees(-08.30794772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -547.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186158"},
        {"Hipparcos Number", "HIP 97016"},
        {"Geneva Identification System", "GEN# +1.00186158"},
        {"Smithsonian Astrophysical Observation", "SAO 143722"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76360379),
        dec: Angle.Degrees(-08.30726550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79322"},
        {"Hipparcos Number", "HIP 45239"},
        {"Smithsonian Astrophysical Observation", "SAO 136672"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.31424829),
        dec: Angle.Degrees(-08.30279526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42205"},
        {"Hipparcos Number", "HIP 29163"},
        {"Smithsonian Astrophysical Observation", "SAO 132888"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.27828477),
        dec: Angle.Degrees(-08.30157730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207863"},
        {"Hipparcos Number", "HIP 107959"},
        {"Smithsonian Astrophysical Observation", "SAO 145715"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08587230),
        dec: Angle.Degrees(-08.30155523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109772"},
        {"Hipparcos Number", "HIP 61599"},
        {"Smithsonian Astrophysical Observation", "SAO 138878"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.33860380),
        dec: Angle.Degrees(-08.30027491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33972"},
        {"Geneva Identification System", "GEN# +2.23230002"},
        {"Smithsonian Astrophysical Observation", "SAO 134109"},
        {"New General Catalogue", "NGC 2323 2"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.72878478),
        dec: Angle.Degrees(-08.29907838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3144"},
        {"Hipparcos Number", "HIP 2721"},
        {"Geneva Identification System", "GEN# +1.00003144"},
        {"Smithsonian Astrophysical Observation", "SAO 128833"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.66027875),
        dec: Angle.Degrees(-08.29775587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93666"},
        {"Hipparcos Number", "HIP 52860"},
        {"Smithsonian Astrophysical Observation", "SAO 137801"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.16163317),
        dec: Angle.Degrees(-08.29497409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72745"},
        {"Hipparcos Number", "HIP 42047"},
        {"Smithsonian Astrophysical Observation", "SAO 136052"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.55335534),
        dec: Angle.Degrees(-08.29401704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29183"},
        {"Hipparcos Number", "HIP 21382"},
        {"Smithsonian Astrophysical Observation", "SAO 131338"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.83803570),
        dec: Angle.Degrees(-08.29168442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35353"},
        {"Hipparcos Number", "HIP 25227"},
        {"Celescope Catalog", "CEL 673"},
        {"Geneva Identification System", "GEN# +1.00035353"},
        {"Renson", "Renson 9030"},
        {"Smithsonian Astrophysical Observation", "SAO 132061"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.93181680),
        dec: Angle.Degrees(-08.28958421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90721"},
        {"Hipparcos Number", "HIP 51281"},
        {"Smithsonian Astrophysical Observation", "SAO 137587"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.11511083),
        dec: Angle.Degrees(-08.28946271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94950"},
        {"Hipparcos Number", "HIP 53575"},
        {"Smithsonian Astrophysical Observation", "SAO 137909"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.40738822),
        dec: Angle.Degrees(-08.28664950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122409"},
        {"Hipparcos Number", "HIP 68535"},
        {"Smithsonian Astrophysical Observation", "SAO 139689"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.45241106),
        dec: Angle.Degrees(-08.28594869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64836"},
        {"Hipparcos Number", "HIP 38710"},
        {"Smithsonian Astrophysical Observation", "SAO 135261"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.87958010),
        dec: Angle.Degrees(-08.28501667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9564 A"},
        {"Henry Draper", "HD 135725"},
        {"Henry Draper 2", "HD 135725A"},
        {"Hipparcos Number", "HIP 74771"},
        {"Cincinnati Publication", "Ci 18 2035"},
        {"Geneva Identification System", "GEN# +1.00135725"},
        {"Smithsonian Astrophysical Observation", "SAO 140428"},
        {"Wilson Evans Batten Catalogue", "WEB 12757"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.22113088),
        dec: Angle.Degrees(-08.28501626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34993"},
        {"Hipparcos Number", "HIP 24995"},
        {"Smithsonian Astrophysical Observation", "SAO 132019"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.29128725),
        dec: Angle.Degrees(-08.28486704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89973"},
        {"Smithsonian Astrophysical Observation", "SAO 142240"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.35993457),
        dec: Angle.Degrees(-08.28270387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213562"},
        {"Hipparcos Number", "HIP 111258"},
        {"Smithsonian Astrophysical Observation", "SAO 146141"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.10883724),
        dec: Angle.Degrees(-08.28148695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37063"},
        {"Hipparcos Number", "HIP 26226"},
        {"Smithsonian Astrophysical Observation", "SAO 132318"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.82293897),
        dec: Angle.Degrees(-08.28119190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1690"},
        {"Hipparcos Number", "HIP 1692"},
        {"Smithsonian Astrophysical Observation", "SAO 128711"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.30549230),
        dec: Angle.Degrees(-08.28117086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16587 AB"},
        {"Henry Draper", "HD 218968"},
        {"Hipparcos Number", "HIP 114567"},
        {"Smithsonian Astrophysical Observation", "SAO 146561"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.11642423),
        dec: Angle.Degrees(-08.27996681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11601 A"},
        {"Henry Draper", "HD 173009"},
        {"Hipparcos Number", "HIP 91845"},
        {"Fundamental Katalog 5th Edition", "FK5 702"},
        {"Geneva Identification System", "GEN# +1.00173009"},
        {"Smithsonian Astrophysical Observation", "SAO 142546"},
        {"Wilson Evans Batten Catalogue", "WEB 15803"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.88016751),
        dec: Angle.Degrees(-08.27524299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103890"},
        {"Hipparcos Number", "HIP 58333"},
        {"Geneva Identification System", "GEN# +1.00103890"},
        {"Smithsonian Astrophysical Observation", "SAO 138502"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.44252888),
        dec: Angle.Degrees(-08.27509272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19210"},
        {"Hipparcos Number", "HIP 14355"},
        {"Smithsonian Astrophysical Observation", "SAO 130277"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.29691909),
        dec: Angle.Degrees(-08.27430166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222833"},
        {"Hipparcos Number", "HIP 117076"},
        {"Smithsonian Astrophysical Observation", "SAO 146873"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.00783088),
        dec: Angle.Degrees(-08.27178813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13345"},
        {"Geneva Identification System", "GEN# -0.00800535"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.93514174),
        dec: Angle.Degrees(-08.26929762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133375"},
        {"Hipparcos Number", "HIP 73733"},
        {"Smithsonian Astrophysical Observation", "SAO 140298"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.07787814),
        dec: Angle.Degrees(-08.26778538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17895"},
        {"Hipparcos Number", "HIP 13384"},
        {"Geneva Identification System", "GEN# +1.00017895"},
        {"Smithsonian Astrophysical Observation", "SAO 130157"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.05910507),
        dec: Angle.Degrees(-08.26702678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203238"},
        {"Hipparcos Number", "HIP 105424"},
        {"Geneva Identification System", "GEN# +1.00203238"},
        {"Smithsonian Astrophysical Observation", "SAO 145320"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.31741567),
        dec: Angle.Degrees(-08.26675906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74122"},
        {"Hipparcos Number", "HIP 42676"},
        {"Smithsonian Astrophysical Observation", "SAO 136190"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.46981120),
        dec: Angle.Degrees(-08.26529138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80617"},
        {"Smithsonian Astrophysical Observation", "SAO 141185"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.92061908),
        dec: Angle.Degrees(-08.26312212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78014"},
        {"Hipparcos Number", "HIP 44632"},
        {"Geneva Identification System", "GEN# +1.00078014"},
        {"Smithsonian Astrophysical Observation", "SAO 136572"},
        {"Wilson Evans Batten Catalogue", "WEB 8539"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.42156224),
        dec: Angle.Degrees(-08.26096964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113153"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.70471288),
        dec: Angle.Degrees(-08.26072040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74643"},
        {"Hipparcos Number", "HIP 42924"},
        {"Geneva Identification System", "GEN# +1.00074643"},
        {"Smithsonian Astrophysical Observation", "SAO 136237"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.21827137),
        dec: Angle.Degrees(-08.25657193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28980"},
        {"Hipparcos Number", "HIP 21258"},
        {"Smithsonian Astrophysical Observation", "SAO 131301"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.41037742),
        dec: Angle.Degrees(-08.25565086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78353"},
        {"Geneva Identification System", "GEN# -0.00704156"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97192634),
        dec: Angle.Degrees(-08.25314327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129698"},
        {"Hipparcos Number", "HIP 72047"},
        {"Fundamental Katalog 5th Edition", "FK5 5306"},
        {"Geneva Identification System", "GEN# +1.00129698"},
        {"Smithsonian Astrophysical Observation", "SAO 140100"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.05748120),
        dec: Angle.Degrees(-08.25210733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145207"},
        {"Hipparcos Number", "HIP 79211"},
        {"Smithsonian Astrophysical Observation", "SAO 141002"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.49960387),
        dec: Angle.Degrees(-08.25159528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164828"},
        {"Hipparcos Number", "HIP 88431"},
        {"Smithsonian Astrophysical Observation", "SAO 142054"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.82205656),
        dec: Angle.Degrees(-08.25007778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16583"},
        {"Hipparcos Number", "HIP 12378"},
        {"Smithsonian Astrophysical Observation", "SAO 130040"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.83383620),
        dec: Angle.Degrees(-08.24873031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125924"},
        {"Hipparcos Number", "HIP 70275"},
        {"Geneva Identification System", "GEN# +1.00125924"},
        {"Renson", "Renson 35940"},
        {"Smithsonian Astrophysical Observation", "SAO 139900"},
        {"Wilson Evans Batten Catalogue", "WEB 12202"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.67913658),
        dec: Angle.Degrees(-08.24819194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145318"},
        {"Hipparcos Number", "HIP 79265"},
        {"Smithsonian Astrophysical Observation", "SAO 141010"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65893912),
        dec: Angle.Degrees(-08.24429132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171443"},
        {"Hipparcos Number", "HIP 91117"},
        {"Fundamental Katalog 5th Edition", "FK5 1482"},
        {"Geneva Identification System", "GEN# +1.00171443"},
        {"Smithsonian Astrophysical Observation", "SAO 142408"},
        {"Wilson Evans Batten Catalogue", "WEB 15639"},
    },
    visualMagnitude: 3.85,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.80182442),
        dec: Angle.Degrees(-08.24330819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13087 B"},
        {"Henry Draper", "HD 188294"},
        {"Hipparcos Number", "HIP 97967"},
        {"Geneva Identification System", "GEN# +1.00188294"},
        {"Smithsonian Astrophysical Observation", "SAO 143899"},
        {"Wilson Evans Batten Catalogue", "WEB 17240"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.65858512),
        dec: Angle.Degrees(-08.23697430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44480"},
        {"Hipparcos Number", "HIP 30238"},
        {"Smithsonian Astrophysical Observation", "SAO 133156"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.42408991),
        dec: Angle.Degrees(-08.23600978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47278"},
        {"Hipparcos Number", "HIP 31656"},
        {"Celescope Catalog", "CEL 1324"},
        {"Geneva Identification System", "GEN# +1.00047278"},
        {"Smithsonian Astrophysical Observation", "SAO 133491"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.38344313),
        dec: Angle.Degrees(-08.23560841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14648 AB"},
        {"Henry Draper", "HD 201038"},
        {"Hipparcos Number", "HIP 104272"},
        {"Geneva Identification System", "GEN# +1.00201038"},
        {"Renson", "Renson 56080"},
        {"Smithsonian Astrophysical Observation", "SAO 145118"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.85951404),
        dec: Angle.Degrees(-08.23487628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6718"},
        {"Hipparcos Number", "HIP 5301"},
        {"Geneva Identification System", "GEN# +1.00006718"},
        {"Smithsonian Astrophysical Observation", "SAO 129137"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.95228938),
        dec: Angle.Degrees(-08.23375136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29064"},
        {"Hipparcos Number", "HIP 21296"},
        {"Fundamental Katalog 5th Edition", "FK5 2337"},
        {"Geneva Identification System", "GEN# +1.00029064"},
        {"Smithsonian Astrophysical Observation", "SAO 131315"},
        {"Wilson Evans Batten Catalogue", "WEB 4094"},
    },
    visualMagnitude: 5.20,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.54850732),
        dec: Angle.Degrees(-08.23135939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44547"},
        {"Hipparcos Number", "HIP 30264"},
        {"Celescope Catalog", "CEL 1199"},
        {"Geneva Identification System", "GEN# +1.00044547"},
        {"Smithsonian Astrophysical Observation", "SAO 133164"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.49362723),
        dec: Angle.Degrees(-08.22966986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34552"},
        {"Hipparcos Number", "HIP 24708"},
        {"Smithsonian Astrophysical Observation", "SAO 131962"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.50395805),
        dec: Angle.Degrees(-08.22812035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13087 A"},
        {"Henry Draper", "HD 188293"},
        {"Hipparcos Number", "HIP 97966"},
        {"Geneva Identification System", "GEN# +1.00188293"},
        {"Smithsonian Astrophysical Observation", "SAO 143898"},
        {"Wilson Evans Batten Catalogue", "WEB 17239"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.65686507),
        dec: Angle.Degrees(-08.22722614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29554"},
        {"Hipparcos Number", "HIP 21640"},
        {"Smithsonian Astrophysical Observation", "SAO 131380"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.71877891),
        dec: Angle.Degrees(-08.22480347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92243"},
        {"Hipparcos Number", "HIP 52114"},
        {"Smithsonian Astrophysical Observation", "SAO 137703"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.71077663),
        dec: Angle.Degrees(-08.22458417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130852"},
        {"Hipparcos Number", "HIP 72606"},
        {"Geneva Identification System", "GEN# +1.00130852"},
        {"Smithsonian Astrophysical Observation", "SAO 140171"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67563813),
        dec: Angle.Degrees(-08.22435351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180726"},
        {"Hipparcos Number", "HIP 94848"},
        {"Smithsonian Astrophysical Observation", "SAO 143232"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.49196486),
        dec: Angle.Degrees(-08.22344356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206070"},
        {"Hipparcos Number", "HIP 106967"},
        {"Smithsonian Astrophysical Observation", "SAO 145570"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.96280013),
        dec: Angle.Degrees(-08.22284527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145004"},
        {"Hipparcos Number", "HIP 79121"},
        {"Smithsonian Astrophysical Observation", "SAO 140990"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.25607435),
        dec: Angle.Degrees(-08.21879851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217194"},
        {"Hipparcos Number", "HIP 113488"},
        {"Smithsonian Astrophysical Observation", "SAO 146422"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.74854764),
        dec: Angle.Degrees(-08.21331333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5877 AB"},
        {"Henry Draper", "HD 55417"},
        {"Hipparcos Number", "HIP 34824"},
        {"Celescope Catalog", "CEL 1665"},
        {"Geneva Identification System", "GEN# +1.00055417J"},
        {"Smithsonian Astrophysical Observation", "SAO 134351"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.11509784),
        dec: Angle.Degrees(-08.21202539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206031"},
        {"Hipparcos Number", "HIP 106945"},
        {"Smithsonian Astrophysical Observation", "SAO 145565"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.88882066),
        dec: Angle.Degrees(-08.21171487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3274"},
        {"Hipparcos Number", "HIP 2805"},
        {"Smithsonian Astrophysical Observation", "SAO 128846"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.92763125),
        dec: Angle.Degrees(-08.20966183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32432"},
        {"Hipparcos Number", "HIP 23483"},
        {"Geneva Identification System", "GEN# +1.00032432"},
        {"Renson", "Renson 8250"},
        {"Smithsonian Astrophysical Observation", "SAO 131718"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.70290897),
        dec: Angle.Degrees(-08.20946223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158170"},
        {"Hipparcos Number", "HIP 85474"},
        {"Geneva Identification System", "GEN# +1.00158170"},
        {"Smithsonian Astrophysical Observation", "SAO 141679"},
        {"Wilson Evans Batten Catalogue", "WEB 14435"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.00994813),
        dec: Angle.Degrees(-08.20805870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36885"},
        {"Hipparcos Number", "HIP 26150"},
        {"Fundamental Katalog 5th Edition", "FK5 4504"},
        {"Smithsonian Astrophysical Observation", "SAO 132283"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.62322662),
        dec: Angle.Degrees(-08.20721998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103594"},
        {"Hipparcos Number", "HIP 58163"},
        {"Smithsonian Astrophysical Observation", "SAO 138487"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.92744174),
        dec: Angle.Degrees(-08.20366640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148114"},
        {"Hipparcos Number", "HIP 80516"},
        {"Smithsonian Astrophysical Observation", "SAO 141171"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.55126257),
        dec: Angle.Degrees(-08.20196417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24436",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rigel"},
        {"Aitken", "ADS 3823 A"},
        {"Henry Draper", "HD 34085"},
        {"Hipparcos Number", "HIP 24436"},
        {"Celescope Catalog", "CEL 579"},
        {"Fundamental Katalog 5th Edition", "FK5 194"},
        {"Smithsonian Astrophysical Observation", "SAO 131907"},
        {"Wilson Evans Batten Catalogue", "WEB 4731"},
    },
    visualMagnitude: 0.18,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.63446353),
        dec: Angle.Degrees(-08.20163919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181858"},
        {"Hipparcos Number", "HIP 95219"},
        {"Geneva Identification System", "GEN# +1.00181858"},
        {"Smithsonian Astrophysical Observation", "SAO 143321"},
        {"Wilson Evans Batten Catalogue", "WEB 16635"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.58672149),
        dec: Angle.Degrees(-08.20102055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27047"},
        {"Hipparcos Number", "HIP 19907"},
        {"Smithsonian Astrophysical Observation", "SAO 131078"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.05968926),
        dec: Angle.Degrees(-08.20040226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37358"},
        {"Hipparcos Number", "HIP 26446"},
        {"Smithsonian Astrophysical Observation", "SAO 132381"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40490433),
        dec: Angle.Degrees(-08.20039197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195563"},
        {"Hipparcos Number", "HIP 101351"},
        {"Smithsonian Astrophysical Observation", "SAO 144543"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.10802215),
        dec: Angle.Degrees(-08.19620604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7821 AB"},
        {"Henry Draper", "HD 91289"},
        {"Hipparcos Number", "HIP 51587"},
        {"Smithsonian Astrophysical Observation", "SAO 137626"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.05818295),
        dec: Angle.Degrees(-08.19470130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70407"},
        {"Hipparcos Number", "HIP 40959"},
        {"Smithsonian Astrophysical Observation", "SAO 135811"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.38569153),
        dec: Angle.Degrees(-08.19178720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28310"},
        {"Hipparcos Number", "HIP 20809"},
        {"Smithsonian Astrophysical Observation", "SAO 131229"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.88204664),
        dec: Angle.Degrees(-08.19156756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120319"},
        {"Hipparcos Number", "HIP 67402"},
        {"Smithsonian Astrophysical Observation", "SAO 139567"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.20583096),
        dec: Angle.Degrees(-08.19031157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183593"},
        {"Hipparcos Number", "HIP 95944"},
        {"Smithsonian Astrophysical Observation", "SAO 143481"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.67475048),
        dec: Angle.Degrees(-08.18646324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175377"},
        {"Hipparcos Number", "HIP 92874"},
        {"Geneva Identification System", "GEN# +1.00175377"},
        {"Wilson Evans Batten Catalogue", "WEB 16077"},
    },
    visualMagnitude: 9.08,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.86508300),
        dec: Angle.Degrees(-08.18620940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210269"},
        {"Hipparcos Number", "HIP 109369"},
        {"Geneva Identification System", "GEN# +1.00210269"},
        {"Smithsonian Astrophysical Observation", "SAO 145905"},
        {"Wilson Evans Batten Catalogue", "WEB 19651"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36184613),
        dec: Angle.Degrees(-08.18584855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169752"},
        {"Hipparcos Number", "HIP 90375"},
        {"Smithsonian Astrophysical Observation", "SAO 142315"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.61838101),
        dec: Angle.Degrees(-08.18557613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61749"},
        {"Hipparcos Number", "HIP 37394"},
        {"Geneva Identification System", "GEN# +1.00061749"},
        {"Smithsonian Astrophysical Observation", "SAO 134969"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.14796501),
        dec: Angle.Degrees(-08.18535824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225224"},
        {"Hipparcos Number", "HIP 373"},
        {"Smithsonian Astrophysical Observation", "SAO 128565"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.16597990),
        dec: Angle.Degrees(-08.18490648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91239"},
        {"Geneva Identification System", "GEN# -0.00804652"},
        {"Geneva Identification System 2", "GEN# +2.66640080"},
        {"New General Catalogue", "NGC 6664 80"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.16500708),
        dec: Angle.Degrees(-08.18481596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51360"},
        {"Hipparcos Number", "HIP 33391"},
        {"Geneva Identification System", "GEN# +1.00051360"},
        {"Smithsonian Astrophysical Observation", "SAO 133927"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.16423893),
        dec: Angle.Degrees(-08.18277014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1118 A"},
        {"Henry Draper", "HD 8512"},
        {"Hipparcos Number", "HIP 6537"},
        {"Fundamental Katalog 5th Edition", "FK5 47"},
        {"Geneva Identification System", "GEN# +1.00008512"},
        {"Smithsonian Astrophysical Observation", "SAO 129274"},
        {"Wilson Evans Batten Catalogue", "WEB 1440"},
    },
    visualMagnitude: 3.60,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.00604671),
        dec: Angle.Degrees(-08.18275372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55134"},
        {"Hipparcos Number", "HIP 34720"},
        {"Celescope Catalog", "CEL 1650"},
        {"Geneva Identification System", "GEN# +1.00055134"},
        {"Smithsonian Astrophysical Observation", "SAO 134321"},
    },
    visualMagnitude: 9.36,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83813574),
        dec: Angle.Degrees(-08.18266425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78639"},
        {"Hipparcos Number", "HIP 44940"},
        {"Smithsonian Astrophysical Observation", "SAO 136617"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.30908083),
        dec: Angle.Degrees(-08.18178977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190795"},
        {"Hipparcos Number", "HIP 99094"},
        {"Geneva Identification System", "GEN# +1.00190795"},
        {"Smithsonian Astrophysical Observation", "SAO 144078"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.76515906),
        dec: Angle.Degrees(-08.18161561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157658"},
        {"Hipparcos Number", "HIP 85219"},
        {"Smithsonian Astrophysical Observation", "SAO 141654"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.20464684),
        dec: Angle.Degrees(-08.18027397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11005 AB"},
        {"Henry Draper", "HD 164765J"},
        {"Henry Draper 2", "HD 164764J"},
        {"Hipparcos Number", "HIP 88404"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77046145),
        dec: Angle.Degrees(-08.18025785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203844"},
        {"Hipparcos Number", "HIP 105734"},
        {"Geneva Identification System", "GEN# +1.00203844"},
        {"Smithsonian Astrophysical Observation", "SAO 145377"},
        {"Wilson Evans Batten Catalogue", "WEB 19189"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.23554904),
        dec: Angle.Degrees(-08.17952807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51424"},
        {"Henry Draper 2", "HD 51425"},
        {"Hipparcos Number", "HIP 33420"},
        {"Geneva Identification System", "GEN# +1.00051424"},
        {"Renson", "Renson 14190"},
        {"Smithsonian Astrophysical Observation", "SAO 133937"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.25040195),
        dec: Angle.Degrees(-08.17926621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10703"},
        {"Smithsonian Astrophysical Observation", "SAO 129804"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.44282064),
        dec: Angle.Degrees(-08.17887681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76576"},
        {"Hipparcos Number", "HIP 43919"},
        {"Smithsonian Astrophysical Observation", "SAO 136429"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.20576123),
        dec: Angle.Degrees(-08.17776749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86316"},
        {"Hipparcos Number", "HIP 48816"},
        {"Smithsonian Astrophysical Observation", "SAO 137255"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.36214410),
        dec: Angle.Degrees(-08.17538019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169332"},
        {"Hipparcos Number", "HIP 90218"},
        {"Geneva Identification System", "GEN# +1.00169332"},
        {"Smithsonian Astrophysical Observation", "SAO 142281"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.12495138),
        dec: Angle.Degrees(-08.17490300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66488"},
        {"Hipparcos Number", "HIP 39425"},
        {"Fundamental Katalog 5th Edition", "FK5 4726"},
        {"Geneva Identification System", "GEN# +1.00066488"},
        {"Smithsonian Astrophysical Observation", "SAO 135430"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.88384920),
        dec: Angle.Degrees(-08.17350915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144660"},
        {"Hipparcos Number", "HIP 78983"},
        {"Geneva Identification System", "GEN# +1.00144660"},
        {"Smithsonian Astrophysical Observation", "SAO 140969"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.83869984),
        dec: Angle.Degrees(-08.16972701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84874"},
        {"Hipparcos Number", "HIP 48076"},
        {"Smithsonian Astrophysical Observation", "SAO 137139"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.01600159),
        dec: Angle.Degrees(-08.16858094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23646"},
        {"Hipparcos Number", "HIP 17612"},
        {"Geneva Identification System", "GEN# +1.00023646"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.59638557),
        dec: Angle.Degrees(-08.16843273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 706 AB"},
        {"Henry Draper", "HD 4987"},
        {"Hipparcos Number", "HIP 4044"},
        {"Smithsonian Astrophysical Observation", "SAO 128997"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.96041231),
        dec: Angle.Degrees(-08.16581842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201056"},
        {"Hipparcos Number", "HIP 104271"},
        {"Geneva Identification System", "GEN# +1.00201056"},
        {"Smithsonian Astrophysical Observation", "SAO 145117"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.85403569),
        dec: Angle.Degrees(-08.16429637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52964"},
        {"Hipparcos Number", "HIP 33968"},
        {"Smithsonian Astrophysical Observation", "SAO 134108"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.71972122),
        dec: Angle.Degrees(-08.16184768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182768"},
        {"Hipparcos Number", "HIP 95588"},
        {"Geneva Identification System", "GEN# +1.00182768"},
        {"Smithsonian Astrophysical Observation", "SAO 143399"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.63825019),
        dec: Angle.Degrees(-08.16171528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122135"},
        {"Hipparcos Number", "HIP 68398"},
        {"Smithsonian Astrophysical Observation", "SAO 139669"},
        {"Wilson Evans Batten Catalogue", "WEB 11993"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01954153),
        dec: Angle.Degrees(-08.16152649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172528"},
        {"Hipparcos Number", "HIP 91620"},
        {"Smithsonian Astrophysical Observation", "SAO 142495"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.27509155),
        dec: Angle.Degrees(-08.16018044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104411"},
        {"Hipparcos Number", "HIP 58633"},
        {"Smithsonian Astrophysical Observation", "SAO 138539"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.35944506),
        dec: Angle.Degrees(-08.15890719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219515"},
        {"Hipparcos Number", "HIP 114905"},
        {"Smithsonian Astrophysical Observation", "SAO 146603"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.11361672),
        dec: Angle.Degrees(-08.15886297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176160"},
        {"Hipparcos Number", "HIP 93216"},
        {"Smithsonian Astrophysical Observation", "SAO 142880"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.81596410),
        dec: Angle.Degrees(-08.15882020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108988"},
        {"Hipparcos Number", "HIP 61110"},
        {"Smithsonian Astrophysical Observation", "SAO 138831"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.86274928),
        dec: Angle.Degrees(-08.15843169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46229"},
        {"Hipparcos Number", "HIP 31121"},
        {"Geneva Identification System", "GEN# +1.00046229"},
        {"Smithsonian Astrophysical Observation", "SAO 133369"},
        {"Wilson Evans Batten Catalogue", "WEB 6204"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.95861449),
        dec: Angle.Degrees(-08.15818115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26589"},
        {"Hipparcos Number", "HIP 19598"},
        {"Smithsonian Astrophysical Observation", "SAO 131022"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99570971),
        dec: Angle.Degrees(-08.15550816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12911 AB"},
        {"Henry Draper", "HD 186847"},
        {"Hipparcos Number", "HIP 97350"},
        {"Geneva Identification System", "GEN# +1.00186847J"},
        {"Smithsonian Astrophysical Observation", "SAO 143795"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.78350283),
        dec: Angle.Degrees(-08.15275479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169650"},
        {"Hipparcos Number", "HIP 90350"},
        {"Smithsonian Astrophysical Observation", "SAO 142310"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.53088651),
        dec: Angle.Degrees(-08.15228687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101061"},
        {"Hipparcos Number", "HIP 56718"},
        {"Smithsonian Astrophysical Observation", "SAO 138310"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.42751683),
        dec: Angle.Degrees(-08.15107725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113651"},
        {"Hipparcos Number", "HIP 63867"},
        {"Smithsonian Astrophysical Observation", "SAO 139142"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.34109650),
        dec: Angle.Degrees(-08.14959727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9461"},
        {"Hipparcos Number", "HIP 7209"},
        {"Smithsonian Astrophysical Observation", "SAO 129360"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21767379),
        dec: Angle.Degrees(-08.14941316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149383"},
        {"Hipparcos Number", "HIP 81159"},
        {"Smithsonian Astrophysical Observation", "SAO 141252"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.64046186),
        dec: Angle.Degrees(-08.14929914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223338"},
        {"Hipparcos Number", "HIP 117439"},
        {"Geneva Identification System", "GEN# +1.00223338"},
        {"Smithsonian Astrophysical Observation", "SAO 146923"},
        {"Wilson Evans Batten Catalogue", "WEB 20683"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.19164924),
        dec: Angle.Degrees(-08.14568485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82373"},
        {"Hipparcos Number", "HIP 46717"},
        {"Smithsonian Astrophysical Observation", "SAO 136925"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.84728224),
        dec: Angle.Degrees(-08.14450348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59831"},
        {"Hipparcos Number", "HIP 36587"},
        {"Geneva Identification System", "GEN# +1.00059831"},
        {"Smithsonian Astrophysical Observation", "SAO 134787"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.87683348),
        dec: Angle.Degrees(-08.14359132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137611"},
        {"Hipparcos Number", "HIP 75650"},
        {"Geneva Identification System", "GEN# +1.00137611"},
        {"Smithsonian Astrophysical Observation", "SAO 140541"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.83112827),
        dec: Angle.Degrees(-08.14308515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38023"},
        {"Hipparcos Number", "HIP 26876"},
        {"Celescope Catalog", "CEL 938"},
        {"Geneva Identification System", "GEN# +1.00038023"},
        {"Smithsonian Astrophysical Observation", "SAO 132471"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.58875748),
        dec: Angle.Degrees(-08.13338326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53621"},
        {"Hipparcos Number", "HIP 34185"},
        {"Smithsonian Astrophysical Observation", "SAO 134169"},
        {"Wilson Evans Batten Catalogue", "WEB 6847"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34102783),
        dec: Angle.Degrees(-08.13316682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18732"},
        {"Hipparcos Number", "HIP 14016"},
        {"Geneva Identification System", "GEN# +1.00018732"},
        {"Smithsonian Astrophysical Observation", "SAO 130239"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.10589176),
        dec: Angle.Degrees(-08.13237376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16477"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.04777452),
        dec: Angle.Degrees(-08.12948154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80719",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10072 A"},
        {"Henry Draper", "HD 148515"},
        {"Henry Draper 2", "HD 148515A"},
        {"Hipparcos Number", "HIP 80719"},
        {"Geneva Identification System", "GEN# +1.00148515"},
        {"Smithsonian Astrophysical Observation", "SAO 141195"},
        {"Wilson Evans Batten Catalogue", "WEB 13653"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.20411533),
        dec: Angle.Degrees(-08.12867261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61236"},
        {"Hipparcos Number", "HIP 37149"},
        {"Geneva Identification System", "GEN# +1.00061236"},
        {"Smithsonian Astrophysical Observation", "SAO 134924"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.50647147),
        dec: Angle.Degrees(-08.12622779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107280"},
        {"Hipparcos Number", "HIP 60147"},
        {"Smithsonian Astrophysical Observation", "SAO 138722"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.01670650),
        dec: Angle.Degrees(-08.12595047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177398"},
        {"Hipparcos Number", "HIP 93709"},
        {"Smithsonian Astrophysical Observation", "SAO 142992"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22674628),
        dec: Angle.Degrees(-08.12232697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173611"},
        {"Hipparcos Number", "HIP 92126"},
        {"Smithsonian Astrophysical Observation", "SAO 142605"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.65280654),
        dec: Angle.Degrees(-08.11975042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27436"},
        {"Hipparcos Number", "HIP 20179"},
        {"Smithsonian Astrophysical Observation", "SAO 131115"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.87910549),
        dec: Angle.Degrees(-08.11956287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159975"},
        {"Hipparcos Number", "HIP 86284"},
        {"Fundamental Katalog 5th Edition", "FK5 3399"},
        {"Geneva Identification System", "GEN# +1.00159975"},
        {"Renson", "Renson 45060"},
        {"Smithsonian Astrophysical Observation", "SAO 141772"},
        {"Wilson Evans Batten Catalogue", "WEB 14553"},
    },
    visualMagnitude: 4.58,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.46133236),
        dec: Angle.Degrees(-08.11872126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150784"},
        {"Hipparcos Number", "HIP 81882"},
        {"Smithsonian Astrophysical Observation", "SAO 141329"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.88731158),
        dec: Angle.Degrees(-08.11836812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145894"},
        {"Hipparcos Number", "HIP 79529"},
        {"Geneva Identification System", "GEN# +1.00145894"},
        {"Smithsonian Astrophysical Observation", "SAO 141039"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.43941317),
        dec: Angle.Degrees(-08.11799040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115996"},
        {"Hipparcos Number", "HIP 65142"},
        {"Smithsonian Astrophysical Observation", "SAO 139290"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.23518542),
        dec: Angle.Degrees(-08.11784269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30688"},
        {"Hipparcos Number", "HIP 22419"},
        {"Smithsonian Astrophysical Observation", "SAO 131523"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.36917530),
        dec: Angle.Degrees(-08.11739277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70317"},
        {"Geneva Identification System", "GEN# -0.00703837"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.79897377),
        dec: Angle.Degrees(-08.11602105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -356.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138809"},
        {"Hipparcos Number", "HIP 76269"},
        {"Geneva Identification System", "GEN# +1.00138809"},
        {"Smithsonian Astrophysical Observation", "SAO 140618"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.68052587),
        dec: Angle.Degrees(-08.11567306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138855"},
        {"Hipparcos Number", "HIP 76286"},
        {"Geneva Identification System", "GEN# +1.00138855"},
        {"Smithsonian Astrophysical Observation", "SAO 140621"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.74302997),
        dec: Angle.Degrees(-08.11473263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213293"},
        {"Hipparcos Number", "HIP 111113"},
        {"Geneva Identification System", "GEN# +1.00213293"},
        {"Smithsonian Astrophysical Observation", "SAO 146130"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.63655109),
        dec: Angle.Degrees(-08.11462526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68381"},
        {"Hipparcos Number", "HIP 40145"},
        {"Smithsonian Astrophysical Observation", "SAO 135620"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.97480668),
        dec: Angle.Degrees(-08.11356375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215873"},
        {"Hipparcos Number", "HIP 112604"},
        {"Smithsonian Astrophysical Observation", "SAO 146323"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.09382680),
        dec: Angle.Degrees(-08.11230430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39615"},
        {"Hipparcos Number", "HIP 27834"},
        {"Smithsonian Astrophysical Observation", "SAO 132618"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.34425040),
        dec: Angle.Degrees(-08.11171338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88656",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11052 A"},
        {"Henry Draper", "HD 165360"},
        {"Henry Draper 2", "HD 165360A"},
        {"Hipparcos Number", "HIP 88656"},
        {"Smithsonian Astrophysical Observation", "SAO 142081"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.50649930),
        dec: Angle.Degrees(-08.10880318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27665"},
        {"Hipparcos Number", "HIP 20358"},
        {"Smithsonian Astrophysical Observation", "SAO 131142"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.39667756),
        dec: Angle.Degrees(-08.10858579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40672"},
        {"Hipparcos Number", "HIP 28409"},
        {"Smithsonian Astrophysical Observation", "SAO 132734"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.00471800),
        dec: Angle.Degrees(-08.10753345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212459"},
        {"Hipparcos Number", "HIP 110612"},
        {"Smithsonian Astrophysical Observation", "SAO 146073"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.13798835),
        dec: Angle.Degrees(-08.10654989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160037"},
        {"Hipparcos Number", "HIP 86318"},
        {"Smithsonian Astrophysical Observation", "SAO 141777"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.55196307),
        dec: Angle.Degrees(-08.10588898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190438"},
        {"Hipparcos Number", "HIP 98930"},
        {"Geneva Identification System", "GEN# +1.00190438"},
        {"Smithsonian Astrophysical Observation", "SAO 144052"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.30822962),
        dec: Angle.Degrees(-08.10577026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25171",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3974 AB"},
        {"Henry Draper", "HD 35261"},
        {"Hipparcos Number", "HIP 25171"},
        {"Celescope Catalog", "CEL 666"},
        {"Geneva Identification System", "GEN# +1.00035261J"},
        {"Smithsonian Astrophysical Observation", "SAO 132046"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76761622),
        dec: Angle.Degrees(-08.10554699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11376"},
        {"Hipparcos Number", "HIP 8683"},
        {"Smithsonian Astrophysical Observation", "SAO 129540"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.93149185),
        dec: Angle.Degrees(-08.10493864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7555 AB"},
        {"Henry Draper", "HD 85558"},
        {"Hipparcos Number", "HIP 48437"},
        {"Smithsonian Astrophysical Observation", "SAO 137199"},
        {"Wilson Evans Batten Catalogue", "WEB 9033"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.12696211),
        dec: Angle.Degrees(-08.10491559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45804"},
        {"Hipparcos Number", "HIP 30909"},
        {"Smithsonian Astrophysical Observation", "SAO 133326"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.31417004),
        dec: Angle.Degrees(-08.10065310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84127"},
        {"Hipparcos Number", "HIP 47630"},
        {"Smithsonian Astrophysical Observation", "SAO 137070"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67683348),
        dec: Angle.Degrees(-08.09989031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98904"},
        {"Hipparcos Number", "HIP 55556"},
        {"Smithsonian Astrophysical Observation", "SAO 138169"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.69596665),
        dec: Angle.Degrees(-08.09687765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56157"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.67514083),
        dec: Angle.Degrees(-08.09590028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -354.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147178"},
        {"Hipparcos Number", "HIP 80082"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.16529968),
        dec: Angle.Degrees(-08.09551979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13493 AB"},
        {"Henry Draper", "HD 191841"},
        {"Hipparcos Number", "HIP 99558"},
        {"Smithsonian Astrophysical Observation", "SAO 144164"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.06384601),
        dec: Angle.Degrees(-08.09224064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9233 A"},
        {"Henry Draper", "HD 125818"},
        {"Hipparcos Number", "HIP 70226"},
        {"Smithsonian Astrophysical Observation", "SAO 139889"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.50958523),
        dec: Angle.Degrees(-08.09128031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189264"},
        {"Hipparcos Number", "HIP 98387"},
        {"Smithsonian Astrophysical Observation", "SAO 143970"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.85221160),
        dec: Angle.Degrees(-08.08939137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3939"},
        {"Hipparcos Number", "HIP 3283"},
        {"Smithsonian Astrophysical Observation", "SAO 128904"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.46287314),
        dec: Angle.Degrees(-08.08892729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7392 AB"},
        {"Henry Draper", "HD 81901"},
        {"Hipparcos Number", "HIP 46442"},
        {"Renson", "Renson 23290"},
        {"Smithsonian Astrophysical Observation", "SAO 136882"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.08486839),
        dec: Angle.Degrees(-08.08835922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57256",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8287 AB"},
        {"Henry Draper", "HD 102032"},
        {"Hipparcos Number", "HIP 57256"},
        {"Smithsonian Astrophysical Observation", "SAO 138381"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.11819798),
        dec: Angle.Degrees(-08.08801518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22891"},
        {"Hipparcos Number", "HIP 17143"},
        {"Geneva Identification System", "GEN# +1.00022891"},
        {"Smithsonian Astrophysical Observation", "SAO 130650"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.07242231),
        dec: Angle.Degrees(-08.08729399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35225"},
        {"Hipparcos Number", "HIP 25147"},
        {"Celescope Catalog", "CEL 662"},
        {"Geneva Identification System", "GEN# +1.00035225"},
        {"Smithsonian Astrophysical Observation", "SAO 132041"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.71945180),
        dec: Angle.Degrees(-08.08722042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117317"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.82646499),
        dec: Angle.Degrees(-08.08669335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125519"},
        {"Hipparcos Number", "HIP 70046"},
        {"Geneva Identification System", "GEN# +1.00125519"},
        {"Smithsonian Astrophysical Observation", "SAO 139870"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.00703521),
        dec: Angle.Degrees(-08.08606283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71565"},
        {"Hipparcos Number", "HIP 41499"},
        {"Smithsonian Astrophysical Observation", "SAO 135944"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.95956825),
        dec: Angle.Degrees(-08.08560478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2692"},
        {"Hipparcos Number", "HIP 2394"},
        {"Geneva Identification System", "GEN# +1.00002692"},
        {"Smithsonian Astrophysical Observation", "SAO 128794"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62245146),
        dec: Angle.Degrees(-08.08418277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138544"},
        {"Hipparcos Number", "HIP 76138"},
        {"Smithsonian Astrophysical Observation", "SAO 140597"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.27641408),
        dec: Angle.Degrees(-08.08161645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75623"},
        {"Hipparcos Number", "HIP 43432"},
        {"Smithsonian Astrophysical Observation", "SAO 136332"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69506548),
        dec: Angle.Degrees(-08.08068805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75076"},
        {"Smithsonian Astrophysical Observation", "SAO 140467"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.13011076),
        dec: Angle.Degrees(-08.07824479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11330"},
        {"Hipparcos Number", "HIP 8636"},
        {"Smithsonian Astrophysical Observation", "SAO 129534"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83893828),
        dec: Angle.Degrees(-08.07627353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98852"},
        {"Hipparcos Number", "HIP 55536"},
        {"Smithsonian Astrophysical Observation", "SAO 138167"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.63167109),
        dec: Angle.Degrees(-08.07430715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83435"},
        {"Hipparcos Number", "HIP 47295"},
        {"Smithsonian Astrophysical Observation", "SAO 137018"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.57637421),
        dec: Angle.Degrees(-08.07376828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160804"},
        {"Hipparcos Number", "HIP 86646"},
        {"Fundamental Katalog 5th Edition", "FK5 5555"},
        {"Geneva Identification System", "GEN# +1.00160804"},
        {"Smithsonian Astrophysical Observation", "SAO 141817"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55968528),
        dec: Angle.Degrees(-08.07144691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122242"},
        {"Hipparcos Number", "HIP 68453"},
        {"Smithsonian Astrophysical Observation", "SAO 139675"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.21474602),
        dec: Angle.Degrees(-08.07106158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24080"},
        {"Hipparcos Number", "HIP 17917"},
        {"Smithsonian Astrophysical Observation", "SAO 130758"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.47117201),
        dec: Angle.Degrees(-08.07048930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94123"},
        {"Hipparcos Number", "HIP 53090"},
        {"Geneva Identification System", "GEN# +1.00094123"},
        {"Smithsonian Astrophysical Observation", "SAO 137844"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.92077135),
        dec: Angle.Degrees(-08.06990382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1195 AB"},
        {"Henry Draper", "HD 9227"},
        {"Hipparcos Number", "HIP 7038"},
        {"Smithsonian Astrophysical Observation", "SAO 129339"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.68694016),
        dec: Angle.Degrees(-08.06926282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89254"},
        {"Hipparcos Number", "HIP 50414"},
        {"Fundamental Katalog 5th Edition", "FK5 1263"},
        {"Geneva Identification System", "GEN# +1.00089254"},
        {"Smithsonian Astrophysical Observation", "SAO 137469"},
        {"Wilson Evans Batten Catalogue", "WEB 9250"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.40790248),
        dec: Angle.Degrees(-08.06892120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163568"},
        {"Hipparcos Number", "HIP 87884"},
        {"Geneva Identification System", "GEN# +1.00163568"},
        {"Smithsonian Astrophysical Observation", "SAO 141983"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.29156836),
        dec: Angle.Degrees(-08.06888770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192945"},
        {"Hipparcos Number", "HIP 100054"},
        {"Smithsonian Astrophysical Observation", "SAO 144260"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.48614707),
        dec: Angle.Degrees(-08.06605336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198709"},
        {"Hipparcos Number", "HIP 103034"},
        {"Smithsonian Astrophysical Observation", "SAO 144894"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.12152812),
        dec: Angle.Degrees(-08.06302197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67953",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9053 AB"},
        {"Henry Draper", "HD 121325"},
        {"Hipparcos Number", "HIP 67953"},
        {"Geneva Identification System", "GEN# +1.00121325"},
        {"Smithsonian Astrophysical Observation", "SAO 139618"},
        {"Wilson Evans Batten Catalogue", "WEB 11936"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.74293617),
        dec: Angle.Degrees(-08.05876407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70358"},
        {"Hipparcos Number", "HIP 40937"},
        {"Smithsonian Astrophysical Observation", "SAO 135806"},
        {"Wilson Evans Batten Catalogue", "WEB 7937"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.31492160),
        dec: Angle.Degrees(-08.05786894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88665"},
        {"Smithsonian Astrophysical Observation", "SAO 142082"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.52173126),
        dec: Angle.Degrees(-08.05744939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109428"},
        {"Hipparcos Number", "HIP 61378"},
        {"Smithsonian Astrophysical Observation", "SAO 138856"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.67431161),
        dec: Angle.Degrees(-08.05719100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92675"},
        {"Hipparcos Number", "HIP 52343"},
        {"Smithsonian Astrophysical Observation", "SAO 137734"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.46815357),
        dec: Angle.Degrees(-08.05608236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115153"},
        {"Hipparcos Number", "HIP 64688"},
        {"Geneva Identification System", "GEN# +1.00115153"},
        {"Smithsonian Astrophysical Observation", "SAO 139246"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.87809348),
        dec: Angle.Degrees(-08.05530078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37846"},
        {"Hipparcos Number", "HIP 26750"},
        {"Celescope Catalog", "CEL 926"},
        {"Geneva Identification System", "GEN# +1.00037846"},
        {"Smithsonian Astrophysical Observation", "SAO 132454"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.25165228),
        dec: Angle.Degrees(-08.05445505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138119"},
        {"Hipparcos Number", "HIP 75906"},
        {"Smithsonian Astrophysical Observation", "SAO 140570"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.56260980),
        dec: Angle.Degrees(-08.05399246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211127"},
        {"Hipparcos Number", "HIP 109869"},
        {"Smithsonian Astrophysical Observation", "SAO 145972"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.78926495),
        dec: Angle.Degrees(-08.05382541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140540"},
        {"Hipparcos Number", "HIP 77097"},
        {"Geneva Identification System", "GEN# +1.00140540"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.13115990),
        dec: Angle.Degrees(-08.05357640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5401"},
        {"Hipparcos Number", "HIP 4342"},
        {"Geneva Identification System", "GEN# +1.00005401"},
        {"Smithsonian Astrophysical Observation", "SAO 129030"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.91878081),
        dec: Angle.Degrees(-08.05326894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20992"},
        {"Smithsonian Astrophysical Observation", "SAO 131254"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.52877898),
        dec: Angle.Degrees(-08.05285812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1461"},
        {"Hipparcos Number", "HIP 1499"},
        {"Cincinnati Publication", "Ci 20 21"},
        {"Geneva Identification System", "GEN# +1.00001461"},
        {"Smithsonian Astrophysical Observation", "SAO 128690"},
        {"Wilson Evans Batten Catalogue", "WEB 280"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67342336),
        dec: Angle.Degrees(-08.05265094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 417.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143841"},
        {"Hipparcos Number", "HIP 78615"},
        {"Smithsonian Astrophysical Observation", "SAO 140916"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.74516325),
        dec: Angle.Degrees(-08.04818625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19985"},
        {"Hipparcos Number", "HIP 14918"},
        {"Smithsonian Astrophysical Observation", "SAO 130349"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.11576696),
        dec: Angle.Degrees(-08.04706049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133395"},
        {"Hipparcos Number", "HIP 73747"},
        {"Smithsonian Astrophysical Observation", "SAO 140301"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.11685576),
        dec: Angle.Degrees(-08.04689217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40618"},
        {"Hipparcos Number", "HIP 28375"},
        {"Smithsonian Astrophysical Observation", "SAO 132727"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.91786392),
        dec: Angle.Degrees(-08.04581834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23867"},
        {"Hipparcos Number", "HIP 17758"},
        {"Smithsonian Astrophysical Observation", "SAO 130733"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.02368200),
        dec: Angle.Degrees(-08.04530398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63188"},
        {"Hipparcos Number", "HIP 38006"},
        {"Smithsonian Astrophysical Observation", "SAO 135102"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.84474340),
        dec: Angle.Degrees(-08.04490106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141897"},
        {"Hipparcos Number", "HIP 77699"},
        {"Smithsonian Astrophysical Observation", "SAO 140805"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.95837159),
        dec: Angle.Degrees(-08.04340212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48436"},
        {"Hipparcos Number", "HIP 32176"},
        {"Smithsonian Astrophysical Observation", "SAO 133612"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77602469),
        dec: Angle.Degrees(-08.04337286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196976"},
        {"Hipparcos Number", "HIP 102059"},
        {"Geneva Identification System", "GEN# +1.00196976"},
        {"Smithsonian Astrophysical Observation", "SAO 144691"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.24218516),
        dec: Angle.Degrees(-08.04336055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136698"},
        {"Hipparcos Number", "HIP 75229"},
        {"Geneva Identification System", "GEN# +1.00136698"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59247515),
        dec: Angle.Degrees(-08.04100965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49976"},
        {"Hipparcos Number", "HIP 32838"},
        {"Geneva Identification System", "GEN# +1.00049976"},
        {"Renson", "Renson 13560"},
        {"Smithsonian Astrophysical Observation", "SAO 133761"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.67628645),
        dec: Angle.Degrees(-08.04100355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169913"},
        {"Hipparcos Number", "HIP 90437"},
        {"Smithsonian Astrophysical Observation", "SAO 142326"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.78693235),
        dec: Angle.Degrees(-08.04043090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202819"},
        {"Hipparcos Number", "HIP 105204"},
        {"Geneva Identification System", "GEN# +1.00202819"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.66278843),
        dec: Angle.Degrees(-08.03950836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 317.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187169"},
        {"Hipparcos Number", "HIP 97488"},
        {"Smithsonian Astrophysical Observation", "SAO 143812"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.21760160),
        dec: Angle.Degrees(-08.03926133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113896"},
        {"Hipparcos Number", "HIP 64010"},
        {"Smithsonian Astrophysical Observation", "SAO 139163"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.74411078),
        dec: Angle.Degrees(-08.03821814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65841"},
        {"Hipparcos Number", "HIP 39150"},
        {"Smithsonian Astrophysical Observation", "SAO 135363"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.11821213),
        dec: Angle.Degrees(-08.03790395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159874"},
        {"Hipparcos Number", "HIP 86240"},
        {"Smithsonian Astrophysical Observation", "SAO 141765"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.34974380),
        dec: Angle.Degrees(-08.03678301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14202"},
        {"Smithsonian Astrophysical Observation", "SAO 130259"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.78782539),
        dec: Angle.Degrees(-08.03172785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3927 AB"},
        {"Henry Draper", "HD 34892"},
        {"Hipparcos Number", "HIP 24919"},
        {"Celescope Catalog", "CEL 633"},
        {"Smithsonian Astrophysical Observation", "SAO 132006"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.10064841),
        dec: Angle.Degrees(-08.02973136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17311"},
        {"Hipparcos Number", "HIP 12947"},
        {"Geneva Identification System", "GEN# +1.00017311"},
        {"Smithsonian Astrophysical Observation", "SAO 130105"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.63277405),
        dec: Angle.Degrees(-08.02803510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6154"},
        {"Hipparcos Number", "HIP 4854"},
        {"Smithsonian Astrophysical Observation", "SAO 129093"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.61466622),
        dec: Angle.Degrees(-08.02558714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120186"},
        {"Hipparcos Number", "HIP 67333"},
        {"Geneva Identification System", "GEN# +1.00120186"},
        {"Smithsonian Astrophysical Observation", "SAO 139556"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.00853739),
        dec: Angle.Degrees(-08.02471630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5442"},
        {"Hipparcos Number", "HIP 4380"},
        {"Geneva Identification System", "GEN# +1.00005442"},
        {"Smithsonian Astrophysical Observation", "SAO 129038"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.03460746),
        dec: Angle.Degrees(-08.02349884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156802"},
        {"Hipparcos Number", "HIP 84803"},
        {"Geneva Identification System", "GEN# +1.00156802"},
        {"Smithsonian Astrophysical Observation", "SAO 141608"},
        {"Wilson Evans Batten Catalogue", "WEB 14315"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00060781),
        dec: Angle.Degrees(-08.02260932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41483"},
        {"Hipparcos Number", "HIP 28833"},
        {"Smithsonian Astrophysical Observation", "SAO 132811"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.29084047),
        dec: Angle.Degrees(-08.02236908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24920",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3927 C"},
        {"Hipparcos Number", "HIP 24920"},
        {"Smithsonian Astrophysical Observation", "SAO 132007"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.10136417),
        dec: Angle.Degrees(-08.02000564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118940"},
        {"Hipparcos Number", "HIP 66695"},
        {"Geneva Identification System", "GEN# +1.00118940"},
        {"Smithsonian Astrophysical Observation", "SAO 139478"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.07153069),
        dec: Angle.Degrees(-08.01948515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137777"},
        {"Hipparcos Number", "HIP 75717"},
        {"Smithsonian Astrophysical Observation", "SAO 140551"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.03799241),
        dec: Angle.Degrees(-08.01885302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63620"},
        {"Hipparcos Number", "HIP 38198"},
        {"Smithsonian Astrophysical Observation", "SAO 135141"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.38535360),
        dec: Angle.Degrees(-08.01794292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158450"},
        {"Hipparcos Number", "HIP 85618"},
        {"Renson", "Renson 44620"},
        {"Smithsonian Astrophysical Observation", "SAO 141690"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43331688),
        dec: Angle.Degrees(-08.01748117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99849"},
        {"Hipparcos Number", "HIP 56039"},
        {"Smithsonian Astrophysical Observation", "SAO 138228"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.28352220),
        dec: Angle.Degrees(-08.01626302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24485"},
        {"Hipparcos Number", "HIP 18186"},
        {"Smithsonian Astrophysical Observation", "SAO 130798"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.36047726),
        dec: Angle.Degrees(-08.01524759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15725 A"},
        {"Henry Draper", "HD 210733"},
        {"Hipparcos Number", "HIP 109637"},
        {"Smithsonian Astrophysical Observation", "SAO 145938"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.14895972),
        dec: Angle.Degrees(-08.01388195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22787"},
        {"Hipparcos Number", "HIP 17063"},
        {"Geneva Identification System", "GEN# +1.00022787"},
        {"Smithsonian Astrophysical Observation", "SAO 130638"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.86699378),
        dec: Angle.Degrees(-08.01195293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104018"},
        {"Hipparcos Number", "HIP 58420"},
        {"Smithsonian Astrophysical Observation", "SAO 138513"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.67296680),
        dec: Angle.Degrees(-08.00780384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8511"},
        {"Hipparcos Number", "HIP 6539"},
        {"Geneva Identification System", "GEN# +1.00008511"},
        {"Smithsonian Astrophysical Observation", "SAO 129275"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.01013866),
        dec: Angle.Degrees(-08.00725234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207077"},
        {"Hipparcos Number", "HIP 107529"},
        {"Geneva Identification System", "GEN# +1.00207077"},
        {"Smithsonian Astrophysical Observation", "SAO 145657"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.68348259),
        dec: Angle.Degrees(-08.00708491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117579"},
        {"Hipparcos Number", "HIP 65963"},
        {"Smithsonian Astrophysical Observation", "SAO 139383"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.87014948),
        dec: Angle.Degrees(-08.00706955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197577"},
        {"Hipparcos Number", "HIP 102389"},
        {"Geneva Identification System", "GEN# +1.00197577"},
        {"Smithsonian Astrophysical Observation", "SAO 144762"},
        {"Wilson Evans Batten Catalogue", "WEB 18533"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.22464988),
        dec: Angle.Degrees(-08.00629666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3707"},
        {"Hipparcos Number", "HIP 3126"},
        {"Geneva Identification System", "GEN# +1.00003707"},
        {"Smithsonian Astrophysical Observation", "SAO 128880"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93568757),
        dec: Angle.Degrees(-08.00572347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9938"},
        {"Smithsonian Astrophysical Observation", "SAO 129710"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.98972040),
        dec: Angle.Degrees(-08.00540340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123644"},
        {"Hipparcos Number", "HIP 69133"},
        {"Smithsonian Astrophysical Observation", "SAO 139756"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.26396200),
        dec: Angle.Degrees(-08.00409401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88631"},
        {"Hipparcos Number", "HIP 50055"},
        {"Geneva Identification System", "GEN# +1.00088631"},
        {"Smithsonian Astrophysical Observation", "SAO 137415"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.29109532),
        dec: Angle.Degrees(-08.00245922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8220"},
        {"Hipparcos Number", "HIP 6337"},
        {"Smithsonian Astrophysical Observation", "SAO 129248"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.35532879),
        dec: Angle.Degrees(-08.00143652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26950"},
    },
    visualMagnitude: 11.80,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.78121864),
        dec: Angle.Degrees(-07.99921414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15657"},
        {"Hipparcos Number", "HIP 11699"},
        {"Smithsonian Astrophysical Observation", "SAO 129952"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.73121575),
        dec: Angle.Degrees(-07.99779813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123015"},
        {"Hipparcos Number", "HIP 68819"},
        {"Geneva Identification System", "GEN# +1.00123015"},
        {"Smithsonian Astrophysical Observation", "SAO 139729"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.34549014),
        dec: Angle.Degrees(-07.99688728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184067"},
        {"Hipparcos Number", "HIP 96147"},
        {"Smithsonian Astrophysical Observation", "SAO 143523"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.23792542),
        dec: Angle.Degrees(-07.99670818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170988"},
        {"Hipparcos Number", "HIP 90911"},
        {"Geneva Identification System", "GEN# +1.00170988"},
        {"Smithsonian Astrophysical Observation", "SAO 142375"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.16413845),
        dec: Angle.Degrees(-07.99600088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18194"},
        {"Hipparcos Number", "HIP 13594"},
        {"Geneva Identification System", "GEN# +1.00018194"},
        {"Smithsonian Astrophysical Observation", "SAO 130186"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.78824394),
        dec: Angle.Degrees(-07.99589450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110014"},
        {"Hipparcos Number", "HIP 61740"},
        {"Fundamental Katalog 5th Edition", "FK5 475"},
        {"Geneva Identification System", "GEN# +1.00110014"},
        {"Smithsonian Astrophysical Observation", "SAO 138892"},
        {"Wilson Evans Batten Catalogue", "WEB 10983"},
    },
    visualMagnitude: 4.66,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81171855),
        dec: Angle.Degrees(-07.99550439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88764"},
        {"Hipparcos Number", "HIP 50140"},
        {"Geneva Identification System", "GEN# +1.00088764"},
        {"Smithsonian Astrophysical Observation", "SAO 137430"},
        {"Wilson Evans Batten Catalogue", "WEB 9217"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.53503102),
        dec: Angle.Degrees(-07.99344700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5336 C"},
        {"Henry Draper", "HD 48060"},
        {"Hipparcos Number", "HIP 31999"},
        {"Celescope Catalog", "CEL 1350"},
        {"Geneva Identification System", "GEN# +1.00048060J"},
        {"Smithsonian Astrophysical Observation", "SAO 133568"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)41, 10.0800),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)59, 35.800)
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
    primaryId: "HIP 57806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102960"},
        {"Hipparcos Number", "HIP 57806"},
        {"Smithsonian Astrophysical Observation", "SAO 138447"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.79554568),
        dec: Angle.Degrees(-07.99156933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219093"},
        {"Hipparcos Number", "HIP 114637"},
        {"Geneva Identification System", "GEN# +1.00219093"},
        {"Smithsonian Astrophysical Observation", "SAO 146568"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.34173773),
        dec: Angle.Degrees(-07.99140863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65005"},
        {"Hipparcos Number", "HIP 38790"},
        {"Smithsonian Astrophysical Observation", "SAO 135280"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.09051814),
        dec: Angle.Degrees(-07.99119504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5336 AB"},
        {"Henry Draper", "HD 48061"},
        {"Hipparcos Number", "HIP 32000"},
        {"Smithsonian Astrophysical Observation", "SAO 133569"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)41, 10.2500),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)59, 26.100)
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
    primaryId: "HIP 35434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56968"},
        {"Hipparcos Number", "HIP 35434"},
        {"Smithsonian Astrophysical Observation", "SAO 134501"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.72733110),
        dec: Angle.Degrees(-07.98956448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161555"},
        {"Hipparcos Number", "HIP 86985"},
        {"Geneva Identification System", "GEN# +1.00161555"},
        {"Smithsonian Astrophysical Observation", "SAO 141859"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.63250808),
        dec: Angle.Degrees(-07.98529815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72968"},
        {"Hipparcos Number", "HIP 42146"},
        {"Fundamental Katalog 5th Edition", "FK5 2672"},
        {"Geneva Identification System", "GEN# +1.00072968"},
        {"Renson", "Renson 20240"},
        {"Smithsonian Astrophysical Observation", "SAO 136076"},
        {"Wilson Evans Batten Catalogue", "WEB 8100"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.86754708),
        dec: Angle.Degrees(-07.98233083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21419"},
        {"Hipparcos Number", "HIP 16065"},
        {"Smithsonian Astrophysical Observation", "SAO 130497"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.73073408),
        dec: Angle.Degrees(-07.98231950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39481"},
        {"Hipparcos Number", "HIP 27770"},
        {"Geneva Identification System", "GEN# +1.00039481"},
        {"Smithsonian Astrophysical Observation", "SAO 132611"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.15262454),
        dec: Angle.Degrees(-07.98149143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11262 AB"},
        {"Henry Draper", "HD 168459"},
        {"Hipparcos Number", "HIP 89846"},
        {"Smithsonian Astrophysical Observation", "SAO 142229"},
        {"Wilson Evans Batten Catalogue", "WEB 15336"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.02140210),
        dec: Angle.Degrees(-07.98130446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185588"},
        {"Hipparcos Number", "HIP 96754"},
        {"Fundamental Katalog 5th Edition", "FK5 5731"},
        {"Geneva Identification System", "GEN# +1.00185588"},
        {"Smithsonian Astrophysical Observation", "SAO 143664"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02222253),
        dec: Angle.Degrees(-07.97931983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104887"},
        {"Hipparcos Number", "HIP 58898"},
        {"Smithsonian Astrophysical Observation", "SAO 138565"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.18390231),
        dec: Angle.Degrees(-07.97665139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91591"},
        {"Smithsonian Astrophysical Observation", "SAO 142488"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.18609424),
        dec: Angle.Degrees(-07.97333308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75197"},
        {"Hipparcos Number", "HIP 43218"},
        {"Smithsonian Astrophysical Observation", "SAO 136288"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.06337985),
        dec: Angle.Degrees(-07.97243354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64277"},
        {"Hipparcos Number", "HIP 38479"},
        {"Smithsonian Astrophysical Observation", "SAO 135209"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.21548125),
        dec: Angle.Degrees(-07.97139762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7093 AB"},
        {"Hipparcos Number", "HIP 43822"},
        {"Geneva Identification System", "GEN# +1.00076370J"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.87335197),
        dec: Angle.Degrees(-07.97108917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36176"},
        {"Smithsonian Astrophysical Observation", "SAO 134686"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.76126700),
        dec: Angle.Degrees(-07.96698813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125185"},
        {"Hipparcos Number", "HIP 69877"},
        {"Smithsonian Astrophysical Observation", "SAO 139854"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.49369334),
        dec: Angle.Degrees(-07.96659434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77461"},
        {"Smithsonian Astrophysical Observation", "SAO 140772"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.22860301),
        dec: Angle.Degrees(-07.96460252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92340"},
        {"Hipparcos Number", "HIP 52169"},
        {"Smithsonian Astrophysical Observation", "SAO 137711"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.87614013),
        dec: Angle.Degrees(-07.96323145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201737"},
        {"Hipparcos Number", "HIP 104641"},
        {"Geneva Identification System", "GEN# +1.00201737"},
        {"Smithsonian Astrophysical Observation", "SAO 145187"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.94767790),
        dec: Angle.Degrees(-07.96211325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13749"},
        {"Hipparcos Number", "HIP 10394"},
        {"Smithsonian Astrophysical Observation", "SAO 129763"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.46841342),
        dec: Angle.Degrees(-07.95945499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153378"},
        {"Hipparcos Number", "HIP 83146"},
        {"Geneva Identification System", "GEN# +1.00153378"},
        {"Smithsonian Astrophysical Observation", "SAO 141471"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.88152686),
        dec: Angle.Degrees(-07.95554599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46691"},
        {"Hipparcos Number", "HIP 31352"},
        {"Smithsonian Astrophysical Observation", "SAO 133428"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.61287155),
        dec: Angle.Degrees(-07.95033320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158675"},
        {"Hipparcos Number", "HIP 85721"},
        {"Geneva Identification System", "GEN# +1.00158675"},
        {"Smithsonian Astrophysical Observation", "SAO 141712"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.75136235),
        dec: Angle.Degrees(-07.94691148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164185"},
        {"Hipparcos Number", "HIP 88165"},
        {"Smithsonian Astrophysical Observation", "SAO 142023"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.10151128),
        dec: Angle.Degrees(-07.94523414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198555"},
        {"Hipparcos Number", "HIP 102939"},
        {"Smithsonian Astrophysical Observation", "SAO 144874"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.83831901),
        dec: Angle.Degrees(-07.94512869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60157"},
        {"Hipparcos Number", "HIP 36692"},
        {"Smithsonian Astrophysical Observation", "SAO 134825"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.21743330),
        dec: Angle.Degrees(-07.94361393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75378"},
        {"Hipparcos Number", "HIP 43308"},
        {"Smithsonian Astrophysical Observation", "SAO 136309"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34219931),
        dec: Angle.Degrees(-07.94205273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179406"},
        {"Hipparcos Number", "HIP 94385"},
        {"Fundamental Katalog 5th Edition", "FK5 1500"},
        {"Geneva Identification System", "GEN# +1.00179406"},
        {"Smithsonian Astrophysical Observation", "SAO 143134"},
        {"Wilson Evans Batten Catalogue", "WEB 16450"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.16959861),
        dec: Angle.Degrees(-07.93950077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54573"},
        {"Hipparcos Number", "HIP 34508"},
        {"Smithsonian Astrophysical Observation", "SAO 134257"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.25525525),
        dec: Angle.Degrees(-07.93903338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23504"},
        {"Hipparcos Number", "HIP 17546"},
        {"Smithsonian Astrophysical Observation", "SAO 130706"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.35570464),
        dec: Angle.Degrees(-07.93712488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44733"},
        {"Hipparcos Number", "HIP 30350"},
        {"Smithsonian Astrophysical Observation", "SAO 133193"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.75553696),
        dec: Angle.Degrees(-07.93695418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218173"},
        {"Hipparcos Number", "HIP 114054"},
        {"Smithsonian Astrophysical Observation", "SAO 146505"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.46884955),
        dec: Angle.Degrees(-07.93669575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42133"},
        {"Hipparcos Number", "HIP 29135"},
        {"Geneva Identification System", "GEN# +1.00042133"},
        {"Smithsonian Astrophysical Observation", "SAO 132883"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.19040709),
        dec: Angle.Degrees(-07.93631304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114825"},
        {"Hipparcos Number", "HIP 64505"},
        {"Smithsonian Astrophysical Observation", "SAO 139226"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.31664011),
        dec: Angle.Degrees(-07.93335675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173637"},
        {"Hipparcos Number", "HIP 92128"},
        {"Geneva Identification System", "GEN# +1.00173637"},
        {"Smithsonian Astrophysical Observation", "SAO 142608"},
        {"Wilson Evans Batten Catalogue", "WEB 15881"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.65866875),
        dec: Angle.Degrees(-07.93197742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195655"},
        {"Hipparcos Number", "HIP 101388"},
        {"Geneva Identification System", "GEN# +1.00195655"},
        {"Smithsonian Astrophysical Observation", "SAO 144549"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21943046),
        dec: Angle.Degrees(-07.93035561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7149"},
        {"Hipparcos Number", "HIP 5590"},
        {"Geneva Identification System", "GEN# +1.00007149"},
        {"Smithsonian Astrophysical Observation", "SAO 129170"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.92441645),
        dec: Angle.Degrees(-07.92926747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3032 AB"},
        {"Henry Draper", "HD 26294"},
        {"Hipparcos Number", "HIP 19399"},
        {"Geneva Identification System", "GEN# +1.00026294J"},
        {"Smithsonian Astrophysical Observation", "SAO 130988"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.33532703),
        dec: Angle.Degrees(-07.92902893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100646"},
        {"Hipparcos Number", "HIP 56490"},
        {"Smithsonian Astrophysical Observation", "SAO 138282"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.71418186),
        dec: Angle.Degrees(-07.92697623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20337"},
        {"Hipparcos Number", "HIP 15213"},
        {"Smithsonian Astrophysical Observation", "SAO 130390"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.02617064),
        dec: Angle.Degrees(-07.92691844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51783"},
        {"Smithsonian Astrophysical Observation", "SAO 137655"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70897477),
        dec: Angle.Degrees(-07.92539925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113329"},
        {"Hipparcos Number", "HIP 63685"},
        {"Smithsonian Astrophysical Observation", "SAO 139122"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.76638799),
        dec: Angle.Degrees(-07.92421847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77282"},
        {"Hipparcos Number", "HIP 44305"},
        {"Smithsonian Astrophysical Observation", "SAO 136501"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.34616281),
        dec: Angle.Degrees(-07.92417103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5799",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1003 A"},
        {"Henry Draper", "HD 7439"},
        {"Hipparcos Number", "HIP 5799"},
        {"Geneva Identification System", "GEN# +1.00007439"},
        {"Smithsonian Astrophysical Observation", "SAO 129193"},
        {"Wilson Evans Batten Catalogue", "WEB 1322"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.59986241),
        dec: Angle.Degrees(-07.92350040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 277.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222766"},
        {"Hipparcos Number", "HIP 117041"},
        {"Cincinnati Publication", "Ci 20 1446"},
        {"Geneva Identification System", "GEN# +1.00222766"},
        {"Wilson Evans Batten Catalogue", "WEB 20635"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.89399371),
        dec: Angle.Degrees(-07.92293367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 609.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305"},
        {"Hipparcos Number", "HIP 629"},
        {"Geneva Identification System", "GEN# +1.00000305"},
        {"Smithsonian Astrophysical Observation", "SAO 128594"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.91744231),
        dec: Angle.Degrees(-07.92129475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39348"},
        {"Hipparcos Number", "HIP 27687"},
        {"Celescope Catalog", "CEL 1008"},
        {"Geneva Identification System", "GEN# +1.00039348"},
        {"Smithsonian Astrophysical Observation", "SAO 132596"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.93180668),
        dec: Angle.Degrees(-07.92106930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148859"},
        {"Hipparcos Number", "HIP 80904"},
        {"Geneva Identification System", "GEN# +1.00148859"},
        {"Smithsonian Astrophysical Observation", "SAO 141219"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.82583658),
        dec: Angle.Degrees(-07.92077734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55514"},
        {"Hipparcos Number", "HIP 34876"},
        {"Geneva Identification System", "GEN# +1.00055514"},
        {"Smithsonian Astrophysical Observation", "SAO 134362"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.23891031),
        dec: Angle.Degrees(-07.92065181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10858 AB"},
        {"Henry Draper", "HD 162756"},
        {"Hipparcos Number", "HIP 87533"},
        {"Cincinnati Publication", "Ci 18 2374"},
        {"Geneva Identification System", "GEN# +1.00162756"},
        {"Smithsonian Astrophysical Observation", "SAO 141935"},
        {"Wilson Evans Batten Catalogue", "WEB 14765"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.24451692),
        dec: Angle.Degrees(-07.91890043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159209"},
        {"Hipparcos Number", "HIP 85936"},
        {"Smithsonian Astrophysical Observation", "SAO 141732"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.44540130),
        dec: Angle.Degrees(-07.91758200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109985"},
        {"Hipparcos Number", "HIP 61721"},
        {"Smithsonian Astrophysical Observation", "SAO 138890"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.76832134),
        dec: Angle.Degrees(-07.91751528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140124"},
        {"Hipparcos Number", "HIP 76909"},
        {"Smithsonian Astrophysical Observation", "SAO 140705"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.56273623),
        dec: Angle.Degrees(-07.91414278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222465"},
        {"Hipparcos Number", "HIP 116834"},
        {"Geneva Identification System", "GEN# +1.00222465"},
        {"Smithsonian Astrophysical Observation", "SAO 146842"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.20281887),
        dec: Angle.Degrees(-07.91411224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72566"},
        {"Hipparcos Number", "HIP 41976"},
        {"Smithsonian Astrophysical Observation", "SAO 136031"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.34393374),
        dec: Angle.Degrees(-07.91404200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166185"},
        {"Hipparcos Number", "HIP 88996"},
        {"Fundamental Katalog 5th Edition", "FK5 5602"},
        {"Smithsonian Astrophysical Observation", "SAO 142129"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.46821827),
        dec: Angle.Degrees(-07.91368606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17039"},
        {"Hipparcos Number", "HIP 12754"},
        {"Smithsonian Astrophysical Observation", "SAO 130083"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.98145927),
        dec: Angle.Degrees(-07.91232752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134088"},
        {"Hipparcos Number", "HIP 74067"},
        {"Cincinnati Publication", "Ci 20 910"},
        {"Geneva Identification System", "GEN# +1.00134088"},
        {"Smithsonian Astrophysical Observation", "SAO 140339"},
        {"Wilson Evans Batten Catalogue", "WEB 12651"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05274900),
        dec: Angle.Degrees(-07.91211503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -446.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24634"},
        {"Hipparcos Number", "HIP 18293"},
        {"Geneva Identification System", "GEN# +1.00024634"},
        {"Smithsonian Astrophysical Observation", "SAO 130814"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.67764512),
        dec: Angle.Degrees(-07.91027402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150512"},
        {"Hipparcos Number", "HIP 81744"},
        {"Smithsonian Astrophysical Observation", "SAO 141314"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.45258958),
        dec: Angle.Degrees(-07.90847869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11726 A"},
        {"Henry Draper", "HD 174325"},
        {"Hipparcos Number", "HIP 92442"},
        {"Geneva Identification System", "GEN# +1.00174325"},
        {"Smithsonian Astrophysical Observation", "SAO 142674"},
        {"Wilson Evans Batten Catalogue", "WEB 15971"},
    },
    visualMagnitude: 6.82,
    bvColour: 2.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.58346898),
        dec: Angle.Degrees(-07.90760778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207707"},
        {"Hipparcos Number", "HIP 107851"},
        {"Geneva Identification System", "GEN# +1.00207707"},
        {"Smithsonian Astrophysical Observation", "SAO 145703"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.76415337),
        dec: Angle.Degrees(-07.90753537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40987"},
        {"Hipparcos Number", "HIP 28581"},
        {"Smithsonian Astrophysical Observation", "SAO 132758"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.49762827),
        dec: Angle.Degrees(-07.90400778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65132"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.20456925),
        dec: Angle.Degrees(-07.90320356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3273"},
        {"Hipparcos Number", "HIP 2811"},
        {"Geneva Identification System", "GEN# +1.00003273"},
        {"Smithsonian Astrophysical Observation", "SAO 128848"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.94615898),
        dec: Angle.Degrees(-07.90142539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11232"},
        {"Smithsonian Astrophysical Observation", "SAO 129882"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.14235609),
        dec: Angle.Degrees(-07.89979200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129083"},
        {"Hipparcos Number", "HIP 71769"},
        {"Smithsonian Astrophysical Observation", "SAO 140064"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.20885117),
        dec: Angle.Degrees(-07.89850729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16130 AB"},
        {"Henry Draper", "HD 214448"},
        {"Hipparcos Number", "HIP 111761"},
        {"Geneva Identification System", "GEN# +1.00214448J"},
        {"Smithsonian Astrophysical Observation", "SAO 146216"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59208979),
        dec: Angle.Degrees(-07.89755654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 425"},
        {"Hipparcos Number", "HIP 711"},
        {"Smithsonian Astrophysical Observation", "SAO 128609"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.20465275),
        dec: Angle.Degrees(-07.89705908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196370"},
        {"Hipparcos Number", "HIP 101735"},
        {"Smithsonian Astrophysical Observation", "SAO 144629"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31178022),
        dec: Angle.Degrees(-07.89692708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31057"},
        {"Hipparcos Number", "HIP 22644"},
        {"Smithsonian Astrophysical Observation", "SAO 131558"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08192690),
        dec: Angle.Degrees(-07.89564572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139077"},
        {"Hipparcos Number", "HIP 76410"},
        {"Smithsonian Astrophysical Observation", "SAO 140637"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.09668627),
        dec: Angle.Degrees(-07.89528915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45239"},
        {"Hipparcos Number", "HIP 30608"},
        {"Celescope Catalog", "CEL 1231"},
        {"Geneva Identification System", "GEN# +1.00045239"},
        {"Smithsonian Astrophysical Observation", "SAO 133246"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49511860),
        dec: Angle.Degrees(-07.89497456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3531"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.25627971),
        dec: Angle.Degrees(-07.89488136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31469"},
        {"Hipparcos Number", "HIP 22909"},
        {"Geneva Identification System", "GEN# +1.00031469"},
        {"Renson", "Renson 8052"},
        {"Smithsonian Astrophysical Observation", "SAO 131607"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.94003419),
        dec: Angle.Degrees(-07.89380745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26337"},
        {"Hipparcos Number", "HIP 19431"},
        {"Geneva Identification System", "GEN# +1.00026337"},
        {"Smithsonian Astrophysical Observation", "SAO 130994"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.42030350),
        dec: Angle.Degrees(-07.89310465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4186"},
        {"Hipparcos Number", "HIP 3458"},
        {"Renson", "Renson 1143"},
        {"Smithsonian Astrophysical Observation", "SAO 128926"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.05653741),
        dec: Angle.Degrees(-07.88792602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143298"},
        {"Hipparcos Number", "HIP 78354"},
        {"Geneva Identification System", "GEN# +1.00143298"},
        {"Smithsonian Astrophysical Observation", "SAO 140887"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97268015),
        dec: Angle.Degrees(-07.88790593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23317"},
        {"Hipparcos Number", "HIP 17417"},
        {"Fundamental Katalog 5th Edition", "FK5 4339"},
        {"Geneva Identification System", "GEN# +1.00023317"},
        {"Smithsonian Astrophysical Observation", "SAO 130693"},
        {"Wilson Evans Batten Catalogue", "WEB 3294"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.97835834),
        dec: Angle.Degrees(-07.88247769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9705"},
        {"Smithsonian Astrophysical Observation", "SAO 129678"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.20852672),
        dec: Angle.Degrees(-07.88225241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59475"},
        {"Hipparcos Number", "HIP 36433"},
        {"Smithsonian Astrophysical Observation", "SAO 134754"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.46623376),
        dec: Angle.Degrees(-07.88170684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56305"},
        {"Hipparcos Number", "HIP 35178"},
        {"Geneva Identification System", "GEN# +1.00056305"},
        {"Smithsonian Astrophysical Observation", "SAO 134437"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.05650814),
        dec: Angle.Degrees(-07.88062803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202888"},
        {"Hipparcos Number", "HIP 105243"},
        {"Smithsonian Astrophysical Observation", "SAO 145291"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76306890),
        dec: Angle.Degrees(-07.87852237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16766"},
        {"Hipparcos Number", "HIP 12515"},
        {"Smithsonian Astrophysical Observation", "SAO 130054"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.26503936),
        dec: Angle.Degrees(-07.87684797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156344B"},
        {"Hipparcos Number", "HIP 84581"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.34773232),
        dec: Angle.Degrees(-07.87683635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 168.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10957"},
        {"Hipparcos Number", "HIP 8337"},
        {"Smithsonian Astrophysical Observation", "SAO 129502"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.88055799),
        dec: Angle.Degrees(-07.87681933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15477"},
        {"Smithsonian Astrophysical Observation", "SAO 130421"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89171001),
        dec: Angle.Degrees(-07.87660445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 363 AB"},
        {"Henry Draper", "HD 2333"},
        {"Hipparcos Number", "HIP 2143"},
        {"Geneva Identification System", "GEN# +1.00002333"},
        {"Smithsonian Astrophysical Observation", "SAO 128768"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.78245063),
        dec: Angle.Degrees(-07.87604519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72844"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.34461013),
        dec: Angle.Degrees(-07.87428473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44178"},
        {"Hipparcos Number", "HIP 30105"},
        {"Geneva Identification System", "GEN# +1.00044178"},
        {"Smithsonian Astrophysical Observation", "SAO 133124"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.02846586),
        dec: Angle.Degrees(-07.87193757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3733"},
        {"Hipparcos Number", "HIP 3146"},
        {"Smithsonian Astrophysical Observation", "SAO 128882"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.00023902),
        dec: Angle.Degrees(-07.87191914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118511"},
        {"Hipparcos Number", "HIP 66465"},
        {"Smithsonian Astrophysical Observation", "SAO 139447"},
        {"Wilson Evans Batten Catalogue", "WEB 11734"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.39665844),
        dec: Angle.Degrees(-07.87187610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134359"},
        {"Hipparcos Number", "HIP 74191"},
        {"Smithsonian Astrophysical Observation", "SAO 140351"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.40066733),
        dec: Angle.Degrees(-07.87112247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54929"},
        {"Hipparcos Number", "HIP 34649"},
        {"Celescope Catalog", "CEL 1638"},
        {"Geneva Identification System", "GEN# +1.00054929"},
        {"Smithsonian Astrophysical Observation", "SAO 134293"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.63847295),
        dec: Angle.Degrees(-07.87101157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88582"},
        {"Hipparcos Number", "HIP 50029"},
        {"Geneva Identification System", "GEN# +1.00088582"},
        {"Smithsonian Astrophysical Observation", "SAO 137413"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.20826364),
        dec: Angle.Degrees(-07.87054051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156344"},
        {"Hipparcos Number", "HIP 84582"},
        {"Smithsonian Astrophysical Observation", "SAO 141591"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.34708315),
        dec: Angle.Degrees(-07.86917984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120880"},
        {"Hipparcos Number", "HIP 67718"},
        {"Smithsonian Astrophysical Observation", "SAO 139597"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.08749818),
        dec: Angle.Degrees(-07.86660301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130773"},
        {"Hipparcos Number", "HIP 72566"},
        {"Smithsonian Astrophysical Observation", "SAO 140167"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56521094),
        dec: Angle.Degrees(-07.86465663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117501"},
        {"Hipparcos Number", "HIP 65928"},
        {"Smithsonian Astrophysical Observation", "SAO 139377"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.72478751),
        dec: Angle.Degrees(-07.86333365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9933"},
        {"Smithsonian Astrophysical Observation", "SAO 129708"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.96959394),
        dec: Angle.Degrees(-07.86279967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16074"},
        {"Hipparcos Number", "HIP 12002"},
        {"Geneva Identification System", "GEN# +1.00016074"},
        {"Smithsonian Astrophysical Observation", "SAO 129984"},
        {"Wilson Evans Batten Catalogue", "WEB 2474"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.67745683),
        dec: Angle.Degrees(-07.85928850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110724"},
        {"Hipparcos Number", "HIP 62143"},
        {"Smithsonian Astrophysical Observation", "SAO 138943"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.05919920),
        dec: Angle.Degrees(-07.85874184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90374"},
        {"Hipparcos Number", "HIP 51057"},
        {"Smithsonian Astrophysical Observation", "SAO 137559"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.48666384),
        dec: Angle.Degrees(-07.85871351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180458"},
        {"Hipparcos Number", "HIP 94763"},
        {"Smithsonian Astrophysical Observation", "SAO 143214"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24070545),
        dec: Angle.Degrees(-07.85764977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135793"},
        {"Hipparcos Number", "HIP 74800"},
        {"Smithsonian Astrophysical Observation", "SAO 140431"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.30684290),
        dec: Angle.Degrees(-07.85667690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86623"},
        {"Hipparcos Number", "HIP 48978"},
        {"Geneva Identification System", "GEN# +1.00086623"},
        {"Smithsonian Astrophysical Observation", "SAO 137272"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.88911551),
        dec: Angle.Degrees(-07.85653853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106786",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bunda"},
        {"Henry Draper", "HD 205767"},
        {"Hipparcos Number", "HIP 106786"},
        {"Fundamental Katalog 5th Edition", "FK5 1569"},
        {"Geneva Identification System", "GEN# +1.00205767"},
        {"Smithsonian Astrophysical Observation", "SAO 145537"},
        {"Wilson Evans Batten Catalogue", "WEB 19303"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.43767522),
        dec: Angle.Degrees(-07.85414212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8155 AB"},
        {"Henry Draper", "HD 99307"},
        {"Hipparcos Number", "HIP 55759"},
        {"Smithsonian Astrophysical Observation", "SAO 138197"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.37551608),
        dec: Angle.Degrees(-07.85292494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4781"},
        {"Hipparcos Number", "HIP 3874"},
        {"Smithsonian Astrophysical Observation", "SAO 128971"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.43501726),
        dec: Angle.Degrees(-07.84930992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125412"},
        {"Hipparcos Number", "HIP 69993"},
        {"Smithsonian Astrophysical Observation", "SAO 139862"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.83050306),
        dec: Angle.Degrees(-07.84857833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178218"},
        {"Hipparcos Number", "HIP 93972"},
        {"Smithsonian Astrophysical Observation", "SAO 143056"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.00401698),
        dec: Angle.Degrees(-07.84778336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1443"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.49204071),
        dec: Angle.Degrees(-07.84559532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43934"},
        {"Hipparcos Number", "HIP 29971"},
        {"Fundamental Katalog 5th Edition", "FK5 4572"},
        {"Smithsonian Astrophysical Observation", "SAO 133083"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.63986104),
        dec: Angle.Degrees(-07.84060936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133008"},
        {"Hipparcos Number", "HIP 73587"},
        {"Geneva Identification System", "GEN# +1.00133008"},
        {"Smithsonian Astrophysical Observation", "SAO 140283"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.62503952),
        dec: Angle.Degrees(-07.84039867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21948"},
        {"Hipparcos Number", "HIP 16463"},
        {"Smithsonian Astrophysical Observation", "SAO 130548"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.01100144),
        dec: Angle.Degrees(-07.83996106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112035"},
        {"Hipparcos Number", "HIP 62912"},
        {"Geneva Identification System", "GEN# +1.00112035"},
        {"Renson", "Renson 32500"},
        {"Smithsonian Astrophysical Observation", "SAO 139026"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.40297693),
        dec: Angle.Degrees(-07.83916291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22807"},
        {"Hipparcos Number", "HIP 17088"},
        {"Smithsonian Astrophysical Observation", "SAO 130641"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.91236364),
        dec: Angle.Degrees(-07.83910242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28969"},
        {"Hipparcos Number", "HIP 21245"},
        {"Smithsonian Astrophysical Observation", "SAO 131294"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.37004221),
        dec: Angle.Degrees(-07.83876969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56871"},
        {"Hipparcos Number", "HIP 35383"},
        {"Geneva Identification System", "GEN# +1.00056871"},
        {"Smithsonian Astrophysical Observation", "SAO 134492"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63005394),
        dec: Angle.Degrees(-07.83650911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16212"},
        {"Hipparcos Number", "HIP 12107"},
        {"Fundamental Katalog 5th Edition", "FK5 1074"},
        {"Geneva Identification System", "GEN# +1.00016212A"},
        {"Smithsonian Astrophysical Observation", "SAO 130004"},
        {"Wilson Evans Batten Catalogue", "WEB 2493"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.00028366),
        dec: Angle.Degrees(-07.83145306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220670"},
        {"Hipparcos Number", "HIP 115653"},
        {"Smithsonian Astrophysical Observation", "SAO 146701"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.42850568),
        dec: Angle.Degrees(-07.82940270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25954"},
        {"Hipparcos Number", "HIP 19152"},
        {"Smithsonian Astrophysical Observation", "SAO 130953"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.57458460),
        dec: Angle.Degrees(-07.82872057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151332"},
        {"Hipparcos Number", "HIP 82156"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.76132866),
        dec: Angle.Degrees(-07.82825882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100343"},
        {"Hipparcos Number", "HIP 56318"},
        {"Fundamental Katalog 5th Edition", "FK5 2921"},
        {"Geneva Identification System", "GEN# +1.00100343"},
        {"Smithsonian Astrophysical Observation", "SAO 138265"},
        {"Wilson Evans Batten Catalogue", "WEB 10126"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.19808805),
        dec: Angle.Degrees(-07.82752440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11500"},
        {"Hipparcos Number", "HIP 8776"},
        {"Smithsonian Astrophysical Observation", "SAO 129550"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21549369),
        dec: Angle.Degrees(-07.82609062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113849"},
        {"Hipparcos Number", "HIP 63983"},
        {"Smithsonian Astrophysical Observation", "SAO 139160"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.66577708),
        dec: Angle.Degrees(-07.82545277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83729"},
        {"Geneva Identification System", "GEN# -0.00704396J"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.68760806),
        dec: Angle.Degrees(-07.82469912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113805"},
        {"Smithsonian Astrophysical Observation", "SAO 146468"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.69007978),
        dec: Angle.Degrees(-07.82381557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25927"},
    },
    visualMagnitude: 11.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.98771717),
        dec: Angle.Degrees(-07.82313326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44112"},
        {"Hipparcos Number", "HIP 30073"},
        {"Celescope Catalog", "CEL 1180"},
        {"Fundamental Katalog 5th Edition", "FK5 1170"},
        {"Geneva Identification System", "GEN# +1.00044112"},
        {"Smithsonian Astrophysical Observation", "SAO 133114"},
        {"Wilson Evans Batten Catalogue", "WEB 5978"},
    },
    visualMagnitude: 5.27,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.92833719),
        dec: Angle.Degrees(-07.82291023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216777"},
        {"Hipparcos Number", "HIP 113231"},
        {"Cincinnati Publication", "Ci 20 1391"},
        {"Geneva Identification System", "GEN# +1.00216777A"},
        {"Smithsonian Astrophysical Observation", "SAO 146393"},
        {"Wilson Evans Batten Catalogue", "WEB 20149"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.95688553),
        dec: Angle.Degrees(-07.82248788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 553.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32007"},
        {"Hipparcos Number", "HIP 23230"},
        {"Geneva Identification System", "GEN# +1.00032007"},
        {"Renson", "Renson 8147"},
        {"Smithsonian Astrophysical Observation", "SAO 131669"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.97454206),
        dec: Angle.Degrees(-07.82238443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25928"},
        {"Smithsonian Astrophysical Observation", "SAO 132224"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.99291414),
        dec: Angle.Degrees(-07.82200640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102048"},
        {"Hipparcos Number", "HIP 57268"},
        {"Smithsonian Astrophysical Observation", "SAO 138383"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.15679579),
        dec: Angle.Degrees(-07.82152163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211838"},
        {"Hipparcos Number", "HIP 110273"},
        {"Geneva Identification System", "GEN# +1.00211838"},
        {"Renson", "Renson 58800"},
        {"Smithsonian Astrophysical Observation", "SAO 146023"},
        {"Wilson Evans Batten Catalogue", "WEB 19784"},
    },
    visualMagnitude: 5.35,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.04961499),
        dec: Angle.Degrees(-07.82110592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43764",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7086 AB"},
        {"Henry Draper", "HD 76274"},
        {"Hipparcos Number", "HIP 43764"},
        {"Smithsonian Astrophysical Observation", "SAO 136400"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.72775625),
        dec: Angle.Degrees(-07.81846009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1821 AB"},
        {"Henry Draper", "HD 14828"},
        {"Hipparcos Number", "HIP 11136"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.82271941),
        dec: Angle.Degrees(-07.81807688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73232"},
        {"Hipparcos Number", "HIP 42260"},
        {"Smithsonian Astrophysical Observation", "SAO 136093"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.26386323),
        dec: Angle.Degrees(-07.81673164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205670"},
        {"Hipparcos Number", "HIP 106727"},
        {"Smithsonian Astrophysical Observation", "SAO 145530"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.27843100),
        dec: Angle.Degrees(-07.81586889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126879"},
        {"Hipparcos Number", "HIP 70766"},
        {"Smithsonian Astrophysical Observation", "SAO 139952"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.08541700),
        dec: Angle.Degrees(-07.81565784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225060"},
        {"Hipparcos Number", "HIP 245"},
        {"Geneva Identification System", "GEN# +1.00225060"},
        {"Smithsonian Astrophysical Observation", "SAO 128553"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.76358207),
        dec: Angle.Degrees(-07.81552594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11952"},
        {"Hipparcos Number", "HIP 9099"},
        {"Geneva Identification System", "GEN# +1.00011952"},
        {"Smithsonian Astrophysical Observation", "SAO 129578"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.30370204),
        dec: Angle.Degrees(-07.81379137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59905"},
        {"Geneva Identification System", "GEN# -0.00703382"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.31361581),
        dec: Angle.Degrees(-07.81207733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15706"},
        {"Hipparcos Number", "HIP 11726"},
        {"Smithsonian Astrophysical Observation", "SAO 129954"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.84389240),
        dec: Angle.Degrees(-07.81200646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218730"},
        {"Hipparcos Number", "HIP 114424"},
        {"Geneva Identification System", "GEN# +1.00218730"},
        {"Smithsonian Astrophysical Observation", "SAO 146541"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.60263944),
        dec: Angle.Degrees(-07.81166478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17153 AB"},
        {"Henry Draper", "HD 224651"},
        {"Hipparcos Number", "HIP 118294"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.89624486),
        dec: Angle.Degrees(-07.81050916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41207"},
        {"Hipparcos Number", "HIP 28674"},
        {"Smithsonian Astrophysical Observation", "SAO 132784"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.81372062),
        dec: Angle.Degrees(-07.80990005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73910"},
        {"Hipparcos Number", "HIP 42569"},
        {"Smithsonian Astrophysical Observation", "SAO 136161"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.15481217),
        dec: Angle.Degrees(-07.80839425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143397"},
        {"Hipparcos Number", "HIP 78406"},
        {"Geneva Identification System", "GEN# +1.00143397"},
        {"Smithsonian Astrophysical Observation", "SAO 140893"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.09411891),
        dec: Angle.Degrees(-07.80804366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35369"},
        {"Hipparcos Number", "HIP 25247"},
        {"Geneva Identification System", "GEN# +1.00035369"},
        {"Smithsonian Astrophysical Observation", "SAO 132067"},
        {"Wilson Evans Batten Catalogue", "WEB 4896"},
    },
    visualMagnitude: 4.13,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.98681839),
        dec: Angle.Degrees(-07.80795569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188390"},
        {"Hipparcos Number", "HIP 98029"},
        {"Smithsonian Astrophysical Observation", "SAO 143908"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.80484207),
        dec: Angle.Degrees(-07.80671471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78422"},
        {"Hipparcos Number", "HIP 44813"},
        {"Geneva Identification System", "GEN# +1.00078422"},
        {"Smithsonian Astrophysical Observation", "SAO 136598"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.99203217),
        dec: Angle.Degrees(-07.80503834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90581"},
        {"Hipparcos Number", "HIP 51189"},
        {"Smithsonian Astrophysical Observation", "SAO 137576"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.84564988),
        dec: Angle.Degrees(-07.80232060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65199"},
        {"Hipparcos Number", "HIP 38878"},
        {"Smithsonian Astrophysical Observation", "SAO 135294"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.33219440),
        dec: Angle.Degrees(-07.79996474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51588"},
        {"Hipparcos Number", "HIP 33484"},
        {"Smithsonian Astrophysical Observation", "SAO 133958"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.40358299),
        dec: Angle.Degrees(-07.79994190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111096"},
        {"Hipparcos Number", "HIP 62371"},
        {"Geneva Identification System", "GEN# +1.00111096"},
        {"Smithsonian Astrophysical Observation", "SAO 138963"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.74615741),
        dec: Angle.Degrees(-07.79969088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174513"},
        {"Hipparcos Number", "HIP 92510"},
        {"Geneva Identification System", "GEN# +1.00174513"},
        {"Smithsonian Astrophysical Observation", "SAO 142694"},
        {"Wilson Evans Batten Catalogue", "WEB 15996"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.79061201),
        dec: Angle.Degrees(-07.79881573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130048"},
        {"Hipparcos Number", "HIP 72218"},
        {"Geneva Identification System", "GEN# +1.00130048"},
        {"Smithsonian Astrophysical Observation", "SAO 140127"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.55628479),
        dec: Angle.Degrees(-07.79692192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200341"},
        {"Hipparcos Number", "HIP 103904"},
        {"Smithsonian Astrophysical Observation", "SAO 145051"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.79753712),
        dec: Angle.Degrees(-07.79387719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2507 A"},
        {"Henry Draper", "HD 21019"},
        {"Hipparcos Number", "HIP 15776"},
        {"Geneva Identification System", "GEN# +1.00021019"},
        {"Smithsonian Astrophysical Observation", "SAO 130457"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.82374810),
        dec: Angle.Degrees(-07.79356443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11813"},
        {"Smithsonian Astrophysical Observation", "SAO 129963"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09340140),
        dec: Angle.Degrees(-07.79273856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99506"},
        {"Hipparcos Number", "HIP 55851"},
        {"Smithsonian Astrophysical Observation", "SAO 138210"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.70400558),
        dec: Angle.Degrees(-07.79193306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11552 A"},
        {"Henry Draper", "HD 172348"},
        {"Hipparcos Number", "HIP 91532"},
        {"Geneva Identification System", "GEN# +1.00172348"},
        {"Smithsonian Astrophysical Observation", "SAO 142480"},
        {"Wilson Evans Batten Catalogue", "WEB 15736"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.00166783),
        dec: Angle.Degrees(-07.79070788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162059"},
        {"Hipparcos Number", "HIP 87236"},
        {"Smithsonian Astrophysical Observation", "SAO 141892"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.36384920),
        dec: Angle.Degrees(-07.78475997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209460"},
        {"Hipparcos Number", "HIP 108909"},
        {"Smithsonian Astrophysical Observation", "SAO 145842"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.91311216),
        dec: Angle.Degrees(-07.78460649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120637"},
        {"Hipparcos Number", "HIP 67578"},
        {"Smithsonian Astrophysical Observation", "SAO 139584"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.71174642),
        dec: Angle.Degrees(-07.78425343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91961"},
        {"Hipparcos Number", "HIP 51961"},
        {"Geneva Identification System", "GEN# +1.00091961"},
        {"Smithsonian Astrophysical Observation", "SAO 137677"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.22243116),
        dec: Angle.Degrees(-07.78340641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110003",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ancha"},
        {"Henry Draper", "HD 211391"},
        {"Hipparcos Number", "HIP 110003"},
        {"Fundamental Katalog 5th Edition", "FK5 840"},
        {"Geneva Identification System", "GEN# +1.00211391"},
        {"Smithsonian Astrophysical Observation", "SAO 145991"},
        {"Wilson Evans Batten Catalogue", "WEB 19750"},
    },
    visualMagnitude: 4.17,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.20819329),
        dec: Angle.Degrees(-07.78323706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31921"},
        {"Hipparcos Number", "HIP 23182"},
        {"Smithsonian Astrophysical Observation", "SAO 131659"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.82527706),
        dec: Angle.Degrees(-07.78129918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114267"},
        {"Hipparcos Number", "HIP 64210"},
        {"Smithsonian Astrophysical Observation", "SAO 139185"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.40043599),
        dec: Angle.Degrees(-07.78090986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 180 A"},
        {"Henry Draper", "HD 1014"},
        {"Hipparcos Number", "HIP 1158"},
        {"Geneva Identification System", "GEN# +1.00001014J"},
        {"Smithsonian Astrophysical Observation", "SAO 128655"},
        {"Wilson Evans Batten Catalogue", "WEB 205"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61496786),
        dec: Angle.Degrees(-07.78053784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93261"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.96528947),
        dec: Angle.Degrees(-07.77848765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36121"},
        {"Hipparcos Number", "HIP 25682"},
        {"Geneva Identification System", "GEN# +1.00036121"},
        {"Smithsonian Astrophysical Observation", "SAO 132166"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27452050),
        dec: Angle.Degrees(-07.77744396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105759"},
        {"Hipparcos Number", "HIP 59346"},
        {"Smithsonian Astrophysical Observation", "SAO 138625"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.61331430),
        dec: Angle.Degrees(-07.77403030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90012"},
        {"Hipparcos Number", "HIP 50872"},
        {"Smithsonian Astrophysical Observation", "SAO 137531"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.81996089),
        dec: Angle.Degrees(-07.77330699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68312"},
        {"Hipparcos Number", "HIP 40107"},
        {"Geneva Identification System", "GEN# +1.00068312"},
        {"Smithsonian Astrophysical Observation", "SAO 135611"},
        {"Wilson Evans Batten Catalogue", "WEB 7827"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.88762397),
        dec: Angle.Degrees(-07.77247623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54599"},
        {"Hipparcos Number", "HIP 34516"},
        {"Celescope Catalog", "CEL 1613"},
        {"Smithsonian Astrophysical Observation", "SAO 134259"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.27990962),
        dec: Angle.Degrees(-07.77236894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86509"},
        {"Geneva Identification System", "GEN# -0.00704478"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.18247333),
        dec: Angle.Degrees(-07.77033446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84038"},
        {"Hipparcos Number", "HIP 47588"},
        {"Geneva Identification System", "GEN# +1.00084038"},
        {"Smithsonian Astrophysical Observation", "SAO 137064"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.55107797),
        dec: Angle.Degrees(-07.77006155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102266"},
        {"Hipparcos Number", "HIP 57407"},
        {"Smithsonian Astrophysical Observation", "SAO 138394"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.53839898),
        dec: Angle.Degrees(-07.76919404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125906"},
        {"Hipparcos Number", "HIP 70269"},
        {"Smithsonian Astrophysical Observation", "SAO 139897"},
        {"Smithsonian Astrophysical Observation 2", "SAO 139898"},
        {"Wilson Evans Batten Catalogue", "WEB 12201"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.66106181),
        dec: Angle.Degrees(-07.76785216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50461"},
        {"Hipparcos Number", "HIP 33058"},
        {"Geneva Identification System", "GEN# +1.00050461"},
        {"Renson", "Renson 13810"},
        {"Smithsonian Astrophysical Observation", "SAO 133826"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.28332832),
        dec: Angle.Degrees(-07.76556535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149700"},
        {"Hipparcos Number", "HIP 81355"},
        {"Smithsonian Astrophysical Observation", "SAO 141273"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.21581787),
        dec: Angle.Degrees(-07.76219609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59766"},
        {"Hipparcos Number", "HIP 36562"},
        {"Fundamental Katalog 5th Edition", "FK5 4675"},
        {"Smithsonian Astrophysical Observation", "SAO 134783"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.81125785),
        dec: Angle.Degrees(-07.76005956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138200"},
        {"Hipparcos Number", "HIP 75962"},
        {"Smithsonian Astrophysical Observation", "SAO 140575"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70899814),
        dec: Angle.Degrees(-07.76003770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67114"},
        {"Hipparcos Number", "HIP 39654"},
        {"Smithsonian Astrophysical Observation", "SAO 135498"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.55744903),
        dec: Angle.Degrees(-07.75771804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28535",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4608 AB"},
        {"Henry Draper", "HD 40878"},
        {"Hipparcos Number", "HIP 28535"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.35280980),
        dec: Angle.Degrees(-07.75618653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16497 C"},
        {"Henry Draper", "HD 218081"},
        {"Hipparcos Number", "HIP 114006"},
        {"Smithsonian Astrophysical Observation", "SAO 146500"},
        {"Wilson Evans Batten Catalogue", "WEB 20246"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.32711173),
        dec: Angle.Degrees(-07.75468020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49481"},
        {"Hipparcos Number", "HIP 32622"},
        {"Smithsonian Astrophysical Observation", "SAO 133696"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.08983092),
        dec: Angle.Degrees(-07.75460987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37413"},
        {"Hipparcos Number", "HIP 26497"},
        {"Geneva Identification System", "GEN# +1.00037413"},
        {"Smithsonian Astrophysical Observation", "SAO 132391"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.53190663),
        dec: Angle.Degrees(-07.75380391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201009"},
        {"Hipparcos Number", "HIP 104232"},
        {"Smithsonian Astrophysical Observation", "SAO 145112"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.78071628),
        dec: Angle.Degrees(-07.75257624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18031"},
        {"Hipparcos Number", "HIP 13476"},
        {"Geneva Identification System", "GEN# +1.00018031"},
        {"Smithsonian Astrophysical Observation", "SAO 130173"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39482553),
        dec: Angle.Degrees(-07.75013879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106510"},
        {"Geneva Identification System", "GEN# -0.00805680"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.58786780),
        dec: Angle.Degrees(-07.74623926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59514"},
        {"Hipparcos Number", "HIP 36445"},
        {"Smithsonian Astrophysical Observation", "SAO 134757"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.49935304),
        dec: Angle.Degrees(-07.74615524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58457"},
        {"Hipparcos Number", "HIP 36030"},
        {"Smithsonian Astrophysical Observation", "SAO 134647"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.36649733),
        dec: Angle.Degrees(-07.74493979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13721 AB"},
        {"Henry Draper", "HD 193493"},
        {"Hipparcos Number", "HIP 100326"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.19694433),
        dec: Angle.Degrees(-07.74398201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4330 AB"},
        {"Henry Draper", "HD 38324"},
        {"Hipparcos Number", "HIP 27082"},
        {"Celescope Catalog", "CEL 959"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13715289),
        dec: Angle.Degrees(-07.74293622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11352"},
        {"Hipparcos Number", "HIP 8653"},
        {"Smithsonian Astrophysical Observation", "SAO 129536"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.87974212),
        dec: Angle.Degrees(-07.73989355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34638"},
        {"Hipparcos Number", "HIP 24768"},
        {"Geneva Identification System", "GEN# +1.00034638"},
        {"Smithsonian Astrophysical Observation", "SAO 131973"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.66470905),
        dec: Angle.Degrees(-07.73584122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194470"},
        {"Hipparcos Number", "HIP 100778"},
        {"Smithsonian Astrophysical Observation", "SAO 144417"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50412891),
        dec: Angle.Degrees(-07.73459006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197659"},
        {"Hipparcos Number", "HIP 102436"},
        {"Smithsonian Astrophysical Observation", "SAO 144768"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.35055821),
        dec: Angle.Degrees(-07.73454276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163153"},
        {"Hipparcos Number", "HIP 87710"},
        {"Fundamental Katalog 5th Edition", "FK5 1467"},
        {"Geneva Identification System", "GEN# +1.00163153"},
        {"Smithsonian Astrophysical Observation", "SAO 141956"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.74043589),
        dec: Angle.Degrees(-07.73381162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196729"},
        {"Hipparcos Number", "HIP 101939"},
        {"Geneva Identification System", "GEN# +1.00196729"},
        {"Smithsonian Astrophysical Observation", "SAO 144671"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.86302320),
        dec: Angle.Degrees(-07.73250360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32940"},
        {"Hipparcos Number", "HIP 23758"},
        {"Geneva Identification System", "GEN# +1.00032940"},
        {"Smithsonian Astrophysical Observation", "SAO 131771"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.59668317),
        dec: Angle.Degrees(-07.73239302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99897",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13598 A"},
        {"Henry Draper", "HD 192646"},
        {"Hipparcos Number", "HIP 99897"},
        {"Smithsonian Astrophysical Observation", "SAO 144228"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.03511792),
        dec: Angle.Degrees(-07.73216285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131652"},
        {"Hipparcos Number", "HIP 72997"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.78012722),
        dec: Angle.Degrees(-07.73208241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75865"},
        {"Hipparcos Number", "HIP 43574"},
        {"Geneva Identification System", "GEN# +1.00075865"},
        {"Smithsonian Astrophysical Observation", "SAO 136358"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.10979689),
        dec: Angle.Degrees(-07.73113729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173058"},
        {"Hipparcos Number", "HIP 91867"},
        {"Geneva Identification System", "GEN# +1.00173058"},
        {"Smithsonian Astrophysical Observation", "SAO 142552"},
        {"Wilson Evans Batten Catalogue", "WEB 15814"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.93129239),
        dec: Angle.Degrees(-07.73110230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80633"},
        {"Hipparcos Number", "HIP 45838"},
        {"Geneva Identification System", "GEN# +1.00080633"},
        {"Smithsonian Astrophysical Observation", "SAO 136773"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.18507513),
        dec: Angle.Degrees(-07.73009368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61176"},
        {"Hipparcos Number", "HIP 37126"},
        {"Smithsonian Astrophysical Observation", "SAO 134911"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.43002741),
        dec: Angle.Degrees(-07.72722556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219576"},
        {"Hipparcos Number", "HIP 114939"},
        {"Geneva Identification System", "GEN# +1.00219576"},
        {"Smithsonian Astrophysical Observation", "SAO 146612"},
        {"Wilson Evans Batten Catalogue", "WEB 20364"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.21229368),
        dec: Angle.Degrees(-07.72646619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176921"},
        {"Hipparcos Number", "HIP 93520"},
        {"Smithsonian Astrophysical Observation", "SAO 142952"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.70531411),
        dec: Angle.Degrees(-07.72575608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87807"},
        {"Hipparcos Number", "HIP 49590"},
        {"Smithsonian Astrophysical Observation", "SAO 137360"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.84910420),
        dec: Angle.Degrees(-07.72484716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62674"},
        {"Hipparcos Number", "HIP 37793"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.24382161),
        dec: Angle.Degrees(-07.72473927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217626"},
        {"Hipparcos Number", "HIP 113748"},
        {"Geneva Identification System", "GEN# +1.00217626"},
        {"Smithsonian Astrophysical Observation", "SAO 146462"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.54664339),
        dec: Angle.Degrees(-07.72440802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74995"},
        {"Cincinnati Publication", "Ci 20 923"},
        {"Geneva Identification System", "GEN# -0.00704003"},
        {"Wilson Evans Batten Catalogue", "WEB 12795"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86477439),
        dec: Angle.Degrees(-07.72203834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1224.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81884"},
        {"Hipparcos Number", "HIP 46435"},
        {"Smithsonian Astrophysical Observation", "SAO 136880"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.05528919),
        dec: Angle.Degrees(-07.72072277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213292"},
        {"Hipparcos Number", "HIP 111111"},
        {"Smithsonian Astrophysical Observation", "SAO 146129"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.63470628),
        dec: Angle.Degrees(-07.72051627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202280"},
        {"Hipparcos Number", "HIP 104898"},
        {"Smithsonian Astrophysical Observation", "SAO 145231"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.72721500),
        dec: Angle.Degrees(-07.72035719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16100"},
        {"Hipparcos Number", "HIP 12021"},
        {"Smithsonian Astrophysical Observation", "SAO 129988"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.76542176),
        dec: Angle.Degrees(-07.71912042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28798"},
        {"Smithsonian Astrophysical Observation", "SAO 132805"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.19988294),
        dec: Angle.Degrees(-07.71704305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199239"},
        {"Hipparcos Number", "HIP 103334"},
        {"Smithsonian Astrophysical Observation", "SAO 144953"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.02940721),
        dec: Angle.Degrees(-07.71627544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36513"},
        {"Hipparcos Number", "HIP 25915"},
        {"Geneva Identification System", "GEN# +1.00036513"},
        {"Smithsonian Astrophysical Observation", "SAO 132219"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.96345952),
        dec: Angle.Degrees(-07.71616591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182787"},
        {"Hipparcos Number", "HIP 95597"},
        {"Smithsonian Astrophysical Observation", "SAO 143400"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.66130968),
        dec: Angle.Degrees(-07.71610429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14528"},
        {"Smithsonian Astrophysical Observation", "SAO 130297"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.90206605),
        dec: Angle.Degrees(-07.71547207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74784"},
        {"Hipparcos Number", "HIP 43006"},
        {"Geneva Identification System", "GEN# +1.00074784"},
        {"Renson", "Renson 20908"},
        {"Smithsonian Astrophysical Observation", "SAO 136250"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.46644726),
        dec: Angle.Degrees(-07.71467555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199469"},
        {"Hipparcos Number", "HIP 103457"},
        {"Geneva Identification System", "GEN# +1.00199469"},
        {"Smithsonian Astrophysical Observation", "SAO 144978"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41734100),
        dec: Angle.Degrees(-07.71347480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171279"},
        {"Hipparcos Number", "HIP 91031"},
        {"Geneva Identification System", "GEN# +1.00171279"},
        {"Renson", "Renson 47970"},
        {"Smithsonian Astrophysical Observation", "SAO 142391"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.55172463),
        dec: Angle.Degrees(-07.71232063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76014"},
        {"Hipparcos Number", "HIP 43638"},
        {"Smithsonian Astrophysical Observation", "SAO 136369"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.32055801),
        dec: Angle.Degrees(-07.71065921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31056"},
        {"Hipparcos Number", "HIP 22649"},
        {"Geneva Identification System", "GEN# +1.00031056"},
        {"Smithsonian Astrophysical Observation", "SAO 131560"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08709834),
        dec: Angle.Degrees(-07.70929398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7949"},
        {"Hipparcos Number", "HIP 6150"},
        {"Smithsonian Astrophysical Observation", "SAO 129221"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73497731),
        dec: Angle.Degrees(-07.70492365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20476",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3178 A"},
        {"Henry Draper", "HD 27841"},
        {"Hipparcos Number", "HIP 20476"},
        {"Smithsonian Astrophysical Observation", "SAO 131170"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.83222175),
        dec: Angle.Degrees(-07.70454895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154229"},
        {"Hipparcos Number", "HIP 83548"},
        {"Smithsonian Astrophysical Observation", "SAO 141506"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12848866),
        dec: Angle.Degrees(-07.70438884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43268"},
        {"Hipparcos Number", "HIP 29663"},
        {"Smithsonian Astrophysical Observation", "SAO 133016"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.73365245),
        dec: Angle.Degrees(-07.70436014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34547"},
        {"Smithsonian Astrophysical Observation", "SAO 134267"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.36186333),
        dec: Angle.Degrees(-07.70356300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98354"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.74117385),
        dec: Angle.Degrees(-07.70315506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219295"},
        {"Hipparcos Number", "HIP 114763"},
        {"Smithsonian Astrophysical Observation", "SAO 146589"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.70701855),
        dec: Angle.Degrees(-07.70282526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2542"},
        {"Hipparcos Number", "HIP 2275"},
        {"Smithsonian Astrophysical Observation", "SAO 128778"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.27368345),
        dec: Angle.Degrees(-07.70279608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 779"},
        {"Hipparcos Number", "HIP 977"},
        {"Smithsonian Astrophysical Observation", "SAO 128636"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.02534364),
        dec: Angle.Degrees(-07.70199823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144659"},
        {"Hipparcos Number", "HIP 78971"},
        {"Geneva Identification System", "GEN# +1.00144659"},
        {"Smithsonian Astrophysical Observation", "SAO 140968"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.81777772),
        dec: Angle.Degrees(-07.70161272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57230"},
        {"Hipparcos Number", "HIP 35535"},
        {"Smithsonian Astrophysical Observation", "SAO 134525"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.00310753),
        dec: Angle.Degrees(-07.69905506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189964"},
        {"Hipparcos Number", "HIP 98720"},
        {"Smithsonian Astrophysical Observation", "SAO 144026"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.76543443),
        dec: Angle.Degrees(-07.69724384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35563"},
        {"Hipparcos Number", "HIP 25352"},
        {"Smithsonian Astrophysical Observation", "SAO 132084"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.33095969),
        dec: Angle.Degrees(-07.69642168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209712"},
        {"Hipparcos Number", "HIP 109053"},
        {"Geneva Identification System", "GEN# +1.00209712"},
        {"Smithsonian Astrophysical Observation", "SAO 145861"},
        {"Wilson Evans Batten Catalogue", "WEB 19607"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.38483154),
        dec: Angle.Degrees(-07.69525570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218331"},
        {"Hipparcos Number", "HIP 114164"},
        {"Smithsonian Astrophysical Observation", "SAO 146515"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.79872402),
        dec: Angle.Degrees(-07.69446498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113996",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16497 AB"},
        {"Henry Draper", "HD 218060"},
        {"Hipparcos Number", "HIP 113996"},
        {"Geneva Identification System", "GEN# +1.00218060"},
        {"Smithsonian Astrophysical Observation", "SAO 146498"},
        {"Wilson Evans Batten Catalogue", "WEB 20245"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.29047874),
        dec: Angle.Degrees(-07.69381853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95900"},
        {"Hipparcos Number", "HIP 54069"},
        {"Smithsonian Astrophysical Observation", "SAO 137970"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.95857064),
        dec: Angle.Degrees(-07.68803577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48651"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.81329516),
        dec: Angle.Degrees(-07.68782095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2312 A"},
        {"Henry Draper", "HD 18953"},
        {"Hipparcos Number", "HIP 14168"},
        {"Geneva Identification System", "GEN# +1.00018953"},
        {"Smithsonian Astrophysical Observation", "SAO 130254"},
        {"Wilson Evans Batten Catalogue", "WEB 2785"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.67608040),
        dec: Angle.Degrees(-07.68546315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10172"},
        {"Smithsonian Astrophysical Observation", "SAO 129732"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.70641335),
        dec: Angle.Degrees(-07.68484160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104625"},
        {"Hipparcos Number", "HIP 58741"},
        {"Geneva Identification System", "GEN# +1.00104625"},
        {"Smithsonian Astrophysical Observation", "SAO 138551"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.71533620),
        dec: Angle.Degrees(-07.68366221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 876"},
        {"Hipparcos Number", "HIP 1053"},
        {"Smithsonian Astrophysical Observation", "SAO 128643"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.28431076),
        dec: Angle.Degrees(-07.68257721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146719"},
        {"Hipparcos Number", "HIP 79851"},
        {"Smithsonian Astrophysical Observation", "SAO 141083"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.49518659),
        dec: Angle.Degrees(-07.68154009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56006"},
        {"Hipparcos Number", "HIP 35057"},
        {"Celescope Catalog", "CEL 1704"},
        {"Geneva Identification System", "GEN# +1.00056006"},
        {"Smithsonian Astrophysical Observation", "SAO 134412"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.74662505),
        dec: Angle.Degrees(-07.68029191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221777"},
        {"Hipparcos Number", "HIP 116388"},
        {"Geneva Identification System", "GEN# +1.00221777"},
        {"Smithsonian Astrophysical Observation", "SAO 146786"},
        {"Wilson Evans Batten Catalogue", "WEB 20564"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.76755199),
        dec: Angle.Degrees(-07.67744289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139379"},
        {"Hipparcos Number", "HIP 76555"},
        {"Smithsonian Astrophysical Observation", "SAO 140665"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.52354151),
        dec: Angle.Degrees(-07.67597332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6377"},
        {"Hipparcos Number", "HIP 5047"},
        {"Smithsonian Astrophysical Observation", "SAO 129109"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.15901423),
        dec: Angle.Degrees(-07.67442397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81071"},
        {"Hipparcos Number", "HIP 46044"},
        {"Fundamental Katalog 5th Edition", "FK5 4834"},
        {"Smithsonian Astrophysical Observation", "SAO 136805"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84891853),
        dec: Angle.Degrees(-07.67147620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164763"},
        {"Hipparcos Number", "HIP 88412"},
        {"Geneva Identification System", "GEN# +1.00164763"},
        {"Smithsonian Astrophysical Observation", "SAO 142051"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77691412),
        dec: Angle.Degrees(-07.66836897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28319"},
    },
    visualMagnitude: 12.80,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.74841925),
        dec: Angle.Degrees(-07.66755414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95071"},
    },
    visualMagnitude: 12.28,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.14566329),
        dec: Angle.Degrees(-07.66629110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207224"},
        {"Hipparcos Number", "HIP 107595"},
        {"Geneva Identification System", "GEN# +1.00207224"},
        {"Smithsonian Astrophysical Observation", "SAO 145670"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.90459997),
        dec: Angle.Degrees(-07.66626075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124801"},
        {"Hipparcos Number", "HIP 69675"},
        {"Smithsonian Astrophysical Observation", "SAO 139818"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.92564777),
        dec: Angle.Degrees(-07.66584491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65712"},
        {"Smithsonian Astrophysical Observation", "SAO 139352"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.08470821),
        dec: Angle.Degrees(-07.66568269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108961"},
        {"Hipparcos Number", "HIP 61095"},
        {"Smithsonian Astrophysical Observation", "SAO 138829"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82069462),
        dec: Angle.Degrees(-07.66534467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62"},
        {"Hipparcos Number", "HIP 458"},
        {"Smithsonian Astrophysical Observation", "SAO 128575"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36762563),
        dec: Angle.Degrees(-07.66532823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214132"},
        {"Hipparcos Number", "HIP 111577"},
        {"Geneva Identification System", "GEN# +1.00214132"},
        {"Smithsonian Astrophysical Observation", "SAO 146188"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.07091489),
        dec: Angle.Degrees(-07.66438226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18321"},
        {"Hipparcos Number", "HIP 13704"},
        {"Smithsonian Astrophysical Observation", "SAO 130198"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.11171381),
        dec: Angle.Degrees(-07.66324491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18784"},
        {"Hipparcos Number", "HIP 14060"},
        {"Geneva Identification System", "GEN# +1.00018784"},
        {"Smithsonian Astrophysical Observation", "SAO 130243"},
        {"Wilson Evans Batten Catalogue", "WEB 2771"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.29152748),
        dec: Angle.Degrees(-07.66283629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87290"},
        {"Hipparcos Number", "HIP 49312"},
        {"Smithsonian Astrophysical Observation", "SAO 137331"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.98489284),
        dec: Angle.Degrees(-07.66191891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53915"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.47977768),
        dec: Angle.Degrees(-07.66158803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140123"},
        {"Hipparcos Number", "HIP 76916"},
        {"Geneva Identification System", "GEN# +1.00140123"},
        {"Smithsonian Astrophysical Observation", "SAO 140706"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.57894742),
        dec: Angle.Degrees(-07.66091871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7812"},
        {"Hipparcos Number", "HIP 6048"},
        {"Smithsonian Astrophysical Observation", "SAO 129217"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42647013),
        dec: Angle.Degrees(-07.65955931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37747"},
        {"Hipparcos Number", "HIP 26709"},
        {"Smithsonian Astrophysical Observation", "SAO 132442"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.13585977),
        dec: Angle.Degrees(-07.65942451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3770"},
        {"Hipparcos Number", "HIP 3169"},
        {"Geneva Identification System", "GEN# +1.00003770"},
        {"Smithsonian Astrophysical Observation", "SAO 128888"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.10140616),
        dec: Angle.Degrees(-07.65641664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114286"},
        {"Hipparcos Number", "HIP 64225"},
        {"Geneva Identification System", "GEN# +1.00114286"},
        {"Smithsonian Astrophysical Observation", "SAO 139187"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.44283955),
        dec: Angle.Degrees(-07.65536723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105051",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14804 AB"},
        {"Henry Draper", "HD 202533"},
        {"Hipparcos Number", "HIP 105051"},
        {"Smithsonian Astrophysical Observation", "SAO 145258"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.18037756),
        dec: Angle.Degrees(-07.65477763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14116"},
        {"Hipparcos Number", "HIP 10632"},
        {"Smithsonian Astrophysical Observation", "SAO 129796"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.21029842),
        dec: Angle.Degrees(-07.65399298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30592"},
        {"Hipparcos Number", "HIP 22330"},
        {"Smithsonian Astrophysical Observation", "SAO 131505"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14189710),
        dec: Angle.Degrees(-07.65254064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31110"},
        {"Hipparcos Number", "HIP 22687"},
        {"Smithsonian Astrophysical Observation", "SAO 131565"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.18580212),
        dec: Angle.Degrees(-07.65169538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145915"},
        {"Hipparcos Number", "HIP 79532"},
        {"Smithsonian Astrophysical Observation", "SAO 141042"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.44300800),
        dec: Angle.Degrees(-07.64565974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86082"},
        {"Hipparcos Number", "HIP 48712"},
        {"Fundamental Katalog 5th Edition", "FK5 1257"},
        {"Geneva Identification System", "GEN# +1.00086082"},
        {"Smithsonian Astrophysical Observation", "SAO 137237"},
        {"Wilson Evans Batten Catalogue", "WEB 9058"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.03338582),
        dec: Angle.Degrees(-07.64532876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19849",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Keid"},
        {"Aitken", "ADS 3093 A"},
        {"Henry Draper", "HD 26965"},
        {"Hipparcos Number", "HIP 19849"},
        {"Cincinnati Publication", "Ci 20 288"},
        {"Geneva Identification System", "GEN# +1.00026965A"},
        {"Geneva Identification System 2", "GEN# +1.00026965"},
        {"Smithsonian Astrophysical Observation", "SAO 131063"},
        {"Wilson Evans Batten Catalogue", "WEB 3792"},
    },
    visualMagnitude: 4.43,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.82349230),
        dec: Angle.Degrees(-07.64455846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2239.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3419.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36203"},
        {"Hipparcos Number", "HIP 25744"},
        {"Geneva Identification System", "GEN# +1.00036203"},
        {"Smithsonian Astrophysical Observation", "SAO 132179"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.45410080),
        dec: Angle.Degrees(-07.64314117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24782"},
        {"Hipparcos Number", "HIP 18403"},
        {"Smithsonian Astrophysical Observation", "SAO 130827"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.02432128),
        dec: Angle.Degrees(-07.64174745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104184"},
        {"Hipparcos Number", "HIP 58505"},
        {"Geneva Identification System", "GEN# +1.00104184"},
        {"Smithsonian Astrophysical Observation", "SAO 138524"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.97893548),
        dec: Angle.Degrees(-07.64171008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201588"},
        {"Hipparcos Number", "HIP 104560"},
        {"Geneva Identification System", "GEN# +1.00201588"},
        {"Smithsonian Astrophysical Observation", "SAO 145173"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.70073594),
        dec: Angle.Degrees(-07.64152956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25127"},
        {"Hipparcos Number", "HIP 18631"},
        {"Smithsonian Astrophysical Observation", "SAO 130861"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.81404684),
        dec: Angle.Degrees(-07.64045104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145915B"},
        {"Hipparcos Number", "HIP 79531"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.44250569),
        dec: Angle.Degrees(-07.64024208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7808 AB"},
        {"Henry Draper", "HD 91106"},
        {"Hipparcos Number", "HIP 51490"},
        {"Geneva Identification System", "GEN# +1.00091106"},
        {"Smithsonian Astrophysical Observation", "SAO 137614"},
        {"Wilson Evans Batten Catalogue", "WEB 9396"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.74493577),
        dec: Angle.Degrees(-07.63754495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39990"},
        {"Hipparcos Number", "HIP 28039"},
        {"Smithsonian Astrophysical Observation", "SAO 132663"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.94680816),
        dec: Angle.Degrees(-07.63612957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119706"},
        {"Hipparcos Number", "HIP 67082"},
        {"Smithsonian Astrophysical Observation", "SAO 139527"},
        {"Wilson Evans Batten Catalogue", "WEB 11813"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.23708173),
        dec: Angle.Degrees(-07.63440030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154908"},
        {"Hipparcos Number", "HIP 83881"},
        {"Smithsonian Astrophysical Observation", "SAO 141531"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.16524149),
        dec: Angle.Degrees(-07.63368348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111545"},
        {"Hipparcos Number", "HIP 62636"},
        {"Geneva Identification System", "GEN# +1.00111545"},
        {"Smithsonian Astrophysical Observation", "SAO 138986"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.52204376),
        dec: Angle.Degrees(-07.63222915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87855"},
        {"Hipparcos Number", "HIP 49633"},
        {"Geneva Identification System", "GEN# +1.00087855"},
        {"Smithsonian Astrophysical Observation", "SAO 137364"},
        {"Wilson Evans Batten Catalogue", "WEB 9153"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.94026882),
        dec: Angle.Degrees(-07.63073464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83874"},
        {"Hipparcos Number", "HIP 47516"},
        {"Smithsonian Astrophysical Observation", "SAO 137053"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29957999),
        dec: Angle.Degrees(-07.62806860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81597"},
        {"Hipparcos Number", "HIP 46300"},
        {"Smithsonian Astrophysical Observation", "SAO 136849"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.62461257),
        dec: Angle.Degrees(-07.62717249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18790",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2943 AB"},
        {"Hipparcos Number", "HIP 18790"},
        {"Smithsonian Astrophysical Observation", "SAO 130880"},
    },
    visualMagnitude: 9.25,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.39062724),
        dec: Angle.Degrees(-07.62667365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117878"},
        {"Hipparcos Number", "HIP 66131"},
        {"Geneva Identification System", "GEN# +1.00117878"},
        {"Smithsonian Astrophysical Observation", "SAO 139407"},
        {"Wilson Evans Batten Catalogue", "WEB 11686"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.35234010),
        dec: Angle.Degrees(-07.62261992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5760",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 997 A"},
        {"Henry Draper", "HD 7385"},
        {"Hipparcos Number", "HIP 5760"},
        {"Geneva Identification System", "GEN# +1.00007385"},
        {"Smithsonian Astrophysical Observation", "SAO 129188"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.48126590),
        dec: Angle.Degrees(-07.62248123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197125"},
        {"Hipparcos Number", "HIP 102148"},
        {"Smithsonian Astrophysical Observation", "SAO 144715"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.47302164),
        dec: Angle.Degrees(-07.62017783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173202"},
        {"Hipparcos Number", "HIP 91933"},
        {"Geneva Identification System", "GEN# +1.00173202J"},
        {"Smithsonian Astrophysical Observation", "SAO 142564"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.11597555),
        dec: Angle.Degrees(-07.61848978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215352"},
        {"Hipparcos Number", "HIP 112283"},
        {"Geneva Identification System", "GEN# +1.00215352"},
        {"Smithsonian Astrophysical Observation", "SAO 146287"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.14874891),
        dec: Angle.Degrees(-07.61717732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 997 B"},
        {"Hipparcos Number", "HIP 5759"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.47981910),
        dec: Angle.Degrees(-07.61686915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12083"},
        {"Hipparcos Number", "HIP 9213"},
        {"Geneva Identification System", "GEN# +1.00012083"},
        {"Smithsonian Astrophysical Observation", "SAO 129597"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62167595),
        dec: Angle.Degrees(-07.61654434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97586"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.52640979),
        dec: Angle.Degrees(-07.61460773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107330"},
        {"Hipparcos Number", "HIP 60179"},
        {"Smithsonian Astrophysical Observation", "SAO 138727"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.10862638),
        dec: Angle.Degrees(-07.61370429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108158"},
        {"Hipparcos Number", "HIP 60636"},
        {"Smithsonian Astrophysical Observation", "SAO 138773"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.40128631),
        dec: Angle.Degrees(-07.61327543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112141"},
        {"Hipparcos Number", "HIP 62991"},
        {"Smithsonian Astrophysical Observation", "SAO 139034"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.61206519),
        dec: Angle.Degrees(-07.61037362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125883"},
        {"Hipparcos Number", "HIP 70256"},
        {"Geneva Identification System", "GEN# +1.00125883"},
        {"Smithsonian Astrophysical Observation", "SAO 139895"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.62711676),
        dec: Angle.Degrees(-07.60888659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212062"},
        {"Hipparcos Number", "HIP 110396"},
        {"Smithsonian Astrophysical Observation", "SAO 146043"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.42420964),
        dec: Angle.Degrees(-07.60832582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194230"},
        {"Hipparcos Number", "HIP 100683"},
        {"Geneva Identification System", "GEN# +1.00194230"},
        {"Smithsonian Astrophysical Observation", "SAO 144395"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18916407),
        dec: Angle.Degrees(-07.60640550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78013"},
        {"Hipparcos Number", "HIP 44635"},
        {"Renson", "Renson 22070"},
        {"Smithsonian Astrophysical Observation", "SAO 136573"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.42785655),
        dec: Angle.Degrees(-07.60564186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214614"},
        {"Hipparcos Number", "HIP 111863"},
        {"Smithsonian Astrophysical Observation", "SAO 146225"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.87652555),
        dec: Angle.Degrees(-07.60454876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58340"},
        {"Hipparcos Number", "HIP 35982"},
        {"Geneva Identification System", "GEN# +1.00058340"},
        {"Renson", "Renson 15934"},
        {"Smithsonian Astrophysical Observation", "SAO 134638"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.23526721),
        dec: Angle.Degrees(-07.60383034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171804"},
        {"Hipparcos Number", "HIP 91275"},
        {"Geneva Identification System", "GEN# +1.00171804"},
        {"Wilson Evans Batten Catalogue", "WEB 15684"},
    },
    visualMagnitude: 8.60,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.26701257),
        dec: Angle.Degrees(-07.60327965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94617"},
        {"Hipparcos Number", "HIP 53400"},
        {"Smithsonian Astrophysical Observation", "SAO 137887"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.83335912),
        dec: Angle.Degrees(-07.60092494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19107"},
        {"Hipparcos Number", "HIP 14293"},
        {"Geneva Identification System", "GEN# +1.00019107"},
        {"Smithsonian Astrophysical Observation", "SAO 130269"},
        {"Wilson Evans Batten Catalogue", "WEB 2798"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.06865515),
        dec: Angle.Degrees(-07.60089934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101209"},
        {"Hipparcos Number", "HIP 56817"},
        {"Geneva Identification System", "GEN# +1.00101209"},
        {"Smithsonian Astrophysical Observation", "SAO 138316"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.70605616),
        dec: Angle.Degrees(-07.60004200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85537"},
        {"Hipparcos Number", "HIP 48427"},
        {"Smithsonian Astrophysical Observation", "SAO 137197"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.08629067),
        dec: Angle.Degrees(-07.59898576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42040"},
        {"Hipparcos Number", "HIP 29095"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.05818734),
        dec: Angle.Degrees(-07.59883533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120584"},
        {"Hipparcos Number", "HIP 67553"},
        {"Smithsonian Astrophysical Observation", "SAO 139581"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.63553427),
        dec: Angle.Degrees(-07.59850956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148349"},
        {"Hipparcos Number", "HIP 80620"},
        {"Geneva Identification System", "GEN# +1.00148349"},
        {"Smithsonian Astrophysical Observation", "SAO 141186"},
        {"Wilson Evans Batten Catalogue", "WEB 13635"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.93107061),
        dec: Angle.Degrees(-07.59755617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25852"},
        {"Hipparcos Number", "HIP 19084"},
        {"Smithsonian Astrophysical Observation", "SAO 130940"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.37744309),
        dec: Angle.Degrees(-07.59724130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103154"},
        {"Hipparcos Number", "HIP 57917"},
        {"Geneva Identification System", "GEN# +1.00103154"},
        {"Smithsonian Astrophysical Observation", "SAO 138457"},
        {"Wilson Evans Batten Catalogue", "WEB 10383"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.18791912),
        dec: Angle.Degrees(-07.59667770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194078"},
        {"Hipparcos Number", "HIP 100596"},
        {"Smithsonian Astrophysical Observation", "SAO 144377"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97628506),
        dec: Angle.Degrees(-07.59636448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33163"},
        {"Wilson Evans Batten Catalogue", "WEB 6670"},
    },
    visualMagnitude: 10.55,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55131284),
        dec: Angle.Degrees(-07.59584157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35178"},
        {"Hipparcos Number", "HIP 25116"},
        {"Celescope Catalog", "CEL 658"},
        {"Geneva Identification System", "GEN# +1.00035178"},
        {"Smithsonian Astrophysical Observation", "SAO 132039"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64751402),
        dec: Angle.Degrees(-07.59414837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24076",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3748 AB"},
        {"Henry Draper", "HD 33507"},
        {"Hipparcos Number", "HIP 24076"},
        {"Smithsonian Astrophysical Observation", "SAO 131841"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.58623886),
        dec: Angle.Degrees(-07.59367425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28220"},
        {"Hipparcos Number", "HIP 20757"},
        {"Smithsonian Astrophysical Observation", "SAO 131218"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.71496875),
        dec: Angle.Degrees(-07.59299526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27563"},
        {"Hipparcos Number", "HIP 20271"},
        {"Fundamental Katalog 5th Edition", "FK5 2322"},
        {"Geneva Identification System", "GEN# +1.00027563"},
        {"Smithsonian Astrophysical Observation", "SAO 131132"},
        {"Wilson Evans Batten Catalogue", "WEB 3875"},
    },
    visualMagnitude: 5.85,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.17846608),
        dec: Angle.Degrees(-07.59249081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16468"},
        {"Hipparcos Number", "HIP 12292"},
        {"Smithsonian Astrophysical Observation", "SAO 130028"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.58443763),
        dec: Angle.Degrees(-07.59051171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40728"},
        {"Hipparcos Number", "HIP 28453"},
        {"Smithsonian Astrophysical Observation", "SAO 132739"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11310432),
        dec: Angle.Degrees(-07.58971131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90185"},
        {"Hipparcos Number", "HIP 50955"},
        {"Smithsonian Astrophysical Observation", "SAO 137542"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.10383685),
        dec: Angle.Degrees(-07.58807497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211532"},
        {"Hipparcos Number", "HIP 110079"},
        {"Smithsonian Astrophysical Observation", "SAO 146000"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.46119205),
        dec: Angle.Degrees(-07.58762460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36697"},
        {"Hipparcos Number", "HIP 26036"},
        {"Geneva Identification System", "GEN# +1.00036697"},
        {"Renson", "Renson 9600"},
        {"Smithsonian Astrophysical Observation", "SAO 132252"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.31871119),
        dec: Angle.Degrees(-07.58752470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186642"},
        {"Hipparcos Number", "HIP 97256"},
        {"Smithsonian Astrophysical Observation", "SAO 143777"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.49048141),
        dec: Angle.Degrees(-07.58716475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74833"},
        {"Hipparcos Number", "HIP 43034"},
        {"Smithsonian Astrophysical Observation", "SAO 136257"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.52741827),
        dec: Angle.Degrees(-07.58431320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116681"},
        {"Hipparcos Number", "HIP 65491"},
        {"Smithsonian Astrophysical Observation", "SAO 139332"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.33760545),
        dec: Angle.Degrees(-07.58404745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66201"},
        {"Hipparcos Number", "HIP 39300"},
        {"Smithsonian Astrophysical Observation", "SAO 135403"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.52907111),
        dec: Angle.Degrees(-07.58264540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106449"},
        {"Geneva Identification System", "GEN# -0.00805676"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.40811470),
        dec: Angle.Degrees(-07.58140052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93196"},
        {"Hipparcos Number", "HIP 52617"},
        {"Smithsonian Astrophysical Observation", "SAO 137765"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.39458072),
        dec: Angle.Degrees(-07.58062292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216386"},
        {"Hipparcos Number", "HIP 112961"},
        {"Fundamental Katalog 5th Edition", "FK5 864"},
        {"Geneva Identification System", "GEN# +1.00216386"},
        {"Smithsonian Astrophysical Observation", "SAO 146362"},
        {"Wilson Evans Batten Catalogue", "WEB 20114"},
    },
    visualMagnitude: 3.73,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.15360192),
        dec: Angle.Degrees(-07.57967878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9754"},
        {"Hipparcos Number", "HIP 7391"},
        {"Smithsonian Astrophysical Observation", "SAO 129390"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.82727434),
        dec: Angle.Degrees(-07.57919730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173693"},
        {"Hipparcos Number", "HIP 92150"},
        {"Smithsonian Astrophysical Observation", "SAO 142612"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.72789320),
        dec: Angle.Degrees(-07.57911848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5453"},
        {"Hipparcos Number", "HIP 4385"},
        {"Geneva Identification System", "GEN# +1.00005453"},
        {"Smithsonian Astrophysical Observation", "SAO 129039"},
        {"Wilson Evans Batten Catalogue", "WEB 785"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.05463596),
        dec: Angle.Degrees(-07.57709226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55852"},
        {"Hipparcos Number", "HIP 34994"},
        {"Geneva Identification System", "GEN# +1.00055852"},
        {"Renson", "Renson 15210"},
        {"Smithsonian Astrophysical Observation", "SAO 134401"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.60879239),
        dec: Angle.Degrees(-07.57699258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95246"},
        {"Hipparcos Number", "HIP 53738"},
        {"Smithsonian Astrophysical Observation", "SAO 137930"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.93608584),
        dec: Angle.Degrees(-07.57608149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132953"},
        {"Hipparcos Number", "HIP 73571"},
        {"Geneva Identification System", "GEN# +1.00132953"},
        {"Smithsonian Astrophysical Observation", "SAO 140281"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.53577825),
        dec: Angle.Degrees(-07.57529216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24690"},
        {"Smithsonian Astrophysical Observation", "SAO 131954"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.43643930),
        dec: Angle.Degrees(-07.57367050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8132 AB"},
        {"Henry Draper", "HD 98429"},
        {"Hipparcos Number", "HIP 55287"},
        {"Smithsonian Astrophysical Observation", "SAO 138131"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.84290416),
        dec: Angle.Degrees(-07.57354751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196796"},
        {"Hipparcos Number", "HIP 101969"},
        {"Smithsonian Astrophysical Observation", "SAO 144675"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.97424013),
        dec: Angle.Degrees(-07.57306024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48016"},
        {"Hipparcos Number", "HIP 31985"},
        {"Smithsonian Astrophysical Observation", "SAO 133566"},
        {"Wilson Evans Batten Catalogue", "WEB 6440"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.25772616),
        dec: Angle.Degrees(-07.57263378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133235"},
        {"Hipparcos Number", "HIP 73676"},
        {"Smithsonian Astrophysical Observation", "SAO 140292"},
        {"Wilson Evans Batten Catalogue", "WEB 12594"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.90376359),
        dec: Angle.Degrees(-07.57136426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69789"},
        {"Hipparcos Number", "HIP 40694"},
        {"Geneva Identification System", "GEN# +1.00069789"},
        {"Smithsonian Astrophysical Observation", "SAO 135752"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.60290733),
        dec: Angle.Degrees(-07.57130638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13874"},
        {"Hipparcos Number", "HIP 10473"},
        {"Smithsonian Astrophysical Observation", "SAO 129777"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.75733807),
        dec: Angle.Degrees(-07.57074551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108508"},
        {"Hipparcos Number", "HIP 60820"},
        {"Smithsonian Astrophysical Observation", "SAO 138801"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.99908713),
        dec: Angle.Degrees(-07.56805806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208721"},
        {"Hipparcos Number", "HIP 108462"},
        {"Smithsonian Astrophysical Observation", "SAO 145779"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.58647008),
        dec: Angle.Degrees(-07.56734773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174163"},
        {"Hipparcos Number", "HIP 92380"},
        {"Smithsonian Astrophysical Observation", "SAO 142660"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.39176977),
        dec: Angle.Degrees(-07.56715263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208461"},
        {"Hipparcos Number", "HIP 108303"},
        {"Smithsonian Astrophysical Observation", "SAO 145761"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.11777476),
        dec: Angle.Degrees(-07.56637569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214247"},
        {"Hipparcos Number", "HIP 111647"},
        {"Geneva Identification System", "GEN# +1.00214247"},
        {"Smithsonian Astrophysical Observation", "SAO 146201"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.25341745),
        dec: Angle.Degrees(-07.56611610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25731"},
        {"Smithsonian Astrophysical Observation", "SAO 132177"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.42319084),
        dec: Angle.Degrees(-07.56587763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162598"},
        {"Hipparcos Number", "HIP 87464"},
        {"Geneva Identification System", "GEN# +1.00162598"},
        {"Smithsonian Astrophysical Observation", "SAO 141917"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.06975219),
        dec: Angle.Degrees(-07.56126476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 353.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69966"},
        {"Hipparcos Number", "HIP 40763"},
        {"Smithsonian Astrophysical Observation", "SAO 135772"},
        {"Wilson Evans Batten Catalogue", "WEB 7913"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.80990968),
        dec: Angle.Degrees(-07.55818177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34326"},
        {"Geneva Identification System", "GEN# -0.00701742"},
        {"Wilson Evans Batten Catalogue", "WEB 6874"},
    },
    visualMagnitude: 7.86,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.73531276),
        dec: Angle.Degrees(-07.55735295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119183"},
        {"Hipparcos Number", "HIP 66831"},
        {"Geneva Identification System", "GEN# +1.00119183"},
        {"Smithsonian Astrophysical Observation", "SAO 139493"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.45005032),
        dec: Angle.Degrees(-07.55633708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79285"},
        {"Hipparcos Number", "HIP 45228"},
        {"Smithsonian Astrophysical Observation", "SAO 136670"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.26032883),
        dec: Angle.Degrees(-07.55502278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28407"},
        {"Hipparcos Number", "HIP 20882"},
        {"Smithsonian Astrophysical Observation", "SAO 131236"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.13038631),
        dec: Angle.Degrees(-07.55268164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59380"},
        {"Hipparcos Number", "HIP 36399"},
        {"Geneva Identification System", "GEN# +1.00059380"},
        {"Smithsonian Astrophysical Observation", "SAO 134742"},
        {"Wilson Evans Batten Catalogue", "WEB 7245"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.35670842),
        dec: Angle.Degrees(-07.55147431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220476"},
        {"Hipparcos Number", "HIP 115527"},
        {"Geneva Identification System", "GEN# +1.00220476"},
        {"Smithsonian Astrophysical Observation", "SAO 146686"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.02605135),
        dec: Angle.Degrees(-07.55074634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205868"},
        {"Hipparcos Number", "HIP 106842"},
        {"Smithsonian Astrophysical Observation", "SAO 145551"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.60857158),
        dec: Angle.Degrees(-07.54844636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210277"},
        {"Hipparcos Number", "HIP 109378"},
        {"Cincinnati Publication", "Ci 20 1339"},
        {"Geneva Identification System", "GEN# +1.00210277"},
        {"Smithsonian Astrophysical Observation", "SAO 145906"},
        {"Wilson Evans Batten Catalogue", "WEB 19653"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.37423100),
        dec: Angle.Degrees(-07.54756077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -449.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334"},
        {"Hipparcos Number", "HIP 649"},
        {"Geneva Identification System", "GEN# +1.00000334"},
        {"Smithsonian Astrophysical Observation", "SAO 128600"},
        {"Wilson Evans Batten Catalogue", "WEB 109"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00105125),
        dec: Angle.Degrees(-07.54477340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134552"},
        {"Hipparcos Number", "HIP 74267"},
        {"Smithsonian Astrophysical Observation", "SAO 140365"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.67226431),
        dec: Angle.Degrees(-07.54474587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71751"},
        {"Hipparcos Number", "HIP 41595"},
        {"Smithsonian Astrophysical Observation", "SAO 135964"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.20678649),
        dec: Angle.Degrees(-07.54437299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14636"},
        {"Hipparcos Number", "HIP 10994"},
        {"Geneva Identification System", "GEN# +1.00014636"},
        {"Smithsonian Astrophysical Observation", "SAO 129850"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.42016759),
        dec: Angle.Degrees(-07.54321952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70652"},
        {"Hipparcos Number", "HIP 41080"},
        {"Geneva Identification System", "GEN# +1.00070652"},
        {"Smithsonian Astrophysical Observation", "SAO 135840"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.72542177),
        dec: Angle.Degrees(-07.54313579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219677"},
        {"Hipparcos Number", "HIP 115025"},
        {"Smithsonian Astrophysical Observation", "SAO 146619"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.44808455),
        dec: Angle.Degrees(-07.54269675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125184"},
        {"Hipparcos Number", "HIP 69881"},
        {"Geneva Identification System", "GEN# +1.00125184"},
        {"Smithsonian Astrophysical Observation", "SAO 139856"},
        {"Wilson Evans Batten Catalogue", "WEB 12156"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.50237262),
        dec: Angle.Degrees(-07.54181672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148833"},
        {"Hipparcos Number", "HIP 80891"},
        {"Geneva Identification System", "GEN# +1.00148833"},
        {"Smithsonian Astrophysical Observation", "SAO 141218"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.77296096),
        dec: Angle.Degrees(-07.54086746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11983"},
        {"Hipparcos Number", "HIP 9118"},
        {"Geneva Identification System", "GEN# +1.00011983"},
        {"Smithsonian Astrophysical Observation", "SAO 129581"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.38297982),
        dec: Angle.Degrees(-07.53603803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4156"},
        {"Hipparcos Number", "HIP 3441"},
        {"Geneva Identification System", "GEN# +1.00004156"},
        {"Smithsonian Astrophysical Observation", "SAO 128923"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.98805866),
        dec: Angle.Degrees(-07.53320949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82925"},
        {"Hipparcos Number", "HIP 47011"},
        {"Smithsonian Astrophysical Observation", "SAO 136972"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.71281885),
        dec: Angle.Degrees(-07.53246682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106719"},
        {"Hipparcos Number", "HIP 59848"},
        {"Smithsonian Astrophysical Observation", "SAO 138687"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.09021422),
        dec: Angle.Degrees(-07.53188412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32148"},
        {"Hipparcos Number", "HIP 23305"},
        {"Geneva Identification System", "GEN# +1.00032148"},
        {"Smithsonian Astrophysical Observation", "SAO 131687"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.18247333),
        dec: Angle.Degrees(-07.53164203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153458"},
        {"Hipparcos Number", "HIP 83181"},
        {"Geneva Identification System", "GEN# +1.00153458"},
        {"Smithsonian Astrophysical Observation", "SAO 141474"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.00666961),
        dec: Angle.Degrees(-07.53161019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192505"},
        {"Hipparcos Number", "HIP 99849"},
        {"Fundamental Katalog 5th Edition", "FK5 5784"},
        {"Smithsonian Astrophysical Observation", "SAO 144221"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.86825346),
        dec: Angle.Degrees(-07.53138167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16488"},
        {"Hipparcos Number", "HIP 12316"},
        {"Fundamental Katalog 5th Edition", "FK5 4243"},
        {"Geneva Identification System", "GEN# +1.00016488"},
        {"Smithsonian Astrophysical Observation", "SAO 130030"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65028858),
        dec: Angle.Degrees(-07.53014978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62883"},
        {"Hipparcos Number", "HIP 37879"},
        {"Geneva Identification System", "GEN# +1.00062883"},
        {"Smithsonian Astrophysical Observation", "SAO 135076"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46225633),
        dec: Angle.Degrees(-07.52955411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41470"},
        {"Hipparcos Number", "HIP 28821"},
        {"Geneva Identification System", "GEN# +1.00041470"},
        {"Smithsonian Astrophysical Observation", "SAO 132810"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26163508),
        dec: Angle.Degrees(-07.52874480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56495"},
        {"Hipparcos Number", "HIP 35244"},
        {"Geneva Identification System", "GEN# +1.00056495"},
        {"Renson", "Renson 15430"},
        {"Smithsonian Astrophysical Observation", "SAO 134454"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.24063929),
        dec: Angle.Degrees(-07.52743498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24079"},
        {"Hipparcos Number", "HIP 17913"},
        {"Smithsonian Astrophysical Observation", "SAO 130757"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.46165226),
        dec: Angle.Degrees(-07.52318097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203363"},
        {"Hipparcos Number", "HIP 105486"},
        {"Smithsonian Astrophysical Observation", "SAO 145332"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.48297772),
        dec: Angle.Degrees(-07.52096877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55831"},
        {"Hipparcos Number", "HIP 34985"},
        {"Celescope Catalog", "CEL 1690"},
        {"Geneva Identification System", "GEN# +1.00055831"},
        {"Smithsonian Astrophysical Observation", "SAO 134396"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.57850770),
        dec: Angle.Degrees(-07.51920147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39291"},
        {"Hipparcos Number", "HIP 27658"},
        {"Celescope Catalog", "CEL 1006"},
        {"Fundamental Katalog 5th Edition", "FK5 2442"},
        {"Geneva Identification System", "GEN# +1.00039291"},
        {"Smithsonian Astrophysical Observation", "SAO 132591"},
        {"Wilson Evans Batten Catalogue", "WEB 5431"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.84159736),
        dec: Angle.Degrees(-07.51800251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99377"},
        {"Hipparcos Number", "HIP 55804"},
        {"Smithsonian Astrophysical Observation", "SAO 138205"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.51716981),
        dec: Angle.Degrees(-07.51699298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128985"},
        {"Hipparcos Number", "HIP 71720"},
        {"Smithsonian Astrophysical Observation", "SAO 140061"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.05407424),
        dec: Angle.Degrees(-07.51509441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148743"},
        {"Hipparcos Number", "HIP 80840"},
        {"Geneva Identification System", "GEN# +1.00148743"},
        {"Smithsonian Astrophysical Observation", "SAO 141206"},
        {"Wilson Evans Batten Catalogue", "WEB 13671"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.62506733),
        dec: Angle.Degrees(-07.51445768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150017"},
        {"Hipparcos Number", "HIP 81572"},
        {"Geneva Identification System", "GEN# +1.00150017"},
        {"Smithsonian Astrophysical Observation", "SAO 141297"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.89673776),
        dec: Angle.Degrees(-07.51230271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185720"},
        {"Hipparcos Number", "HIP 96813"},
        {"Geneva Identification System", "GEN# +1.00185720"},
        {"Smithsonian Astrophysical Observation", "SAO 143674"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18783833),
        dec: Angle.Degrees(-07.51220178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14065"},
        {"Smithsonian Astrophysical Observation", "SAO 130244"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.31129618),
        dec: Angle.Degrees(-07.51217485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5070 A"},
        {"Henry Draper", "HD 45380"},
        {"Hipparcos Number", "HIP 30675"},
        {"Celescope Catalog", "CEL 1241"},
        {"Geneva Identification System", "GEN# +1.00045380A"},
        {"Smithsonian Astrophysical Observation", "SAO 133263"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.68687170),
        dec: Angle.Degrees(-07.51190723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208161"},
        {"Hipparcos Number", "HIP 108138"},
        {"Smithsonian Astrophysical Observation", "SAO 145734"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.63205410),
        dec: Angle.Degrees(-07.51045322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135841"},
        {"Hipparcos Number", "HIP 74828"},
        {"Geneva Identification System", "GEN# +1.00135841"},
        {"Smithsonian Astrophysical Observation", "SAO 140434"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.38631794),
        dec: Angle.Degrees(-07.50935396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46380"},
        {"Hipparcos Number", "HIP 31199"},
        {"Geneva Identification System", "GEN# +1.00046380"},
        {"Smithsonian Astrophysical Observation", "SAO 133389"},
        {"Wilson Evans Batten Catalogue", "WEB 6233"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.18013415),
        dec: Angle.Degrees(-07.50897469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41662"},
        {"Hipparcos Number", "HIP 28918"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.56189729),
        dec: Angle.Degrees(-07.50662655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65607"},
        {"Hipparcos Number", "HIP 39042"},
        {"Geneva Identification System", "GEN# +1.00065607"},
        {"Smithsonian Astrophysical Observation", "SAO 135333"},
        {"Wilson Evans Batten Catalogue", "WEB 7657"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.81823456),
        dec: Angle.Degrees(-07.50496700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89378"},
        {"Hipparcos Number", "HIP 50490"},
        {"Smithsonian Astrophysical Observation", "SAO 137481"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.65274058),
        dec: Angle.Degrees(-07.50222448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141994"},
        {"Hipparcos Number", "HIP 77734"},
        {"Geneva Identification System", "GEN# +1.00141994"},
        {"Smithsonian Astrophysical Observation", "SAO 140808"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06123941),
        dec: Angle.Degrees(-07.50089308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110418"},
        {"Hipparcos Number", "HIP 61969"},
        {"Geneva Identification System", "GEN# +1.00110418"},
        {"Smithsonian Astrophysical Observation", "SAO 138920"},
        {"Wilson Evans Batten Catalogue", "WEB 11020"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.49033010),
        dec: Angle.Degrees(-07.50018780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168856"},
        {"Hipparcos Number", "HIP 90030"},
        {"Geneva Identification System", "GEN# +1.00168856"},
        {"Renson", "Renson 47330"},
        {"Smithsonian Astrophysical Observation", "SAO 142250"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.54510501),
        dec: Angle.Degrees(-07.49873964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20874"},
        {"Hipparcos Number", "HIP 15659"},
        {"Smithsonian Astrophysical Observation", "SAO 130438"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.41712657),
        dec: Angle.Degrees(-07.49866011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82426"},
        {"Hipparcos Number", "HIP 46758"},
        {"Geneva Identification System", "GEN# +1.00082426"},
        {"Smithsonian Astrophysical Observation", "SAO 136930"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.94807684),
        dec: Angle.Degrees(-07.49611014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12157 AB"},
        {"Henry Draper", "HD 179427"},
        {"Hipparcos Number", "HIP 94404"},
        {"Smithsonian Astrophysical Observation", "SAO 143137"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.20970950),
        dec: Angle.Degrees(-07.49398059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85929"},
        {"Smithsonian Astrophysical Observation", "SAO 141731"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.40230720),
        dec: Angle.Degrees(-07.48902203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62153"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.07971451),
        dec: Angle.Degrees(-07.48378621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22630"},
        {"Hipparcos Number", "HIP 16960"},
        {"Geneva Identification System", "GEN# +1.00022630"},
        {"Smithsonian Astrophysical Observation", "SAO 130620"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.54331675),
        dec: Angle.Degrees(-07.48338221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115944"},
        {"Hipparcos Number", "HIP 65107"},
        {"Smithsonian Astrophysical Observation", "SAO 139287"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.14520180),
        dec: Angle.Degrees(-07.48321098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93864"},
        {"Hipparcos Number", "HIP 52968"},
        {"Smithsonian Astrophysical Observation", "SAO 137819"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.49417945),
        dec: Angle.Degrees(-07.48232020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38110"},
        {"Hipparcos Number", "HIP 26935"},
        {"Geneva Identification System", "GEN# +1.00038110"},
        {"Smithsonian Astrophysical Observation", "SAO 132479"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74500626),
        dec: Angle.Degrees(-07.48092249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34992"},
        {"Hipparcos Number", "HIP 25006"},
        {"Smithsonian Astrophysical Observation", "SAO 132020"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.31130782),
        dec: Angle.Degrees(-07.47994117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10653"},
        {"Hipparcos Number", "HIP 8092"},
        {"Geneva Identification System", "GEN# +1.00010653"},
        {"Smithsonian Astrophysical Observation", "SAO 129476"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.96915222),
        dec: Angle.Degrees(-07.47925241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142400"},
        {"Hipparcos Number", "HIP 77906"},
        {"Geneva Identification System", "GEN# +1.00142400"},
        {"Smithsonian Astrophysical Observation", "SAO 140833"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.65565674),
        dec: Angle.Degrees(-07.47732192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194846"},
        {"Hipparcos Number", "HIP 100959"},
        {"Geneva Identification System", "GEN# +1.00194846"},
        {"Smithsonian Astrophysical Observation", "SAO 144461"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.04172738),
        dec: Angle.Degrees(-07.47723997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135326"},
        {"Hipparcos Number", "HIP 74613"},
        {"Smithsonian Astrophysical Observation", "SAO 140405"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.67662274),
        dec: Angle.Degrees(-07.47374882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163176"},
        {"Hipparcos Number", "HIP 87727"},
        {"Smithsonian Astrophysical Observation", "SAO 141958"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.79066635),
        dec: Angle.Degrees(-07.47203641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142213"},
        {"Hipparcos Number", "HIP 77833"},
        {"Geneva Identification System", "GEN# +1.00142213"},
        {"Smithsonian Astrophysical Observation", "SAO 140823"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.38823513),
        dec: Angle.Degrees(-07.46974510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40744"},
        {"Hipparcos Number", "HIP 28459"},
        {"Smithsonian Astrophysical Observation", "SAO 132740"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.13000979),
        dec: Angle.Degrees(-07.46967029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190172"},
        {"Hipparcos Number", "HIP 98809"},
        {"Geneva Identification System", "GEN# +1.00190172"},
        {"Smithsonian Astrophysical Observation", "SAO 144038"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00497184),
        dec: Angle.Degrees(-07.46937856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124954"},
        {"Hipparcos Number", "HIP 69758"},
        {"Renson", "Renson 35721"},
        {"Smithsonian Astrophysical Observation", "SAO 139831"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.15088964),
        dec: Angle.Degrees(-07.46677158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39957"},
        {"Hipparcos Number", "HIP 28024"},
        {"Smithsonian Astrophysical Observation", "SAO 132657"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90892390),
        dec: Angle.Degrees(-07.46583089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221835"},
        {"Hipparcos Number", "HIP 116428"},
        {"Fundamental Katalog 5th Edition", "FK5 888"},
        {"Geneva Identification System", "GEN# +1.00221835"},
        {"Smithsonian Astrophysical Observation", "SAO 146795"},
        {"Wilson Evans Batten Catalogue", "WEB 20569"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.88363333),
        dec: Angle.Degrees(-07.46447114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80083"},
        {"Hipparcos Number", "HIP 45596"},
        {"Smithsonian Astrophysical Observation", "SAO 136737"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.40018876),
        dec: Angle.Degrees(-07.46289496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184573"},
        {"Hipparcos Number", "HIP 96356"},
        {"Geneva Identification System", "GEN# +1.00184573"},
        {"Smithsonian Astrophysical Observation", "SAO 143564"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.87413266),
        dec: Angle.Degrees(-07.46018539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216125"},
        {"Hipparcos Number", "HIP 112769"},
        {"Smithsonian Astrophysical Observation", "SAO 146340"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.55928548),
        dec: Angle.Degrees(-07.45981478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141026"},
        {"Hipparcos Number", "HIP 77313"},
        {"Geneva Identification System", "GEN# +1.00141026"},
        {"Smithsonian Astrophysical Observation", "SAO 140754"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.76392066),
        dec: Angle.Degrees(-07.45967738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12496"},
        {"Hipparcos Number", "HIP 9516"},
        {"Smithsonian Astrophysical Observation", "SAO 129643"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.59706609),
        dec: Angle.Degrees(-07.45813330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191986"},
        {"Hipparcos Number", "HIP 99611"},
        {"Geneva Identification System", "GEN# +1.00191986"},
        {"Smithsonian Astrophysical Observation", "SAO 144174"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.22702459),
        dec: Angle.Degrees(-07.45810458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14338"},
        {"Hipparcos Number", "HIP 10783"},
        {"Geneva Identification System", "GEN# +1.00014338"},
        {"Smithsonian Astrophysical Observation", "SAO 129819"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.71543979),
        dec: Angle.Degrees(-07.45802508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151864"},
        {"Hipparcos Number", "HIP 82406"},
        {"Smithsonian Astrophysical Observation", "SAO 141391"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.59620337),
        dec: Angle.Degrees(-07.45731944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42913"},
        {"Hipparcos Number", "HIP 29521"},
        {"Smithsonian Astrophysical Observation", "SAO 132976"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.28986497),
        dec: Angle.Degrees(-07.45616198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152392"},
        {"Hipparcos Number", "HIP 82626"},
        {"Geneva Identification System", "GEN# +1.00152392"},
        {"Smithsonian Astrophysical Observation", "SAO 141419"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35968043),
        dec: Angle.Degrees(-07.45588192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177374"},
        {"Hipparcos Number", "HIP 93690"},
        {"Smithsonian Astrophysical Observation", "SAO 142990"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.18797456),
        dec: Angle.Degrees(-07.45549975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195562"},
        {"Hipparcos Number", "HIP 101343"},
        {"Smithsonian Astrophysical Observation", "SAO 144541"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09453644),
        dec: Angle.Degrees(-07.45301891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61175"},
        {"Hipparcos Number", "HIP 37129"},
        {"Smithsonian Astrophysical Observation", "SAO 134914"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.43830108),
        dec: Angle.Degrees(-07.45297665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30380"},
        {"Geneva Identification System", "GEN# -0.00701402"},
        {"Wilson Evans Batten Catalogue", "WEB 6041"},
    },
    visualMagnitude: 9.76,
    bvColour: 2.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.82669014),
        dec: Angle.Degrees(-07.45133898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9922"},
        {"Hipparcos Number", "HIP 7518"},
        {"Smithsonian Astrophysical Observation", "SAO 129401"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20452638),
        dec: Angle.Degrees(-07.45107433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10236"},
        {"Hipparcos Number", "HIP 7772"},
        {"Smithsonian Astrophysical Observation", "SAO 129434"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.00721614),
        dec: Angle.Degrees(-07.44883711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109569"},
        {"Hipparcos Number", "HIP 61467"},
        {"Geneva Identification System", "GEN# +1.00109569"},
        {"Smithsonian Astrophysical Observation", "SAO 138865"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.93716842),
        dec: Angle.Degrees(-07.44686866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145426"},
        {"Hipparcos Number", "HIP 79313"},
        {"Smithsonian Astrophysical Observation", "SAO 141017"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.80150571),
        dec: Angle.Degrees(-07.44678455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66393"},
        {"Hipparcos Number", "HIP 39381"},
        {"Smithsonian Astrophysical Observation", "SAO 135421"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.76817405),
        dec: Angle.Degrees(-07.44488739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192718"},
        {"Hipparcos Number", "HIP 99938"},
        {"Geneva Identification System", "GEN# +1.00192718"},
        {"Smithsonian Astrophysical Observation", "SAO 144233"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.15791467),
        dec: Angle.Degrees(-07.44352984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 313.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25801"},
        {"Hipparcos Number", "HIP 19065"},
        {"Fundamental Katalog 5th Edition", "FK5 4369"},
        {"Smithsonian Astrophysical Observation", "SAO 130936"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.29075757),
        dec: Angle.Degrees(-07.43858047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178287"},
        {"Hipparcos Number", "HIP 94004"},
        {"Geneva Identification System", "GEN# +1.00178287"},
        {"Smithsonian Astrophysical Observation", "SAO 143063"},
        {"Wilson Evans Batten Catalogue", "WEB 16362"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08654560),
        dec: Angle.Degrees(-07.43773608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117732"},
        {"Hipparcos Number", "HIP 66039"},
        {"Geneva Identification System", "GEN# +1.00117732"},
        {"Smithsonian Astrophysical Observation", "SAO 139395"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.08485990),
        dec: Angle.Degrees(-07.43713847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215751"},
        {"Hipparcos Number", "HIP 112514"},
        {"Smithsonian Astrophysical Observation", "SAO 146309"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.86118384),
        dec: Angle.Degrees(-07.43498331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36285"},
        {"Hipparcos Number", "HIP 25786"},
        {"Celescope Catalog", "CEL 741"},
        {"Geneva Identification System", "GEN# +1.00036285"},
        {"Smithsonian Astrophysical Observation", "SAO 132192"},
        {"Wilson Evans Batten Catalogue", "WEB 5009"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.58647080),
        dec: Angle.Degrees(-07.43481174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22129"},
        {"Hipparcos Number", "HIP 16601"},
        {"Geneva Identification System", "GEN# +1.00022129"},
        {"Smithsonian Astrophysical Observation", "SAO 130574"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.42025968),
        dec: Angle.Degrees(-07.42902203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188025"},
        {"Hipparcos Number", "HIP 97885"},
        {"Smithsonian Astrophysical Observation", "SAO 143887"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.36295185),
        dec: Angle.Degrees(-07.42877208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12126 AB"},
        {"Henry Draper", "HD 179002"},
        {"Hipparcos Number", "HIP 94241"},
        {"Geneva Identification System", "GEN# +1.00179002J"},
        {"Smithsonian Astrophysical Observation", "SAO 143106"},
        {"Wilson Evans Batten Catalogue", "WEB 16415"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75526250),
        dec: Angle.Degrees(-07.42742450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119480"},
        {"Hipparcos Number", "HIP 66972"},
        {"Smithsonian Astrophysical Observation", "SAO 139508"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.89688031),
        dec: Angle.Degrees(-07.42710119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27388"},
        {"Hipparcos Number", "HIP 20137"},
        {"Smithsonian Astrophysical Observation", "SAO 131108"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.76127683),
        dec: Angle.Degrees(-07.42320726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78786"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.26429770),
        dec: Angle.Degrees(-07.41506889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22128"},
        {"Hipparcos Number", "HIP 16596"},
        {"Geneva Identification System", "GEN# +1.00022128"},
        {"Renson", "Renson 5560"},
        {"Smithsonian Astrophysical Observation", "SAO 130572"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.40800177),
        dec: Angle.Degrees(-07.41502504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42355"},
        {"Hipparcos Number", "HIP 29240"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.48128431),
        dec: Angle.Degrees(-07.41359446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223348"},
        {"Hipparcos Number", "HIP 117446"},
        {"Smithsonian Astrophysical Observation", "SAO 146925"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.20570130),
        dec: Angle.Degrees(-07.41295399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49741"},
        {"Hipparcos Number", "HIP 32724"},
        {"Smithsonian Astrophysical Observation", "SAO 133729"},
        {"Wilson Evans Batten Catalogue", "WEB 6591"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39895945),
        dec: Angle.Degrees(-07.41237889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21955",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3402 AB"},
        {"Henry Draper", "HD 29972"},
        {"Hipparcos Number", "HIP 21955"},
        {"Smithsonian Astrophysical Observation", "SAO 131433"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.77994038),
        dec: Angle.Degrees(-07.41168981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5326"},
        {"Smithsonian Astrophysical Observation", "SAO 129138"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.03933829),
        dec: Angle.Degrees(-07.41163688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76681"},
        {"Hipparcos Number", "HIP 43994"},
        {"Smithsonian Astrophysical Observation", "SAO 136441"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.38094162),
        dec: Angle.Degrees(-07.41062813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107251",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bosona"},
        {"Henry Draper", "HD 206610"},
        {"Hipparcos Number", "HIP 107251"},
        {"Fundamental Katalog 5th Edition", "FK5 5916"},
        {"Smithsonian Astrophysical Observation", "SAO 145619"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.85374453),
        dec: Angle.Degrees(-07.40825822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161203"},
        {"Hipparcos Number", "HIP 86833"},
        {"Geneva Identification System", "GEN# +1.00161203"},
        {"Smithsonian Astrophysical Observation", "SAO 141845"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.14490139),
        dec: Angle.Degrees(-07.40810129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46283"},
        {"Hipparcos Number", "HIP 31152"},
        {"Geneva Identification System", "GEN# +1.00046283"},
        {"Renson", "Renson 12380"},
        {"Smithsonian Astrophysical Observation", "SAO 133381"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.06317001),
        dec: Angle.Degrees(-07.40803955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14907"},
        {"Hipparcos Number", "HIP 11191"},
        {"Geneva Identification System", "GEN# +1.00014907"},
        {"Smithsonian Astrophysical Observation", "SAO 129873"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.03953977),
        dec: Angle.Degrees(-07.40554752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104201"},
        {"Smithsonian Astrophysical Observation", "SAO 145102"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.66546069),
        dec: Angle.Degrees(-07.40486355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188806"},
        {"Hipparcos Number", "HIP 98187"},
        {"Smithsonian Astrophysical Observation", "SAO 143939"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.29860031),
        dec: Angle.Degrees(-07.40469095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207774"},
        {"Hipparcos Number", "HIP 107885"},
        {"Smithsonian Astrophysical Observation", "SAO 145707"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.88994580),
        dec: Angle.Degrees(-07.40397042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221080"},
        {"Hipparcos Number", "HIP 115901"},
        {"Geneva Identification System", "GEN# +1.00221080"},
        {"Smithsonian Astrophysical Observation", "SAO 146726"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.23659510),
        dec: Angle.Degrees(-07.40203519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182038"},
        {"Hipparcos Number", "HIP 95281"},
        {"Geneva Identification System", "GEN# +1.00182038"},
        {"Smithsonian Astrophysical Observation", "SAO 143340"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76850134),
        dec: Angle.Degrees(-07.40056318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178099"},
        {"Hipparcos Number", "HIP 93936"},
        {"Smithsonian Astrophysical Observation", "SAO 143045"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.90802968),
        dec: Angle.Degrees(-07.39930232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37151"},
        {"Hipparcos Number", "HIP 26304"},
        {"Celescope Catalog", "CEL 853"},
        {"Geneva Identification System", "GEN# +1.00037151"},
        {"Renson", "Renson 9930"},
        {"Smithsonian Astrophysical Observation", "SAO 132347"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.02598217),
        dec: Angle.Degrees(-07.39649054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50775"},
        {"Hipparcos Number", "HIP 33180"},
        {"Smithsonian Astrophysical Observation", "SAO 133875"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.58927312),
        dec: Angle.Degrees(-07.39616548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29553"},
        {"Hipparcos Number", "HIP 21647"},
        {"Smithsonian Astrophysical Observation", "SAO 131381"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72922179),
        dec: Angle.Degrees(-07.39474556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7730"},
        {"Smithsonian Astrophysical Observation", "SAO 129430"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.88436959),
        dec: Angle.Degrees(-07.39454028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19987"},
        {"Smithsonian Astrophysical Observation", "SAO 131091"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.30608327),
        dec: Angle.Degrees(-07.39425403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10359"},
        {"Smithsonian Astrophysical Observation", "SAO 129757"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.37822273),
        dec: Angle.Degrees(-07.39372143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88774"},
        {"Smithsonian Astrophysical Observation", "SAO 142099"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83837196),
        dec: Angle.Degrees(-07.39366304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15093 AB"},
        {"Henry Draper", "HD 205318"},
        {"Hipparcos Number", "HIP 106539"},
        {"Smithsonian Astrophysical Observation", "SAO 145501"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.66363128),
        dec: Angle.Degrees(-07.39223678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22675"},
        {"Hipparcos Number", "HIP 16989"},
        {"Geneva Identification System", "GEN# +1.00022675"},
        {"Smithsonian Astrophysical Observation", "SAO 130628"},
        {"Wilson Evans Batten Catalogue", "WEB 3230"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.62189268),
        dec: Angle.Degrees(-07.39170945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36867"},
        {"Hipparcos Number", "HIP 26139"},
        {"Geneva Identification System", "GEN# +1.00036867"},
        {"Smithsonian Astrophysical Observation", "SAO 132280"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60246782),
        dec: Angle.Degrees(-07.38943365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216526"},
        {"Hipparcos Number", "HIP 113059"},
        {"Smithsonian Astrophysical Observation", "SAO 146376"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.44402483),
        dec: Angle.Degrees(-07.38935896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97037"},
        {"Hipparcos Number", "HIP 54582"},
        {"Geneva Identification System", "GEN# +1.00097037"},
        {"Smithsonian Astrophysical Observation", "SAO 138023"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.55618831),
        dec: Angle.Degrees(-07.38898414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176414"},
        {"Hipparcos Number", "HIP 93324"},
        {"Geneva Identification System", "GEN# +1.00176414"},
        {"Smithsonian Astrophysical Observation", "SAO 142903"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.12377448),
        dec: Angle.Degrees(-07.38555989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88697"},
        {"Hipparcos Number", "HIP 50100"},
        {"Geneva Identification System", "GEN# +1.00088697"},
        {"Smithsonian Astrophysical Observation", "SAO 137424"},
        {"Wilson Evans Batten Catalogue", "WEB 9210"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.43538141),
        dec: Angle.Degrees(-07.38409519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103378"},
        {"Hipparcos Number", "HIP 58044"},
        {"Smithsonian Astrophysical Observation", "SAO 138470"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.55937832),
        dec: Angle.Degrees(-07.38383498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85294"},
        {"Hipparcos Number", "HIP 48286"},
        {"Geneva Identification System", "GEN# +1.00085294"},
        {"Smithsonian Astrophysical Observation", "SAO 137179"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.67116083),
        dec: Angle.Degrees(-07.38208296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39835"},
        {"Hipparcos Number", "HIP 27940"},
        {"Smithsonian Astrophysical Observation", "SAO 132639"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.68585013),
        dec: Angle.Degrees(-07.37812042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212717"},
        {"Hipparcos Number", "HIP 110780"},
        {"Geneva Identification System", "GEN# +1.00212717"},
        {"Smithsonian Astrophysical Observation", "SAO 146087"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.64438500),
        dec: Angle.Degrees(-07.37746071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38756"},
        {"Hipparcos Number", "HIP 27363"},
        {"Geneva Identification System", "GEN# +1.00038756"},
        {"Smithsonian Astrophysical Observation", "SAO 132538"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.92803284),
        dec: Angle.Degrees(-07.37711519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39439"},
        {"Hipparcos Number", "HIP 27741"},
        {"Celescope Catalog", "CEL 1014"},
        {"Geneva Identification System", "GEN# +1.00039439"},
        {"Smithsonian Astrophysical Observation", "SAO 132606"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.08802081),
        dec: Angle.Degrees(-07.37644740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 681"},
        {"Hipparcos Number", "HIP 904"},
        {"Smithsonian Astrophysical Observation", "SAO 128627"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.78769565),
        dec: Angle.Degrees(-07.37619874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55830"},
        {"Hipparcos Number", "HIP 34990"},
        {"Celescope Catalog", "CEL 1691"},
        {"Geneva Identification System", "GEN# +1.00055830"},
        {"Smithsonian Astrophysical Observation", "SAO 134397"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.58786894),
        dec: Angle.Degrees(-07.37612807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102826"},
        {"Hipparcos Number", "HIP 57730"},
        {"Geneva Identification System", "GEN# +1.00102826"},
        {"Smithsonian Astrophysical Observation", "SAO 138435"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57789657),
        dec: Angle.Degrees(-07.37593403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22242"},
        {"Hipparcos Number", "HIP 16686"},
        {"Smithsonian Astrophysical Observation", "SAO 130585"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.66389316),
        dec: Angle.Degrees(-07.37575120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224419"},
        {"Hipparcos Number", "HIP 118132"},
        {"Geneva Identification System", "GEN# +1.00224419"},
        {"Smithsonian Astrophysical Observation", "SAO 146999"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44147776),
        dec: Angle.Degrees(-07.37515118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9691"},
        {"Hipparcos Number", "HIP 7350"},
        {"Smithsonian Astrophysical Observation", "SAO 129385"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.69096662),
        dec: Angle.Degrees(-07.37501187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11675"},
        {"Hipparcos Number", "HIP 8891"},
        {"Smithsonian Astrophysical Observation", "SAO 129559"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.61252266),
        dec: Angle.Degrees(-07.37484914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46873"},
        {"Hipparcos Number", "HIP 31461"},
        {"Smithsonian Astrophysical Observation", "SAO 133444"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.85730786),
        dec: Angle.Degrees(-07.37475224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37103"},
        {"Hipparcos Number", "HIP 26274"},
        {"Smithsonian Astrophysical Observation", "SAO 132339"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.92195420),
        dec: Angle.Degrees(-07.37431526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57959"},
        {"Geneva Identification System", "GEN# +9.85673042"},
    },
    visualMagnitude: 11.89,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.31745565),
        dec: Angle.Degrees(-07.37311375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -512.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210878"},
        {"Hipparcos Number", "HIP 109722"},
        {"Smithsonian Astrophysical Observation", "SAO 145949"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.38831015),
        dec: Angle.Degrees(-07.37216559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207382"},
        {"Hipparcos Number", "HIP 107672"},
        {"Smithsonian Astrophysical Observation", "SAO 145682"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.16749738),
        dec: Angle.Degrees(-07.37029654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46488"},
        {"Cincinnati Publication", "Ci 20 528"},
        {"Geneva Identification System", "GEN# +9.80161033"},
    },
    visualMagnitude: 12.10,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.22259268),
        dec: Angle.Degrees(-07.36932122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -711.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10025 AB"},
        {"Henry Draper", "HD 147533"},
        {"Hipparcos Number", "HIP 80234"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.70897970),
        dec: Angle.Degrees(-07.36626287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11508"},
        {"Geneva Identification System", "GEN# -0.00800456"},
        {"Smithsonian Astrophysical Observation", "SAO 129926"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.09646782),
        dec: Angle.Degrees(-07.36498423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189605"},
        {"Hipparcos Number", "HIP 98542"},
        {"Wilson Evans Batten Catalogue", "WEB 17407"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.27160917),
        dec: Angle.Degrees(-07.36440300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45855"},
        {"Hipparcos Number", "HIP 30935"},
        {"Smithsonian Astrophysical Observation", "SAO 133334"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.38930597),
        dec: Angle.Degrees(-07.36263423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146173"},
        {"Hipparcos Number", "HIP 79645"},
        {"Geneva Identification System", "GEN# +1.00146173"},
        {"Smithsonian Astrophysical Observation", "SAO 141062"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.79485491),
        dec: Angle.Degrees(-07.36156258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45284"},
        {"Hipparcos Number", "HIP 30633"},
        {"Celescope Catalog", "CEL 1236"},
        {"Geneva Identification System", "GEN# +1.00045284"},
        {"Smithsonian Astrophysical Observation", "SAO 133252"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.55489782),
        dec: Angle.Degrees(-07.36144012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102661"},
        {"Hipparcos Number", "HIP 57641"},
        {"Smithsonian Astrophysical Observation", "SAO 138424"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.29498036),
        dec: Angle.Degrees(-07.36062810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172275"},
        {"Hipparcos Number", "HIP 91502"},
        {"Geneva Identification System", "GEN# +1.00172275"},
        {"Smithsonian Astrophysical Observation", "SAO 142475"},
        {"Wilson Evans Batten Catalogue", "WEB 15728"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.91522796),
        dec: Angle.Degrees(-07.35423013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224336"},
        {"Hipparcos Number", "HIP 118064"},
        {"Geneva Identification System", "GEN# +1.00224336"},
        {"Smithsonian Astrophysical Observation", "SAO 146990"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25588082),
        dec: Angle.Degrees(-07.35420849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34736"},
        {"Hipparcos Number", "HIP 24828"},
        {"Celescope Catalog", "CEL 615"},
        {"Geneva Identification System", "GEN# +1.00034736"},
        {"Renson", "Renson 8860"},
        {"Smithsonian Astrophysical Observation", "SAO 131980"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.83846301),
        dec: Angle.Degrees(-07.34723729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5384"},
        {"Hipparcos Number", "HIP 4346"},
        {"Fundamental Katalog 5th Edition", "FK5 2058"},
        {"Geneva Identification System", "GEN# +1.00005384"},
        {"Smithsonian Astrophysical Observation", "SAO 129032"},
        {"Wilson Evans Batten Catalogue", "WEB 778"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.92668443),
        dec: Angle.Degrees(-07.34703997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24472"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.78286215),
        dec: Angle.Degrees(-07.34575425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -431.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176077"},
        {"Hipparcos Number", "HIP 93189"},
        {"Geneva Identification System", "GEN# +1.00176077"},
        {"Smithsonian Astrophysical Observation", "SAO 142867"},
        {"Wilson Evans Batten Catalogue", "WEB 16152"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.72104618),
        dec: Angle.Degrees(-07.34466216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8885"},
        {"Hipparcos Number", "HIP 6798"},
        {"Smithsonian Astrophysical Observation", "SAO 129310"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.86986184),
        dec: Angle.Degrees(-07.34452801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122788"},
        {"Hipparcos Number", "HIP 68721"},
        {"Smithsonian Astrophysical Observation", "SAO 139707"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02009732),
        dec: Angle.Degrees(-07.34415083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214078"},
        {"Hipparcos Number", "HIP 111545"},
        {"Geneva Identification System", "GEN# +1.00214078"},
        {"Smithsonian Astrophysical Observation", "SAO 146184"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.96697577),
        dec: Angle.Degrees(-07.33954301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48979"},
        {"Hipparcos Number", "HIP 32407"},
        {"Geneva Identification System", "GEN# +1.00048979"},
        {"Smithsonian Astrophysical Observation", "SAO 133651"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49064569),
        dec: Angle.Degrees(-07.33894870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172768"},
        {"Hipparcos Number", "HIP 91728"},
        {"Smithsonian Astrophysical Observation", "SAO 142518"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.57453939),
        dec: Angle.Degrees(-07.33732102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222799"},
        {"Hipparcos Number", "HIP 117052"},
        {"Smithsonian Astrophysical Observation", "SAO 146869"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.92799880),
        dec: Angle.Degrees(-07.33669885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171918"},
        {"Hipparcos Number", "HIP 91332"},
        {"Geneva Identification System", "GEN# +1.00171918"},
        {"Smithsonian Astrophysical Observation", "SAO 142443"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.42734957),
        dec: Angle.Degrees(-07.33651722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69225"},
        {"Hipparcos Number", "HIP 40468"},
        {"Smithsonian Astrophysical Observation", "SAO 135695"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.95140551),
        dec: Angle.Degrees(-07.33644502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108264"},
        {"Hipparcos Number", "HIP 60690"},
        {"Geneva Identification System", "GEN# +1.00108264"},
        {"Smithsonian Astrophysical Observation", "SAO 138778"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.57957686),
        dec: Angle.Degrees(-07.33009677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3806 AB"},
        {"Hipparcos Number", "HIP 24353"},
        {"Smithsonian Astrophysical Observation", "SAO 131886"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38651664),
        dec: Angle.Degrees(-07.32985016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202887"},
        {"Hipparcos Number", "HIP 105235"},
        {"Geneva Identification System", "GEN# +1.00202887"},
        {"Smithsonian Astrophysical Observation", "SAO 145289"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.74836287),
        dec: Angle.Degrees(-07.32956534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15245"},
        {"Smithsonian Astrophysical Observation", "SAO 130393"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.15188957),
        dec: Angle.Degrees(-07.32753799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126553"},
        {"Hipparcos Number", "HIP 70588"},
        {"Smithsonian Astrophysical Observation", "SAO 139929"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58750191),
        dec: Angle.Degrees(-07.32751220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175122"},
        {"Hipparcos Number", "HIP 92766"},
        {"Smithsonian Astrophysical Observation", "SAO 142774"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55339689),
        dec: Angle.Degrees(-07.32519924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43542"},
        {"Hipparcos Number", "HIP 29806"},
        {"Renson", "Renson 11566"},
        {"Smithsonian Astrophysical Observation", "SAO 133052"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.13432825),
        dec: Angle.Degrees(-07.32415434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73196"},
        {"Hipparcos Number", "HIP 42252"},
        {"Smithsonian Astrophysical Observation", "SAO 136088"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.22497228),
        dec: Angle.Degrees(-07.32262995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200315"},
        {"Hipparcos Number", "HIP 103881"},
        {"Geneva Identification System", "GEN# +1.00200315"},
        {"Smithsonian Astrophysical Observation", "SAO 145049"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.73894126),
        dec: Angle.Degrees(-07.32152836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146931"},
        {"Hipparcos Number", "HIP 79942"},
        {"Geneva Identification System", "GEN# +1.00146931"},
        {"Smithsonian Astrophysical Observation", "SAO 141094"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.77528957),
        dec: Angle.Degrees(-07.31936195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84941"},
        {"Hipparcos Number", "HIP 48109"},
        {"Smithsonian Astrophysical Observation", "SAO 137149"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14021203),
        dec: Angle.Degrees(-07.31846150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158039"},
        {"Hipparcos Number", "HIP 85408"},
        {"Geneva Identification System", "GEN# +1.00158039"},
        {"Smithsonian Astrophysical Observation", "SAO 141669"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80007814),
        dec: Angle.Degrees(-07.31660221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88372"},
        {"Hipparcos Number", "HIP 49900"},
        {"Fundamental Katalog 5th Edition", "FK5 2818"},
        {"Geneva Identification System", "GEN# +1.00088372"},
        {"Smithsonian Astrophysical Observation", "SAO 137400"},
        {"Wilson Evans Batten Catalogue", "WEB 9185"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.82398897),
        dec: Angle.Degrees(-07.31659367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184612"},
        {"Hipparcos Number", "HIP 96368"},
        {"Geneva Identification System", "GEN# +1.00184612"},
        {"Smithsonian Astrophysical Observation", "SAO 143565"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.89808810),
        dec: Angle.Degrees(-07.31624023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218576"},
        {"Hipparcos Number", "HIP 114323"},
        {"Smithsonian Astrophysical Observation", "SAO 146534"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.29787940),
        dec: Angle.Degrees(-07.31390686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211706"},
        {"Hipparcos Number", "HIP 110187"},
        {"Geneva Identification System", "GEN# +1.00211706"},
        {"Smithsonian Astrophysical Observation", "SAO 146014"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.78179118),
        dec: Angle.Degrees(-07.31325129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120386"},
        {"Hipparcos Number", "HIP 67433"},
        {"Smithsonian Astrophysical Observation", "SAO 139572"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.30564493),
        dec: Angle.Degrees(-07.31319629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216182"},
        {"Hipparcos Number", "HIP 112813"},
        {"Smithsonian Astrophysical Observation", "SAO 146347"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69298521),
        dec: Angle.Degrees(-07.31189044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53854"},
        {"Hipparcos Number", "HIP 34279"},
        {"Geneva Identification System", "GEN# +1.00053854"},
        {"Renson", "Renson 14790"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.59242038),
        dec: Angle.Degrees(-07.31150273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121629"},
        {"Hipparcos Number", "HIP 68116"},
        {"Geneva Identification System", "GEN# +1.00121629"},
        {"Smithsonian Astrophysical Observation", "SAO 139641"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.18823945),
        dec: Angle.Degrees(-07.31100879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4462 A"},
        {"Henry Draper", "HD 39376"},
        {"Hipparcos Number", "HIP 27703"},
        {"Celescope Catalog", "CEL 1010"},
        {"Geneva Identification System", "GEN# +1.00039376"},
        {"Smithsonian Astrophysical Observation", "SAO 132599"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.98837780),
        dec: Angle.Degrees(-07.31008342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114095"},
        {"Hipparcos Number", "HIP 64115"},
        {"Geneva Identification System", "GEN# +1.00114095"},
        {"Smithsonian Astrophysical Observation", "SAO 139171"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.10799209),
        dec: Angle.Degrees(-07.30865959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14848"},
        {"Smithsonian Astrophysical Observation", "SAO 130337"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.93807921),
        dec: Angle.Degrees(-07.30743637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136712"},
        {"Hipparcos Number", "HIP 75237"},
        {"Smithsonian Astrophysical Observation", "SAO 140490"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.61091795),
        dec: Angle.Degrees(-07.30678050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132361"},
        {"Hipparcos Number", "HIP 73312"},
        {"Smithsonian Astrophysical Observation", "SAO 140255"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.72595531),
        dec: Angle.Degrees(-07.30657644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1147"},
        {"Hipparcos Number", "HIP 1252"},
        {"Smithsonian Astrophysical Observation", "SAO 128666"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.92542027),
        dec: Angle.Degrees(-07.30639265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143259"},
        {"Hipparcos Number", "HIP 78333"},
        {"Geneva Identification System", "GEN# +1.00143259"},
        {"Smithsonian Astrophysical Observation", "SAO 140882"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.92208421),
        dec: Angle.Degrees(-07.30203381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36512"},
        {"Hipparcos Number", "HIP 25923"},
        {"Celescope Catalog", "CEL 767"},
        {"Geneva Identification System", "GEN# +1.00036512"},
        {"Smithsonian Astrophysical Observation", "SAO 132222"},
        {"Wilson Evans Batten Catalogue", "WEB 5037"},
    },
    visualMagnitude: 4.62,
    bvColour: -0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.98275119),
        dec: Angle.Degrees(-07.30152625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139803"},
        {"Hipparcos Number", "HIP 76772"},
        {"Geneva Identification System", "GEN# +1.00139803"},
        {"Smithsonian Astrophysical Observation", "SAO 140689"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.12509808),
        dec: Angle.Degrees(-07.30115422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107780"},
        {"Hipparcos Number", "HIP 60407"},
        {"Fundamental Katalog 5th Edition", "FK5 5093"},
        {"Smithsonian Astrophysical Observation", "SAO 138747"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.78980583),
        dec: Angle.Degrees(-07.29913295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99708"},
        {"Hipparcos Number", "HIP 55969"},
        {"Smithsonian Astrophysical Observation", "SAO 138222"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.04132759),
        dec: Angle.Degrees(-07.29819217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11165 A"},
        {"Henry Draper", "HD 166761"},
        {"Hipparcos Number", "HIP 89216"},
        {"Geneva Identification System", "GEN# +1.00166761"},
        {"Smithsonian Astrophysical Observation", "SAO 142150"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.10015584),
        dec: Angle.Degrees(-07.29685659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47092"},
        {"Hipparcos Number", "HIP 31587"},
        {"Smithsonian Astrophysical Observation", "SAO 133473"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.15386165),
        dec: Angle.Degrees(-07.29584457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32485"},
        {"Hipparcos Number", "HIP 23505"},
        {"Smithsonian Astrophysical Observation", "SAO 131725"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.81158777),
        dec: Angle.Degrees(-07.29438607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204617"},
        {"Hipparcos Number", "HIP 106146"},
        {"Smithsonian Astrophysical Observation", "SAO 145438"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.50627302),
        dec: Angle.Degrees(-07.29354352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131670"},
        {"Hipparcos Number", "HIP 73007"},
        {"Geneva Identification System", "GEN# +1.00131670"},
        {"Smithsonian Astrophysical Observation", "SAO 140221"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.80756068),
        dec: Angle.Degrees(-07.29287599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130344"},
        {"Hipparcos Number", "HIP 72356"},
        {"Smithsonian Astrophysical Observation", "SAO 140144"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93541544),
        dec: Angle.Degrees(-07.29286831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38184"},
        {"Hipparcos Number", "HIP 26987"},
        {"Celescope Catalog", "CEL 947"},
        {"Geneva Identification System", "GEN# +1.00038184"},
        {"Smithsonian Astrophysical Observation", "SAO 132486"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.88936845),
        dec: Angle.Degrees(-07.29227500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61813"},
        {"Hipparcos Number", "HIP 37413"},
        {"Geneva Identification System", "GEN# +1.00061813"},
        {"Smithsonian Astrophysical Observation", "SAO 134975"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21659858),
        dec: Angle.Degrees(-07.29193909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40232"},
        {"Hipparcos Number", "HIP 28178"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.30855301),
        dec: Angle.Degrees(-07.28901872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24752"},
        {"Hipparcos Number", "HIP 18391"},
        {"Smithsonian Astrophysical Observation", "SAO 130826"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.97751957),
        dec: Angle.Degrees(-07.28740363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90652"},
        {"Smithsonian Astrophysical Observation", "SAO 142349"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.46213475),
        dec: Angle.Degrees(-07.28738443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8323"},
        {"Hipparcos Number", "HIP 6419"},
        {"Geneva Identification System", "GEN# +1.00008323"},
        {"Smithsonian Astrophysical Observation", "SAO 129260"},
    },
    visualMagnitude: 9.53,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.60369176),
        dec: Angle.Degrees(-07.28689940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88751"},
        {"Hipparcos Number", "HIP 50138"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.53261707),
        dec: Angle.Degrees(-07.28669231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167832"},
        {"Hipparcos Number", "HIP 89619"},
        {"Smithsonian Astrophysical Observation", "SAO 142193"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.34400185),
        dec: Angle.Degrees(-07.28637681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91495"},
        {"Smithsonian Astrophysical Observation", "SAO 142474"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.89687695),
        dec: Angle.Degrees(-07.28560456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60138"},
        {"Hipparcos Number", "HIP 36688"},
        {"Smithsonian Astrophysical Observation", "SAO 134824"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.20694024),
        dec: Angle.Degrees(-07.28488731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42551"},
        {"Hipparcos Number", "HIP 29327"},
        {"Geneva Identification System", "GEN# +1.00042551"},
        {"Smithsonian Astrophysical Observation", "SAO 132926"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.75921403),
        dec: Angle.Degrees(-07.28424698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24428"},
        {"Celescope Catalog", "CEL 578"},
        {"Smithsonian Astrophysical Observation", "SAO 131906"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.62187094),
        dec: Angle.Degrees(-07.28282091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99764"},
        {"Geneva Identification System", "GEN# -0.00705223"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.61743702),
        dec: Angle.Degrees(-07.28132198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116020"},
        {"Smithsonian Astrophysical Observation", "SAO 146745"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.62372452),
        dec: Angle.Degrees(-07.27850942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178746"},
        {"Hipparcos Number", "HIP 94163"},
        {"Smithsonian Astrophysical Observation", "SAO 143088"},
        {"Wilson Evans Batten Catalogue", "WEB 16404"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.51238480),
        dec: Angle.Degrees(-07.27765516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122993"},
        {"Hipparcos Number", "HIP 68806"},
        {"Smithsonian Astrophysical Observation", "SAO 139726"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.30238265),
        dec: Angle.Degrees(-07.27653007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62465"},
        {"Hipparcos Number", "HIP 37682"},
        {"Smithsonian Astrophysical Observation", "SAO 135039"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.96576122),
        dec: Angle.Degrees(-07.27531180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172656"},
        {"Hipparcos Number", "HIP 91676"},
        {"Smithsonian Astrophysical Observation", "SAO 142510"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.42564387),
        dec: Angle.Degrees(-07.27107953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109219"},
        {"Hipparcos Number", "HIP 61256"},
        {"Smithsonian Astrophysical Observation", "SAO 138841"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.29989560),
        dec: Angle.Degrees(-07.26797141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218475"},
        {"Hipparcos Number", "HIP 114257"},
        {"Geneva Identification System", "GEN# +1.00218475"},
        {"Smithsonian Astrophysical Observation", "SAO 146524"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.09554846),
        dec: Angle.Degrees(-07.26699368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70845"},
        {"Hipparcos Number", "HIP 41167"},
        {"Geneva Identification System", "GEN# +1.00070845"},
        {"Smithsonian Astrophysical Observation", "SAO 135865"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.99236347),
        dec: Angle.Degrees(-07.26426115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36151"},
        {"Hipparcos Number", "HIP 25712"},
        {"Celescope Catalog", "CEL 735"},
        {"Geneva Identification System", "GEN# +1.00036151A"},
        {"Smithsonian Astrophysical Observation", "SAO 132172"},
        {"Wilson Evans Batten Catalogue", "WEB 4991"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35585642),
        dec: Angle.Degrees(-07.26088199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97492"},
        {"Hipparcos Number", "HIP 54791"},
        {"Smithsonian Astrophysical Observation", "SAO 138067"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.25668756),
        dec: Angle.Degrees(-07.26022217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8477 AB"},
        {"Henry Draper", "HD 106515"},
        {"Hipparcos Number", "HIP 59743"},
        {"Geneva Identification System", "GEN# +1.00106515"},
        {"Wilson Evans Batten Catalogue", "WEB 10615"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.77797345),
        dec: Angle.Degrees(-07.25719352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78157"},
        {"Hipparcos Number", "HIP 44701"},
        {"Geneva Identification System", "GEN# +1.00078157"},
        {"Smithsonian Astrophysical Observation", "SAO 136583"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63368237),
        dec: Angle.Degrees(-07.25455445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10404"},
        {"Smithsonian Astrophysical Observation", "SAO 129768"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.51590341),
        dec: Angle.Degrees(-07.25403612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30086",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4949 AB"},
        {"Henry Draper", "HD 44140"},
        {"Hipparcos Number", "HIP 30086"},
        {"Smithsonian Astrophysical Observation", "SAO 133119"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.97957558),
        dec: Angle.Degrees(-07.25062973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43066"},
        {"Hipparcos Number", "HIP 29579"},
        {"Geneva Identification System", "GEN# +1.00043066"},
        {"Smithsonian Astrophysical Observation", "SAO 132997"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.48794708),
        dec: Angle.Degrees(-07.24808216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14487"},
        {"Smithsonian Astrophysical Observation", "SAO 130293"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.75299595),
        dec: Angle.Degrees(-07.24686899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84882"},
        {"Hipparcos Number", "HIP 48087"},
        {"Renson", "Renson 24204"},
        {"Smithsonian Astrophysical Observation", "SAO 137142"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.05296991),
        dec: Angle.Degrees(-07.24570725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28652"},
        {"Hipparcos Number", "HIP 21050"},
        {"Smithsonian Astrophysical Observation", "SAO 131261"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.68797228),
        dec: Angle.Degrees(-07.24105576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210253"},
        {"Hipparcos Number", "HIP 109356"},
        {"Smithsonian Astrophysical Observation", "SAO 145903"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.31636558),
        dec: Angle.Degrees(-07.24105386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5299"},
        {"Hipparcos Number", "HIP 4276"},
        {"Smithsonian Astrophysical Observation", "SAO 129021"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.68082595),
        dec: Angle.Degrees(-07.23829137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131335"},
        {"Hipparcos Number", "HIP 72829"},
        {"Smithsonian Astrophysical Observation", "SAO 140199"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.29821545),
        dec: Angle.Degrees(-07.23750059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189852"},
        {"Hipparcos Number", "HIP 98663"},
        {"Smithsonian Astrophysical Observation", "SAO 144012"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.59721156),
        dec: Angle.Degrees(-07.23485803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74395"},
        {"Hipparcos Number", "HIP 42835"},
        {"Geneva Identification System", "GEN# +1.00074395"},
        {"Smithsonian Astrophysical Observation", "SAO 136221"},
        {"Wilson Evans Batten Catalogue", "WEB 8277"},
    },
    visualMagnitude: 4.63,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.91825129),
        dec: Angle.Degrees(-07.23372781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72585"},
        {"Hipparcos Number", "HIP 41989"},
        {"Smithsonian Astrophysical Observation", "SAO 136037"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.38105598),
        dec: Angle.Degrees(-07.23334804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195996"},
        {"Hipparcos Number", "HIP 101553"},
        {"Smithsonian Astrophysical Observation", "SAO 144585"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.69762243),
        dec: Angle.Degrees(-07.23241259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3821"},
        {"Hipparcos Number", "HIP 3203"},
        {"Geneva Identification System", "GEN# +1.00003821J"},
        {"Smithsonian Astrophysical Observation", "SAO 128892"},
        {"Wilson Evans Batten Catalogue", "WEB 574"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19784263),
        dec: Angle.Degrees(-07.23238377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13309"},
        {"Smithsonian Astrophysical Observation", "SAO 130144"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.81695454),
        dec: Angle.Degrees(-07.23141812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13002"},
        {"Hipparcos Number", "HIP 9889"},
        {"Geneva Identification System", "GEN# +1.00013002"},
        {"Smithsonian Astrophysical Observation", "SAO 129704"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.80268656),
        dec: Angle.Degrees(-07.22555304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54832"},
        {"Hipparcos Number", "HIP 34606"},
        {"Geneva Identification System", "GEN# +1.00054832"},
        {"Renson", "Renson 14980"},
        {"Smithsonian Astrophysical Observation", "SAO 134280"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.52722071),
        dec: Angle.Degrees(-07.22400967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1539"},
        {"Hipparcos Number", "HIP 1573"},
        {"Geneva Identification System", "GEN# +1.00001539"},
        {"Smithsonian Astrophysical Observation", "SAO 128696"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.90192752),
        dec: Angle.Degrees(-07.22367560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101632"},
        {"Hipparcos Number", "HIP 57046"},
        {"Geneva Identification System", "GEN# +1.00101632"},
        {"Smithsonian Astrophysical Observation", "SAO 138351"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43149641),
        dec: Angle.Degrees(-07.22132250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71538"},
        {"Hipparcos Number", "HIP 41495"},
        {"Smithsonian Astrophysical Observation", "SAO 135941"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.94175082),
        dec: Angle.Degrees(-07.22035929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181887"},
        {"Hipparcos Number", "HIP 95228"},
        {"Smithsonian Astrophysical Observation", "SAO 143323"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.62056376),
        dec: Angle.Degrees(-07.21880218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167788"},
        {"Hipparcos Number", "HIP 89606"},
        {"Smithsonian Astrophysical Observation", "SAO 142190"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.29025610),
        dec: Angle.Degrees(-07.21838289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87359"},
        {"Hipparcos Number", "HIP 49350"},
        {"Geneva Identification System", "GEN# +1.00087359"},
        {"Smithsonian Astrophysical Observation", "SAO 137336"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.11127719),
        dec: Angle.Degrees(-07.21787576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34862"},
        {"Hipparcos Number", "HIP 24900"},
        {"Smithsonian Astrophysical Observation", "SAO 131997"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.05299893),
        dec: Angle.Degrees(-07.21691862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191675"},
        {"Hipparcos Number", "HIP 99482"},
        {"Geneva Identification System", "GEN# +1.00191675"},
        {"Smithsonian Astrophysical Observation", "SAO 144147"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.84825950),
        dec: Angle.Degrees(-07.21533369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51666"},
        {"Smithsonian Astrophysical Observation", "SAO 137635"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.32098270),
        dec: Angle.Degrees(-07.21517205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215144"},
        {"Hipparcos Number", "HIP 112178"},
        {"Geneva Identification System", "GEN# +1.00215144"},
        {"Smithsonian Astrophysical Observation", "SAO 146272"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.80382520),
        dec: Angle.Degrees(-07.21505491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37507"},
        {"Hipparcos Number", "HIP 26563"},
        {"Celescope Catalog", "CEL 895"},
        {"Geneva Identification System", "GEN# +1.00037507"},
        {"Smithsonian Astrophysical Observation", "SAO 132411"},
        {"Wilson Evans Batten Catalogue", "WEB 5235"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.72121589),
        dec: Angle.Degrees(-07.21270844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127687"},
        {"Hipparcos Number", "HIP 71130"},
        {"Smithsonian Astrophysical Observation", "SAO 139991"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.20562316),
        dec: Angle.Degrees(-07.21168988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147575"},
        {"Hipparcos Number", "HIP 80248"},
        {"Smithsonian Astrophysical Observation", "SAO 141133"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.74777173),
        dec: Angle.Degrees(-07.20895079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216637"},
        {"Hipparcos Number", "HIP 113127"},
        {"Geneva Identification System", "GEN# +1.00216637"},
        {"Smithsonian Astrophysical Observation", "SAO 146382"},
        {"Wilson Evans Batten Catalogue", "WEB 20134"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.64221027),
        dec: Angle.Degrees(-07.20454057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68586"},
        {"Hipparcos Number", "HIP 40221"},
        {"Cincinnati Publication", "Ci 18 970"},
        {"Geneva Identification System", "GEN# +1.00068586"},
        {"Smithsonian Astrophysical Observation", "SAO 135634"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.21638100),
        dec: Angle.Degrees(-07.20439595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57564"},
        {"Hipparcos Number", "HIP 35663"},
        {"Smithsonian Astrophysical Observation", "SAO 134569"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.38319651),
        dec: Angle.Degrees(-07.20393493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46541"},
        {"Hipparcos Number", "HIP 31285"},
        {"Smithsonian Astrophysical Observation", "SAO 133408"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.42117217),
        dec: Angle.Degrees(-07.20347884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11470"},
        {"Smithsonian Astrophysical Observation", "SAO 129922"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.99365145),
        dec: Angle.Degrees(-07.20339613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34370"},
        {"Hipparcos Number", "HIP 24599"},
        {"Geneva Identification System", "GEN# +1.00034370"},
        {"Smithsonian Astrophysical Observation", "SAO 131936"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.15026454),
        dec: Angle.Degrees(-07.20314124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155990"},
        {"Hipparcos Number", "HIP 84397"},
        {"Geneva Identification System", "GEN# +1.00155990"},
        {"Smithsonian Astrophysical Observation", "SAO 141575"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.82184902),
        dec: Angle.Degrees(-07.20167034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36920"},
        {"Hipparcos Number", "HIP 26173"},
        {"Smithsonian Astrophysical Observation", "SAO 132290"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.70001996),
        dec: Angle.Degrees(-07.20036955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6645 AB"},
        {"Henry Draper", "HD 68229"},
        {"Hipparcos Number", "HIP 40082"},
        {"Smithsonian Astrophysical Observation", "SAO 135607"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.81149816),
        dec: Angle.Degrees(-07.19915774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 984"},
        {"Hipparcos Number", "HIP 1134"},
        {"Geneva Identification System", "GEN# +1.00000984"},
        {"Smithsonian Astrophysical Observation", "SAO 128650"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.54247339),
        dec: Angle.Degrees(-07.19896207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17031"},
        {"Hipparcos Number", "HIP 12746"},
        {"Smithsonian Astrophysical Observation", "SAO 130082"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.96575491),
        dec: Angle.Degrees(-07.19879575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111528"},
        {"Hipparcos Number", "HIP 62632"},
        {"Geneva Identification System", "GEN# +1.00111528"},
        {"Smithsonian Astrophysical Observation", "SAO 138985"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.50709333),
        dec: Angle.Degrees(-07.19713385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197060"},
        {"Hipparcos Number", "HIP 102099"},
        {"Smithsonian Astrophysical Observation", "SAO 144703"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.36224466),
        dec: Angle.Degrees(-07.19600868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117833"},
        {"Hipparcos Number", "HIP 66100"},
        {"Smithsonian Astrophysical Observation", "SAO 139403"},
        {"Wilson Evans Batten Catalogue", "WEB 11682"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.25049845),
        dec: Angle.Degrees(-07.19473275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212320"},
        {"Hipparcos Number", "HIP 110532"},
        {"Geneva Identification System", "GEN# +1.00212320"},
        {"Smithsonian Astrophysical Observation", "SAO 146062"},
        {"Wilson Evans Batten Catalogue", "WEB 19811"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.88397901),
        dec: Angle.Degrees(-07.19444293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129783"},
        {"Hipparcos Number", "HIP 72079"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.17080996),
        dec: Angle.Degrees(-07.19353320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1267"},
        {"Hipparcos Number", "HIP 1350"},
        {"Smithsonian Astrophysical Observation", "SAO 128675"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.22410680),
        dec: Angle.Degrees(-07.19198605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65259"},
        {"Hipparcos Number", "HIP 38898"},
        {"Geneva Identification System", "GEN# +1.00065259"},
        {"Wilson Evans Batten Catalogue", "WEB 7621"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.40983538),
        dec: Angle.Degrees(-07.18945698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16887"},
        {"Hipparcos Number", "HIP 12627"},
        {"Smithsonian Astrophysical Observation", "SAO 130066"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.57342660),
        dec: Angle.Degrees(-07.18834458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86446"},
        {"Hipparcos Number", "HIP 48902"},
        {"Smithsonian Astrophysical Observation", "SAO 137263"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.63491724),
        dec: Angle.Degrees(-07.18568915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51845"},
        {"Hipparcos Number", "HIP 33578"},
        {"Geneva Identification System", "GEN# +1.00051845"},
        {"Smithsonian Astrophysical Observation", "SAO 133978"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65293869),
        dec: Angle.Degrees(-07.18567379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136599"},
        {"Hipparcos Number", "HIP 75180"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.45386636),
        dec: Angle.Degrees(-07.18202960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18634"},
        {"Hipparcos Number", "HIP 13944"},
        {"Smithsonian Astrophysical Observation", "SAO 130227"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.90162170),
        dec: Angle.Degrees(-07.17984857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5443"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.41214932),
        dec: Angle.Degrees(-07.17945503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199086"},
        {"Hipparcos Number", "HIP 103250"},
        {"Geneva Identification System", "GEN# +1.00199086"},
        {"Smithsonian Astrophysical Observation", "SAO 144937"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.76405287),
        dec: Angle.Degrees(-07.17823264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20182"},
        {"Hipparcos Number", "HIP 15080"},
        {"Smithsonian Astrophysical Observation", "SAO 130373"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.61088162),
        dec: Angle.Degrees(-07.17800697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43496",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7050 AB"},
        {"Henry Draper", "HD 75737"},
        {"Hipparcos Number", "HIP 43496"},
        {"Geneva Identification System", "GEN# +1.00075737"},
        {"Renson", "Renson 21210"},
        {"Smithsonian Astrophysical Observation", "SAO 136345"},
        {"Wilson Evans Batten Catalogue", "WEB 8382"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.89349889),
        dec: Angle.Degrees(-07.17721266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32249"},
        {"Hipparcos Number", "HIP 23364"},
        {"Geneva Identification System", "GEN# +1.00032249"},
        {"Smithsonian Astrophysical Observation", "SAO 131700"},
        {"Wilson Evans Batten Catalogue", "WEB 4536"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.35977051),
        dec: Angle.Degrees(-07.17397802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213650"},
        {"Hipparcos Number", "HIP 111315"},
        {"Smithsonian Astrophysical Observation", "SAO 146149"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.26682958),
        dec: Angle.Degrees(-07.17395474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120792"},
        {"Hipparcos Number", "HIP 67658"},
        {"Geneva Identification System", "GEN# +1.00120792"},
        {"Smithsonian Astrophysical Observation", "SAO 139592"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.93367273),
        dec: Angle.Degrees(-07.17280724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71071"},
        {"Hipparcos Number", "HIP 41274"},
        {"Geneva Identification System", "GEN# +1.00071071"},
        {"Smithsonian Astrophysical Observation", "SAO 135893"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.30896120),
        dec: Angle.Degrees(-07.17021314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120604"},
        {"Hipparcos Number", "HIP 67559"},
        {"Smithsonian Astrophysical Observation", "SAO 139582"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.65450371),
        dec: Angle.Degrees(-07.16991766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126293"},
        {"Hipparcos Number", "HIP 70458"},
        {"Smithsonian Astrophysical Observation", "SAO 139919"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19210840),
        dec: Angle.Degrees(-07.16961593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15797"},
        {"Hipparcos Number", "HIP 11810"},
        {"Smithsonian Astrophysical Observation", "SAO 129962"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.07928041),
        dec: Angle.Degrees(-07.16934952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13161"},
        {"Smithsonian Astrophysical Observation", "SAO 130130"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.31032138),
        dec: Angle.Degrees(-07.16914722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32022",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5340 AB"},
        {"Henry Draper", "HD 48106"},
        {"Hipparcos Number", "HIP 32022"},
        {"Smithsonian Astrophysical Observation", "SAO 133574"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.34343599),
        dec: Angle.Degrees(-07.16871797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33288"},
        {"Hipparcos Number", "HIP 23959"},
        {"Geneva Identification System", "GEN# +1.00033288"},
        {"Smithsonian Astrophysical Observation", "SAO 131821"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.24138003),
        dec: Angle.Degrees(-07.16642137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49527"},
        {"Hipparcos Number", "HIP 32639"},
        {"Smithsonian Astrophysical Observation", "SAO 133705"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.13516014),
        dec: Angle.Degrees(-07.16534109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12862"},
        {"Hipparcos Number", "HIP 9794"},
        {"Smithsonian Astrophysical Observation", "SAO 129691"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.49263782),
        dec: Angle.Degrees(-07.16464139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72557",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9403 AB"},
        {"Henry Draper", "HD 130746"},
        {"Hipparcos Number", "HIP 72557"},
        {"Smithsonian Astrophysical Observation", "SAO 140164"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.51567963),
        dec: Angle.Degrees(-07.16455938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41950"},
        {"Hipparcos Number", "HIP 29053"},
        {"Smithsonian Astrophysical Observation", "SAO 132863"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.93470575),
        dec: Angle.Degrees(-07.16329999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128707"},
        {"Hipparcos Number", "HIP 71600"},
        {"Geneva Identification System", "GEN# +1.00128707"},
        {"Smithsonian Astrophysical Observation", "SAO 140049"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.64871413),
        dec: Angle.Degrees(-07.16267425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219592"},
        {"Hipparcos Number", "HIP 114952"},
        {"Geneva Identification System", "GEN# +1.00219592"},
        {"Smithsonian Astrophysical Observation", "SAO 146614"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.24610585),
        dec: Angle.Degrees(-07.16088877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123806"},
        {"Hipparcos Number", "HIP 69195"},
        {"Smithsonian Astrophysical Observation", "SAO 139764"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.48735072),
        dec: Angle.Degrees(-07.15997714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113717"},
        {"Hipparcos Number", "HIP 63895"},
        {"Smithsonian Astrophysical Observation", "SAO 139147"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42220654),
        dec: Angle.Degrees(-07.15939748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59128"},
        {"Hipparcos Number", "HIP 36303"},
        {"Geneva Identification System", "GEN# +1.00059128"},
        {"Smithsonian Astrophysical Observation", "SAO 134717"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.09249809),
        dec: Angle.Degrees(-07.15891396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206738"},
        {"Hipparcos Number", "HIP 107319"},
        {"Smithsonian Astrophysical Observation", "SAO 145624"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.05927517),
        dec: Angle.Degrees(-07.15807967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72055"},
        {"Hipparcos Number", "HIP 41732"},
        {"Geneva Identification System", "GEN# +1.00072055"},
        {"Renson", "Renson 19900"},
        {"Smithsonian Astrophysical Observation", "SAO 135989"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64532451),
        dec: Angle.Degrees(-07.15756884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135505"},
        {"Hipparcos Number", "HIP 74671"},
        {"Geneva Identification System", "GEN# +1.00135505"},
        {"Smithsonian Astrophysical Observation", "SAO 140417"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.89843539),
        dec: Angle.Degrees(-07.15687834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201917"},
        {"Hipparcos Number", "HIP 104720"},
        {"Geneva Identification System", "GEN# +1.00201917"},
        {"Smithsonian Astrophysical Observation", "SAO 145205"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.19780669),
        dec: Angle.Degrees(-07.15647617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138357"},
        {"Hipparcos Number", "HIP 76049"},
        {"Smithsonian Astrophysical Observation", "SAO 140584"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.96341790),
        dec: Angle.Degrees(-07.15314973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149976"},
        {"Hipparcos Number", "HIP 81471"},
        {"Smithsonian Astrophysical Observation", "SAO 141288"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.60627930),
        dec: Angle.Degrees(-07.15296195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221823"},
        {"Hipparcos Number", "HIP 116426"},
        {"Smithsonian Astrophysical Observation", "SAO 146794"},
    },
    visualMagnitude: 8.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.87931442),
        dec: Angle.Degrees(-07.15176483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62018"},
        {"Hipparcos Number", "HIP 37493"},
        {"Geneva Identification System", "GEN# +1.00062018"},
        {"Smithsonian Astrophysical Observation", "SAO 134995"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.43815731),
        dec: Angle.Degrees(-07.15090863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5888 AB"},
        {"Henry Draper", "HD 55489"},
        {"Hipparcos Number", "HIP 34862"},
        {"Smithsonian Astrophysical Observation", "SAO 134360"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20573412),
        dec: Angle.Degrees(-07.14937957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7651"},
        {"Hipparcos Number", "HIP 5933"},
        {"Smithsonian Astrophysical Observation", "SAO 129202"},
        {"Wilson Evans Batten Catalogue", "WEB 1350"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.07058100),
        dec: Angle.Degrees(-07.14891397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211390"},
        {"Hipparcos Number", "HIP 110002"},
        {"Smithsonian Astrophysical Observation", "SAO 145990"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.20146319),
        dec: Angle.Degrees(-07.14862973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93722"},
    },
    visualMagnitude: 10.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24857024),
        dec: Angle.Degrees(-07.14766829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99041"},
        {"Hipparcos Number", "HIP 55635"},
        {"Geneva Identification System", "GEN# +1.00099041"},
        {"Smithsonian Astrophysical Observation", "SAO 138181"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.96428325),
        dec: Angle.Degrees(-07.14762822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177444"},
        {"Hipparcos Number", "HIP 93724"},
        {"Geneva Identification System", "GEN# +1.00177444"},
        {"Smithsonian Astrophysical Observation", "SAO 142994"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.25052629),
        dec: Angle.Degrees(-07.14188722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112588"},
        {"Hipparcos Number", "HIP 63270"},
        {"Smithsonian Astrophysical Observation", "SAO 139067"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.47913535),
        dec: Angle.Degrees(-07.14094652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122657"},
        {"Hipparcos Number", "HIP 68661"},
        {"Geneva Identification System", "GEN# +1.00122657"},
        {"Smithsonian Astrophysical Observation", "SAO 139700"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.81819842),
        dec: Angle.Degrees(-07.13973024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15396"},
        {"Geneva Identification System", "GEN# +6.10220570"},
        {"Renson", "Renson 5137"},
        {"Wilson Evans Batten Catalogue", "WEB 2960"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.62007274),
        dec: Angle.Degrees(-07.13958029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98018"},
        {"Hipparcos Number", "HIP 55062"},
        {"Smithsonian Astrophysical Observation", "SAO 138098"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.08134624),
        dec: Angle.Degrees(-07.13908338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202886"},
        {"Hipparcos Number", "HIP 105236"},
        {"Smithsonian Astrophysical Observation", "SAO 145290"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.74911448),
        dec: Angle.Degrees(-07.13887747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7198 ABC"},
        {"Henry Draper", "HD 78391"},
        {"Hipparcos Number", "HIP 44804"},
        {"Geneva Identification System", "GEN# +1.00078391"},
        {"Smithsonian Astrophysical Observation", "SAO 136596"},
        {"Wilson Evans Batten Catalogue", "WEB 8563"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.96866394),
        dec: Angle.Degrees(-07.13886903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48896"},
        {"Hipparcos Number", "HIP 32380"},
        {"Smithsonian Astrophysical Observation", "SAO 133644"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.36608197),
        dec: Angle.Degrees(-07.13618022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108851"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.76930361),
        dec: Angle.Degrees(-07.13509692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8115 AB"},
        {"Henry Draper", "HD 98088"},
        {"Hipparcos Number", "HIP 55106"},
        {"Fundamental Katalog 5th Edition", "FK5 2900"},
        {"Geneva Identification System", "GEN# +1.00098088J"},
        {"Renson", "Renson 28310"},
        {"Smithsonian Astrophysical Observation", "SAO 138106"},
        {"Wilson Evans Batten Catalogue", "WEB 9936"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.24242347),
        dec: Angle.Degrees(-07.13470764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
