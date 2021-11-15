using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_86() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91479"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85933223),
        dec: Angle.Degrees(+28.37524509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32962"},
        {"Hipparcos Number", "HIP 23906"},
        {"Smithsonian Astrophysical Observation", "SAO 76973"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.03665774),
        dec: Angle.Degrees(+28.37585436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214349"},
        {"Hipparcos Number", "HIP 111650"},
        {"Smithsonian Astrophysical Observation", "SAO 90650"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.27183700),
        dec: Angle.Degrees(+28.37698042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334216"},
        {"Hipparcos Number", "HIP 100402"},
        {"Smithsonian Astrophysical Observation", "SAO 88570"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40793979),
        dec: Angle.Degrees(+28.38018613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105889"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.68345738),
        dec: Angle.Degrees(+28.38109630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60093"},
        {"Cincinnati Publication", "Ci 20 695"},
        {"Geneva Identification System", "GEN# +0.02902279"},
        {"Wilson Evans Batten Catalogue", "WEB 10685"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.85216737),
        dec: Angle.Degrees(+28.38217879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -650.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147980"},
        {"Hipparcos Number", "HIP 80322"},
        {"Smithsonian Astrophysical Observation", "SAO 84351"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98193806),
        dec: Angle.Degrees(+28.38404327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64467"},
        {"Hipparcos Number", "HIP 38677"},
        {"Geneva Identification System", "GEN# +1.00064467"},
        {"Smithsonian Astrophysical Observation", "SAO 79791"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.78469124),
        dec: Angle.Degrees(+28.38432252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152013"},
        {"Hipparcos Number", "HIP 82359"},
        {"Geneva Identification System", "GEN# +1.00152013"},
        {"Smithsonian Astrophysical Observation", "SAO 84628"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.43348474),
        dec: Angle.Degrees(+28.38509058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73044"},
        {"Hipparcos Number", "HIP 42276"},
        {"Geneva Identification System", "GEN# +1.00073044"},
        {"Smithsonian Astrophysical Observation", "SAO 80290"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.30292316),
        dec: Angle.Degrees(+28.38607405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50317"},
        {"Hipparcos Number", "HIP 33129"},
        {"Geneva Identification System", "GEN# +1.00050317"},
        {"Smithsonian Astrophysical Observation", "SAO 78840"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48387754),
        dec: Angle.Degrees(+28.38701147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188419"},
        {"Hipparcos Number", "HIP 97924"},
        {"Geneva Identification System", "GEN# +1.00188419"},
        {"Smithsonian Astrophysical Observation", "SAO 87899"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.51057725),
        dec: Angle.Degrees(+28.38756649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74624"},
        {"Hipparcos Number", "HIP 43020"},
        {"Geneva Identification System", "GEN# +1.00074624"},
        {"Smithsonian Astrophysical Observation", "SAO 80406"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.50089490),
        dec: Angle.Degrees(+28.38988401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128185"},
        {"Hipparcos Number", "HIP 71288"},
        {"Geneva Identification System", "GEN# +1.00128185"},
        {"Smithsonian Astrophysical Observation", "SAO 83418"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.68377918),
        dec: Angle.Degrees(+28.39418721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13162"},
        {"Hipparcos Number", "HIP 10045"},
        {"Smithsonian Astrophysical Observation", "SAO 75167"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.32694942),
        dec: Angle.Degrees(+28.39422423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180315"},
        {"Hipparcos Number", "HIP 94591"},
        {"Smithsonian Astrophysical Observation", "SAO 86984"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74363038),
        dec: Angle.Degrees(+28.39471570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88749"},
        {"Smithsonian Astrophysical Observation", "SAO 85744"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.76155486),
        dec: Angle.Degrees(+28.39476721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2976 AB"},
        {"Henry Draper", "HD 25694"},
        {"Hipparcos Number", "HIP 19097"},
        {"Smithsonian Astrophysical Observation", "SAO 76444"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.41322926),
        dec: Angle.Degrees(+28.39539159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151625"},
        {"Hipparcos Number", "HIP 82185"},
        {"Geneva Identification System", "GEN# +1.00151625"},
        {"Smithsonian Astrophysical Observation", "SAO 84608"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.85352464),
        dec: Angle.Degrees(+28.39864948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12402"},
        {"Hipparcos Number", "HIP 9493"},
        {"Geneva Identification System", "GEN# +1.00012402"},
        {"Smithsonian Astrophysical Observation", "SAO 75100"},
        {"Wilson Evans Batten Catalogue", "WEB 1991"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.53278750),
        dec: Angle.Degrees(+28.40022662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52771"},
        {"Cincinnati Publication", "Ci 20 589"},
        {"Geneva Identification System", "GEN# +0.02902091"},
        {"Wilson Evans Batten Catalogue", "WEB 9606"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.84601872),
        dec: Angle.Degrees(+28.40087268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -825.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48230"},
        {"Hipparcos Number", "HIP 32225"},
        {"Geneva Identification System", "GEN# +1.00048230"},
        {"Smithsonian Astrophysical Observation", "SAO 78673"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.90898362),
        dec: Angle.Degrees(+28.40181054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221394"},
        {"Hipparcos Number", "HIP 116119"},
        {"Geneva Identification System", "GEN# +1.00221394"},
        {"Renson", "Renson 60670"},
        {"Smithsonian Astrophysical Observation", "SAO 91321"},
        {"Wilson Evans Batten Catalogue", "WEB 20528"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.92937294),
        dec: Angle.Degrees(+28.40352227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156453"},
        {"Hipparcos Number", "HIP 84499"},
        {"Smithsonian Astrophysical Observation", "SAO 84965"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13174004),
        dec: Angle.Degrees(+28.40721122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99473"},
        {"Hipparcos Number", "HIP 55861"},
        {"Geneva Identification System", "GEN# +1.00099473"},
        {"Smithsonian Astrophysical Observation", "SAO 81831"},
        {"Wilson Evans Batten Catalogue", "WEB 10039"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.73982838),
        dec: Angle.Degrees(+28.40726925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159139"},
        {"Hipparcos Number", "HIP 85790"},
        {"Geneva Identification System", "GEN# +1.00159139"},
        {"Smithsonian Astrophysical Observation", "SAO 85182"},
        {"Wilson Evans Batten Catalogue", "WEB 14477"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.95655998),
        dec: Angle.Degrees(+28.40743646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223247"},
        {"Hipparcos Number", "HIP 117360"},
        {"Geneva Identification System", "GEN# +1.00223247"},
        {"Renson", "Renson 61190"},
        {"Smithsonian Astrophysical Observation", "SAO 91492"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.94372254),
        dec: Angle.Degrees(+28.40756883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139224"},
        {"Hipparcos Number", "HIP 76380"},
        {"Smithsonian Astrophysical Observation", "SAO 83903"},
        {"Wilson Evans Batten Catalogue", "WEB 12965"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.99972913),
        dec: Angle.Degrees(+28.40925090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122442"},
        {"Hipparcos Number", "HIP 68494"},
        {"Geneva Identification System", "GEN# +1.00122442"},
        {"Smithsonian Astrophysical Observation", "SAO 83131"},
        {"Wilson Evans Batten Catalogue", "WEB 12000"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.33160210),
        dec: Angle.Degrees(+28.40975494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60180"},
        {"Hipparcos Number", "HIP 36835"},
        {"Smithsonian Astrophysical Observation", "SAO 79510"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61774607),
        dec: Angle.Degrees(+28.41073925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333026"},
        {"Hipparcos Number", "HIP 98057"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.91700023),
        dec: Angle.Degrees(+28.41138402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176914"},
        {"Hipparcos Number", "HIP 93396"},
        {"Geneva Identification System", "GEN# +1.00176914"},
        {"Smithsonian Astrophysical Observation", "SAO 86708"},
        {"Wilson Evans Batten Catalogue", "WEB 16198"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.32491168),
        dec: Angle.Degrees(+28.41200866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84872"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.18949317),
        dec: Angle.Degrees(+28.41277988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201036"},
        {"Hipparcos Number", "HIP 104166"},
        {"Smithsonian Astrophysical Observation", "SAO 89458"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.57862210),
        dec: Angle.Degrees(+28.41326553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104571"},
        {"Smithsonian Astrophysical Observation", "SAO 89512"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.74797063),
        dec: Angle.Degrees(+28.41411261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334753"},
        {"Hipparcos Number", "HIP 101566"},
        {"Geneva Identification System", "GEN# +2.69400164"},
        {"New General Catalogue", "NGC 6940 164"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.76450942),
        dec: Angle.Degrees(+28.41536831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184605"},
        {"Hipparcos Number", "HIP 96242"},
        {"Smithsonian Astrophysical Observation", "SAO 87369"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.54784951),
        dec: Angle.Degrees(+28.41566462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102555"},
        {"Hipparcos Number", "HIP 57591"},
        {"Fundamental Katalog 5th Edition", "FK5 2943"},
        {"Geneva Identification System", "GEN# +1.00102555"},
        {"Smithsonian Astrophysical Observation", "SAO 82000"},
        {"Wilson Evans Batten Catalogue", "WEB 10340"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.10551097),
        dec: Angle.Degrees(+28.41704630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142816"},
        {"Hipparcos Number", "HIP 78001"},
        {"Geneva Identification System", "GEN# +1.00142816"},
        {"Smithsonian Astrophysical Observation", "SAO 84080"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92291006),
        dec: Angle.Degrees(+28.41908322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223138"},
        {"Hipparcos Number", "HIP 117280"},
        {"Smithsonian Astrophysical Observation", "SAO 91482"},
        {"Wilson Evans Batten Catalogue", "WEB 20663"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71838585),
        dec: Angle.Degrees(+28.41973722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266381"},
        {"Hipparcos Number", "HIP 33364"},
        {"Smithsonian Astrophysical Observation", "SAO 78883"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.08564747),
        dec: Angle.Degrees(+28.42266299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 956",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 147 AB"},
        {"Henry Draper", "HD 744"},
        {"Hipparcos Number", "HIP 956"},
        {"Smithsonian Astrophysical Observation", "SAO 73801"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.95912203),
        dec: Angle.Degrees(+28.42325717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224895"},
        {"Hipparcos Number", "HIP 121"},
        {"Geneva Identification System", "GEN# +1.00224895"},
        {"Smithsonian Astrophysical Observation", "SAO 91659"},
        {"Wilson Evans Batten Catalogue", "WEB 19"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.39647681),
        dec: Angle.Degrees(+28.42377416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85286"},
        {"Smithsonian Astrophysical Observation", "SAO 85076"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.40934262),
        dec: Angle.Degrees(+28.42384219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90839"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98343106),
        dec: Angle.Degrees(+28.42408916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129131"},
        {"Hipparcos Number", "HIP 71712"},
        {"Smithsonian Astrophysical Observation", "SAO 83457"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.03410693),
        dec: Angle.Degrees(+28.42662271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30091",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4929 ABC"},
        {"Henry Draper", "HD 43885"},
        {"Hipparcos Number", "HIP 30091"},
        {"Geneva Identification System", "GEN# +1.00043885J"},
        {"Smithsonian Astrophysical Observation", "SAO 78233"},
        {"Wilson Evans Batten Catalogue", "WEB 5984"},
    },
    visualMagnitude: 7.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.99568098),
        dec: Angle.Degrees(+28.42683927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117285"},
    },
    visualMagnitude: 10.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.72386254),
        dec: Angle.Degrees(+28.42813219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253458"},
        {"Hipparcos Number", "HIP 29570"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.45098350),
        dec: Angle.Degrees(+28.42848858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77620"},
        {"Hipparcos Number", "HIP 44543"},
        {"Smithsonian Astrophysical Observation", "SAO 80613"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.13306011),
        dec: Angle.Degrees(+28.42852375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63252"},
        {"Geneva Identification System", "GEN# +0.02902345"},
        {"Smithsonian Astrophysical Observation", "SAO 82582"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.41119917),
        dec: Angle.Degrees(+28.43067377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191746"},
        {"Hipparcos Number", "HIP 99400"},
        {"Geneva Identification System", "GEN# +1.00191746"},
        {"Renson", "Renson 53443"},
        {"Smithsonian Astrophysical Observation", "SAO 88296"},
        {"Wilson Evans Batten Catalogue", "WEB 17745"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.63258507),
        dec: Angle.Degrees(+28.43426843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283444"},
        {"Hipparcos Number", "HIP 19629"},
        {"Geneva Identification System", "GEN# +1.00283444"},
        {"Smithsonian Astrophysical Observation", "SAO 76497"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.08883135),
        dec: Angle.Degrees(+28.43507262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123409"},
        {"Hipparcos Number", "HIP 68955"},
        {"Geneva Identification System", "GEN# +1.00123409"},
        {"Smithsonian Astrophysical Observation", "SAO 83172"},
        {"Wilson Evans Batten Catalogue", "WEB 12048"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.73281832),
        dec: Angle.Degrees(+28.43803914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145729"},
        {"Hipparcos Number", "HIP 79327"},
        {"Geneva Identification System", "GEN# +1.00145729"},
        {"Smithsonian Astrophysical Observation", "SAO 84239"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.84915688),
        dec: Angle.Degrees(+28.43870117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125408"},
        {"Hipparcos Number", "HIP 69922"},
        {"Geneva Identification System", "GEN# +1.00125408"},
        {"Smithsonian Astrophysical Observation", "SAO 83286"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.64086814),
        dec: Angle.Degrees(+28.43918984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89469"},
        {"Hipparcos Number", "HIP 50585"},
        {"Smithsonian Astrophysical Observation", "SAO 81297"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.00959716),
        dec: Angle.Degrees(+28.43951922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187640"},
        {"Hipparcos Number", "HIP 97572"},
        {"Celescope Catalog", "CEL 4855"},
        {"Geneva Identification System", "GEN# +1.00187640"},
        {"Smithsonian Astrophysical Observation", "SAO 87786"},
        {"Wilson Evans Batten Catalogue", "WEB 17159"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.47799734),
        dec: Angle.Degrees(+28.43968047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55012"},
        {"Smithsonian Astrophysical Observation", "SAO 81744"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.95467994),
        dec: Angle.Degrees(+28.44078939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55578"},
        {"Hipparcos Number", "HIP 35022"},
        {"Geneva Identification System", "GEN# +1.00055578"},
        {"Smithsonian Astrophysical Observation", "SAO 79193"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.66203702),
        dec: Angle.Degrees(+28.44165143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16905"},
        {"Smithsonian Astrophysical Observation", "SAO 76034"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.38655117),
        dec: Angle.Degrees(+28.44181844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46531"},
        {"Hipparcos Number", "HIP 31444"},
        {"Smithsonian Astrophysical Observation", "SAO 78526"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.81485245),
        dec: Angle.Degrees(+28.44270522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213372"},
        {"Hipparcos Number", "HIP 111098"},
        {"Geneva Identification System", "GEN# +1.00213372"},
        {"Smithsonian Astrophysical Observation", "SAO 90558"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.60818132),
        dec: Angle.Degrees(+28.44309315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283571"},
        {"Hipparcos Number", "HIP 20387"},
        {"Wilson Evans Batten Catalogue", "WEB 3898"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.48917856),
        dec: Angle.Degrees(+28.44326825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72559"},
        {"Hipparcos Number", "HIP 42082"},
        {"Geneva Identification System", "GEN# +1.00072559"},
        {"Smithsonian Astrophysical Observation", "SAO 80260"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.66181410),
        dec: Angle.Degrees(+28.44373298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74546"},
        {"Hipparcos Number", "HIP 42976"},
        {"Geneva Identification System", "GEN# +1.00074546"},
        {"Smithsonian Astrophysical Observation", "SAO 80398"},
        {"Wilson Evans Batten Catalogue", "WEB 8307"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.38040067),
        dec: Angle.Degrees(+28.44525255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36220"},
        {"Smithsonian Astrophysical Observation", "SAO 79398"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.88436609),
        dec: Angle.Degrees(+28.44549045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65687"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02035261),
        dec: Angle.Degrees(+28.44628172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89034"},
        {"Smithsonian Astrophysical Observation", "SAO 85796"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.58121825),
        dec: Angle.Degrees(+28.44747927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117243"},
        {"Hipparcos Number", "HIP 65747"},
        {"Geneva Identification System", "GEN# +1.00117243"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.16405582),
        dec: Angle.Degrees(+28.44880817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113468"},
        {"Hipparcos Number", "HIP 63733"},
        {"Geneva Identification System", "GEN# +1.00113468"},
        {"Smithsonian Astrophysical Observation", "SAO 82631"},
        {"Wilson Evans Batten Catalogue", "WEB 11270"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.91118876),
        dec: Angle.Degrees(+28.45008940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106581"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.77285925),
        dec: Angle.Degrees(+28.45051514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100041"},
        {"Hipparcos Number", "HIP 56178"},
        {"Geneva Identification System", "GEN# +1.00100041"},
        {"Smithsonian Astrophysical Observation", "SAO 81863"},
        {"Wilson Evans Batten Catalogue", "WEB 10089"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72890550),
        dec: Angle.Degrees(+28.45156543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20097",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "V410 Tau AB"},
        {"Henry Draper", "HD 283518"},
        {"Hipparcos Number", "HIP 20097"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.62959409),
        dec: Angle.Degrees(+28.45454739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25382"},
        {"Hipparcos Number", "HIP 18892"},
        {"Smithsonian Astrophysical Observation", "SAO 76409"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74548589),
        dec: Angle.Degrees(+28.45587910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10681"},
        {"Hipparcos Number", "HIP 8153"},
        {"Smithsonian Astrophysical Observation", "SAO 74899"},
        {"Wilson Evans Batten Catalogue", "WEB 1741"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.21297733),
        dec: Angle.Degrees(+28.45815398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37318"},
        {"Hipparcos Number", "HIP 26574"},
        {"Geneva Identification System", "GEN# +1.00037318"},
        {"Smithsonian Astrophysical Observation", "SAO 77349"},
        {"Wilson Evans Batten Catalogue", "WEB 5238"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.74173695),
        dec: Angle.Degrees(+28.46014504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39304"},
        {"Hipparcos Number", "HIP 27800"},
        {"Geneva Identification System", "GEN# +1.00039304"},
        {"Smithsonian Astrophysical Observation", "SAO 77664"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.24432831),
        dec: Angle.Degrees(+28.46086745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147768"},
        {"Hipparcos Number", "HIP 80228"},
        {"Smithsonian Astrophysical Observation", "SAO 84337"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.67251010),
        dec: Angle.Degrees(+28.46167113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195215"},
        {"Hipparcos Number", "HIP 101041"},
        {"Smithsonian Astrophysical Observation", "SAO 88741"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.25631263),
        dec: Angle.Degrees(+28.46215584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62570"},
        {"Geneva Identification System", "GEN# +0.02902327"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.30529688),
        dec: Angle.Degrees(+28.46381801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107276"},
        {"Hipparcos Number", "HIP 60123"},
        {"Geneva Identification System", "GEN# +5.21110068"},
        {"Renson", "Renson 31080"},
        {"Smithsonian Astrophysical Observation", "SAO 82246"},
        {"Wilson Evans Batten Catalogue", "WEB 10689"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.96096822),
        dec: Angle.Degrees(+28.46437517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335447"},
        {"Hipparcos Number", "HIP 103560"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.73190728),
        dec: Angle.Degrees(+28.46610052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157086"},
        {"Hipparcos Number", "HIP 84797"},
        {"Smithsonian Astrophysical Observation", "SAO 85014"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.99166122),
        dec: Angle.Degrees(+28.46626485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35035"},
        {"Hipparcos Number", "HIP 25160"},
        {"Geneva Identification System", "GEN# +1.00035035"},
        {"Renson", "Renson 8950"},
        {"Smithsonian Astrophysical Observation", "SAO 77138"},
        {"Wilson Evans Batten Catalogue", "WEB 4878"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75589302),
        dec: Angle.Degrees(+28.46895850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141352"},
        {"Hipparcos Number", "HIP 77373"},
        {"Geneva Identification System", "GEN# +1.00141352"},
        {"Smithsonian Astrophysical Observation", "SAO 84005"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.92000308),
        dec: Angle.Degrees(+28.46933212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179338"},
        {"Hipparcos Number", "HIP 94246"},
        {"Geneva Identification System", "GEN# +1.00179338"},
        {"Smithsonian Astrophysical Observation", "SAO 86903"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.76442169),
        dec: Angle.Degrees(+28.46940654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140913"},
        {"Hipparcos Number", "HIP 77152"},
        {"Geneva Identification System", "GEN# +1.00140913"},
        {"Smithsonian Astrophysical Observation", "SAO 83985"},
        {"Wilson Evans Batten Catalogue", "WEB 13079"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.28128319),
        dec: Angle.Degrees(+28.46983604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56603"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.08252361),
        dec: Angle.Degrees(+28.47065315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251807"},
        {"Hipparcos Number", "HIP 29042"},
        {"Smithsonian Astrophysical Observation", "SAO 77985"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.91504320),
        dec: Angle.Degrees(+28.47209051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85479"},
        {"Smithsonian Astrophysical Observation", "SAO 85117"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.03121539),
        dec: Angle.Degrees(+28.47381269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48549"},
        {"Smithsonian Astrophysical Observation", "SAO 81075"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52327267),
        dec: Angle.Degrees(+28.47790028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8356"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.92365607),
        dec: Angle.Degrees(+28.48166107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10296"},
        {"Hipparcos Number", "HIP 7865"},
        {"Geneva Identification System", "GEN# +1.00010296"},
        {"Smithsonian Astrophysical Observation", "SAO 74867"},
        {"Wilson Evans Batten Catalogue", "WEB 1678"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.29724735),
        dec: Angle.Degrees(+28.48192507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135945"},
        {"Hipparcos Number", "HIP 74780"},
        {"Smithsonian Astrophysical Observation", "SAO 83745"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.24543713),
        dec: Angle.Degrees(+28.48382779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68928"},
        {"Geneva Identification System", "GEN# +0.02902491"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.66809658),
        dec: Angle.Degrees(+28.48401946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140555"},
        {"Hipparcos Number", "HIP 76999"},
        {"Smithsonian Astrophysical Observation", "SAO 83963"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.82768523),
        dec: Angle.Degrees(+28.48408877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20318"},
        {"Hipparcos Number", "HIP 15276"},
        {"Smithsonian Astrophysical Observation", "SAO 75835"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.26627843),
        dec: Angle.Degrees(+28.48431509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187162"},
        {"Hipparcos Number", "HIP 97377"},
        {"Fundamental Katalog 5th Edition", "FK5 5747"},
        {"Geneva Identification System", "GEN# +1.00187162"},
        {"Smithsonian Astrophysical Observation", "SAO 87726"},
        {"Wilson Evans Batten Catalogue", "WEB 17113"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86659669),
        dec: Angle.Degrees(+28.48581807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128095"},
        {"Hipparcos Number", "HIP 71254"},
        {"Geneva Identification System", "GEN# +1.00128095"},
        {"Smithsonian Astrophysical Observation", "SAO 83412"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.57224831),
        dec: Angle.Degrees(+28.48626094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8358"},
        {"Smithsonian Astrophysical Observation", "SAO 74936"},
        {"Wilson Evans Batten Catalogue", "WEB 1778"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.92751426),
        dec: Angle.Degrees(+28.48725775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95012"},
        {"Smithsonian Astrophysical Observation", "SAO 87078"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.99659569),
        dec: Angle.Degrees(+28.48832083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56387"},
        {"Hipparcos Number", "HIP 35336"},
        {"Smithsonian Astrophysical Observation", "SAO 79254"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.48913754),
        dec: Angle.Degrees(+28.48866064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5893 AB"},
        {"Henry Draper", "HD 55356"},
        {"Hipparcos Number", "HIP 34943"},
        {"Smithsonian Astrophysical Observation", "SAO 79185"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.45905047),
        dec: Angle.Degrees(+28.49406919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88397"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.75842570),
        dec: Angle.Degrees(+28.49421030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9108"},
        {"Hipparcos Number", "HIP 7004"},
        {"Smithsonian Astrophysical Observation", "SAO 74758"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.53402238),
        dec: Angle.Degrees(+28.49522560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170986"},
        {"Hipparcos Number", "HIP 90764"},
        {"Smithsonian Astrophysical Observation", "SAO 86151"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.77217194),
        dec: Angle.Degrees(+28.49583903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70062"},
        {"Geneva Identification System", "GEN# +0.02902526"},
        {"Smithsonian Astrophysical Observation", "SAO 83294"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.06656204),
        dec: Angle.Degrees(+28.49648599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66217"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.57581894),
        dec: Angle.Degrees(+28.49745515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55079"},
        {"Hipparcos Number", "HIP 34846"},
        {"Smithsonian Astrophysical Observation", "SAO 79167"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.16589723),
        dec: Angle.Degrees(+28.49938917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185269"},
        {"Hipparcos Number", "HIP 96507"},
        {"Geneva Identification System", "GEN# +1.00185269"},
        {"Smithsonian Astrophysical Observation", "SAO 87464"},
        {"Wilson Evans Batten Catalogue", "WEB 16936"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.29900895),
        dec: Angle.Degrees(+28.50006016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80649"},
        {"Hipparcos Number", "HIP 45913"},
        {"Geneva Identification System", "GEN# +1.00080649"},
        {"Smithsonian Astrophysical Observation", "SAO 80781"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.42991664),
        dec: Angle.Degrees(+28.50017968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25228"},
        {"Hipparcos Number", "HIP 18781"},
        {"Geneva Identification System", "GEN# +1.00025228"},
        {"Smithsonian Astrophysical Observation", "SAO 76395"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.35789211),
        dec: Angle.Degrees(+28.50196972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60235"},
        {"Hipparcos Number", "HIP 36859"},
        {"Geneva Identification System", "GEN# +1.00060235"},
        {"Smithsonian Astrophysical Observation", "SAO 79517"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66888184),
        dec: Angle.Degrees(+28.50220965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147467"},
        {"Hipparcos Number", "HIP 80105"},
        {"Smithsonian Astrophysical Observation", "SAO 84316"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.27919663),
        dec: Angle.Degrees(+28.50353289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105020"},
        {"Hipparcos Number", "HIP 58971"},
        {"Geneva Identification System", "GEN# +1.00105020"},
        {"Smithsonian Astrophysical Observation", "SAO 82126"},
        {"Wilson Evans Batten Catalogue", "WEB 10500"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.37738062),
        dec: Angle.Degrees(+28.50557053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131509"},
        {"Hipparcos Number", "HIP 72830"},
        {"Geneva Identification System", "GEN# +1.00131509"},
        {"Smithsonian Astrophysical Observation", "SAO 83568"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.29991803),
        dec: Angle.Degrees(+28.50806068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2322 AB"},
        {"Henry Draper", "HD 18984"},
        {"Hipparcos Number", "HIP 14270"},
        {"Smithsonian Astrophysical Observation", "SAO 75713"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99869213),
        dec: Angle.Degrees(+28.50914301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2840"},
        {"Hipparcos Number", "HIP 2518"},
        {"Geneva Identification System", "GEN# +1.00002840"},
        {"Smithsonian Astrophysical Observation", "SAO 74067"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.98469585),
        dec: Angle.Degrees(+28.50962600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81317"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.12021850),
        dec: Angle.Degrees(+28.51009130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209420"},
        {"Hipparcos Number", "HIP 108823"},
        {"Smithsonian Astrophysical Observation", "SAO 90192"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.69481154),
        dec: Angle.Degrees(+28.51156951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140120"},
        {"Hipparcos Number", "HIP 76806"},
        {"Smithsonian Astrophysical Observation", "SAO 83941"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.23733046),
        dec: Angle.Degrees(+28.51262142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96647"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.74056464),
        dec: Angle.Degrees(+28.51296430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66318"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.87756926),
        dec: Angle.Degrees(+28.51296613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6345"},
        {"Hipparcos Number", "HIP 5072"},
        {"Smithsonian Astrophysical Observation", "SAO 74474"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20881549),
        dec: Angle.Degrees(+28.51444538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190167"},
        {"Hipparcos Number", "HIP 98699"},
        {"Geneva Identification System", "GEN# +1.00190167"},
        {"Smithsonian Astrophysical Observation", "SAO 88115"},
        {"Wilson Evans Batten Catalogue", "WEB 17477"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.69710442),
        dec: Angle.Degrees(+28.51484727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334116"},
        {"Hipparcos Number", "HIP 100021"},
        {"Smithsonian Astrophysical Observation", "SAO 88477"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.39865969),
        dec: Angle.Degrees(+28.51753196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212750"},
        {"Hipparcos Number", "HIP 110740"},
        {"Smithsonian Astrophysical Observation", "SAO 90502"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.52896821),
        dec: Angle.Degrees(+28.51798918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134246"},
        {"Hipparcos Number", "HIP 74052"},
        {"Geneva Identification System", "GEN# +1.00134246"},
        {"Smithsonian Astrophysical Observation", "SAO 83678"},
        {"Wilson Evans Batten Catalogue", "WEB 12648"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.00211278),
        dec: Angle.Degrees(+28.51843248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215715"},
        {"Hipparcos Number", "HIP 112471"},
        {"Smithsonian Astrophysical Observation", "SAO 90782"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.72621463),
        dec: Angle.Degrees(+28.51984253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11962"},
        {"Hipparcos Number", "HIP 9166"},
        {"Smithsonian Astrophysical Observation", "SAO 75052"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.50473478),
        dec: Angle.Degrees(+28.51998759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2839"},
        {"Hipparcos Number", "HIP 2520"},
        {"Geneva Identification System", "GEN# +1.00002839"},
        {"Smithsonian Astrophysical Observation", "SAO 74068"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.98871296),
        dec: Angle.Degrees(+28.52109346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86812"},
        {"Hipparcos Number", "HIP 49132"},
        {"Smithsonian Astrophysical Observation", "SAO 81147"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41397715),
        dec: Angle.Degrees(+28.52184484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199140"},
        {"Hipparcos Number", "HIP 103191"},
        {"Geneva Identification System", "GEN# +1.00199140"},
        {"Smithsonian Astrophysical Observation", "SAO 89265"},
        {"Wilson Evans Batten Catalogue", "WEB 18741"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.59330936),
        dec: Angle.Degrees(+28.52201021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116394"},
        {"Hipparcos Number", "HIP 65298"},
        {"Geneva Identification System", "GEN# +1.00116394"},
        {"Smithsonian Astrophysical Observation", "SAO 82813"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.74809168),
        dec: Angle.Degrees(+28.52214203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84801"},
        {"Hipparcos Number", "HIP 48093"},
        {"Smithsonian Astrophysical Observation", "SAO 81019"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.08400986),
        dec: Angle.Degrees(+28.52235969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192953"},
        {"Hipparcos Number", "HIP 99942"},
        {"Smithsonian Astrophysical Observation", "SAO 88449"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.16439304),
        dec: Angle.Degrees(+28.52292470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14456"},
        {"Hipparcos Number", "HIP 10929"},
        {"Geneva Identification System", "GEN# +1.00014456"},
        {"Smithsonian Astrophysical Observation", "SAO 75293"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.19564289),
        dec: Angle.Degrees(+28.52350484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194469"},
        {"Hipparcos Number", "HIP 100681"},
        {"Geneva Identification System", "GEN# +1.00194469"},
        {"Smithsonian Astrophysical Observation", "SAO 88643"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18847317),
        dec: Angle.Degrees(+28.52476014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164632"},
        {"Hipparcos Number", "HIP 88214"},
        {"Smithsonian Astrophysical Observation", "SAO 85637"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.22700791),
        dec: Angle.Degrees(+28.52546423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30755"},
        {"Hipparcos Number", "HIP 22578"},
        {"Geneva Identification System", "GEN# +1.00030755"},
        {"Smithsonian Astrophysical Observation", "SAO 76788"},
        {"Wilson Evans Batten Catalogue", "WEB 4364"},
    },
    visualMagnitude: 7.66,
    bvColour: 2.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.88027568),
        dec: Angle.Degrees(+28.52692724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198254"},
        {"Hipparcos Number", "HIP 102656"},
        {"Smithsonian Astrophysical Observation", "SAO 89140"},
        {"Wilson Evans Batten Catalogue", "WEB 18608"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.04517992),
        dec: Angle.Degrees(+28.52942523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7351"},
        {"Hipparcos Number", "HIP 5772"},
        {"Geneva Identification System", "GEN# +1.00007351"},
        {"Smithsonian Astrophysical Observation", "SAO 74576"},
        {"Wilson Evans Batten Catalogue", "WEB 1316"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.52027175),
        dec: Angle.Degrees(+28.52970567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79445"},
        {"Smithsonian Astrophysical Observation", "SAO 84248"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.19448371),
        dec: Angle.Degrees(+28.53156321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66891"},
        {"New General Catalogue", "NGC 5272 1346"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.61966770),
        dec: Angle.Degrees(+28.53307036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6588"},
        {"Hipparcos Number", "HIP 5250"},
        {"Smithsonian Astrophysical Observation", "SAO 74498"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.78864560),
        dec: Angle.Degrees(+28.53575800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106022"},
        {"Hipparcos Number", "HIP 59489"},
        {"Geneva Identification System", "GEN# +1.00106022"},
        {"Smithsonian Astrophysical Observation", "SAO 82181"},
        {"Wilson Evans Batten Catalogue", "WEB 10575"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.00404877),
        dec: Angle.Degrees(+28.53646316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89687"},
        {"Hipparcos Number", "HIP 50730"},
        {"Smithsonian Astrophysical Observation", "SAO 81309"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.37249590),
        dec: Angle.Degrees(+28.53659561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148869"},
        {"Hipparcos Number", "HIP 80803"},
        {"Smithsonian Astrophysical Observation", "SAO 84410"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.49432848),
        dec: Angle.Degrees(+28.53922853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49507"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.62546282),
        dec: Angle.Degrees(+28.53979672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111284"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.16879660),
        dec: Angle.Degrees(+28.54066936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49365"},
        {"Hipparcos Number", "HIP 32700"},
        {"Geneva Identification System", "GEN# +1.00049365"},
        {"Smithsonian Astrophysical Observation", "SAO 78773"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.33050923),
        dec: Angle.Degrees(+28.54178931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225024"},
        {"Hipparcos Number", "HIP 214"},
        {"Geneva Identification System", "GEN# +1.00225024"},
        {"Renson", "Renson 61700"},
        {"Smithsonian Astrophysical Observation", "SAO 73709"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.66917246),
        dec: Angle.Degrees(+28.54222144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 450"},
        {"Smithsonian Astrophysical Observation", "SAO 73734"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.34994786),
        dec: Angle.Degrees(+28.54375172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54132"},
        {"Smithsonian Astrophysical Observation", "SAO 81651"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12231629),
        dec: Angle.Degrees(+28.54420932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190003"},
        {"Hipparcos Number", "HIP 98628"},
        {"Geneva Identification System", "GEN# +1.00190003"},
        {"Smithsonian Astrophysical Observation", "SAO 88096"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.48110114),
        dec: Angle.Degrees(+28.54468748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64305"},
        {"Geneva Identification System", "GEN# +0.02902375"},
        {"Smithsonian Astrophysical Observation", "SAO 82691"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.69861076),
        dec: Angle.Degrees(+28.54477140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69024"},
    },
    visualMagnitude: 11.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.95821958),
        dec: Angle.Degrees(+28.54529893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167"},
        {"Hipparcos Number", "HIP 540"},
        {"Smithsonian Astrophysical Observation", "SAO 73744"},
        {"Wilson Evans Batten Catalogue", "WEB 98"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.64810682),
        dec: Angle.Degrees(+28.55343687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103846"},
        {"Hipparcos Number", "HIP 58323"},
        {"Geneva Identification System", "GEN# +1.00103846"},
        {"Smithsonian Astrophysical Observation", "SAO 82074"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.39582888),
        dec: Angle.Degrees(+28.55515492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90841"},
        {"Hipparcos Number", "HIP 51390"},
        {"Geneva Identification System", "GEN# +1.00090841"},
        {"Smithsonian Astrophysical Observation", "SAO 81380"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.44320906),
        dec: Angle.Degrees(+28.55556230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34957"},
        {"Geneva Identification System", "GEN# +0.02801343"},
        {"Smithsonian Astrophysical Observation", "SAO 79186"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.49250979),
        dec: Angle.Degrees(+28.55793741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5164"},
        {"Hipparcos Number", "HIP 4220"},
        {"Geneva Identification System", "GEN# +1.00005164"},
        {"Smithsonian Astrophysical Observation", "SAO 74346"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45681609),
        dec: Angle.Degrees(+28.55826467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218869"},
        {"Hipparcos Number", "HIP 114480"},
        {"Geneva Identification System", "GEN# +1.00218869"},
        {"Smithsonian Astrophysical Observation", "SAO 91068"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.77373446),
        dec: Angle.Degrees(+28.55834137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5328"},
        {"Hipparcos Number", "HIP 4329"},
        {"Geneva Identification System", "GEN# +1.00005328"},
        {"Smithsonian Astrophysical Observation", "SAO 74367"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.85497565),
        dec: Angle.Degrees(+28.55955760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146640"},
        {"Hipparcos Number", "HIP 79726"},
        {"Smithsonian Astrophysical Observation", "SAO 84276"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.07251952),
        dec: Angle.Degrees(+28.56006941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86131"},
        {"Hipparcos Number", "HIP 48805"},
        {"Smithsonian Astrophysical Observation", "SAO 81104"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.31137816),
        dec: Angle.Degrees(+28.56126566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45617",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7284 AB"},
        {"Henry Draper", "HD 79969"},
        {"Hipparcos Number", "HIP 45617"},
        {"Cincinnati Publication", "Ci 20 517"},
        {"Geneva Identification System", "GEN# +1.00079969"},
        {"Smithsonian Astrophysical Observation", "SAO 80745"},
        {"Wilson Evans Batten Catalogue", "WEB 8668"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.47259606),
        dec: Angle.Degrees(+28.56175076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -507.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181600"},
        {"Hipparcos Number", "HIP 95009"},
        {"Smithsonian Astrophysical Observation", "SAO 87077"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.99069047),
        dec: Angle.Degrees(+28.56331267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203471"},
        {"Hipparcos Number", "HIP 105455"},
        {"Geneva Identification System", "GEN# +1.00203471"},
        {"Smithsonian Astrophysical Observation", "SAO 89648"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.39340747),
        dec: Angle.Degrees(+28.56484802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73113"},
        {"Smithsonian Astrophysical Observation", "SAO 83590"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.13884031),
        dec: Angle.Degrees(+28.56493673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11808",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1930 AB"},
        {"Henry Draper", "HD 15705"},
        {"Hipparcos Number", "HIP 11808"},
        {"Geneva Identification System", "GEN# +1.00015705J"},
        {"Smithsonian Astrophysical Observation", "SAO 75426"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.07037084),
        dec: Angle.Degrees(+28.56663161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6643",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Belenos"},
        {"Henry Draper", "HD 8574"},
        {"Hipparcos Number", "HIP 6643"},
        {"Geneva Identification System", "GEN# +1.00008574"},
        {"Smithsonian Astrophysical Observation", "SAO 74702"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.30145418),
        dec: Angle.Degrees(+28.56707875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 252.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115782"},
        {"Hipparcos Number", "HIP 64976"},
        {"Geneva Identification System", "GEN# +1.00115782"},
        {"Smithsonian Astrophysical Observation", "SAO 82777"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.75824847),
        dec: Angle.Degrees(+28.56755515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117497"},
        {"Hipparcos Number", "HIP 65882"},
        {"Geneva Identification System", "GEN# +1.00117497"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.57031525),
        dec: Angle.Degrees(+28.56793120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58500"},
        {"Geneva Identification System", "GEN# +0.02902243"},
        {"Smithsonian Astrophysical Observation", "SAO 82090"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.95880543),
        dec: Angle.Degrees(+28.56879127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141656"},
        {"Hipparcos Number", "HIP 77479"},
        {"Smithsonian Astrophysical Observation", "SAO 84017"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.30682033),
        dec: Angle.Degrees(+28.57061559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34626"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.58733621),
        dec: Angle.Degrees(+28.57277179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73705"},
        {"Hipparcos Number", "HIP 42577"},
        {"Smithsonian Astrophysical Observation", "SAO 80346"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.17970093),
        dec: Angle.Degrees(+28.57282187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109941"},
        {"Hipparcos Number", "HIP 61669"},
        {"Geneva Identification System", "GEN# +1.00109941"},
        {"Smithsonian Astrophysical Observation", "SAO 82413"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.63021839),
        dec: Angle.Degrees(+28.57306133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6382 A"},
        {"Henry Draper", "HD 63238"},
        {"Hipparcos Number", "HIP 38144"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.25348594),
        dec: Angle.Degrees(+28.57399234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199418"},
        {"Hipparcos Number", "HIP 103336"},
        {"Smithsonian Astrophysical Observation", "SAO 89302"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.03774611),
        dec: Angle.Degrees(+28.57529158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114579"},
        {"Smithsonian Astrophysical Observation", "SAO 91087"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.17114690),
        dec: Angle.Degrees(+28.57709730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187524"},
        {"Hipparcos Number", "HIP 97528"},
        {"Geneva Identification System", "GEN# +1.00187524"},
        {"Smithsonian Astrophysical Observation", "SAO 87771"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.32995170),
        dec: Angle.Degrees(+28.57910045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182617"},
        {"Hipparcos Number", "HIP 95397"},
        {"Smithsonian Astrophysical Observation", "SAO 87166"},
        {"Wilson Evans Batten Catalogue", "WEB 16676"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.09070545),
        dec: Angle.Degrees(+28.58011646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90861"},
        {"Hipparcos Number", "HIP 51399"},
        {"Fundamental Katalog 5th Edition", "FK5 1271"},
        {"Geneva Identification System", "GEN# +1.00090861"},
        {"Smithsonian Astrophysical Observation", "SAO 81381"},
        {"Wilson Evans Batten Catalogue", "WEB 9385"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.47370104),
        dec: Angle.Degrees(+28.58122314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118082"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.29369925),
        dec: Angle.Degrees(+28.58185434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204642"},
        {"Hipparcos Number", "HIP 106081"},
        {"Geneva Identification System", "GEN# +1.00204642"},
        {"Smithsonian Astrophysical Observation", "SAO 89742"},
        {"Wilson Evans Batten Catalogue", "WEB 19228"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.31420226),
        dec: Angle.Degrees(+28.58334620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9666"},
        {"Smithsonian Astrophysical Observation", "SAO 75121"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.08074424),
        dec: Angle.Degrees(+28.58412067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117777"},
        {"Hipparcos Number", "HIP 66017"},
        {"Geneva Identification System", "GEN# +1.00117777"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.01411994),
        dec: Angle.Degrees(+28.58470227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1094"},
        {"Hipparcos Number", "HIP 1234"},
        {"Geneva Identification System", "GEN# +1.00001094"},
        {"Smithsonian Astrophysical Observation", "SAO 73846"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.83963432),
        dec: Angle.Degrees(+28.58737734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126778"},
        {"Hipparcos Number", "HIP 70635"},
        {"Geneva Identification System", "GEN# +1.00126778"},
        {"Smithsonian Astrophysical Observation", "SAO 83358"},
        {"Wilson Evans Batten Catalogue", "WEB 12242"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.72548344),
        dec: Angle.Degrees(+28.58937147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132893"},
        {"Hipparcos Number", "HIP 73461"},
        {"Geneva Identification System", "GEN# +1.00132893"},
        {"Smithsonian Astrophysical Observation", "SAO 83617"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.19425145),
        dec: Angle.Degrees(+28.59173068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67046"},
        {"Hipparcos Number", "HIP 39729"},
        {"Smithsonian Astrophysical Observation", "SAO 79954"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.81257353),
        dec: Angle.Degrees(+28.59184196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111614"},
        {"Smithsonian Astrophysical Observation", "SAO 90642"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.17291528),
        dec: Angle.Degrees(+28.59502088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163096"},
        {"Hipparcos Number", "HIP 87548"},
        {"Smithsonian Astrophysical Observation", "SAO 85506"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.28729344),
        dec: Angle.Degrees(+28.60087988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4929"},
        {"Smithsonian Astrophysical Observation", "SAO 74450"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.80808812),
        dec: Angle.Degrees(+28.60549618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 755"},
        {"Hipparcos Number", "HIP 971"},
        {"Geneva Identification System", "GEN# +1.00000755"},
        {"Smithsonian Astrophysical Observation", "SAO 73803"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.00608084),
        dec: Angle.Degrees(+28.60673326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195611"},
        {"Hipparcos Number", "HIP 101248"},
        {"Smithsonian Astrophysical Observation", "SAO 88795"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.84992643),
        dec: Angle.Degrees(+28.60696456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63698"},
        {"Geneva Identification System", "GEN# +0.02902359"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.81228627),
        dec: Angle.Degrees(+28.60704103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142209"},
        {"Hipparcos Number", "HIP 77743"},
        {"Smithsonian Astrophysical Observation", "SAO 84051"},
        {"Wilson Evans Batten Catalogue", "WEB 13154"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.08965755),
        dec: Angle.Degrees(+28.60734497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25428",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Elnath"},
        {"Henry Draper", "HD 35497"},
        {"Hipparcos Number", "HIP 25428"},
        {"Celescope Catalog", "CEL 688"},
        {"Fundamental Katalog 5th Edition", "FK5 202"},
        {"Geneva Identification System", "GEN# +1.00035497"},
        {"Renson", "Renson 9110"},
        {"Smithsonian Astrophysical Observation", "SAO 77168"},
        {"Wilson Evans Batten Catalogue", "WEB 4928"},
    },
    visualMagnitude: 1.65,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.57290804),
        dec: Angle.Degrees(+28.60787346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211006"},
        {"Hipparcos Number", "HIP 109730"},
        {"Geneva Identification System", "GEN# +1.00211006"},
        {"Smithsonian Astrophysical Observation", "SAO 90337"},
        {"Wilson Evans Batten Catalogue", "WEB 19713"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.41104240),
        dec: Angle.Degrees(+28.60802681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187548"},
        {"Hipparcos Number", "HIP 97537"},
        {"Geneva Identification System", "GEN# +1.00187548"},
        {"Smithsonian Astrophysical Observation", "SAO 87774"},
        {"Wilson Evans Batten Catalogue", "WEB 17150"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.36167607),
        dec: Angle.Degrees(+28.61000603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189317"},
        {"Hipparcos Number", "HIP 98296"},
        {"Geneva Identification System", "GEN# +1.00189317"},
        {"Smithsonian Astrophysical Observation", "SAO 88002"},
        {"Wilson Evans Batten Catalogue", "WEB 17336"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.58798252),
        dec: Angle.Degrees(+28.61085068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70480"},
        {"Smithsonian Astrophysical Observation", "SAO 83338"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.24203769),
        dec: Angle.Degrees(+28.61498552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3379 A"},
        {"Henry Draper", "HD 29646"},
        {"Hipparcos Number", "HIP 21819"},
        {"Fundamental Katalog 5th Edition", "FK5 1126"},
        {"Geneva Identification System", "GEN# +1.00029646A"},
        {"Smithsonian Astrophysical Observation", "SAO 76707"},
        {"Wilson Evans Batten Catalogue", "WEB 4194"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.33223225),
        dec: Angle.Degrees(+28.61506693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130917"},
        {"Hipparcos Number", "HIP 72552"},
        {"Fundamental Katalog 5th Edition", "FK5 3171"},
        {"Geneva Identification System", "GEN# +1.00130917"},
        {"Smithsonian Astrophysical Observation", "SAO 83551"},
        {"Wilson Evans Batten Catalogue", "WEB 12474"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.49327659),
        dec: Angle.Degrees(+28.61583341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104314"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.97638896),
        dec: Angle.Degrees(+28.61670234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44434"},
        {"Hipparcos Number", "HIP 30348"},
        {"Smithsonian Astrophysical Observation", "SAO 78294"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.75112292),
        dec: Angle.Degrees(+28.62151845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67266"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80040853),
        dec: Angle.Degrees(+28.62277379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207069"},
        {"Hipparcos Number", "HIP 107451"},
        {"Smithsonian Astrophysical Observation", "SAO 89967"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.45426345),
        dec: Angle.Degrees(+28.62321436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78961"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.79174834),
        dec: Angle.Degrees(+28.62438884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13385"},
        {"Smithsonian Astrophysical Observation", "SAO 75611"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.06061499),
        dec: Angle.Degrees(+28.62521620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216586"},
        {"Hipparcos Number", "HIP 113063"},
        {"Smithsonian Astrophysical Observation", "SAO 90859"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.45320686),
        dec: Angle.Degrees(+28.62596404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69664"},
        {"Smithsonian Astrophysical Observation", "SAO 83255"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.86819037),
        dec: Angle.Degrees(+28.62701402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60383"},
        {"Hipparcos Number", "HIP 36919"},
        {"Smithsonian Astrophysical Observation", "SAO 79531"},
        {"Wilson Evans Batten Catalogue", "WEB 7328"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84990966),
        dec: Angle.Degrees(+28.62764549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178233"},
        {"Hipparcos Number", "HIP 93843"},
        {"Fundamental Katalog 5th Edition", "FK5 1498"},
        {"Geneva Identification System", "GEN# +1.00178233"},
        {"Smithsonian Astrophysical Observation", "SAO 86819"},
        {"Wilson Evans Batten Catalogue", "WEB 16320"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.65701713),
        dec: Angle.Degrees(+28.62838960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71008"},
        {"Hipparcos Number", "HIP 41342"},
        {"Smithsonian Astrophysical Observation", "SAO 80177"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.52573843),
        dec: Angle.Degrees(+28.62865333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109823"},
        {"Hipparcos Number", "HIP 61617"},
        {"Geneva Identification System", "GEN# +1.00109823"},
        {"Smithsonian Astrophysical Observation", "SAO 82405"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.40960996),
        dec: Angle.Degrees(+28.62940773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172244"},
        {"Hipparcos Number", "HIP 91361"},
        {"Smithsonian Astrophysical Observation", "SAO 86264"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.49973923),
        dec: Angle.Degrees(+28.62993513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106479"},
        {"Hipparcos Number", "HIP 59718"},
        {"Geneva Identification System", "GEN# +5.21110030"},
        {"Smithsonian Astrophysical Observation", "SAO 82202"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71566862),
        dec: Angle.Degrees(+28.63038335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63561"},
        {"Geneva Identification System", "GEN# +0.02902355"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.38773798),
        dec: Angle.Degrees(+28.63172064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224085"},
        {"Hipparcos Number", "HIP 117915"},
        {"Cincinnati Publication", "Ci 20 1461"},
        {"Cincinnati Publication 2", "Ci 19 3131"},
        {"Geneva Identification System", "GEN# +1.00224085"},
        {"Smithsonian Astrophysical Observation", "SAO 91578"},
        {"Wilson Evans Batten Catalogue", "WEB 20737"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.76529212),
        dec: Angle.Degrees(+28.63359392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 576.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65855"},
        {"Hipparcos Number", "HIP 39276"},
        {"Smithsonian Astrophysical Observation", "SAO 79870"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.46748143),
        dec: Angle.Degrees(+28.63369182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106184"},
        {"Hipparcos Number", "HIP 59578"},
        {"Geneva Identification System", "GEN# +5.21110022"},
        {"Smithsonian Astrophysical Observation", "SAO 82189"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.26286919),
        dec: Angle.Degrees(+28.63492416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71067"},
        {"Smithsonian Astrophysical Observation", "SAO 83392"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00350161),
        dec: Angle.Degrees(+28.63609863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47228"},
    },
    visualMagnitude: 12.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.38290303),
        dec: Angle.Degrees(+28.63638907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23849"},
        {"Hipparcos Number", "HIP 17871"},
        {"Smithsonian Astrophysical Observation", "SAO 76235"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.35545392),
        dec: Angle.Degrees(+28.63659059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2672 A"},
        {"Hipparcos Number", "HIP 17156"},
        {"Smithsonian Astrophysical Observation", "SAO 76068"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.12153556),
        dec: Angle.Degrees(+28.63754297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15931"},
        {"Hipparcos Number", "HIP 11977"},
        {"Geneva Identification System", "GEN# +1.00015931"},
        {"Smithsonian Astrophysical Observation", "SAO 75446"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.62584092),
        dec: Angle.Degrees(+28.64077807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1770 A"},
        {"Henry Draper", "HD 14252"},
        {"Hipparcos Number", "HIP 10793"},
        {"Geneva Identification System", "GEN# +1.00014252"},
        {"Smithsonian Astrophysical Observation", "SAO 75276"},
        {"Wilson Evans Batten Catalogue", "WEB 2271"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.73745342),
        dec: Angle.Degrees(+28.64267411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3021 AB"},
        {"Henry Draper", "HD 26126"},
        {"Hipparcos Number", "HIP 19385"},
        {"Geneva Identification System", "GEN# +1.00026126J"},
        {"Smithsonian Astrophysical Observation", "SAO 76478"},
        {"Wilson Evans Batten Catalogue", "WEB 3720"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.28568335),
        dec: Angle.Degrees(+28.64305137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142161"},
        {"Hipparcos Number", "HIP 77715"},
        {"Smithsonian Astrophysical Observation", "SAO 84045"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99941985),
        dec: Angle.Degrees(+28.64372533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174126"},
        {"Hipparcos Number", "HIP 92228"},
        {"Geneva Identification System", "GEN# +1.00174126"},
        {"Smithsonian Astrophysical Observation", "SAO 86446"},
        {"Wilson Evans Batten Catalogue", "WEB 15910"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.93749753),
        dec: Angle.Degrees(+28.64378174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96262"},
        {"Smithsonian Astrophysical Observation", "SAO 87374"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.59901151),
        dec: Angle.Degrees(+28.64527275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182953"},
        {"Hipparcos Number", "HIP 95551"},
        {"Smithsonian Astrophysical Observation", "SAO 87204"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52831668),
        dec: Angle.Degrees(+28.64529958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121164"},
        {"Hipparcos Number", "HIP 67782"},
        {"Fundamental Katalog 5th Edition", "FK5 3106"},
        {"Geneva Identification System", "GEN# +1.00121164"},
        {"Smithsonian Astrophysical Observation", "SAO 83055"},
        {"Wilson Evans Batten Catalogue", "WEB 11915"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.29317893),
        dec: Angle.Degrees(+28.64806212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46269",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7365 AB"},
        {"Henry Draper", "HD 81387"},
        {"Hipparcos Number", "HIP 46269"},
        {"Geneva Identification System", "GEN# +1.00081387J"},
        {"Smithsonian Astrophysical Observation", "SAO 80830"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.50972416),
        dec: Angle.Degrees(+28.65042064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21062"},
        {"Hipparcos Number", "HIP 15902"},
        {"Geneva Identification System", "GEN# +1.00021062"},
        {"Smithsonian Astrophysical Observation", "SAO 75918"},
        {"Wilson Evans Batten Catalogue", "WEB 3035"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.20398361),
        dec: Angle.Degrees(+28.65268439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 598"},
        {"Hipparcos Number", "HIP 852"},
        {"Smithsonian Astrophysical Observation", "SAO 73785"},
        {"Wilson Evans Batten Catalogue", "WEB 142"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.61150772),
        dec: Angle.Degrees(+28.65292193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21842"},
    },
    visualMagnitude: 10.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.44144819),
        dec: Angle.Degrees(+28.65356144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136201"},
        {"Hipparcos Number", "HIP 74899"},
        {"Smithsonian Astrophysical Observation", "SAO 83757"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.60598254),
        dec: Angle.Degrees(+28.65411775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284053"},
        {"Hipparcos Number", "HIP 23591"},
        {"Smithsonian Astrophysical Observation", "SAO 76935"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.09211151),
        dec: Angle.Degrees(+28.65990974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29696"},
        {"Hipparcos Number", "HIP 21845"},
        {"Smithsonian Astrophysical Observation", "SAO 76711"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.44686233),
        dec: Angle.Degrees(+28.66001149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30111"},
        {"Hipparcos Number", "HIP 22138"},
        {"Smithsonian Astrophysical Observation", "SAO 76738"},
        {"Wilson Evans Batten Catalogue", "WEB 4255"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.45862808),
        dec: Angle.Degrees(+28.66075717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73954"},
        {"Hipparcos Number", "HIP 42699"},
        {"Fundamental Katalog 5th Edition", "FK5 4781"},
        {"Smithsonian Astrophysical Observation", "SAO 80365"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.53153944),
        dec: Angle.Degrees(+28.66194051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335256"},
        {"Hipparcos Number", "HIP 102786"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.36140533),
        dec: Angle.Degrees(+28.66519345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95187"},
        {"Cincinnati Publication", "Ci 20 1149"},
        {"Geneva Identification System", "GEN# +6.10010756"},
        {"Geneva Identification System 2", "GEN# +9.80185019"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.46189748),
        dec: Angle.Degrees(+28.66554957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 866.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 265.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252369"},
        {"Hipparcos Number", "HIP 29198"},
        {"Smithsonian Astrophysical Observation", "SAO 78042"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.38605663),
        dec: Angle.Degrees(+28.66571260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221364"},
        {"Hipparcos Number", "HIP 116102"},
        {"Fundamental Katalog 5th Edition", "FK5 3884"},
        {"Geneva Identification System", "GEN# +1.00221364"},
        {"Smithsonian Astrophysical Observation", "SAO 91318"},
        {"Wilson Evans Batten Catalogue", "WEB 20523"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.87549215),
        dec: Angle.Degrees(+28.66620134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86753"},
        {"Smithsonian Astrophysical Observation", "SAO 85365"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.90027903),
        dec: Angle.Degrees(+28.66627435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10235 AB"},
        {"Henry Draper", "HD 152380"},
        {"Hipparcos Number", "HIP 82510"},
        {"Geneva Identification System", "GEN# +1.00152380J"},
        {"Smithsonian Astrophysical Observation", "SAO 84655"},
        {"Wilson Evans Batten Catalogue", "WEB 13930"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.95873873),
        dec: Angle.Degrees(+28.66629995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6371 AB"},
        {"Henry Draper", "HD 63016"},
        {"Hipparcos Number", "HIP 38055"},
        {"Smithsonian Astrophysical Observation", "SAO 79697"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.99362117),
        dec: Angle.Degrees(+28.66743167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137739"},
        {"Hipparcos Number", "HIP 75602"},
        {"Smithsonian Astrophysical Observation", "SAO 83824"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.69641951),
        dec: Angle.Degrees(+28.66779776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59129"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.87877928),
        dec: Angle.Degrees(+28.66780049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112399"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.49770394),
        dec: Angle.Degrees(+28.66782161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76332"},
        {"Hipparcos Number", "HIP 43882"},
        {"Geneva Identification System", "GEN# +1.00076332"},
        {"Smithsonian Astrophysical Observation", "SAO 80520"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.09565864),
        dec: Angle.Degrees(+28.66814178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76976"},
        {"Hipparcos Number", "HIP 44211"},
        {"Smithsonian Astrophysical Observation", "SAO 80567"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.08626275),
        dec: Angle.Degrees(+28.66870442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23336"},
        {"Hipparcos Number", "HIP 17547"},
        {"Geneva Identification System", "GEN# +1.00023336"},
        {"Smithsonian Astrophysical Observation", "SAO 76143"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.36467927),
        dec: Angle.Degrees(+28.66882772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57393"},
        {"Geneva Identification System", "GEN# +0.02902210"},
        {"Smithsonian Astrophysical Observation", "SAO 81976"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49723420),
        dec: Angle.Degrees(+28.66901720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102056"},
        {"Hipparcos Number", "HIP 57279"},
        {"Geneva Identification System", "GEN# +1.00102056"},
        {"Renson", "Renson 29430"},
        {"Smithsonian Astrophysical Observation", "SAO 81968"},
        {"Wilson Evans Batten Catalogue", "WEB 10300"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.18298322),
        dec: Angle.Degrees(+28.67007661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121626"},
        {"Hipparcos Number", "HIP 68055"},
        {"Fundamental Katalog 5th Edition", "FK5 5228"},
        {"Geneva Identification System", "GEN# +1.00121626"},
        {"Smithsonian Astrophysical Observation", "SAO 83079"},
        {"Wilson Evans Batten Catalogue", "WEB 11947"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.01992895),
        dec: Angle.Degrees(+28.67252486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260919"},
        {"Hipparcos Number", "HIP 31767"},
        {"Smithsonian Astrophysical Observation", "SAO 78577"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66012870),
        dec: Angle.Degrees(+28.67296031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134061"},
        {"Hipparcos Number", "HIP 73968"},
        {"Geneva Identification System", "GEN# +1.00134061"},
        {"Smithsonian Astrophysical Observation", "SAO 83666"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.73852733),
        dec: Angle.Degrees(+28.67332145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176695"},
        {"Hipparcos Number", "HIP 93305"},
        {"Smithsonian Astrophysical Observation", "SAO 86688"},
        {"Wilson Evans Batten Catalogue", "WEB 16179"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.07087872),
        dec: Angle.Degrees(+28.67608932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40894"},
        {"Hipparcos Number", "HIP 28649"},
        {"Geneva Identification System", "GEN# +1.00040894"},
        {"Smithsonian Astrophysical Observation", "SAO 77883"},
        {"Wilson Evans Batten Catalogue", "WEB 5601"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.74743708),
        dec: Angle.Degrees(+28.67701768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4664"},
        {"Smithsonian Astrophysical Observation", "SAO 74421"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.98341019),
        dec: Angle.Degrees(+28.67828130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23525"},
        {"Hipparcos Number", "HIP 17662"},
        {"Smithsonian Astrophysical Observation", "SAO 76180"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.74098008),
        dec: Angle.Degrees(+28.67992807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12295"},
        {"Smithsonian Astrophysical Observation", "SAO 75488"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.58989686),
        dec: Angle.Degrees(+28.68224179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83329"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.45972895),
        dec: Angle.Degrees(+28.68256546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88986"},
        {"Hipparcos Number", "HIP 50316"},
        {"Geneva Identification System", "GEN# +1.00088986"},
        {"Smithsonian Astrophysical Observation", "SAO 81259"},
        {"Wilson Evans Batten Catalogue", "WEB 9239"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.11718400),
        dec: Angle.Degrees(+28.68270332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12916"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.51390106),
        dec: Angle.Degrees(+28.68359311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191445"},
        {"Hipparcos Number", "HIP 99258"},
        {"Smithsonian Astrophysical Observation", "SAO 88251"},
        {"Wilson Evans Batten Catalogue", "WEB 17693"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.23809260),
        dec: Angle.Degrees(+28.68435410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99261",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)08, 58.0900),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)41, 03.700)
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
    primaryId: "HIP 88600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165589"},
        {"Hipparcos Number", "HIP 88600"},
        {"Smithsonian Astrophysical Observation", "SAO 85719"},
        {"Wilson Evans Batten Catalogue", "WEB 15005"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.36128814),
        dec: Angle.Degrees(+28.68550606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212567"},
        {"Hipparcos Number", "HIP 110643"},
        {"Smithsonian Astrophysical Observation", "SAO 90484"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.20349423),
        dec: Angle.Degrees(+28.68565520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92823"},
        {"Hipparcos Number", "HIP 52465"},
        {"Geneva Identification System", "GEN# +1.00092823"},
        {"Smithsonian Astrophysical Observation", "SAO 81491"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.87586347),
        dec: Angle.Degrees(+28.68609560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76112"},
        {"Smithsonian Astrophysical Observation", "SAO 83876"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.17582277),
        dec: Angle.Degrees(+28.68653555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60204"},
        {"Hipparcos Number", "HIP 36841"},
        {"Geneva Identification System", "GEN# +1.00060204J"},
        {"Smithsonian Astrophysical Observation", "SAO 79512"},
        {"Wilson Evans Batten Catalogue", "WEB 7318"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.63162197),
        dec: Angle.Degrees(+28.68657708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85745"},
        {"Hipparcos Number", "HIP 48596"},
        {"Geneva Identification System", "GEN# +1.00085745"},
        {"Smithsonian Astrophysical Observation", "SAO 81078"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.65343178),
        dec: Angle.Degrees(+28.68763357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112486"},
    },
    visualMagnitude: 11.70,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.76621441),
        dec: Angle.Degrees(+29.85238503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 452.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255236"},
        {"Hipparcos Number", "HIP 30137"},
        {"Smithsonian Astrophysical Observation", "SAO 78244"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.13347463),
        dec: Angle.Degrees(+28.68820382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13747"},
        {"Hipparcos Number", "HIP 10446"},
        {"Fundamental Katalog 5th Edition", "FK5 2155"},
        {"Geneva Identification System", "GEN# +1.00013747"},
        {"Smithsonian Astrophysical Observation", "SAO 75223"},
        {"Wilson Evans Batten Catalogue", "WEB 2186"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.65781644),
        dec: Angle.Degrees(+28.69142584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83890"},
        {"Hipparcos Number", "HIP 47582"},
        {"Geneva Identification System", "GEN# +1.00083890"},
        {"Smithsonian Astrophysical Observation", "SAO 80975"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.52877904),
        dec: Angle.Degrees(+28.69175593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108417"},
        {"Smithsonian Astrophysical Observation", "SAO 90136"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.45545207),
        dec: Angle.Degrees(+28.69181965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8496"},
        {"Smithsonian Astrophysical Observation", "SAO 74955"},
        {"Wilson Evans Batten Catalogue", "WEB 1804"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.38255541),
        dec: Angle.Degrees(+28.69320365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189108"},
        {"Hipparcos Number", "HIP 98209"},
        {"Smithsonian Astrophysical Observation", "SAO 87979"},
        {"Wilson Evans Batten Catalogue", "WEB 17321"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.34869096),
        dec: Angle.Degrees(+28.69392234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38233"},
        {"Hipparcos Number", "HIP 27180"},
        {"Smithsonian Astrophysical Observation", "SAO 77509"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.40266846),
        dec: Angle.Degrees(+28.69444068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192518"},
        {"Hipparcos Number", "HIP 99738"},
        {"Geneva Identification System", "GEN# +1.00192518"},
        {"Smithsonian Astrophysical Observation", "SAO 88391"},
        {"Wilson Evans Batten Catalogue", "WEB 17897"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.56050449),
        dec: Angle.Degrees(+28.69486353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220254"},
        {"Hipparcos Number", "HIP 115366"},
        {"Geneva Identification System", "GEN# +1.00220254"},
        {"Smithsonian Astrophysical Observation", "SAO 91211"},
        {"Wilson Evans Batten Catalogue", "WEB 20432"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.52058475),
        dec: Angle.Degrees(+28.69499805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125077"},
        {"Hipparcos Number", "HIP 69752"},
        {"Smithsonian Astrophysical Observation", "SAO 83264"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.13983215),
        dec: Angle.Degrees(+28.69687214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11529 AB"},
        {"Henry Draper", "HD 172325"},
        {"Hipparcos Number", "HIP 91392"},
        {"Smithsonian Astrophysical Observation", "SAO 86271"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.59356793),
        dec: Angle.Degrees(+28.69706909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8495"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.37863516),
        dec: Angle.Degrees(+28.69888628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43628"},
        {"Smithsonian Astrophysical Observation", "SAO 80483"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27990786),
        dec: Angle.Degrees(+28.69918544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91129"},
        {"Geneva Identification System", "GEN# +9.80206034"},
        {"Wilson Evans Batten Catalogue", "WEB 15646"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.82991071),
        dec: Angle.Degrees(+28.69940450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199359"},
        {"Hipparcos Number", "HIP 103314"},
        {"Geneva Identification System", "GEN# +1.00199359"},
        {"Smithsonian Astrophysical Observation", "SAO 89294"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.97160660),
        dec: Angle.Degrees(+28.70080652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50144"},
        {"Smithsonian Astrophysical Observation", "SAO 81244"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.54628682),
        dec: Angle.Degrees(+28.70120345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6902"},
        {"Hipparcos Number", "HIP 5469"},
        {"Smithsonian Astrophysical Observation", "SAO 74526"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.50428733),
        dec: Angle.Degrees(+28.70231663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22860"},
        {"Hipparcos Number", "HIP 17220"},
        {"Renson", "Renson 5830"},
        {"Smithsonian Astrophysical Observation", "SAO 76080"},
        {"Wilson Evans Batten Catalogue", "WEB 3262"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.32661111),
        dec: Angle.Degrees(+28.70279174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223094"},
        {"Hipparcos Number", "HIP 117246"},
        {"Geneva Identification System", "GEN# +1.00223094"},
        {"Smithsonian Astrophysical Observation", "SAO 91476"},
        {"Wilson Evans Batten Catalogue", "WEB 20658"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.60633800),
        dec: Angle.Degrees(+28.70363798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89431"},
        {"Smithsonian Astrophysical Observation", "SAO 85862"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.78775843),
        dec: Angle.Degrees(+28.70625512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72907"},
        {"Hipparcos Number", "HIP 42211"},
        {"Smithsonian Astrophysical Observation", "SAO 80277"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09353054),
        dec: Angle.Degrees(+28.70771416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84061"},
        {"Smithsonian Astrophysical Observation", "SAO 84899"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.78296656),
        dec: Angle.Degrees(+28.70807039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84265"},
        {"Hipparcos Number", "HIP 47819"},
        {"Geneva Identification System", "GEN# +1.00084265"},
        {"Smithsonian Astrophysical Observation", "SAO 80996"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22060365),
        dec: Angle.Degrees(+28.70854596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206588"},
        {"Hipparcos Number", "HIP 107163"},
        {"Smithsonian Astrophysical Observation", "SAO 89918"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.59706107),
        dec: Angle.Degrees(+28.70870437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57649"},
        {"Hipparcos Number", "HIP 35836"},
        {"Smithsonian Astrophysical Observation", "SAO 79348"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.84944736),
        dec: Angle.Degrees(+28.71022127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66770"},
        {"Geneva Identification System", "GEN# +0.02902447"},
        {"Smithsonian Astrophysical Observation", "SAO 82949"},
        {"New General Catalogue", "NGC 5272 122"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.28361325),
        dec: Angle.Degrees(+28.71050168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265379"},
        {"Hipparcos Number", "HIP 33053"},
        {"Smithsonian Astrophysical Observation", "SAO 78826"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27597079),
        dec: Angle.Degrees(+28.71125262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13065"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.98326175),
        dec: Angle.Degrees(+28.71224846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113995"},
        {"Hipparcos Number", "HIP 64021"},
        {"Fundamental Katalog 5th Edition", "FK5 5159"},
        {"Geneva Identification System", "GEN# +1.00113995"},
        {"Smithsonian Astrophysical Observation", "SAO 82658"},
        {"Wilson Evans Batten Catalogue", "WEB 11315"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.79070056),
        dec: Angle.Degrees(+28.71267260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61128"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90317505),
        dec: Angle.Degrees(+28.71270531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20456"},
        {"Hipparcos Number", "HIP 15393"},
        {"Smithsonian Astrophysical Observation", "SAO 75852"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.61159738),
        dec: Angle.Degrees(+28.71353013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44627",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7175 AB"},
        {"Henry Draper", "HD 77822"},
        {"Hipparcos Number", "HIP 44627"},
        {"Smithsonian Astrophysical Observation", "SAO 80620"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.41009324),
        dec: Angle.Degrees(+28.71513816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207470"},
        {"Hipparcos Number", "HIP 107666"},
        {"Smithsonian Astrophysical Observation", "SAO 90017"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.13546999),
        dec: Angle.Degrees(+28.71531282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21242"},
        {"Hipparcos Number", "HIP 16042"},
        {"Geneva Identification System", "GEN# +1.00021242"},
        {"Smithsonian Astrophysical Observation", "SAO 75927"},
        {"Wilson Evans Batten Catalogue", "WEB 3061"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64733938),
        dec: Angle.Degrees(+28.71534096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9158 C"},
        {"Henry Draper", "HD 124346C"},
        {"Hipparcos Number", "HIP 69401"},
        {"Geneva Identification System", "GEN# +1.00124346C"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.11542739),
        dec: Angle.Degrees(+28.71610581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82012"},
        {"Hipparcos Number", "HIP 46591"},
        {"Smithsonian Astrophysical Observation", "SAO 80859"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.51337843),
        dec: Angle.Degrees(+28.71721846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184058"},
        {"Hipparcos Number", "HIP 96029"},
        {"Geneva Identification System", "GEN# +1.00184058"},
        {"Smithsonian Astrophysical Observation", "SAO 87316"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.87465163),
        dec: Angle.Degrees(+28.71725209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9158 AB"},
        {"Henry Draper", "HD 124346"},
        {"Hipparcos Number", "HIP 69399"},
        {"Geneva Identification System", "GEN# +1.00124346J"},
        {"Smithsonian Astrophysical Observation", "SAO 83219"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.11117723),
        dec: Angle.Degrees(+28.71731516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93828"},
        {"Geneva Identification System", "GEN# +0.02803192"},
        {"Smithsonian Astrophysical Observation", "SAO 86814"},
        {"Wilson Evans Batten Catalogue", "WEB 16317"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.61245137),
        dec: Angle.Degrees(+28.71760593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29342"},
        {"Hipparcos Number", "HIP 21617"},
        {"Smithsonian Astrophysical Observation", "SAO 76681"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.61837258),
        dec: Angle.Degrees(+28.71767883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81674"},
        {"Smithsonian Astrophysical Observation", "SAO 84538"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.26929464),
        dec: Angle.Degrees(+28.71876041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98970"},
        {"Hipparcos Number", "HIP 55617"},
        {"Geneva Identification System", "GEN# +1.00098970"},
        {"Smithsonian Astrophysical Observation", "SAO 81800"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.92009330),
        dec: Angle.Degrees(+28.71903032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116563"},
    },
    visualMagnitude: 11.12,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.32651871),
        dec: Angle.Degrees(+28.71904737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4686"},
        {"Hipparcos Number", "HIP 3830"},
        {"Smithsonian Astrophysical Observation", "SAO 74288"},
        {"Wilson Evans Batten Catalogue", "WEB 683"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.29035234),
        dec: Angle.Degrees(+28.71930683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164506"},
        {"Hipparcos Number", "HIP 88151"},
        {"Geneva Identification System", "GEN# +1.00164506"},
        {"Smithsonian Astrophysical Observation", "SAO 85625"},
        {"Wilson Evans Batten Catalogue", "WEB 14895"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06719160),
        dec: Angle.Degrees(+28.71974248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174104"},
        {"Hipparcos Number", "HIP 92223"},
        {"Geneva Identification System", "GEN# +1.00174104"},
        {"Smithsonian Astrophysical Observation", "SAO 86445"},
        {"Wilson Evans Batten Catalogue", "WEB 15909"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.93400852),
        dec: Angle.Degrees(+28.72015725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91634"},
        {"Wilson Evans Batten Catalogue", "WEB 15761"},
    },
    visualMagnitude: 11.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31644428),
        dec: Angle.Degrees(+28.72256334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87444"},
        {"Hipparcos Number", "HIP 49443"},
        {"Smithsonian Astrophysical Observation", "SAO 81176"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.41352561),
        dec: Angle.Degrees(+28.72314559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183753"},
        {"Hipparcos Number", "HIP 95873"},
        {"Geneva Identification System", "GEN# +1.00183753"},
        {"Smithsonian Astrophysical Observation", "SAO 87280"},
        {"Wilson Evans Batten Catalogue", "WEB 16787"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48164219),
        dec: Angle.Degrees(+28.72436509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215956"},
        {"Hipparcos Number", "HIP 112619"},
        {"Geneva Identification System", "GEN# +1.00215956"},
        {"Smithsonian Astrophysical Observation", "SAO 90801"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.13261345),
        dec: Angle.Degrees(+28.72485212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4462"},
        {"Hipparcos Number", "HIP 3681"},
        {"Smithsonian Astrophysical Observation", "SAO 74265"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.77415949),
        dec: Angle.Degrees(+28.72558282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106857"},
        {"Hipparcos Number", "HIP 59910"},
        {"Geneva Identification System", "GEN# +5.21110046"},
        {"Smithsonian Astrophysical Observation", "SAO 82218"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.32969892),
        dec: Angle.Degrees(+28.72635670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283682"},
        {"Hipparcos Number", "HIP 21262"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.42858171),
        dec: Angle.Degrees(+28.72957851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219963"},
        {"Hipparcos Number", "HIP 115189"},
        {"Smithsonian Astrophysical Observation", "SAO 91175"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.96477976),
        dec: Angle.Degrees(+28.73039848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63495"},
        {"Hipparcos Number", "HIP 38261"},
        {"Geneva Identification System", "GEN# +1.00063495"},
        {"Smithsonian Astrophysical Observation", "SAO 79733"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.57549535),
        dec: Angle.Degrees(+28.73134635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146168"},
        {"Hipparcos Number", "HIP 79533"},
        {"Smithsonian Astrophysical Observation", "SAO 84258"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.44932398),
        dec: Angle.Degrees(+28.73220029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36846"},
        {"Geneva Identification System", "GEN# +0.02901553"},
        {"Smithsonian Astrophysical Observation", "SAO 79513"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.64172988),
        dec: Angle.Degrees(+28.73330345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156680"},
        {"Hipparcos Number", "HIP 84614"},
        {"Smithsonian Astrophysical Observation", "SAO 84986"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.45048303),
        dec: Angle.Degrees(+28.73345063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82170"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.83104645),
        dec: Angle.Degrees(+28.73347570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10696"},
        {"Hipparcos Number", "HIP 8175"},
        {"Smithsonian Astrophysical Observation", "SAO 74904"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.27760099),
        dec: Angle.Degrees(+28.73472606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333313"},
        {"Hipparcos Number", "HIP 98434"},
        {"Geneva Identification System", "GEN# +1.00333313"},
        {"Smithsonian Astrophysical Observation", "SAO 88042"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.00140346),
        dec: Angle.Degrees(+28.73504206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14455"},
        {"Hipparcos Number", "HIP 10933"},
        {"Geneva Identification System", "GEN# +1.00014455"},
        {"Smithsonian Astrophysical Observation", "SAO 75294"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.20684866),
        dec: Angle.Degrees(+28.73609531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58099"},
        {"Geneva Identification System", "GEN# +0.02902228"},
        {"Wilson Evans Batten Catalogue", "WEB 10401"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.73887315),
        dec: Angle.Degrees(+28.73834845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -322.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8126"},
        {"Hipparcos Number", "HIP 6315"},
        {"Fundamental Katalog 5th Edition", "FK5 2089"},
        {"Geneva Identification System", "GEN# +1.00008126"},
        {"Smithsonian Astrophysical Observation", "SAO 74647"},
        {"Wilson Evans Batten Catalogue", "WEB 1408"},
    },
    visualMagnitude: 5.23,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28064145),
        dec: Angle.Degrees(+28.73838983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1752 B"},
        {"Henry Draper", "HD 14082B"},
        {"Hipparcos Number", "HIP 10679"},
        {"Geneva Identification System", "GEN# +1.00014082B"},
        {"Smithsonian Astrophysical Observation", "SAO 75264"},
        {"Wilson Evans Batten Catalogue", "WEB 2248"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.35283364),
        dec: Angle.Degrees(+28.74195200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115256"},
        {"Hipparcos Number", "HIP 64696"},
        {"Geneva Identification System", "GEN# +1.00115256"},
        {"Smithsonian Astrophysical Observation", "SAO 82740"},
        {"Wilson Evans Batten Catalogue", "WEB 11439"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.90169611),
        dec: Angle.Degrees(+28.74196822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211696"},
        {"Hipparcos Number", "HIP 110121"},
        {"Smithsonian Astrophysical Observation", "SAO 90406"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.60513330),
        dec: Angle.Degrees(+28.74234542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15270 AB"},
        {"Hipparcos Number", "HIP 107310"},
        {"Geneva Identification System", "GEN# +1.00206826J"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.03501874),
        dec: Angle.Degrees(+28.74322228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 260.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51367"},
        {"Geneva Identification System", "GEN# +0.02902055"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37587078),
        dec: Angle.Degrees(+28.74427872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1752 A"},
        {"Henry Draper", "HD 14082"},
        {"Henry Draper 2", "HD 14082A"},
        {"Hipparcos Number", "HIP 10680"},
        {"Geneva Identification System", "GEN# +1.00014082A"},
        {"Smithsonian Astrophysical Observation", "SAO 75265"},
        {"Wilson Evans Batten Catalogue", "WEB 2247"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.35512322),
        dec: Angle.Degrees(+28.74521994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34987"},
        {"Hipparcos Number", "HIP 25141"},
        {"Geneva Identification System", "GEN# +5.20250167"},
        {"Smithsonian Astrophysical Observation", "SAO 77134"},
        {"Wilson Evans Batten Catalogue", "WEB 4874"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.70561551),
        dec: Angle.Degrees(+28.74695374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40440"},
        {"Hipparcos Number", "HIP 28411"},
        {"Smithsonian Astrophysical Observation", "SAO 77817"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.01019843),
        dec: Angle.Degrees(+28.74702112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169003"},
        {"Hipparcos Number", "HIP 89966"},
        {"Geneva Identification System", "GEN# +1.00169003"},
        {"Smithsonian Astrophysical Observation", "SAO 85963"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.34199536),
        dec: Angle.Degrees(+28.74887688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70688"},
        {"Hipparcos Number", "HIP 41187"},
        {"Geneva Identification System", "GEN# +1.00070688"},
        {"Smithsonian Astrophysical Observation", "SAO 80154"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.07250953),
        dec: Angle.Degrees(+28.75101858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92241"},
        {"Hipparcos Number", "HIP 52170"},
        {"Smithsonian Astrophysical Observation", "SAO 81455"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.87724346),
        dec: Angle.Degrees(+28.75145005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47987"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70987710),
        dec: Angle.Degrees(+28.75436321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206332"},
        {"Hipparcos Number", "HIP 107040"},
        {"Geneva Identification System", "GEN# +1.00206332"},
        {"Smithsonian Astrophysical Observation", "SAO 89899"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.17901774),
        dec: Angle.Degrees(+28.75559204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30388",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4994 AB"},
        {"Henry Draper", "HD 44512"},
        {"Hipparcos Number", "HIP 30388"},
        {"Geneva Identification System", "GEN# +1.00044512J"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.84587404),
        dec: Angle.Degrees(+28.75584546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171583"},
        {"Hipparcos Number", "HIP 91056"},
        {"Smithsonian Astrophysical Observation", "SAO 86207"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62179714),
        dec: Angle.Degrees(+28.75616311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157358"},
        {"Hipparcos Number", "HIP 84934"},
        {"Geneva Identification System", "GEN# +1.00157358"},
        {"Smithsonian Astrophysical Observation", "SAO 85028"},
        {"Wilson Evans Batten Catalogue", "WEB 14341"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.38013023),
        dec: Angle.Degrees(+28.75809921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20326"},
        {"Hipparcos Number", "HIP 15274"},
        {"Smithsonian Astrophysical Observation", "SAO 75834"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.26526539),
        dec: Angle.Degrees(+28.75897397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182898"},
        {"Hipparcos Number", "HIP 95521"},
        {"Smithsonian Astrophysical Observation", "SAO 87199"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.45000143),
        dec: Angle.Degrees(+28.75943592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43103",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6988 A"},
        {"Henry Draper", "HD 74739"},
        {"Hipparcos Number", "HIP 43103"},
        {"Fundamental Katalog 5th Edition", "FK5 328"},
        {"Geneva Identification System", "GEN# +1.00074739"},
        {"Smithsonian Astrophysical Observation", "SAO 80416"},
        {"Wilson Evans Batten Catalogue", "WEB 8319"},
    },
    visualMagnitude: 4.03,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.67430955),
        dec: Angle.Degrees(+28.76000509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166014"},
        {"Hipparcos Number", "HIP 88794"},
        {"Fundamental Katalog 5th Edition", "FK5 681"},
        {"Geneva Identification System", "GEN# +1.00166014"},
        {"Smithsonian Astrophysical Observation", "SAO 85750"},
        {"Wilson Evans Batten Catalogue", "WEB 15043"},
    },
    visualMagnitude: 3.84,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.88562824),
        dec: Angle.Degrees(+28.76247025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63138"},
        {"Hipparcos Number", "HIP 38101"},
        {"Geneva Identification System", "GEN# +1.00063138"},
        {"Smithsonian Astrophysical Observation", "SAO 79703"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.12000825),
        dec: Angle.Degrees(+28.76424595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43100",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6988 B"},
        {"Henry Draper", "HD 74738"},
        {"Hipparcos Number", "HIP 43100"},
        {"Geneva Identification System", "GEN# +1.00074738"},
        {"Smithsonian Astrophysical Observation", "SAO 80415"},
        {"Wilson Evans Batten Catalogue", "WEB 8318"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.66665123),
        dec: Angle.Degrees(+28.76516551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11317"},
        {"Geneva Identification System", "GEN# +0.02800413"},
        {"Wilson Evans Batten Catalogue", "WEB 2364"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.41694295),
        dec: Angle.Degrees(+28.76635752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207740"},
        {"Hipparcos Number", "HIP 107821"},
        {"Geneva Identification System", "GEN# +1.00207740"},
        {"Smithsonian Astrophysical Observation", "SAO 90050"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.65105301),
        dec: Angle.Degrees(+28.76722436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208716"},
        {"Hipparcos Number", "HIP 108399"},
        {"Smithsonian Astrophysical Observation", "SAO 90133"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.41089646),
        dec: Angle.Degrees(+28.77083439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80487"},
        {"Smithsonian Astrophysical Observation", "SAO 84370"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.44415537),
        dec: Angle.Degrees(+28.77121640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22766"},
        {"Hipparcos Number", "HIP 17168"},
        {"Smithsonian Astrophysical Observation", "SAO 76071"},
        {"Wilson Evans Batten Catalogue", "WEB 3251"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.16148159),
        dec: Angle.Degrees(+28.77342940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94058"},
        {"Smithsonian Astrophysical Observation", "SAO 86865"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.22772704),
        dec: Angle.Degrees(+28.77458502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195151"},
        {"Hipparcos Number", "HIP 101002"},
        {"Smithsonian Astrophysical Observation", "SAO 88728"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.16062536),
        dec: Angle.Degrees(+28.77598377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66387"},
        {"Smithsonian Astrophysical Observation", "SAO 82899"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.16849614),
        dec: Angle.Degrees(+28.77695813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4104"},
        {"Hipparcos Number", "HIP 3429"},
        {"Smithsonian Astrophysical Observation", "SAO 74226"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.93103274),
        dec: Angle.Degrees(+28.77854374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34384"},
        {"Hipparcos Number", "HIP 24735"},
        {"Geneva Identification System", "GEN# +1.00034384"},
        {"Renson", "Renson 8750"},
        {"Smithsonian Astrophysical Observation", "SAO 77089"},
        {"Wilson Evans Batten Catalogue", "WEB 4788"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.56424654),
        dec: Angle.Degrees(+28.78010553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45623"},
        {"Hipparcos Number", "HIP 30943"},
        {"Smithsonian Astrophysical Observation", "SAO 78431"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.41453491),
        dec: Angle.Degrees(+28.78069067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15270 D"},
        {"Aitken 2", "ADS 15275 A"},
        {"Henry Draper", "HD 206874"},
        {"Hipparcos Number", "HIP 107326"},
        {"Geneva Identification System", "GEN# +1.00206874"},
        {"Smithsonian Astrophysical Observation", "SAO 89944"},
        {"Wilson Evans Batten Catalogue", "WEB 19381"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.07993265),
        dec: Angle.Degrees(+28.78173395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180917"},
        {"Hipparcos Number", "HIP 94795"},
        {"Geneva Identification System", "GEN# +1.00180917"},
        {"Smithsonian Astrophysical Observation", "SAO 87030"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.31808225),
        dec: Angle.Degrees(+28.78270632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174881"},
        {"Hipparcos Number", "HIP 92550"},
        {"Geneva Identification System", "GEN# +1.00174881"},
        {"Smithsonian Astrophysical Observation", "SAO 86512"},
        {"Wilson Evans Batten Catalogue", "WEB 16010"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.89954454),
        dec: Angle.Degrees(+28.78365926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29477"},
        {"Hipparcos Number", "HIP 21707"},
        {"Smithsonian Astrophysical Observation", "SAO 76691"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.91150587),
        dec: Angle.Degrees(+28.78384570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86778"},
        {"Hipparcos Number", "HIP 49103"},
        {"Smithsonian Astrophysical Observation", "SAO 81143"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.32636892),
        dec: Angle.Degrees(+28.78439328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282912"},
        {"Hipparcos Number", "HIP 17775"},
        {"Smithsonian Astrophysical Observation", "SAO 76211"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.07902877),
        dec: Angle.Degrees(+28.78596776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12472"},
        {"Hipparcos Number", "HIP 9559"},
        {"Smithsonian Astrophysical Observation", "SAO 75106"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.69887361),
        dec: Angle.Degrees(+28.78613291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94476"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.42135745),
        dec: Angle.Degrees(+28.78765266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38542"},
        {"Hipparcos Number", "HIP 27376"},
        {"Geneva Identification System", "GEN# +1.00038542"},
        {"Smithsonian Astrophysical Observation", "SAO 77566"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.97207852),
        dec: Angle.Degrees(+28.78950093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68167"},
        {"Geneva Identification System", "GEN# +0.02902477"},
        {"Smithsonian Astrophysical Observation", "SAO 83093"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.33021810),
        dec: Angle.Degrees(+28.78995150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283973"},
        {"Hipparcos Number", "HIP 23141"},
        {"Smithsonian Astrophysical Observation", "SAO 76867"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.69008590),
        dec: Angle.Degrees(+28.79044859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207978"},
        {"Hipparcos Number", "HIP 107975"},
        {"Geneva Identification System", "GEN# +1.00207978"},
        {"Smithsonian Astrophysical Observation", "SAO 90065"},
        {"Wilson Evans Batten Catalogue", "WEB 19470"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12481712),
        dec: Angle.Degrees(+28.79369216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96509"},
        {"Smithsonian Astrophysical Observation", "SAO 87465"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.30026634),
        dec: Angle.Degrees(+28.79539804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1522 AB"},
        {"Henry Draper", "HD 11671"},
        {"Hipparcos Number", "HIP 8938"},
        {"Smithsonian Astrophysical Observation", "SAO 75020"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.78078997),
        dec: Angle.Degrees(+28.79795222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5449"},
        {"Hipparcos Number", "HIP 4424"},
        {"Geneva Identification System", "GEN# +1.00005449"},
        {"Smithsonian Astrophysical Observation", "SAO 74381"},
        {"Wilson Evans Batten Catalogue", "WEB 794"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.17010377),
        dec: Angle.Degrees(+28.79826337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102589"},
        {"Hipparcos Number", "HIP 57604"},
        {"Geneva Identification System", "GEN# +1.00102589"},
        {"Smithsonian Astrophysical Observation", "SAO 82001"},
        {"Wilson Evans Batten Catalogue", "WEB 10343"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.15247625),
        dec: Angle.Degrees(+28.79994890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10621 AB"},
        {"Henry Draper", "HD 159240"},
        {"Hipparcos Number", "HIP 85837"},
        {"Geneva Identification System", "GEN# +1.00159240J"},
        {"Smithsonian Astrophysical Observation", "SAO 85189"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.09570778),
        dec: Angle.Degrees(+28.80443833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114401"},
        {"Hipparcos Number", "HIP 64237"},
        {"Geneva Identification System", "GEN# +1.00114401"},
        {"Smithsonian Astrophysical Observation", "SAO 82685"},
        {"Wilson Evans Batten Catalogue", "WEB 11358"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.48760417),
        dec: Angle.Degrees(+28.80461242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89799"},
        {"Smithsonian Astrophysical Observation", "SAO 85929"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.89743286),
        dec: Angle.Degrees(+28.80633919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6329"},
        {"Smithsonian Astrophysical Observation", "SAO 74650"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.31937914),
        dec: Angle.Degrees(+28.80711340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98468"},
        {"Hipparcos Number", "HIP 55341"},
        {"Smithsonian Astrophysical Observation", "SAO 81775"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.00051651),
        dec: Angle.Degrees(+28.80759303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85047"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.72156248),
        dec: Angle.Degrees(+28.80938867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31119"},
        {"Hipparcos Number", "HIP 22809"},
        {"Smithsonian Astrophysical Observation", "SAO 76821"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.61008694),
        dec: Angle.Degrees(+28.81129909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333456"},
        {"Hipparcos Number", "HIP 98651"},
        {"Geneva Identification System", "GEN# +1.00333456"},
        {"Smithsonian Astrophysical Observation", "SAO 88107"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.56003852),
        dec: Angle.Degrees(+28.81398734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158655"},
        {"Hipparcos Number", "HIP 85571"},
        {"Smithsonian Astrophysical Observation", "SAO 85138"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30622434),
        dec: Angle.Degrees(+28.81424875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207393"},
        {"Hipparcos Number", "HIP 107624"},
        {"Geneva Identification System", "GEN# +1.00207393"},
        {"Smithsonian Astrophysical Observation", "SAO 90008"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.99347093),
        dec: Angle.Degrees(+28.81567876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13835"},
        {"Hipparcos Number", "HIP 10515"},
        {"Smithsonian Astrophysical Observation", "SAO 75234"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.87321064),
        dec: Angle.Degrees(+28.81579833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92729"},
        {"Hipparcos Number", "HIP 52418"},
        {"Smithsonian Astrophysical Observation", "SAO 81484"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.72784157),
        dec: Angle.Degrees(+28.81672980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70178"},
        {"Hipparcos Number", "HIP 40960"},
        {"Geneva Identification System", "GEN# +1.00070178"},
        {"Smithsonian Astrophysical Observation", "SAO 80124"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.39100859),
        dec: Angle.Degrees(+28.81786222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110963"},
        {"Hipparcos Number", "HIP 62261"},
        {"Geneva Identification System", "GEN# +1.00110963"},
        {"Smithsonian Astrophysical Observation", "SAO 82476"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.38414201),
        dec: Angle.Degrees(+28.81805427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11453"},
        {"Hipparcos Number", "HIP 8804"},
        {"Smithsonian Astrophysical Observation", "SAO 74997"},
        {"Wilson Evans Batten Catalogue", "WEB 1853"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.29393462),
        dec: Angle.Degrees(+28.81898352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68254"},
        {"Hipparcos Number", "HIP 40192"},
        {"Geneva Identification System", "GEN# +1.00068254J"},
        {"Smithsonian Astrophysical Observation", "SAO 80012"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.15055480),
        dec: Angle.Degrees(+28.82017574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156874"},
        {"Hipparcos Number", "HIP 84691"},
        {"Fundamental Katalog 5th Edition", "FK5 3375"},
        {"Geneva Identification System", "GEN# +1.00156874"},
        {"Smithsonian Astrophysical Observation", "SAO 85001"},
        {"Wilson Evans Batten Catalogue", "WEB 14301"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.70206340),
        dec: Angle.Degrees(+28.82298375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20671"},
        {"Hipparcos Number", "HIP 15576"},
        {"Smithsonian Astrophysical Observation", "SAO 75878"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.16524231),
        dec: Angle.Degrees(+28.82666764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2552"},
        {"Hipparcos Number", "HIP 2300"},
        {"Geneva Identification System", "GEN# +1.00002552"},
        {"Smithsonian Astrophysical Observation", "SAO 74035"},
        {"Wilson Evans Batten Catalogue", "WEB 424"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.33684537),
        dec: Angle.Degrees(+28.82778053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56051"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.31757751),
        dec: Angle.Degrees(+28.82991356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203287"},
        {"Hipparcos Number", "HIP 105373"},
        {"Geneva Identification System", "GEN# +1.00203287"},
        {"Smithsonian Astrophysical Observation", "SAO 89635"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.14873388),
        dec: Angle.Degrees(+28.83305371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61911"},
        {"Hipparcos Number", "HIP 37575"},
        {"Smithsonian Astrophysical Observation", "SAO 79626"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66786357),
        dec: Angle.Degrees(+28.83389334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40432"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.83852357),
        dec: Angle.Degrees(+28.83473929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118157"},
        {"Hipparcos Number", "HIP 66244"},
        {"Geneva Identification System", "GEN# +1.00118157"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.66061473),
        dec: Angle.Degrees(+28.83589626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150086"},
        {"Hipparcos Number", "HIP 81408"},
        {"Geneva Identification System", "GEN# +1.00150086"},
        {"Smithsonian Astrophysical Observation", "SAO 84491"},
        {"Wilson Evans Batten Catalogue", "WEB 13758"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40342500),
        dec: Angle.Degrees(+28.83624141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140832"},
        {"Hipparcos Number", "HIP 77125"},
        {"Smithsonian Astrophysical Observation", "SAO 83982"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.22442542),
        dec: Angle.Degrees(+28.83674167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109552"},
        {"Hipparcos Number", "HIP 61442"},
        {"Geneva Identification System", "GEN# +1.00109552"},
        {"Smithsonian Astrophysical Observation", "SAO 82395"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.86648743),
        dec: Angle.Degrees(+28.83762219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224493"},
        {"Hipparcos Number", "HIP 118184"},
        {"Geneva Identification System", "GEN# +1.00224493"},
        {"Smithsonian Astrophysical Observation", "SAO 91621"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59733713),
        dec: Angle.Degrees(+28.83866753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111919"},
        {"Hipparcos Number", "HIP 62822"},
        {"Geneva Identification System", "GEN# +1.00111919"},
        {"Smithsonian Astrophysical Observation", "SAO 82544"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.10323402),
        dec: Angle.Degrees(+28.83955749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193987"},
        {"Hipparcos Number", "HIP 100439"},
        {"Geneva Identification System", "GEN# +1.00193987"},
        {"Smithsonian Astrophysical Observation", "SAO 88587"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.53298498),
        dec: Angle.Degrees(+28.84133446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334608"},
        {"Hipparcos Number", "HIP 101257"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.87268771),
        dec: Angle.Degrees(+28.84206194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223461"},
        {"Hipparcos Number", "HIP 117500"},
        {"Fundamental Katalog 5th Edition", "FK5 3913"},
        {"Geneva Identification System", "GEN# +1.00223461"},
        {"Renson", "Renson 61230"},
        {"Smithsonian Astrophysical Observation", "SAO 91522"},
        {"Wilson Evans Batten Catalogue", "WEB 20695"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.41396883),
        dec: Angle.Degrees(+28.84232813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7645"},
        {"Smithsonian Astrophysical Observation", "SAO 74844"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.61691498),
        dec: Angle.Degrees(+28.84553141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211799"},
        {"Hipparcos Number", "HIP 110184"},
        {"Geneva Identification System", "GEN# +1.00211799"},
        {"Smithsonian Astrophysical Observation", "SAO 90415"},
        {"Wilson Evans Batten Catalogue", "WEB 19776"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.77983700),
        dec: Angle.Degrees(+28.84755521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135965"},
        {"Hipparcos Number", "HIP 74792"},
        {"Geneva Identification System", "GEN# +1.00135965"},
        {"Smithsonian Astrophysical Observation", "SAO 83746"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.27137303),
        dec: Angle.Degrees(+28.84823739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9907 AB"},
        {"Henry Draper", "HD 144111"},
        {"Hipparcos Number", "HIP 78637"},
        {"Smithsonian Astrophysical Observation", "SAO 84167"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80192716),
        dec: Angle.Degrees(+28.85180579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43246"},
        {"Hipparcos Number", "HIP 29793"},
        {"Geneva Identification System", "GEN# +1.00043246"},
        {"Smithsonian Astrophysical Observation", "SAO 78165"},
        {"Wilson Evans Batten Catalogue", "WEB 5884"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.09250124),
        dec: Angle.Degrees(+28.85201434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57035"},
        {"Geneva Identification System", "GEN# +0.02902196"},
        {"Smithsonian Astrophysical Observation", "SAO 81944"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.41003213),
        dec: Angle.Degrees(+28.85512335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13996 D"},
        {"Hipparcos Number", "HIP 101402"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.25776387),
        dec: Angle.Degrees(+28.85594469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17054"},
        {"Hipparcos Number", "HIP 12847"},
        {"Smithsonian Astrophysical Observation", "SAO 75550"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.28828890),
        dec: Angle.Degrees(+28.85675515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8541"},
        {"Hipparcos Number", "HIP 6602"},
        {"Smithsonian Astrophysical Observation", "SAO 74696"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20065009),
        dec: Angle.Degrees(+28.85699647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110844"},
        {"Hipparcos Number", "HIP 62191"},
        {"Geneva Identification System", "GEN# +1.00110844"},
        {"Smithsonian Astrophysical Observation", "SAO 82469"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.18406718),
        dec: Angle.Degrees(+28.85775503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111763"},
        {"Hipparcos Number", "HIP 62739"},
        {"Cincinnati Publication", "Ci 18 1638"},
        {"Geneva Identification System", "GEN# +1.00111763"},
        {"Smithsonian Astrophysical Observation", "SAO 82534"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.83310262),
        dec: Angle.Degrees(+28.85796807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3198"},
        {"Smithsonian Astrophysical Observation", "SAO 74191"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19165423),
        dec: Angle.Degrees(+28.85828512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103660"},
        {"Hipparcos Number", "HIP 58206"},
        {"Geneva Identification System", "GEN# +1.00103660"},
        {"Smithsonian Astrophysical Observation", "SAO 82061"},
        {"Wilson Evans Batten Catalogue", "WEB 10419"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.06369109),
        dec: Angle.Degrees(+28.85849175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211888"},
        {"Hipparcos Number", "HIP 110246"},
        {"Smithsonian Astrophysical Observation", "SAO 90424"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.97134929),
        dec: Angle.Degrees(+28.85859353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23427"},
        {"Hipparcos Number", "HIP 17596"},
        {"Smithsonian Astrophysical Observation", "SAO 76165"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.53960528),
        dec: Angle.Degrees(+28.85930957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12052"},
        {"Hipparcos Number", "HIP 9246"},
        {"Smithsonian Astrophysical Observation", "SAO 75067"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72320825),
        dec: Angle.Degrees(+28.86269786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87500"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.17053058),
        dec: Angle.Degrees(+28.86311952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101407",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13996 A"},
        {"Henry Draper", "HD 195894"},
        {"Hipparcos Number", "HIP 101407"},
        {"Smithsonian Astrophysical Observation", "SAO 88827"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.26589088),
        dec: Angle.Degrees(+28.86334132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107864",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 55"},
        {"Hipparcos Number", "HIP 107864"},
        {"Geneva Identification System", "GEN# +0.02804211"},
        {"Renson", "Renson 57770"},
    },
    visualMagnitude: 10.53,
    bvColour: -0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.79602136),
        dec: Angle.Degrees(+28.86413055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114635"},
        {"Hipparcos Number", "HIP 64357"},
        {"Geneva Identification System", "GEN# +1.00114635"},
        {"Smithsonian Astrophysical Observation", "SAO 82698"},
        {"Wilson Evans Batten Catalogue", "WEB 11375"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87097981),
        dec: Angle.Degrees(+28.86792994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219953"},
        {"Hipparcos Number", "HIP 115194"},
        {"Cincinnati Publication", "Ci 20 1418"},
        {"Geneva Identification System", "GEN# +1.00219953"},
        {"Smithsonian Astrophysical Observation", "SAO 91177"},
        {"Wilson Evans Batten Catalogue", "WEB 20405"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.99074690),
        dec: Angle.Degrees(+28.86797386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 741.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6714"},
        {"Hipparcos Number", "HIP 5339"},
        {"Geneva Identification System", "GEN# +1.00006714"},
        {"Smithsonian Astrophysical Observation", "SAO 74510"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.06403620),
        dec: Angle.Degrees(+28.86815555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154842"},
        {"Hipparcos Number", "HIP 83726"},
        {"Renson", "Renson 43740"},
        {"Smithsonian Astrophysical Observation", "SAO 84849"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.68099597),
        dec: Angle.Degrees(+28.86846399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168914"},
        {"Hipparcos Number", "HIP 89935"},
        {"Geneva Identification System", "GEN# +1.00168914"},
        {"Smithsonian Astrophysical Observation", "SAO 85957"},
        {"Wilson Evans Batten Catalogue", "WEB 15358"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25423981),
        dec: Angle.Degrees(+28.86983516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83820"},
        {"Hipparcos Number", "HIP 47553"},
        {"Geneva Identification System", "GEN# +1.00083820"},
        {"Smithsonian Astrophysical Observation", "SAO 80972"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.43173047),
        dec: Angle.Degrees(+28.87062635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78967"},
        {"Hipparcos Number", "HIP 45157"},
        {"Smithsonian Astrophysical Observation", "SAO 80687"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98924502),
        dec: Angle.Degrees(+28.87157651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207059"},
        {"Hipparcos Number", "HIP 107446"},
        {"Smithsonian Astrophysical Observation", "SAO 89966"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.43614899),
        dec: Angle.Degrees(+28.87176261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189213"},
        {"Hipparcos Number", "HIP 98249"},
        {"Celescope Catalog", "CEL 4889"},
        {"Geneva Identification System", "GEN# +1.00189213"},
        {"Smithsonian Astrophysical Observation", "SAO 87991"},
        {"Wilson Evans Batten Catalogue", "WEB 17333"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47688766),
        dec: Angle.Degrees(+28.87418710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51684"},
        {"Geneva Identification System", "GEN# +0.02902061"},
        {"Smithsonian Astrophysical Observation", "SAO 81411"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.37855827),
        dec: Angle.Degrees(+28.87421524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117028"},
        {"Hipparcos Number", "HIP 65615"},
        {"Geneva Identification System", "GEN# +1.00117028"},
        {"Smithsonian Astrophysical Observation", "SAO 82846"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.79525663),
        dec: Angle.Degrees(+28.87427234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108097"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.51847081),
        dec: Angle.Degrees(+28.87599610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332412"},
        {"Hipparcos Number", "HIP 96868"},
        {"Smithsonian Astrophysical Observation", "SAO 87576"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.35356380),
        dec: Angle.Degrees(+28.87681395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63982"},
        {"Geneva Identification System", "GEN# +0.02902367"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.66417255),
        dec: Angle.Degrees(+28.87695731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282909"},
        {"Hipparcos Number", "HIP 23563"},
        {"Geneva Identification System", "GEN# +9.80086023"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.99686589),
        dec: Angle.Degrees(+28.87774061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62044"},
        {"Hipparcos Number", "HIP 37629"},
        {"Geneva Identification System", "GEN# +1.00062044"},
        {"Smithsonian Astrophysical Observation", "SAO 79638"},
        {"Wilson Evans Batten Catalogue", "WEB 7440"},
    },
    visualMagnitude: 4.23,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.82785545),
        dec: Angle.Degrees(+28.88407170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108675"},
        {"Hipparcos Number", "HIP 60908"},
        {"Geneva Identification System", "GEN# +5.21110147"},
        {"Smithsonian Astrophysical Observation", "SAO 82331"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.23626415),
        dec: Angle.Degrees(+28.88618247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14423"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.55163473),
        dec: Angle.Degrees(+28.88649508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171164"},
        {"Hipparcos Number", "HIP 90838"},
        {"Smithsonian Astrophysical Observation", "SAO 86163"},
        {"Wilson Evans Batten Catalogue", "WEB 15574"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.97725222),
        dec: Angle.Degrees(+28.88875074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27404"},
        {"Hipparcos Number", "HIP 20262"},
        {"Geneva Identification System", "GEN# +1.00027404"},
        {"Renson", "Renson 7030"},
        {"Smithsonian Astrophysical Observation", "SAO 76560"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.15738823),
        dec: Angle.Degrees(+28.89208213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221191"},
        {"Hipparcos Number", "HIP 115974"},
        {"Smithsonian Astrophysical Observation", "SAO 91305"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.45642158),
        dec: Angle.Degrees(+28.89540287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72256"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.63757563),
        dec: Angle.Degrees(+28.89694313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45921"},
        {"Smithsonian Astrophysical Observation", "SAO 80785"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.45913540),
        dec: Angle.Degrees(+28.89765522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16860 AB"},
        {"Henry Draper", "HD 221949"},
        {"Hipparcos Number", "HIP 116490"},
        {"Smithsonian Astrophysical Observation", "SAO 91371"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.07719022),
        dec: Angle.Degrees(+28.89885873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1690"},
        {"Smithsonian Astrophysical Observation", "SAO 73912"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.29833234),
        dec: Angle.Degrees(+28.90421402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34250"},
        {"Hipparcos Number", "HIP 24642"},
        {"Fundamental Katalog 5th Edition", "FK5 4478"},
        {"Geneva Identification System", "GEN# +1.00034250"},
        {"Smithsonian Astrophysical Observation", "SAO 77079"},
        {"Wilson Evans Batten Catalogue", "WEB 4769"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.31444619),
        dec: Angle.Degrees(+28.90501143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116723"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.83147156),
        dec: Angle.Degrees(+28.90552900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156696"},
        {"Hipparcos Number", "HIP 84621"},
        {"Smithsonian Astrophysical Observation", "SAO 84990"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.48140194),
        dec: Angle.Degrees(+28.90639881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96287"},
        {"Smithsonian Astrophysical Observation", "SAO 87379"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.66791641),
        dec: Angle.Degrees(+28.90749530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42314"},
        {"Hipparcos Number", "HIP 29352"},
        {"Geneva Identification System", "GEN# +1.00042314"},
        {"Smithsonian Astrophysical Observation", "SAO 78072"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81218128),
        dec: Angle.Degrees(+28.90761784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94458"},
        {"Hipparcos Number", "HIP 53335"},
        {"Geneva Identification System", "GEN# +1.00094458"},
        {"Smithsonian Astrophysical Observation", "SAO 81572"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.62456954),
        dec: Angle.Degrees(+28.90879185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68311"},
        {"Geneva Identification System", "GEN# +0.02902480"},
        {"Smithsonian Astrophysical Observation", "SAO 83106"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.75158515),
        dec: Angle.Degrees(+28.90919805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159519"},
        {"Hipparcos Number", "HIP 85949"},
        {"Geneva Identification System", "GEN# +1.00159519"},
        {"Smithsonian Astrophysical Observation", "SAO 85212"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.49428440),
        dec: Angle.Degrees(+28.90929672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161959"},
        {"Hipparcos Number", "HIP 87052"},
        {"Smithsonian Astrophysical Observation", "SAO 85413"},
        {"Wilson Evans Batten Catalogue", "WEB 14685"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.80690151),
        dec: Angle.Degrees(+28.91018616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7159"},
        {"Hipparcos Number", "HIP 5627"},
        {"Smithsonian Astrophysical Observation", "SAO 74551"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.06975327),
        dec: Angle.Degrees(+28.91020557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84596",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10451 A"},
        {"Henry Draper", "HD 156652"},
        {"Hipparcos Number", "HIP 84596"},
        {"Smithsonian Astrophysical Observation", "SAO 84983"},
        {"Wilson Evans Batten Catalogue", "WEB 14285"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39438910),
        dec: Angle.Degrees(+28.91326173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142243"},
        {"Hipparcos Number", "HIP 77748"},
        {"Smithsonian Astrophysical Observation", "SAO 84053"},
        {"Wilson Evans Batten Catalogue", "WEB 13155"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.12863016),
        dec: Angle.Degrees(+28.91330002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334394"},
        {"Hipparcos Number", "HIP 100726"},
        {"Smithsonian Astrophysical Observation", "SAO 88656"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.31400808),
        dec: Angle.Degrees(+28.91492079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268055"},
        {"Hipparcos Number", "HIP 33923"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.58733081),
        dec: Angle.Degrees(+28.91502542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150567"},
        {"Hipparcos Number", "HIP 81644"},
        {"Geneva Identification System", "GEN# +1.00150567"},
        {"Smithsonian Astrophysical Observation", "SAO 84533"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.17635202),
        dec: Angle.Degrees(+28.91516288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193055"},
        {"Hipparcos Number", "HIP 99999"},
        {"Smithsonian Astrophysical Observation", "SAO 88461"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.30553656),
        dec: Angle.Degrees(+28.91565125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333565"},
        {"Hipparcos Number", "HIP 99017"},
        {"Geneva Identification System", "GEN# +1.00333565"},
        {"Smithsonian Astrophysical Observation", "SAO 88198"},
        {"Wilson Evans Batten Catalogue", "WEB 17600"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.53323599),
        dec: Angle.Degrees(+28.91725322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114037"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.40845814),
        dec: Angle.Degrees(+28.92479725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172310"},
        {"Hipparcos Number", "HIP 91381"},
        {"Cincinnati Publication", "Ci 18 2448"},
        {"Cincinnati Publication 2", "Ci 20 1098"},
        {"Geneva Identification System", "GEN# +1.00172310"},
        {"Smithsonian Astrophysical Observation", "SAO 86267"},
        {"Wilson Evans Batten Catalogue", "WEB 15704"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.56723078),
        dec: Angle.Degrees(+28.92656765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -471.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82411"},
        {"Smithsonian Astrophysical Observation", "SAO 84639"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.62377018),
        dec: Angle.Degrees(+28.92664446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11369 A"},
        {"Henry Draper", "HD 170263"},
        {"Hipparcos Number", "HIP 90445"},
        {"Smithsonian Astrophysical Observation", "SAO 86075"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.82300938),
        dec: Angle.Degrees(+28.92890747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128828"},
        {"Hipparcos Number", "HIP 71586"},
        {"Smithsonian Astrophysical Observation", "SAO 83448"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.60651160),
        dec: Angle.Degrees(+28.92963562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95725"},
        {"Hipparcos Number", "HIP 54024"},
        {"Geneva Identification System", "GEN# +1.00095725"},
        {"Smithsonian Astrophysical Observation", "SAO 81642"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.79783253),
        dec: Angle.Degrees(+28.93013313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41443"},
        {"Geneva Identification System", "GEN# +0.02901754"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.79828942),
        dec: Angle.Degrees(+28.93086090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 229.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41398"},
        {"Hipparcos Number", "HIP 28904"},
        {"Geneva Identification System", "GEN# +1.00041398"},
        {"Smithsonian Astrophysical Observation", "SAO 77949"},
        {"Wilson Evans Batten Catalogue", "WEB 5656"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.52730389),
        dec: Angle.Degrees(+28.93477960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253818"},
        {"Hipparcos Number", "HIP 29675"},
        {"Smithsonian Astrophysical Observation", "SAO 78136"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.77630099),
        dec: Angle.Degrees(+28.93569296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35076"},
        {"Hipparcos Number", "HIP 25192"},
        {"Celescope Catalog", "CEL 660"},
        {"Geneva Identification System", "GEN# +1.00035076"},
        {"Smithsonian Astrophysical Observation", "SAO 77139"},
        {"Wilson Evans Batten Catalogue", "WEB 4882"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.84525767),
        dec: Angle.Degrees(+28.93683899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108388"},
        {"Smithsonian Astrophysical Observation", "SAO 90129"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.37777755),
        dec: Angle.Degrees(+28.93698657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8501 AB"},
        {"Henry Draper", "HD 106887"},
        {"Hipparcos Number", "HIP 59923"},
        {"Geneva Identification System", "GEN# +5.21110047J"},
        {"Renson", "Renson 30930"},
        {"Smithsonian Astrophysical Observation", "SAO 82219"},
        {"Wilson Evans Batten Catalogue", "WEB 10645"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.37748884),
        dec: Angle.Degrees(+28.93710321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94818"},
        {"Hipparcos Number", "HIP 53541"},
        {"Cincinnati Publication", "Ci 18 1329"},
        {"Smithsonian Astrophysical Observation", "SAO 81593"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29651150),
        dec: Angle.Degrees(+28.93843708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 353.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2190"},
        {"Hipparcos Number", "HIP 2055"},
        {"Smithsonian Astrophysical Observation", "SAO 73980"},
        {"Wilson Evans Batten Catalogue", "WEB 389"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51132981),
        dec: Angle.Degrees(+28.94055811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80826"},
        {"Smithsonian Astrophysical Observation", "SAO 84415"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.59288941),
        dec: Angle.Degrees(+28.94113976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160437"},
        {"Hipparcos Number", "HIP 86357"},
        {"Smithsonian Astrophysical Observation", "SAO 85282"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.69434916),
        dec: Angle.Degrees(+28.94148831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30571"},
        {"Hipparcos Number", "HIP 22460"},
        {"Smithsonian Astrophysical Observation", "SAO 76778"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.50032979),
        dec: Angle.Degrees(+28.94205549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39866"},
        {"Hipparcos Number", "HIP 28117"},
        {"Geneva Identification System", "GEN# +1.00039866"},
        {"Smithsonian Astrophysical Observation", "SAO 77744"},
        {"Wilson Evans Batten Catalogue", "WEB 5503"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.14069946),
        dec: Angle.Degrees(+28.94227140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89557"},
        {"Hipparcos Number", "HIP 50650"},
        {"Smithsonian Astrophysical Observation", "SAO 81304"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.16232995),
        dec: Angle.Degrees(+28.94263698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333567"},
        {"Hipparcos Number", "HIP 98992"},
        {"Smithsonian Astrophysical Observation", "SAO 88182"},
        {"Wilson Evans Batten Catalogue", "WEB 17587"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.45225877),
        dec: Angle.Degrees(+28.94311136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99178"},
        {"Hipparcos Number", "HIP 55717"},
        {"Cincinnati Publication", "Ci 18 1396"},
        {"Smithsonian Astrophysical Observation", "SAO 81809"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24805792),
        dec: Angle.Degrees(+28.94365155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -290.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216110"},
        {"Hipparcos Number", "HIP 112733"},
        {"Geneva Identification System", "GEN# +1.00216110"},
        {"Smithsonian Astrophysical Observation", "SAO 90814"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.44749728),
        dec: Angle.Degrees(+28.94433307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143705"},
        {"Hipparcos Number", "HIP 78450"},
        {"Fundamental Katalog 5th Edition", "FK5 5414"},
        {"Geneva Identification System", "GEN# +1.00143705"},
        {"Smithsonian Astrophysical Observation", "SAO 84143"},
        {"Wilson Evans Batten Catalogue", "WEB 13262"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.23666455),
        dec: Angle.Degrees(+28.94849549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33584"},
        {"Hipparcos Number", "HIP 24274"},
        {"Smithsonian Astrophysical Observation", "SAO 77029"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.14862250),
        dec: Angle.Degrees(+28.94884105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75869"},
        {"Smithsonian Astrophysical Observation", "SAO 83851"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.45584461),
        dec: Angle.Degrees(+28.94902752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85240"},
        {"Hipparcos Number", "HIP 48342"},
        {"Smithsonian Astrophysical Observation", "SAO 81046"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.81149426),
        dec: Angle.Degrees(+28.95110726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223780"},
        {"Hipparcos Number", "HIP 117725"},
        {"Smithsonian Astrophysical Observation", "SAO 91550"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.13934027),
        dec: Angle.Degrees(+28.95226704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54160"},
        {"Hipparcos Number", "HIP 34515"},
        {"Smithsonian Astrophysical Observation", "SAO 79108"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.27862885),
        dec: Angle.Degrees(+28.95335568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334488"},
        {"Hipparcos Number", "HIP 100983"},
        {"Smithsonian Astrophysical Observation", "SAO 88720"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.11483950),
        dec: Angle.Degrees(+28.95415860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87605"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.43760387),
        dec: Angle.Degrees(+28.95438812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105579"},
        {"Smithsonian Astrophysical Observation", "SAO 89664"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.77083947),
        dec: Angle.Degrees(+28.95509532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144063"},
        {"Hipparcos Number", "HIP 78608"},
        {"Smithsonian Astrophysical Observation", "SAO 84165"},
        {"Wilson Evans Batten Catalogue", "WEB 13287"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.73475845),
        dec: Angle.Degrees(+28.95557060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106487"},
        {"Smithsonian Astrophysical Observation", "SAO 89803"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.52947954),
        dec: Angle.Degrees(+28.95628453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91703"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.52013699),
        dec: Angle.Degrees(+28.95825094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54868"},
        {"Wilson Evans Batten Catalogue", "WEB 9904"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.51642999),
        dec: Angle.Degrees(+28.96030034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21323",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3304 A"},
        {"Henry Draper", "HD 28929"},
        {"Hipparcos Number", "HIP 21323"},
        {"Geneva Identification System", "GEN# +1.00028929J"},
        {"Renson", "Renson 7400"},
        {"Smithsonian Astrophysical Observation", "SAO 76654"},
        {"Wilson Evans Batten Catalogue", "WEB 4098"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65830037),
        dec: Angle.Degrees(+28.96120368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22292"},
        {"Hipparcos Number", "HIP 16806"},
        {"Geneva Identification System", "GEN# +1.00022292"},
        {"Smithsonian Astrophysical Observation", "SAO 76019"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.08258780),
        dec: Angle.Degrees(+28.96141876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104994"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.97863586),
        dec: Angle.Degrees(+28.96289539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209833"},
        {"Hipparcos Number", "HIP 109056"},
        {"Fundamental Katalog 5th Edition", "FK5 3768"},
        {"Geneva Identification System", "GEN# +1.00209833"},
        {"Smithsonian Astrophysical Observation", "SAO 90217"},
        {"Wilson Evans Batten Catalogue", "WEB 19609"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.39439437),
        dec: Angle.Degrees(+28.96400385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266479"},
        {"Hipparcos Number", "HIP 33383"},
        {"Smithsonian Astrophysical Observation", "SAO 78888"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14343386),
        dec: Angle.Degrees(+28.96575498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41728"},
        {"Smithsonian Astrophysical Observation", "SAO 80217"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64042258),
        dec: Angle.Degrees(+28.96585661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151006"},
        {"Hipparcos Number", "HIP 81881"},
        {"Smithsonian Astrophysical Observation", "SAO 84567"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.87877669),
        dec: Angle.Degrees(+28.96683266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141002"},
        {"Hipparcos Number", "HIP 77194"},
        {"Smithsonian Astrophysical Observation", "SAO 83991"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.43696130),
        dec: Angle.Degrees(+28.96930889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48450"},
        {"Hipparcos Number", "HIP 32311"},
        {"Fundamental Katalog 5th Edition", "FK5 2518"},
        {"Geneva Identification System", "GEN# +1.00048450"},
        {"Smithsonian Astrophysical Observation", "SAO 78692"},
        {"Wilson Evans Batten Catalogue", "WEB 6517"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.18943633),
        dec: Angle.Degrees(+28.97098912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119748"},
        {"Hipparcos Number", "HIP 67059"},
        {"Geneva Identification System", "GEN# +1.00119748"},
        {"Smithsonian Astrophysical Observation", "SAO 82978"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12593867),
        dec: Angle.Degrees(+28.97671441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37557"},
        {"Hipparcos Number", "HIP 26711"},
        {"Geneva Identification System", "GEN# +1.00037557"},
        {"Smithsonian Astrophysical Observation", "SAO 77381"},
        {"Wilson Evans Batten Catalogue", "WEB 5266"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.14908321),
        dec: Angle.Degrees(+28.97691525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96128"},
        {"Hipparcos Number", "HIP 54208"},
        {"Smithsonian Astrophysical Observation", "SAO 81661"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.36929164),
        dec: Angle.Degrees(+28.97730492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217201"},
        {"Hipparcos Number", "HIP 113467"},
        {"Smithsonian Astrophysical Observation", "SAO 90912"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.68655128),
        dec: Angle.Degrees(+28.98062176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43274"},
        {"Geneva Identification System", "GEN# +6.20030117"},
        {"Wilson Evans Batten Catalogue", "WEB 8341"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.23713342),
        dec: Angle.Degrees(+28.98108019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199139"},
        {"Hipparcos Number", "HIP 103181"},
        {"Geneva Identification System", "GEN# +1.00199139"},
        {"Smithsonian Astrophysical Observation", "SAO 89263"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.57642710),
        dec: Angle.Degrees(+28.98144489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170491"},
        {"Hipparcos Number", "HIP 90537"},
        {"Smithsonian Astrophysical Observation", "SAO 86096"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.10063028),
        dec: Angle.Degrees(+28.98238375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123672"},
        {"Hipparcos Number", "HIP 69093"},
        {"Smithsonian Astrophysical Observation", "SAO 83193"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.12427985),
        dec: Angle.Degrees(+28.98273425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168812"},
        {"Hipparcos Number", "HIP 89878"},
        {"Renson", "Renson 47317"},
        {"Smithsonian Astrophysical Observation", "SAO 85947"},
        {"Wilson Evans Batten Catalogue", "WEB 15346"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.10553119),
        dec: Angle.Degrees(+28.98353917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133966"},
        {"Hipparcos Number", "HIP 73931"},
        {"Smithsonian Astrophysical Observation", "SAO 83664"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.61897894),
        dec: Angle.Degrees(+28.98388103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53066"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.85828585),
        dec: Angle.Degrees(+28.98429998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47152"},
        {"Hipparcos Number", "HIP 31737"},
        {"Geneva Identification System", "GEN# +1.00047152"},
        {"Renson", "Renson 12670"},
        {"Smithsonian Astrophysical Observation", "SAO 78571"},
        {"Wilson Evans Batten Catalogue", "WEB 6368"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.59591342),
        dec: Angle.Degrees(+28.98439129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200491"},
        {"Hipparcos Number", "HIP 103877"},
        {"Smithsonian Astrophysical Observation", "SAO 89405"},
        {"Wilson Evans Batten Catalogue", "WEB 18913"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.73290746),
        dec: Angle.Degrees(+28.98487664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174023"},
        {"Hipparcos Number", "HIP 92190"},
        {"Smithsonian Astrophysical Observation", "SAO 86440"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83153488),
        dec: Angle.Degrees(+28.98620290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7892"},
        {"Hipparcos Number", "HIP 6160"},
        {"Smithsonian Astrophysical Observation", "SAO 74632"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.75331477),
        dec: Angle.Degrees(+28.98694775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258733"},
        {"Hipparcos Number", "HIP 31117"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.94069273),
        dec: Angle.Degrees(+28.98700660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111013"},
        {"Hipparcos Number", "HIP 62314"},
        {"Geneva Identification System", "GEN# +1.00111013"},
        {"Smithsonian Astrophysical Observation", "SAO 82483"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.52535933),
        dec: Angle.Degrees(+28.98760364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36684"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19549711),
        dec: Angle.Degrees(+28.98777839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98302",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13193 A"},
        {"Henry Draper", "HD 189316"},
        {"Hipparcos Number", "HIP 98302"},
        {"Celescope Catalog", "CEL 4891"},
        {"Geneva Identification System", "GEN# +1.00189316"},
        {"Smithsonian Astrophysical Observation", "SAO 88003"},
        {"Wilson Evans Batten Catalogue", "WEB 17337"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.59745406),
        dec: Angle.Degrees(+28.98818245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218170"},
        {"Hipparcos Number", "HIP 114026"},
        {"Smithsonian Astrophysical Observation", "SAO 91001"},
        {"Wilson Evans Batten Catalogue", "WEB 20252"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.37389169),
        dec: Angle.Degrees(+28.98861429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204831"},
        {"Hipparcos Number", "HIP 106182"},
        {"Geneva Identification System", "GEN# +1.00204831"},
        {"Smithsonian Astrophysical Observation", "SAO 89759"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59927608),
        dec: Angle.Degrees(+28.98881168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112031"},
        {"Hipparcos Number", "HIP 62881"},
        {"Geneva Identification System", "GEN# +1.00112031"},
        {"Smithsonian Astrophysical Observation", "SAO 82548"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.30810477),
        dec: Angle.Degrees(+28.98997810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113242"},
        {"Hipparcos Number", "HIP 63603"},
        {"Geneva Identification System", "GEN# +1.00113242"},
        {"Smithsonian Astrophysical Observation", "SAO 82614"},
        {"Wilson Evans Batten Catalogue", "WEB 11255"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.51808813),
        dec: Angle.Degrees(+28.99157704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33414"},
        {"Hipparcos Number", "HIP 24164"},
        {"Smithsonian Astrophysical Observation", "SAO 77020"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.83634492),
        dec: Angle.Degrees(+28.99163370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5575"},
        {"Hipparcos Number", "HIP 4510"},
        {"Fundamental Katalog 5th Edition", "FK5 1023"},
        {"Geneva Identification System", "GEN# +1.00005575"},
        {"Smithsonian Astrophysical Observation", "SAO 74395"},
        {"Wilson Evans Batten Catalogue", "WEB 816"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.45895150),
        dec: Angle.Degrees(+28.99223560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188170"},
        {"Hipparcos Number", "HIP 97833"},
        {"Celescope Catalog", "CEL 4865"},
        {"Geneva Identification System", "GEN# +1.00188170"},
        {"Smithsonian Astrophysical Observation", "SAO 87863"},
        {"Wilson Evans Batten Catalogue", "WEB 17211"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.20942547),
        dec: Angle.Degrees(+28.99259153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147527"},
        {"Hipparcos Number", "HIP 80131"},
        {"Smithsonian Astrophysical Observation", "SAO 84324"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34388897),
        dec: Angle.Degrees(+28.99539018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79010",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9930 AB"},
        {"Henry Draper", "HD 144999"},
        {"Hipparcos Number", "HIP 79010"},
        {"Renson", "Renson 41090"},
        {"Smithsonian Astrophysical Observation", "SAO 84205"},
        {"Wilson Evans Batten Catalogue", "WEB 13356"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90944571),
        dec: Angle.Degrees(+28.99544605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332408"},
        {"Hipparcos Number", "HIP 96922"},
        {"Geneva Identification System", "GEN# +1.00332408"},
        {"Smithsonian Astrophysical Observation", "SAO 87593"},
        {"Wilson Evans Batten Catalogue", "WEB 17010"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.53325310),
        dec: Angle.Degrees(+28.99600519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5917"},
        {"Hipparcos Number", "HIP 4749"},
        {"Geneva Identification System", "GEN# +1.00005917"},
        {"Smithsonian Astrophysical Observation", "SAO 74431"},
        {"Wilson Evans Batten Catalogue", "WEB 899"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.26078155),
        dec: Angle.Degrees(+28.99737472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55743"},
        {"Smithsonian Astrophysical Observation", "SAO 81813"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.32195799),
        dec: Angle.Degrees(+28.99905315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73887"},
        {"Fundamental Katalog 5th Edition", "FK5 5340"},
        {"Smithsonian Astrophysical Observation", "SAO 83659"},
        {"Wilson Evans Batten Catalogue", "WEB 12620"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.52000214),
        dec: Angle.Degrees(+28.99955991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25867"},
        {"Hipparcos Number", "HIP 19205"},
        {"Fundamental Katalog 5th Edition", "FK5 2295"},
        {"Geneva Identification System", "GEN# +1.00025867"},
        {"Renson", "Renson 6580"},
        {"Smithsonian Astrophysical Observation", "SAO 76461"},
        {"Wilson Evans Batten Catalogue", "WEB 3687"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.75215574),
        dec: Angle.Degrees(+29.00128762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100616",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13807 A"},
        {"Henry Draper", "HD 194358"},
        {"Hipparcos Number", "HIP 100616"},
        {"Geneva Identification System", "GEN# +1.00194358"},
        {"Smithsonian Astrophysical Observation", "SAO 88629"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.03753329),
        dec: Angle.Degrees(+29.00210560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56223"},
        {"Smithsonian Astrophysical Observation", "SAO 81866"},
        {"Wilson Evans Batten Catalogue", "WEB 10101"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.89001030),
        dec: Angle.Degrees(+29.00342220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85473"},
        {"Hipparcos Number", "HIP 48450"},
        {"Smithsonian Astrophysical Observation", "SAO 81062"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.17887086),
        dec: Angle.Degrees(+29.00421373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113558"},
        {"Smithsonian Astrophysical Observation", "SAO 90931"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.01023955),
        dec: Angle.Degrees(+29.00444024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40530"},
        {"Hipparcos Number", "HIP 28469"},
        {"Geneva Identification System", "GEN# +1.00040530"},
        {"Smithsonian Astrophysical Observation", "SAO 77830"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.15405592),
        dec: Angle.Degrees(+29.00525227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14146"},
        {"Hipparcos Number", "HIP 10714"},
        {"Smithsonian Astrophysical Observation", "SAO 75269"},
        {"Wilson Evans Batten Catalogue", "WEB 2260"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.48881558),
        dec: Angle.Degrees(+29.00727061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283677"},
        {"Hipparcos Number", "HIP 21159"},
        {"Geneva Identification System", "GEN# +1.00283677"},
        {"Smithsonian Astrophysical Observation", "SAO 76644"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.04557945),
        dec: Angle.Degrees(+29.01559667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38116"},
        {"Hipparcos Number", "HIP 27088"},
        {"Celescope Catalog", "CEL 951"},
        {"Geneva Identification System", "GEN# +1.00038116J"},
        {"Smithsonian Astrophysical Observation", "SAO 77483"},
        {"Wilson Evans Batten Catalogue", "WEB 5329"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.15726743),
        dec: Angle.Degrees(+29.01660531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57412"},
        {"Geneva Identification System", "GEN# +0.02902211"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.55792424),
        dec: Angle.Degrees(+29.01731091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117779"},
        {"Geneva Identification System", "GEN# +0.02804660"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.28601675),
        dec: Angle.Degrees(+29.01801815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245287"},
        {"Hipparcos Number", "HIP 26342"},
        {"Smithsonian Astrophysical Observation", "SAO 77309"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.14423385),
        dec: Angle.Degrees(+29.01933824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249218"},
        {"Hipparcos Number", "HIP 28072"},
        {"Geneva Identification System", "GEN# +1.00249218"},
        {"Renson", "Renson 10636"},
        {"Smithsonian Astrophysical Observation", "SAO 77734"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.02373229),
        dec: Angle.Degrees(+29.01938563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54480"},
        {"Smithsonian Astrophysical Observation", "SAO 81691"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.19006203),
        dec: Angle.Degrees(+29.02134151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 69 A"},
        {"Henry Draper", "HD 166"},
        {"Hipparcos Number", "HIP 544"},
        {"Cincinnati Publication", "Ci 20 9"},
        {"Geneva Identification System", "GEN# +1.00000166"},
        {"Smithsonian Astrophysical Observation", "SAO 73743"},
        {"Wilson Evans Batten Catalogue", "WEB 97"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.65221045),
        dec: Angle.Degrees(+29.02193518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 379.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67081"},
        {"Smithsonian Astrophysical Observation", "SAO 82982"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.23507501),
        dec: Angle.Degrees(+29.02435578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119025"},
        {"Hipparcos Number", "HIP 66691"},
        {"Geneva Identification System", "GEN# +1.00119025"},
        {"Smithsonian Astrophysical Observation", "SAO 82939"},
        {"New General Catalogue", "NGC 5272 46"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.06711797),
        dec: Angle.Degrees(+29.02760535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95797"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.27769822),
        dec: Angle.Degrees(+29.02804469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213178"},
        {"Hipparcos Number", "HIP 110985"},
        {"Geneva Identification System", "GEN# +1.00213178"},
        {"Smithsonian Astrophysical Observation", "SAO 90543"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.28241211),
        dec: Angle.Degrees(+29.02916338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8777 A"},
        {"Henry Draper", "HD 113865"},
        {"Hipparcos Number", "HIP 63933"},
        {"Geneva Identification System", "GEN# +1.00113865"},
        {"Smithsonian Astrophysical Observation", "SAO 82648"},
        {"Wilson Evans Batten Catalogue", "WEB 11297"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.54288361),
        dec: Angle.Degrees(+29.02925254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109457"},
        {"Smithsonian Astrophysical Observation", "SAO 90289"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.62506891),
        dec: Angle.Degrees(+29.02947104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71519"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.39956831),
        dec: Angle.Degrees(+29.03053237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137109"},
        {"Hipparcos Number", "HIP 75317"},
        {"Smithsonian Astrophysical Observation", "SAO 83799"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.81489080),
        dec: Angle.Degrees(+29.03171265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260160"},
        {"Hipparcos Number", "HIP 31544"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.04610174),
        dec: Angle.Degrees(+29.03197042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42185"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.01507433),
        dec: Angle.Degrees(+29.03495645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335076"},
        {"Hipparcos Number", "HIP 102404"},
        {"Smithsonian Astrophysical Observation", "SAO 89090"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.27819991),
        dec: Angle.Degrees(+29.03566700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220808"},
        {"Hipparcos Number", "HIP 115716"},
        {"Smithsonian Astrophysical Observation", "SAO 91266"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.65930085),
        dec: Angle.Degrees(+29.03877960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152896"},
        {"Hipparcos Number", "HIP 82779"},
        {"Geneva Identification System", "GEN# +1.00152896"},
        {"Smithsonian Astrophysical Observation", "SAO 84694"},
        {"Wilson Evans Batten Catalogue", "WEB 13994"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.75549251),
        dec: Angle.Degrees(+29.03889402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68793"},
        {"Geneva Identification System", "GEN# +0.02902488"},
        {"Smithsonian Astrophysical Observation", "SAO 83156"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.22403159),
        dec: Angle.Degrees(+29.03934599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5209 A"},
        {"Henry Draper", "HD 259841"},
        {"Hipparcos Number", "HIP 31437"},
    },
    visualMagnitude: 10.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)35, 13.1700),
        dec: Angle.DegreesMinutesSeconds((int)+29, (int)02, 27.500)
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
    primaryId: "HIP 20989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28417"},
        {"Hipparcos Number", "HIP 20989"},
        {"Geneva Identification System", "GEN# +1.00028417"},
        {"Smithsonian Astrophysical Observation", "SAO 76630"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.51563645),
        dec: Angle.Degrees(+29.04127229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57178"},
        {"Smithsonian Astrophysical Observation", "SAO 81957"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.88700314),
        dec: Angle.Degrees(+29.04431458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115462"},
        {"Hipparcos Number", "HIP 64807"},
        {"Geneva Identification System", "GEN# +1.00115462"},
        {"Smithsonian Astrophysical Observation", "SAO 82754"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.23622247),
        dec: Angle.Degrees(+29.04446204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17368"},
        {"Hipparcos Number", "HIP 13071"},
        {"Smithsonian Astrophysical Observation", "SAO 75579"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.00199304),
        dec: Angle.Degrees(+29.04485665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100255"},
        {"Hipparcos Number", "HIP 56296"},
        {"Geneva Identification System", "GEN# +1.00100255"},
        {"Smithsonian Astrophysical Observation", "SAO 81872"},
        {"Wilson Evans Batten Catalogue", "WEB 10122"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.10653866),
        dec: Angle.Degrees(+29.04558021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283564"},
        {"Hipparcos Number", "HIP 20483"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.85314015),
        dec: Angle.Degrees(+29.04687539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11652"},
        {"Smithsonian Astrophysical Observation", "SAO 75404"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.57311996),
        dec: Angle.Degrees(+29.04779867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251198"},
        {"Hipparcos Number", "HIP 28846"},
        {"Smithsonian Astrophysical Observation", "SAO 77937"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.33142130),
        dec: Angle.Degrees(+29.04841707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20644"},
        {"Hipparcos Number", "HIP 15549"},
        {"Fundamental Katalog 5th Edition", "FK5 2234"},
        {"Geneva Identification System", "GEN# +1.00020644"},
        {"Smithsonian Astrophysical Observation", "SAO 75871"},
        {"Wilson Evans Batten Catalogue", "WEB 2987"},
    },
    visualMagnitude: 4.47,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08485949),
        dec: Angle.Degrees(+29.04849835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20136"},
        {"Hipparcos Number", "HIP 15141"},
        {"Smithsonian Astrophysical Observation", "SAO 75811"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.79662622),
        dec: Angle.Degrees(+29.05026864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172132"},
        {"Hipparcos Number", "HIP 91290"},
        {"Smithsonian Astrophysical Observation", "SAO 86251"},
        {"Wilson Evans Batten Catalogue", "WEB 15689"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.31071932),
        dec: Angle.Degrees(+29.05700870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224649"},
        {"Hipparcos Number", "HIP 118295"},
        {"Smithsonian Astrophysical Observation", "SAO 91638"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.89823714),
        dec: Angle.Degrees(+29.05749708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266245"},
        {"Hipparcos Number", "HIP 33325"},
        {"Smithsonian Astrophysical Observation", "SAO 78874"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97231577),
        dec: Angle.Degrees(+29.05811364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129357"},
        {"Hipparcos Number", "HIP 71813"},
        {"Geneva Identification System", "GEN# +1.00129357"},
        {"Smithsonian Astrophysical Observation", "SAO 83469"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.34328079),
        dec: Angle.Degrees(+29.05925235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5901"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.94960175),
        dec: Angle.Degrees(+29.06026770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2314"},
        {"Hipparcos Number", "HIP 2133"},
        {"Smithsonian Astrophysical Observation", "SAO 73996"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.76659529),
        dec: Angle.Degrees(+29.06250223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45709"},
        {"Wilson Evans Batten Catalogue", "WEB 8677"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.77514549),
        dec: Angle.Degrees(+29.06556501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109600"},
        {"Smithsonian Astrophysical Observation", "SAO 90318"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.02547062),
        dec: Angle.Degrees(+29.06558696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10377"},
        {"Hipparcos Number", "HIP 7925"},
        {"Smithsonian Astrophysical Observation", "SAO 74877"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.46807260),
        dec: Angle.Degrees(+29.06645385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1888 A"},
        {"Hipparcos Number", "HIP 11579"},
        {"Smithsonian Astrophysical Observation", "SAO 75397"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.30750973),
        dec: Angle.Degrees(+29.06758433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105771"},
        {"Hipparcos Number", "HIP 59348"},
        {"Geneva Identification System", "GEN# +1.00105771"},
        {"Smithsonian Astrophysical Observation", "SAO 82165"},
        {"Wilson Evans Batten Catalogue", "WEB 10556"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.61601419),
        dec: Angle.Degrees(+29.06819847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78713"},
        {"Hipparcos Number", "HIP 45049"},
        {"Geneva Identification System", "GEN# +1.00078713"},
        {"Smithsonian Astrophysical Observation", "SAO 80676"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.63532754),
        dec: Angle.Degrees(+29.07032768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116407"},
        {"Hipparcos Number", "HIP 65306"},
        {"Geneva Identification System", "GEN# +1.00116407"},
        {"Smithsonian Astrophysical Observation", "SAO 82814"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.76392005),
        dec: Angle.Degrees(+29.07464382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4132"},
        {"Smithsonian Astrophysical Observation", "SAO 74336"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22530292),
        dec: Angle.Degrees(+29.07528951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148667"},
        {"Hipparcos Number", "HIP 80691"},
        {"Fundamental Katalog 5th Edition", "FK5 5457"},
        {"Smithsonian Astrophysical Observation", "SAO 84402"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.13264488),
        dec: Angle.Degrees(+29.07567070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19548"},
        {"Hipparcos Number", "HIP 14677"},
        {"Fundamental Katalog 5th Edition", "FK5 1088"},
        {"Geneva Identification System", "GEN# +1.00019548"},
        {"Smithsonian Astrophysical Observation", "SAO 75757"},
        {"Wilson Evans Batten Catalogue", "WEB 2847"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.40303182),
        dec: Angle.Degrees(+29.07711221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133544"},
        {"Hipparcos Number", "HIP 73726"},
        {"Geneva Identification System", "GEN# +1.00133544"},
        {"Smithsonian Astrophysical Observation", "SAO 83643"},
        {"Wilson Evans Batten Catalogue", "WEB 12605"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.06687563),
        dec: Angle.Degrees(+29.07851499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69476"},
        {"Hipparcos Number", "HIP 40676"},
        {"Geneva Identification System", "GEN# +1.00069476"},
        {"Smithsonian Astrophysical Observation", "SAO 80077"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.56068033),
        dec: Angle.Degrees(+29.07911024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166683"},
        {"Hipparcos Number", "HIP 89052"},
        {"Geneva Identification System", "GEN# +1.00166683"},
        {"Smithsonian Astrophysical Observation", "SAO 85801"},
        {"Wilson Evans Batten Catalogue", "WEB 15120"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.64324908),
        dec: Angle.Degrees(+29.07948583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67498"},
        {"Smithsonian Astrophysical Observation", "SAO 83017"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.48248576),
        dec: Angle.Degrees(+29.07987950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5138"},
        {"Hipparcos Number", "HIP 4196"},
        {"Geneva Identification System", "GEN# +1.00005138"},
        {"Smithsonian Astrophysical Observation", "SAO 74340"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.39939077),
        dec: Angle.Degrees(+29.08023366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165473"},
        {"Hipparcos Number", "HIP 88562"},
        {"Geneva Identification System", "GEN# +1.00165473"},
        {"Smithsonian Astrophysical Observation", "SAO 85713"},
        {"Wilson Evans Batten Catalogue", "WEB 14996"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.24588037),
        dec: Angle.Degrees(+29.08101357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334201"},
        {"Hipparcos Number", "HIP 100430"},
        {"Smithsonian Astrophysical Observation", "SAO 88578"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.48527488),
        dec: Angle.Degrees(+29.08460230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124712"},
        {"Hipparcos Number", "HIP 69574"},
        {"Geneva Identification System", "GEN# +1.00124712"},
        {"Smithsonian Astrophysical Observation", "SAO 83240"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62384615),
        dec: Angle.Degrees(+29.08497391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109482"},
        {"Hipparcos Number", "HIP 61390"},
        {"Geneva Identification System", "GEN# +1.00109482"},
        {"Smithsonian Astrophysical Observation", "SAO 82389"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.70076977),
        dec: Angle.Degrees(+29.08743634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129632"},
        {"Hipparcos Number", "HIP 71945"},
        {"Geneva Identification System", "GEN# +1.00129632"},
        {"Smithsonian Astrophysical Observation", "SAO 83482"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.72240146),
        dec: Angle.Degrees(+29.08803325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194032"},
        {"Hipparcos Number", "HIP 100461"},
        {"Fundamental Katalog 5th Edition", "FK5 5795"},
        {"Geneva Identification System", "GEN# +1.00194032"},
        {"Smithsonian Astrophysical Observation", "SAO 88591"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.58501717),
        dec: Angle.Degrees(+29.09072231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 677",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alpheratz"},
        {"Common Name 2", "Sirrah"},
        {"Aitken", "ADS 94 A"},
        {"Henry Draper", "HD 358"},
        {"Hipparcos Number", "HIP 677"},
        {"Fundamental Katalog 5th Edition", "FK5 1"},
        {"Geneva Identification System", "GEN# +1.00000358"},
        {"Renson", "Renson 50"},
        {"Smithsonian Astrophysical Observation", "SAO 73765"},
        {"Wilson Evans Batten Catalogue", "WEB 113"},
    },
    visualMagnitude: 2.07,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.09653333),
        dec: Angle.Degrees(+29.09082805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35014"},
        {"Hipparcos Number", "HIP 25158"},
        {"Smithsonian Astrophysical Observation", "SAO 77137"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75124096),
        dec: Angle.Degrees(+29.09097711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14590 A"},
        {"Henry Draper", "HD 200578"},
        {"Hipparcos Number", "HIP 103930"},
        {"Smithsonian Astrophysical Observation", "SAO 89415"},
        {"Wilson Evans Batten Catalogue", "WEB 18927"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.87305729),
        dec: Angle.Degrees(+29.09254641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67542"},
        {"Hipparcos Number", "HIP 39958"},
        {"Geneva Identification System", "GEN# +1.00067542"},
        {"Smithsonian Astrophysical Observation", "SAO 79982"},
        {"Wilson Evans Batten Catalogue", "WEB 7790"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.39662080),
        dec: Angle.Degrees(+29.09309528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200893"},
        {"Hipparcos Number", "HIP 104106"},
        {"Smithsonian Astrophysical Observation", "SAO 89447"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.37504041),
        dec: Angle.Degrees(+29.09618518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159502"},
        {"Hipparcos Number", "HIP 85951"},
        {"Geneva Identification System", "GEN# +1.00159502"},
        {"Smithsonian Astrophysical Observation", "SAO 85213"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.49529934),
        dec: Angle.Degrees(+29.09641387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41430"},
        {"Hipparcos Number", "HIP 28922"},
        {"Geneva Identification System", "GEN# +1.00041430"},
        {"Smithsonian Astrophysical Observation", "SAO 77956"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.57080846),
        dec: Angle.Degrees(+29.09704995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56914"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.01932200),
        dec: Angle.Degrees(+29.09772128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101928",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14117 AB"},
        {"Henry Draper", "HD 196906"},
        {"Hipparcos Number", "HIP 101928"},
        {"Smithsonian Astrophysical Observation", "SAO 88963"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.82968899),
        dec: Angle.Degrees(+29.09880541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64766"},
        {"Geneva Identification System", "GEN# +6.20004043"},
        {"Geneva Identification System 2", "GEN# +6.20020098"},
    },
    visualMagnitude: 12.73,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.09149458),
        dec: Angle.Degrees(+29.09898520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3252"},
        {"Hipparcos Number", "HIP 2825"},
        {"Smithsonian Astrophysical Observation", "SAO 74129"},
        {"Wilson Evans Batten Catalogue", "WEB 506"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96824512),
        dec: Angle.Degrees(+29.09987897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9638"},
        {"Hipparcos Number", "HIP 7374"},
        {"Geneva Identification System", "GEN# +1.00009638"},
        {"Smithsonian Astrophysical Observation", "SAO 74806"},
        {"Wilson Evans Batten Catalogue", "WEB 1584"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.75785933),
        dec: Angle.Degrees(+29.10078586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56587"},
        {"Hipparcos Number", "HIP 35428"},
        {"Renson", "Renson 15445"},
        {"Smithsonian Astrophysical Observation", "SAO 79275"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71434849),
        dec: Angle.Degrees(+29.10090861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12728"},
        {"Hipparcos Number", "HIP 9739"},
        {"Geneva Identification System", "GEN# +1.00012728"},
        {"Smithsonian Astrophysical Observation", "SAO 75133"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.32060140),
        dec: Angle.Degrees(+29.10407479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91685"},
        {"Hipparcos Number", "HIP 51859"},
        {"Geneva Identification System", "GEN# +1.00091685"},
        {"Smithsonian Astrophysical Observation", "SAO 81431"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.93025655),
        dec: Angle.Degrees(+29.10421629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69523",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9174 AB"},
        {"Henry Draper", "HD 124588"},
        {"Henry Draper 2", "HD 124587"},
        {"Hipparcos Number", "HIP 69523"},
        {"Geneva Identification System", "GEN# +1.00124588J"},
        {"Geneva Identification System 2", "GEN# +1.00124587"},
        {"Smithsonian Astrophysical Observation", "SAO 83235"},
        {"Wilson Evans Batten Catalogue", "WEB 12112"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.47752497),
        dec: Angle.Degrees(+29.10544320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75695",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nusakan"},
        {"Henry Draper", "HD 137909"},
        {"Hipparcos Number", "HIP 75695"},
        {"Fundamental Katalog 5th Edition", "FK5 572"},
        {"Geneva Identification System", "GEN# +1.00137909J"},
        {"Renson", "Renson 39200"},
        {"Smithsonian Astrophysical Observation", "SAO 83831"},
        {"Wilson Evans Batten Catalogue", "WEB 12887"},
    },
    visualMagnitude: 3.66,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.95771631),
        dec: Angle.Degrees(+29.10549164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281934"},
        {"Hipparcos Number", "HIP 20160"},
    },
    visualMagnitude: 11.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.81595047),
        dec: Angle.Degrees(+29.10754103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74331"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.88556148),
        dec: Angle.Degrees(+29.10879280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74829"},
        {"Hipparcos Number", "HIP 43145"},
        {"Smithsonian Astrophysical Observation", "SAO 80424"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.81623067),
        dec: Angle.Degrees(+29.11193037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39303"},
        {"Hipparcos Number", "HIP 27798"},
        {"Smithsonian Astrophysical Observation", "SAO 77661"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.23710856),
        dec: Angle.Degrees(+29.11197097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192042"},
        {"Hipparcos Number", "HIP 99524"},
        {"Geneva Identification System", "GEN# +1.00192042"},
        {"Smithsonian Astrophysical Observation", "SAO 88334"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.97104115),
        dec: Angle.Degrees(+29.11304281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10770"},
    },
    visualMagnitude: 10.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.64928910),
        dec: Angle.Degrees(+29.11306922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178030"},
        {"Hipparcos Number", "HIP 93777"},
        {"Celescope Catalog", "CEL 4699"},
        {"Geneva Identification System", "GEN# +1.00178030"},
        {"Smithsonian Astrophysical Observation", "SAO 86799"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.46815803),
        dec: Angle.Degrees(+29.11336982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82940"},
        {"Smithsonian Astrophysical Observation", "SAO 84714"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.23497889),
        dec: Angle.Degrees(+29.11656205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33120"},
        {"Hipparcos Number", "HIP 23993"},
        {"Smithsonian Astrophysical Observation", "SAO 76987"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.36320171),
        dec: Angle.Degrees(+29.11700363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128003"},
        {"Hipparcos Number", "HIP 71207"},
        {"Smithsonian Astrophysical Observation", "SAO 83403"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.43850999),
        dec: Angle.Degrees(+29.11975444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104688"},
        {"Hipparcos Number", "HIP 58777"},
        {"Fundamental Katalog 5th Edition", "FK5 5062"},
        {"Geneva Identification System", "GEN# +1.00104688"},
        {"Smithsonian Astrophysical Observation", "SAO 82118"},
        {"Wilson Evans Batten Catalogue", "WEB 10473"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.82713609),
        dec: Angle.Degrees(+29.12061696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180502"},
        {"Hipparcos Number", "HIP 94653"},
        {"Geneva Identification System", "GEN# +1.00180502"},
        {"Smithsonian Astrophysical Observation", "SAO 86998"},
        {"Wilson Evans Batten Catalogue", "WEB 16500"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.90865501),
        dec: Angle.Degrees(+29.12217587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281813"},
        {"Hipparcos Number", "HIP 19715"},
        {"Smithsonian Astrophysical Observation", "SAO 76508"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.35185198),
        dec: Angle.Degrees(+29.12294671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19310"},
        {"Hipparcos Number", "HIP 14499"},
        {"Smithsonian Astrophysical Observation", "SAO 75740"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.82055720),
        dec: Angle.Degrees(+29.12340873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67628"},
        {"Hipparcos Number", "HIP 39985"},
        {"Smithsonian Astrophysical Observation", "SAO 79988"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.49131181),
        dec: Angle.Degrees(+29.12508230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176671"},
        {"Hipparcos Number", "HIP 93301"},
        {"Smithsonian Astrophysical Observation", "SAO 86687"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.06229550),
        dec: Angle.Degrees(+29.12635914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192912"},
        {"Hipparcos Number", "HIP 99924"},
        {"Smithsonian Astrophysical Observation", "SAO 88445"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.10757568),
        dec: Angle.Degrees(+29.13210780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75645"},
        {"Hipparcos Number", "HIP 43551"},
        {"Geneva Identification System", "GEN# +1.00075645"},
        {"Smithsonian Astrophysical Observation", "SAO 80468"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.04226090),
        dec: Angle.Degrees(+29.13414276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66300"},
        {"Geneva Identification System", "GEN# +0.02902432"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.81769495),
        dec: Angle.Degrees(+29.13465487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38708"},
        {"Hipparcos Number", "HIP 27459"},
        {"Geneva Identification System", "GEN# +1.00038708"},
        {"Smithsonian Astrophysical Observation", "SAO 77589"},
        {"Wilson Evans Batten Catalogue", "WEB 5393"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.22353930),
        dec: Angle.Degrees(+29.13611853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81209"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.80819365),
        dec: Angle.Degrees(+29.14041309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189848"},
        {"Hipparcos Number", "HIP 98541"},
        {"Celescope Catalog", "CEL 4910"},
        {"Smithsonian Astrophysical Observation", "SAO 88072"},
        {"Wilson Evans Batten Catalogue", "WEB 17412"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.27063733),
        dec: Angle.Degrees(+29.14050054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63169"},
        {"Geneva Identification System", "GEN# +0.02902344"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13993733),
        dec: Angle.Degrees(+29.14069237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145626"},
        {"Hipparcos Number", "HIP 79283"},
        {"Smithsonian Astrophysical Observation", "SAO 84231"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.72213089),
        dec: Angle.Degrees(+29.14167416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96059"},
        {"Smithsonian Astrophysical Observation", "SAO 87322"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.97771623),
        dec: Angle.Degrees(+29.14210293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122992"},
        {"Hipparcos Number", "HIP 68765"},
        {"Geneva Identification System", "GEN# +1.00122992"},
        {"Smithsonian Astrophysical Observation", "SAO 83151"},
        {"Wilson Evans Batten Catalogue", "WEB 12030"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11507613),
        dec: Angle.Degrees(+29.14259966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332407"},
        {"Hipparcos Number", "HIP 96862"},
        {"Geneva Identification System", "GEN# +1.00332407"},
        {"Smithsonian Astrophysical Observation", "SAO 87572"},
        {"Wilson Evans Batten Catalogue", "WEB 17002"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.33273333),
        dec: Angle.Degrees(+29.14445883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14397 AB"},
        {"Henry Draper", "HD 198977"},
        {"Hipparcos Number", "HIP 103074"},
        {"Smithsonian Astrophysical Observation", "SAO 89240"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.26761224),
        dec: Angle.Degrees(+29.14546990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197643"},
        {"Hipparcos Number", "HIP 102335"},
        {"Smithsonian Astrophysical Observation", "SAO 89063"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.01454902),
        dec: Angle.Degrees(+29.14615586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137445"},
        {"Hipparcos Number", "HIP 75471"},
        {"Smithsonian Astrophysical Observation", "SAO 83809"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.26131080),
        dec: Angle.Degrees(+29.14621003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86329"},
        {"Geneva Identification System", "GEN# +0.02903070"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.58835334),
        dec: Angle.Degrees(+29.14642904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13648 A"},
        {"Henry Draper", "HD 193094"},
        {"Hipparcos Number", "HIP 100018"},
        {"Geneva Identification System", "GEN# +1.00193094J"},
        {"Smithsonian Astrophysical Observation", "SAO 88473"},
        {"Wilson Evans Batten Catalogue", "WEB 18004"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.38140202),
        dec: Angle.Degrees(+29.14750941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68053"},
        {"Smithsonian Astrophysical Observation", "SAO 83078"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.01782709),
        dec: Angle.Degrees(+29.14937330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79757",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9990 A"},
        {"Henry Draper", "HD 146738"},
        {"Hipparcos Number", "HIP 79757"},
        {"Fundamental Katalog 5th Edition", "FK5 3287"},
        {"Geneva Identification System", "GEN# +1.00146738"},
        {"Renson", "Renson 41460"},
        {"Smithsonian Astrophysical Observation", "SAO 84281"},
        {"Wilson Evans Batten Catalogue", "WEB 13495"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18654828),
        dec: Angle.Degrees(+29.15030220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62537"},
        {"Geneva Identification System", "GEN# +0.02902326"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.22087093),
        dec: Angle.Degrees(+29.15161948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155041"},
        {"Hipparcos Number", "HIP 83832"},
        {"Smithsonian Astrophysical Observation", "SAO 84865"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.99782565),
        dec: Angle.Degrees(+29.15421518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111717"},
        {"Smithsonian Astrophysical Observation", "SAO 90661"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44611687),
        dec: Angle.Degrees(+29.15482584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111540"},
        {"Hipparcos Number", "HIP 62606"},
        {"Geneva Identification System", "GEN# +1.00111540"},
        {"Smithsonian Astrophysical Observation", "SAO 82518"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.43202464),
        dec: Angle.Degrees(+29.15632220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218538"},
        {"Hipparcos Number", "HIP 114263"},
        {"Smithsonian Astrophysical Observation", "SAO 91037"},
        {"Wilson Evans Batten Catalogue", "WEB 20291"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.11870413),
        dec: Angle.Degrees(+29.16097827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70394"},
        {"Smithsonian Astrophysical Observation", "SAO 83330"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.03403148),
        dec: Angle.Degrees(+29.16137866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9123 AB"},
        {"Hipparcos Number", "HIP 69088"},
        {"Smithsonian Astrophysical Observation", "SAO 83192"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.11169724),
        dec: Angle.Degrees(+29.16153281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259059"},
        {"Hipparcos Number", "HIP 31202"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.19283281),
        dec: Angle.Degrees(+29.16185499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110523"},
        {"Hipparcos Number", "HIP 62014"},
        {"Geneva Identification System", "GEN# +1.00110523"},
        {"Smithsonian Astrophysical Observation", "SAO 82448"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.64988934),
        dec: Angle.Degrees(+29.16244320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18202"},
        {"Hipparcos Number", "HIP 13684"},
        {"Smithsonian Astrophysical Observation", "SAO 75651"},
        {"Wilson Evans Batten Catalogue", "WEB 2715"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.06642735),
        dec: Angle.Degrees(+29.16412159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135502"},
        {"Hipparcos Number", "HIP 74596"},
        {"Fundamental Katalog 5th Edition", "FK5 3204"},
        {"Geneva Identification System", "GEN# +1.00135502"},
        {"Smithsonian Astrophysical Observation", "SAO 83729"},
        {"Wilson Evans Batten Catalogue", "WEB 12731"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.62168817),
        dec: Angle.Degrees(+29.16422593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8234"},
        {"Smithsonian Astrophysical Observation", "SAO 74916"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.50440124),
        dec: Angle.Degrees(+29.16435410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99487",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13487 A"},
        {"Henry Draper", "HD 191945"},
        {"Hipparcos Number", "HIP 99487"},
        {"Smithsonian Astrophysical Observation", "SAO 88325"},
        {"Wilson Evans Batten Catalogue", "WEB 17787"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.85779516),
        dec: Angle.Degrees(+29.16692450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155455"},
        {"Hipparcos Number", "HIP 84016"},
        {"Smithsonian Astrophysical Observation", "SAO 84892"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.61039424),
        dec: Angle.Degrees(+29.16748674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63712"},
        {"Hipparcos Number", "HIP 38363"},
        {"Geneva Identification System", "GEN# +1.00063712"},
        {"Smithsonian Astrophysical Observation", "SAO 79747"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.86080898),
        dec: Angle.Degrees(+29.16799520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91945"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.13756938),
        dec: Angle.Degrees(+29.17008529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149752"},
        {"Hipparcos Number", "HIP 81247"},
        {"Smithsonian Astrophysical Observation", "SAO 84472"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.91435971),
        dec: Angle.Degrees(+29.17046794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86167"},
        {"Hipparcos Number", "HIP 48817"},
        {"Renson", "Renson 24610"},
        {"Smithsonian Astrophysical Observation", "SAO 81107"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.36587862),
        dec: Angle.Degrees(+29.17206221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95978"},
        {"Hipparcos Number", "HIP 54148"},
        {"Geneva Identification System", "GEN# +1.00095978"},
        {"Smithsonian Astrophysical Observation", "SAO 81652"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.15081799),
        dec: Angle.Degrees(+29.17219463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211460"},
        {"Hipparcos Number", "HIP 109993"},
        {"Geneva Identification System", "GEN# +1.00211460"},
        {"Smithsonian Astrophysical Observation", "SAO 90382"},
        {"Wilson Evans Batten Catalogue", "WEB 19746"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.17046576),
        dec: Angle.Degrees(+29.17319796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107849",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15378 AB"},
        {"Henry Draper", "HD 207794"},
        {"Hipparcos Number", "HIP 107849"},
        {"Geneva Identification System", "GEN# +1.00207794J"},
        {"Smithsonian Astrophysical Observation", "SAO 90051"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.75822115),
        dec: Angle.Degrees(+29.17538173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79025"},
        {"Smithsonian Astrophysical Observation", "SAO 84206"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.94160267),
        dec: Angle.Degrees(+29.17827803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63815"},
        {"Hipparcos Number", "HIP 38391"},
        {"Geneva Identification System", "GEN# +1.00063815"},
        {"Smithsonian Astrophysical Observation", "SAO 79754"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.97389361),
        dec: Angle.Degrees(+29.17982260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130066"},
        {"Hipparcos Number", "HIP 72144"},
        {"Smithsonian Astrophysical Observation", "SAO 83505"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.34644463),
        dec: Angle.Degrees(+29.18163308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1386"},
        {"Cincinnati Publication", "Ci 20 17"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.33275961),
        dec: Angle.Degrees(+29.18196397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 691.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 428.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56629"},
        {"Hipparcos Number", "HIP 35443"},
        {"Smithsonian Astrophysical Observation", "SAO 79278"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.76065137),
        dec: Angle.Degrees(+29.18371444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56527"},
        {"Geneva Identification System", "GEN# +0.02902183"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.86159797),
        dec: Angle.Degrees(+29.18512710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106957"},
        {"Smithsonian Astrophysical Observation", "SAO 89886"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.93917451),
        dec: Angle.Degrees(+29.18593666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35984"},
        {"Hipparcos Number", "HIP 25730"},
        {"Geneva Identification System", "GEN# +1.00035984"},
        {"Smithsonian Astrophysical Observation", "SAO 77205"},
        {"Wilson Evans Batten Catalogue", "WEB 4995"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.41931237),
        dec: Angle.Degrees(+29.18657825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104319"},
        {"Hipparcos Number", "HIP 58577"},
        {"Geneva Identification System", "GEN# +1.00104319"},
        {"Smithsonian Astrophysical Observation", "SAO 82097"},
        {"Wilson Evans Batten Catalogue", "WEB 10454"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.19992779),
        dec: Angle.Degrees(+29.18726170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4300"},
        {"Hipparcos Number", "HIP 3568"},
        {"Smithsonian Astrophysical Observation", "SAO 74246"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.40473842),
        dec: Angle.Degrees(+29.18971862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3017 AB"},
        {"Henry Draper", "HD 26090"},
        {"Hipparcos Number", "HIP 19365"},
        {"Geneva Identification System", "GEN# +0.02800624J"},
        {"Geneva Identification System 2", "GEN# +1.00026090J"},
        {"Smithsonian Astrophysical Observation", "SAO 76473"},
        {"Wilson Evans Batten Catalogue", "WEB 3718"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.22629746),
        dec: Angle.Degrees(+29.19076080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59268"},
        {"Hipparcos Number", "HIP 36479"},
        {"Geneva Identification System", "GEN# +1.00059268"},
        {"Smithsonian Astrophysical Observation", "SAO 79441"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.59294934),
        dec: Angle.Degrees(+29.19155260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110394"},
        {"Smithsonian Astrophysical Observation", "SAO 90443"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.41059132),
        dec: Angle.Degrees(+29.19335505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139876"},
        {"Hipparcos Number", "HIP 76692"},
        {"Geneva Identification System", "GEN# +1.00139876"},
        {"Smithsonian Astrophysical Observation", "SAO 83935"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.90310188),
        dec: Angle.Degrees(+29.19401998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206900"},
        {"Hipparcos Number", "HIP 107343"},
        {"Smithsonian Astrophysical Observation", "SAO 89948"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.11849735),
        dec: Angle.Degrees(+29.19405783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78015"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.95250626),
        dec: Angle.Degrees(+29.19421871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36335"},
        {"Hipparcos Number", "HIP 25948"},
        {"Geneva Identification System", "GEN# +1.00036335"},
        {"Smithsonian Astrophysical Observation", "SAO 77233"},
        {"Wilson Evans Batten Catalogue", "WEB 5045"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.05908038),
        dec: Angle.Degrees(+29.19546995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115664"},
        {"Cincinnati Publication", "Ci 20 1426"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.48024272),
        dec: Angle.Degrees(+29.19563239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 495.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -339.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282771"},
        {"Hipparcos Number", "HIP 23283"},
        {"Smithsonian Astrophysical Observation", "SAO 76886"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13961675),
        dec: Angle.Degrees(+29.19691138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 266.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94251"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.78382156),
        dec: Angle.Degrees(+29.19731303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25461"},
        {"Hipparcos Number", "HIP 18965"},
        {"Smithsonian Astrophysical Observation", "SAO 76416"},
        {"Wilson Evans Batten Catalogue", "WEB 3647"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.96109084),
        dec: Angle.Degrees(+29.19802864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37956"},
        {"Hipparcos Number", "HIP 26969"},
        {"Geneva Identification System", "GEN# +1.00037956"},
        {"Smithsonian Astrophysical Observation", "SAO 77449"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.84506175),
        dec: Angle.Degrees(+29.20027989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88340"},
        {"Smithsonian Astrophysical Observation", "SAO 85679"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.61420686),
        dec: Angle.Degrees(+29.20105313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60772"},
        {"Hipparcos Number", "HIP 37095"},
        {"Smithsonian Astrophysical Observation", "SAO 79554"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.33778249),
        dec: Angle.Degrees(+29.20220232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13481"},
        {"Hipparcos Number", "HIP 10281"},
        {"Smithsonian Astrophysical Observation", "SAO 75200"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.09545794),
        dec: Angle.Degrees(+29.20285840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80882"},
        {"Smithsonian Astrophysical Observation", "SAO 84421"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.72808216),
        dec: Angle.Degrees(+29.20429532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100079",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13665 AB"},
        {"Henry Draper", "HD 334100"},
        {"Hipparcos Number", "HIP 100079"},
        {"Smithsonian Astrophysical Observation", "SAO 88492"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55596505),
        dec: Angle.Degrees(+29.20437036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74981"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.83853111),
        dec: Angle.Degrees(+29.20521342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 394.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167588"},
        {"Hipparcos Number", "HIP 89408"},
        {"Geneva Identification System", "GEN# +1.00167588"},
        {"Smithsonian Astrophysical Observation", "SAO 85856"},
        {"Wilson Evans Batten Catalogue", "WEB 15205"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68329895),
        dec: Angle.Degrees(+29.20788970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -240.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196448"},
        {"Hipparcos Number", "HIP 101672"},
        {"Geneva Identification System", "GEN# +1.00196448"},
        {"Smithsonian Astrophysical Observation", "SAO 88896"},
        {"Wilson Evans Batten Catalogue", "WEB 18364"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.12943533),
        dec: Angle.Degrees(+29.20857329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65769"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25861916),
        dec: Angle.Degrees(+29.20949098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14091"},
        {"Smithsonian Astrophysical Observation", "SAO 75690"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.42709945),
        dec: Angle.Degrees(+29.20990085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64232"},
        {"Hipparcos Number", "HIP 38586"},
        {"Smithsonian Astrophysical Observation", "SAO 79779"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.51806468),
        dec: Angle.Degrees(+29.21152852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85659"},
        {"Hipparcos Number", "HIP 48544"},
        {"Smithsonian Astrophysical Observation", "SAO 81074"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.51046105),
        dec: Angle.Degrees(+29.21286394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65583"},
        {"Hipparcos Number", "HIP 39157"},
        {"Cincinnati Publication", "Ci 20 452"},
        {"Cincinnati Publication 2", "Ci 18 949"},
        {"Geneva Identification System", "GEN# +1.00065583"},
        {"Smithsonian Astrophysical Observation", "SAO 79856"},
        {"Wilson Evans Batten Catalogue", "WEB 7678"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.13434742),
        dec: Angle.Degrees(+29.21518554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1164.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37367"},
        {"Hipparcos Number", "HIP 26606"},
        {"Celescope Catalog", "CEL 885"},
        {"Geneva Identification System", "GEN# +1.00037367"},
        {"Smithsonian Astrophysical Observation", "SAO 77354"},
        {"Wilson Evans Batten Catalogue", "WEB 5245"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.82630420),
        dec: Angle.Degrees(+29.21523028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76444"},
        {"Hipparcos Number", "HIP 43952"},
        {"Geneva Identification System", "GEN# +1.00076444"},
        {"Smithsonian Astrophysical Observation", "SAO 80528"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.27784382),
        dec: Angle.Degrees(+29.21590248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52147"},
        {"Hipparcos Number", "HIP 33815"},
        {"Geneva Identification System", "GEN# +1.00052147"},
        {"Smithsonian Astrophysical Observation", "SAO 78972"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.30251105),
        dec: Angle.Degrees(+29.21695062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150361"},
        {"Hipparcos Number", "HIP 81560"},
        {"Geneva Identification System", "GEN# +1.00150361"},
        {"Smithsonian Astrophysical Observation", "SAO 84519"},
        {"Wilson Evans Batten Catalogue", "WEB 13778"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.85863648),
        dec: Angle.Degrees(+29.21814841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95342"},
        {"Hipparcos Number", "HIP 53833"},
        {"Smithsonian Astrophysical Observation", "SAO 81621"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20279292),
        dec: Angle.Degrees(+29.21860769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43495"},
        {"Hipparcos Number", "HIP 29902"},
        {"Geneva Identification System", "GEN# +1.00043495"},
        {"Smithsonian Astrophysical Observation", "SAO 78186"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.44041063),
        dec: Angle.Degrees(+29.21971680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16071"},
        {"Hipparcos Number", "HIP 12080"},
        {"Geneva Identification System", "GEN# +1.00016071"},
        {"Smithsonian Astrophysical Observation", "SAO 75458"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92834522),
        dec: Angle.Degrees(+29.22177097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22317"},
        {"Hipparcos Number", "HIP 16835"},
        {"Geneva Identification System", "GEN# +1.00022317"},
        {"Smithsonian Astrophysical Observation", "SAO 76024"},
        {"Wilson Evans Batten Catalogue", "WEB 3202"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.16579754),
        dec: Angle.Degrees(+29.22404365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151572"},
        {"Hipparcos Number", "HIP 82155"},
        {"Smithsonian Astrophysical Observation", "SAO 84602"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.75823059),
        dec: Angle.Degrees(+29.22526519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60675"},
        {"Geneva Identification System", "GEN# +5.21110121"},
        {"Smithsonian Astrophysical Observation", "SAO 82307"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.52171544),
        dec: Angle.Degrees(+29.22528053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188820"},
        {"Hipparcos Number", "HIP 98076"},
        {"Geneva Identification System", "GEN# +1.00188820"},
        {"Smithsonian Astrophysical Observation", "SAO 87949"},
        {"Wilson Evans Batten Catalogue", "WEB 17281"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98518817),
        dec: Angle.Degrees(+29.22620032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11847 AB"},
        {"Hipparcos Number", "HIP 92875"},
        {"Smithsonian Astrophysical Observation", "SAO 86588"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.86882048),
        dec: Angle.Degrees(+29.22662007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156668"},
        {"Hipparcos Number", "HIP 84607"},
        {"Smithsonian Astrophysical Observation", "SAO 84984"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.41890861),
        dec: Angle.Degrees(+29.22670035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134792"},
        {"Hipparcos Number", "HIP 74286"},
        {"Geneva Identification System", "GEN# +1.00134792"},
        {"Smithsonian Astrophysical Observation", "SAO 83705"},
        {"Wilson Evans Batten Catalogue", "WEB 12683"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.72289624),
        dec: Angle.Degrees(+29.22921962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14741"},
        {"Smithsonian Astrophysical Observation", "SAO 75767"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.58505659),
        dec: Angle.Degrees(+29.23009386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179838"},
        {"Hipparcos Number", "HIP 94412"},
        {"Smithsonian Astrophysical Observation", "SAO 86941"},
        {"Wilson Evans Batten Catalogue", "WEB 16453"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.23362544),
        dec: Angle.Degrees(+29.23159370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19982"},
        {"Hipparcos Number", "HIP 15022"},
        {"Smithsonian Astrophysical Observation", "SAO 75802"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.40437475),
        dec: Angle.Degrees(+29.23234336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111264"},
        {"Smithsonian Astrophysical Observation", "SAO 90581"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.11544563),
        dec: Angle.Degrees(+29.23272924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112854",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16312 A"},
        {"Henry Draper", "HD 216277"},
        {"Hipparcos Number", "HIP 112854"},
        {"Smithsonian Astrophysical Observation", "SAO 90828"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.81665095),
        dec: Angle.Degrees(+29.23393959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81594"},
        {"Hipparcos Number", "HIP 46374"},
        {"Smithsonian Astrophysical Observation", "SAO 80837"},
        {"Wilson Evans Batten Catalogue", "WEB 8766"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.84400290),
        dec: Angle.Degrees(+29.23404238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16312 BC"},
        {"Hipparcos Number", "HIP 112856"},
    },
    visualMagnitude: 8.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)51, 17.2500),
        dec: Angle.DegreesMinutesSeconds((int)+29, (int)14, 07.100)
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
    primaryId: "HIP 22309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30379"},
        {"Hipparcos Number", "HIP 22309"},
        {"Geneva Identification System", "GEN# +1.00030379"},
        {"Smithsonian Astrophysical Observation", "SAO 76761"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.07937737),
        dec: Angle.Degrees(+29.23587969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110044"},
        {"Hipparcos Number", "HIP 61739"},
        {"Cincinnati Publication", "Ci 18 1599"},
        {"Geneva Identification System", "GEN# +1.00110044"},
        {"Smithsonian Astrophysical Observation", "SAO 82423"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81078128),
        dec: Angle.Degrees(+29.23599051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211074"},
        {"Hipparcos Number", "HIP 109779"},
        {"Smithsonian Astrophysical Observation", "SAO 90343"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.54423481),
        dec: Angle.Degrees(+29.23636498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8887 AB"},
        {"Henry Draper", "HD 116495"},
        {"Hipparcos Number", "HIP 65343"},
        {"Cincinnati Publication", "Ci 20 777"},
        {"Geneva Identification System", "GEN# +1.00116495"},
        {"Smithsonian Astrophysical Observation", "SAO 82816"},
        {"Wilson Evans Batten Catalogue", "WEB 11534"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88790539),
        dec: Angle.Degrees(+29.23688593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -468.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 244.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10703 A"},
        {"Henry Draper", "HD 160678"},
        {"Hipparcos Number", "HIP 86471"},
        {"Smithsonian Astrophysical Observation", "SAO 85301"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.01595657),
        dec: Angle.Degrees(+29.23705585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117501"},
        {"Smithsonian Astrophysical Observation", "SAO 91523"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.41928742),
        dec: Angle.Degrees(+29.23733470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95609"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.68730895),
        dec: Angle.Degrees(+29.23758280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87680"},
        {"Hipparcos Number", "HIP 49580"},
        {"Geneva Identification System", "GEN# +1.00087680"},
        {"Smithsonian Astrophysical Observation", "SAO 81189"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.81163569),
        dec: Angle.Degrees(+29.23767503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 494 A"},
        {"Henry Draper", "HD 3251"},
        {"Hipparcos Number", "HIP 2824"},
        {"Smithsonian Astrophysical Observation", "SAO 74128"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96750287),
        dec: Angle.Degrees(+29.23785059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12273"},
        {"Hipparcos Number", "HIP 9417"},
        {"Geneva Identification System", "GEN# +1.00012273"},
        {"Smithsonian Astrophysical Observation", "SAO 75087"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.24810226),
        dec: Angle.Degrees(+29.23841405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92581"},
        {"Smithsonian Astrophysical Observation", "SAO 86514"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.97673104),
        dec: Angle.Degrees(+29.23842546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29224",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4750 AB"},
        {"Henry Draper", "HD 42033"},
        {"Hipparcos Number", "HIP 29224"},
        {"Smithsonian Astrophysical Observation", "SAO 78046"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.43099602),
        dec: Angle.Degrees(+29.23850386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21652"},
        {"Hipparcos Number", "HIP 16352"},
        {"Smithsonian Astrophysical Observation", "SAO 75957"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.67418193),
        dec: Angle.Degrees(+29.23886200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9617"},
        {"Hipparcos Number", "HIP 7356"},
        {"Smithsonian Astrophysical Observation", "SAO 74802"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.70285436),
        dec: Angle.Degrees(+29.23901955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10703 B"},
        {"Hipparcos Number", "HIP 86472"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.01868514),
        dec: Angle.Degrees(+29.24034031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45336"},
        {"Hipparcos Number", "HIP 30779"},
        {"Smithsonian Astrophysical Observation", "SAO 78397"},
        {"Wilson Evans Batten Catalogue", "WEB 6135"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.01162679),
        dec: Angle.Degrees(+29.24184560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66558"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.66541720),
        dec: Angle.Degrees(+29.24426803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14875"},
        {"Hipparcos Number", "HIP 11240"},
        {"Smithsonian Astrophysical Observation", "SAO 75342"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.17268707),
        dec: Angle.Degrees(+29.24478461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94026"},
        {"Hipparcos Number", "HIP 53082"},
        {"Smithsonian Astrophysical Observation", "SAO 81556"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.89537426),
        dec: Angle.Degrees(+29.24705491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13061",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lilii Borea"},
        {"Henry Draper", "HD 17361"},
        {"Hipparcos Number", "HIP 13061"},
        {"Geneva Identification System", "GEN# +1.00017361"},
        {"Smithsonian Astrophysical Observation", "SAO 75578"},
        {"Wilson Evans Batten Catalogue", "WEB 2636"},
    },
    visualMagnitude: 4.52,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.97683942),
        dec: Angle.Degrees(+29.24742385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163993"},
        {"Hipparcos Number", "HIP 87933"},
        {"Fundamental Katalog 5th Edition", "FK5 674"},
        {"Geneva Identification System", "GEN# +1.00163993"},
        {"Smithsonian Astrophysical Observation", "SAO 85590"},
        {"Wilson Evans Batten Catalogue", "WEB 14848"},
    },
    visualMagnitude: 3.70,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.44096106),
        dec: Angle.Degrees(+29.24792527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203559"},
        {"Hipparcos Number", "HIP 105520"},
        {"Smithsonian Astrophysical Observation", "SAO 89655"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.57686926),
        dec: Angle.Degrees(+29.25018463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148163"},
        {"Hipparcos Number", "HIP 80432"},
        {"Smithsonian Astrophysical Observation", "SAO 84366"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.27086535),
        dec: Angle.Degrees(+29.25112086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210661"},
        {"Hipparcos Number", "HIP 109546"},
        {"Smithsonian Astrophysical Observation", "SAO 90305"},
        {"Wilson Evans Batten Catalogue", "WEB 19679"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84640436),
        dec: Angle.Degrees(+29.25465496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55869"},
        {"Hipparcos Number", "HIP 35162"},
        {"Smithsonian Astrophysical Observation", "SAO 79222"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.00798049),
        dec: Angle.Degrees(+29.25512385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47217"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.34389979),
        dec: Angle.Degrees(+29.25520541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131410"},
        {"Hipparcos Number", "HIP 72791"},
        {"Geneva Identification System", "GEN# +1.00131410"},
        {"Smithsonian Astrophysical Observation", "SAO 83564"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.17128010),
        dec: Angle.Degrees(+29.25631857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106238"},
        {"Hipparcos Number", "HIP 59597"},
        {"Geneva Identification System", "GEN# +1.00106238"},
        {"Smithsonian Astrophysical Observation", "SAO 82192"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.33091209),
        dec: Angle.Degrees(+29.25654519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281818"},
        {"Hipparcos Number", "HIP 19914"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.07918016),
        dec: Angle.Degrees(+29.25662509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82608"},
        {"Smithsonian Astrophysical Observation", "SAO 84668"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.32017360),
        dec: Angle.Degrees(+29.26064781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115965"},
        {"Smithsonian Astrophysical Observation", "SAO 91304"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.42950738),
        dec: Angle.Degrees(+29.26106363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75208"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.54113342),
        dec: Angle.Degrees(+29.26202833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282182"},
        {"Hipparcos Number", "HIP 20728"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.62929357),
        dec: Angle.Degrees(+29.26279199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126970"},
        {"Hipparcos Number", "HIP 70738"},
        {"Geneva Identification System", "GEN# +1.00126970"},
        {"Smithsonian Astrophysical Observation", "SAO 83369"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99488823),
        dec: Angle.Degrees(+29.26389266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186688"},
        {"Hipparcos Number", "HIP 97150"},
        {"Geneva Identification System", "GEN# +1.00186688"},
        {"Smithsonian Astrophysical Observation", "SAO 87659"},
        {"Wilson Evans Batten Catalogue", "WEB 17054"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.20305907),
        dec: Angle.Degrees(+29.26469939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9446"},
        {"Hipparcos Number", "HIP 7245"},
        {"Geneva Identification System", "GEN# +1.00009446"},
        {"Smithsonian Astrophysical Observation", "SAO 74788"},
        {"Wilson Evans Batten Catalogue", "WEB 1557"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.33357176),
        dec: Angle.Degrees(+29.26528053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219171"},
        {"Hipparcos Number", "HIP 114664"},
        {"Smithsonian Astrophysical Observation", "SAO 91102"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.42024192),
        dec: Angle.Degrees(+29.26532141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206889"},
        {"Hipparcos Number", "HIP 107335"},
        {"Smithsonian Astrophysical Observation", "SAO 89946"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09752135),
        dec: Angle.Degrees(+29.26579073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98797"},
        {"Hipparcos Number", "HIP 55530"},
        {"Geneva Identification System", "GEN# +1.00098797"},
        {"Smithsonian Astrophysical Observation", "SAO 81793"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.61686584),
        dec: Angle.Degrees(+29.26586916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74520"},
        {"Hipparcos Number", "HIP 42978"},
        {"Smithsonian Astrophysical Observation", "SAO 80399"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.38815500),
        dec: Angle.Degrees(+29.26803245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77586"},
        {"Hipparcos Number", "HIP 44530"},
        {"Geneva Identification System", "GEN# +1.00077586"},
        {"Smithsonian Astrophysical Observation", "SAO 80610"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.09369672),
        dec: Angle.Degrees(+29.26804669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12884"},
        {"Hipparcos Number", "HIP 9858"},
        {"Geneva Identification System", "GEN# +1.00012884"},
        {"Smithsonian Astrophysical Observation", "SAO 75148"},
        {"Wilson Evans Batten Catalogue", "WEB 2068"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.70477753),
        dec: Angle.Degrees(+29.26941907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257674"},
        {"Hipparcos Number", "HIP 30835"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.15220894),
        dec: Angle.Degrees(+29.27013565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245024"},
        {"Hipparcos Number", "HIP 26227"},
        {"Geneva Identification System", "GEN# +5.20250156"},
        {"Smithsonian Astrophysical Observation", "SAO 77279"},
        {"Wilson Evans Batten Catalogue", "WEB 5129"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.82324518),
        dec: Angle.Degrees(+29.27154675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138854"},
        {"Hipparcos Number", "HIP 76186"},
        {"Smithsonian Astrophysical Observation", "SAO 83884"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.41903072),
        dec: Angle.Degrees(+29.27334709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58312"},
        {"Geneva Identification System", "GEN# +0.03002205"},
        {"Smithsonian Astrophysical Observation", "SAO 82072"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.36597202),
        dec: Angle.Degrees(+29.27426659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215328"},
        {"Hipparcos Number", "HIP 112235"},
        {"Smithsonian Astrophysical Observation", "SAO 90746"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.98667847),
        dec: Angle.Degrees(+29.27703438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14486 A"},
        {"Henry Draper", "HD 199717"},
        {"Hipparcos Number", "HIP 103493"},
        {"Smithsonian Astrophysical Observation", "SAO 89329"},
        {"Wilson Evans Batten Catalogue", "WEB 18825"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.52116196),
        dec: Angle.Degrees(+29.27709366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39614"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.43327521),
        dec: Angle.Degrees(+29.27802879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216140"},
        {"Hipparcos Number", "HIP 112754"},
        {"Geneva Identification System", "GEN# +1.00216140"},
        {"Renson", "Renson 59730"},
        {"Smithsonian Astrophysical Observation", "SAO 90817"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.52277395),
        dec: Angle.Degrees(+29.27899126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335435"},
        {"Hipparcos Number", "HIP 103642"},
        {"Geneva Identification System", "GEN# +1.00335435"},
        {"Smithsonian Astrophysical Observation", "SAO 89357"},
        {"Wilson Evans Batten Catalogue", "WEB 18859"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.98733774),
        dec: Angle.Degrees(+29.27924225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120618"},
        {"Hipparcos Number", "HIP 67517"},
        {"Geneva Identification System", "GEN# +1.00120618"},
        {"Smithsonian Astrophysical Observation", "SAO 83019"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.51855846),
        dec: Angle.Degrees(+29.28030506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73573"},
        {"Hipparcos Number", "HIP 42514"},
        {"Geneva Identification System", "GEN# +1.00073573"},
        {"Smithsonian Astrophysical Observation", "SAO 80329"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.02472059),
        dec: Angle.Degrees(+29.28316712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176970"},
        {"Hipparcos Number", "HIP 93409"},
        {"Geneva Identification System", "GEN# +1.00176970"},
        {"Smithsonian Astrophysical Observation", "SAO 86712"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.36146374),
        dec: Angle.Degrees(+29.28741215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82174"},
        {"Hipparcos Number", "HIP 46694"},
        {"Fundamental Katalog 5th Edition", "FK5 4845"},
        {"Smithsonian Astrophysical Observation", "SAO 80872"},
        {"Wilson Evans Batten Catalogue", "WEB 8808"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.78628333),
        dec: Angle.Degrees(+29.28869927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177251"},
        {"Hipparcos Number", "HIP 93512"},
        {"Smithsonian Astrophysical Observation", "SAO 86735"},
        {"Wilson Evans Batten Catalogue", "WEB 16236"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.66876983),
        dec: Angle.Degrees(+29.29262971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154127"},
        {"Hipparcos Number", "HIP 83383"},
        {"Geneva Identification System", "GEN# +1.00154127"},
        {"Smithsonian Astrophysical Observation", "SAO 84782"},
        {"Wilson Evans Batten Catalogue", "WEB 14092"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.62886884),
        dec: Angle.Degrees(+29.29702925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38232"},
        {"Hipparcos Number", "HIP 27172"},
        {"Geneva Identification System", "GEN# +1.00038232"},
        {"Smithsonian Astrophysical Observation", "SAO 77506"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.38236044),
        dec: Angle.Degrees(+29.29852697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282388"},
        {"Hipparcos Number", "HIP 21817"},
        {"Smithsonian Astrophysical Observation", "SAO 76706"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.32980062),
        dec: Angle.Degrees(+29.30488522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214994"},
        {"Hipparcos Number", "HIP 112051"},
        {"Geneva Identification System", "GEN# +1.00214994"},
        {"Renson", "Renson 59440"},
        {"Smithsonian Astrophysical Observation", "SAO 90717"},
        {"Wilson Evans Batten Catalogue", "WEB 20003"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.43920724),
        dec: Angle.Degrees(+29.30768920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208700"},
        {"Hipparcos Number", "HIP 108385"},
        {"Smithsonian Astrophysical Observation", "SAO 90128"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.37164207),
        dec: Angle.Degrees(+29.31021231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88960"},
        {"Hipparcos Number", "HIP 50303"},
        {"Fundamental Katalog 5th Edition", "FK5 2823"},
        {"Geneva Identification System", "GEN# +1.00088960"},
        {"Smithsonian Astrophysical Observation", "SAO 81258"},
        {"Wilson Evans Batten Catalogue", "WEB 9237"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.06033082),
        dec: Angle.Degrees(+29.31055982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15732"},
        {"Hipparcos Number", "HIP 11823"},
        {"Geneva Identification System", "GEN# +1.00015732"},
        {"Smithsonian Astrophysical Observation", "SAO 75432"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.13613816),
        dec: Angle.Degrees(+29.31153828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3546"},
        {"Hipparcos Number", "HIP 3031"},
        {"Fundamental Katalog 5th Edition", "FK5 19"},
        {"Geneva Identification System", "GEN# +1.00003546"},
        {"Smithsonian Astrophysical Observation", "SAO 74164"},
        {"Wilson Evans Batten Catalogue", "WEB 544"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63958024),
        dec: Angle.Degrees(+29.31236900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22125"},
        {"Hipparcos Number", "HIP 16705"},
        {"Smithsonian Astrophysical Observation", "SAO 76003"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.74122682),
        dec: Angle.Degrees(+29.31333909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58597"},
        {"Hipparcos Number", "HIP 36221"},
        {"Smithsonian Astrophysical Observation", "SAO 79397"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.88650436),
        dec: Angle.Degrees(+29.31348190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109069"},
        {"Hipparcos Number", "HIP 61147"},
        {"Fundamental Katalog 5th Edition", "FK5 5103"},
        {"Geneva Identification System", "GEN# +1.00109069"},
        {"Smithsonian Astrophysical Observation", "SAO 82360"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.96066896),
        dec: Angle.Degrees(+29.31416531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72146"},
        {"Hipparcos Number", "HIP 41875"},
        {"Geneva Identification System", "GEN# +1.00072146"},
        {"Smithsonian Astrophysical Observation", "SAO 80232"},
        {"Wilson Evans Batten Catalogue", "WEB 8059"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.07230716),
        dec: Angle.Degrees(+29.31936199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53442"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.99453366),
        dec: Angle.Degrees(+29.32041666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57976"},
        {"Geneva Identification System", "GEN# +0.03002200"},
        {"Smithsonian Astrophysical Observation", "SAO 82035"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.38740110),
        dec: Angle.Degrees(+29.32198890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162555"},
        {"Hipparcos Number", "HIP 87308"},
        {"Geneva Identification System", "GEN# +1.00162555"},
        {"Smithsonian Astrophysical Observation", "SAO 85464"},
        {"Wilson Evans Batten Catalogue", "WEB 14730"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.59529976),
        dec: Angle.Degrees(+29.32202669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55115"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26469676),
        dec: Angle.Degrees(+29.32397408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97174"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.26302723),
        dec: Angle.Degrees(+29.32793309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 305.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87095"},
        {"Smithsonian Astrophysical Observation", "SAO 85419"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93344868),
        dec: Angle.Degrees(+29.32953115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186357"},
        {"Hipparcos Number", "HIP 96988"},
        {"Geneva Identification System", "GEN# +1.00186357"},
        {"Renson", "Renson 51373"},
        {"Smithsonian Astrophysical Observation", "SAO 87612"},
        {"Wilson Evans Batten Catalogue", "WEB 17020"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70447094),
        dec: Angle.Degrees(+29.33164997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198946"},
        {"Hipparcos Number", "HIP 103066"},
        {"Smithsonian Astrophysical Observation", "SAO 89238"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.23418298),
        dec: Angle.Degrees(+29.33193418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332845"},
        {"Hipparcos Number", "HIP 97806"},
        {"Geneva Identification System", "GEN# +2.68340202"},
        {"New General Catalogue", "NGC 6834 202"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.12781416),
        dec: Angle.Degrees(+29.33258493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197227"},
        {"Hipparcos Number", "HIP 102093"},
        {"Geneva Identification System", "GEN# +1.00197227"},
        {"Smithsonian Astrophysical Observation", "SAO 89012"},
        {"Wilson Evans Batten Catalogue", "WEB 18465"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.35021500),
        dec: Angle.Degrees(+29.33301194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178029"},
        {"Hipparcos Number", "HIP 93776"},
        {"Smithsonian Astrophysical Observation", "SAO 86798"},
        {"Wilson Evans Batten Catalogue", "WEB 16298"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.46148535),
        dec: Angle.Degrees(+29.33319007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30262"},
        {"Hipparcos Number", "HIP 22250"},
        {"Smithsonian Astrophysical Observation", "SAO 76751"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.84177661),
        dec: Angle.Degrees(+29.33326834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12696 A"},
        {"Henry Draper", "HD 185268"},
        {"Hipparcos Number", "HIP 96503"},
        {"Celescope Catalog", "CEL 4804"},
        {"Geneva Identification System", "GEN# +1.00185268"},
        {"Smithsonian Astrophysical Observation", "SAO 87462"},
        {"Wilson Evans Batten Catalogue", "WEB 16935"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.29007444),
        dec: Angle.Degrees(+29.33371247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92366"},
        {"Smithsonian Astrophysical Observation", "SAO 86474"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36225446),
        dec: Angle.Degrees(+29.33476065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31965"},
        {"Hipparcos Number", "HIP 23336"},
        {"Smithsonian Astrophysical Observation", "SAO 76892"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.29076903),
        dec: Angle.Degrees(+29.33481299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333282"},
        {"Hipparcos Number", "HIP 98396"},
        {"Smithsonian Astrophysical Observation", "SAO 88031"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.87893070),
        dec: Angle.Degrees(+29.33609585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34800"},
        {"Smithsonian Astrophysical Observation", "SAO 79154"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.06052096),
        dec: Angle.Degrees(+29.33667610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52711"},
        {"Hipparcos Number", "HIP 34017"},
        {"Cincinnati Publication", "Ci 20 410"},
        {"Geneva Identification System", "GEN# +1.00052711"},
        {"Smithsonian Astrophysical Observation", "SAO 79009"},
        {"Wilson Evans Batten Catalogue", "WEB 6821"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87647681),
        dec: Angle.Degrees(+29.33909345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -828.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334958"},
        {"Hipparcos Number", "HIP 102004"},
        {"Smithsonian Astrophysical Observation", "SAO 88987"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05717904),
        dec: Angle.Degrees(+29.33948093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15215 AB"},
        {"Henry Draper", "HD 206373"},
        {"Hipparcos Number", "HIP 107060"},
        {"Geneva Identification System", "GEN# +1.00206373"},
        {"Smithsonian Astrophysical Observation", "SAO 89904"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.25262280),
        dec: Angle.Degrees(+29.34043893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85057"},
        {"Smithsonian Astrophysical Observation", "SAO 85051"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.74045428),
        dec: Angle.Degrees(+29.34510968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282650"},
        {"Hipparcos Number", "HIP 22778"},
        {"Smithsonian Astrophysical Observation", "SAO 76815"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48575098),
        dec: Angle.Degrees(+29.34540975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3867"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.41396960),
        dec: Angle.Degrees(+29.34603377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208330"},
        {"Hipparcos Number", "HIP 108171"},
        {"Geneva Identification System", "GEN# +1.00208330"},
        {"Smithsonian Astrophysical Observation", "SAO 90092"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.73706398),
        dec: Angle.Degrees(+29.34845130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109402"},
    },
    visualMagnitude: 11.86,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.46386467),
        dec: Angle.Degrees(+29.35170209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 273.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34114"},
        {"Hipparcos Number", "HIP 24571"},
        {"Smithsonian Astrophysical Observation", "SAO 77066"},
        {"Wilson Evans Batten Catalogue", "WEB 4758"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.06388920),
        dec: Angle.Degrees(+29.35668089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142068"},
        {"Hipparcos Number", "HIP 77671"},
        {"Smithsonian Astrophysical Observation", "SAO 84041"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.86124439),
        dec: Angle.Degrees(+29.35671024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178991"},
        {"Hipparcos Number", "HIP 94117"},
        {"Celescope Catalog", "CEL 4710"},
        {"Geneva Identification System", "GEN# +1.00178991"},
        {"Smithsonian Astrophysical Observation", "SAO 86877"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.38795388),
        dec: Angle.Degrees(+29.35803676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332981"},
        {"Hipparcos Number", "HIP 98046"},
        {"Smithsonian Astrophysical Observation", "SAO 87936"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.85005193),
        dec: Angle.Degrees(+29.35842007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216685"},
        {"Hipparcos Number", "HIP 113132"},
        {"Geneva Identification System", "GEN# +1.00216685"},
        {"Smithsonian Astrophysical Observation", "SAO 90871"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.64843205),
        dec: Angle.Degrees(+29.35856807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197208"},
        {"Hipparcos Number", "HIP 102084"},
        {"Geneva Identification System", "GEN# +1.00197208"},
        {"Smithsonian Astrophysical Observation", "SAO 89011"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.32714679),
        dec: Angle.Degrees(+29.35954572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117073",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16957 AB"},
        {"Henry Draper", "HD 222842"},
        {"Hipparcos Number", "HIP 117073"},
        {"Geneva Identification System", "GEN# +1.00222842"},
        {"Smithsonian Astrophysical Observation", "SAO 91457"},
        {"Wilson Evans Batten Catalogue", "WEB 20639"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99765846),
        dec: Angle.Degrees(+29.36155278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106091"},
        {"Smithsonian Astrophysical Observation", "SAO 89745"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.35893646),
        dec: Angle.Degrees(+29.36358096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191745"},
        {"Hipparcos Number", "HIP 99402"},
        {"Smithsonian Astrophysical Observation", "SAO 88297"},
        {"Wilson Evans Batten Catalogue", "WEB 17744"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.63431382),
        dec: Angle.Degrees(+29.36381221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169358"},
        {"Hipparcos Number", "HIP 90091"},
        {"Smithsonian Astrophysical Observation", "SAO 85990"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.77020811),
        dec: Angle.Degrees(+29.36511024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66541",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 38"},
        {"Hipparcos Number", "HIP 66541"},
        {"Geneva Identification System", "GEN# +0.03002431"},
        {"Renson", "Renson 34310"},
        {"Smithsonian Astrophysical Observation", "SAO 82919"},
        {"Wilson Evans Batten Catalogue", "WEB 11743"},
    },
    visualMagnitude: 10.06,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.60322679),
        dec: Angle.Degrees(+29.36582932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32378",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5408 AB"},
        {"Henry Draper", "HD 48591"},
        {"Hipparcos Number", "HIP 32378"},
        {"Geneva Identification System", "GEN# +1.00048591J"},
        {"Smithsonian Astrophysical Observation", "SAO 78705"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.36257708),
        dec: Angle.Degrees(+29.36661861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128109"},
        {"Hipparcos Number", "HIP 71250"},
        {"Geneva Identification System", "GEN# +1.00128109"},
        {"Smithsonian Astrophysical Observation", "SAO 83410"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.56292108),
        dec: Angle.Degrees(+29.36857723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126009"},
        {"Hipparcos Number", "HIP 70236"},
        {"Geneva Identification System", "GEN# +1.00126009"},
        {"Smithsonian Astrophysical Observation", "SAO 83312"},
        {"Wilson Evans Batten Catalogue", "WEB 12195"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.55844676),
        dec: Angle.Degrees(+29.36998400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3702"},
        {"Hipparcos Number", "HIP 3141"},
        {"Smithsonian Astrophysical Observation", "SAO 74181"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.98637657),
        dec: Angle.Degrees(+29.37075619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44071"},
        {"Hipparcos Number", "HIP 30188"},
        {"Geneva Identification System", "GEN# +1.00044071"},
        {"Smithsonian Astrophysical Observation", "SAO 78257"},
        {"Wilson Evans Batten Catalogue", "WEB 6005"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.26706992),
        dec: Angle.Degrees(+29.37171516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187565"},
        {"Hipparcos Number", "HIP 97543"},
        {"Geneva Identification System", "GEN# +1.00187565"},
        {"Smithsonian Astrophysical Observation", "SAO 87776"},
        {"Wilson Evans Batten Catalogue", "WEB 17153"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.38172557),
        dec: Angle.Degrees(+29.37489644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48007"},
        {"Hipparcos Number", "HIP 32120"},
        {"Smithsonian Astrophysical Observation", "SAO 78658"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.63679564),
        dec: Angle.Degrees(+29.37525251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77312"},
        {"Hipparcos Number", "HIP 44400"},
        {"Smithsonian Astrophysical Observation", "SAO 80593"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.67430291),
        dec: Angle.Degrees(+29.37525390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108721"},
        {"Smithsonian Astrophysical Observation", "SAO 90174"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.36186226),
        dec: Angle.Degrees(+29.37621235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109859"},
        {"Smithsonian Astrophysical Observation", "SAO 90354"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.75915952),
        dec: Angle.Degrees(+29.38080970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36480"},
        {"Cincinnati Publication", "Ci 18 898"},
        {"Geneva Identification System", "GEN# +0.02901539"},
        {"Smithsonian Astrophysical Observation", "SAO 79440"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.59321204),
        dec: Angle.Degrees(+29.38113454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114172"},
        {"Hipparcos Number", "HIP 64131"},
        {"Geneva Identification System", "GEN# +1.00114172"},
        {"Smithsonian Astrophysical Observation", "SAO 82672"},
        {"Wilson Evans Batten Catalogue", "WEB 11335"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16056292),
        dec: Angle.Degrees(+29.38340561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198550"},
        {"Hipparcos Number", "HIP 102851"},
        {"Geneva Identification System", "GEN# +1.00198550"},
        {"Smithsonian Astrophysical Observation", "SAO 89188"},
        {"Wilson Evans Batten Catalogue", "WEB 18658"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.54391842),
        dec: Angle.Degrees(+29.38425838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36815"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57704676),
        dec: Angle.Degrees(+29.38458012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92768"},
        {"Hipparcos Number", "HIP 52442"},
        {"Geneva Identification System", "GEN# +1.00092768"},
        {"Smithsonian Astrophysical Observation", "SAO 81486"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.79752980),
        dec: Angle.Degrees(+29.38463162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29333"},
        {"Hipparcos Number", "HIP 21615"},
        {"Smithsonian Astrophysical Observation", "SAO 76679"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.60830172),
        dec: Angle.Degrees(+29.38735501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26007"},
        {"Geneva Identification System", "GEN# +9.80098008"},
        {"Geneva Identification System 2", "GEN# +6.10010207"},
    },
    visualMagnitude: 12.08,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26129571),
        dec: Angle.Degrees(+29.38931839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -327.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10585 AB"},
        {"Hipparcos Number", "HIP 85582"},
        {"Cincinnati Publication", "Ci 18 2334"},
        {"Smithsonian Astrophysical Observation", "SAO 85142"},
        {"Wilson Evans Batten Catalogue", "WEB 14446"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.33418538),
        dec: Angle.Degrees(+29.39261462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71787"},
        {"Smithsonian Astrophysical Observation", "SAO 83466"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.26533427),
        dec: Angle.Degrees(+29.39266663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 851"},
        {"Hipparcos Number", "HIP 1037"},
        {"Smithsonian Astrophysical Observation", "SAO 73818"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.24858774),
        dec: Angle.Degrees(+29.39292162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96549"},
        {"Smithsonian Astrophysical Observation", "SAO 87481"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.42982896),
        dec: Angle.Degrees(+29.39377651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199695"},
        {"Hipparcos Number", "HIP 103488"},
        {"Geneva Identification System", "GEN# +1.00199695"},
        {"Smithsonian Astrophysical Observation", "SAO 89327"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.50943537),
        dec: Angle.Degrees(+29.39454689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16250 AB"},
        {"Henry Draper", "HD 215567"},
        {"Hipparcos Number", "HIP 112386"},
        {"Smithsonian Astrophysical Observation", "SAO 90768"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.43377111),
        dec: Angle.Degrees(+29.39481542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217714"},
        {"Hipparcos Number", "HIP 113756"},
        {"Smithsonian Astrophysical Observation", "SAO 90963"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.55733628),
        dec: Angle.Degrees(+29.39547649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3623"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.61680001),
        dec: Angle.Degrees(+29.39616102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97764"},
        {"Geneva Identification System", "GEN# +2.68340073"},
        {"Geneva Identification System 2", "GEN# +6.10131792"},
        {"New General Catalogue", "NGC 6834 73"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00582450),
        dec: Angle.Degrees(+29.39724818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52406"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.67582334),
        dec: Angle.Degrees(+29.39798870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332844"},
        {"Hipparcos Number", "HIP 97772"},
        {"Geneva Identification System", "GEN# +2.68340072"},
        {"New General Catalogue", "NGC 6834 72"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.02496058),
        dec: Angle.Degrees(+29.39852673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10585 C"},
        {"Henry Draper", "HD 158638"},
        {"Hipparcos Number", "HIP 85579"},
        {"Smithsonian Astrophysical Observation", "SAO 85139"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.32132760),
        dec: Angle.Degrees(+29.40052936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1878"},
        {"Geneva Identification System", "GEN# +0.02800054"},
        {"Smithsonian Astrophysical Observation", "SAO 73952"},
        {"Wilson Evans Batten Catalogue", "WEB 333"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.92955787),
        dec: Angle.Degrees(+29.40105284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115103"},
        {"Hipparcos Number", "HIP 64614"},
        {"Geneva Identification System", "GEN# +1.00115103"},
        {"Smithsonian Astrophysical Observation", "SAO 82735"},
        {"Wilson Evans Batten Catalogue", "WEB 11428"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.65423314),
        dec: Angle.Degrees(+29.40127620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187399"},
        {"Hipparcos Number", "HIP 97472"},
        {"Celescope Catalog", "CEL 4850"},
        {"Geneva Identification System", "GEN# +1.00187399"},
        {"Smithsonian Astrophysical Observation", "SAO 87754"},
        {"Wilson Evans Batten Catalogue", "WEB 17135"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.17448213),
        dec: Angle.Degrees(+29.40234230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16111"},
        {"Hipparcos Number", "HIP 12115"},
        {"Smithsonian Astrophysical Observation", "SAO 75460"},
        {"Wilson Evans Batten Catalogue", "WEB 2494"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.01793141),
        dec: Angle.Degrees(+29.40380793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37693"},
        {"Smithsonian Astrophysical Observation", "SAO 79648"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.99580535),
        dec: Angle.Degrees(+29.40606319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46159"},
        {"Hipparcos Number", "HIP 31230"},
        {"Smithsonian Astrophysical Observation", "SAO 78479"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.26445318),
        dec: Angle.Degrees(+29.40656433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332843"},
        {"Hipparcos Number", "HIP 97785"},
        {"Geneva Identification System", "GEN# +2.68340001"},
        {"New General Catalogue", "NGC 6834 1"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.05664555),
        dec: Angle.Degrees(+29.40769341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214639"},
        {"Hipparcos Number", "HIP 111836"},
        {"Geneva Identification System", "GEN# +1.00214639"},
        {"Smithsonian Astrophysical Observation", "SAO 90679"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.80031180),
        dec: Angle.Degrees(+29.40862977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161883"},
        {"Hipparcos Number", "HIP 87027"},
        {"Geneva Identification System", "GEN# +1.00161883"},
        {"Smithsonian Astrophysical Observation", "SAO 85408"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.72376923),
        dec: Angle.Degrees(+29.40867409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249650"},
        {"Hipparcos Number", "HIP 28258"},
        {"Smithsonian Astrophysical Observation", "SAO 77779"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.56079638),
        dec: Angle.Degrees(+29.41173202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9224"},
        {"Hipparcos Number", "HIP 7090"},
        {"Geneva Identification System", "GEN# +1.00009224"},
        {"Smithsonian Astrophysical Observation", "SAO 74767"},
        {"Wilson Evans Batten Catalogue", "WEB 1529"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.83085664),
        dec: Angle.Degrees(+29.41330395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93636"},
        {"Hipparcos Number", "HIP 52882"},
        {"Geneva Identification System", "GEN# +1.00093636"},
        {"Smithsonian Astrophysical Observation", "SAO 81533"},
        {"Wilson Evans Batten Catalogue", "WEB 9627"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.23867399),
        dec: Angle.Degrees(+29.41614877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161130"},
        {"Hipparcos Number", "HIP 86679"},
        {"Geneva Identification System", "GEN# +1.00161130"},
        {"Smithsonian Astrophysical Observation", "SAO 85347"},
        {"Wilson Evans Batten Catalogue", "WEB 14616"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.65313951),
        dec: Angle.Degrees(+29.41890547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104565"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.72881376),
        dec: Angle.Degrees(+29.42378925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56509"},
        {"Geneva Identification System", "GEN# +0.03002175"},
        {"Wilson Evans Batten Catalogue", "WEB 10157"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.76895453),
        dec: Angle.Degrees(+29.42478968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58746"},
        {"Hipparcos Number", "HIP 36291"},
        {"Geneva Identification System", "GEN# +1.00058746"},
        {"Smithsonian Astrophysical Observation", "SAO 79408"},
        {"Wilson Evans Batten Catalogue", "WEB 7225"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.05070944),
        dec: Angle.Degrees(+29.42501300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146829"},
        {"Hipparcos Number", "HIP 79798"},
        {"Geneva Identification System", "GEN# +1.00146829"},
        {"Smithsonian Astrophysical Observation", "SAO 84287"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.28881034),
        dec: Angle.Degrees(+29.42827276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79877"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.55248041),
        dec: Angle.Degrees(+29.42834750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38450"},
        {"Hipparcos Number", "HIP 27312"},
        {"Geneva Identification System", "GEN# +1.00038450"},
        {"Smithsonian Astrophysical Observation", "SAO 77548"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.79125095),
        dec: Angle.Degrees(+29.43071777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143393"},
        {"Hipparcos Number", "HIP 78288"},
        {"Geneva Identification System", "GEN# +1.00143393"},
        {"Smithsonian Astrophysical Observation", "SAO 84124"},
        {"Wilson Evans Batten Catalogue", "WEB 13238"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.77453593),
        dec: Angle.Degrees(+29.43172246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73890"},
        {"Smithsonian Astrophysical Observation", "SAO 83660"},
        {"Wilson Evans Batten Catalogue", "WEB 12621"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.53209077),
        dec: Angle.Degrees(+29.43238266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220286"},
        {"Hipparcos Number", "HIP 115379"},
        {"Geneva Identification System", "GEN# +1.00220286"},
        {"Smithsonian Astrophysical Observation", "SAO 91215"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.59605273),
        dec: Angle.Degrees(+29.43336880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216465"},
        {"Hipparcos Number", "HIP 112979"},
        {"Geneva Identification System", "GEN# +1.00216465"},
        {"Smithsonian Astrophysical Observation", "SAO 90850"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20290410),
        dec: Angle.Degrees(+29.44102935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219110"},
        {"Hipparcos Number", "HIP 114607"},
        {"Geneva Identification System", "GEN# +1.00219110"},
        {"Smithsonian Astrophysical Observation", "SAO 91095"},
        {"Wilson Evans Batten Catalogue", "WEB 20331"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.26669268),
        dec: Angle.Degrees(+29.44162201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114448"},
        {"Hipparcos Number", "HIP 64269"},
        {"Geneva Identification System", "GEN# +1.00114448"},
        {"Wilson Evans Batten Catalogue", "WEB 11360"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58730130),
        dec: Angle.Degrees(+29.44391107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20401"},
        {"Hipparcos Number", "HIP 15348"},
        {"Smithsonian Astrophysical Observation", "SAO 75844"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.47582325),
        dec: Angle.Degrees(+29.44682704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168742"},
        {"Hipparcos Number", "HIP 89845"},
        {"Smithsonian Astrophysical Observation", "SAO 85937"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.01837876),
        dec: Angle.Degrees(+29.44804784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75216"},
        {"Hipparcos Number", "HIP 43340"},
        {"Smithsonian Astrophysical Observation", "SAO 80447"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.43882737),
        dec: Angle.Degrees(+29.44895326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332701"},
        {"Hipparcos Number", "HIP 97374"},
        {"Celescope Catalog", "CEL 4844"},
        {"Geneva Identification System", "GEN# +1.00332701"},
        {"Renson", "Renson 51620"},
        {"Smithsonian Astrophysical Observation", "SAO 87727"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86408351),
        dec: Angle.Degrees(+29.44933759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183399"},
        {"Hipparcos Number", "HIP 95728"},
        {"Smithsonian Astrophysical Observation", "SAO 87251"},
        {"Wilson Evans Batten Catalogue", "WEB 16750"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05775946),
        dec: Angle.Degrees(+29.45033069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224084"},
        {"Hipparcos Number", "HIP 117913"},
        {"Geneva Identification System", "GEN# +1.00224084"},
        {"Smithsonian Astrophysical Observation", "SAO 91577"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.75559351),
        dec: Angle.Degrees(+29.45051816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98376"},
        {"Wilson Evans Batten Catalogue", "WEB 17359"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.79499688),
        dec: Angle.Degrees(+29.45075682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8408"},
        {"Smithsonian Astrophysical Observation", "SAO 74943"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.11934130),
        dec: Angle.Degrees(+29.45183145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264672"},
        {"Hipparcos Number", "HIP 32845"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.69189421),
        dec: Angle.Degrees(+29.45320539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109650"},
        {"Hipparcos Number", "HIP 61503"},
        {"Geneva Identification System", "GEN# +1.00109650"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.02317124),
        dec: Angle.Degrees(+29.45322305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1826"},
        {"Hipparcos Number", "HIP 1799"},
        {"Geneva Identification System", "GEN# +1.00001826"},
        {"Renson", "Renson 410"},
        {"Smithsonian Astrophysical Observation", "SAO 73938"},
        {"Wilson Evans Batten Catalogue", "WEB 319"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.70759794),
        dec: Angle.Degrees(+29.45430352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22765"},
        {"Hipparcos Number", "HIP 17172"},
        {"Smithsonian Astrophysical Observation", "SAO 76072"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.16785495),
        dec: Angle.Degrees(+29.45467598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10553 A"},
        {"Henry Draper", "HD 158116"},
        {"Hipparcos Number", "HIP 85327"},
        {"Geneva Identification System", "GEN# +1.00158116A"},
        {"Geneva Identification System 2", "GEN# +1.00158116"},
        {"Renson", "Renson 44440"},
        {"Smithsonian Astrophysical Observation", "SAO 85089"},
        {"Wilson Evans Batten Catalogue", "WEB 14406"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.55733003),
        dec: Angle.Degrees(+29.45565895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49572"},
        {"Cincinnati Publication", "Ci 18 1203"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.79297941),
        dec: Angle.Degrees(+29.45665324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207371"},
        {"Hipparcos Number", "HIP 107602"},
        {"Smithsonian Astrophysical Observation", "SAO 90000"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92077123),
        dec: Angle.Degrees(+29.46025730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12808",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2091 AB"},
        {"Henry Draper", "HD 17007"},
        {"Hipparcos Number", "HIP 12808"},
        {"Geneva Identification System", "GEN# +1.00017007"},
        {"Smithsonian Astrophysical Observation", "SAO 75544"},
        {"Wilson Evans Batten Catalogue", "WEB 2604"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.15339728),
        dec: Angle.Degrees(+29.46031092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105586"},
        {"Hipparcos Number", "HIP 59262"},
        {"Geneva Identification System", "GEN# +1.00105586"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.34037459),
        dec: Angle.Degrees(+29.46060462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17868"},
        {"Hipparcos Number", "HIP 13440"},
        {"Smithsonian Astrophysical Observation", "SAO 75618"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.26566633),
        dec: Angle.Degrees(+29.46093999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204051"},
        {"Hipparcos Number", "HIP 105770"},
        {"Smithsonian Astrophysical Observation", "SAO 89697"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.33326269),
        dec: Angle.Degrees(+29.46170629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184759"},
        {"Henry Draper 2", "HD 184760"},
        {"Hipparcos Number", "HIP 96302"},
        {"Celescope Catalog", "CEL 4788"},
        {"Geneva Identification System", "GEN# +1.00184759"},
        {"Smithsonian Astrophysical Observation", "SAO 87385"},
        {"Wilson Evans Batten Catalogue", "WEB 16885"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.71216081),
        dec: Angle.Degrees(+29.46291111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333421"},
        {"Hipparcos Number", "HIP 98886"},
        {"Geneva Identification System", "GEN# +1.00333421"},
        {"Smithsonian Astrophysical Observation", "SAO 88164"},
        {"Wilson Evans Batten Catalogue", "WEB 17551"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.21077162),
        dec: Angle.Degrees(+29.46375287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91007"},
        {"Smithsonian Astrophysical Observation", "SAO 86199"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.47848837),
        dec: Angle.Degrees(+29.46435558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11130"},
        {"Hipparcos Number", "HIP 8543"},
        {"Geneva Identification System", "GEN# +1.00011130"},
        {"Smithsonian Astrophysical Observation", "SAO 74963"},
        {"Wilson Evans Batten Catalogue", "WEB 1815"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.53293290),
        dec: Angle.Degrees(+29.46472971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132358"},
        {"Hipparcos Number", "HIP 73220"},
        {"Geneva Identification System", "GEN# +1.00132358"},
        {"Smithsonian Astrophysical Observation", "SAO 83600"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.46423077),
        dec: Angle.Degrees(+29.46685393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69913"},
        {"Geneva Identification System", "GEN# +0.03002504"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.61957123),
        dec: Angle.Degrees(+29.46699966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334372"},
        {"Hipparcos Number", "HIP 100788"},
        {"Geneva Identification System", "GEN# +1.00334372"},
        {"Smithsonian Astrophysical Observation", "SAO 88675"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.52947222),
        dec: Angle.Degrees(+29.46700851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87917"},
        {"Smithsonian Astrophysical Observation", "SAO 85584"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.39145827),
        dec: Angle.Degrees(+29.46806332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142418"},
        {"Hipparcos Number", "HIP 77828"},
        {"Smithsonian Astrophysical Observation", "SAO 84061"},
        {"Wilson Evans Batten Catalogue", "WEB 13161"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37406518),
        dec: Angle.Degrees(+29.46889784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71594"},
        {"Hipparcos Number", "HIP 41632"},
        {"Geneva Identification System", "GEN# +1.00071594"},
        {"Smithsonian Astrophysical Observation", "SAO 80207"},
        {"Wilson Evans Batten Catalogue", "WEB 8035"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.31841429),
        dec: Angle.Degrees(+29.46933351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110831"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.80976708),
        dec: Angle.Degrees(+29.47008994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84424"},
        {"Smithsonian Astrophysical Observation", "SAO 84956"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.89698987),
        dec: Angle.Degrees(+29.47196766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205851"},
        {"Hipparcos Number", "HIP 106736"},
        {"Geneva Identification System", "GEN# +1.00205851"},
        {"Smithsonian Astrophysical Observation", "SAO 89849"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.32733850),
        dec: Angle.Degrees(+29.47270858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282765"},
        {"Hipparcos Number", "HIP 23291"},
        {"Smithsonian Astrophysical Observation", "SAO 76887"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.15362254),
        dec: Angle.Degrees(+29.47287741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95039"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.06740004),
        dec: Angle.Degrees(+29.47473865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88353"},
        {"Hipparcos Number", "HIP 49947"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.96369256),
        dec: Angle.Degrees(+29.47497143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224083"},
        {"Hipparcos Number", "HIP 117906"},
        {"Geneva Identification System", "GEN# +1.00224083"},
        {"Smithsonian Astrophysical Observation", "SAO 91574"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.73492703),
        dec: Angle.Degrees(+29.47562032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10344"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.31425252),
        dec: Angle.Degrees(+29.47847803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154227"},
        {"Hipparcos Number", "HIP 83420"},
        {"Geneva Identification System", "GEN# +1.00154227"},
        {"Smithsonian Astrophysical Observation", "SAO 84794"},
        {"Wilson Evans Batten Catalogue", "WEB 14100"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.76139272),
        dec: Angle.Degrees(+29.47935135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84871"},
        {"Hipparcos Number", "HIP 48160"},
        {"Smithsonian Astrophysical Observation", "SAO 81026"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.24798945),
        dec: Angle.Degrees(+29.48076723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335471"},
        {"Hipparcos Number", "HIP 103897"},
        {"Geneva Identification System", "GEN# +1.00335471"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.77626854),
        dec: Angle.Degrees(+29.48268988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 252"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.77959051),
        dec: Angle.Degrees(+29.48598254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87553"},
        {"Smithsonian Astrophysical Observation", "SAO 85509"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.30160254),
        dec: Angle.Degrees(+29.48688219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139588"},
        {"Hipparcos Number", "HIP 76551"},
        {"Geneva Identification System", "GEN# +1.00139588"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.51260555),
        dec: Angle.Degrees(+29.48721126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87842"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.18319630),
        dec: Angle.Degrees(+29.48727741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4262 A"},
        {"Henry Draper", "HD 37646"},
        {"Hipparcos Number", "HIP 26781"},
        {"Celescope Catalog", "CEL 920"},
        {"Geneva Identification System", "GEN# +1.00037646"},
        {"Smithsonian Astrophysical Observation", "SAO 77393"},
        {"Wilson Evans Batten Catalogue", "WEB 5282"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.33736027),
        dec: Angle.Degrees(+29.48748098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105182"},
        {"Hipparcos Number", "HIP 59058"},
        {"Geneva Identification System", "GEN# +1.00105182"},
        {"Wilson Evans Batten Catalogue", "WEB 10515"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.67543647),
        dec: Angle.Degrees(+29.48908768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5137"},
        {"Hipparcos Number", "HIP 4197"},
        {"Geneva Identification System", "GEN# +1.00005137"},
        {"Smithsonian Astrophysical Observation", "SAO 74342"},
        {"Wilson Evans Batten Catalogue", "WEB 754"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.40407202),
        dec: Angle.Degrees(+29.48942142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190842"},
        {"Hipparcos Number", "HIP 98995"},
        {"Geneva Identification System", "GEN# +1.00190842"},
        {"Smithsonian Astrophysical Observation", "SAO 88188"},
        {"Wilson Evans Batten Catalogue", "WEB 17588"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.47857632),
        dec: Angle.Degrees(+29.49005943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67190"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.54089325),
        dec: Angle.Degrees(+29.49113048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87838"},
        {"Smithsonian Astrophysical Observation", "SAO 85564"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.17733986),
        dec: Angle.Degrees(+29.49153830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66531"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.56981800),
        dec: Angle.Degrees(+29.49167219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96736"},
        {"Hipparcos Number", "HIP 54488"},
        {"Geneva Identification System", "GEN# +1.00096736"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.21219969),
        dec: Angle.Degrees(+29.49172816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29435",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4790 A"},
        {"Henry Draper", "HD 42454"},
        {"Henry Draper 2", "HD 42454A"},
        {"Hipparcos Number", "HIP 29435"},
        {"Smithsonian Astrophysical Observation", "SAO 78095"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.02286584),
        dec: Angle.Degrees(+29.49215384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202462"},
        {"Hipparcos Number", "HIP 104924"},
        {"Smithsonian Astrophysical Observation", "SAO 89564"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.80593772),
        dec: Angle.Degrees(+29.49296385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62967"},
        {"Geneva Identification System", "GEN# +0.03002342"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54, 11.2900),
        dec: Angle.DegreesMinutesSeconds((int)+29, (int)29, 35.500)
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
    primaryId: "HIP 101534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334704"},
        {"Hipparcos Number", "HIP 101534"},
        {"Smithsonian Astrophysical Observation", "SAO 88861"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.66264116),
        dec: Angle.Degrees(+29.49420073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4262 B"},
        {"Henry Draper", "HD 37647"},
        {"Hipparcos Number", "HIP 26783"},
        {"Geneva Identification System", "GEN# +1.00037647"},
        {"Smithsonian Astrophysical Observation", "SAO 77394"},
        {"Wilson Evans Batten Catalogue", "WEB 5284"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.33940839),
        dec: Angle.Degrees(+29.49448108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1887",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 324 B"},
        {"Henry Draper", "HD 1941"},
        {"Hipparcos Number", "HIP 1887"},
        {"Geneva Identification System", "GEN# +1.00001941"},
        {"Smithsonian Astrophysical Observation", "SAO 73955"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.96439910),
        dec: Angle.Degrees(+29.49591489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186259"},
        {"Hipparcos Number", "HIP 96929"},
        {"Geneva Identification System", "GEN# +1.00186259"},
        {"Smithsonian Astrophysical Observation", "SAO 87596"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.55269596),
        dec: Angle.Degrees(+29.49749334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102686"},
        {"Hipparcos Number", "HIP 57664"},
        {"Geneva Identification System", "GEN# +1.00102686"},
        {"Wilson Evans Batten Catalogue", "WEB 10356"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.39667377),
        dec: Angle.Degrees(+29.49854823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43039"},
        {"Hipparcos Number", "HIP 29696"},
        {"Fundamental Katalog 5th Edition", "FK5 1168"},
        {"Geneva Identification System", "GEN# +1.00043039"},
        {"Smithsonian Astrophysical Observation", "SAO 78143"},
        {"Wilson Evans Batten Catalogue", "WEB 5849"},
    },
    visualMagnitude: 4.32,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.84473576),
        dec: Angle.Degrees(+29.49871224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193410"},
        {"Henry Draper 2", "HD 193411"},
        {"Hipparcos Number", "HIP 100176"},
        {"Geneva Identification System", "GEN# +1.00193410"},
        {"Smithsonian Astrophysical Observation", "SAO 88512"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79368230),
        dec: Angle.Degrees(+29.49906467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92068"},
        {"Hipparcos Number", "HIP 52062"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.57660926),
        dec: Angle.Degrees(+29.49929779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199102"},
        {"Hipparcos Number", "HIP 103149"},
        {"Smithsonian Astrophysical Observation", "SAO 89259"},
        {"Wilson Evans Batten Catalogue", "WEB 18732"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.48632236),
        dec: Angle.Degrees(+29.49967783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38034"},
        {"Hipparcos Number", "HIP 27039"},
        {"Geneva Identification System", "GEN# +1.00038034"},
        {"Smithsonian Astrophysical Observation", "SAO 77470"},
        {"Wilson Evans Batten Catalogue", "WEB 5323"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.02027016),
        dec: Angle.Degrees(+29.50141072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1891",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 324 A"},
        {"Henry Draper", "HD 1942"},
        {"Hipparcos Number", "HIP 1891"},
        {"Geneva Identification System", "GEN# +1.00001942"},
        {"Smithsonian Astrophysical Observation", "SAO 73956"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.97167100),
        dec: Angle.Degrees(+29.50252837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113302"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.17793978),
        dec: Angle.Degrees(+29.50429053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131290"},
        {"Hipparcos Number", "HIP 72701"},
        {"Smithsonian Astrophysical Observation", "SAO 83559"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.96392231),
        dec: Angle.Degrees(+29.50477432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73499"},
        {"Smithsonian Astrophysical Observation", "SAO 83620"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.33716884),
        dec: Angle.Degrees(+29.50540894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10407"},
        {"Hipparcos Number", "HIP 7948"},
        {"Smithsonian Astrophysical Observation", "SAO 74880"},
        {"Wilson Evans Batten Catalogue", "WEB 1699"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.52471564),
        dec: Angle.Degrees(+29.50606787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158823"},
        {"Hipparcos Number", "HIP 85651"},
        {"Smithsonian Astrophysical Observation", "SAO 85155"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.56091885),
        dec: Angle.Degrees(+29.50743804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9098"},
        {"Hipparcos Number", "HIP 7003"},
        {"Smithsonian Astrophysical Observation", "SAO 74757"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.53096113),
        dec: Angle.Degrees(+29.50878200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4673 A"},
        {"Henry Draper", "HD 41429"},
        {"Hipparcos Number", "HIP 28930"},
        {"Geneva Identification System", "GEN# +1.00041429A"},
        {"Geneva Identification System 2", "GEN# +1.00041429"},
        {"Smithsonian Astrophysical Observation", "SAO 77958"},
        {"Wilson Evans Batten Catalogue", "WEB 5661"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.59349085),
        dec: Angle.Degrees(+29.51242509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87667"},
        {"Hipparcos Number", "HIP 49565"},
        {"Geneva Identification System", "GEN# +1.00087667"},
        {"Smithsonian Astrophysical Observation", "SAO 81186"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78487778),
        dec: Angle.Degrees(+29.51265995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188754"},
        {"Hipparcos Number", "HIP 98053"},
        {"Geneva Identification System", "GEN# +1.00188754"},
        {"Smithsonian Astrophysical Observation", "SAO 87938"},
        {"Wilson Evans Batten Catalogue", "WEB 17272"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.89437955),
        dec: Angle.Degrees(+29.51497269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64388"},
        {"Geneva Identification System", "GEN# +0.03002376"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.95932409),
        dec: Angle.Degrees(+29.51517462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93015"},
        {"Hipparcos Number", "HIP 52569"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.22779387),
        dec: Angle.Degrees(+29.51533935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53256"},
        {"Hipparcos Number", "HIP 34203"},
        {"Smithsonian Astrophysical Observation", "SAO 79043"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38768428),
        dec: Angle.Degrees(+29.51620563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52941"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.40114261),
        dec: Angle.Degrees(+29.51627057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65043"},
        {"Hipparcos Number", "HIP 38921"},
        {"Smithsonian Astrophysical Observation", "SAO 79824"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47467378),
        dec: Angle.Degrees(+29.51684460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281331"},
        {"Hipparcos Number", "HIP 18130"},
        {"Smithsonian Astrophysical Observation", "SAO 76289"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.14888477),
        dec: Angle.Degrees(+29.51786911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50245"},
        {"Hipparcos Number", "HIP 33098"},
        {"Smithsonian Astrophysical Observation", "SAO 78835"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.40796525),
        dec: Angle.Degrees(+29.51793456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39208"},
        {"Hipparcos Number", "HIP 27726"},
        {"Smithsonian Astrophysical Observation", "SAO 77650"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.06592212),
        dec: Angle.Degrees(+29.51803369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
