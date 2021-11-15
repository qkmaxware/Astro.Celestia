using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_61() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1957"},
        {"Hipparcos Number", "HIP 1886"},
        {"Geneva Identification System", "GEN# +1.00001957"},
        {"Smithsonian Astrophysical Observation", "SAO 128737"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.95477866),
        dec: Angle.Degrees(+00.12190198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94653"},
        {"Hipparcos Number", "HIP 53419"},
        {"Geneva Identification System", "GEN# +1.00094653"},
        {"Smithsonian Astrophysical Observation", "SAO 118573"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.90854383),
        dec: Angle.Degrees(+00.12288579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179821"},
        {"Hipparcos Number", "HIP 94496"},
        {"Geneva Identification System", "GEN# +1.00179821"},
        {"Smithsonian Astrophysical Observation", "SAO 124414"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49420079),
        dec: Angle.Degrees(+00.12554637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62238"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.33816237),
        dec: Angle.Degrees(+00.12613878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9473"},
        {"Hipparcos Number", "HIP 7218"},
        {"Smithsonian Astrophysical Observation", "SAO 129361"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.24534616),
        dec: Angle.Degrees(+00.12690074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45689"},
        {"Hipparcos Number", "HIP 30874"},
        {"Geneva Identification System", "GEN# +1.00045689"},
        {"Smithsonian Astrophysical Observation", "SAO 113938"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21815993),
        dec: Angle.Degrees(+00.12796928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12573"},
        {"Hipparcos Number", "HIP 9589"},
        {"Fundamental Katalog 5th Edition", "FK5 2142"},
        {"Geneva Identification System", "GEN# +1.00012573"},
        {"Renson", "Renson 3220"},
        {"Smithsonian Astrophysical Observation", "SAO 129655"},
        {"Wilson Evans Batten Catalogue", "WEB 2015"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.79835710),
        dec: Angle.Degrees(+00.12845397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98960"},
        {"Hipparcos Number", "HIP 55595"},
        {"Geneva Identification System", "GEN# +1.00098960"},
        {"Smithsonian Astrophysical Observation", "SAO 118825"},
        {"Wilson Evans Batten Catalogue", "WEB 9991"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.82489203),
        dec: Angle.Degrees(+00.13206925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52226"},
        {"Smithsonian Astrophysical Observation", "SAO 118423"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05898209),
        dec: Angle.Degrees(+00.13249435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15897"},
        {"Hipparcos Number", "HIP 11883"},
        {"Geneva Identification System", "GEN# +1.00015897"},
        {"Smithsonian Astrophysical Observation", "SAO 129971"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31587471),
        dec: Angle.Degrees(+00.13353728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45397"},
        {"Hipparcos Number", "HIP 30709"},
        {"Smithsonian Astrophysical Observation", "SAO 113900"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.78828046),
        dec: Angle.Degrees(+00.13503804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206765"},
        {"Hipparcos Number", "HIP 107333"},
        {"Smithsonian Astrophysical Observation", "SAO 145626"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09185063),
        dec: Angle.Degrees(+00.13540988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86526"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.23914052),
        dec: Angle.Degrees(+00.13543709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143436"},
        {"Hipparcos Number", "HIP 78399"},
        {"Smithsonian Astrophysical Observation", "SAO 121307"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.07882057),
        dec: Angle.Degrees(+00.13727293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111079",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15990 A"},
        {"Henry Draper", "HD 213247"},
        {"Hipparcos Number", "HIP 111079"},
        {"Smithsonian Astrophysical Observation", "SAO 146126"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.54135164),
        dec: Angle.Degrees(+00.13832874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25128",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3963 AB"},
        {"Henry Draper", "HD 35135"},
        {"Hipparcos Number", "HIP 25128"},
        {"Smithsonian Astrophysical Observation", "SAO 112695"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.67964294),
        dec: Angle.Degrees(+00.13924191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22572"},
        {"Hipparcos Number", "HIP 16926"},
        {"Geneva Identification System", "GEN# +1.00022572"},
        {"Smithsonian Astrophysical Observation", "SAO 130614"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.45985589),
        dec: Angle.Degrees(+00.14110013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192327"},
        {"Hipparcos Number", "HIP 99748"},
        {"Fundamental Katalog 5th Edition", "FK5 5781"},
        {"Geneva Identification System", "GEN# +1.00192327"},
        {"Smithsonian Astrophysical Observation", "SAO 144202"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.58314798),
        dec: Angle.Degrees(+00.14441312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38238"},
        {"Hipparcos Number", "HIP 27059"},
        {"Geneva Identification System", "GEN# +1.00038238"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.07830680),
        dec: Angle.Degrees(+00.14456004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72648"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.79972585),
        dec: Angle.Degrees(+00.14560068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12421",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2028 AB"},
        {"Henry Draper", "HD 16619"},
        {"Hipparcos Number", "HIP 12421"},
        {"Geneva Identification System", "GEN# +1.00016619J"},
        {"Smithsonian Astrophysical Observation", "SAO 130042"},
        {"Wilson Evans Batten Catalogue", "WEB 2543"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.96553193),
        dec: Angle.Degrees(+00.14669603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93399"},
        {"Geneva Identification System", "GEN# -0.00003627"},
        {"Wilson Evans Batten Catalogue", "WEB 16201"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.33220862),
        dec: Angle.Degrees(+00.14701352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172327"},
        {"Hipparcos Number", "HIP 91505"},
        {"Geneva Identification System", "GEN# +1.00172327"},
        {"Smithsonian Astrophysical Observation", "SAO 123774"},
        {"Wilson Evans Batten Catalogue", "WEB 15729"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.91829362),
        dec: Angle.Degrees(+00.14776758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70595"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.59431322),
        dec: Angle.Degrees(+00.15122400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22161"},
        {"Hipparcos Number", "HIP 16654"},
        {"Smithsonian Astrophysical Observation", "SAO 130579"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.56693097),
        dec: Angle.Degrees(+00.15265488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39033"},
        {"Hipparcos Number", "HIP 27545"},
        {"Geneva Identification System", "GEN# +1.00039033"},
        {"Smithsonian Astrophysical Observation", "SAO 113182"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.49346833),
        dec: Angle.Degrees(+00.15332964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10955"},
        {"Hipparcos Number", "HIP 8341"},
        {"Geneva Identification System", "GEN# +1.00010955"},
        {"Smithsonian Astrophysical Observation", "SAO 129503"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.89945044),
        dec: Angle.Degrees(+00.15523992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59645"},
        {"Hipparcos Number", "HIP 36538"},
        {"Smithsonian Astrophysical Observation", "SAO 115549"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73931897),
        dec: Angle.Degrees(+00.15563416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77125"},
        {"Hipparcos Number", "HIP 44227"},
        {"Smithsonian Astrophysical Observation", "SAO 117337"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.12423642),
        dec: Angle.Degrees(+00.15700879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168890"},
        {"Hipparcos Number", "HIP 90021"},
        {"Geneva Identification System", "GEN# +1.00168890"},
        {"Smithsonian Astrophysical Observation", "SAO 123392"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.53502671),
        dec: Angle.Degrees(+00.15850208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42877"},
        {"Hipparcos Number", "HIP 29524"},
        {"Smithsonian Astrophysical Observation", "SAO 113599"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.30043147),
        dec: Angle.Degrees(+00.15885994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202751"},
        {"Hipparcos Number", "HIP 105152"},
        {"Cincinnati Publication", "Ci 20 1276"},
        {"Geneva Identification System", "GEN# +1.00202751"},
        {"Smithsonian Astrophysical Observation", "SAO 145275"},
        {"Wilson Evans Batten Catalogue", "WEB 19098"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.51125500),
        dec: Angle.Degrees(+00.16203347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 469.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1887"},
        {"Hipparcos Number", "HIP 1841"},
        {"Geneva Identification System", "GEN# +1.00001887"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.82475507),
        dec: Angle.Degrees(+00.16365915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 313.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173315"},
        {"Hipparcos Number", "HIP 91948"},
        {"Smithsonian Astrophysical Observation", "SAO 123872"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.14346176),
        dec: Angle.Degrees(+00.16372671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114992"},
        {"Hipparcos Number", "HIP 64575"},
        {"Smithsonian Astrophysical Observation", "SAO 119825"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.54423947),
        dec: Angle.Degrees(+00.16399334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290915"},
        {"Hipparcos Number", "HIP 27794"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.23082225),
        dec: Angle.Degrees(+00.16401984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60155"},
        {"Hipparcos Number", "HIP 36730"},
        {"Geneva Identification System", "GEN# +1.00060155"},
        {"Smithsonian Astrophysical Observation", "SAO 115614"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.30696866),
        dec: Angle.Degrees(+00.16430779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3278"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.44215804),
        dec: Angle.Degrees(+00.16590534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20045"},
        {"Hipparcos Number", "HIP 14999"},
        {"Geneva Identification System", "GEN# +1.00020045"},
        {"Smithsonian Astrophysical Observation", "SAO 130360"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.33949739),
        dec: Angle.Degrees(+00.17425553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60475"},
        {"Hipparcos Number", "HIP 36852"},
        {"Geneva Identification System", "GEN# +1.00060475"},
        {"Smithsonian Astrophysical Observation", "SAO 115650"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.65768725),
        dec: Angle.Degrees(+00.17438142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11186 AB"},
        {"Henry Draper", "HD 167278"},
        {"Hipparcos Number", "HIP 89393"},
        {"Geneva Identification System", "GEN# +1.00167278J"},
        {"Smithsonian Astrophysical Observation", "SAO 123283"},
        {"Wilson Evans Batten Catalogue", "WEB 15204"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.64017836),
        dec: Angle.Degrees(+00.17589029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57608"},
        {"Hipparcos Number", "HIP 35712"},
        {"Geneva Identification System", "GEN# +1.00057608"},
        {"Smithsonian Astrophysical Observation", "SAO 115335"},
        {"Wilson Evans Batten Catalogue", "WEB 7116"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.51448965),
        dec: Angle.Degrees(+00.17712559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59906"},
    },
    visualMagnitude: 10.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.31452244),
        dec: Angle.Degrees(+00.17773235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26257"},
        {"Hipparcos Number", "HIP 19386"},
        {"Geneva Identification System", "GEN# +1.00026257"},
        {"Smithsonian Astrophysical Observation", "SAO 111629"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.28763781),
        dec: Angle.Degrees(+00.17893034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221529"},
        {"Hipparcos Number", "HIP 116230"},
        {"Smithsonian Astrophysical Observation", "SAO 146767"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.23750240),
        dec: Angle.Degrees(+00.18046477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56590"},
        {"Hipparcos Number", "HIP 35309"},
        {"Smithsonian Astrophysical Observation", "SAO 115215"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.40576340),
        dec: Angle.Degrees(+00.18128042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116317"},
        {"Cincinnati Publication", "Ci 20 1433"},
        {"Geneva Identification System", "GEN# +9.80029043"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.51630754),
        dec: Angle.Degrees(+00.18168871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -997.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -936.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80567"},
        {"Hipparcos Number", "HIP 45824"},
        {"Geneva Identification System", "GEN# +1.00080567"},
        {"Smithsonian Astrophysical Observation", "SAO 117605"},
        {"Wilson Evans Batten Catalogue", "WEB 8689"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.15282478),
        dec: Angle.Degrees(+00.18175177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125609"},
        {"Hipparcos Number", "HIP 70081"},
        {"Smithsonian Astrophysical Observation", "SAO 120407"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.12059179),
        dec: Angle.Degrees(+00.18204238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101846"},
        {"Hipparcos Number", "HIP 57158"},
        {"Smithsonian Astrophysical Observation", "SAO 119012"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.83299329),
        dec: Angle.Degrees(+00.18526392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217428"},
        {"Hipparcos Number", "HIP 113610"},
        {"Fundamental Katalog 5th Edition", "FK5 3840"},
        {"Geneva Identification System", "GEN# +1.00217428"},
        {"Smithsonian Astrophysical Observation", "SAO 146443"},
        {"Wilson Evans Batten Catalogue", "WEB 20190"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15783182),
        dec: Angle.Degrees(+00.18583971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37614",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6313 ABC"},
        {"Henry Draper", "HD 62264"},
        {"Hipparcos Number", "HIP 37614"},
        {"Geneva Identification System", "GEN# +1.00062264"},
        {"Smithsonian Astrophysical Observation", "SAO 115839"},
        {"Wilson Evans Batten Catalogue", "WEB 7438"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.77257360),
        dec: Angle.Degrees(+00.18936449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14712"},
        {"Hipparcos Number", "HIP 11062"},
        {"Smithsonian Astrophysical Observation", "SAO 129860"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.59461890),
        dec: Angle.Degrees(+00.19234554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80995"},
        {"Smithsonian Astrophysical Observation", "SAO 121674"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.12607248),
        dec: Angle.Degrees(+00.19341505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105911"},
        {"Hipparcos Number", "HIP 59429"},
        {"Smithsonian Astrophysical Observation", "SAO 119259"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.85589168),
        dec: Angle.Degrees(+00.19375585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11353 APB"},
        {"Hipparcos Number", "HIP 90441"},
        {"Smithsonian Astrophysical Observation", "SAO 123497"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.80212484),
        dec: Angle.Degrees(+00.19612982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198153"},
        {"Hipparcos Number", "HIP 102688"},
        {"Geneva Identification System", "GEN# +1.00198153"},
        {"Renson", "Renson 55150"},
        {"Smithsonian Astrophysical Observation", "SAO 126226"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.11366357),
        dec: Angle.Degrees(+00.19624083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34194"},
        {"Hipparcos Number", "HIP 24516"},
        {"Geneva Identification System", "GEN# +1.00034194"},
        {"Smithsonian Astrophysical Observation", "SAO 112577"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.88120025),
        dec: Angle.Degrees(+00.19699892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74686"},
        {"Hipparcos Number", "HIP 42957"},
        {"Geneva Identification System", "GEN# +1.00074686"},
        {"Smithsonian Astrophysical Observation", "SAO 117093"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.34723316),
        dec: Angle.Degrees(+00.19776995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170115"},
        {"Hipparcos Number", "HIP 90486"},
        {"Smithsonian Astrophysical Observation", "SAO 123512"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.95774817),
        dec: Angle.Degrees(+00.19997515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83046"},
        {"Hipparcos Number", "HIP 47092"},
        {"Smithsonian Astrophysical Observation", "SAO 117796"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.95400107),
        dec: Angle.Degrees(+00.20024758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207372"},
        {"Hipparcos Number", "HIP 107655"},
        {"Geneva Identification System", "GEN# +1.00207372"},
        {"Smithsonian Astrophysical Observation", "SAO 145679"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.09514955),
        dec: Angle.Degrees(+00.20086863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35152"},
        {"Hipparcos Number", "HIP 25135"},
        {"Smithsonian Astrophysical Observation", "SAO 112696"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68978121),
        dec: Angle.Degrees(+00.20945812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100763"},
        {"Hipparcos Number", "HIP 56564"},
        {"Smithsonian Astrophysical Observation", "SAO 118936"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94695310),
        dec: Angle.Degrees(+00.20955602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141422"},
        {"Hipparcos Number", "HIP 77467"},
        {"Smithsonian Astrophysical Observation", "SAO 121201"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.24921125),
        dec: Angle.Degrees(+00.21004590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19739"},
        {"Hipparcos Number", "HIP 14758"},
        {"Geneva Identification System", "GEN# +1.00019739"},
        {"Smithsonian Astrophysical Observation", "SAO 111027"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.64977981),
        dec: Angle.Degrees(+00.21258523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167495"},
        {"Hipparcos Number", "HIP 89472"},
        {"Smithsonian Astrophysical Observation", "SAO 123298"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.88087660),
        dec: Angle.Degrees(+00.21359606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14680 AB"},
        {"Hipparcos Number", "HIP 104390"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.22003066),
        dec: Angle.Degrees(+00.21497472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109915"},
        {"Hipparcos Number", "HIP 61672"},
        {"Geneva Identification System", "GEN# +1.00109915"},
        {"Smithsonian Astrophysical Observation", "SAO 119510"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.63454302),
        dec: Angle.Degrees(+00.21734002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9318 C"},
        {"Henry Draper", "HD 128272"},
        {"Hipparcos Number", "HIP 71394"},
        {"Geneva Identification System", "GEN# +1.00128272"},
        {"Smithsonian Astrophysical Observation", "SAO 120553"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.99617526),
        dec: Angle.Degrees(+00.21972404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106335"},
        {"Cincinnati Publication", "Ci 18 2800"},
        {"Cincinnati Publication 2", "Ci 20 1289"},
        {"Geneva Identification System", "GEN# -0.00004234A"},
        {"Geneva Identification System 2", "GEN# -0.00004234S"},
        {"Wilson Evans Batten Catalogue", "WEB 19257"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.04868987),
        dec: Angle.Degrees(+00.22163403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 415.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187019"},
        {"Hipparcos Number", "HIP 97397"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.93411493),
        dec: Angle.Degrees(+00.22247977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23527"},
        {"Hipparcos Number", "HIP 17578"},
        {"Smithsonian Astrophysical Observation", "SAO 111403"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.47278192),
        dec: Angle.Degrees(+00.22268183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224785"},
        {"Hipparcos Number", "HIP 56"},
        {"Smithsonian Astrophysical Observation", "SAO 147028"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.16283175),
        dec: Angle.Degrees(+00.22293899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218907"},
        {"Hipparcos Number", "HIP 114521"},
        {"Smithsonian Astrophysical Observation", "SAO 146554"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.93920263),
        dec: Angle.Degrees(+00.22346834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13485"},
        {"Hipparcos Number", "HIP 10244"},
        {"Smithsonian Astrophysical Observation", "SAO 129742"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.93373705),
        dec: Angle.Degrees(+00.22357445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205225"},
        {"Hipparcos Number", "HIP 106477"},
        {"Smithsonian Astrophysical Observation", "SAO 126891"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.48100145),
        dec: Angle.Degrees(+00.22442374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43743"},
        {"Hipparcos Number", "HIP 29922"},
        {"Smithsonian Astrophysical Observation", "SAO 113701"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.49452916),
        dec: Angle.Degrees(+00.22476069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27251"},
        {"Hipparcos Number", "HIP 20073"},
        {"Smithsonian Astrophysical Observation", "SAO 111730"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56244053),
        dec: Angle.Degrees(+00.22737577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23887"},
        {"Hipparcos Number", "HIP 17805"},
        {"Fundamental Katalog 5th Edition", "FK5 2273"},
        {"Geneva Identification System", "GEN# +1.00023887"},
        {"Smithsonian Astrophysical Observation", "SAO 111433"},
        {"Wilson Evans Batten Catalogue", "WEB 3413"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16215134),
        dec: Angle.Degrees(+00.22787124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71189"},
        {"Hipparcos Number", "HIP 41345"},
        {"Smithsonian Astrophysical Observation", "SAO 116757"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.52950259),
        dec: Angle.Degrees(+00.23010991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215093"},
        {"Hipparcos Number", "HIP 112131"},
        {"Geneva Identification System", "GEN# +1.00215093"},
        {"Smithsonian Astrophysical Observation", "SAO 146261"},
        {"Wilson Evans Batten Catalogue", "WEB 20009"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.70490762),
        dec: Angle.Degrees(+00.23184222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9649"},
        {"Hipparcos Number", "HIP 7341"},
        {"Smithsonian Astrophysical Observation", "SAO 129380"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.64559964),
        dec: Angle.Degrees(+00.23269304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177496"},
        {"Hipparcos Number", "HIP 93714"},
        {"Smithsonian Astrophysical Observation", "SAO 124236"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.23198643),
        dec: Angle.Degrees(+00.23290308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58754"},
        {"Hipparcos Number", "HIP 36171"},
        {"Geneva Identification System", "GEN# +1.00058754"},
        {"Smithsonian Astrophysical Observation", "SAO 115457"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.75360572),
        dec: Angle.Degrees(+00.23345347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18667"},
        {"Hipparcos Number", "HIP 13989"},
        {"Smithsonian Astrophysical Observation", "SAO 110897"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.03404192),
        dec: Angle.Degrees(+00.23544254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54803"},
        {"Cincinnati Publication", "Ci 20 618"},
        {"Geneva Identification System", "GEN# +9.80010006"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.29297305),
        dec: Angle.Degrees(+00.23931283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -414.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193894"},
        {"Hipparcos Number", "HIP 100496"},
        {"Smithsonian Astrophysical Observation", "SAO 125739"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68398093),
        dec: Angle.Degrees(+00.23944722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44285"},
        {"Hipparcos Number", "HIP 30177"},
        {"Smithsonian Astrophysical Observation", "SAO 113749"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.24657297),
        dec: Angle.Degrees(+00.23960802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222697"},
        {"Hipparcos Number", "HIP 116984"},
        {"Geneva Identification System", "GEN# +1.00222697"},
        {"Smithsonian Astrophysical Observation", "SAO 146856"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.73554582),
        dec: Angle.Degrees(+00.23967737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188934"},
        {"Hipparcos Number", "HIP 98223"},
        {"Geneva Identification System", "GEN# +1.00188934"},
        {"Wilson Evans Batten Catalogue", "WEB 17326"},
    },
    visualMagnitude: 9.36,
    bvColour: 2.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.40676768),
        dec: Angle.Degrees(+00.24174596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210860"},
        {"Hipparcos Number", "HIP 109709"},
        {"Smithsonian Astrophysical Observation", "SAO 145946"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.33449105),
        dec: Angle.Degrees(+00.24230668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9318 AB"},
        {"Henry Draper", "HD 128233"},
        {"Hipparcos Number", "HIP 71377"},
        {"Geneva Identification System", "GEN# +1.00128233J"},
        {"Smithsonian Astrophysical Observation", "SAO 120550"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94804903),
        dec: Angle.Degrees(+00.24292920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71597"},
        {"Hipparcos Number", "HIP 41538"},
        {"Geneva Identification System", "GEN# +1.00071597"},
        {"Smithsonian Astrophysical Observation", "SAO 116796"},
        {"Wilson Evans Batten Catalogue", "WEB 8021"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.06067856),
        dec: Angle.Degrees(+00.24401242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21095"},
        {"Hipparcos Number", "HIP 15856"},
        {"Smithsonian Astrophysical Observation", "SAO 111167"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.06303251),
        dec: Angle.Degrees(+00.24487702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136378"},
        {"Hipparcos Number", "HIP 75069"},
        {"Geneva Identification System", "GEN# +1.00136378"},
        {"Smithsonian Astrophysical Observation", "SAO 120952"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.10854898),
        dec: Angle.Degrees(+00.24528234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183387"},
        {"Hipparcos Number", "HIP 95812"},
        {"Geneva Identification System", "GEN# +1.00183387"},
        {"Smithsonian Astrophysical Observation", "SAO 124681"},
        {"Wilson Evans Batten Catalogue", "WEB 16771"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.32508068),
        dec: Angle.Degrees(+00.24610506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174551"},
        {"Hipparcos Number", "HIP 92494"},
        {"Fundamental Katalog 5th Edition", "FK5 5657"},
        {"Smithsonian Astrophysical Observation", "SAO 123969"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.75390628),
        dec: Angle.Degrees(+00.24633102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25682"},
        {"Hipparcos Number", "HIP 19024"},
        {"Cincinnati Publication", "Ci 20 278"},
        {"Cincinnati Publication 2", "Ci 18 547"},
        {"Geneva Identification System", "GEN# +1.00025682"},
        {"Smithsonian Astrophysical Observation", "SAO 111592"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.12830821),
        dec: Angle.Degrees(+00.24643554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103084"},
        {"Hipparcos Number", "HIP 57878"},
        {"Smithsonian Astrophysical Observation", "SAO 119088"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.06411059),
        dec: Angle.Degrees(+00.24724506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184767"},
        {"Hipparcos Number", "HIP 96403"},
        {"Geneva Identification System", "GEN# +1.00184767"},
        {"Smithsonian Astrophysical Observation", "SAO 124830"},
        {"Wilson Evans Batten Catalogue", "WEB 16909"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.00414685),
        dec: Angle.Degrees(+00.24967349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135824"},
        {"Hipparcos Number", "HIP 74796"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.28903620),
        dec: Angle.Degrees(+00.25210621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4271"},
        {"Hipparcos Number", "HIP 3540"},
        {"Geneva Identification System", "GEN# +1.00004271A"},
        {"Smithsonian Astrophysical Observation", "SAO 128932"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.29502236),
        dec: Angle.Degrees(+00.25340728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154032"},
        {"Hipparcos Number", "HIP 83419"},
        {"Smithsonian Astrophysical Observation", "SAO 122037"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.76099855),
        dec: Angle.Degrees(+00.25352554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149806"},
        {"Henry Draper 2", "HD 149806A"},
        {"Hipparcos Number", "HIP 81375"},
        {"Geneva Identification System", "GEN# +1.00149806"},
        {"Smithsonian Astrophysical Observation", "SAO 121731"},
        {"Wilson Evans Batten Catalogue", "WEB 13753"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.28489217),
        dec: Angle.Degrees(+00.25415627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15633"},
        {"Hipparcos Number", "HIP 11687"},
        {"Geneva Identification System", "GEN# +1.00015633"},
        {"Renson", "Renson 3900"},
        {"Smithsonian Astrophysical Observation", "SAO 110583"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.68847239),
        dec: Angle.Degrees(+00.25587583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45317"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53852332),
        dec: Angle.Degrees(+00.25628106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289927"},
        {"Hipparcos Number", "HIP 23867"},
        {"Smithsonian Astrophysical Observation", "SAO 112444"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.94274703),
        dec: Angle.Degrees(+00.25661511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209711"},
        {"Hipparcos Number", "HIP 109044"},
        {"Geneva Identification System", "GEN# +1.00209711"},
        {"Renson", "Renson 58360"},
        {"Smithsonian Astrophysical Observation", "SAO 127279"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.34884890),
        dec: Angle.Degrees(+00.26115988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19326"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.12830398),
        dec: Angle.Degrees(+00.26141473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117215",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16978 AB"},
        {"Henry Draper", "HD 223029"},
        {"Hipparcos Number", "HIP 117215"},
        {"Geneva Identification System", "GEN# +1.00223029J"},
        {"Smithsonian Astrophysical Observation", "SAO 146891"},
        {"Wilson Evans Batten Catalogue", "WEB 20653"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50043132),
        dec: Angle.Degrees(+00.26208283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54808"},
        {"Hipparcos Number", "HIP 34629"},
        {"Smithsonian Astrophysical Observation", "SAO 115028"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.59635528),
        dec: Angle.Degrees(+00.26213099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16262"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.39963825),
        dec: Angle.Degrees(+00.26388589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50545"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.86071979),
        dec: Angle.Degrees(+00.26433081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175544"},
        {"Hipparcos Number", "HIP 92904"},
        {"Geneva Identification System", "GEN# +1.00175544"},
        {"Smithsonian Astrophysical Observation", "SAO 124055"},
        {"Wilson Evans Batten Catalogue", "WEB 16086"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94445306),
        dec: Angle.Degrees(+00.26516715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77726"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.03578611),
        dec: Angle.Degrees(+00.26766519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8615"},
        {"Hipparcos Number", "HIP 6629"},
        {"Smithsonian Astrophysical Observation", "SAO 109876"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.26457976),
        dec: Angle.Degrees(+00.26912883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213689"},
        {"Hipparcos Number", "HIP 111336"},
        {"Smithsonian Astrophysical Observation", "SAO 127597"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34604883),
        dec: Angle.Degrees(+00.26973363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69499"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42763386),
        dec: Angle.Degrees(+00.27254450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69705"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.01354779),
        dec: Angle.Degrees(+00.27295424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71884"},
        {"Hipparcos Number", "HIP 41677"},
        {"Smithsonian Astrophysical Observation", "SAO 116822"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.44862777),
        dec: Angle.Degrees(+00.27358236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188350"},
        {"Hipparcos Number", "HIP 97980"},
        {"Geneva Identification System", "GEN# +1.00188350"},
        {"Smithsonian Astrophysical Observation", "SAO 125219"},
        {"Wilson Evans Batten Catalogue", "WEB 17243"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.68655124),
        dec: Angle.Degrees(+00.27365959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98539"},
        {"Hipparcos Number", "HIP 55369"},
        {"Geneva Identification System", "GEN# +1.00098539"},
        {"Smithsonian Astrophysical Observation", "SAO 118797"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.06581565),
        dec: Angle.Degrees(+00.27412806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84817"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01998823),
        dec: Angle.Degrees(+00.27464227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42094"},
        {"Smithsonian Astrophysical Observation", "SAO 116910"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.69571453),
        dec: Angle.Degrees(+00.27769241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52044"},
        {"Hipparcos Number", "HIP 33677"},
        {"Smithsonian Astrophysical Observation", "SAO 114744"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.94629726),
        dec: Angle.Degrees(+00.27833645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12324"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.67927754),
        dec: Angle.Degrees(+00.27842153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56821"},
        {"Hipparcos Number", "HIP 35395"},
        {"Geneva Identification System", "GEN# +1.00056821"},
        {"Smithsonian Astrophysical Observation", "SAO 115237"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65041968),
        dec: Angle.Degrees(+00.27867053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80537"},
        {"Hipparcos Number", "HIP 45804"},
        {"Geneva Identification System", "GEN# +1.00080537"},
        {"Smithsonian Astrophysical Observation", "SAO 117603"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.10960954),
        dec: Angle.Degrees(+00.28385960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154659"},
        {"Hipparcos Number", "HIP 83731"},
        {"Smithsonian Astrophysical Observation", "SAO 122082"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.69734194),
        dec: Angle.Degrees(+00.28403636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21926"},
        {"Hipparcos Number", "HIP 16472"},
        {"Smithsonian Astrophysical Observation", "SAO 111243"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.03670566),
        dec: Angle.Degrees(+00.28843981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196307"},
        {"Hipparcos Number", "HIP 101674"},
        {"Geneva Identification System", "GEN# +1.00196307"},
        {"Smithsonian Astrophysical Observation", "SAO 126010"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.14084393),
        dec: Angle.Degrees(+00.28970350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21528",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3369 AB"},
        {"Henry Draper", "HD 29345"},
        {"Hipparcos Number", "HIP 21528"},
        {"Smithsonian Astrophysical Observation", "SAO 111930"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.33529631),
        dec: Angle.Degrees(+00.28984483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220406"},
        {"Hipparcos Number", "HIP 115476"},
        {"Geneva Identification System", "GEN# +1.00220406"},
        {"Smithsonian Astrophysical Observation", "SAO 128156"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.88293700),
        dec: Angle.Degrees(+00.29129760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7227 AB"},
        {"Henry Draper", "HD 79011"},
        {"Hipparcos Number", "HIP 45114"},
        {"Geneva Identification System", "GEN# +1.00079011J"},
        {"Smithsonian Astrophysical Observation", "SAO 117483"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.87188298),
        dec: Angle.Degrees(+00.29131306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197623"},
        {"Hipparcos Number", "HIP 102393"},
        {"Geneva Identification System", "GEN# +1.00197623"},
        {"Smithsonian Astrophysical Observation", "SAO 126166"},
        {"Wilson Evans Batten Catalogue", "WEB 18534"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.23764149),
        dec: Angle.Degrees(+00.29213544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113595"},
        {"Hipparcos Number", "HIP 63810"},
        {"Smithsonian Astrophysical Observation", "SAO 119756"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18563719),
        dec: Angle.Degrees(+00.29538409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142286"},
        {"Hipparcos Number", "HIP 77846"},
        {"Smithsonian Astrophysical Observation", "SAO 121241"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.41797938),
        dec: Angle.Degrees(+00.29719392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65222"},
        {"Hipparcos Number", "HIP 38905"},
        {"Geneva Identification System", "GEN# +1.00065222"},
        {"Smithsonian Astrophysical Observation", "SAO 116175"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.43692813),
        dec: Angle.Degrees(+00.29735614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7737"},
        {"Hipparcos Number", "HIP 5997"},
        {"Smithsonian Astrophysical Observation", "SAO 109782"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.27786172),
        dec: Angle.Degrees(+00.29833923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14570"},
        {"Geneva Identification System", "GEN# -0.00000496"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.03174854),
        dec: Angle.Degrees(+00.29867750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290861"},
        {"Hipparcos Number", "HIP 27309"},
        {"Geneva Identification System", "GEN# +1.00290861"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.78297087),
        dec: Angle.Degrees(+00.29895046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45416"},
        {"Hipparcos Number", "HIP 30717"},
        {"Geneva Identification System", "GEN# +1.00045416"},
        {"Smithsonian Astrophysical Observation", "SAO 113905"},
        {"Wilson Evans Batten Catalogue", "WEB 6125"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.80733207),
        dec: Angle.Degrees(+00.29926632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152115"},
        {"Hipparcos Number", "HIP 82475"},
        {"Smithsonian Astrophysical Observation", "SAO 121909"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.83995761),
        dec: Angle.Degrees(+00.29983279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208365"},
        {"Hipparcos Number", "HIP 108253"},
        {"Smithsonian Astrophysical Observation", "SAO 127163"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.96720831),
        dec: Angle.Degrees(+00.30027796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44456"},
        {"Hipparcos Number", "HIP 30257"},
        {"Geneva Identification System", "GEN# +1.00044456"},
        {"Renson", "Renson 11800"},
        {"Smithsonian Astrophysical Observation", "SAO 113772"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.48092912),
        dec: Angle.Degrees(+00.30421532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70845"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.31782182),
        dec: Angle.Degrees(+00.30482151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49385"},
        {"Henry Draper 2", "HD 49385A"},
        {"Hipparcos Number", "HIP 32608"},
        {"Geneva Identification System", "GEN# +1.00049385"},
        {"Smithsonian Astrophysical Observation", "SAO 114435"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.04807994),
        dec: Angle.Degrees(+00.30487525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67067"},
        {"Hipparcos Number", "HIP 39664"},
        {"Smithsonian Astrophysical Observation", "SAO 116348"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.58434618),
        dec: Angle.Degrees(+00.30565566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112915"},
        {"Hipparcos Number", "HIP 63446"},
        {"Smithsonian Astrophysical Observation", "SAO 119706"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.01908112),
        dec: Angle.Degrees(+00.30756932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81192"},
        {"Geneva Identification System", "GEN# +0.00003550"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.75945415),
        dec: Angle.Degrees(+00.30787864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82216"},
        {"Hipparcos Number", "HIP 46654"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.68259024),
        dec: Angle.Degrees(+00.30988299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11653"},
        {"Smithsonian Astrophysical Observation", "SAO 110578"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.57624492),
        dec: Angle.Degrees(+00.31096099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138968"},
        {"Hipparcos Number", "HIP 76325"},
        {"Smithsonian Astrophysical Observation", "SAO 121077"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.86209235),
        dec: Angle.Degrees(+00.31265598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37331"},
        {"Hipparcos Number", "HIP 26471"},
        {"Geneva Identification System", "GEN# +1.00037331"},
        {"Smithsonian Astrophysical Observation", "SAO 112978"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.45935970),
        dec: Angle.Degrees(+00.31731792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139406"},
        {"Hipparcos Number", "HIP 76547"},
        {"Geneva Identification System", "GEN# +1.00139406"},
        {"Smithsonian Astrophysical Observation", "SAO 121098"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.50069543),
        dec: Angle.Degrees(+00.31954813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 241 A"},
        {"Henry Draper", "HD 1329"},
        {"Hipparcos Number", "HIP 1397"},
        {"Smithsonian Astrophysical Observation", "SAO 109113"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.36983733),
        dec: Angle.Degrees(+00.32097536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 292296"},
        {"Hipparcos Number", "HIP 32596"},
        {"Geneva Identification System", "GEN# +1.00292296"},
        {"Smithsonian Astrophysical Observation", "SAO 114433"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.00028216),
        dec: Angle.Degrees(+00.32204873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12783"},
        {"Hipparcos Number", "HIP 9742"},
        {"Geneva Identification System", "GEN# +1.00012783"},
        {"Smithsonian Astrophysical Observation", "SAO 110329"},
        {"Wilson Evans Batten Catalogue", "WEB 2048"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.32971130),
        dec: Angle.Degrees(+00.32290725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188022"},
        {"Hipparcos Number", "HIP 97854"},
        {"Smithsonian Astrophysical Observation", "SAO 125172"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29095182),
        dec: Angle.Degrees(+00.32543487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198881"},
        {"Hipparcos Number", "HIP 103110"},
        {"Smithsonian Astrophysical Observation", "SAO 126338"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.36288889),
        dec: Angle.Degrees(+00.32551376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198347"},
        {"Hipparcos Number", "HIP 102813"},
        {"Smithsonian Astrophysical Observation", "SAO 126258"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.43055669),
        dec: Angle.Degrees(+00.32554324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50087"},
        {"Hipparcos Number", "HIP 32934"},
        {"Geneva Identification System", "GEN# +2.23010145"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.91917181),
        dec: Angle.Degrees(+00.32677441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155123"},
        {"Hipparcos Number", "HIP 83958"},
        {"Smithsonian Astrophysical Observation", "SAO 122136"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.42958608),
        dec: Angle.Degrees(+00.32753842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24042"},
        {"Hipparcos Number", "HIP 17910"},
        {"Smithsonian Astrophysical Observation", "SAO 111443"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.44843094),
        dec: Angle.Degrees(+00.32760601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16582"},
        {"Hipparcos Number", "HIP 12387"},
        {"Fundamental Katalog 5th Edition", "FK5 91"},
        {"Geneva Identification System", "GEN# +1.00016582"},
        {"Smithsonian Astrophysical Observation", "SAO 110665"},
        {"Wilson Evans Batten Catalogue", "WEB 2537"},
    },
    visualMagnitude: 4.08,
    bvColour: -0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.87061789),
        dec: Angle.Degrees(+00.32851680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158352"},
        {"Hipparcos Number", "HIP 85537"},
        {"Fundamental Katalog 5th Edition", "FK5 3391"},
        {"Geneva Identification System", "GEN# +1.00158352"},
        {"Smithsonian Astrophysical Observation", "SAO 122418"},
        {"Wilson Evans Batten Catalogue", "WEB 14440"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.20705273),
        dec: Angle.Degrees(+00.33057703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64413"},
        {"Hipparcos Number", "HIP 38573"},
        {"Smithsonian Astrophysical Observation", "SAO 116085"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.46574710),
        dec: Angle.Degrees(+00.33150493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188469"},
        {"Hipparcos Number", "HIP 98041"},
        {"Smithsonian Astrophysical Observation", "SAO 125234"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83682622),
        dec: Angle.Degrees(+00.33424716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112544"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.92956168),
        dec: Angle.Degrees(+00.33532577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67810"},
        {"Hipparcos Number", "HIP 39971"},
        {"Smithsonian Astrophysical Observation", "SAO 116420"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.43655006),
        dec: Angle.Degrees(+00.33609041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37788"},
        {"Hipparcos Number", "HIP 26762"},
        {"Geneva Identification System", "GEN# +1.00037788"},
        {"Smithsonian Astrophysical Observation", "SAO 113033"},
        {"Wilson Evans Batten Catalogue", "WEB 5279"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.27328514),
        dec: Angle.Degrees(+00.33768602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210185"},
        {"Hipparcos Number", "HIP 109302"},
        {"Smithsonian Astrophysical Observation", "SAO 127318"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.16866704),
        dec: Angle.Degrees(+00.33807631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182835"},
        {"Hipparcos Number", "HIP 95585"},
        {"Geneva Identification System", "GEN# +1.00182835A"},
        {"Renson", "Renson 50552"},
        {"Smithsonian Astrophysical Observation", "SAO 124628"},
        {"Wilson Evans Batten Catalogue", "WEB 16716"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.62954029),
        dec: Angle.Degrees(+00.33857566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181053"},
        {"Hipparcos Number", "HIP 94913"},
        {"Geneva Identification System", "GEN# +1.00181053"},
        {"Smithsonian Astrophysical Observation", "SAO 124492"},
        {"Wilson Evans Batten Catalogue", "WEB 16567"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.71222480),
        dec: Angle.Degrees(+00.33900138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5455 AB"},
        {"Henry Draper", "HD 49294"},
        {"Hipparcos Number", "HIP 32572"},
        {"Geneva Identification System", "GEN# +1.00049294J"},
        {"Smithsonian Astrophysical Observation", "SAO 114426"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.94815779),
        dec: Angle.Degrees(+00.34017027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5544"},
        {"Hipparcos Number", "HIP 4464"},
        {"Geneva Identification System", "GEN# +1.00005544"},
        {"Smithsonian Astrophysical Observation", "SAO 109552"},
        {"Wilson Evans Batten Catalogue", "WEB 807"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.30433708),
        dec: Angle.Degrees(+00.34235300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169192"},
        {"Hipparcos Number", "HIP 90123"},
        {"Smithsonian Astrophysical Observation", "SAO 123418"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.86773111),
        dec: Angle.Degrees(+00.34275356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50902",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7751 AB"},
        {"Henry Draper", "HD 90055"},
        {"Hipparcos Number", "HIP 50902"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.91465658),
        dec: Angle.Degrees(+00.34327075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53004"},
        {"Hipparcos Number", "HIP 34005"},
        {"Smithsonian Astrophysical Observation", "SAO 114842"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.84849243),
        dec: Angle.Degrees(+00.34399433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117406"},
        {"Hipparcos Number", "HIP 65874"},
        {"Smithsonian Astrophysical Observation", "SAO 119964"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.53261558),
        dec: Angle.Degrees(+00.34431318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92905"},
        {"Smithsonian Astrophysical Observation", "SAO 124056"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94453400),
        dec: Angle.Degrees(+00.34498194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12708 AB"},
        {"Henry Draper", "HD 185297"},
        {"Hipparcos Number", "HIP 96603"},
        {"Geneva Identification System", "GEN# +1.00185297J"},
        {"Smithsonian Astrophysical Observation", "SAO 124878"},
        {"Wilson Evans Batten Catalogue", "WEB 16950"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.59034898),
        dec: Angle.Degrees(+00.34544615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206404"},
        {"Hipparcos Number", "HIP 107120"},
        {"Geneva Identification System", "GEN# +1.00206404"},
        {"Smithsonian Astrophysical Observation", "SAO 126992"},
        {"Wilson Evans Batten Catalogue", "WEB 19347"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.48514995),
        dec: Angle.Degrees(+00.34606680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97422"},
        {"Hipparcos Number", "HIP 54766"},
        {"Smithsonian Astrophysical Observation", "SAO 118720"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18813058),
        dec: Angle.Degrees(+00.34808466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188859"},
        {"Hipparcos Number", "HIP 98191"},
        {"Smithsonian Astrophysical Observation", "SAO 125272"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30511671),
        dec: Angle.Degrees(+00.35206103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106817"},
        {"Hipparcos Number", "HIP 59890"},
        {"Smithsonian Astrophysical Observation", "SAO 119304"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.24322487),
        dec: Angle.Degrees(+00.35213130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155646"},
        {"Hipparcos Number", "HIP 84217"},
        {"Geneva Identification System", "GEN# +1.00155646"},
        {"Smithsonian Astrophysical Observation", "SAO 122182"},
        {"Wilson Evans Batten Catalogue", "WEB 14219"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22639294),
        dec: Angle.Degrees(+00.35220645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184409"},
        {"Hipparcos Number", "HIP 96257"},
        {"Geneva Identification System", "GEN# +1.00184409"},
        {"Smithsonian Astrophysical Observation", "SAO 124802"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.58185399),
        dec: Angle.Degrees(+00.35424081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161201"},
        {"Hipparcos Number", "HIP 86797"},
        {"Geneva Identification System", "GEN# +1.00161201"},
        {"Smithsonian Astrophysical Observation", "SAO 122682"},
        {"Wilson Evans Batten Catalogue", "WEB 14638"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.04168272),
        dec: Angle.Degrees(+00.35494144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86477"},
        {"Hipparcos Number", "HIP 48927"},
        {"Smithsonian Astrophysical Observation", "SAO 118030"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.72100114),
        dec: Angle.Degrees(+00.35687930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198406"},
        {"Hipparcos Number", "HIP 102841"},
        {"Renson", "Renson 55230"},
        {"Smithsonian Astrophysical Observation", "SAO 126268"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.51667591),
        dec: Angle.Degrees(+00.35927218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16005"},
        {"Hipparcos Number", "HIP 11962"},
        {"Smithsonian Astrophysical Observation", "SAO 110617"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59190906),
        dec: Angle.Degrees(+00.36152991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290064"},
        {"Hipparcos Number", "HIP 24236"},
        {"Smithsonian Astrophysical Observation", "SAO 112518"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.05475203),
        dec: Angle.Degrees(+00.36176160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72848"},
        {"Hipparcos Number", "HIP 42119"},
        {"Geneva Identification System", "GEN# +1.00072848"},
        {"Smithsonian Astrophysical Observation", "SAO 116915"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.78895067),
        dec: Angle.Degrees(+00.36269137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12307"},
        {"Hipparcos Number", "HIP 9394"},
        {"Geneva Identification System", "GEN# +1.00012307"},
        {"Smithsonian Astrophysical Observation", "SAO 110277"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.18478680),
        dec: Angle.Degrees(+00.36307806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214183"},
        {"Hipparcos Number", "HIP 111613"},
        {"Geneva Identification System", "GEN# +1.00214183"},
        {"Smithsonian Astrophysical Observation", "SAO 127632"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.16673791),
        dec: Angle.Degrees(+00.36406151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41100"},
        {"Smithsonian Astrophysical Observation", "SAO 116699"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76727448),
        dec: Angle.Degrees(+00.36459485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36269"},
        {"Hipparcos Number", "HIP 25799"},
        {"Geneva Identification System", "GEN# +1.00036269"},
        {"Smithsonian Astrophysical Observation", "SAO 112844"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.64449202),
        dec: Angle.Degrees(+00.36557294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51596"},
        {"Hipparcos Number", "HIP 33525"},
        {"Geneva Identification System", "GEN# +1.00051596"},
        {"Renson", "Renson 14206"},
        {"Smithsonian Astrophysical Observation", "SAO 114694"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.51548297),
        dec: Angle.Degrees(+00.36942897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135297"},
        {"Hipparcos Number", "HIP 74584"},
        {"Geneva Identification System", "GEN# +1.00135297"},
        {"Renson", "Renson 38390"},
        {"Smithsonian Astrophysical Observation", "SAO 120910"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.58757648),
        dec: Angle.Degrees(+00.36959656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112718"},
        {"Hipparcos Number", "HIP 63342"},
        {"Smithsonian Astrophysical Observation", "SAO 119689"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70009524),
        dec: Angle.Degrees(+00.37208279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135559"},
        {"Hipparcos Number", "HIP 74689"},
        {"Geneva Identification System", "GEN# +1.00135559"},
        {"Smithsonian Astrophysical Observation", "SAO 120920"},
        {"Wilson Evans Batten Catalogue", "WEB 12744"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.95474940),
        dec: Angle.Degrees(+00.37210753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11532"},
        {"Hipparcos Number", "HIP 8815"},
        {"Geneva Identification System", "GEN# +1.01153220"},
        {"Smithsonian Astrophysical Observation", "SAO 110201"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.32634231),
        dec: Angle.Degrees(+00.37319775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71422"},
        {"Smithsonian Astrophysical Observation", "SAO 120556"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.08428693),
        dec: Angle.Degrees(+00.37396744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17078"},
        {"Hipparcos Number", "HIP 12800"},
        {"Geneva Identification System", "GEN# +1.00017078"},
        {"Smithsonian Astrophysical Observation", "SAO 110719"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.13043686),
        dec: Angle.Degrees(+00.37513841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4483"},
        {"Hipparcos Number", "HIP 3665"},
        {"Smithsonian Astrophysical Observation", "SAO 109458"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.72020916),
        dec: Angle.Degrees(+00.37700097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1368"},
        {"Hipparcos Number", "HIP 1437"},
        {"Cincinnati Publication", "Ci 18 26"},
        {"Geneva Identification System", "GEN# +1.00001368"},
        {"Smithsonian Astrophysical Observation", "SAO 109122"},
        {"Wilson Evans Batten Catalogue", "WEB 262"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.47693979),
        dec: Angle.Degrees(+00.37758269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53812"},
        {"Smithsonian Astrophysical Observation", "SAO 118613"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15248322),
        dec: Angle.Degrees(+00.37880024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170652"},
        {"Hipparcos Number", "HIP 90726"},
        {"Smithsonian Astrophysical Observation", "SAO 123583"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.65416968),
        dec: Angle.Degrees(+00.37996331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4649"},
        {"Hipparcos Number", "HIP 3777"},
        {"Geneva Identification System", "GEN# +1.00004649"},
        {"Smithsonian Astrophysical Observation", "SAO 109473"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.13826887),
        dec: Angle.Degrees(+00.38211049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181906"},
        {"Hipparcos Number", "HIP 95221"},
        {"Geneva Identification System", "GEN# +1.00181906"},
        {"Smithsonian Astrophysical Observation", "SAO 124553"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.58875907),
        dec: Angle.Degrees(+00.38286015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125489"},
        {"Hipparcos Number", "HIP 70022"},
        {"Geneva Identification System", "GEN# +1.00125489"},
        {"Smithsonian Astrophysical Observation", "SAO 120400"},
        {"Wilson Evans Batten Catalogue", "WEB 12177"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.92071957),
        dec: Angle.Degrees(+00.38436366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293178"},
        {"Hipparcos Number", "HIP 34309"},
        {"Geneva Identification System", "GEN# +1.00293178"},
        {"Smithsonian Astrophysical Observation", "SAO 114932"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.69793031),
        dec: Angle.Degrees(+00.38900696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76525"},
        {"Hipparcos Number", "HIP 43913"},
        {"Geneva Identification System", "GEN# +1.00076525"},
        {"Smithsonian Astrophysical Observation", "SAO 117288"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.18962848),
        dec: Angle.Degrees(+00.39013120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166183"},
        {"Hipparcos Number", "HIP 88958"},
        {"Geneva Identification System", "GEN# +1.00166183"},
        {"Smithsonian Astrophysical Observation", "SAO 123181"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.37919771),
        dec: Angle.Degrees(+00.39144878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129291"},
        {"Hipparcos Number", "HIP 71842"},
        {"Geneva Identification System", "GEN# +1.00129291"},
        {"Smithsonian Astrophysical Observation", "SAO 120602"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.43963857),
        dec: Angle.Degrees(+00.39291164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106447"},
        {"Geneva Identification System", "GEN# +9.80026012"},
    },
    visualMagnitude: 12.14,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.40178916),
        dec: Angle.Degrees(+00.39560305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14652"},
        {"Hipparcos Number", "HIP 11021"},
        {"Geneva Identification System", "GEN# +1.00014652"},
        {"Smithsonian Astrophysical Observation", "SAO 110495"},
        {"Wilson Evans Batten Catalogue", "WEB 2316"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.48597927),
        dec: Angle.Degrees(+00.39569203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93345"},
        {"Geneva Identification System", "GEN# +0.00004078"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.19418266),
        dec: Angle.Degrees(+00.39718644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217622"},
        {"Hipparcos Number", "HIP 113737"},
        {"Smithsonian Astrophysical Observation", "SAO 127912"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.51312560),
        dec: Angle.Degrees(+00.39864689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59376"},
        {"Cincinnati Publication", "Ci 20 687"},
        {"Geneva Identification System", "GEN# +9.80011044"},
        {"Renson", "Renson 30624"},
        {"Wilson Evans Batten Catalogue", "WEB 10560"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.73251931),
        dec: Angle.Degrees(+00.39948417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -435.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215110"},
        {"Hipparcos Number", "HIP 112151"},
        {"Geneva Identification System", "GEN# +1.00215110"},
        {"Smithsonian Astrophysical Observation", "SAO 127706"},
        {"Wilson Evans Batten Catalogue", "WEB 20014"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74112845),
        dec: Angle.Degrees(+00.40226930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22484"},
        {"Hipparcos Number", "HIP 16852"},
        {"Cincinnati Publication", "Ci 20 245"},
        {"Fundamental Katalog 5th Edition", "FK5 1101"},
        {"Geneva Identification System", "GEN# +1.00022484"},
        {"Smithsonian Astrophysical Observation", "SAO 111292"},
        {"Wilson Evans Batten Catalogue", "WEB 3206"},
    },
    visualMagnitude: 4.29,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.21882896),
        dec: Angle.Degrees(+00.40283316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -482.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47530"},
        {"Hipparcos Number", "HIP 31820"},
        {"Geneva Identification System", "GEN# +1.00047530"},
        {"Smithsonian Astrophysical Observation", "SAO 114213"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.79376011),
        dec: Angle.Degrees(+00.40304192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5996 AB"},
        {"Henry Draper", "HD 57275"},
        {"Hipparcos Number", "HIP 35576"},
        {"Geneva Identification System", "GEN# +1.00057275J"},
        {"Smithsonian Astrophysical Observation", "SAO 115294"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.12946983),
        dec: Angle.Degrees(+00.40363429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183228"},
        {"Hipparcos Number", "HIP 95749"},
        {"Smithsonian Astrophysical Observation", "SAO 124662"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.11822214),
        dec: Angle.Degrees(+00.40428672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29052"},
        {"Hipparcos Number", "HIP 21307"},
        {"Geneva Identification System", "GEN# +1.00029052"},
        {"Smithsonian Astrophysical Observation", "SAO 111902"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.61186378),
        dec: Angle.Degrees(+00.40723777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7159 A"},
        {"Henry Draper", "HD 77484"},
        {"Hipparcos Number", "HIP 44413"},
        {"Smithsonian Astrophysical Observation", "SAO 117371"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.71109198),
        dec: Angle.Degrees(+00.40821398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10314"},
        {"Hipparcos Number", "HIP 7840"},
        {"Smithsonian Astrophysical Observation", "SAO 110052"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21393490),
        dec: Angle.Degrees(+00.41034521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114458"},
        {"Cincinnati Publication", "Ci 18 3031"},
        {"Geneva Identification System", "GEN# -0.00004475"},
        {"Smithsonian Astrophysical Observation", "SAO 128016"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.71101443),
        dec: Angle.Degrees(+00.41038994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216599"},
        {"Hipparcos Number", "HIP 113095"},
        {"Smithsonian Astrophysical Observation", "SAO 127830"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.55946722),
        dec: Angle.Degrees(+00.41516542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16919 A"},
        {"Henry Draper", "HD 222455"},
        {"Hipparcos Number", "HIP 116823"},
        {"Geneva Identification System", "GEN# +1.00222455"},
        {"Smithsonian Astrophysical Observation", "SAO 128319"},
        {"Wilson Evans Batten Catalogue", "WEB 20613"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.16784968),
        dec: Angle.Degrees(+00.41602606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50085"},
        {"Hipparcos Number", "HIP 32928"},
        {"Geneva Identification System", "GEN# +2.23010028"},
        {"Renson", "Renson 13620"},
        {"Smithsonian Astrophysical Observation", "SAO 114526"},
        {"New General Catalogue", "NGC 2301 28"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.90370314),
        dec: Angle.Degrees(+00.41881529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122444"},
        {"Hipparcos Number", "HIP 68539"},
        {"Smithsonian Astrophysical Observation", "SAO 120241"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.46742365),
        dec: Angle.Degrees(+00.42241471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180973"},
        {"Hipparcos Number", "HIP 94883"},
        {"Geneva Identification System", "GEN# +1.00180973"},
        {"Smithsonian Astrophysical Observation", "SAO 124486"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.63030110),
        dec: Angle.Degrees(+00.42338424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19595"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99189915),
        dec: Angle.Degrees(+00.42858452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170713"},
        {"Hipparcos Number", "HIP 90742"},
        {"Smithsonian Astrophysical Observation", "SAO 123588"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.73055598),
        dec: Angle.Degrees(+00.42955268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94738"},
        {"Hipparcos Number", "HIP 53460"},
        {"Smithsonian Astrophysical Observation", "SAO 118577"},
        {"Wilson Evans Batten Catalogue", "WEB 9703"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.04389637),
        dec: Angle.Degrees(+00.43293388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22904"},
        {"Smithsonian Astrophysical Observation", "SAO 112212"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.90350897),
        dec: Angle.Degrees(+00.43574281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32097"},
        {"Hipparcos Number", "HIP 23300"},
        {"Smithsonian Astrophysical Observation", "SAO 112307"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.17317044),
        dec: Angle.Degrees(+00.43625167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18175"},
        {"Hipparcos Number", "HIP 13598"},
        {"Geneva Identification System", "GEN# +1.00018175"},
        {"Smithsonian Astrophysical Observation", "SAO 110838"},
        {"Wilson Evans Batten Catalogue", "WEB 2702"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.80844184),
        dec: Angle.Degrees(+00.43689853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3493"},
        {"Hipparcos Number", "HIP 2982"},
        {"Smithsonian Astrophysical Observation", "SAO 109322"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48820878),
        dec: Angle.Degrees(+00.43767471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2221"},
        {"Hipparcos Number", "HIP 2057"},
        {"Geneva Identification System", "GEN# +1.00002221"},
        {"Smithsonian Astrophysical Observation", "SAO 109204"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51300439),
        dec: Angle.Degrees(+00.43776368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223364"},
        {"Hipparcos Number", "HIP 117457"},
        {"Geneva Identification System", "GEN# +1.00223364"},
        {"Smithsonian Astrophysical Observation", "SAO 128394"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.24120678),
        dec: Angle.Degrees(+00.43802941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88652"},
        {"Hipparcos Number", "HIP 50082"},
        {"Geneva Identification System", "GEN# +1.00088652"},
        {"Smithsonian Astrophysical Observation", "SAO 118173"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.37544644),
        dec: Angle.Degrees(+00.43829452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34637"},
        {"Hipparcos Number", "HIP 24803"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.76455210),
        dec: Angle.Degrees(+00.43849972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111196"},
        {"Hipparcos Number", "HIP 62417"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.87740528),
        dec: Angle.Degrees(+00.43887635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35194"},
        {"Hipparcos Number", "HIP 25164"},
        {"Geneva Identification System", "GEN# +1.00035194"},
        {"Smithsonian Astrophysical Observation", "SAO 112702"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75816317),
        dec: Angle.Degrees(+00.43908100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217679"},
        {"Hipparcos Number", "HIP 113770"},
        {"Geneva Identification System", "GEN# +1.00217679"},
        {"Smithsonian Astrophysical Observation", "SAO 127916"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.60128208),
        dec: Angle.Degrees(+00.43918199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181731"},
        {"Henry Draper 2", "HD 181732"},
        {"Hipparcos Number", "HIP 95155"},
        {"Geneva Identification System", "GEN# +1.00181731"},
        {"Smithsonian Astrophysical Observation", "SAO 124545"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.39998638),
        dec: Angle.Degrees(+00.44363263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23221"},
        {"Hipparcos Number", "HIP 17389"},
        {"Smithsonian Astrophysical Observation", "SAO 111374"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.85275841),
        dec: Angle.Degrees(+00.44513536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116454"},
        {"Geneva Identification System", "GEN# -0.00004534"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.95592023),
        dec: Angle.Degrees(+00.44596816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119945"},
        {"Hipparcos Number", "HIP 67216"},
        {"Smithsonian Astrophysical Observation", "SAO 120104"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61520013),
        dec: Angle.Degrees(+00.44613574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18369"},
        {"Hipparcos Number", "HIP 13765"},
        {"Geneva Identification System", "GEN# +1.00018369"},
        {"Smithsonian Astrophysical Observation", "SAO 110867"},
        {"Wilson Evans Batten Catalogue", "WEB 2725"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.29307336),
        dec: Angle.Degrees(+00.44780479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10788"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.72554995),
        dec: Angle.Degrees(+00.45158481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11028"},
        {"Hipparcos Number", "HIP 8393"},
        {"Smithsonian Astrophysical Observation", "SAO 110137"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.07102427),
        dec: Angle.Degrees(+00.45212623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5520"},
        {"Hipparcos Number", "HIP 4453"},
        {"Geneva Identification System", "GEN# +1.00005520"},
        {"Smithsonian Astrophysical Observation", "SAO 109548"},
        {"Wilson Evans Batten Catalogue", "WEB 802"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.24839375),
        dec: Angle.Degrees(+00.45264799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3095 AB"},
        {"Henry Draper", "HD 26991"},
        {"Hipparcos Number", "HIP 19892"},
        {"Smithsonian Astrophysical Observation", "SAO 111705"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.00593315),
        dec: Angle.Degrees(+00.45395118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31738"},
        {"Hipparcos Number", "HIP 23105"},
        {"Geneva Identification System", "GEN# +1.00031738"},
        {"Smithsonian Astrophysical Observation", "SAO 112278"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.57116069),
        dec: Angle.Degrees(+00.45398946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45317"},
        {"Hipparcos Number", "HIP 30670"},
        {"Geneva Identification System", "GEN# +1.00045317"},
        {"Smithsonian Astrophysical Observation", "SAO 113892"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.68083796),
        dec: Angle.Degrees(+00.45427537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13340 A"},
        {"Henry Draper", "HD 190522"},
        {"Hipparcos Number", "HIP 98945"},
        {"Smithsonian Astrophysical Observation", "SAO 125429"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.33474284),
        dec: Angle.Degrees(+00.45451197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120185"},
        {"Hipparcos Number", "HIP 67319"},
        {"Smithsonian Astrophysical Observation", "SAO 120116"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98109113),
        dec: Angle.Degrees(+00.45504651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9747 AB"},
        {"Henry Draper", "HD 140122"},
        {"Hipparcos Number", "HIP 76892"},
        {"Geneva Identification System", "GEN# +1.00140122"},
        {"Renson", "Renson 39830"},
        {"Smithsonian Astrophysical Observation", "SAO 121129"},
        {"Wilson Evans Batten Catalogue", "WEB 13042"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50579781),
        dec: Angle.Degrees(+00.45707508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67614"},
        {"Hipparcos Number", "HIP 39884"},
        {"Smithsonian Astrophysical Observation", "SAO 116398"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20308734),
        dec: Angle.Degrees(+00.45949920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54357"},
        {"Hipparcos Number", "HIP 34460"},
        {"Smithsonian Astrophysical Observation", "SAO 114978"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.14703157),
        dec: Angle.Degrees(+00.45983451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73153"},
        {"Smithsonian Astrophysical Observation", "SAO 120755"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.25805991),
        dec: Angle.Degrees(+00.46317508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14457 A"},
        {"Henry Draper", "HD 199442"},
        {"Hipparcos Number", "HIP 103414"},
        {"Geneva Identification System", "GEN# +1.00199442A"},
        {"Smithsonian Astrophysical Observation", "SAO 126396"},
        {"Wilson Evans Batten Catalogue", "WEB 18805"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29404317),
        dec: Angle.Degrees(+00.46393242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136888"},
        {"Hipparcos Number", "HIP 75293"},
        {"Smithsonian Astrophysical Observation", "SAO 120969"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.75614582),
        dec: Angle.Degrees(+00.46435072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31331"},
        {"Hipparcos Number", "HIP 22840"},
        {"Geneva Identification System", "GEN# +1.00031331"},
        {"Smithsonian Astrophysical Observation", "SAO 112206"},
        {"Wilson Evans Batten Catalogue", "WEB 4422"},
    },
    visualMagnitude: 5.98,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.71128549),
        dec: Angle.Degrees(+00.46717846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197409"},
        {"Hipparcos Number", "HIP 102285"},
        {"Geneva Identification System", "GEN# +1.00197409"},
        {"Smithsonian Astrophysical Observation", "SAO 126135"},
        {"Wilson Evans Batten Catalogue", "WEB 18516"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.88597567),
        dec: Angle.Degrees(+00.46939829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38054"},
        {"Smithsonian Astrophysical Observation", "SAO 115946"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.99199022),
        dec: Angle.Degrees(+00.46963044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75620"},
        {"Hipparcos Number", "HIP 43456"},
        {"Geneva Identification System", "GEN# +1.00075620"},
        {"Smithsonian Astrophysical Observation", "SAO 117197"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.76763956),
        dec: Angle.Degrees(+00.46969039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58384"},
        {"Hipparcos Number", "HIP 36023"},
        {"Smithsonian Astrophysical Observation", "SAO 115424"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.35499703),
        dec: Angle.Degrees(+00.47359762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51559"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.98333970),
        dec: Angle.Degrees(+00.47545843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12382"},
        {"Hipparcos Number", "HIP 9448"},
        {"Smithsonian Astrophysical Observation", "SAO 110282"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.36620218),
        dec: Angle.Degrees(+00.47586221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69581"},
        {"Hipparcos Number", "HIP 40627"},
        {"Smithsonian Astrophysical Observation", "SAO 116591"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.41200478),
        dec: Angle.Degrees(+00.47940712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65668"},
        {"Hipparcos Number", "HIP 39093"},
        {"Smithsonian Astrophysical Observation", "SAO 116214"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.96131624),
        dec: Angle.Degrees(+00.47986445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224263"},
        {"Hipparcos Number", "HIP 118025"},
        {"Renson", "Renson 61454"},
        {"Smithsonian Astrophysical Observation", "SAO 128481"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.11085615),
        dec: Angle.Degrees(+00.48132036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155231"},
        {"Hipparcos Number", "HIP 83999"},
        {"Geneva Identification System", "GEN# +1.00155231"},
        {"Smithsonian Astrophysical Observation", "SAO 122146"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.56485108),
        dec: Angle.Degrees(+00.48161201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53175"},
        {"Geneva Identification System", "GEN# +6.20030275"},
        {"Wilson Evans Batten Catalogue", "WEB 9659"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16529009),
        dec: Angle.Degrees(+00.48394972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12166"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.19900718),
        dec: Angle.Degrees(+00.48467164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82146"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.72635058),
        dec: Angle.Degrees(+00.48646571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14108 A"},
        {"Henry Draper", "HD 196758"},
        {"Hipparcos Number", "HIP 101936"},
        {"Fundamental Katalog 5th Edition", "FK5 3651"},
        {"Geneva Identification System", "GEN# +1.00196758"},
        {"Smithsonian Astrophysical Observation", "SAO 126062"},
        {"Wilson Evans Batten Catalogue", "WEB 18422"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.85346440),
        dec: Angle.Degrees(+00.48649190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43756"},
        {"Hipparcos Number", "HIP 29933"},
        {"Smithsonian Astrophysical Observation", "SAO 113702"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.52957976),
        dec: Angle.Degrees(+00.48669977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84222"},
        {"Hipparcos Number", "HIP 47712"},
        {"Geneva Identification System", "GEN# +1.00084222"},
        {"Smithsonian Astrophysical Observation", "SAO 117873"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90875639),
        dec: Angle.Degrees(+00.48690221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133583"},
        {"Hipparcos Number", "HIP 73823"},
        {"Smithsonian Astrophysical Observation", "SAO 120827"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32456721),
        dec: Angle.Degrees(+00.49400022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13326"},
        {"Hipparcos Number", "HIP 10122"},
        {"Geneva Identification System", "GEN# +1.00013326"},
        {"Smithsonian Astrophysical Observation", "SAO 110380"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.55272345),
        dec: Angle.Degrees(+00.49436617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115050"},
        {"Smithsonian Astrophysical Observation", "SAO 128096"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.52817591),
        dec: Angle.Degrees(+00.49479383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110440"},
        {"Hipparcos Number", "HIP 61977"},
        {"Geneva Identification System", "GEN# +1.00110440"},
        {"Smithsonian Astrophysical Observation", "SAO 119541"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.51269300),
        dec: Angle.Degrees(+00.49527253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47964"},
        {"Hipparcos Number", "HIP 31992"},
        {"Geneva Identification System", "GEN# +1.00047964"},
        {"Smithsonian Astrophysical Observation", "SAO 114269"},
        {"Wilson Evans Batten Catalogue", "WEB 6444"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.27268782),
        dec: Angle.Degrees(+00.49533540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37015"},
        {"Hipparcos Number", "HIP 26254"},
        {"Celescope Catalog", "CEL 838"},
        {"Geneva Identification System", "GEN# +1.00037015"},
        {"Smithsonian Astrophysical Observation", "SAO 112935"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.87596973),
        dec: Angle.Degrees(+00.49571212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111766"},
        {"Hipparcos Number", "HIP 62759"},
        {"Smithsonian Astrophysical Observation", "SAO 119634"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.91302497),
        dec: Angle.Degrees(+00.49614017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180622"},
        {"Hipparcos Number", "HIP 94785"},
        {"Smithsonian Astrophysical Observation", "SAO 124464"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.29599305),
        dec: Angle.Degrees(+00.49741006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14113"},
        {"Smithsonian Astrophysical Observation", "SAO 110917"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.50128106),
        dec: Angle.Degrees(+00.49785977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147470"},
        {"Hipparcos Number", "HIP 80184"},
        {"Smithsonian Astrophysical Observation", "SAO 121542"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.55384852),
        dec: Angle.Degrees(+00.49829166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118006"},
        {"Hipparcos Number", "HIP 66197"},
        {"Geneva Identification System", "GEN# +1.00118006"},
        {"Smithsonian Astrophysical Observation", "SAO 120003"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.52869985),
        dec: Angle.Degrees(+00.49919936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113099"},
        {"Hipparcos Number", "HIP 63545"},
        {"Smithsonian Astrophysical Observation", "SAO 119719"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.31734049),
        dec: Angle.Degrees(+00.49976059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199400"},
        {"Hipparcos Number", "HIP 103399"},
        {"Smithsonian Astrophysical Observation", "SAO 126394"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.22117309),
        dec: Angle.Degrees(+00.50314558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108182"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.76859929),
        dec: Angle.Degrees(+00.50375147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46713"},
        {"Hipparcos Number", "HIP 31406"},
        {"Fundamental Katalog 5th Edition", "FK5 4597"},
        {"Smithsonian Astrophysical Observation", "SAO 114091"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.74324944),
        dec: Angle.Degrees(+00.50409345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37198",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6240 ABC"},
        {"Henry Draper", "HD 61275"},
        {"Hipparcos Number", "HIP 37198"},
        {"Smithsonian Astrophysical Observation", "SAO 115733"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.62690149),
        dec: Angle.Degrees(+00.50502202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8855 AB"},
        {"Henry Draper", "HD 115710"},
        {"Hipparcos Number", "HIP 64960"},
        {"Smithsonian Astrophysical Observation", "SAO 119868"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.72697712),
        dec: Angle.Degrees(+00.50587442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131268"},
        {"Hipparcos Number", "HIP 72775"},
        {"Smithsonian Astrophysical Observation", "SAO 120706"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.14972453),
        dec: Angle.Degrees(+00.50682965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12134"},
        {"Hipparcos Number", "HIP 9272"},
        {"Geneva Identification System", "GEN# +1.00012134"},
        {"Smithsonian Astrophysical Observation", "SAO 110258"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.79298987),
        dec: Angle.Degrees(+00.50691835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150484"},
        {"Hipparcos Number", "HIP 81703"},
        {"Smithsonian Astrophysical Observation", "SAO 121784"},
        {"Wilson Evans Batten Catalogue", "WEB 13798"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33698195),
        dec: Angle.Degrees(+00.50755210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84157"},
        {"Hipparcos Number", "HIP 47666"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.79728836),
        dec: Angle.Degrees(+00.50924290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27800"},
        {"Hipparcos Number", "HIP 20473"},
        {"Smithsonian Astrophysical Observation", "SAO 111786"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.82400361),
        dec: Angle.Degrees(+00.50978076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92494"},
        {"Hipparcos Number", "HIP 52267"},
        {"Smithsonian Astrophysical Observation", "SAO 118428"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.19870970),
        dec: Angle.Degrees(+00.51010494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3591 A"},
        {"Hipparcos Number", "HIP 23222"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.96284299),
        dec: Angle.Degrees(+00.51081529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10819 AB"},
        {"Henry Draper", "HD 162232"},
        {"Hipparcos Number", "HIP 87272"},
        {"Smithsonian Astrophysical Observation", "SAO 122800"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48768056),
        dec: Angle.Degrees(+00.51206852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3767 AB"},
        {"Henry Draper", "HD 33647"},
        {"Hipparcos Number", "HIP 24196"},
        {"Geneva Identification System", "GEN# +1.00033647J"},
        {"Renson", "Renson 8580"},
        {"Smithsonian Astrophysical Observation", "SAO 112505"},
        {"Wilson Evans Batten Catalogue", "WEB 4700"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92227538),
        dec: Angle.Degrees(+00.51456989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108263"},
        {"Hipparcos Number", "HIP 60688"},
        {"Smithsonian Astrophysical Observation", "SAO 119393"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.57025183),
        dec: Angle.Degrees(+00.51476565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70136"},
    },
    visualMagnitude: 11.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.27056664),
        dec: Angle.Degrees(+00.51862653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1617"},
        {"Hipparcos Number", "HIP 1632"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.11806834),
        dec: Angle.Degrees(+00.51971287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35588"},
        {"Hipparcos Number", "HIP 25378"},
        {"Celescope Catalog", "CEL 691"},
        {"Geneva Identification System", "GEN# +1.00035588"},
        {"Smithsonian Astrophysical Observation", "SAO 112752"},
        {"Wilson Evans Batten Catalogue", "WEB 4919"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.44590528),
        dec: Angle.Degrees(+00.52024371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1513"},
        {"Hipparcos Number", "HIP 1545"},
        {"Geneva Identification System", "GEN# +1.00001513"},
        {"Smithsonian Astrophysical Observation", "SAO 109135"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.81931720),
        dec: Angle.Degrees(+00.52059326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18286"},
        {"Hipparcos Number", "HIP 13680"},
        {"Geneva Identification System", "GEN# +1.00018286"},
        {"Smithsonian Astrophysical Observation", "SAO 110854"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.05759229),
        dec: Angle.Degrees(+00.52219556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194136"},
        {"Hipparcos Number", "HIP 100590"},
        {"Smithsonian Astrophysical Observation", "SAO 125758"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96998003),
        dec: Angle.Degrees(+00.52253181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90720"},
        {"Hipparcos Number", "HIP 51285"},
        {"Smithsonian Astrophysical Observation", "SAO 118324"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.13067642),
        dec: Angle.Degrees(+00.52468521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219752"},
        {"Hipparcos Number", "HIP 115063"},
        {"Smithsonian Astrophysical Observation", "SAO 128100"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.58472778),
        dec: Angle.Degrees(+00.52495525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3481"},
        {"Smithsonian Astrophysical Observation", "SAO 109419"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.11207241),
        dec: Angle.Degrees(+00.52512201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47274"},
        {"Hipparcos Number", "HIP 31691"},
        {"Smithsonian Astrophysical Observation", "SAO 114163"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46163773),
        dec: Angle.Degrees(+00.52709750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95829"},
        {"Geneva Identification System", "GEN# +0.00004221"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.35983013),
        dec: Angle.Degrees(+00.52871908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223096"},
        {"Hipparcos Number", "HIP 117260"},
        {"Geneva Identification System", "GEN# +1.00223096"},
        {"Smithsonian Astrophysical Observation", "SAO 128375"},
        {"Wilson Evans Batten Catalogue", "WEB 20660"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64436515),
        dec: Angle.Degrees(+00.53011562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8372 A"},
        {"Henry Draper", "HD 104055"},
        {"Hipparcos Number", "HIP 58445"},
        {"Geneva Identification System", "GEN# +1.00104055"},
        {"Smithsonian Astrophysical Observation", "SAO 119147"},
        {"Wilson Evans Batten Catalogue", "WEB 10442"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.76406511),
        dec: Angle.Degrees(+00.53060794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204041"},
        {"Hipparcos Number", "HIP 105819"},
        {"Geneva Identification System", "GEN# +1.00204041"},
        {"Smithsonian Astrophysical Observation", "SAO 126789"},
        {"Wilson Evans Batten Catalogue", "WEB 19197"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.46481241),
        dec: Angle.Degrees(+00.53430605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78496"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.36638912),
        dec: Angle.Degrees(+00.53433258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206660"},
        {"Hipparcos Number", "HIP 107270"},
        {"Geneva Identification System", "GEN# +1.00206660"},
        {"Smithsonian Astrophysical Observation", "SAO 127018"},
        {"Wilson Evans Batten Catalogue", "WEB 19374"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.91448260),
        dec: Angle.Degrees(+00.53511179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76600"},
        {"Hipparcos Number", "HIP 43968"},
        {"Geneva Identification System", "GEN# +1.00076600"},
        {"Smithsonian Astrophysical Observation", "SAO 117293"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30797901),
        dec: Angle.Degrees(+00.53541957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110778"},
        {"Hipparcos Number", "HIP 62168"},
        {"Smithsonian Astrophysical Observation", "SAO 119565"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10580411),
        dec: Angle.Degrees(+00.53673388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132660"},
        {"Hipparcos Number", "HIP 73419"},
        {"Smithsonian Astrophysical Observation", "SAO 120783"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.06515708),
        dec: Angle.Degrees(+00.53722476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91920"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.08766530),
        dec: Angle.Degrees(+00.53745424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64940"},
        {"Hipparcos Number", "HIP 38796"},
        {"Smithsonian Astrophysical Observation", "SAO 116147"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.10154817),
        dec: Angle.Degrees(+00.53775132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208790"},
        {"Hipparcos Number", "HIP 108488"},
        {"Smithsonian Astrophysical Observation", "SAO 127204"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.66490169),
        dec: Angle.Degrees(+00.53945783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17272"},
    },
    visualMagnitude: 10.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47962989),
        dec: Angle.Degrees(+00.54315896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11119 AB"},
        {"Henry Draper", "HD 166384"},
        {"Hipparcos Number", "HIP 89038"},
        {"Smithsonian Astrophysical Observation", "SAO 123205"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.59985432),
        dec: Angle.Degrees(+00.54337946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60580"},
        {"Hipparcos Number", "HIP 36909"},
        {"Geneva Identification System", "GEN# +1.00060580"},
        {"Smithsonian Astrophysical Observation", "SAO 115665"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.82168450),
        dec: Angle.Degrees(+00.54578766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16786"},
        {"Hipparcos Number", "HIP 12555"},
        {"Geneva Identification System", "GEN# +1.00016786"},
        {"Smithsonian Astrophysical Observation", "SAO 110689"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37607972),
        dec: Angle.Degrees(+00.54606195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211926"},
        {"Hipparcos Number", "HIP 110319"},
        {"Smithsonian Astrophysical Observation", "SAO 127455"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16974572),
        dec: Angle.Degrees(+00.54656358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20813"},
        {"Hipparcos Number", "HIP 15624"},
        {"Geneva Identification System", "GEN# +1.00020813"},
        {"Smithsonian Astrophysical Observation", "SAO 111145"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.30165775),
        dec: Angle.Degrees(+00.54752304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155122"},
        {"Hipparcos Number", "HIP 83957"},
        {"Geneva Identification System", "GEN# +1.00155122"},
        {"Smithsonian Astrophysical Observation", "SAO 122135"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.42828660),
        dec: Angle.Degrees(+00.54852678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15827"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97513936),
        dec: Angle.Degrees(+00.55028388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16835"},
        {"Hipparcos Number", "HIP 12598"},
        {"Geneva Identification System", "GEN# +1.00016835"},
        {"Smithsonian Astrophysical Observation", "SAO 110692"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.49571136),
        dec: Angle.Degrees(+00.55033059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29634"},
        {"Hipparcos Number", "HIP 21739"},
        {"Geneva Identification System", "GEN# +1.00029634"},
        {"Smithsonian Astrophysical Observation", "SAO 111968"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.02326332),
        dec: Angle.Degrees(+00.55070632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57902"},
        {"Hipparcos Number", "HIP 35835"},
        {"Smithsonian Astrophysical Observation", "SAO 115374"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.84524008),
        dec: Angle.Degrees(+00.55103110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 292518"},
        {"Hipparcos Number", "HIP 32940"},
        {"Geneva Identification System", "GEN# +2.23010098"},
        {"New General Catalogue", "NGC 2301 98"},
    },
    visualMagnitude: 10.56,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.92842478),
        dec: Angle.Degrees(+00.55144638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103313"},
        {"Hipparcos Number", "HIP 58002"},
        {"Geneva Identification System", "GEN# +1.00103313"},
        {"Renson", "Renson 29796"},
        {"Smithsonian Astrophysical Observation", "SAO 119100"},
        {"Wilson Evans Batten Catalogue", "WEB 10388"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.45959018),
        dec: Angle.Degrees(+00.55210721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40446"},
        {"Hipparcos Number", "HIP 28296"},
        {"Fundamental Katalog 5th Edition", "FK5 1161"},
        {"Geneva Identification System", "GEN# +1.00040446"},
        {"Smithsonian Astrophysical Observation", "SAO 113321"},
        {"Wilson Evans Batten Catalogue", "WEB 5532"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.70658741),
        dec: Angle.Degrees(+00.55297359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29356"},
        {"Hipparcos Number", "HIP 21537"},
        {"Geneva Identification System", "GEN# +1.00029356"},
        {"Smithsonian Astrophysical Observation", "SAO 111935"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.36129865),
        dec: Angle.Degrees(+00.55309034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113227"},
        {"Hipparcos Number", "HIP 63615"},
        {"Smithsonian Astrophysical Observation", "SAO 119731"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.57012276),
        dec: Angle.Degrees(+00.55378242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80046"},
        {"Hipparcos Number", "HIP 45592"},
        {"Geneva Identification System", "GEN# +1.00080046"},
        {"Smithsonian Astrophysical Observation", "SAO 117569"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.38717049),
        dec: Angle.Degrees(+00.55494213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43224",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7004 A"},
        {"Henry Draper", "HD 75138"},
        {"Hipparcos Number", "HIP 43224"},
        {"Geneva Identification System", "GEN# +1.00075138"},
        {"Smithsonian Astrophysical Observation", "SAO 117144"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.07627602),
        dec: Angle.Degrees(+00.55504689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131006"},
        {"Hipparcos Number", "HIP 72644"},
        {"Geneva Identification System", "GEN# +1.00131006"},
        {"Smithsonian Astrophysical Observation", "SAO 120696"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.78610121),
        dec: Angle.Degrees(+00.55680455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7004 B"},
        {"Henry Draper", "HD 75138B"},
        {"Hipparcos Number", "HIP 43225"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.07920243),
        dec: Angle.Degrees(+00.55697316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212368"},
        {"Hipparcos Number", "HIP 110552"},
        {"Fundamental Katalog 5th Edition", "FK5 5976"},
        {"Smithsonian Astrophysical Observation", "SAO 127504"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.93143095),
        dec: Angle.Degrees(+00.55748858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120722"},
        {"Hipparcos Number", "HIP 67607"},
        {"Smithsonian Astrophysical Observation", "SAO 120139"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.79116125),
        dec: Angle.Degrees(+00.55822384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29788"},
        {"Hipparcos Number", "HIP 21833"},
        {"Smithsonian Astrophysical Observation", "SAO 111984"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39958057),
        dec: Angle.Degrees(+00.56004219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33946"},
        {"Hipparcos Number", "HIP 24377"},
        {"Geneva Identification System", "GEN# +1.00033946"},
        {"Smithsonian Astrophysical Observation", "SAO 112543"},
        {"Wilson Evans Batten Catalogue", "WEB 4727"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.44687015),
        dec: Angle.Degrees(+00.56046647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70660"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.79620178),
        dec: Angle.Degrees(+00.56071138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191691"},
        {"Hipparcos Number", "HIP 99459"},
        {"Smithsonian Astrophysical Observation", "SAO 125532"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.79483104),
        dec: Angle.Degrees(+00.56088076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147397"},
        {"Hipparcos Number", "HIP 80163"},
        {"Smithsonian Astrophysical Observation", "SAO 121535"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.45927816),
        dec: Angle.Degrees(+00.56280654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104528"},
        {"Hipparcos Number", "HIP 58700"},
        {"Smithsonian Astrophysical Observation", "SAO 119176"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.58867147),
        dec: Angle.Degrees(+00.56370423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38310"},
        {"Hipparcos Number", "HIP 27107"},
        {"Smithsonian Astrophysical Observation", "SAO 113098"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.22696959),
        dec: Angle.Degrees(+00.56381057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172651"},
        {"Hipparcos Number", "HIP 91655"},
        {"Geneva Identification System", "GEN# +1.00172651"},
        {"Smithsonian Astrophysical Observation", "SAO 123809"},
        {"Wilson Evans Batten Catalogue", "WEB 15762"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.36117703),
        dec: Angle.Degrees(+00.56448117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30112"},
        {"Hipparcos Number", "HIP 22061"},
        {"Fundamental Katalog 5th Edition", "FK5 4430"},
        {"Geneva Identification System", "GEN# +1.00030112"},
        {"Smithsonian Astrophysical Observation", "SAO 112033"},
        {"Wilson Evans Batten Catalogue", "WEB 4239"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.17565693),
        dec: Angle.Degrees(+00.56817195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109186",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15639 AB"},
        {"Henry Draper", "HD 209965"},
        {"Hipparcos Number", "HIP 109186"},
        {"Smithsonian Astrophysical Observation", "SAO 127306"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.77753449),
        dec: Angle.Degrees(+00.57016787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60178"},
        {"Wilson Evans Batten Catalogue", "WEB 10699"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20, 24.5400),
        dec: Angle.DegreesMinutesSeconds((int)+00, (int)34, 20.600)
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
    primaryId: "HIP 54994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97892"},
        {"Hipparcos Number", "HIP 54994"},
        {"Smithsonian Astrophysical Observation", "SAO 118751"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.90238857),
        dec: Angle.Degrees(+00.57344299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108850"},
        {"Hipparcos Number", "HIP 61030"},
        {"Smithsonian Astrophysical Observation", "SAO 119435"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.61924593),
        dec: Angle.Degrees(+00.57440782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29355"},
        {"Hipparcos Number", "HIP 21534"},
        {"Geneva Identification System", "GEN# +1.00029355"},
        {"Smithsonian Astrophysical Observation", "SAO 111934"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.35867010),
        dec: Angle.Degrees(+00.57460419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59377"},
        {"Hipparcos Number", "HIP 36426"},
        {"Geneva Identification System", "GEN# +1.00059377"},
        {"Smithsonian Astrophysical Observation", "SAO 115520"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.45004031),
        dec: Angle.Degrees(+00.57476030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177115"},
        {"Hipparcos Number", "HIP 93557"},
        {"Geneva Identification System", "GEN# +1.00177115"},
        {"Smithsonian Astrophysical Observation", "SAO 124198"},
        {"Wilson Evans Batten Catalogue", "WEB 16249"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.83057595),
        dec: Angle.Degrees(+00.57617889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22532"},
        {"Geneva Identification System", "GEN# +0.00000873"},
        {"Wilson Evans Batten Catalogue", "WEB 4350"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.73222696),
        dec: Angle.Degrees(+00.57662705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39802"},
        {"Hipparcos Number", "HIP 27968"},
        {"Smithsonian Astrophysical Observation", "SAO 113270"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73812944),
        dec: Angle.Degrees(+00.57735417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96121"},
        {"Geneva Identification System", "GEN# +0.00004241"},
        {"Wilson Evans Batten Catalogue", "WEB 16838"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.15745654),
        dec: Angle.Degrees(+00.57745578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171070"},
        {"Hipparcos Number", "HIP 90912"},
        {"Smithsonian Astrophysical Observation", "SAO 123617"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.17144021),
        dec: Angle.Degrees(+00.57752732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156669"},
        {"Hipparcos Number", "HIP 84707"},
        {"Smithsonian Astrophysical Observation", "SAO 122269"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.72962529),
        dec: Angle.Degrees(+00.57917851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4352"},
        {"Hipparcos Number", "HIP 3591"},
        {"Geneva Identification System", "GEN# +1.00004352"},
        {"Smithsonian Astrophysical Observation", "SAO 109441"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.47714629),
        dec: Angle.Degrees(+00.57936277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92316",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nova Aquila No 3"},
        {"Henry Draper", "HD 174107"},
        {"Hipparcos Number", "HIP 92316"},
        {"Geneva Identification System", "GEN# +8.04000003"},
        {"Wilson Evans Batten Catalogue", "WEB 15932"},
    },
    visualMagnitude: 11.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.22762634),
        dec: Angle.Degrees(+00.58415016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113984"},
        {"Hipparcos Number", "HIP 64030"},
        {"Geneva Identification System", "GEN# +1.00113984"},
        {"Smithsonian Astrophysical Observation", "SAO 119774"},
        {"Wilson Evans Batten Catalogue", "WEB 11317"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.83232688),
        dec: Angle.Degrees(+00.58519889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101356"},
        {"Wilson Evans Batten Catalogue", "WEB 18314"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.13142351),
        dec: Angle.Degrees(+00.58535736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2644 A"},
        {"Henry Draper", "HD 22468"},
        {"Henry Draper 2", "HD 22468A"},
        {"Hipparcos Number", "HIP 16846"},
        {"Geneva Identification System", "GEN# +1.00022468"},
        {"Smithsonian Astrophysical Observation", "SAO 111291"},
        {"Wilson Evans Batten Catalogue", "WEB 3204"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.19711994),
        dec: Angle.Degrees(+00.58815498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4761"},
        {"Hipparcos Number", "HIP 3863"},
        {"Smithsonian Astrophysical Observation", "SAO 109484"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.39625379),
        dec: Angle.Degrees(+00.58817712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48691"},
        {"Hipparcos Number", "HIP 32300"},
        {"Geneva Identification System", "GEN# +1.00048691"},
        {"Smithsonian Astrophysical Observation", "SAO 114352"},
        {"Wilson Evans Batten Catalogue", "WEB 6514"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.15230767),
        dec: Angle.Degrees(+00.58930753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1311"},
        {"Hipparcos Number", "HIP 1385"},
        {"Smithsonian Astrophysical Observation", "SAO 109110"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.33268320),
        dec: Angle.Degrees(+00.59009841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144959"},
        {"Hipparcos Number", "HIP 79075"},
        {"Geneva Identification System", "GEN# +1.00144959"},
        {"Smithsonian Astrophysical Observation", "SAO 121382"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.13143245),
        dec: Angle.Degrees(+00.59114068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34550"},
        {"Hipparcos Number", "HIP 24746"},
        {"Geneva Identification System", "GEN# +1.00034550"},
        {"Smithsonian Astrophysical Observation", "SAO 112610"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.59364947),
        dec: Angle.Degrees(+00.59306009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103450",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14463 B"},
        {"Hipparcos Number", "HIP 103450"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.37805114),
        dec: Angle.Degrees(+00.59331223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34879"},
        {"Hipparcos Number", "HIP 24952"},
        {"Smithsonian Astrophysical Observation", "SAO 112651"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.16468375),
        dec: Angle.Degrees(+00.59454944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213893"},
        {"Hipparcos Number", "HIP 111441"},
        {"Geneva Identification System", "GEN# +1.00213893"},
        {"Smithsonian Astrophysical Observation", "SAO 127611"},
        {"Wilson Evans Batten Catalogue", "WEB 19925"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.64980568),
        dec: Angle.Degrees(+00.59536075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223943"},
        {"Hipparcos Number", "HIP 117832"},
        {"Smithsonian Astrophysical Observation", "SAO 128449"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.46724603),
        dec: Angle.Degrees(+00.59620014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100832"},
        {"Hipparcos Number", "HIP 56605"},
        {"Smithsonian Astrophysical Observation", "SAO 118944"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.08523699),
        dec: Angle.Degrees(+00.59708527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100156"},
        {"Smithsonian Astrophysical Observation", "SAO 125672"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.74210875),
        dec: Angle.Degrees(+00.59746442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27008"},
        {"Hipparcos Number", "HIP 19899"},
        {"Fundamental Katalog 5th Edition", "FK5 4392"},
        {"Geneva Identification System", "GEN# +1.00027008"},
        {"Smithsonian Astrophysical Observation", "SAO 111706"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.02733227),
        dec: Angle.Degrees(+00.59778013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78282"},
        {"Hipparcos Number", "HIP 44761"},
        {"Geneva Identification System", "GEN# +1.00078282"},
        {"Smithsonian Astrophysical Observation", "SAO 117436"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.84249579),
        dec: Angle.Degrees(+00.60021743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208671"},
        {"Hipparcos Number", "HIP 108428"},
        {"Smithsonian Astrophysical Observation", "SAO 127194"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.47112012),
        dec: Angle.Degrees(+00.60022361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11290"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.35619362),
        dec: Angle.Degrees(+00.60034413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103446",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14463 A"},
        {"Henry Draper", "HD 199482"},
        {"Hipparcos Number", "HIP 103446"},
        {"Smithsonian Astrophysical Observation", "SAO 126405"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.37066633),
        dec: Angle.Degrees(+00.60186005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81491"},
        {"Hipparcos Number", "HIP 46262"},
        {"Geneva Identification System", "GEN# +1.00081491"},
        {"Smithsonian Astrophysical Observation", "SAO 117685"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.49320729),
        dec: Angle.Degrees(+00.60269663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3771 AB"},
        {"Henry Draper", "HD 33692"},
        {"Hipparcos Number", "HIP 24227"},
        {"Geneva Identification System", "GEN# +1.00033692"},
        {"Renson", "Renson 8597"},
        {"Smithsonian Astrophysical Observation", "SAO 112513"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.02344923),
        dec: Angle.Degrees(+00.60463744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209128"},
        {"Hipparcos Number", "HIP 108691"},
        {"Geneva Identification System", "GEN# +1.00209128"},
        {"Smithsonian Astrophysical Observation", "SAO 127235"},
        {"Wilson Evans Batten Catalogue", "WEB 19558"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.27087929),
        dec: Angle.Degrees(+00.60474348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185378"},
        {"Hipparcos Number", "HIP 96629"},
        {"Geneva Identification System", "GEN# +1.00185378"},
        {"Smithsonian Astrophysical Observation", "SAO 124891"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69642871),
        dec: Angle.Degrees(+00.60568390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137884"},
        {"Hipparcos Number", "HIP 75756"},
        {"Renson", "Renson 39196"},
        {"Smithsonian Astrophysical Observation", "SAO 121017"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.13751532),
        dec: Angle.Degrees(+00.60703796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54246"},
        {"Smithsonian Astrophysical Observation", "SAO 118654"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46503377),
        dec: Angle.Degrees(+00.60754466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212318"},
        {"Hipparcos Number", "HIP 110522"},
        {"Geneva Identification System", "GEN# +1.00212318"},
        {"Smithsonian Astrophysical Observation", "SAO 127494"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.86508254),
        dec: Angle.Degrees(+00.60863830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8952"},
        {"Geneva Identification System", "GEN# -0.00000294"},
        {"Smithsonian Astrophysical Observation", "SAO 110230"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.82662377),
        dec: Angle.Degrees(+00.60872821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68285"},
        {"Hipparcos Number", "HIP 40132"},
        {"Smithsonian Astrophysical Observation", "SAO 116467"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95488920),
        dec: Angle.Degrees(+00.60903993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102696"},
        {"Hipparcos Number", "HIP 57658"},
        {"Smithsonian Astrophysical Observation", "SAO 119062"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.36725178),
        dec: Angle.Degrees(+00.60917866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87939"},
        {"Hipparcos Number", "HIP 49671"},
        {"Smithsonian Astrophysical Observation", "SAO 118128"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.10030462),
        dec: Angle.Degrees(+00.60931348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10165"},
        {"Hipparcos Number", "HIP 7724"},
        {"Smithsonian Astrophysical Observation", "SAO 110033"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.85465324),
        dec: Angle.Degrees(+00.61208790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41460"},
        {"Hipparcos Number", "HIP 28847"},
        {"Geneva Identification System", "GEN# +1.00041460"},
        {"Smithsonian Astrophysical Observation", "SAO 113439"},
        {"Wilson Evans Batten Catalogue", "WEB 5644"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.34460887),
        dec: Angle.Degrees(+00.61287519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81549"},
        {"Hipparcos Number", "HIP 46286"},
        {"Smithsonian Astrophysical Observation", "SAO 117692"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.58499016),
        dec: Angle.Degrees(+00.61306570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41288"},
        {"Hipparcos Number", "HIP 28746"},
        {"Geneva Identification System", "GEN# +1.00041288"},
        {"Smithsonian Astrophysical Observation", "SAO 113419"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.06112775),
        dec: Angle.Degrees(+00.61351385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6331"},
        {"Hipparcos Number", "HIP 5017"},
        {"Smithsonian Astrophysical Observation", "SAO 109648"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.07315506),
        dec: Angle.Degrees(+00.61537868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30356"},
        {"Hipparcos Number", "HIP 22230"},
        {"Smithsonian Astrophysical Observation", "SAO 112072"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.72321782),
        dec: Angle.Degrees(+00.61734781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23503"},
        {"Hipparcos Number", "HIP 17567"},
        {"Geneva Identification System", "GEN# +1.00023503"},
        {"Smithsonian Astrophysical Observation", "SAO 111402"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.43544561),
        dec: Angle.Degrees(+00.61735011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56272"},
    },
    visualMagnitude: 12.05,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.04924669),
        dec: Angle.Degrees(+00.61854245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 292167"},
        {"Hipparcos Number", "HIP 32327"},
        {"Geneva Identification System", "GEN# +1.00292167"},
        {"Smithsonian Astrophysical Observation", "SAO 114357"},
        {"Wilson Evans Batten Catalogue", "WEB 6522"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.22422842),
        dec: Angle.Degrees(+00.62016364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105374"},
        {"Hipparcos Number", "HIP 59164"},
        {"Geneva Identification System", "GEN# +1.00105374"},
        {"Smithsonian Astrophysical Observation", "SAO 119234"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.00247218),
        dec: Angle.Degrees(+00.62135927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36668"},
        {"Hipparcos Number", "HIP 26048"},
        {"Celescope Catalog", "CEL 785"},
        {"Geneva Identification System", "GEN# +1.00036668"},
        {"Renson", "Renson 9560"},
        {"Smithsonian Astrophysical Observation", "SAO 112899"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.35857805),
        dec: Angle.Degrees(+00.62136993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143395"},
        {"Hipparcos Number", "HIP 78377"},
        {"Fundamental Katalog 5th Edition", "FK5 5411"},
        {"Smithsonian Astrophysical Observation", "SAO 121301"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.00900178),
        dec: Angle.Degrees(+00.62362150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13957"},
        {"Smithsonian Astrophysical Observation", "SAO 110892"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.93799104),
        dec: Angle.Degrees(+00.62489825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160347"},
        {"Hipparcos Number", "HIP 86409"},
        {"Fundamental Katalog 5th Edition", "FK5 5550"},
        {"Smithsonian Astrophysical Observation", "SAO 122611"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.84463406),
        dec: Angle.Degrees(+00.62568615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6278 AB"},
        {"Henry Draper", "HD 61771"},
        {"Hipparcos Number", "HIP 37426"},
        {"Smithsonian Astrophysical Observation", "SAO 115800"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.24107037),
        dec: Angle.Degrees(+00.62699583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184546"},
        {"Hipparcos Number", "HIP 96312"},
        {"Geneva Identification System", "GEN# +1.00184546"},
        {"Smithsonian Astrophysical Observation", "SAO 124812"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.74396994),
        dec: Angle.Degrees(+00.62733378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209726"},
        {"Hipparcos Number", "HIP 109052"},
        {"Smithsonian Astrophysical Observation", "SAO 127281"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.38395708),
        dec: Angle.Degrees(+00.62760814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147293"},
        {"Hipparcos Number", "HIP 80101"},
        {"Smithsonian Astrophysical Observation", "SAO 121524"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.27283627),
        dec: Angle.Degrees(+00.62776097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164258"},
        {"Hipparcos Number", "HIP 88148"},
        {"Geneva Identification System", "GEN# +1.00164258"},
        {"Renson", "Renson 46450"},
        {"Smithsonian Astrophysical Observation", "SAO 123004"},
        {"Wilson Evans Batten Catalogue", "WEB 14893"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06525642),
        dec: Angle.Degrees(+00.62948791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70983"},
    },
    visualMagnitude: 11.44,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.77867020),
        dec: Angle.Degrees(+00.63276117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15003"},
        {"Hipparcos Number", "HIP 11269"},
        {"Smithsonian Astrophysical Observation", "SAO 110521"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.28327574),
        dec: Angle.Degrees(+00.63639061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133462"},
        {"Hipparcos Number", "HIP 73757"},
        {"Smithsonian Astrophysical Observation", "SAO 120824"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.14891548),
        dec: Angle.Degrees(+00.64064676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178065"},
        {"Hipparcos Number", "HIP 93892"},
        {"Geneva Identification System", "GEN# +1.00178065"},
        {"Renson", "Renson 49620"},
        {"Smithsonian Astrophysical Observation", "SAO 124282"},
        {"Wilson Evans Batten Catalogue", "WEB 16334"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78764073),
        dec: Angle.Degrees(+00.64100550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193122"},
        {"Hipparcos Number", "HIP 100121"},
        {"Fundamental Katalog 5th Edition", "FK5 3624"},
        {"Geneva Identification System", "GEN# +1.00193122"},
        {"Smithsonian Astrophysical Observation", "SAO 125665"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.65607560),
        dec: Angle.Degrees(+00.64107378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160969"},
        {"Hipparcos Number", "HIP 86699"},
        {"Smithsonian Astrophysical Observation", "SAO 122665"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.71690498),
        dec: Angle.Degrees(+00.64559919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74831"},
        {"Hipparcos Number", "HIP 43060"},
        {"Geneva Identification System", "GEN# +1.00074831"},
        {"Smithsonian Astrophysical Observation", "SAO 117102"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58374419),
        dec: Angle.Degrees(+00.64689272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189415"},
        {"Hipparcos Number", "HIP 98429"},
        {"Geneva Identification System", "GEN# +1.00189415"},
        {"Smithsonian Astrophysical Observation", "SAO 125320"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.99036189),
        dec: Angle.Degrees(+00.64695415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56518"},
        {"Hipparcos Number", "HIP 35285"},
        {"Geneva Identification System", "GEN# +1.00056518"},
        {"Smithsonian Astrophysical Observation", "SAO 115206"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.33837634),
        dec: Angle.Degrees(+00.64859835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13046 AB"},
        {"Henry Draper", "HD 187930"},
        {"Hipparcos Number", "HIP 97809"},
        {"Geneva Identification System", "GEN# +1.00187930J"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.13569102),
        dec: Angle.Degrees(+00.64898427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 291725"},
        {"Hipparcos Number", "HIP 31127"},
        {"Geneva Identification System", "GEN# +1.00291725"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.96479444),
        dec: Angle.Degrees(+00.65004329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7646"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.62349663),
        dec: Angle.Degrees(+00.65118329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 512.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10341 AB"},
        {"Henry Draper", "HD 154621"},
        {"Hipparcos Number", "HIP 83716"},
        {"Geneva Identification System", "GEN# +1.00154621J"},
        {"Smithsonian Astrophysical Observation", "SAO 122078"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.65075202),
        dec: Angle.Degrees(+00.65220817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61050"},
    },
    visualMagnitude: 11.57,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.69283140),
        dec: Angle.Degrees(+00.65651686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82888"},
        {"Hipparcos Number", "HIP 47010"},
        {"Geneva Identification System", "GEN# +1.00082888"},
        {"Smithsonian Astrophysical Observation", "SAO 117782"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.71296482),
        dec: Angle.Degrees(+00.65767622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63436"},
        {"Hipparcos Number", "HIP 38138"},
        {"Geneva Identification System", "GEN# +1.00063436"},
        {"Smithsonian Astrophysical Observation", "SAO 115967"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.24259515),
        dec: Angle.Degrees(+00.66198467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290054"},
        {"Hipparcos Number", "HIP 24454"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.69997880),
        dec: Angle.Degrees(+00.66304730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -446.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108916"},
        {"Hipparcos Number", "HIP 61061"},
        {"Smithsonian Astrophysical Observation", "SAO 119442"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.72644275),
        dec: Angle.Degrees(+00.66475028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148513"},
        {"Hipparcos Number", "HIP 80693"},
        {"Fundamental Katalog 5th Edition", "FK5 3300"},
        {"Geneva Identification System", "GEN# +1.00148513"},
        {"Smithsonian Astrophysical Observation", "SAO 121623"},
        {"Wilson Evans Batten Catalogue", "WEB 13648"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14157201),
        dec: Angle.Degrees(+00.66516717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111544"},
        {"Hipparcos Number", "HIP 62633"},
        {"Smithsonian Astrophysical Observation", "SAO 119616"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.51058192),
        dec: Angle.Degrees(+00.66563841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13045"},
        {"Smithsonian Astrophysical Observation", "SAO 110749"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.90703419),
        dec: Angle.Degrees(+00.66651944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163288"},
        {"Hipparcos Number", "HIP 87738"},
        {"Geneva Identification System", "GEN# +1.00163288"},
        {"Smithsonian Astrophysical Observation", "SAO 122915"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.83738075),
        dec: Angle.Degrees(+00.66702841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114865"},
        {"Smithsonian Astrophysical Observation", "SAO 128071"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.99331942),
        dec: Angle.Degrees(+00.66987236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163472"},
        {"Hipparcos Number", "HIP 87812"},
        {"Geneva Identification System", "GEN# +1.00163472"},
        {"Renson", "Renson 46222"},
        {"Smithsonian Astrophysical Observation", "SAO 122935"},
        {"Wilson Evans Batten Catalogue", "WEB 14819"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.07667921),
        dec: Angle.Degrees(+00.67035571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75455"},
        {"Smithsonian Astrophysical Observation", "SAO 120987"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.22840981),
        dec: Angle.Degrees(+00.67070530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5804"},
        {"Hipparcos Number", "HIP 4642"},
        {"Smithsonian Astrophysical Observation", "SAO 109579"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.90254237),
        dec: Angle.Degrees(+00.67076631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144172"},
        {"Hipparcos Number", "HIP 78742"},
        {"Geneva Identification System", "GEN# +1.00144172"},
        {"Smithsonian Astrophysical Observation", "SAO 121350"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.12328523),
        dec: Angle.Degrees(+00.67242104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155716"},
        {"Hipparcos Number", "HIP 84246"},
        {"Fundamental Katalog 5th Edition", "FK5 5519"},
        {"Smithsonian Astrophysical Observation", "SAO 122189"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.32247507),
        dec: Angle.Degrees(+00.67280314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212902"},
        {"Hipparcos Number", "HIP 110856"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.89723595),
        dec: Angle.Degrees(+00.67285023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203236"},
        {"Hipparcos Number", "HIP 105409"},
        {"Geneva Identification System", "GEN# +1.00203236"},
        {"Smithsonian Astrophysical Observation", "SAO 126718"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.26103421),
        dec: Angle.Degrees(+00.67450589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63859"},
        {"Hipparcos Number", "HIP 38323"},
        {"Smithsonian Astrophysical Observation", "SAO 116025"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.76324119),
        dec: Angle.Degrees(+00.67466483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78311"},
        {"Smithsonian Astrophysical Observation", "SAO 121296"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.85169017),
        dec: Angle.Degrees(+00.67470828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186296"},
        {"Hipparcos Number", "HIP 97059"},
        {"Smithsonian Astrophysical Observation", "SAO 124991"},
        {"Wilson Evans Batten Catalogue", "WEB 17033"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.87696339),
        dec: Angle.Degrees(+00.67568072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30486"},
        {"Hipparcos Number", "HIP 22296"},
        {"Geneva Identification System", "GEN# +1.00030486"},
        {"Smithsonian Astrophysical Observation", "SAO 112088"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.02455071),
        dec: Angle.Degrees(+00.67580977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32951"},
        {"Hipparcos Number", "HIP 23798"},
        {"Geneva Identification System", "GEN# +1.00032951"},
        {"Smithsonian Astrophysical Observation", "SAO 112426"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.70291267),
        dec: Angle.Degrees(+00.67756725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106633"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.98292053),
        dec: Angle.Degrees(+00.67813855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201752"},
        {"Hipparcos Number", "HIP 104629"},
        {"Smithsonian Astrophysical Observation", "SAO 126605"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.91359880),
        dec: Angle.Degrees(+00.67833621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102009",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14129 A"},
        {"Henry Draper", "HD 196913"},
        {"Hipparcos Number", "HIP 102009"},
        {"Fundamental Katalog 5th Edition", "FK5 5818"},
        {"Smithsonian Astrophysical Observation", "SAO 126086"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.07310545),
        dec: Angle.Degrees(+00.67973350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204248"},
        {"Hipparcos Number", "HIP 105936"},
        {"Smithsonian Astrophysical Observation", "SAO 126804"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82246339),
        dec: Angle.Degrees(+00.67977416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28101"},
        {"Hipparcos Number", "HIP 20700"},
        {"Smithsonian Astrophysical Observation", "SAO 111815"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.51109075),
        dec: Angle.Degrees(+00.68044400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22199"},
        {"Hipparcos Number", "HIP 16675"},
        {"Geneva Identification System", "GEN# +1.00022199"},
        {"Smithsonian Astrophysical Observation", "SAO 111268"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.64562232),
        dec: Angle.Degrees(+00.68052692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205525"},
        {"Hipparcos Number", "HIP 106632"},
        {"Smithsonian Astrophysical Observation", "SAO 126915"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.98151455),
        dec: Angle.Degrees(+00.68098067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167108"},
        {"Hipparcos Number", "HIP 89340"},
        {"Smithsonian Astrophysical Observation", "SAO 123267"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.43077510),
        dec: Angle.Degrees(+00.68523302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7845 AB"},
        {"Henry Draper", "HD 91814"},
        {"Hipparcos Number", "HIP 51895"},
        {"Smithsonian Astrophysical Observation", "SAO 118391"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.03829502),
        dec: Angle.Degrees(+00.68597717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140669"},
        {"Hipparcos Number", "HIP 77120"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.20973524),
        dec: Angle.Degrees(+00.68683200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82903"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.12013059),
        dec: Angle.Degrees(+00.68695883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22689"},
        {"Geneva Identification System", "GEN# +0.00000884"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19131342),
        dec: Angle.Degrees(+00.68727513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26826"},
        {"Hipparcos Number", "HIP 19801"},
        {"Smithsonian Astrophysical Observation", "SAO 111683"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.65954647),
        dec: Angle.Degrees(+00.68950887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178953"},
        {"Hipparcos Number", "HIP 94190"},
        {"Smithsonian Astrophysical Observation", "SAO 124344"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.63796159),
        dec: Angle.Degrees(+00.68963778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73412"},
        {"Hipparcos Number", "HIP 42370"},
        {"Smithsonian Astrophysical Observation", "SAO 116983"},
        {"Wilson Evans Batten Catalogue", "WEB 8143"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.58520440),
        dec: Angle.Degrees(+00.69104358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 422"},
        {"Hipparcos Number", "HIP 717"},
        {"Smithsonian Astrophysical Observation", "SAO 109035"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.21766632),
        dec: Angle.Degrees(+00.69244524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66877"},
        {"Hipparcos Number", "HIP 39604"},
        {"Smithsonian Astrophysical Observation", "SAO 116329"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.39169093),
        dec: Angle.Degrees(+00.69324991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122329"},
        {"Hipparcos Number", "HIP 68486"},
        {"Smithsonian Astrophysical Observation", "SAO 120226"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.31444818),
        dec: Angle.Degrees(+00.69538351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224157"},
        {"Hipparcos Number", "HIP 117960"},
        {"Smithsonian Astrophysical Observation", "SAO 128470"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.89957740),
        dec: Angle.Degrees(+00.69583972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163035"},
        {"Hipparcos Number", "HIP 87637"},
        {"Smithsonian Astrophysical Observation", "SAO 122901"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.52231847),
        dec: Angle.Degrees(+00.69953502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57707"},
        {"Hipparcos Number", "HIP 35751"},
        {"Geneva Identification System", "GEN# +1.00057707"},
        {"Smithsonian Astrophysical Observation", "SAO 115351"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.61790366),
        dec: Angle.Degrees(+00.70095228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119650"},
        {"Hipparcos Number", "HIP 67050"},
        {"Smithsonian Astrophysical Observation", "SAO 120092"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.11299453),
        dec: Angle.Degrees(+00.70192918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154417"},
        {"Hipparcos Number", "HIP 83601"},
        {"Cincinnati Publication", "Ci 18 2279"},
        {"Geneva Identification System", "GEN# +1.00154417"},
        {"Smithsonian Astrophysical Observation", "SAO 122056"},
        {"Wilson Evans Batten Catalogue", "WEB 14137"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.32011831),
        dec: Angle.Degrees(+00.70337361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55413"},
        {"Hipparcos Number", "HIP 34870"},
        {"Smithsonian Astrophysical Observation", "SAO 115084"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.22506076),
        dec: Angle.Degrees(+00.70671364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69152"},
        {"Hipparcos Number", "HIP 40461"},
        {"Smithsonian Astrophysical Observation", "SAO 116549"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.92393954),
        dec: Angle.Degrees(+00.70816733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105323"},
        {"Hipparcos Number", "HIP 59142"},
        {"Smithsonian Astrophysical Observation", "SAO 119229"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.90745594),
        dec: Angle.Degrees(+00.70858435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290053"},
        {"Hipparcos Number", "HIP 24457"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.70731850),
        dec: Angle.Degrees(+00.70929163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80163"},
        {"Hipparcos Number", "HIP 45646"},
        {"Smithsonian Astrophysical Observation", "SAO 117583"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.56979447),
        dec: Angle.Degrees(+00.70989684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42334"},
        {"Hipparcos Number", "HIP 29258"},
        {"Smithsonian Astrophysical Observation", "SAO 113539"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.53646639),
        dec: Angle.Degrees(+00.71006279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18408",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2879 AB"},
        {"Henry Draper", "HD 24749"},
        {"Hipparcos Number", "HIP 18408"},
        {"Geneva Identification System", "GEN# +1.00024749J"},
        {"Smithsonian Astrophysical Observation", "SAO 111506"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.03498291),
        dec: Angle.Degrees(+00.71111830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124443"},
        {"Hipparcos Number", "HIP 69497"},
        {"Smithsonian Astrophysical Observation", "SAO 120350"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42458921),
        dec: Angle.Degrees(+00.71138276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222860"},
        {"Hipparcos Number", "HIP 117097"},
        {"Geneva Identification System", "GEN# +1.00222860"},
        {"Smithsonian Astrophysical Observation", "SAO 128354"},
        {"Wilson Evans Batten Catalogue", "WEB 20641"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.07590512),
        dec: Angle.Degrees(+00.71242698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8358"},
        {"Hipparcos Number", "HIP 6448"},
        {"Cincinnati Publication", "Ci 18 182"},
        {"Geneva Identification System", "GEN# +1.00008358"},
        {"Smithsonian Astrophysical Observation", "SAO 109840"},
        {"Wilson Evans Batten Catalogue", "WEB 1427"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.70983978),
        dec: Angle.Degrees(+00.71263569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107842"},
        {"Hipparcos Number", "HIP 60440"},
        {"Smithsonian Astrophysical Observation", "SAO 119368"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.87726413),
        dec: Angle.Degrees(+00.71284328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98675"},
    },
    visualMagnitude: 11.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.63620300),
        dec: Angle.Degrees(+00.71391909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132932"},
        {"Hipparcos Number", "HIP 73528"},
        {"Smithsonian Astrophysical Observation", "SAO 120797"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.43311949),
        dec: Angle.Degrees(+00.71478723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9596 A"},
        {"Henry Draper", "HD 136514"},
        {"Hipparcos Number", "HIP 75119"},
        {"Geneva Identification System", "GEN# +1.00136514"},
        {"Smithsonian Astrophysical Observation", "SAO 120955"},
        {"Wilson Evans Batten Catalogue", "WEB 12813"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.25842001),
        dec: Angle.Degrees(+00.71558981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179126"},
        {"Hipparcos Number", "HIP 94276"},
        {"Smithsonian Astrophysical Observation", "SAO 124361"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.83353368),
        dec: Angle.Degrees(+00.71572068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79921"},
        {"Smithsonian Astrophysical Observation", "SAO 121492"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.69317942),
        dec: Angle.Degrees(+00.71623921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165990"},
        {"Hipparcos Number", "HIP 88870"},
        {"Smithsonian Astrophysical Observation", "SAO 123166"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15331810),
        dec: Angle.Degrees(+00.71633083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129956"},
        {"Hipparcos Number", "HIP 72154"},
        {"Geneva Identification System", "GEN# +1.00129956"},
        {"Smithsonian Astrophysical Observation", "SAO 120642"},
        {"Wilson Evans Batten Catalogue", "WEB 12415"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.37595224),
        dec: Angle.Degrees(+00.71729003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41761"},
        {"Smithsonian Astrophysical Observation", "SAO 116846"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.73553486),
        dec: Angle.Degrees(+00.71808918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13885"},
        {"Hipparcos Number", "HIP 10482"},
        {"Smithsonian Astrophysical Observation", "SAO 110428"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.79000705),
        dec: Angle.Degrees(+00.72019555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32263"},
        {"Hipparcos Number", "HIP 23408"},
        {"Fundamental Katalog 5th Edition", "FK5 2376"},
        {"Geneva Identification System", "GEN# +1.00032263"},
        {"Smithsonian Astrophysical Observation", "SAO 112334"},
        {"Wilson Evans Batten Catalogue", "WEB 4545"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.45979252),
        dec: Angle.Degrees(+00.72216704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220890"},
        {"Hipparcos Number", "HIP 115784"},
        {"Smithsonian Astrophysical Observation", "SAO 128193"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85286396),
        dec: Angle.Degrees(+00.72232000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134408"},
        {"Hipparcos Number", "HIP 74198"},
        {"Geneva Identification System", "GEN# +1.00134408"},
        {"Smithsonian Astrophysical Observation", "SAO 120872"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.42377816),
        dec: Angle.Degrees(+00.72307383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98399"},
        {"Hipparcos Number", "HIP 55277"},
        {"Smithsonian Astrophysical Observation", "SAO 118783"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.81493581),
        dec: Angle.Degrees(+00.72334393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114349"},
        {"Cincinnati Publication", "Ci 20 1404"},
        {"Geneva Identification System", "GEN# -0.00004470J"},
        {"Wilson Evans Batten Catalogue", "WEB 20303"},
    },
    visualMagnitude: 12.41,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)09, 33.6600),
        dec: Angle.DegreesMinutesSeconds((int)+00, (int)43, 26.400)
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
    primaryId: "HIP 27452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38856"},
        {"Hipparcos Number", "HIP 27452"},
        {"Celescope Catalog", "CEL 986"},
        {"Geneva Identification System", "GEN# +1.00038856"},
        {"Smithsonian Astrophysical Observation", "SAO 113167"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.19153471),
        dec: Angle.Degrees(+00.72556436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200747"},
        {"Hipparcos Number", "HIP 104090"},
        {"Geneva Identification System", "GEN# +1.00200747"},
        {"Smithsonian Astrophysical Observation", "SAO 126532"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.33010908),
        dec: Angle.Degrees(+00.72706205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7276 A"},
        {"Henry Draper", "HD 79873"},
        {"Hipparcos Number", "HIP 45521"},
        {"Smithsonian Astrophysical Observation", "SAO 117553"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16679539),
        dec: Angle.Degrees(+00.72907888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131787"},
        {"Hipparcos Number", "HIP 73033"},
        {"Geneva Identification System", "GEN# +1.00131787"},
        {"Smithsonian Astrophysical Observation", "SAO 120741"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.88796224),
        dec: Angle.Degrees(+00.73164001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37054"},
        {"Hipparcos Number", "HIP 26276"},
        {"Celescope Catalog", "CEL 844"},
        {"Geneva Identification System", "GEN# +1.00037054"},
        {"Smithsonian Astrophysical Observation", "SAO 112937"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.93317566),
        dec: Angle.Degrees(+00.73341720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81503"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.70928759),
        dec: Angle.Degrees(+00.73465930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3054 A"},
        {"Henry Draper", "HD 26573"},
        {"Hipparcos Number", "HIP 19611"},
        {"Geneva Identification System", "GEN# +1.00026573A"},
        {"Smithsonian Astrophysical Observation", "SAO 111659"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.03867012),
        dec: Angle.Degrees(+00.73555565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4018"},
        {"Hipparcos Number", "HIP 3355"},
        {"Smithsonian Astrophysical Observation", "SAO 109397"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67879194),
        dec: Angle.Degrees(+00.73635417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7982 A"},
        {"Henry Draper", "HD 94672"},
        {"Hipparcos Number", "HIP 53423"},
        {"Geneva Identification System", "GEN# +1.00094672"},
        {"Smithsonian Astrophysical Observation", "SAO 118574"},
        {"Wilson Evans Batten Catalogue", "WEB 9696"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.92640433),
        dec: Angle.Degrees(+00.73693069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83274"},
        {"Hipparcos Number", "HIP 47212"},
        {"Geneva Identification System", "GEN# +1.00083274"},
        {"Smithsonian Astrophysical Observation", "SAO 117808"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.32315743),
        dec: Angle.Degrees(+00.73841727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2416 AB"},
        {"Henry Draper", "HD 20115"},
        {"Hipparcos Number", "HIP 15058"},
        {"Geneva Identification System", "GEN# +1.00020115"},
        {"Smithsonian Astrophysical Observation", "SAO 111062"},
        {"Wilson Evans Batten Catalogue", "WEB 2897"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.51185230),
        dec: Angle.Degrees(+00.73938883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193374"},
        {"Hipparcos Number", "HIP 100265"},
        {"Geneva Identification System", "GEN# +1.00193374"},
        {"Smithsonian Astrophysical Observation", "SAO 125689"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.05674691),
        dec: Angle.Degrees(+00.74088813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10382"},
        {"Hipparcos Number", "HIP 7871"},
        {"Smithsonian Astrophysical Observation", "SAO 110060"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32193315),
        dec: Angle.Degrees(+00.74263011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114266"},
        {"Hipparcos Number", "HIP 64207"},
        {"Smithsonian Astrophysical Observation", "SAO 119795"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.38396545),
        dec: Angle.Degrees(+00.74314105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138920"},
        {"Hipparcos Number", "HIP 76296"},
        {"Smithsonian Astrophysical Observation", "SAO 121073"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.78490674),
        dec: Angle.Degrees(+00.74620325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42638"},
        {"Hipparcos Number", "HIP 29420"},
        {"Smithsonian Astrophysical Observation", "SAO 113579"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96908516),
        dec: Angle.Degrees(+00.75071045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186550"},
        {"Hipparcos Number", "HIP 97177"},
        {"Geneva Identification System", "GEN# +1.00186550"},
        {"Smithsonian Astrophysical Observation", "SAO 125016"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.26889564),
        dec: Angle.Degrees(+00.75119196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25059"},
        {"Hipparcos Number", "HIP 18612"},
        {"Geneva Identification System", "GEN# +1.00025059"},
        {"Smithsonian Astrophysical Observation", "SAO 111541"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.73375514),
        dec: Angle.Degrees(+00.75136532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30978"},
        {"Hipparcos Number", "HIP 22634"},
        {"Geneva Identification System", "GEN# +1.00030978J"},
        {"Smithsonian Astrophysical Observation", "SAO 112161"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.04554442),
        dec: Angle.Degrees(+00.75224902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207653"},
        {"Hipparcos Number", "HIP 107816"},
        {"Smithsonian Astrophysical Observation", "SAO 127103"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.63621372),
        dec: Angle.Degrees(+00.75300489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42823"},
        {"Hipparcos Number", "HIP 29506"},
        {"Smithsonian Astrophysical Observation", "SAO 113594"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24587085),
        dec: Angle.Degrees(+00.75668490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141025"},
        {"Hipparcos Number", "HIP 77285"},
        {"Geneva Identification System", "GEN# +1.00141025A"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.68308539),
        dec: Angle.Degrees(+00.75708792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160453"},
        {"Hipparcos Number", "HIP 86460"},
        {"Smithsonian Astrophysical Observation", "SAO 122624"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98756808),
        dec: Angle.Degrees(+00.75817145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9205"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60704894),
        dec: Angle.Degrees(+00.75846664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104864"},
        {"Hipparcos Number", "HIP 58888"},
        {"Smithsonian Astrophysical Observation", "SAO 119205"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16446034),
        dec: Angle.Degrees(+00.75957621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72212"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.53333814),
        dec: Angle.Degrees(+00.76067412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102262"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81153763),
        dec: Angle.Degrees(+00.76190390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57152",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8277 B"},
        {"Henry Draper", "HD 101845B"},
        {"Hipparcos Number", "HIP 57152"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.82100445),
        dec: Angle.Degrees(+00.76303929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74331"},
        {"Hipparcos Number", "HIP 42811"},
        {"Smithsonian Astrophysical Observation", "SAO 117055"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.85142207),
        dec: Angle.Degrees(+00.76355370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2500"},
        {"Hipparcos Number", "HIP 2257"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.18995306),
        dec: Angle.Degrees(+00.76716164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215044"},
        {"Hipparcos Number", "HIP 112103"},
        {"Geneva Identification System", "GEN# +1.00215044"},
        {"Smithsonian Astrophysical Observation", "SAO 127700"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.59916948),
        dec: Angle.Degrees(+00.77050253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207796"},
        {"Hipparcos Number", "HIP 107886"},
        {"Smithsonian Astrophysical Observation", "SAO 127114"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.89054332),
        dec: Angle.Degrees(+00.77058466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49330"},
        {"Hipparcos Number", "HIP 32586"},
        {"Geneva Identification System", "GEN# +1.00049330"},
        {"Smithsonian Astrophysical Observation", "SAO 114432"},
        {"Wilson Evans Batten Catalogue", "WEB 6573"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.98861804),
        dec: Angle.Degrees(+00.77611840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4624",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 818 A"},
        {"Henry Draper", "HD 5780"},
        {"Hipparcos Number", "HIP 4624"},
        {"Geneva Identification System", "GEN# +1.00005780A"},
        {"Smithsonian Astrophysical Observation", "SAO 109577"},
        {"Wilson Evans Batten Catalogue", "WEB 861"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.84719408),
        dec: Angle.Degrees(+00.77903236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39557"},
        {"Hipparcos Number", "HIP 27842"},
        {"Geneva Identification System", "GEN# +1.00039557"},
        {"Smithsonian Astrophysical Observation", "SAO 113242"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.36306952),
        dec: Angle.Degrees(+00.77921626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84969"},
        {"Hipparcos Number", "HIP 48153"},
        {"Smithsonian Astrophysical Observation", "SAO 117926"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.23290105),
        dec: Angle.Degrees(+00.78027814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11339 AB"},
        {"Henry Draper", "HD 169725"},
        {"Hipparcos Number", "HIP 90347"},
        {"Smithsonian Astrophysical Observation", "SAO 123471"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.51400398),
        dec: Angle.Degrees(+00.78048052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116646"},
        {"Smithsonian Astrophysical Observation", "SAO 128294"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.57812781),
        dec: Angle.Degrees(+00.78100861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15454"},
        {"Hipparcos Number", "HIP 11587"},
        {"Smithsonian Astrophysical Observation", "SAO 110562"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.33359611),
        dec: Angle.Degrees(+00.78281826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70199"},
        {"Geneva Identification System", "GEN# +0.00102916"},
        {"Smithsonian Astrophysical Observation", "SAO 120412"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.43864810),
        dec: Angle.Degrees(+00.78313733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26184"},
        {"Hipparcos Number", "HIP 19347"},
        {"Geneva Identification System", "GEN# +1.00026184"},
        {"Smithsonian Astrophysical Observation", "SAO 111626"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.17458572),
        dec: Angle.Degrees(+00.78315436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41516"},
        {"Smithsonian Astrophysical Observation", "SAO 116790"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.00249647),
        dec: Angle.Degrees(+00.78588099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4623",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 818 B"},
        {"Henry Draper", "HD 5780B"},
        {"Hipparcos Number", "HIP 4623"},
        {"Smithsonian Astrophysical Observation", "SAO 109576"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.84399752),
        dec: Angle.Degrees(+00.78600450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4062 AB"},
        {"Henry Draper", "HD 35926"},
        {"Hipparcos Number", "HIP 25592"},
        {"Geneva Identification System", "GEN# +1.00035926J"},
        {"Smithsonian Astrophysical Observation", "SAO 112798"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04216345),
        dec: Angle.Degrees(+00.78722928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120981"},
        {"Hipparcos Number", "HIP 67754"},
        {"Smithsonian Astrophysical Observation", "SAO 120148"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.20804364),
        dec: Angle.Degrees(+00.78936513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5319"},
        {"Hipparcos Number", "HIP 4297"},
        {"Geneva Identification System", "GEN# +1.00005319"},
        {"Smithsonian Astrophysical Observation", "SAO 109532"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.75584534),
        dec: Angle.Degrees(+00.78967656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56036"},
        {"Hipparcos Number", "HIP 35098"},
        {"Geneva Identification System", "GEN# +1.00056036"},
        {"Smithsonian Astrophysical Observation", "SAO 115158"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87259157),
        dec: Angle.Degrees(+00.79296105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79354"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.93574838),
        dec: Angle.Degrees(+00.79412655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22696"},
        {"Hipparcos Number", "HIP 17024"},
        {"Smithsonian Astrophysical Observation", "SAO 111322"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.74475769),
        dec: Angle.Degrees(+00.79656988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135599"},
        {"Hipparcos Number", "HIP 74702"},
        {"Smithsonian Astrophysical Observation", "SAO 120922"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.99609545),
        dec: Angle.Degrees(+00.79669425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170294"},
        {"Hipparcos Number", "HIP 90548"},
        {"Geneva Identification System", "GEN# +1.00170294"},
        {"Smithsonian Astrophysical Observation", "SAO 123536"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.14371582),
        dec: Angle.Degrees(+00.79713874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35657"},
        {"Hipparcos Number", "HIP 25432"},
        {"Celescope Catalog", "CEL 696"},
        {"Geneva Identification System", "GEN# +1.00035657"},
        {"Smithsonian Astrophysical Observation", "SAO 112763"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.59327574),
        dec: Angle.Degrees(+00.79810760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287873"},
        {"Hipparcos Number", "HIP 25430"},
        {"Geneva Identification System", "GEN# +1.00287873"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.58351432),
        dec: Angle.Degrees(+00.79909308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123980"},
        {"Hipparcos Number", "HIP 69265"},
        {"Smithsonian Astrophysical Observation", "SAO 120326"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.69907867),
        dec: Angle.Degrees(+00.79966007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51481"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.72677348),
        dec: Angle.Degrees(+00.80103796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289394"},
        {"Hipparcos Number", "HIP 33238"},
        {"Smithsonian Astrophysical Observation", "SAO 114609"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.73069552),
        dec: Angle.Degrees(+00.80283572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100437"},
        {"Hipparcos Number", "HIP 56377"},
        {"Smithsonian Astrophysical Observation", "SAO 118919"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.34800376),
        dec: Angle.Degrees(+00.80340883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209749"},
        {"Hipparcos Number", "HIP 109073"},
        {"Smithsonian Astrophysical Observation", "SAO 127286"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.43535584),
        dec: Angle.Degrees(+00.80574464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85304"},
        {"Hipparcos Number", "HIP 48313"},
        {"Fundamental Katalog 5th Edition", "FK5 4875"},
        {"Geneva Identification System", "GEN# +1.00085304"},
        {"Smithsonian Astrophysical Observation", "SAO 117944"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.73962713),
        dec: Angle.Degrees(+00.80643486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169285"},
        {"Hipparcos Number", "HIP 90161"},
        {"Smithsonian Astrophysical Observation", "SAO 123426"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98341564),
        dec: Angle.Degrees(+00.80737870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57548"},
        {"Cincinnati Publication", "Ci 20 662"},
        {"Geneva Identification System", "GEN# +6.10010447"},
        {"Wilson Evans Batten Catalogue", "WEB 10335"},
    },
    visualMagnitude: 11.12,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.93351286),
        dec: Angle.Degrees(+00.80752617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 605.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1219.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135979"},
        {"Hipparcos Number", "HIP 74872"},
        {"Smithsonian Astrophysical Observation", "SAO 120936"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.52332638),
        dec: Angle.Degrees(+00.80868583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166686"},
        {"Hipparcos Number", "HIP 89151"},
        {"Smithsonian Astrophysical Observation", "SAO 123230"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.92637547),
        dec: Angle.Degrees(+00.81190830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10930"},
        {"Hipparcos Number", "HIP 8328"},
        {"Geneva Identification System", "GEN# +1.00010930"},
        {"Smithsonian Astrophysical Observation", "SAO 110128"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.84024548),
        dec: Angle.Degrees(+00.81219918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45152"},
        {"Hipparcos Number", "HIP 30601"},
        {"Geneva Identification System", "GEN# +1.00045152"},
        {"Smithsonian Astrophysical Observation", "SAO 113872"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.46414245),
        dec: Angle.Degrees(+00.81273992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25881"},
        {"Hipparcos Number", "HIP 19130"},
        {"Geneva Identification System", "GEN# +1.00025881"},
        {"Smithsonian Astrophysical Observation", "SAO 111603"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51382830),
        dec: Angle.Degrees(+00.81299127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41755"},
        {"Hipparcos Number", "HIP 28990"},
        {"Smithsonian Astrophysical Observation", "SAO 113466"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.76261072),
        dec: Angle.Degrees(+00.81764431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88866"},
        {"Hipparcos Number", "HIP 50209"},
        {"Smithsonian Astrophysical Observation", "SAO 118185"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.75287991),
        dec: Angle.Degrees(+00.81922414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145204"},
        {"Hipparcos Number", "HIP 79187"},
        {"Smithsonian Astrophysical Observation", "SAO 121396"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.42253884),
        dec: Angle.Degrees(+00.81989400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64632"},
        {"Hipparcos Number", "HIP 38651"},
        {"Geneva Identification System", "GEN# +1.00064632"},
        {"Smithsonian Astrophysical Observation", "SAO 116106"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.71332107),
        dec: Angle.Degrees(+00.82012022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8639"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.85597125),
        dec: Angle.Degrees(+00.82109897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157983"},
        {"Hipparcos Number", "HIP 85356"},
        {"Smithsonian Astrophysical Observation", "SAO 122382"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.63152482),
        dec: Angle.Degrees(+00.82212088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86893"},
        {"Smithsonian Astrophysical Observation", "SAO 122700"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.32113707),
        dec: Angle.Degrees(+00.82311377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37885"},
        {"Geneva Identification System", "GEN# +0.00101900"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.47047670),
        dec: Angle.Degrees(+00.82312368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120967"},
        {"Hipparcos Number", "HIP 67743"},
        {"Smithsonian Astrophysical Observation", "SAO 120146"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.15951966),
        dec: Angle.Degrees(+00.82500622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288690"},
        {"Hipparcos Number", "HIP 30683"},
        {"Smithsonian Astrophysical Observation", "SAO 113895"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.72052576),
        dec: Angle.Degrees(+00.82559526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71634"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.77009425),
        dec: Angle.Degrees(+00.82763880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289531"},
        {"Hipparcos Number", "HIP 33877"},
    },
    visualMagnitude: 10.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48464453),
        dec: Angle.Degrees(+00.82775715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71431"},
        {"Hipparcos Number", "HIP 41471"},
        {"Geneva Identification System", "GEN# +1.00071431"},
        {"Smithsonian Astrophysical Observation", "SAO 116780"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88119458),
        dec: Angle.Degrees(+00.82829737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127167"},
        {"Hipparcos Number", "HIP 70894"},
        {"Fundamental Katalog 5th Edition", "FK5 3145"},
        {"Geneva Identification System", "GEN# +1.00127167"},
        {"Smithsonian Astrophysical Observation", "SAO 120499"},
        {"Wilson Evans Batten Catalogue", "WEB 12272"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.46045655),
        dec: Angle.Degrees(+00.82891135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13373"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.01561564),
        dec: Angle.Degrees(+00.82976034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86749"},
        {"Hipparcos Number", "HIP 49058"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.15305107),
        dec: Angle.Degrees(+00.82980307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10593"},
        {"Smithsonian Astrophysical Observation", "SAO 110439"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.09796814),
        dec: Angle.Degrees(+00.83272790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37593"},
        {"Hipparcos Number", "HIP 26633"},
        {"Smithsonian Astrophysical Observation", "SAO 113011"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.90828651),
        dec: Angle.Degrees(+00.83388233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35612"},
        {"Hipparcos Number", "HIP 25411"},
        {"Geneva Identification System", "GEN# +1.00035612"},
        {"Smithsonian Astrophysical Observation", "SAO 112756"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.52498487),
        dec: Angle.Degrees(+00.83399371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43301"},
        {"Hipparcos Number", "HIP 29715"},
        {"Smithsonian Astrophysical Observation", "SAO 113649"},
        {"Wilson Evans Batten Catalogue", "WEB 5856"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.88262947),
        dec: Angle.Degrees(+00.83498942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39953"},
        {"Hipparcos Number", "HIP 28056"},
        {"Smithsonian Astrophysical Observation", "SAO 113276"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.98883778),
        dec: Angle.Degrees(+00.83614553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174240"},
        {"Hipparcos Number", "HIP 92386"},
        {"Geneva Identification System", "GEN# +1.00174240"},
        {"Smithsonian Astrophysical Observation", "SAO 123947"},
        {"Wilson Evans Batten Catalogue", "WEB 15953"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.40493577),
        dec: Angle.Degrees(+00.83623568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137691"},
        {"Hipparcos Number", "HIP 75656"},
        {"Smithsonian Astrophysical Observation", "SAO 121009"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.85059826),
        dec: Angle.Degrees(+00.83817598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157415"},
        {"Hipparcos Number", "HIP 85060"},
        {"Geneva Identification System", "GEN# +1.00157415"},
        {"Smithsonian Astrophysical Observation", "SAO 122332"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.75884766),
        dec: Angle.Degrees(+00.84048310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171977"},
        {"Hipparcos Number", "HIP 91320"},
        {"Geneva Identification System", "GEN# +1.00171977"},
        {"Smithsonian Astrophysical Observation", "SAO 123717"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.39840771),
        dec: Angle.Degrees(+00.84066379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45357"},
        {"Hipparcos Number", "HIP 30692"},
        {"Geneva Identification System", "GEN# +1.00045357"},
        {"Smithsonian Astrophysical Observation", "SAO 113896"},
        {"Wilson Evans Batten Catalogue", "WEB 6120"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74511089),
        dec: Angle.Degrees(+00.84104075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72561"},
        {"Geneva Identification System", "GEN# +9.80066030"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.53320767),
        dec: Angle.Degrees(+00.84113133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -286.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168413"},
        {"Hipparcos Number", "HIP 89789"},
        {"Geneva Identification System", "GEN# +1.00168413"},
        {"Smithsonian Astrophysical Observation", "SAO 123355"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.85700150),
        dec: Angle.Degrees(+00.84194917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187619"},
        {"Hipparcos Number", "HIP 97662"},
        {"Geneva Identification System", "GEN# +1.00187619"},
        {"Smithsonian Astrophysical Observation", "SAO 125123"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.72829718),
        dec: Angle.Degrees(+00.84435005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105615"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.87027204),
        dec: Angle.Degrees(+00.84496473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 917"},
        {"Hipparcos Number", "HIP 1087"},
        {"Smithsonian Astrophysical Observation", "SAO 109073"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.38492029),
        dec: Angle.Degrees(+00.84702277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14164"},
        {"Smithsonian Astrophysical Observation", "SAO 110925"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.65672361),
        dec: Angle.Degrees(+00.84867732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207795"},
        {"Hipparcos Number", "HIP 107895"},
        {"Cincinnati Publication", "Ci 18 2838"},
        {"Geneva Identification System", "GEN# +1.00207795"},
        {"Smithsonian Astrophysical Observation", "SAO 127116"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.91349637),
        dec: Angle.Degrees(+00.84958446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 334.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8895 A"},
        {"Henry Draper", "HD 116695"},
        {"Hipparcos Number", "HIP 65483"},
        {"Smithsonian Astrophysical Observation", "SAO 119918"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.31753414),
        dec: Angle.Degrees(+00.84987467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127889"},
        {"Hipparcos Number", "HIP 71226"},
        {"Smithsonian Astrophysical Observation", "SAO 120531"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.47854804),
        dec: Angle.Degrees(+00.85065936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15313 AB"},
        {"Henry Draper", "HD 207136"},
        {"Hipparcos Number", "HIP 107544"},
        {"Smithsonian Astrophysical Observation", "SAO 127055"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.72290114),
        dec: Angle.Degrees(+00.85095745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79708"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01563603),
        dec: Angle.Degrees(+00.85148930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19189"},
        {"Hipparcos Number", "HIP 14358"},
        {"Fundamental Katalog 5th Edition", "FK5 4281"},
        {"Smithsonian Astrophysical Observation", "SAO 110952"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.31259695),
        dec: Angle.Degrees(+00.85323366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60137"},
        {"Hipparcos Number", "HIP 36724"},
        {"Fundamental Katalog 5th Edition", "FK5 4678"},
        {"Geneva Identification System", "GEN# +1.00060137"},
        {"Smithsonian Astrophysical Observation", "SAO 115613"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.29880381),
        dec: Angle.Degrees(+00.85497787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138308"},
        {"Hipparcos Number", "HIP 75999"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.81707758),
        dec: Angle.Degrees(+00.85530552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43102"},
        {"Hipparcos Number", "HIP 29613"},
        {"Smithsonian Astrophysical Observation", "SAO 113619"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.60782840),
        dec: Angle.Degrees(+00.85977301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121588"},
        {"Hipparcos Number", "HIP 68086"},
        {"Smithsonian Astrophysical Observation", "SAO 120184"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.10811660),
        dec: Angle.Degrees(+00.86198825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92706"},
        {"Hipparcos Number", "HIP 52377"},
        {"Smithsonian Astrophysical Observation", "SAO 118440"},
        {"Wilson Evans Batten Catalogue", "WEB 9532"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.59091031),
        dec: Angle.Degrees(+00.86212606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35305"},
        {"Hipparcos Number", "HIP 25241"},
        {"Geneva Identification System", "GEN# +1.00035305"},
        {"Smithsonian Astrophysical Observation", "SAO 112715"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96406370),
        dec: Angle.Degrees(+00.86286056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27572"},
        {"Hipparcos Number", "HIP 20322"},
        {"Smithsonian Astrophysical Observation", "SAO 111767"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.30458271),
        dec: Angle.Degrees(+00.86376954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31710"},
        {"Hipparcos Number", "HIP 23086"},
        {"Geneva Identification System", "GEN# +1.00031710"},
        {"Smithsonian Astrophysical Observation", "SAO 112276"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.53123986),
        dec: Angle.Degrees(+00.86586568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28830",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4662 A"},
        {"Henry Draper", "HD 41433"},
        {"Hipparcos Number", "HIP 28830"},
        {"Geneva Identification System", "GEN# +1.00041433A"},
        {"Smithsonian Astrophysical Observation", "SAO 113435"},
        {"Wilson Evans Batten Catalogue", "WEB 5641"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.28569489),
        dec: Angle.Degrees(+00.86652087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99585",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13506 AB"},
        {"Henry Draper", "HD 191984"},
        {"Hipparcos Number", "HIP 99585"},
        {"Geneva Identification System", "GEN# +1.00191984J"},
        {"Wilson Evans Batten Catalogue", "WEB 17821"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.14634666),
        dec: Angle.Degrees(+00.86710230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140256"},
        {"Hipparcos Number", "HIP 76931"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.64005149),
        dec: Angle.Degrees(+00.86842509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 964"},
        {"Hipparcos Number", "HIP 1121"},
        {"Smithsonian Astrophysical Observation", "SAO 109080"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.50534532),
        dec: Angle.Degrees(+00.86872588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103946"},
        {"Hipparcos Number", "HIP 58375"},
        {"Smithsonian Astrophysical Observation", "SAO 119138"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.55403750),
        dec: Angle.Degrees(+00.86930668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173671"},
        {"Hipparcos Number", "HIP 92119"},
        {"Smithsonian Astrophysical Observation", "SAO 123905"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.62424487),
        dec: Angle.Degrees(+00.86984827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175037"},
        {"Hipparcos Number", "HIP 92711"},
        {"Smithsonian Astrophysical Observation", "SAO 124011"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.36640982),
        dec: Angle.Degrees(+00.87029324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211648"},
        {"Hipparcos Number", "HIP 110132"},
        {"Smithsonian Astrophysical Observation", "SAO 127441"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62971239),
        dec: Angle.Degrees(+00.87146362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43408"},
        {"Hipparcos Number", "HIP 29765"},
        {"Geneva Identification System", "GEN# +1.00043408"},
        {"Renson", "Renson 11520"},
        {"Smithsonian Astrophysical Observation", "SAO 113661"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.02141167),
        dec: Angle.Degrees(+00.87604430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210947"},
        {"Hipparcos Number", "HIP 109748"},
        {"Geneva Identification System", "GEN# +1.00210947"},
        {"Smithsonian Astrophysical Observation", "SAO 127386"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.45989716),
        dec: Angle.Degrees(+00.87651558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221273"},
        {"Hipparcos Number", "HIP 116034"},
        {"Smithsonian Astrophysical Observation", "SAO 128215"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66871832),
        dec: Angle.Degrees(+00.87756263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80584"},
        {"Hipparcos Number", "HIP 45846"},
        {"Smithsonian Astrophysical Observation", "SAO 117609"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.20588801),
        dec: Angle.Degrees(+00.87959367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190872"},
        {"Hipparcos Number", "HIP 99087"},
        {"Smithsonian Astrophysical Observation", "SAO 125459"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.73746667),
        dec: Angle.Degrees(+00.88216892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194990"},
        {"Hipparcos Number", "HIP 100996"},
        {"Smithsonian Astrophysical Observation", "SAO 125847"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.14987593),
        dec: Angle.Degrees(+00.88351502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138369"},
        {"Hipparcos Number", "HIP 76031"},
        {"Geneva Identification System", "GEN# +1.00138369"},
        {"Smithsonian Astrophysical Observation", "SAO 121042"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92870197),
        dec: Angle.Degrees(+00.88374435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76399"},
        {"Hipparcos Number", "HIP 43854"},
        {"Smithsonian Astrophysical Observation", "SAO 117275"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.98617541),
        dec: Angle.Degrees(+00.88602278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287748"},
        {"Hipparcos Number", "HIP 24863"},
        {"Smithsonian Astrophysical Observation", "SAO 112635"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.95121277),
        dec: Angle.Degrees(+00.88669681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97661"},
        {"Hipparcos Number", "HIP 54889"},
        {"Fundamental Katalog 5th Edition", "FK5 4990"},
        {"Smithsonian Astrophysical Observation", "SAO 118739"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.58399200),
        dec: Angle.Degrees(+00.88675474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70364"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95304516),
        dec: Angle.Degrees(+00.88862831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133234"},
        {"Hipparcos Number", "HIP 73655"},
        {"Smithsonian Astrophysical Observation", "SAO 120813"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.84333740),
        dec: Angle.Degrees(+00.88970987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46769"},
        {"Hipparcos Number", "HIP 31446"},
        {"Geneva Identification System", "GEN# +1.00046769"},
        {"Smithsonian Astrophysical Observation", "SAO 114097"},
        {"Wilson Evans Batten Catalogue", "WEB 6293"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.81595606),
        dec: Angle.Degrees(+00.89022204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151783"},
        {"Hipparcos Number", "HIP 82334"},
        {"Geneva Identification System", "GEN# +1.00151783"},
        {"Smithsonian Astrophysical Observation", "SAO 121882"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.35676632),
        dec: Angle.Degrees(+00.89063282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84981"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.53553790),
        dec: Angle.Degrees(+00.89080579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140815"},
        {"Hipparcos Number", "HIP 77186"},
        {"Geneva Identification System", "GEN# +1.00140815"},
        {"Smithsonian Astrophysical Observation", "SAO 121173"},
        {"Wilson Evans Batten Catalogue", "WEB 13082"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.41458802),
        dec: Angle.Degrees(+00.89104971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140849"},
        {"Hipparcos Number", "HIP 77208"},
        {"Smithsonian Astrophysical Observation", "SAO 121175"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46825442),
        dec: Angle.Degrees(+00.89239409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53512"},
        {"Hipparcos Number", "HIP 34183"},
        {"Smithsonian Astrophysical Observation", "SAO 114897"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.33961454),
        dec: Angle.Degrees(+00.89574705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80367"},
        {"Hipparcos Number", "HIP 45737"},
        {"Cincinnati Publication", "Ci 18 1099"},
        {"Geneva Identification System", "GEN# +1.00080367"},
        {"Smithsonian Astrophysical Observation", "SAO 117589"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.86830215),
        dec: Angle.Degrees(+00.89736617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18039"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.83975080),
        dec: Angle.Degrees(+00.89929264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10642"},
        {"Hipparcos Number", "HIP 8080"},
        {"Smithsonian Astrophysical Observation", "SAO 110091"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.94543707),
        dec: Angle.Degrees(+00.90252092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20214"},
        {"Hipparcos Number", "HIP 15123"},
        {"Smithsonian Astrophysical Observation", "SAO 111074"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.74766956),
        dec: Angle.Degrees(+00.90298255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222733"},
        {"Hipparcos Number", "HIP 117013"},
        {"Geneva Identification System", "GEN# +1.00222733"},
        {"Smithsonian Astrophysical Observation", "SAO 128344"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.81111156),
        dec: Angle.Degrees(+00.90463180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162163"},
        {"Hipparcos Number", "HIP 87244"},
        {"Smithsonian Astrophysical Observation", "SAO 122793"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.39126620),
        dec: Angle.Degrees(+00.90624589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37592"},
        {"Hipparcos Number", "HIP 26637"},
        {"Geneva Identification System", "GEN# +1.00037592"},
        {"Smithsonian Astrophysical Observation", "SAO 113013"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93021177),
        dec: Angle.Degrees(+00.90757648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44947"},
        {"Hipparcos Number", "HIP 30500"},
        {"Geneva Identification System", "GEN# +1.00044947"},
        {"Renson", "Renson 11910"},
        {"Smithsonian Astrophysical Observation", "SAO 113837"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.17946475),
        dec: Angle.Degrees(+00.90851876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102106"},
        {"Hipparcos Number", "HIP 57317"},
        {"Smithsonian Astrophysical Observation", "SAO 119027"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.28003914),
        dec: Angle.Degrees(+00.90948712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4937"},
        {"Hipparcos Number", "HIP 4007"},
        {"Smithsonian Astrophysical Observation", "SAO 109508"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.85888522),
        dec: Angle.Degrees(+00.91003722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21032"},
        {"Hipparcos Number", "HIP 15800"},
        {"Fundamental Katalog 5th Edition", "FK5 2239"},
        {"Geneva Identification System", "GEN# +1.00021032"},
        {"Smithsonian Astrophysical Observation", "SAO 111162"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90128167),
        dec: Angle.Degrees(+00.91031067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7551"},
        {"Hipparcos Number", "HIP 5886"},
        {"Fundamental Katalog 5th Edition", "FK5 4111"},
        {"Geneva Identification System", "GEN# +1.00007551"},
        {"Smithsonian Astrophysical Observation", "SAO 109764"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.89843609),
        dec: Angle.Degrees(+00.91244873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181555"},
        {"Hipparcos Number", "HIP 95112"},
        {"Geneva Identification System", "GEN# +1.00181555"},
        {"Smithsonian Astrophysical Observation", "SAO 124531"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.23454341),
        dec: Angle.Degrees(+00.91496001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51956"},
        {"Hipparcos Number", "HIP 33657"},
        {"Geneva Identification System", "GEN# +1.00051956"},
        {"Smithsonian Astrophysical Observation", "SAO 114736"},
        {"Wilson Evans Batten Catalogue", "WEB 6763"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.88228753),
        dec: Angle.Degrees(+00.91677784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87806"},
        {"Hipparcos Number", "HIP 49613"},
        {"Fundamental Katalog 5th Edition", "FK5 4902"},
        {"Smithsonian Astrophysical Observation", "SAO 118120"},
        {"Wilson Evans Batten Catalogue", "WEB 9149"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88892919),
        dec: Angle.Degrees(+00.91833824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63093"},
        {"Hipparcos Number", "HIP 37990"},
        {"Geneva Identification System", "GEN# +1.00063093"},
        {"Smithsonian Astrophysical Observation", "SAO 115930"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.79119312),
        dec: Angle.Degrees(+00.91877657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77778"},
        {"Hipparcos Number", "HIP 44553"},
        {"Geneva Identification System", "GEN# +1.00077778"},
        {"Smithsonian Astrophysical Observation", "SAO 117400"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.16575463),
        dec: Angle.Degrees(+00.91881456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121151"},
        {"Hipparcos Number", "HIP 67828"},
        {"Smithsonian Astrophysical Observation", "SAO 120156"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.41531162),
        dec: Angle.Degrees(+00.91947490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153531"},
        {"Hipparcos Number", "HIP 83188"},
        {"Smithsonian Astrophysical Observation", "SAO 121986"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03108961),
        dec: Angle.Degrees(+00.92072804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17616"},
        {"Hipparcos Number", "HIP 13183"},
        {"Fundamental Katalog 5th Edition", "FK5 2193"},
        {"Geneva Identification System", "GEN# +1.00017616"},
        {"Smithsonian Astrophysical Observation", "SAO 110775"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.40783393),
        dec: Angle.Degrees(+00.92103500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13164"},
        {"Hipparcos Number", "HIP 9994"},
        {"Smithsonian Astrophysical Observation", "SAO 110364"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.17395549),
        dec: Angle.Degrees(+00.92922278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219114"},
        {"Hipparcos Number", "HIP 114644"},
        {"Geneva Identification System", "GEN# +1.00219114"},
        {"Smithsonian Astrophysical Observation", "SAO 128043"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.36832105),
        dec: Angle.Degrees(+00.93062170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12508"},
        {"Smithsonian Astrophysical Observation", "SAO 110681"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.24307258),
        dec: Angle.Degrees(+00.93199086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178857"},
        {"Hipparcos Number", "HIP 94167"},
        {"Smithsonian Astrophysical Observation", "SAO 124337"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.53038597),
        dec: Angle.Degrees(+00.93202710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4312"},
        {"Geneva Identification System", "GEN# +0.00000143"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.80046465),
        dec: Angle.Degrees(+00.93295838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24195"},
        {"Hipparcos Number", "HIP 18028"},
        {"Geneva Identification System", "GEN# +1.00024195"},
        {"Renson", "Renson 6220"},
        {"Smithsonian Astrophysical Observation", "SAO 111463"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.79288182),
        dec: Angle.Degrees(+00.93357274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158419"},
        {"Hipparcos Number", "HIP 85566"},
        {"Smithsonian Astrophysical Observation", "SAO 122423"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30176706),
        dec: Angle.Degrees(+00.93492623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87741"},
        {"Hipparcos Number", "HIP 49558"},
        {"Smithsonian Astrophysical Observation", "SAO 118114"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77640554),
        dec: Angle.Degrees(+00.93740280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196991"},
        {"Hipparcos Number", "HIP 102041"},
        {"Smithsonian Astrophysical Observation", "SAO 126097"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.18947228),
        dec: Angle.Degrees(+00.93922667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9574 AB"},
        {"Henry Draper", "HD 136027"},
        {"Hipparcos Number", "HIP 74895"},
        {"Smithsonian Astrophysical Observation", "SAO 120938"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.59424244),
        dec: Angle.Degrees(+00.93945188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139483"},
        {"Hipparcos Number", "HIP 76577"},
        {"Smithsonian Astrophysical Observation", "SAO 121102"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.57986682),
        dec: Angle.Degrees(+00.94019969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7012 AB"},
        {"Henry Draper", "HD 75207"},
        {"Hipparcos Number", "HIP 43252"},
        {"Smithsonian Astrophysical Observation", "SAO 117154"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.16791750),
        dec: Angle.Degrees(+00.94193556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85833"},
        {"Hipparcos Number", "HIP 48591"},
        {"Geneva Identification System", "GEN# +1.00085833"},
        {"Smithsonian Astrophysical Observation", "SAO 117983"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64333370),
        dec: Angle.Degrees(+00.94436381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74170"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.32368719),
        dec: Angle.Degrees(+00.94441360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93799"},
        {"Hipparcos Number", "HIP 52949"},
        {"Smithsonian Astrophysical Observation", "SAO 118520"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.43365295),
        dec: Angle.Degrees(+00.94476131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9670"},
        {"Hipparcos Number", "HIP 7357"},
        {"Geneva Identification System", "GEN# +1.00009670"},
        {"Smithsonian Astrophysical Observation", "SAO 109989"},
        {"Wilson Evans Batten Catalogue", "WEB 1580"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.70309634),
        dec: Angle.Degrees(+00.94542483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100599"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97766810),
        dec: Angle.Degrees(+00.94577957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23206"},
        {"Hipparcos Number", "HIP 17385"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.84865991),
        dec: Angle.Degrees(+00.94598827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3592"},
        {"Hipparcos Number", "HIP 3055"},
        {"Smithsonian Astrophysical Observation", "SAO 109342"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.70063519),
        dec: Angle.Degrees(+00.94651320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41297"},
        {"Smithsonian Astrophysical Observation", "SAO 116746"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.39162764),
        dec: Angle.Degrees(+00.94921184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101589"},
        {"Hipparcos Number", "HIP 57022"},
        {"Smithsonian Astrophysical Observation", "SAO 118992"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.36609173),
        dec: Angle.Degrees(+00.95047099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171888"},
        {"Hipparcos Number", "HIP 91281"},
        {"Fundamental Katalog 5th Edition", "FK5 5635"},
        {"Geneva Identification System", "GEN# +1.00171888"},
        {"Smithsonian Astrophysical Observation", "SAO 123699"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.28927241),
        dec: Angle.Degrees(+00.95108452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8261 AB"},
        {"Henry Draper", "HD 101445"},
        {"Hipparcos Number", "HIP 56941"},
        {"Fundamental Katalog 5th Edition", "FK5 5031"},
        {"Smithsonian Astrophysical Observation", "SAO 118981"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.10032952),
        dec: Angle.Degrees(+00.95217774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123324"},
        {"Hipparcos Number", "HIP 68952"},
        {"Smithsonian Astrophysical Observation", "SAO 120293"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.72479335),
        dec: Angle.Degrees(+00.95304552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76193"},
        {"Hipparcos Number", "HIP 43750"},
        {"Geneva Identification System", "GEN# +1.00076193"},
        {"Smithsonian Astrophysical Observation", "SAO 117257"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.66965253),
        dec: Angle.Degrees(+00.95335169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99596"},
        {"Hipparcos Number", "HIP 55907"},
        {"Smithsonian Astrophysical Observation", "SAO 118871"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.89173092),
        dec: Angle.Degrees(+00.95638351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48035"},
        {"Hipparcos Number", "HIP 32027"},
        {"Smithsonian Astrophysical Observation", "SAO 114278"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.35779573),
        dec: Angle.Degrees(+00.95727223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73975"},
        {"Hipparcos Number", "HIP 42629"},
        {"Smithsonian Astrophysical Observation", "SAO 117025"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.31875313),
        dec: Angle.Degrees(+00.95810035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4320 AB"},
        {"Henry Draper", "HD 38203"},
        {"Hipparcos Number", "HIP 27053"},
        {"Smithsonian Astrophysical Observation", "SAO 113090"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.05151951),
        dec: Angle.Degrees(+00.95830405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66613"},
        {"Hipparcos Number", "HIP 39500"},
        {"Smithsonian Astrophysical Observation", "SAO 116304"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.11125246),
        dec: Angle.Degrees(+00.96107581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6249 AB"},
        {"Henry Draper", "HD 61366"},
        {"Hipparcos Number", "HIP 37249"},
        {"Smithsonian Astrophysical Observation", "SAO 115749"},
    },
    visualMagnitude: 7.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.75253707),
        dec: Angle.Degrees(+00.96127721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69632"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.76678131),
        dec: Angle.Degrees(+00.96137912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21795"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.23421196),
        dec: Angle.Degrees(+00.96279005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16431 A"},
        {"Henry Draper", "HD 217264"},
        {"Hipparcos Number", "HIP 113521"},
        {"Geneva Identification System", "GEN# +1.00217264"},
        {"Smithsonian Astrophysical Observation", "SAO 127881"},
        {"Wilson Evans Batten Catalogue", "WEB 20181"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.86417726),
        dec: Angle.Degrees(+00.96309154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17690"},
        {"Hipparcos Number", "HIP 13232"},
        {"Geneva Identification System", "GEN# +1.00017690"},
        {"Smithsonian Astrophysical Observation", "SAO 110778"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.58471997),
        dec: Angle.Degrees(+00.96402619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68299"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.71819339),
        dec: Angle.Degrees(+00.96660917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31364"},
        {"Hipparcos Number", "HIP 22874"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.80787222),
        dec: Angle.Degrees(+00.96739844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38589"},
        {"Hipparcos Number", "HIP 27284"},
        {"Geneva Identification System", "GEN# +1.00038589"},
        {"Smithsonian Astrophysical Observation", "SAO 113129"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.72953959),
        dec: Angle.Degrees(+00.96787474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37330"},
        {"Hipparcos Number", "HIP 26476"},
        {"Celescope Catalog", "CEL 871"},
        {"Geneva Identification System", "GEN# +1.00037330"},
        {"Smithsonian Astrophysical Observation", "SAO 112980"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.47272459),
        dec: Angle.Degrees(+00.96861377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39775"},
        {"Hipparcos Number", "HIP 27939"},
        {"Geneva Identification System", "GEN# +1.00039775"},
        {"Smithsonian Astrophysical Observation", "SAO 113265"},
        {"Wilson Evans Batten Catalogue", "WEB 5472"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.68349348),
        dec: Angle.Degrees(+00.96861499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11010",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1811 AB"},
        {"Henry Draper", "HD 14634"},
        {"Hipparcos Number", "HIP 11010"},
        {"Fundamental Katalog 5th Edition", "FK5 4217"},
        {"Smithsonian Astrophysical Observation", "SAO 110494"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.45391074),
        dec: Angle.Degrees(+00.97001291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18682"},
        {"Hipparcos Number", "HIP 14003"},
        {"Smithsonian Astrophysical Observation", "SAO 110898"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.07259348),
        dec: Angle.Degrees(+00.97061607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7873"},
        {"Hipparcos Number", "HIP 6112"},
        {"Smithsonian Astrophysical Observation", "SAO 109797"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.61763906),
        dec: Angle.Degrees(+00.97074238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130256"},
        {"Hipparcos Number", "HIP 72298"},
        {"Smithsonian Astrophysical Observation", "SAO 120657"},
        {"Wilson Evans Batten Catalogue", "WEB 12432"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77237272),
        dec: Angle.Degrees(+00.97095783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37659"},
        {"Hipparcos Number", "HIP 26687"},
        {"Geneva Identification System", "GEN# +1.00037659"},
        {"Smithsonian Astrophysical Observation", "SAO 113022"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07126635),
        dec: Angle.Degrees(+00.97238006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22571"},
        {"Hipparcos Number", "HIP 16929"},
        {"Geneva Identification System", "GEN# +1.00022571"},
        {"Smithsonian Astrophysical Observation", "SAO 111306"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.46654638),
        dec: Angle.Degrees(+00.97357367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58114"},
        {"Cincinnati Publication", "Ci 20 670"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.78184908),
        dec: Angle.Degrees(+00.97368164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -737.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211213"},
        {"Hipparcos Number", "HIP 109913"},
        {"Smithsonian Astrophysical Observation", "SAO 127414"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.91367215),
        dec: Angle.Degrees(+00.97379960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205455"},
        {"Hipparcos Number", "HIP 106601"},
        {"Geneva Identification System", "GEN# +1.00205455"},
        {"Smithsonian Astrophysical Observation", "SAO 126910"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.84675553),
        dec: Angle.Degrees(+00.97573398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5949 AB"},
        {"Henry Draper", "HD 56361"},
        {"Hipparcos Number", "HIP 35221"},
        {"Geneva Identification System", "GEN# +1.00056361J"},
        {"Smithsonian Astrophysical Observation", "SAO 115193"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.19796472),
        dec: Angle.Degrees(+00.97951848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21006"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.56951172),
        dec: Angle.Degrees(+00.98005142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28796"},
        {"Hipparcos Number", "HIP 21177"},
        {"Smithsonian Astrophysical Observation", "SAO 111884"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.10194813),
        dec: Angle.Degrees(+00.98016249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42257"},
        {"Hipparcos Number", "HIP 29231"},
        {"Smithsonian Astrophysical Observation", "SAO 113528"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.44488778),
        dec: Angle.Degrees(+00.98054055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7208"},
        {"Hipparcos Number", "HIP 5647"},
        {"Geneva Identification System", "GEN# +1.00007208"},
        {"Smithsonian Astrophysical Observation", "SAO 109728"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.13099835),
        dec: Angle.Degrees(+00.98162503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212355"},
        {"Hipparcos Number", "HIP 110546"},
        {"Smithsonian Astrophysical Observation", "SAO 127502"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.91353647),
        dec: Angle.Degrees(+00.98228817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8298"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.75136424),
        dec: Angle.Degrees(+00.98260772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9459 AB"},
        {"Hipparcos Number", "HIP 73320"},
        {"Smithsonian Astrophysical Observation", "SAO 120770"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73940796),
        dec: Angle.Degrees(+00.98611973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110935"},
        {"Hipparcos Number", "HIP 62265"},
        {"Smithsonian Astrophysical Observation", "SAO 119573"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.38959909),
        dec: Angle.Degrees(+00.98682027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37342"},
        {"Hipparcos Number", "HIP 26481"},
        {"Geneva Identification System", "GEN# +1.00037342"},
        {"Smithsonian Astrophysical Observation", "SAO 112981"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.48438597),
        dec: Angle.Degrees(+00.98742339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75199"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.50196952),
        dec: Angle.Degrees(+00.98799885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17641"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70234183),
        dec: Angle.Degrees(+00.98805052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117914"},
        {"Hipparcos Number", "HIP 66140"},
        {"Smithsonian Astrophysical Observation", "SAO 119995"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.37306943),
        dec: Angle.Degrees(+00.98868018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33008"},
        {"Hipparcos Number", "HIP 23821"},
        {"Geneva Identification System", "GEN# +1.00033008"},
        {"Smithsonian Astrophysical Observation", "SAO 112432"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.81996741),
        dec: Angle.Degrees(+00.99099699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3558 AB"},
        {"Henry Draper", "HD 31622"},
        {"Hipparcos Number", "HIP 23044"},
        {"Geneva Identification System", "GEN# +5.20250149J"},
        {"Smithsonian Astrophysical Observation", "SAO 112259"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.34770870),
        dec: Angle.Degrees(+00.99194437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70553",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Preston's Star"},
        {"Henry Draper", "HD 126515"},
        {"Hipparcos Number", "HIP 70553"},
        {"Geneva Identification System", "GEN# +1.00126515"},
        {"Renson", "Renson 36050"},
        {"Smithsonian Astrophysical Observation", "SAO 120452"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.48290740),
        dec: Angle.Degrees(+00.99278358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156656"},
        {"Hipparcos Number", "HIP 84683"},
        {"Smithsonian Astrophysical Observation", "SAO 122266"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.68028148),
        dec: Angle.Degrees(+00.99364636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101631"},
        {"Hipparcos Number", "HIP 57042"},
        {"Smithsonian Astrophysical Observation", "SAO 118997"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.42508684),
        dec: Angle.Degrees(+00.99370272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10650 AB"},
        {"Henry Draper", "HD 159660"},
        {"Hipparcos Number", "HIP 86106"},
        {"Smithsonian Astrophysical Observation", "SAO 122544"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.96013048),
        dec: Angle.Degrees(+00.99661675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119290"},
        {"Hipparcos Number", "HIP 66875"},
        {"Smithsonian Astrophysical Observation", "SAO 120076"},
        {"Wilson Evans Batten Catalogue", "WEB 11790"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.58914317),
        dec: Angle.Degrees(+00.99705802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45428"},
        {"Smithsonian Astrophysical Observation", "SAO 117542"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.86729085),
        dec: Angle.Degrees(+00.99801937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29335"},
        {"Hipparcos Number", "HIP 21515"},
        {"Fundamental Katalog 5th Edition", "FK5 2339"},
        {"Geneva Identification System", "GEN# +1.00029335"},
        {"Smithsonian Astrophysical Observation", "SAO 111928"},
        {"Wilson Evans Batten Catalogue", "WEB 4130"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.30698431),
        dec: Angle.Degrees(+00.99832711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24521"},
        {"Hipparcos Number", "HIP 18239"},
        {"Smithsonian Astrophysical Observation", "SAO 111484"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.52051684),
        dec: Angle.Degrees(+00.99983561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49567"},
        {"Hipparcos Number", "HIP 32682"},
        {"Geneva Identification System", "GEN# +1.00049567"},
        {"Smithsonian Astrophysical Observation", "SAO 114465"},
        {"Wilson Evans Batten Catalogue", "WEB 6586"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.26523768),
        dec: Angle.Degrees(+01.00207185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122346"},
        {"Hipparcos Number", "HIP 68505"},
        {"Smithsonian Astrophysical Observation", "SAO 120229"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.35470748),
        dec: Angle.Degrees(+01.00256977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3117"},
        {"Hipparcos Number", "HIP 2706"},
        {"Smithsonian Astrophysical Observation", "SAO 109286"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.59919586),
        dec: Angle.Degrees(+01.00268447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88283"},
        {"Hipparcos Number", "HIP 49857"},
        {"Smithsonian Astrophysical Observation", "SAO 118148"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.71715890),
        dec: Angle.Degrees(+01.00524851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139176"},
        {"Hipparcos Number", "HIP 76439"},
        {"Smithsonian Astrophysical Observation", "SAO 121091"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.17808627),
        dec: Angle.Degrees(+01.00555494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187929"},
        {"Hipparcos Number", "HIP 97804"},
        {"Fundamental Katalog 5th Edition", "FK5 746"},
        {"Geneva Identification System", "GEN# +1.00187929"},
        {"Smithsonian Astrophysical Observation", "SAO 125159"},
        {"Wilson Evans Batten Catalogue", "WEB 17207"},
    },
    visualMagnitude: 3.87,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.11818257),
        dec: Angle.Degrees(+01.00567827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167858"},
        {"Hipparcos Number", "HIP 89601"},
        {"Geneva Identification System", "GEN# +1.00167858"},
        {"Renson", "Renson 47080"},
        {"Smithsonian Astrophysical Observation", "SAO 123320"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.27019535),
        dec: Angle.Degrees(+01.00580088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23266",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 13"},
        {"Henry Draper", "HD 32023"},
        {"Hipparcos Number", "HIP 23266"},
        {"Geneva Identification System", "GEN# +1.00032023"},
        {"Smithsonian Astrophysical Observation", "SAO 112302"},
        {"Wilson Evans Batten Catalogue", "WEB 4522"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.08710013),
        dec: Angle.Degrees(+01.00657023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24145"},
        {"Hipparcos Number", "HIP 17996"},
        {"Geneva Identification System", "GEN# +1.00024145"},
        {"Smithsonian Astrophysical Observation", "SAO 111458"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.70434756),
        dec: Angle.Degrees(+01.00998217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50229"},
        {"Hipparcos Number", "HIP 32989"},
        {"Smithsonian Astrophysical Observation", "SAO 114548"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.09298669),
        dec: Angle.Degrees(+01.01036668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93153"},
        {"Hipparcos Number", "HIP 52610"},
        {"Smithsonian Astrophysical Observation", "SAO 118478"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.37201237),
        dec: Angle.Degrees(+01.01080042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205027"},
        {"Hipparcos Number", "HIP 106356"},
        {"Cincinnati Publication", "Ci 20 1292"},
        {"Geneva Identification System", "GEN# +1.00205027"},
        {"Smithsonian Astrophysical Observation", "SAO 126873"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.11957784),
        dec: Angle.Degrees(+01.01310394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -332.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3793"},
        {"Smithsonian Astrophysical Observation", "SAO 109475"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.18341093),
        dec: Angle.Degrees(+01.01348091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287601"},
        {"Hipparcos Number", "HIP 24034"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.49893033),
        dec: Angle.Degrees(+01.01521125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34908"},
        {"Hipparcos Number", "HIP 24970"},
        {"Geneva Identification System", "GEN# +1.00034908"},
        {"Smithsonian Astrophysical Observation", "SAO 112656"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.22047148),
        dec: Angle.Degrees(+01.01662649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151133"},
        {"Hipparcos Number", "HIP 82037"},
        {"Geneva Identification System", "GEN# +1.00151133"},
        {"Smithsonian Astrophysical Observation", "SAO 121834"},
        {"Wilson Evans Batten Catalogue", "WEB 13852"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.37365324),
        dec: Angle.Degrees(+01.02014536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67852"},
        {"Hipparcos Number", "HIP 39986"},
        {"Geneva Identification System", "GEN# +1.00067852"},
        {"Smithsonian Astrophysical Observation", "SAO 116425"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.49360353),
        dec: Angle.Degrees(+01.02050087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28932"},
        {"Hipparcos Number", "HIP 21250"},
        {"Geneva Identification System", "GEN# +1.00028932"},
        {"Smithsonian Astrophysical Observation", "SAO 111888"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.38200030),
        dec: Angle.Degrees(+01.02247372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3945"},
        {"Hipparcos Number", "HIP 3296"},
        {"Smithsonian Astrophysical Observation", "SAO 109383"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.50943301),
        dec: Angle.Degrees(+01.02369093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154658"},
        {"Hipparcos Number", "HIP 83725"},
        {"Smithsonian Astrophysical Observation", "SAO 122081"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.67840111),
        dec: Angle.Degrees(+01.02440302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83769"},
        {"Hipparcos Number", "HIP 47480"},
        {"Geneva Identification System", "GEN# +1.00083769A"},
        {"Wilson Evans Batten Catalogue", "WEB 8907"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.19078218),
        dec: Angle.Degrees(+01.02472384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94180"},
        {"Hipparcos Number", "HIP 53141"},
        {"Geneva Identification System", "GEN# +1.00094180"},
        {"Smithsonian Astrophysical Observation", "SAO 118550"},
        {"Wilson Evans Batten Catalogue", "WEB 9649"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.05704676),
        dec: Angle.Degrees(+01.02498206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95856"},
        {"Geneva Identification System", "GEN# +9.80092006"},
    },
    visualMagnitude: 11.74,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.43391707),
        dec: Angle.Degrees(+01.02548650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202620"},
        {"Hipparcos Number", "HIP 105059"},
        {"Smithsonian Astrophysical Observation", "SAO 126678"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.24263881),
        dec: Angle.Degrees(+01.02593473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77858"},
        {"Hipparcos Number", "HIP 44588"},
        {"Smithsonian Astrophysical Observation", "SAO 117407"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.25718596),
        dec: Angle.Degrees(+01.02702850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41062"},
        {"Smithsonian Astrophysical Observation", "SAO 116693"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.68398768),
        dec: Angle.Degrees(+01.02888924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147449"},
        {"Hipparcos Number", "HIP 80179"},
        {"Fundamental Katalog 5th Edition", "FK5 1427"},
        {"Geneva Identification System", "GEN# +1.00147449"},
        {"Smithsonian Astrophysical Observation", "SAO 121540"},
        {"Wilson Evans Batten Catalogue", "WEB 13573"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.51850007),
        dec: Angle.Degrees(+01.02892219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101639"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.02362579),
        dec: Angle.Degrees(+01.02948564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14713 AB"},
        {"Henry Draper", "HD 201675"},
        {"Hipparcos Number", "HIP 104574"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.75747154),
        dec: Angle.Degrees(+01.02978435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133091"},
        {"Hipparcos Number", "HIP 73592"},
        {"Smithsonian Astrophysical Observation", "SAO 120805"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.63559230),
        dec: Angle.Degrees(+01.03119862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28087"},
        {"Hipparcos Number", "HIP 20692"},
        {"Smithsonian Astrophysical Observation", "SAO 111813"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.48420797),
        dec: Angle.Degrees(+01.03178972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110046"},
        {"Hipparcos Number", "HIP 61760"},
        {"Smithsonian Astrophysical Observation", "SAO 119517"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.86191860),
        dec: Angle.Degrees(+01.03296017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15821"},
        {"Hipparcos Number", "HIP 11831"},
        {"Geneva Identification System", "GEN# +1.00015821"},
        {"Smithsonian Astrophysical Observation", "SAO 110603"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.17559686),
        dec: Angle.Degrees(+01.03368612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200063"},
        {"Hipparcos Number", "HIP 103722"},
        {"Smithsonian Astrophysical Observation", "SAO 126464"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.26684389),
        dec: Angle.Degrees(+01.03490205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211987"},
        {"Hipparcos Number", "HIP 110358"},
        {"Geneva Identification System", "GEN# +1.00211987"},
        {"Smithsonian Astrophysical Observation", "SAO 127466"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.27684352),
        dec: Angle.Degrees(+01.03512646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24203",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3764 AB"},
        {"Henry Draper", "HD 33646"},
        {"Hipparcos Number", "HIP 24203"},
        {"Geneva Identification System", "GEN# +1.00033646"},
        {"Smithsonian Astrophysical Observation", "SAO 112509"},
        {"Wilson Evans Batten Catalogue", "WEB 4701"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.93896000),
        dec: Angle.Degrees(+01.03705465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15126"},
        {"Geneva Identification System", "GEN# +0.00000549"},
        {"Geneva Identification System 2", "GEN# +9.80077034"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.76894465),
        dec: Angle.Degrees(+01.03727125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 362.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225294"},
        {"Hipparcos Number", "HIP 416"},
        {"Smithsonian Astrophysical Observation", "SAO 109000"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.26440114),
        dec: Angle.Degrees(+01.03782858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214670"},
        {"Hipparcos Number", "HIP 111881"},
        {"Geneva Identification System", "GEN# +1.00214670"},
        {"Renson", "Renson 59410"},
        {"Smithsonian Astrophysical Observation", "SAO 127670"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.94060819),
        dec: Angle.Degrees(+01.03884312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62263"},
        {"Hipparcos Number", "HIP 37619"},
        {"Smithsonian Astrophysical Observation", "SAO 115840"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.78645235),
        dec: Angle.Degrees(+01.04181481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109218"},
        {"Hipparcos Number", "HIP 61252"},
        {"Geneva Identification System", "GEN# +1.00109218"},
        {"Smithsonian Astrophysical Observation", "SAO 119462"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.28526858),
        dec: Angle.Degrees(+01.04412245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161587"},
        {"Hipparcos Number", "HIP 86969"},
        {"Smithsonian Astrophysical Observation", "SAO 122729"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.60368388),
        dec: Angle.Degrees(+01.04434999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109656"},
        {"Hipparcos Number", "HIP 61529"},
        {"Smithsonian Astrophysical Observation", "SAO 119493"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.09137414),
        dec: Angle.Degrees(+01.04486500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32274"},
        {"Hipparcos Number", "HIP 23414"},
        {"Geneva Identification System", "GEN# +1.00032274"},
        {"Smithsonian Astrophysical Observation", "SAO 112338"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.48788479),
        dec: Angle.Degrees(+01.04953932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121607"},
        {"Hipparcos Number", "HIP 68092"},
        {"Geneva Identification System", "GEN# +1.00121607"},
        {"Smithsonian Astrophysical Observation", "SAO 120185"},
        {"Wilson Evans Batten Catalogue", "WEB 11953"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11622242),
        dec: Angle.Degrees(+01.05054828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71373"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94357467),
        dec: Angle.Degrees(+01.05188178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27013",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4309 AB"},
        {"Henry Draper", "HD 38155"},
        {"Hipparcos Number", "HIP 27013"},
        {"Smithsonian Astrophysical Observation", "SAO 113085"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95029542),
        dec: Angle.Degrees(+01.05383829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47022"},
        {"Hipparcos Number", "HIP 31586"},
        {"Smithsonian Astrophysical Observation", "SAO 114125"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.15055546),
        dec: Angle.Degrees(+01.05403699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127006"},
        {"Hipparcos Number", "HIP 70817"},
        {"Smithsonian Astrophysical Observation", "SAO 120487"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.23907452),
        dec: Angle.Degrees(+01.05596898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110885"},
        {"Hipparcos Number", "HIP 62235"},
        {"Geneva Identification System", "GEN# +1.00110885"},
        {"Smithsonian Astrophysical Observation", "SAO 119568"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.33026230),
        dec: Angle.Degrees(+01.05597692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25174",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3968 AB"},
        {"Henry Draper", "HD 35192"},
        {"Hipparcos Number", "HIP 25174"},
        {"Celescope Catalog", "CEL 663"},
        {"Geneva Identification System", "GEN# +1.00035192J"},
        {"Smithsonian Astrophysical Observation", "SAO 112704"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.77307391),
        dec: Angle.Degrees(+01.05692656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17397"},
        {"Hipparcos Number", "HIP 13026"},
        {"Smithsonian Astrophysical Observation", "SAO 110748"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.86240424),
        dec: Angle.Degrees(+01.05928586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180642"},
        {"Hipparcos Number", "HIP 94793"},
        {"Geneva Identification System", "GEN# +1.00180642"},
        {"Smithsonian Astrophysical Observation", "SAO 124467"},
        {"Wilson Evans Batten Catalogue", "WEB 16542"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.31168379),
        dec: Angle.Degrees(+01.05942616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1512"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.71276884),
        dec: Angle.Degrees(+01.06311484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 222.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3951"},
        {"Hipparcos Number", "HIP 3302"},
        {"Geneva Identification System", "GEN# +1.00003951"},
        {"Smithsonian Astrophysical Observation", "SAO 109387"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.52804752),
        dec: Angle.Degrees(+01.06353787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70298"},
        {"Hipparcos Number", "HIP 40938"},
        {"Geneva Identification System", "GEN# +1.00070298"},
        {"Smithsonian Astrophysical Observation", "SAO 116665"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.31697009),
        dec: Angle.Degrees(+01.06414845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216701"},
        {"Hipparcos Number", "HIP 113167"},
        {"Geneva Identification System", "GEN# +1.00216701"},
        {"Smithsonian Astrophysical Observation", "SAO 127836"},
        {"Wilson Evans Batten Catalogue", "WEB 20141"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74780883),
        dec: Angle.Degrees(+01.06489117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199803"},
        {"Hipparcos Number", "HIP 103611"},
        {"Cincinnati Publication", "Ci 18 2715"},
        {"Geneva Identification System", "GEN# +1.00199803"},
        {"Smithsonian Astrophysical Observation", "SAO 126438"},
        {"Wilson Evans Batten Catalogue", "WEB 18850"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.88612193),
        dec: Angle.Degrees(+01.06540590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224774"},
        {"Hipparcos Number", "HIP 51"},
        {"Smithsonian Astrophysical Observation", "SAO 128528"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.14339044),
        dec: Angle.Degrees(+01.06619726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13811 A"},
        {"Henry Draper", "HD 194244"},
        {"Hipparcos Number", "HIP 100664"},
        {"Geneva Identification System", "GEN# +1.00194244"},
        {"Smithsonian Astrophysical Observation", "SAO 125769"},
        {"Wilson Evans Batten Catalogue", "WEB 18191"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15622323),
        dec: Angle.Degrees(+01.06839246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191749"},
        {"Hipparcos Number", "HIP 99495"},
        {"Smithsonian Astrophysical Observation", "SAO 125538"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.87569267),
        dec: Angle.Degrees(+01.06882868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200108"},
        {"Hipparcos Number", "HIP 103742"},
        {"Smithsonian Astrophysical Observation", "SAO 126469"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.34238809),
        dec: Angle.Degrees(+01.06978063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21712"},
        {"Hipparcos Number", "HIP 16311"},
        {"Smithsonian Astrophysical Observation", "SAO 111227"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55785722),
        dec: Angle.Degrees(+01.07447468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77781"},
        {"Smithsonian Astrophysical Observation", "SAO 121235"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.23315836),
        dec: Angle.Degrees(+01.07509962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223438"},
        {"Hipparcos Number", "HIP 117491"},
        {"Geneva Identification System", "GEN# +1.00223438"},
        {"Renson", "Renson 61210"},
        {"Smithsonian Astrophysical Observation", "SAO 128401"},
        {"Wilson Evans Batten Catalogue", "WEB 20693"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.36448204),
        dec: Angle.Degrees(+01.07619547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7276"},
        {"Hipparcos Number", "HIP 5681"},
        {"Smithsonian Astrophysical Observation", "SAO 109733"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.25624235),
        dec: Angle.Degrees(+01.07856119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53745"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94835738),
        dec: Angle.Degrees(+01.07856596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43461"},
        {"Hipparcos Number", "HIP 29791"},
        {"Geneva Identification System", "GEN# +1.00043461"},
        {"Smithsonian Astrophysical Observation", "SAO 113668"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.08781454),
        dec: Angle.Degrees(+01.08035555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90305"},
        {"Hipparcos Number", "HIP 51034"},
        {"Smithsonian Astrophysical Observation", "SAO 118294"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.39550119),
        dec: Angle.Degrees(+01.08284007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205145"},
        {"Hipparcos Number", "HIP 106426"},
        {"Smithsonian Astrophysical Observation", "SAO 126886"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.33819771),
        dec: Angle.Degrees(+01.08427352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217529"},
        {"Hipparcos Number", "HIP 113667"},
        {"Smithsonian Astrophysical Observation", "SAO 127903"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.31827027),
        dec: Angle.Degrees(+01.08445225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74892"},
        {"Hipparcos Number", "HIP 43116"},
        {"Geneva Identification System", "GEN# +1.00074892"},
        {"Smithsonian Astrophysical Observation", "SAO 117113"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70696193),
        dec: Angle.Degrees(+01.08487729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12289 A"},
        {"Henry Draper", "HD 180972"},
        {"Hipparcos Number", "HIP 94885"},
        {"Geneva Identification System", "GEN# +1.00180972"},
        {"Smithsonian Astrophysical Observation", "SAO 124487"},
        {"Wilson Evans Batten Catalogue", "WEB 16561"},
    },
    visualMagnitude: 5.10,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.63537019),
        dec: Angle.Degrees(+01.08508548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111719"},
        {"Hipparcos Number", "HIP 62736"},
        {"Geneva Identification System", "GEN# +1.00111719"},
        {"Smithsonian Astrophysical Observation", "SAO 119629"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82774062),
        dec: Angle.Degrees(+01.08545196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78870"},
        {"Hipparcos Number", "HIP 45056"},
        {"Smithsonian Astrophysical Observation", "SAO 117474"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.65039580),
        dec: Angle.Degrees(+01.08667217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118865"},
        {"Hipparcos Number", "HIP 66637"},
        {"Geneva Identification System", "GEN# +1.00118865"},
        {"Smithsonian Astrophysical Observation", "SAO 120055"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.89325600),
        dec: Angle.Degrees(+01.08848447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224700"},
        {"Hipparcos Number", "HIP 1"},
        {"Smithsonian Astrophysical Observation", "SAO 128522"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.00091185),
        dec: Angle.Degrees(+01.08901332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40983"},
        {"Hipparcos Number", "HIP 28613"},
        {"Geneva Identification System", "GEN# +1.00040983"},
        {"Smithsonian Astrophysical Observation", "SAO 113393"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.59385304),
        dec: Angle.Degrees(+01.08926863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187003"},
        {"Hipparcos Number", "HIP 97384"},
        {"Geneva Identification System", "GEN# +1.00187003"},
        {"Smithsonian Astrophysical Observation", "SAO 125069"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.88890477),
        dec: Angle.Degrees(+01.08943925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78517"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.44345753),
        dec: Angle.Degrees(+01.09000430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151591"},
        {"Hipparcos Number", "HIP 82247"},
        {"Smithsonian Astrophysical Observation", "SAO 121871"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.05746997),
        dec: Angle.Degrees(+01.09050361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11736",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1924 B"},
        {"Hipparcos Number", "HIP 11736"},
        {"Smithsonian Astrophysical Observation", "SAO 110590"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.87211239),
        dec: Angle.Degrees(+01.09141488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56027"},
        {"Geneva Identification System", "GEN# +0.00102570"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.24489778),
        dec: Angle.Degrees(+01.09385415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15603"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.22895477),
        dec: Angle.Degrees(+01.09400934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294"},
        {"Hipparcos Number", "HIP 628"},
        {"Geneva Identification System", "GEN# +1.00000294"},
        {"Renson", "Renson 20"},
        {"Smithsonian Astrophysical Observation", "SAO 109023"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.91669898),
        dec: Angle.Degrees(+01.09425779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11737",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1924 A"},
        {"Henry Draper", "HD 15695"},
        {"Hipparcos Number", "HIP 11737"},
        {"Renson", "Renson 3910"},
        {"Smithsonian Astrophysical Observation", "SAO 110591"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.87451295),
        dec: Angle.Degrees(+01.09429343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87079"},
        {"Hipparcos Number", "HIP 49217"},
        {"Geneva Identification System", "GEN# +1.00087079"},
        {"Wilson Evans Batten Catalogue", "WEB 9115"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.69982732),
        dec: Angle.Degrees(+01.09454695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117362"},
        {"Hipparcos Number", "HIP 65839"},
        {"Smithsonian Astrophysical Observation", "SAO 119959"},
        {"Wilson Evans Batten Catalogue", "WEB 11649"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.44634394),
        dec: Angle.Degrees(+01.09559331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103548"},
        {"Hipparcos Number", "HIP 58133"},
        {"Geneva Identification System", "GEN# +1.00103548"},
        {"Smithsonian Astrophysical Observation", "SAO 119114"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.84965771),
        dec: Angle.Degrees(+01.09599880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53098"},
        {"Smithsonian Astrophysical Observation", "SAO 118544"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.94189072),
        dec: Angle.Degrees(+01.09601526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162651"},
        {"Hipparcos Number", "HIP 87432"},
        {"Geneva Identification System", "GEN# +1.00162651"},
        {"Renson", "Renson 45950"},
        {"Smithsonian Astrophysical Observation", "SAO 122843"},
        {"Wilson Evans Batten Catalogue", "WEB 14747"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00300423),
        dec: Angle.Degrees(+01.09922864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115474"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.87905427),
        dec: Angle.Degrees(+01.10111270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87994"},
        {"Geneva Identification System", "GEN# +0.00103547"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.61342714),
        dec: Angle.Degrees(+01.10143379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98147"},
    },
    visualMagnitude: 11.82,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.19285921),
        dec: Angle.Degrees(+01.10188968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204121"},
        {"Hipparcos Number", "HIP 105864"},
        {"Fundamental Katalog 5th Edition", "FK5 3711"},
        {"Geneva Identification System", "GEN# +1.00204121"},
        {"Smithsonian Astrophysical Observation", "SAO 126794"},
        {"Wilson Evans Batten Catalogue", "WEB 19200"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61661904),
        dec: Angle.Degrees(+01.10375193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213610"},
        {"Hipparcos Number", "HIP 111287"},
        {"Smithsonian Astrophysical Observation", "SAO 127588"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.17220655),
        dec: Angle.Degrees(+01.10392049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35881"},
        {"Hipparcos Number", "HIP 25567"},
        {"Celescope Catalog", "CEL 718"},
        {"Geneva Identification System", "GEN# +1.00035881"},
        {"Renson", "Renson 9250"},
        {"Smithsonian Astrophysical Observation", "SAO 112793"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.97596819),
        dec: Angle.Degrees(+01.10505150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4056 AB"},
        {"Henry Draper", "HD 35834"},
        {"Hipparcos Number", "HIP 25533"},
        {"Celescope Catalog", "CEL 716"},
        {"Geneva Identification System", "GEN# +1.00035834J"},
        {"Smithsonian Astrophysical Observation", "SAO 112792"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90365439),
        dec: Angle.Degrees(+01.10758506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29925"},
        {"Hipparcos Number", "HIP 21944"},
        {"Geneva Identification System", "GEN# +1.00029925"},
        {"Renson", "Renson 7690"},
        {"Smithsonian Astrophysical Observation", "SAO 112007"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.75157097),
        dec: Angle.Degrees(+01.10789032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162652"},
        {"Hipparcos Number", "HIP 87448"},
        {"Geneva Identification System", "GEN# +1.00162652"},
        {"Smithsonian Astrophysical Observation", "SAO 122847"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.02169196),
        dec: Angle.Degrees(+01.11119731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222732"},
        {"Hipparcos Number", "HIP 117012"},
        {"Fundamental Katalog 5th Edition", "FK5 6099"},
        {"Geneva Identification System", "GEN# +1.00222732"},
        {"Smithsonian Astrophysical Observation", "SAO 128343"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.81007908),
        dec: Angle.Degrees(+01.11308070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131651"},
        {"Hipparcos Number", "HIP 72978"},
        {"Geneva Identification System", "GEN# +1.00131651"},
        {"Smithsonian Astrophysical Observation", "SAO 120732"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.71274933),
        dec: Angle.Degrees(+01.11453665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168832"},
        {"Hipparcos Number", "HIP 89997"},
        {"Smithsonian Astrophysical Observation", "SAO 123387"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.44642609),
        dec: Angle.Degrees(+01.11480780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52560"},
        {"Hipparcos Number", "HIP 33866"},
        {"Smithsonian Astrophysical Observation", "SAO 114800"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.45104740),
        dec: Angle.Degrees(+01.11485132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158737"},
        {"Hipparcos Number", "HIP 85707"},
        {"Geneva Identification System", "GEN# +1.00158737"},
        {"Smithsonian Astrophysical Observation", "SAO 122453"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.71468360),
        dec: Angle.Degrees(+01.11962682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175337"},
        {"Hipparcos Number", "HIP 92837"},
        {"Geneva Identification System", "GEN# +1.00175337"},
        {"Smithsonian Astrophysical Observation", "SAO 124039"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.72655844),
        dec: Angle.Degrees(+01.12167188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22547"},
        {"Hipparcos Number", "HIP 16913"},
        {"Smithsonian Astrophysical Observation", "SAO 111301"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.40991431),
        dec: Angle.Degrees(+01.12255048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220858"},
        {"Hipparcos Number", "HIP 115768"},
        {"Geneva Identification System", "GEN# +1.00220858"},
        {"Smithsonian Astrophysical Observation", "SAO 128188"},
        {"Wilson Evans Batten Catalogue", "WEB 20486"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.81152185),
        dec: Angle.Degrees(+01.12268705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73359"},
        {"Smithsonian Astrophysical Observation", "SAO 120775"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.87543870),
        dec: Angle.Degrees(+01.12302588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38870",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6483 AB"},
        {"Henry Draper", "HD 65123"},
        {"Hipparcos Number", "HIP 38870"},
        {"Geneva Identification System", "GEN# +1.00065123J"},
        {"Smithsonian Astrophysical Observation", "SAO 116165"},
        {"Wilson Evans Batten Catalogue", "WEB 7613"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.31829276),
        dec: Angle.Degrees(+01.12702230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152583"},
        {"Hipparcos Number", "HIP 82687"},
        {"Smithsonian Astrophysical Observation", "SAO 121931"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.52752357),
        dec: Angle.Degrees(+01.13061473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86901"},
        {"Hipparcos Number", "HIP 49135"},
        {"Smithsonian Astrophysical Observation", "SAO 118058"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41698353),
        dec: Angle.Degrees(+01.13112345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24381"},
        {"Hipparcos Number", "HIP 18144"},
        {"Geneva Identification System", "GEN# +1.00024381"},
        {"Smithsonian Astrophysical Observation", "SAO 111473"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.19385197),
        dec: Angle.Degrees(+01.13290900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164855"},
        {"Hipparcos Number", "HIP 88422"},
        {"Smithsonian Astrophysical Observation", "SAO 123061"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79827848),
        dec: Angle.Degrees(+01.13393940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72657"},
        {"Hipparcos Number", "HIP 42043"},
        {"Geneva Identification System", "GEN# +1.00072657"},
        {"Smithsonian Astrophysical Observation", "SAO 116895"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.54852854),
        dec: Angle.Degrees(+01.13418624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204564"},
        {"Hipparcos Number", "HIP 106086"},
        {"Smithsonian Astrophysical Observation", "SAO 126828"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.34388983),
        dec: Angle.Degrees(+01.13699638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16092"},
        {"Hipparcos Number", "HIP 12037"},
        {"Geneva Identification System", "GEN# +1.00016092"},
        {"Smithsonian Astrophysical Observation", "SAO 110628"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79645272),
        dec: Angle.Degrees(+01.13754976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35203"},
        {"Hipparcos Number", "HIP 25179"},
        {"Celescope Catalog", "CEL 665"},
        {"Geneva Identification System", "GEN# +1.00035203"},
        {"Smithsonian Astrophysical Observation", "SAO 112707"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.79228101),
        dec: Angle.Degrees(+01.13962542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126677"},
        {"Hipparcos Number", "HIP 70649"},
        {"Geneva Identification System", "GEN# +1.00126677"},
        {"Smithsonian Astrophysical Observation", "SAO 120467"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.75518595),
        dec: Angle.Degrees(+01.14301554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287545"},
        {"Hipparcos Number", "HIP 23907"},
        {"Smithsonian Astrophysical Observation", "SAO 112454"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.05231478),
        dec: Angle.Degrees(+01.14342458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125231"},
        {"Hipparcos Number", "HIP 69884"},
        {"Geneva Identification System", "GEN# +1.00125231"},
        {"Smithsonian Astrophysical Observation", "SAO 120386"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.52710580),
        dec: Angle.Degrees(+01.14588467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69554"},
        {"Hipparcos Number", "HIP 40624"},
        {"Smithsonian Astrophysical Observation", "SAO 116588"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.39800877),
        dec: Angle.Degrees(+01.14605932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198642"},
        {"Hipparcos Number", "HIP 102966"},
        {"Smithsonian Astrophysical Observation", "SAO 126301"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.92506778),
        dec: Angle.Degrees(+01.14683233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30796"},
        {"Hipparcos Number", "HIP 22520"},
        {"Geneva Identification System", "GEN# +1.00030796"},
        {"Smithsonian Astrophysical Observation", "SAO 112132"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.68910785),
        dec: Angle.Degrees(+01.14781727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108653"},
        {"Hipparcos Number", "HIP 60902"},
        {"Geneva Identification System", "GEN# +1.00108653"},
        {"Smithsonian Astrophysical Observation", "SAO 119422"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.22600777),
        dec: Angle.Degrees(+01.14877576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89932"},
        {"Hipparcos Number", "HIP 50831"},
        {"Fundamental Katalog 5th Edition", "FK5 4921"},
        {"Smithsonian Astrophysical Observation", "SAO 118267"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.68760847),
        dec: Angle.Degrees(+01.15156693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7805"},
        {"Hipparcos Number", "HIP 6049"},
        {"Geneva Identification System", "GEN# +1.00007805"},
        {"Smithsonian Astrophysical Observation", "SAO 109792"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42734647),
        dec: Angle.Degrees(+01.15179667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30585"},
        {"Smithsonian Astrophysical Observation", "SAO 113866"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.42210702),
        dec: Angle.Degrees(+01.15191658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201159"},
        {"Hipparcos Number", "HIP 104305"},
        {"Smithsonian Astrophysical Observation", "SAO 126556"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.95503685),
        dec: Angle.Degrees(+01.15387965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36055"},
        {"Hipparcos Number", "HIP 25683"},
        {"Smithsonian Astrophysical Observation", "SAO 112819"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27655835),
        dec: Angle.Degrees(+01.15427526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190412"},
        {"Hipparcos Number", "HIP 98878"},
        {"Geneva Identification System", "GEN# +1.00190412"},
        {"Smithsonian Astrophysical Observation", "SAO 125417"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19419632),
        dec: Angle.Degrees(+01.15609918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18789"},
        {"Hipparcos Number", "HIP 14077"},
        {"Geneva Identification System", "GEN# +1.00018789"},
        {"Smithsonian Astrophysical Observation", "SAO 110908"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.35632489),
        dec: Angle.Degrees(+01.15618297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68905"},
        {"Hipparcos Number", "HIP 40376"},
        {"Smithsonian Astrophysical Observation", "SAO 116524"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66262896),
        dec: Angle.Degrees(+01.15738549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215330"},
        {"Hipparcos Number", "HIP 112264"},
        {"Geneva Identification System", "GEN# +1.00215330"},
        {"Smithsonian Astrophysical Observation", "SAO 127721"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.08584223),
        dec: Angle.Degrees(+01.16005443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87974"},
        {"Hipparcos Number", "HIP 49694"},
        {"Geneva Identification System", "GEN# +1.00087974"},
        {"Smithsonian Astrophysical Observation", "SAO 118131"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.17190052),
        dec: Angle.Degrees(+01.16071719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89823"},
        {"Hipparcos Number", "HIP 50774"},
        {"Smithsonian Astrophysical Observation", "SAO 118258"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.52358565),
        dec: Angle.Degrees(+01.16114137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51219"},
        {"Hipparcos Number", "HIP 33382"},
        {"Cincinnati Publication", "Ci 20 403"},
        {"Cincinnati Publication 2", "Ci 18 841"},
        {"Geneva Identification System", "GEN# +1.00051219"},
        {"Smithsonian Astrophysical Observation", "SAO 114659"},
        {"Wilson Evans Batten Catalogue", "WEB 6711"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14245997),
        dec: Angle.Degrees(+01.16348742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -577.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221194"},
        {"Hipparcos Number", "HIP 115984"},
        {"Geneva Identification System", "GEN# +1.00221194"},
        {"Smithsonian Astrophysical Observation", "SAO 128208"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.48289733),
        dec: Angle.Degrees(+01.16375297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54633"},
    },
    visualMagnitude: 11.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.73185097),
        dec: Angle.Degrees(+01.16387531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162007"},
        {"Hipparcos Number", "HIP 87186"},
        {"Geneva Identification System", "GEN# +1.00162007"},
        {"Smithsonian Astrophysical Observation", "SAO 122774"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.18262683),
        dec: Angle.Degrees(+01.16420483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1576"},
        {"Hipparcos Number", "HIP 1601"},
        {"Geneva Identification System", "GEN# +1.00001576"},
        {"Smithsonian Astrophysical Observation", "SAO 109144"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.01258034),
        dec: Angle.Degrees(+01.16423405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2236"},
        {"Hipparcos Number", "HIP 2073"},
        {"Smithsonian Astrophysical Observation", "SAO 109205"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.55041479),
        dec: Angle.Degrees(+01.16431217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87187"},
    },
    visualMagnitude: 11.31,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.18779709),
        dec: Angle.Degrees(+01.16497768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2484 AB"},
        {"Henry Draper", "HD 20771"},
        {"Hipparcos Number", "HIP 15599"},
        {"Smithsonian Astrophysical Observation", "SAO 111138"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.22253558),
        dec: Angle.Degrees(+01.16501305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59805"},
        {"Hipparcos Number", "HIP 36618"},
        {"Smithsonian Astrophysical Observation", "SAO 115572"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.95511215),
        dec: Angle.Degrees(+01.16525343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107117"},
        {"Hipparcos Number", "HIP 60062"},
        {"Smithsonian Astrophysical Observation", "SAO 119325"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75400558),
        dec: Angle.Degrees(+01.16594778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115213"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.04822322),
        dec: Angle.Degrees(+01.16695629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38529"},
        {"Hipparcos Number", "HIP 27253"},
        {"Geneva Identification System", "GEN# +1.00038529"},
        {"Smithsonian Astrophysical Observation", "SAO 113119"},
        {"Wilson Evans Batten Catalogue", "WEB 5357"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.64566124),
        dec: Angle.Degrees(+01.16853796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43358"},
        {"Hipparcos Number", "HIP 29746"},
        {"Geneva Identification System", "GEN# +1.00043358J"},
        {"Smithsonian Astrophysical Observation", "SAO 113656"},
        {"Wilson Evans Batten Catalogue", "WEB 5871"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.97490252),
        dec: Angle.Degrees(+01.16900467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122254"},
        {"Hipparcos Number", "HIP 68450"},
        {"Smithsonian Astrophysical Observation", "SAO 120224"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.20765053),
        dec: Angle.Degrees(+01.16950399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59500"},
        {"Smithsonian Astrophysical Observation", "SAO 119267"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.03294509),
        dec: Angle.Degrees(+01.16974469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206140"},
        {"Hipparcos Number", "HIP 106991"},
        {"Smithsonian Astrophysical Observation", "SAO 126970"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02933492),
        dec: Angle.Degrees(+01.17481954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67029"},
        {"Hipparcos Number", "HIP 39655"},
        {"Smithsonian Astrophysical Observation", "SAO 116345"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.55835063),
        dec: Angle.Degrees(+01.17738883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32736"},
        {"Hipparcos Number", "HIP 23680"},
        {"Geneva Identification System", "GEN# +1.00032736"},
        {"Smithsonian Astrophysical Observation", "SAO 112406"},
        {"Wilson Evans Batten Catalogue", "WEB 4618"},
    },
    visualMagnitude: 6.10,
    bvColour: 3.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.34880992),
        dec: Angle.Degrees(+01.17763581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192809"},
        {"Hipparcos Number", "HIP 99948"},
        {"Smithsonian Astrophysical Observation", "SAO 125640"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.19163537),
        dec: Angle.Degrees(+01.17873700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288683"},
        {"Hipparcos Number", "HIP 30584"},
        {"Smithsonian Astrophysical Observation", "SAO 113863"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.41953582),
        dec: Angle.Degrees(+01.17882935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31998"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.29121561),
        dec: Angle.Degrees(+01.17987848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150557"},
        {"Hipparcos Number", "HIP 81734"},
        {"Fundamental Katalog 5th Edition", "FK5 3324"},
        {"Geneva Identification System", "GEN# +1.00150557"},
        {"Smithsonian Astrophysical Observation", "SAO 121790"},
        {"Wilson Evans Batten Catalogue", "WEB 13811"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.42725289),
        dec: Angle.Degrees(+01.18110145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47963"},
        {"Hipparcos Number", "HIP 31994"},
        {"Smithsonian Astrophysical Observation", "SAO 114270"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.28636764),
        dec: Angle.Degrees(+01.18112448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62444"},
        {"Wilson Evans Batten Catalogue", "WEB 11087"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.96445543),
        dec: Angle.Degrees(+01.18222439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186025"},
        {"Hipparcos Number", "HIP 96908"},
        {"Geneva Identification System", "GEN# +1.00186025"},
        {"Smithsonian Astrophysical Observation", "SAO 124949"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.49334436),
        dec: Angle.Degrees(+01.18227782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138086"},
        {"Hipparcos Number", "HIP 75859"},
        {"Smithsonian Astrophysical Observation", "SAO 121030"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43244438),
        dec: Angle.Degrees(+01.18230757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109650",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15731 AB"},
        {"Henry Draper", "HD 210775"},
        {"Hipparcos Number", "HIP 109650"},
        {"Smithsonian Astrophysical Observation", "SAO 127373"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.19167246),
        dec: Angle.Degrees(+01.18458073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85989"},
        {"Hipparcos Number", "HIP 48681"},
        {"Smithsonian Astrophysical Observation", "SAO 117996"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.92898224),
        dec: Angle.Degrees(+01.18768279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111515"},
        {"Hipparcos Number", "HIP 62607"},
        {"Cincinnati Publication", "Ci 20 741"},
        {"Cincinnati Publication 2", "Ci 18 1630"},
        {"Geneva Identification System", "GEN# +1.00111515"},
        {"Smithsonian Astrophysical Observation", "SAO 119614"},
        {"Wilson Evans Batten Catalogue", "WEB 11111"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.43697841),
        dec: Angle.Degrees(+01.18960395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -644.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213748"},
        {"Hipparcos Number", "HIP 111365"},
        {"Smithsonian Astrophysical Observation", "SAO 127600"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.42140559),
        dec: Angle.Degrees(+01.19285589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27549"},
        {"Hipparcos Number", "HIP 20312"},
        {"Smithsonian Astrophysical Observation", "SAO 111764"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26964511),
        dec: Angle.Degrees(+01.19438074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92826"},
        {"Smithsonian Astrophysical Observation", "SAO 124036"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.70934449),
        dec: Angle.Degrees(+01.19761029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176074"},
        {"Hipparcos Number", "HIP 93142"},
        {"Smithsonian Astrophysical Observation", "SAO 124109"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.60709290),
        dec: Angle.Degrees(+01.19815087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20672"},
        {"Hipparcos Number", "HIP 15501"},
        {"Smithsonian Astrophysical Observation", "SAO 111127"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.93703297),
        dec: Angle.Degrees(+01.19895520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82887"},
        {"Hipparcos Number", "HIP 47014"},
        {"Smithsonian Astrophysical Observation", "SAO 117783"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.72810882),
        dec: Angle.Degrees(+01.19947483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6465"},
        {"Hipparcos Number", "HIP 5123"},
        {"Smithsonian Astrophysical Observation", "SAO 109663"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.40943445),
        dec: Angle.Degrees(+01.20103114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66354"},
        {"Geneva Identification System", "GEN# +0.00102831"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.00731537),
        dec: Angle.Degrees(+01.20286402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99789"},
        {"Hipparcos Number", "HIP 56015"},
        {"Smithsonian Astrophysical Observation", "SAO 118884"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.19615522),
        dec: Angle.Degrees(+01.20382487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14539"},
        {"Smithsonian Astrophysical Observation", "SAO 110989"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.92730889),
        dec: Angle.Degrees(+01.20572132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123727"},
        {"Hipparcos Number", "HIP 69151"},
        {"Smithsonian Astrophysical Observation", "SAO 120313"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.34018821),
        dec: Angle.Degrees(+01.20779185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75751"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.12582590),
        dec: Angle.Degrees(+01.20845389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16157 AB"},
        {"Henry Draper", "HD 214699"},
        {"Hipparcos Number", "HIP 111900"},
        {"Geneva Identification System", "GEN# +1.00214699"},
        {"Smithsonian Astrophysical Observation", "SAO 127673"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.00210164),
        dec: Angle.Degrees(+01.20919003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84500",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10428 A"},
        {"Henry Draper", "HD 156247"},
        {"Hipparcos Number", "HIP 84500"},
        {"Fundamental Katalog 5th Edition", "FK5 1453"},
        {"Geneva Identification System", "GEN# +1.00156247A"},
        {"Smithsonian Astrophysical Observation", "SAO 122226"},
        {"Wilson Evans Batten Catalogue", "WEB 14264"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13216019),
        dec: Angle.Degrees(+01.21058377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96274"},
        {"Hipparcos Number", "HIP 54260"},
        {"Smithsonian Astrophysical Observation", "SAO 118655"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.50936056),
        dec: Angle.Degrees(+01.21070165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149615"},
        {"Hipparcos Number", "HIP 81263"},
        {"Geneva Identification System", "GEN# +1.00149615"},
        {"Smithsonian Astrophysical Observation", "SAO 121720"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.96593114),
        dec: Angle.Degrees(+01.21213477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151546"},
        {"Hipparcos Number", "HIP 82230"},
        {"Smithsonian Astrophysical Observation", "SAO 121868"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.99399628),
        dec: Angle.Degrees(+01.21328832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10230 AB"},
        {"Henry Draper", "HD 152127"},
        {"Hipparcos Number", "HIP 82480"},
        {"Geneva Identification System", "GEN# +1.00152127"},
        {"Renson", "Renson 43060"},
        {"Smithsonian Astrophysical Observation", "SAO 121911"},
        {"Wilson Evans Batten Catalogue", "WEB 13925"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.85391115),
        dec: Angle.Degrees(+01.21598136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209048"},
        {"Hipparcos Number", "HIP 108635"},
        {"Smithsonian Astrophysical Observation", "SAO 127224"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.11823607),
        dec: Angle.Degrees(+01.21697880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16201 AB"},
        {"Henry Draper", "HD 215129"},
        {"Hipparcos Number", "HIP 112153"},
        {"Smithsonian Astrophysical Observation", "SAO 127707"},
        {"Wilson Evans Batten Catalogue", "WEB 20015"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74206064),
        dec: Angle.Degrees(+01.21738369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148035"},
        {"Hipparcos Number", "HIP 80450"},
        {"Smithsonian Astrophysical Observation", "SAO 121583"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.33009232),
        dec: Angle.Degrees(+01.21876588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289114"},
        {"Hipparcos Number", "HIP 32621"},
        {"Smithsonian Astrophysical Observation", "SAO 114440"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.08779785),
        dec: Angle.Degrees(+01.21897604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9989 AB"},
        {"Henry Draper", "HD 146564"},
        {"Hipparcos Number", "HIP 79774"},
        {"Geneva Identification System", "GEN# +1.00146564"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.21857075),
        dec: Angle.Degrees(+01.22143095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170634"},
        {"Hipparcos Number", "HIP 90707"},
        {"Geneva Identification System", "GEN# +1.00170634"},
        {"Smithsonian Astrophysical Observation", "SAO 123580"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.60364083),
        dec: Angle.Degrees(+01.22324980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64586"},
        {"Smithsonian Astrophysical Observation", "SAO 119827"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.56971546),
        dec: Angle.Degrees(+01.22331679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26105"},
        {"Hipparcos Number", "HIP 19285"},
        {"Geneva Identification System", "GEN# +1.00026105"},
        {"Smithsonian Astrophysical Observation", "SAO 111618"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.99885723),
        dec: Angle.Degrees(+01.22334280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40282"},
        {"Hipparcos Number", "HIP 28232"},
        {"Geneva Identification System", "GEN# +1.00040282"},
        {"Smithsonian Astrophysical Observation", "SAO 113306"},
        {"Wilson Evans Batten Catalogue", "WEB 5524"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.47711006),
        dec: Angle.Degrees(+01.22430693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6924"},
        {"Hipparcos Number", "HIP 5448"},
        {"Smithsonian Astrophysical Observation", "SAO 109708"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.43739181),
        dec: Angle.Degrees(+01.22531996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181439"},
        {"Hipparcos Number", "HIP 95053"},
        {"Geneva Identification System", "GEN# +1.00181439"},
        {"Renson", "Renson 50260"},
        {"Smithsonian Astrophysical Observation", "SAO 124522"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10845957),
        dec: Angle.Degrees(+01.22538196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36002"},
        {"Hipparcos Number", "HIP 25645"},
        {"Smithsonian Astrophysical Observation", "SAO 112808"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.17536047),
        dec: Angle.Degrees(+01.22703145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139044"},
        {"Hipparcos Number", "HIP 76365"},
        {"Geneva Identification System", "GEN# +1.00139044"},
        {"Smithsonian Astrophysical Observation", "SAO 121081"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.95367885),
        dec: Angle.Degrees(+01.22748723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219616"},
        {"Hipparcos Number", "HIP 114965"},
        {"Smithsonian Astrophysical Observation", "SAO 128083"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.27797373),
        dec: Angle.Degrees(+01.23166920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203173"},
        {"Hipparcos Number", "HIP 105366"},
        {"Smithsonian Astrophysical Observation", "SAO 126713"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.13189941),
        dec: Angle.Degrees(+01.23481895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178719"},
        {"Hipparcos Number", "HIP 94131"},
        {"Geneva Identification System", "GEN# +1.00178719"},
        {"Smithsonian Astrophysical Observation", "SAO 124332"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.42561893),
        dec: Angle.Degrees(+01.23505769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165146"},
        {"Hipparcos Number", "HIP 88516"},
        {"Geneva Identification System", "GEN# +1.00165146"},
        {"Smithsonian Astrophysical Observation", "SAO 123088"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.13446694),
        dec: Angle.Degrees(+01.23761186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115386"},
        {"Hipparcos Number", "HIP 64799"},
        {"Geneva Identification System", "GEN# +1.00115386"},
        {"Smithsonian Astrophysical Observation", "SAO 119849"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.21607772),
        dec: Angle.Degrees(+01.24023793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27007"},
        {"Hipparcos Number", "HIP 19906"},
        {"Smithsonian Astrophysical Observation", "SAO 111708"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.05691244),
        dec: Angle.Degrees(+01.24076823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6024 AB"},
        {"Henry Draper", "HD 57732"},
        {"Hipparcos Number", "HIP 35765"},
        {"Smithsonian Astrophysical Observation", "SAO 115353"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.65570371),
        dec: Angle.Degrees(+01.24087954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77822"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.36754766),
        dec: Angle.Degrees(+01.24175269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150618"},
        {"Hipparcos Number", "HIP 81768"},
        {"Geneva Identification System", "GEN# +1.00150618"},
        {"Smithsonian Astrophysical Observation", "SAO 121792"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53049616),
        dec: Angle.Degrees(+01.24175793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206216"},
        {"Hipparcos Number", "HIP 107033"},
        {"Smithsonian Astrophysical Observation", "SAO 126980"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.15320063),
        dec: Angle.Degrees(+01.24248840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126053"},
        {"Hipparcos Number", "HIP 70319"},
        {"Cincinnati Publication", "Ci 20 855"},
        {"Geneva Identification System", "GEN# +1.00126053"},
        {"Smithsonian Astrophysical Observation", "SAO 120424"},
        {"Wilson Evans Batten Catalogue", "WEB 12208"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.81314273),
        dec: Angle.Degrees(+01.24272950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -477.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 491"},
        {"Hipparcos Number", "HIP 769"},
        {"Geneva Identification System", "GEN# +1.00000491"},
        {"Smithsonian Astrophysical Observation", "SAO 109039"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.36674758),
        dec: Angle.Degrees(+01.24402533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7862 A"},
        {"Henry Draper", "HD 92129"},
        {"Hipparcos Number", "HIP 52058"},
        {"Geneva Identification System", "GEN# +1.00092129"},
        {"Smithsonian Astrophysical Observation", "SAO 118406"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.57220990),
        dec: Angle.Degrees(+01.24404479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18571"},
        {"Hipparcos Number", "HIP 13917"},
        {"Geneva Identification System", "GEN# +1.00018571"},
        {"Smithsonian Astrophysical Observation", "SAO 110882"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.81980176),
        dec: Angle.Degrees(+01.24458826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16062"},
        {"Hipparcos Number", "HIP 12013"},
        {"Smithsonian Astrophysical Observation", "SAO 110624"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.72084432),
        dec: Angle.Degrees(+01.24502191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150493"},
        {"Hipparcos Number", "HIP 81691"},
        {"Geneva Identification System", "GEN# +1.00150493"},
        {"Smithsonian Astrophysical Observation", "SAO 121783"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.31975652),
        dec: Angle.Degrees(+01.24548334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113008"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.29634441),
        dec: Angle.Degrees(+01.24575662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99179"},
        {"Hipparcos Number", "HIP 55703"},
        {"Smithsonian Astrophysical Observation", "SAO 118835"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.21147362),
        dec: Angle.Degrees(+01.24589974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53994"},
        {"Smithsonian Astrophysical Observation", "SAO 118632"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.69127195),
        dec: Angle.Degrees(+01.24635075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159758"},
        {"Hipparcos Number", "HIP 86152"},
        {"Smithsonian Astrophysical Observation", "SAO 122552"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.08553033),
        dec: Angle.Degrees(+01.24652455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115640"},
        {"Hipparcos Number", "HIP 64930"},
        {"Smithsonian Astrophysical Observation", "SAO 119863"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.61986669),
        dec: Angle.Degrees(+01.24662763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52061",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7862 B"},
        {"Hipparcos Number", "HIP 52061"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.57490906),
        dec: Angle.Degrees(+01.24673229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71640"},
        {"Hipparcos Number", "HIP 41573"},
        {"Geneva Identification System", "GEN# +1.00071640"},
        {"Smithsonian Astrophysical Observation", "SAO 116802"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15015303),
        dec: Angle.Degrees(+01.24753049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38783"},
        {"Hipparcos Number", "HIP 27412"},
        {"Smithsonian Astrophysical Observation", "SAO 113158"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.07801585),
        dec: Angle.Degrees(+01.24754837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155715"},
        {"Hipparcos Number", "HIP 84247"},
        {"Smithsonian Astrophysical Observation", "SAO 122190"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.32298400),
        dec: Angle.Degrees(+01.24979679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224278"},
        {"Hipparcos Number", "HIP 118035"},
        {"Smithsonian Astrophysical Observation", "SAO 128484"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.13663243),
        dec: Angle.Degrees(+01.25101799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118703"},
        {"Hipparcos Number", "HIP 66551"},
        {"Geneva Identification System", "GEN# +1.00118703"},
        {"Smithsonian Astrophysical Observation", "SAO 120049"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.63017715),
        dec: Angle.Degrees(+01.25492618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220825"},
        {"Hipparcos Number", "HIP 115738"},
        {"Celescope Catalog", "CEL 5619"},
        {"Fundamental Katalog 5th Edition", "FK5 884"},
        {"Geneva Identification System", "GEN# +1.00220825"},
        {"Renson", "Renson 60520"},
        {"Smithsonian Astrophysical Observation", "SAO 128186"},
        {"Wilson Evans Batten Catalogue", "WEB 20479"},
    },
    visualMagnitude: 4.95,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.73293881),
        dec: Angle.Degrees(+01.25583758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68727"},
        {"Hipparcos Number", "HIP 40304"},
        {"Smithsonian Astrophysical Observation", "SAO 116505"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.45809386),
        dec: Angle.Degrees(+01.25686909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82194"},
        {"Hipparcos Number", "HIP 46633"},
        {"Smithsonian Astrophysical Observation", "SAO 117739"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64621633),
        dec: Angle.Degrees(+01.25725094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11457"},
        {"Hipparcos Number", "HIP 8756"},
        {"Geneva Identification System", "GEN# +1.00011457"},
        {"Smithsonian Astrophysical Observation", "SAO 110194"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.15756335),
        dec: Angle.Degrees(+01.25728880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24552"},
        {"Hipparcos Number", "HIP 18261"},
        {"Geneva Identification System", "GEN# +1.00024552"},
        {"Smithsonian Astrophysical Observation", "SAO 111490"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.59425396),
        dec: Angle.Degrees(+01.26190420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75263"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.66699953),
        dec: Angle.Degrees(+01.26469313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205783"},
        {"Hipparcos Number", "HIP 106769"},
        {"Smithsonian Astrophysical Observation", "SAO 126935"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.41128113),
        dec: Angle.Degrees(+01.26480214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78066"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.08993241),
        dec: Angle.Degrees(+01.26625284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74927"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.66401270),
        dec: Angle.Degrees(+01.26642998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195824"},
        {"Hipparcos Number", "HIP 101446"},
        {"Smithsonian Astrophysical Observation", "SAO 125947"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.40468741),
        dec: Angle.Degrees(+01.26924752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135405"},
        {"Hipparcos Number", "HIP 74627"},
        {"Geneva Identification System", "GEN# +1.00135405"},
        {"Smithsonian Astrophysical Observation", "SAO 120913"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.72133928),
        dec: Angle.Degrees(+01.27121073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46377"},
        {"Hipparcos Number", "HIP 31237"},
        {"Smithsonian Astrophysical Observation", "SAO 114039"},
        {"Wilson Evans Batten Catalogue", "WEB 6242"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.27577072),
        dec: Angle.Degrees(+01.27333111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10697"},
        {"Smithsonian Astrophysical Observation", "SAO 110455"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.42563815),
        dec: Angle.Degrees(+01.27429394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9818"},
        {"Hipparcos Number", "HIP 7448"},
        {"Smithsonian Astrophysical Observation", "SAO 110000"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.98237427),
        dec: Angle.Degrees(+01.27501927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33189"},
        {"Hipparcos Number", "HIP 23934"},
        {"Smithsonian Astrophysical Observation", "SAO 112460"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.15614421),
        dec: Angle.Degrees(+01.27635444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3549"},
        {"Hipparcos Number", "HIP 3019"},
        {"Smithsonian Astrophysical Observation", "SAO 109336"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.60571081),
        dec: Angle.Degrees(+01.27801959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77193"},
        {"Hipparcos Number", "HIP 44280"},
        {"Smithsonian Astrophysical Observation", "SAO 117345"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.27599121),
        dec: Angle.Degrees(+01.28015377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9740"},
        {"Hipparcos Number", "HIP 7394"},
        {"Smithsonian Astrophysical Observation", "SAO 109994"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.83406717),
        dec: Angle.Degrees(+01.28062277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31454"},
        {"Hipparcos Number", "HIP 22934"},
        {"Geneva Identification System", "GEN# +1.00031454"},
        {"Smithsonian Astrophysical Observation", "SAO 112227"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.02601890),
        dec: Angle.Degrees(+01.28312543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108177"},
        {"Hipparcos Number", "HIP 60632"},
        {"Cincinnati Publication", "Ci 20 706"},
        {"Geneva Identification System", "GEN# +1.00108177"},
        {"Smithsonian Astrophysical Observation", "SAO 119389"},
        {"Wilson Evans Batten Catalogue", "WEB 10784"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.39572982),
        dec: Angle.Degrees(+01.28510778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -470.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206445"},
        {"Hipparcos Number", "HIP 107144"},
        {"Geneva Identification System", "GEN# +1.00206445"},
        {"Smithsonian Astrophysical Observation", "SAO 126997"},
        {"Wilson Evans Batten Catalogue", "WEB 19354"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.54214706),
        dec: Angle.Degrees(+01.28527344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37323",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6260 AB"},
        {"Henry Draper", "HD 61526"},
        {"Hipparcos Number", "HIP 37323"},
        {"Smithsonian Astrophysical Observation", "SAO 115767"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.93494389),
        dec: Angle.Degrees(+01.28587320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157855"},
        {"Hipparcos Number", "HIP 85298"},
        {"Smithsonian Astrophysical Observation", "SAO 122373"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.44996294),
        dec: Angle.Degrees(+01.28746657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92372"},
        {"Hipparcos Number", "HIP 52205"},
        {"Smithsonian Astrophysical Observation", "SAO 118420"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99344699),
        dec: Angle.Degrees(+01.28798546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42396"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.67355812),
        dec: Angle.Degrees(+01.28863138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -434.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171288"},
        {"Hipparcos Number", "HIP 91016"},
        {"Smithsonian Astrophysical Observation", "SAO 123646"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.49805435),
        dec: Angle.Degrees(+01.29064193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172426"},
        {"Hipparcos Number", "HIP 91535"},
        {"Geneva Identification System", "GEN# +1.00172426"},
        {"Smithsonian Astrophysical Observation", "SAO 123783"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.01691923),
        dec: Angle.Degrees(+01.29110434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1031"},
        {"Hipparcos Number", "HIP 1169"},
        {"Geneva Identification System", "GEN# +1.00001031"},
        {"Smithsonian Astrophysical Observation", "SAO 109084"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.65231452),
        dec: Angle.Degrees(+01.29686825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6750"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.72137616),
        dec: Angle.Degrees(+01.29766874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35912"},
        {"Hipparcos Number", "HIP 25582"},
        {"Celescope Catalog", "CEL 721"},
        {"Geneva Identification System", "GEN# +1.00035912"},
        {"Smithsonian Astrophysical Observation", "SAO 112794"},
        {"Wilson Evans Batten Catalogue", "WEB 4965"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00612814),
        dec: Angle.Degrees(+01.29824815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110236"},
        {"Hipparcos Number", "HIP 61865"},
        {"Smithsonian Astrophysical Observation", "SAO 119528"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17764172),
        dec: Angle.Degrees(+01.29846413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178359"},
        {"Hipparcos Number", "HIP 93990"},
        {"Geneva Identification System", "GEN# +1.00178359"},
        {"Smithsonian Astrophysical Observation", "SAO 124305"},
        {"Wilson Evans Batten Catalogue", "WEB 16356"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.05729245),
        dec: Angle.Degrees(+01.29866361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99595"},
        {"Hipparcos Number", "HIP 55906"},
        {"Smithsonian Astrophysical Observation", "SAO 118870"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.88958279),
        dec: Angle.Degrees(+01.30149461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40501"},
        {"Geneva Identification System", "GEN# +9.80113020"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.03417002),
        dec: Angle.Degrees(+01.30242701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -375.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162774"},
        {"Hipparcos Number", "HIP 87491"},
        {"Geneva Identification System", "GEN# +1.00162774"},
        {"Smithsonian Astrophysical Observation", "SAO 122861"},
        {"Wilson Evans Batten Catalogue", "WEB 14758"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.14776351),
        dec: Angle.Degrees(+01.30504981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
