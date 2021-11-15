using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_68() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98830"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.04711388),
        dec: Angle.Degrees(+08.08585936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123497"},
        {"Hipparcos Number", "HIP 69033"},
        {"Smithsonian Astrophysical Observation", "SAO 120299"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.97389389),
        dec: Angle.Degrees(+08.08792875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171683"},
        {"Hipparcos Number", "HIP 91161"},
        {"Smithsonian Astrophysical Observation", "SAO 123679"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97645811),
        dec: Angle.Degrees(+08.08812558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176467"},
        {"Hipparcos Number", "HIP 93290"},
        {"Smithsonian Astrophysical Observation", "SAO 124139"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.01930317),
        dec: Angle.Degrees(+08.09177215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12640"},
        {"Hipparcos Number", "HIP 9647"},
        {"Geneva Identification System", "GEN# +1.00012640"},
        {"Smithsonian Astrophysical Observation", "SAO 110316"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.00049159),
        dec: Angle.Degrees(+08.09497613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144426"},
        {"Hipparcos Number", "HIP 78840"},
        {"Geneva Identification System", "GEN# +1.00144426"},
        {"Renson", "Renson 40950"},
        {"Smithsonian Astrophysical Observation", "SAO 121361"},
        {"Wilson Evans Batten Catalogue", "WEB 13327"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.40805867),
        dec: Angle.Degrees(+08.09624575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180083"},
        {"Hipparcos Number", "HIP 94572"},
        {"Geneva Identification System", "GEN# +1.00180083"},
        {"Smithsonian Astrophysical Observation", "SAO 124433"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70316888),
        dec: Angle.Degrees(+08.09639362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177307"},
        {"Hipparcos Number", "HIP 93613"},
        {"Smithsonian Astrophysical Observation", "SAO 124214"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.95312296),
        dec: Angle.Degrees(+08.09765736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111660"},
        {"Hipparcos Number", "HIP 62697"},
        {"Geneva Identification System", "GEN# +1.00111660"},
        {"Smithsonian Astrophysical Observation", "SAO 119623"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.70693504),
        dec: Angle.Degrees(+08.09920720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106177"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59211410),
        dec: Angle.Degrees(+08.09963346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169957"},
        {"Hipparcos Number", "HIP 90404"},
        {"Geneva Identification System", "GEN# +1.00169957"},
        {"Smithsonian Astrophysical Observation", "SAO 123488"},
        {"Wilson Evans Batten Catalogue", "WEB 15482"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.69560049),
        dec: Angle.Degrees(+08.10216000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159333"},
        {"Hipparcos Number", "HIP 85940"},
        {"Geneva Identification System", "GEN# +1.00159333"},
        {"Smithsonian Astrophysical Observation", "SAO 122512"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.47010571),
        dec: Angle.Degrees(+08.10391592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34471"},
        {"Hipparcos Number", "HIP 24703"},
        {"Smithsonian Astrophysical Observation", "SAO 112604"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.48774068),
        dec: Angle.Degrees(+08.10471410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39186"},
        {"Hipparcos Number", "HIP 27644"},
        {"Smithsonian Astrophysical Observation", "SAO 113203"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.77957378),
        dec: Angle.Degrees(+08.10724106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96398"},
        {"Hipparcos Number", "HIP 54330"},
        {"Smithsonian Astrophysical Observation", "SAO 118666"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.71569525),
        dec: Angle.Degrees(+08.10798327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202201"},
        {"Hipparcos Number", "HIP 104818"},
        {"Smithsonian Astrophysical Observation", "SAO 126635"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.53496141),
        dec: Angle.Degrees(+08.10866269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48412",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7552 AB"},
        {"Henry Draper", "HD 85474"},
        {"Hipparcos Number", "HIP 48412"},
        {"Smithsonian Astrophysical Observation", "SAO 117957"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.04925032),
        dec: Angle.Degrees(+08.11256885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14334",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2332 AB"},
        {"Hipparcos Number", "HIP 14334"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20927629),
        dec: Angle.Degrees(+08.11357797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1286",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 211 A"},
        {"Henry Draper", "HD 1169"},
        {"Hipparcos Number", "HIP 1286"},
        {"Renson", "Renson 230"},
        {"Smithsonian Astrophysical Observation", "SAO 109096"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.02245158),
        dec: Angle.Degrees(+08.11560380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19846"},
        {"Hipparcos Number", "HIP 14842"},
        {"Geneva Identification System", "GEN# +1.00019846"},
        {"Smithsonian Astrophysical Observation", "SAO 111039"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.92513724),
        dec: Angle.Degrees(+08.11873932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10114"},
        {"Hipparcos Number", "HIP 7686"},
        {"Smithsonian Astrophysical Observation", "SAO 110029"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.73831911),
        dec: Angle.Degrees(+08.11931186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12129 A"},
        {"Henry Draper", "HD 179123"},
        {"Hipparcos Number", "HIP 94230"},
        {"Geneva Identification System", "GEN# +1.00179123"},
        {"Smithsonian Astrophysical Observation", "SAO 124355"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.73733472),
        dec: Angle.Degrees(+08.12159716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38040"},
        {"Smithsonian Astrophysical Observation", "SAO 115941"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.94974625),
        dec: Angle.Degrees(+08.12588357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85270"},
        {"Hipparcos Number", "HIP 48309"},
        {"Geneva Identification System", "GEN# +1.00085270"},
        {"Smithsonian Astrophysical Observation", "SAO 117942"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.72960857),
        dec: Angle.Degrees(+08.12731639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107867"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.81251225),
        dec: Angle.Degrees(+08.12883899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221500"},
        {"Hipparcos Number", "HIP 116202"},
        {"Smithsonian Astrophysical Observation", "SAO 128236"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.16345169),
        dec: Angle.Degrees(+08.12992936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31798"},
        {"Hipparcos Number", "HIP 23165"},
        {"Geneva Identification System", "GEN# +1.00031798"},
        {"Wilson Evans Batten Catalogue", "WEB 4493"},
    },
    visualMagnitude: 10.24,
    bvColour: 3.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.75232376),
        dec: Angle.Degrees(+08.13048415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122743"},
        {"Hipparcos Number", "HIP 68686"},
        {"Smithsonian Astrophysical Observation", "SAO 120260"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90138531),
        dec: Angle.Degrees(+08.13050342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101153"},
        {"Hipparcos Number", "HIP 56779"},
        {"Fundamental Katalog 5th Edition", "FK5 2932"},
        {"Geneva Identification System", "GEN# +1.00101153"},
        {"Smithsonian Astrophysical Observation", "SAO 118965"},
        {"Wilson Evans Batten Catalogue", "WEB 10219"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.61504009),
        dec: Angle.Degrees(+08.13428325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144169"},
        {"Hipparcos Number", "HIP 78718"},
        {"Smithsonian Astrophysical Observation", "SAO 121346"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.04703114),
        dec: Angle.Degrees(+08.13756512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18174"},
        {"Hipparcos Number", "HIP 13603"},
        {"Smithsonian Astrophysical Observation", "SAO 110837"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.82604826),
        dec: Angle.Degrees(+08.13761928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25464"},
        {"Hipparcos Number", "HIP 18887"},
        {"Geneva Identification System", "GEN# +1.00025464"},
        {"Smithsonian Astrophysical Observation", "SAO 111576"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74133022),
        dec: Angle.Degrees(+08.14008450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45027"},
        {"Hipparcos Number", "HIP 30563"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.36647194),
        dec: Angle.Degrees(+08.14074084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66432"},
        {"Smithsonian Astrophysical Observation", "SAO 120034"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.29004323),
        dec: Angle.Degrees(+08.14463943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68318"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.78200755),
        dec: Angle.Degrees(+08.15142468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89759"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76187920),
        dec: Angle.Degrees(+08.15338456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14096"},
        {"Smithsonian Astrophysical Observation", "SAO 110914"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.45777025),
        dec: Angle.Degrees(+08.15376155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186142"},
        {"Hipparcos Number", "HIP 96943"},
        {"Geneva Identification System", "GEN# +1.00186142"},
        {"Smithsonian Astrophysical Observation", "SAO 124959"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.61348048),
        dec: Angle.Degrees(+08.15470792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28284"},
        {"Hipparcos Number", "HIP 20852"},
        {"Smithsonian Astrophysical Observation", "SAO 111838"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.02223132),
        dec: Angle.Degrees(+08.15482059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85155"},
        {"Smithsonian Astrophysical Observation", "SAO 122348"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.01926995),
        dec: Angle.Degrees(+08.15768653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51505"},
        {"Hipparcos Number", "HIP 33512"},
        {"Smithsonian Astrophysical Observation", "SAO 114688"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.48957262),
        dec: Angle.Degrees(+08.15877503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53597"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.48302782),
        dec: Angle.Degrees(+08.15900654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130005"},
        {"Hipparcos Number", "HIP 72162"},
        {"Smithsonian Astrophysical Observation", "SAO 120643"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.40055845),
        dec: Angle.Degrees(+08.15978832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129312"},
        {"Hipparcos Number", "HIP 71832"},
        {"Fundamental Katalog 5th Edition", "FK5 3163"},
        {"Geneva Identification System", "GEN# +1.00129312"},
        {"Smithsonian Astrophysical Observation", "SAO 120601"},
        {"Wilson Evans Batten Catalogue", "WEB 12372"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.41148550),
        dec: Angle.Degrees(+08.16175611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246803"},
        {"Hipparcos Number", "HIP 26954"},
        {"Smithsonian Astrophysical Observation", "SAO 113071"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.79695098),
        dec: Angle.Degrees(+08.16285010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103106"},
    },
    visualMagnitude: 12.25,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35679319),
        dec: Angle.Degrees(+08.16448399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106909"},
        {"Smithsonian Astrophysical Observation", "SAO 126962"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.78057284),
        dec: Angle.Degrees(+08.16477019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159356"},
        {"Hipparcos Number", "HIP 85944"},
        {"Geneva Identification System", "GEN# +1.00159356"},
        {"Smithsonian Astrophysical Observation", "SAO 122513"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.48357006),
        dec: Angle.Degrees(+08.16620124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54100"},
        {"Geneva Identification System", "GEN# +0.00802453"},
        {"Smithsonian Astrophysical Observation", "SAO 118643"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.05608671),
        dec: Angle.Degrees(+08.16805923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -302.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151955"},
        {"Hipparcos Number", "HIP 82400"},
        {"Geneva Identification System", "GEN# +1.00151955"},
        {"Smithsonian Astrophysical Observation", "SAO 121894"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.56827768),
        dec: Angle.Degrees(+08.16856513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74632"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.73774713),
        dec: Angle.Degrees(+08.17295019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3737 A"},
        {"Henry Draper", "HD 33340"},
        {"Hipparcos Number", "HIP 24031"},
        {"Smithsonian Astrophysical Observation", "SAO 112481"},
        {"Wilson Evans Batten Catalogue", "WEB 4685"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.49276424),
        dec: Angle.Degrees(+08.17341192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46862"},
        {"Smithsonian Astrophysical Observation", "SAO 117764"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23912324),
        dec: Angle.Degrees(+08.17373970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91844"},
        {"Hipparcos Number", "HIP 51922"},
        {"Smithsonian Astrophysical Observation", "SAO 118394"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09848972),
        dec: Angle.Degrees(+08.17399915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212489"},
        {"Hipparcos Number", "HIP 110613"},
        {"Smithsonian Astrophysical Observation", "SAO 127510"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.13891183),
        dec: Angle.Degrees(+08.17494731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29441"},
        {"Hipparcos Number", "HIP 21626"},
        {"Geneva Identification System", "GEN# +1.00029441"},
        {"Smithsonian Astrophysical Observation", "SAO 111944"},
        {"Wilson Evans Batten Catalogue", "WEB 4156"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.65100206),
        dec: Angle.Degrees(+08.17519280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105652"},
        {"Hipparcos Number", "HIP 59289"},
        {"Smithsonian Astrophysical Observation", "SAO 119247"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.44289323),
        dec: Angle.Degrees(+08.17904637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11338"},
    },
    visualMagnitude: 12.25,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.46885288),
        dec: Angle.Degrees(+08.18048087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14279"},
        {"Hipparcos Number", "HIP 10776"},
        {"Smithsonian Astrophysical Observation", "SAO 110464"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.67315658),
        dec: Angle.Degrees(+08.18069600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63516"},
        {"Hipparcos Number", "HIP 38213"},
        {"Geneva Identification System", "GEN# +1.00063516"},
        {"Smithsonian Astrophysical Observation", "SAO 115983"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.42357209),
        dec: Angle.Degrees(+08.18115699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73281"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.65443594),
        dec: Angle.Degrees(+08.18136289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80424"},
        {"Hipparcos Number", "HIP 45772"},
        {"Smithsonian Astrophysical Observation", "SAO 117594"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99546890),
        dec: Angle.Degrees(+08.18171703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19756"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.52952929),
        dec: Angle.Degrees(+08.18284936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103185"},
        {"Geneva Identification System", "GEN# +6.20156499"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.58440120),
        dec: Angle.Degrees(+08.18564201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211976"},
        {"Hipparcos Number", "HIP 110341"},
        {"Geneva Identification System", "GEN# +1.00211976"},
        {"Smithsonian Astrophysical Observation", "SAO 127460"},
        {"Wilson Evans Batten Catalogue", "WEB 19789"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.23238665),
        dec: Angle.Degrees(+08.18668942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28993"},
        {"Hipparcos Number", "HIP 21304"},
        {"Smithsonian Astrophysical Observation", "SAO 111899"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.59322322),
        dec: Angle.Degrees(+08.18719157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82819"},
        {"Hipparcos Number", "HIP 46994"},
        {"Fundamental Katalog 5th Edition", "FK5 4850"},
        {"Geneva Identification System", "GEN# +1.00082819"},
        {"Smithsonian Astrophysical Observation", "SAO 117777"},
        {"Wilson Evans Batten Catalogue", "WEB 8857"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.67273871),
        dec: Angle.Degrees(+08.18745947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46457",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7391 A"},
        {"Henry Draper", "HD 81873"},
        {"Hipparcos Number", "HIP 46457"},
        {"Fundamental Katalog 5th Edition", "FK5 2752"},
        {"Geneva Identification System", "GEN# +1.00081873A"},
        {"Smithsonian Astrophysical Observation", "SAO 117718"},
        {"Wilson Evans Batten Catalogue", "WEB 8773"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.12164079),
        dec: Angle.Degrees(+08.18837326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223291"},
        {"Hipparcos Number", "HIP 117401"},
        {"Smithsonian Astrophysical Observation", "SAO 128390"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.07735241),
        dec: Angle.Degrees(+08.18874062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8431"},
        {"Hipparcos Number", "HIP 6513"},
        {"Smithsonian Astrophysical Observation", "SAO 109853"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.91746900),
        dec: Angle.Degrees(+08.18932849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181303"},
        {"Hipparcos Number", "HIP 94983"},
        {"Smithsonian Astrophysical Observation", "SAO 124509"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91381022),
        dec: Angle.Degrees(+08.18984986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1635"},
        {"Hipparcos Number", "HIP 1645"},
        {"Fundamental Katalog 5th Edition", "FK5 1008"},
        {"Geneva Identification System", "GEN# +1.00001635"},
        {"Smithsonian Astrophysical Observation", "SAO 109152"},
        {"Wilson Evans Batten Catalogue", "WEB 300"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.14943435),
        dec: Angle.Degrees(+08.19024803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25951"},
        {"Hipparcos Number", "HIP 19200"},
        {"Smithsonian Astrophysical Observation", "SAO 111608"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.72706046),
        dec: Angle.Degrees(+08.19178719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20986"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.51261770),
        dec: Angle.Degrees(+08.19227092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98968"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.39905823),
        dec: Angle.Degrees(+08.19350644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 931"},
        {"Hipparcos Number", "HIP 1103"},
        {"Geneva Identification System", "GEN# +1.00000931"},
        {"Smithsonian Astrophysical Observation", "SAO 109077"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.44015009),
        dec: Angle.Degrees(+08.19351658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7909"},
        {"Smithsonian Astrophysical Observation", "SAO 110067"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.41487401),
        dec: Angle.Degrees(+08.19526171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161301"},
        {"Hipparcos Number", "HIP 86821"},
        {"Smithsonian Astrophysical Observation", "SAO 122689"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.10631446),
        dec: Angle.Degrees(+08.19557964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204445"},
        {"Hipparcos Number", "HIP 106021"},
        {"Fundamental Katalog 5th Edition", "FK5 1564"},
        {"Geneva Identification System", "GEN# +1.00204445"},
        {"Smithsonian Astrophysical Observation", "SAO 126818"},
        {"Wilson Evans Batten Catalogue", "WEB 19217"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.10347396),
        dec: Angle.Degrees(+08.19571132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80785"},
        {"Smithsonian Astrophysical Observation", "SAO 121644"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.43485456),
        dec: Angle.Degrees(+08.19617692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25570"},
        {"Hipparcos Number", "HIP 18975"},
        {"Geneva Identification System", "GEN# +5.20250160"},
        {"Smithsonian Astrophysical Observation", "SAO 111586"},
        {"Wilson Evans Batten Catalogue", "WEB 3649"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.98543787),
        dec: Angle.Degrees(+08.19720135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64650"},
        {"Geneva Identification System", "GEN# +0.00802688"},
        {"Smithsonian Astrophysical Observation", "SAO 119830"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.78896016),
        dec: Angle.Degrees(+08.19882293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66776"},
        {"Hipparcos Number", "HIP 39590"},
        {"Smithsonian Astrophysical Observation", "SAO 116322"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.35232872),
        dec: Angle.Degrees(+08.19965744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16596"},
        {"Hipparcos Number", "HIP 12407"},
        {"Smithsonian Astrophysical Observation", "SAO 110667"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94063422),
        dec: Angle.Degrees(+08.20297247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32551"},
        {"Hipparcos Number", "HIP 23588"},
        {"Geneva Identification System", "GEN# +1.00032551"},
        {"Smithsonian Astrophysical Observation", "SAO 112381"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.08894164),
        dec: Angle.Degrees(+08.20516787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130291"},
        {"Hipparcos Number", "HIP 72297"},
        {"Smithsonian Astrophysical Observation", "SAO 120660"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77225415),
        dec: Angle.Degrees(+08.20865716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9496"},
        {"Hipparcos Number", "HIP 7243"},
        {"Smithsonian Astrophysical Observation", "SAO 109964"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.32611246),
        dec: Angle.Degrees(+08.20881472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57139"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.73932344),
        dec: Angle.Degrees(+08.20894194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -353.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112737"},
        {"Hipparcos Number", "HIP 63344"},
        {"Geneva Identification System", "GEN# +1.00112737"},
        {"Smithsonian Astrophysical Observation", "SAO 119690"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70174040),
        dec: Angle.Degrees(+08.21012441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111733"},
        {"Hipparcos Number", "HIP 62741"},
        {"Geneva Identification System", "GEN# +1.00111733"},
        {"Smithsonian Astrophysical Observation", "SAO 119631"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.83446416),
        dec: Angle.Degrees(+08.21043443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4503"},
        {"Smithsonian Astrophysical Observation", "SAO 109555"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.42228980),
        dec: Angle.Degrees(+08.21044700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200033"},
        {"Hipparcos Number", "HIP 103686"},
        {"Smithsonian Astrophysical Observation", "SAO 126458"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.16432722),
        dec: Angle.Degrees(+08.21126422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203207"},
        {"Hipparcos Number", "HIP 105375"},
        {"Smithsonian Astrophysical Observation", "SAO 126715"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.15549095),
        dec: Angle.Degrees(+08.21169901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80744"},
        {"Hipparcos Number", "HIP 45912"},
        {"Smithsonian Astrophysical Observation", "SAO 117620"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.42545569),
        dec: Angle.Degrees(+08.21170010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94194"},
        {"Hipparcos Number", "HIP 53148"},
        {"Geneva Identification System", "GEN# +1.00094194"},
        {"Smithsonian Astrophysical Observation", "SAO 118552"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.10608820),
        dec: Angle.Degrees(+08.21381439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152844"},
        {"Hipparcos Number", "HIP 82828"},
        {"Smithsonian Astrophysical Observation", "SAO 121943"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89522831),
        dec: Angle.Degrees(+08.21450811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160849"},
        {"Hipparcos Number", "HIP 86604"},
        {"Smithsonian Astrophysical Observation", "SAO 122651"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.46299897),
        dec: Angle.Degrees(+08.21844370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109095"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.48804757),
        dec: Angle.Degrees(+08.21903517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41853"},
        {"Hipparcos Number", "HIP 29063"},
        {"Geneva Identification System", "GEN# +1.00041853"},
        {"Smithsonian Astrophysical Observation", "SAO 113482"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.96781348),
        dec: Angle.Degrees(+08.22027251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93654"},
        {"Hipparcos Number", "HIP 52871"},
        {"Smithsonian Astrophysical Observation", "SAO 118511"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.18356723),
        dec: Angle.Degrees(+08.22073478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41307"},
        {"Hipparcos Number", "HIP 28784"},
        {"Smithsonian Astrophysical Observation", "SAO 113422"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.15999682),
        dec: Angle.Degrees(+08.22127725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131209"},
        {"Hipparcos Number", "HIP 72715"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.00183262),
        dec: Angle.Degrees(+08.22182550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224155"},
        {"Hipparcos Number", "HIP 117962"},
        {"Geneva Identification System", "GEN# +1.00224155"},
        {"Smithsonian Astrophysical Observation", "SAO 128472"},
        {"Wilson Evans Batten Catalogue", "WEB 20745"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.90709245),
        dec: Angle.Degrees(+08.22329782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76814"},
        {"Hipparcos Number", "HIP 44079"},
        {"Smithsonian Astrophysical Observation", "SAO 117316"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.68952212),
        dec: Angle.Degrees(+08.22375537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65542"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53819957),
        dec: Angle.Degrees(+08.22414830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115393"},
        {"Smithsonian Astrophysical Observation", "SAO 128146"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.63048759),
        dec: Angle.Degrees(+08.22523043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3326"},
        {"Henry Draper", "HD 29196"},
        {"Hipparcos Number", "HIP 21434"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.03891444),
        dec: Angle.Degrees(+08.22578290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166844"},
        {"Hipparcos Number", "HIP 89195"},
        {"Smithsonian Astrophysical Observation", "SAO 123239"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.04297873),
        dec: Angle.Degrees(+08.22716847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87143"},
        {"Hipparcos Number", "HIP 49256"},
        {"Geneva Identification System", "GEN# +1.00087143"},
        {"Smithsonian Astrophysical Observation", "SAO 118077"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.82382571),
        dec: Angle.Degrees(+08.22795397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184297"},
        {"Hipparcos Number", "HIP 96187"},
        {"Smithsonian Astrophysical Observation", "SAO 124787"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.36779666),
        dec: Angle.Degrees(+08.22921412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164139"},
        {"Hipparcos Number", "HIP 88084"},
        {"Smithsonian Astrophysical Observation", "SAO 122989"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.85948051),
        dec: Angle.Degrees(+08.22975382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144085"},
        {"Hipparcos Number", "HIP 78693"},
        {"Geneva Identification System", "GEN# +1.00144085"},
        {"Smithsonian Astrophysical Observation", "SAO 121341"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.96047892),
        dec: Angle.Degrees(+08.22979509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177940"},
        {"Hipparcos Number", "HIP 93820"},
        {"Geneva Identification System", "GEN# +1.00177940"},
        {"Smithsonian Astrophysical Observation", "SAO 124266"},
        {"Wilson Evans Batten Catalogue", "WEB 16316"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.59270472),
        dec: Angle.Degrees(+08.23016469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222941"},
        {"Hipparcos Number", "HIP 117164"},
        {"Geneva Identification System", "GEN# +1.00222941"},
        {"Smithsonian Astrophysical Observation", "SAO 128362"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.30782460),
        dec: Angle.Degrees(+08.23085978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104443"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.35162680),
        dec: Angle.Degrees(+08.23087391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202699"},
        {"Hipparcos Number", "HIP 105104"},
        {"Geneva Identification System", "GEN# +1.00202699"},
        {"Smithsonian Astrophysical Observation", "SAO 126685"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.35528850),
        dec: Angle.Degrees(+08.23407848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222941B"},
        {"Hipparcos Number", "HIP 117163"},
    },
    visualMagnitude: 11.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.30190113),
        dec: Angle.Degrees(+08.23527111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45234"},
        {"Smithsonian Astrophysical Observation", "SAO 117502"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.28062600),
        dec: Angle.Degrees(+08.23693483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80117"},
        {"Hipparcos Number", "HIP 45634"},
        {"Geneva Identification System", "GEN# +1.00080117"},
        {"Smithsonian Astrophysical Observation", "SAO 117578"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.53197433),
        dec: Angle.Degrees(+08.23916322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1227"},
        {"Hipparcos Number", "HIP 1319"},
        {"Fundamental Katalog 5th Edition", "FK5 2015"},
        {"Geneva Identification System", "GEN# +1.00001227"},
        {"Smithsonian Astrophysical Observation", "SAO 109100"},
        {"Wilson Evans Batten Catalogue", "WEB 233"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.14190528),
        dec: Angle.Degrees(+08.24018997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16707"},
        {"Hipparcos Number", "HIP 12505"},
        {"Geneva Identification System", "GEN# +1.00016707"},
        {"Smithsonian Astrophysical Observation", "SAO 110678"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.22695285),
        dec: Angle.Degrees(+08.24027122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101644"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.05995946),
        dec: Angle.Degrees(+08.24325207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66473"},
        {"Smithsonian Astrophysical Observation", "SAO 120041"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.41957628),
        dec: Angle.Degrees(+08.24347003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126200"},
        {"Hipparcos Number", "HIP 70384"},
        {"Geneva Identification System", "GEN# +1.00126200"},
        {"Smithsonian Astrophysical Observation", "SAO 120433"},
        {"Wilson Evans Batten Catalogue", "WEB 12214"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.00366765),
        dec: Angle.Degrees(+08.24400431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115982"},
        {"Hipparcos Number", "HIP 65105"},
        {"Smithsonian Astrophysical Observation", "SAO 119887"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.13711013),
        dec: Angle.Degrees(+08.24505748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135149"},
        {"Hipparcos Number", "HIP 74494"},
        {"Smithsonian Astrophysical Observation", "SAO 120900"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.33086095),
        dec: Angle.Degrees(+08.24513991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89112"},
        {"Hipparcos Number", "HIP 50353"},
        {"Smithsonian Astrophysical Observation", "SAO 118196"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23165274),
        dec: Angle.Degrees(+08.24522053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223277"},
        {"Hipparcos Number", "HIP 117394"},
        {"Geneva Identification System", "GEN# +1.00223277"},
        {"Smithsonian Astrophysical Observation", "SAO 128388"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.05045624),
        dec: Angle.Degrees(+08.24566002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102510"},
        {"Hipparcos Number", "HIP 57562"},
        {"Geneva Identification System", "GEN# +1.00102510"},
        {"Smithsonian Astrophysical Observation", "SAO 119058"},
        {"Wilson Evans Batten Catalogue", "WEB 10336"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.97888233),
        dec: Angle.Degrees(+08.24586534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12872"},
        {"Hipparcos Number", "HIP 9809"},
        {"Geneva Identification System", "GEN# +1.00012872"},
        {"Smithsonian Astrophysical Observation", "SAO 110337"},
        {"Wilson Evans Batten Catalogue", "WEB 2061"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.55113149),
        dec: Angle.Degrees(+08.24814235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53173"},
        {"Hipparcos Number", "HIP 34121"},
        {"Smithsonian Astrophysical Observation", "SAO 114869"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.12802820),
        dec: Angle.Degrees(+08.24852551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102472"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.48300225),
        dec: Angle.Degrees(+08.24960449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53053"},
        {"Hipparcos Number", "HIP 34076"},
        {"Geneva Identification System", "GEN# +1.00053053"},
        {"Smithsonian Astrophysical Observation", "SAO 114857"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00650641),
        dec: Angle.Degrees(+08.24990656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9063"},
        {"Smithsonian Astrophysical Observation", "SAO 110240"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.17091879),
        dec: Angle.Degrees(+08.25380136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42669"},
        {"Smithsonian Astrophysical Observation", "SAO 117032"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.44859410),
        dec: Angle.Degrees(+08.25463251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35623"},
        {"Hipparcos Number", "HIP 25445"},
        {"Smithsonian Astrophysical Observation", "SAO 112764"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.63406690),
        dec: Angle.Degrees(+08.25532939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188777"},
        {"Hipparcos Number", "HIP 98124"},
        {"Geneva Identification System", "GEN# +1.00188777"},
        {"Smithsonian Astrophysical Observation", "SAO 125255"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.14012967),
        dec: Angle.Degrees(+08.25595455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195021"},
        {"Hipparcos Number", "HIP 100995"},
        {"Smithsonian Astrophysical Observation", "SAO 125849"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.14510534),
        dec: Angle.Degrees(+08.25663591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209167"},
        {"Hipparcos Number", "HIP 108699"},
        {"Geneva Identification System", "GEN# +1.00209167"},
        {"Smithsonian Astrophysical Observation", "SAO 127239"},
        {"Wilson Evans Batten Catalogue", "WEB 19561"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.28849736),
        dec: Angle.Degrees(+08.25717124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102124"},
        {"Hipparcos Number", "HIP 57328"},
        {"Geneva Identification System", "GEN# +1.00102124"},
        {"Smithsonian Astrophysical Observation", "SAO 119029"},
        {"Wilson Evans Batten Catalogue", "WEB 10303"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.32085333),
        dec: Angle.Degrees(+08.25817475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 247"},
        {"Smithsonian Astrophysical Observation", "SAO 108988"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.76552823),
        dec: Angle.Degrees(+08.26141340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207565"},
        {"Hipparcos Number", "HIP 107754"},
        {"Smithsonian Astrophysical Observation", "SAO 127098"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.43820145),
        dec: Angle.Degrees(+08.26612466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11448 A"},
        {"Henry Draper", "HD 171247"},
        {"Hipparcos Number", "HIP 90971"},
        {"Geneva Identification System", "GEN# +1.00171247A"},
        {"Renson", "Renson 47950"},
        {"Smithsonian Astrophysical Observation", "SAO 123634"},
        {"Wilson Evans Batten Catalogue", "WEB 15604"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.34709587),
        dec: Angle.Degrees(+08.26827334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31408"},
        {"Geneva Identification System", "GEN# +2.22510005"},
        {"New General Catalogue", "NGC 2251 5"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.74688084),
        dec: Angle.Degrees(+08.26886291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158934"},
        {"Hipparcos Number", "HIP 85779"},
        {"Fundamental Katalog 5th Edition", "FK5 5542"},
        {"Geneva Identification System", "GEN# +1.00158934"},
        {"Smithsonian Astrophysical Observation", "SAO 122473"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.92176151),
        dec: Angle.Degrees(+08.26907176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162138"},
        {"Hipparcos Number", "HIP 87219"},
        {"Smithsonian Astrophysical Observation", "SAO 122784"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.28305514),
        dec: Angle.Degrees(+08.26907328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101386"},
        {"Smithsonian Astrophysical Observation", "SAO 125931"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21856436),
        dec: Angle.Degrees(+08.26911129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66472"},
        {"Hipparcos Number", "HIP 39469"},
        {"Geneva Identification System", "GEN# +1.00066472"},
        {"Smithsonian Astrophysical Observation", "SAO 116291"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.00611658),
        dec: Angle.Degrees(+08.26964680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21249"},
        {"Hipparcos Number", "HIP 15993"},
        {"Smithsonian Astrophysical Observation", "SAO 111184"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.50565899),
        dec: Angle.Degrees(+08.27000356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41791"},
        {"Hipparcos Number", "HIP 29027"},
        {"Celescope Catalog", "CEL 1084"},
        {"Geneva Identification System", "GEN# +1.00041791"},
        {"Smithsonian Astrophysical Observation", "SAO 113473"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.86395180),
        dec: Angle.Degrees(+08.27056829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62411"},
    },
    visualMagnitude: 11.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.85587248),
        dec: Angle.Degrees(+08.27077644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225057"},
        {"Hipparcos Number", "HIP 248"},
        {"Smithsonian Astrophysical Observation", "SAO 108989"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.76575139),
        dec: Angle.Degrees(+08.27080462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102015"},
        {"Hipparcos Number", "HIP 57258"},
        {"Smithsonian Astrophysical Observation", "SAO 119017"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.12740799),
        dec: Angle.Degrees(+08.27099883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45851"},
        {"Smithsonian Astrophysical Observation", "SAO 117607"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.22080100),
        dec: Angle.Degrees(+08.27187439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214140"},
        {"Hipparcos Number", "HIP 111572"},
        {"Smithsonian Astrophysical Observation", "SAO 127628"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.04142402),
        dec: Angle.Degrees(+08.27253185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62303"},
        {"Hipparcos Number", "HIP 37657"},
        {"Smithsonian Astrophysical Observation", "SAO 115854"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.90813686),
        dec: Angle.Degrees(+08.27308155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75406"},
        {"Hipparcos Number", "HIP 43369"},
        {"Geneva Identification System", "GEN# +1.00075406"},
        {"Smithsonian Astrophysical Observation", "SAO 117178"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.50775398),
        dec: Angle.Degrees(+08.27408768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21987"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.89553173),
        dec: Angle.Degrees(+08.27441239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110335"},
        {"Smithsonian Astrophysical Observation", "SAO 127458"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.21130315),
        dec: Angle.Degrees(+08.27483354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9657"},
        {"Hipparcos Number", "HIP 7366"},
        {"Smithsonian Astrophysical Observation", "SAO 109990"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71904116),
        dec: Angle.Degrees(+08.27487179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187347"},
        {"Hipparcos Number", "HIP 97510"},
        {"Geneva Identification System", "GEN# +1.00187347"},
        {"Smithsonian Astrophysical Observation", "SAO 125096"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.28960142),
        dec: Angle.Degrees(+08.27733189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83647"},
        {"Hipparcos Number", "HIP 47446"},
        {"Geneva Identification System", "GEN# +1.00083647"},
        {"Smithsonian Astrophysical Observation", "SAO 117836"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.04336180),
        dec: Angle.Degrees(+08.27810833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2594"},
        {"Smithsonian Astrophysical Observation", "SAO 109268"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.22530169),
        dec: Angle.Degrees(+08.27983232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35482"},
        {"Smithsonian Astrophysical Observation", "SAO 115260"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.85476066),
        dec: Angle.Degrees(+08.28328165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70063",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9223 B"},
        {"Hipparcos Number", "HIP 70063"},
    },
    visualMagnitude: 11.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.06888900),
        dec: Angle.Degrees(+08.28603141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9223 A"},
        {"Henry Draper", "HD 125590"},
        {"Hipparcos Number", "HIP 70065"},
        {"Smithsonian Astrophysical Observation", "SAO 120405"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.07222881),
        dec: Angle.Degrees(+08.28604708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20718"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.59901017),
        dec: Angle.Degrees(+08.28741817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17761"},
        {"Hipparcos Number", "HIP 13303"},
        {"Smithsonian Astrophysical Observation", "SAO 110785"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.80359448),
        dec: Angle.Degrees(+08.28908481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36188",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gomeisa"},
        {"Henry Draper", "HD 58715"},
        {"Hipparcos Number", "HIP 36188"},
        {"Fundamental Katalog 5th Edition", "FK5 285"},
        {"Geneva Identification System", "GEN# +1.00058715"},
        {"Smithsonian Astrophysical Observation", "SAO 115456"},
        {"Wilson Evans Batten Catalogue", "WEB 7206"},
    },
    visualMagnitude: 2.89,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78780121),
        dec: Angle.Degrees(+08.28940893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118159"},
        {"Hipparcos Number", "HIP 66274"},
        {"Smithsonian Astrophysical Observation", "SAO 120018"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.74775402),
        dec: Angle.Degrees(+08.29038605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22073"},
        {"Hipparcos Number", "HIP 16609"},
        {"Geneva Identification System", "GEN# +1.00022073"},
        {"Smithsonian Astrophysical Observation", "SAO 111260"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.44361547),
        dec: Angle.Degrees(+08.29063306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46416",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7388 AB"},
        {"Henry Draper", "HD 81776"},
        {"Hipparcos Number", "HIP 46416"},
        {"Smithsonian Astrophysical Observation", "SAO 117709"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98209419),
        dec: Angle.Degrees(+08.29267064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118289"},
        {"Hipparcos Number", "HIP 66345"},
        {"Fundamental Katalog 5th Edition", "FK5 5198"},
        {"Geneva Identification System", "GEN# +1.00118289"},
        {"Smithsonian Astrophysical Observation", "SAO 120026"},
        {"Wilson Evans Batten Catalogue", "WEB 11718"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.96701474),
        dec: Angle.Degrees(+08.29276209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100707"},
        {"Smithsonian Astrophysical Observation", "SAO 125779"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.25931749),
        dec: Angle.Degrees(+08.29329294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112503"},
        {"Hipparcos Number", "HIP 63221"},
        {"Fundamental Katalog 5th Edition", "FK5 3035"},
        {"Geneva Identification System", "GEN# +1.00112503J"},
        {"Smithsonian Astrophysical Observation", "SAO 119683"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.30673494),
        dec: Angle.Degrees(+08.29375695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177256"},
        {"Hipparcos Number", "HIP 93578"},
        {"Geneva Identification System", "GEN# +1.00177256"},
        {"Smithsonian Astrophysical Observation", "SAO 124206"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88260996),
        dec: Angle.Degrees(+08.29380220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148979"},
        {"Hipparcos Number", "HIP 80926"},
        {"Geneva Identification System", "GEN# +1.00148979"},
        {"Smithsonian Astrophysical Observation", "SAO 121665"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87750879),
        dec: Angle.Degrees(+08.29392849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6837"},
        {"Hipparcos Number", "HIP 5406"},
        {"Smithsonian Astrophysical Observation", "SAO 109702"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.29630107),
        dec: Angle.Degrees(+08.29623059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148998"},
        {"Hipparcos Number", "HIP 80933"},
        {"Geneva Identification System", "GEN# +1.00148998"},
        {"Smithsonian Astrophysical Observation", "SAO 121666"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.89317520),
        dec: Angle.Degrees(+08.29935505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256577"},
        {"Hipparcos Number", "HIP 30443"},
        {"Celescope Catalog", "CEL 1214"},
        {"Geneva Identification System", "GEN# +1.00256577"},
        {"Smithsonian Astrophysical Observation", "SAO 113814"},
        {"Wilson Evans Batten Catalogue", "WEB 6062"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00074677),
        dec: Angle.Degrees(+08.30069319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84952"},
        {"Hipparcos Number", "HIP 48145"},
        {"Geneva Identification System", "GEN# +1.00084952"},
        {"Smithsonian Astrophysical Observation", "SAO 117923"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.21990094),
        dec: Angle.Degrees(+08.30177506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127519"},
        {"Hipparcos Number", "HIP 71038"},
        {"Smithsonian Astrophysical Observation", "SAO 120513"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92375061),
        dec: Angle.Degrees(+08.30202962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64015"},
        {"Geneva Identification System", "GEN# +0.00902718"},
        {"Smithsonian Astrophysical Observation", "SAO 119771"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.75411377),
        dec: Angle.Degrees(+08.30390009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181754"},
        {"Hipparcos Number", "HIP 95144"},
        {"Smithsonian Astrophysical Observation", "SAO 124542"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.35633897),
        dec: Angle.Degrees(+08.30768845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4464"},
        {"Hipparcos Number", "HIP 3666"},
        {"Smithsonian Astrophysical Observation", "SAO 109457"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.72354686),
        dec: Angle.Degrees(+08.30795858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57124"},
        {"Smithsonian Astrophysical Observation", "SAO 119007"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.67932557),
        dec: Angle.Degrees(+08.31246787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222243"},
        {"Hipparcos Number", "HIP 116694"},
        {"Smithsonian Astrophysical Observation", "SAO 128301"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.71825058),
        dec: Angle.Degrees(+08.31290020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86369"},
        {"Hipparcos Number", "HIP 48876"},
        {"Geneva Identification System", "GEN# +1.00086369"},
        {"Smithsonian Astrophysical Observation", "SAO 118023"},
        {"Wilson Evans Batten Catalogue", "WEB 9080"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.53175281),
        dec: Angle.Degrees(+08.31404459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90621"},
        {"Hipparcos Number", "HIP 51239"},
        {"Smithsonian Astrophysical Observation", "SAO 118317"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.98520943),
        dec: Angle.Degrees(+08.31437529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71185"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.38585149),
        dec: Angle.Degrees(+08.31608698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30285"},
        {"Hipparcos Number", "HIP 22212"},
        {"Smithsonian Astrophysical Observation", "SAO 112066"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.65112074),
        dec: Angle.Degrees(+08.31796453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59950"},
        {"Hipparcos Number", "HIP 36675"},
        {"Geneva Identification System", "GEN# +1.00059950"},
        {"Smithsonian Astrophysical Observation", "SAO 115591"},
        {"Wilson Evans Batten Catalogue", "WEB 7293"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.17948271),
        dec: Angle.Degrees(+08.31814406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2743 AB"},
        {"Henry Draper", "HD 23376"},
        {"Hipparcos Number", "HIP 17512"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.24547471),
        dec: Angle.Degrees(+08.31963268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39403"},
        {"Smithsonian Astrophysical Observation", "SAO 116281"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.83275394),
        dec: Angle.Degrees(+08.32035511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21027"},
        {"Smithsonian Astrophysical Observation", "SAO 111856"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.63035105),
        dec: Angle.Degrees(+08.32183354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127887"},
        {"Hipparcos Number", "HIP 71201"},
        {"Smithsonian Astrophysical Observation", "SAO 120529"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42440520),
        dec: Angle.Degrees(+08.32197562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4399"},
        {"Smithsonian Astrophysical Observation", "SAO 109539"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.10470563),
        dec: Angle.Degrees(+08.32332158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42258"},
        {"Smithsonian Astrophysical Observation", "SAO 116951"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.26063517),
        dec: Angle.Degrees(+08.32352098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50931"},
        {"Hipparcos Number", "HIP 33297"},
        {"Geneva Identification System", "GEN# +1.00050931"},
        {"Smithsonian Astrophysical Observation", "SAO 114626"},
        {"Wilson Evans Batten Catalogue", "WEB 6694"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.89428792),
        dec: Angle.Degrees(+08.32428996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44498"},
        {"Hipparcos Number", "HIP 30297"},
        {"Celescope Catalog", "CEL 1200"},
        {"Geneva Identification System", "GEN# +1.00044498"},
        {"Smithsonian Astrophysical Observation", "SAO 113777"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.59395478),
        dec: Angle.Degrees(+08.32680529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108820"},
    },
    visualMagnitude: 12.10,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.68737072),
        dec: Angle.Degrees(+08.32860598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78156"},
        {"Hipparcos Number", "HIP 44736"},
        {"Geneva Identification System", "GEN# +1.00078156"},
        {"Smithsonian Astrophysical Observation", "SAO 117430"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.74550289),
        dec: Angle.Degrees(+08.32902063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19313"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.09692770),
        dec: Angle.Degrees(+08.33036696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141491"},
        {"Hipparcos Number", "HIP 77476"},
        {"Smithsonian Astrophysical Observation", "SAO 121204"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.28250533),
        dec: Angle.Degrees(+08.33095293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6432"},
        {"Hipparcos Number", "HIP 5103"},
        {"Geneva Identification System", "GEN# +1.00006432"},
        {"Smithsonian Astrophysical Observation", "SAO 109661"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.35054386),
        dec: Angle.Degrees(+08.33207098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92717"},
        {"Hipparcos Number", "HIP 52387"},
        {"Smithsonian Astrophysical Observation", "SAO 118441"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.62024058),
        dec: Angle.Degrees(+08.33307822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115324"},
    },
    visualMagnitude: 12.42,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.37883525),
        dec: Angle.Degrees(+08.33394706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222462"},
        {"Hipparcos Number", "HIP 116837"},
        {"Smithsonian Astrophysical Observation", "SAO 128323"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.21233488),
        dec: Angle.Degrees(+08.33399504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102606"},
    },
    visualMagnitude: 12.25,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89985023),
        dec: Angle.Degrees(+08.33586852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29411"},
        {"Hipparcos Number", "HIP 21600"},
        {"Wilson Evans Batten Catalogue", "WEB 4146"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.56070548),
        dec: Angle.Degrees(+08.33594684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4887"},
        {"Hipparcos Number", "HIP 3968"},
        {"Smithsonian Astrophysical Observation", "SAO 109501"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.75425648),
        dec: Angle.Degrees(+08.33635729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150191"},
        {"Hipparcos Number", "HIP 81525"},
        {"Smithsonian Astrophysical Observation", "SAO 121759"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.77774171),
        dec: Angle.Degrees(+08.33732225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107889"},
        {"Hipparcos Number", "HIP 60473"},
        {"Geneva Identification System", "GEN# +1.00107889"},
        {"Smithsonian Astrophysical Observation", "SAO 119371"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.96260499),
        dec: Angle.Degrees(+08.34400854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41840"},
        {"Smithsonian Astrophysical Observation", "SAO 116858"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.94574072),
        dec: Angle.Degrees(+08.34602113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41204"},
        {"Smithsonian Astrophysical Observation", "SAO 116722"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.12779040),
        dec: Angle.Degrees(+08.34677618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15379 A"},
        {"Henry Draper", "HD 207772"},
        {"Hipparcos Number", "HIP 107868"},
        {"Geneva Identification System", "GEN# +1.00207772A"},
        {"Smithsonian Astrophysical Observation", "SAO 127111"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.82617620),
        dec: Angle.Degrees(+08.34714189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15685"},
        {"Hipparcos Number", "HIP 11735"},
        {"Smithsonian Astrophysical Observation", "SAO 110588"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.86736079),
        dec: Angle.Degrees(+08.34795910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178162"},
        {"Hipparcos Number", "HIP 93896"},
        {"Geneva Identification System", "GEN# +1.00178162"},
        {"Smithsonian Astrophysical Observation", "SAO 124285"},
        {"Wilson Evans Batten Catalogue", "WEB 16337"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.79677298),
        dec: Angle.Degrees(+08.34904814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49525"},
        {"Hipparcos Number", "HIP 32686"},
        {"Geneva Identification System", "GEN# +1.00049525"},
        {"Smithsonian Astrophysical Observation", "SAO 114463"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.28350617),
        dec: Angle.Degrees(+08.34933690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261490"},
        {"Hipparcos Number", "HIP 31854"},
        {"Geneva Identification System", "GEN# +1.00261490"},
        {"Smithsonian Astrophysical Observation", "SAO 114221"},
        {"Wilson Evans Batten Catalogue", "WEB 6403"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.89291531),
        dec: Angle.Degrees(+08.35038219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196367"},
        {"Hipparcos Number", "HIP 101679"},
        {"Geneva Identification System", "GEN# +1.00196367"},
        {"Smithsonian Astrophysical Observation", "SAO 126011"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.15110610),
        dec: Angle.Degrees(+08.35101691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182784"},
        {"Hipparcos Number", "HIP 95540"},
        {"Smithsonian Astrophysical Observation", "SAO 124620"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.50186907),
        dec: Angle.Degrees(+08.35151853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259954"},
        {"Hipparcos Number", "HIP 31365"},
        {"Geneva Identification System", "GEN# +2.22510001"},
        {"Renson", "Renson 12460"},
        {"Wilson Evans Batten Catalogue", "WEB 6250"},
        {"New General Catalogue", "NGC 2251 1"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.65067353),
        dec: Angle.Degrees(+08.35212795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127247"},
        {"Hipparcos Number", "HIP 70914"},
        {"Geneva Identification System", "GEN# +1.00127247"},
        {"Smithsonian Astrophysical Observation", "SAO 120501"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.53502371),
        dec: Angle.Degrees(+08.35324973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46036"},
        {"Smithsonian Astrophysical Observation", "SAO 117642"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84101991),
        dec: Angle.Degrees(+08.35665650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117115"},
        {"Hipparcos Number", "HIP 65696"},
        {"Geneva Identification System", "GEN# +1.00117115"},
        {"Smithsonian Astrophysical Observation", "SAO 119940"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.03769556),
        dec: Angle.Degrees(+08.35802650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183263"},
        {"Hipparcos Number", "HIP 95740"},
        {"Geneva Identification System", "GEN# +1.00183263"},
        {"Smithsonian Astrophysical Observation", "SAO 124664"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.10242998),
        dec: Angle.Degrees(+08.35813467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6568"},
        {"Hipparcos Number", "HIP 5209"},
        {"Geneva Identification System", "GEN# +1.00006568"},
        {"Smithsonian Astrophysical Observation", "SAO 109677"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.65690295),
        dec: Angle.Degrees(+08.36013248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63039"},
        {"Hipparcos Number", "HIP 37997"},
        {"Smithsonian Astrophysical Observation", "SAO 115927"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.81121851),
        dec: Angle.Degrees(+08.36073761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167808"},
        {"Hipparcos Number", "HIP 89565"},
        {"Smithsonian Astrophysical Observation", "SAO 123317"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.13946940),
        dec: Angle.Degrees(+08.36106922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49015"},
        {"Hipparcos Number", "HIP 32475"},
        {"Geneva Identification System", "GEN# +1.00049015"},
        {"Smithsonian Astrophysical Observation", "SAO 114392"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.66968476),
        dec: Angle.Degrees(+08.36314976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31002"},
        {"Hipparcos Number", "HIP 22685"},
        {"Smithsonian Astrophysical Observation", "SAO 112169"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.17500935),
        dec: Angle.Degrees(+08.36471699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119733"},
        {"Hipparcos Number", "HIP 67079"},
        {"Smithsonian Astrophysical Observation", "SAO 120093"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.22221636),
        dec: Angle.Degrees(+08.36798862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24985"},
        {"Hipparcos Number", "HIP 18566"},
        {"Smithsonian Astrophysical Observation", "SAO 111533"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.62260689),
        dec: Angle.Degrees(+08.36838922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21776"},
        {"Hipparcos Number", "HIP 16372"},
        {"Smithsonian Astrophysical Observation", "SAO 111234"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.72261154),
        dec: Angle.Degrees(+08.36853579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13374"},
        {"Hipparcos Number", "HIP 10171"},
        {"Geneva Identification System", "GEN# +1.00013374"},
        {"Smithsonian Astrophysical Observation", "SAO 110383"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.70557343),
        dec: Angle.Degrees(+08.36872609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141041"},
        {"Hipparcos Number", "HIP 77276"},
        {"Smithsonian Astrophysical Observation", "SAO 121187"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.66361999),
        dec: Angle.Degrees(+08.36982925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176981"},
        {"Hipparcos Number", "HIP 93488"},
        {"Geneva Identification System", "GEN# +1.00176981"},
        {"Smithsonian Astrophysical Observation", "SAO 124184"},
        {"Wilson Evans Batten Catalogue", "WEB 16229"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.58983810),
        dec: Angle.Degrees(+08.37352914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37926"},
        {"Hipparcos Number", "HIP 26867"},
        {"Smithsonian Astrophysical Observation", "SAO 113050"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.56041867),
        dec: Angle.Degrees(+08.37357736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214560"},
        {"Hipparcos Number", "HIP 111812"},
        {"Cincinnati Publication", "Ci 18 2943"},
        {"Geneva Identification System", "GEN# +1.00214560"},
        {"Smithsonian Astrophysical Observation", "SAO 127660"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.72399250),
        dec: Angle.Degrees(+08.37412386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 257.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110024",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15802 AB"},
        {"Henry Draper", "HD 211461"},
        {"Hipparcos Number", "HIP 110024"},
        {"Smithsonian Astrophysical Observation", "SAO 127432"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.27725293),
        dec: Angle.Degrees(+08.37428111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80009"},
        {"Hipparcos Number", "HIP 45589"},
        {"Smithsonian Astrophysical Observation", "SAO 117566"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.37823532),
        dec: Angle.Degrees(+08.37578380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65874"},
        {"Hipparcos Number", "HIP 39212"},
        {"Geneva Identification System", "GEN# +1.00065874"},
        {"Smithsonian Astrophysical Observation", "SAO 116241"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30636257),
        dec: Angle.Degrees(+08.37640899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11564"},
        {"Smithsonian Astrophysical Observation", "SAO 110558"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.24837968),
        dec: Angle.Degrees(+08.37935342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117330"},
        {"Hipparcos Number", "HIP 65817"},
        {"Smithsonian Astrophysical Observation", "SAO 119958"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.39226344),
        dec: Angle.Degrees(+08.37957143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12813 B"},
        {"Hipparcos Number", "HIP 96976"},
        {"Geneva Identification System", "GEN# +1.00186226B"},
        {"Smithsonian Astrophysical Observation", "SAO 124966"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.68385043),
        dec: Angle.Degrees(+08.38024318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61789"},
        {"Hipparcos Number", "HIP 37459"},
        {"Wilson Evans Batten Catalogue", "WEB 7408"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.33346933),
        dec: Angle.Degrees(+08.38030031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50277"},
        {"Hipparcos Number", "HIP 33024"},
        {"Geneva Identification System", "GEN# +1.00050277"},
        {"Smithsonian Astrophysical Observation", "SAO 114556"},
        {"Wilson Evans Batten Catalogue", "WEB 6647"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.20619730),
        dec: Angle.Degrees(+08.38044841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6954"},
        {"Smithsonian Astrophysical Observation", "SAO 109922"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.38039515),
        dec: Angle.Degrees(+08.38061688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126676"},
        {"Hipparcos Number", "HIP 70621"},
        {"Geneva Identification System", "GEN# +1.00126676"},
        {"Smithsonian Astrophysical Observation", "SAO 120465"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.69746892),
        dec: Angle.Degrees(+08.38172529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18262"},
        {"Hipparcos Number", "HIP 13679"},
        {"Geneva Identification System", "GEN# +1.00018262"},
        {"Smithsonian Astrophysical Observation", "SAO 110851"},
        {"Wilson Evans Batten Catalogue", "WEB 2714"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.05720205),
        dec: Angle.Degrees(+08.38177807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11707"},
        {"Geneva Identification System", "GEN# +9.80004024"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.76274694),
        dec: Angle.Degrees(+08.38220250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 375.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12813 A"},
        {"Henry Draper", "HD 186226"},
        {"Hipparcos Number", "HIP 96979"},
        {"Geneva Identification System", "GEN# +1.00186226A"},
        {"Smithsonian Astrophysical Observation", "SAO 124969"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.69108839),
        dec: Angle.Degrees(+08.38263150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221853"},
        {"Hipparcos Number", "HIP 116431"},
        {"Geneva Identification System", "GEN# +1.00221853"},
        {"Smithsonian Astrophysical Observation", "SAO 128272"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.90047713),
        dec: Angle.Degrees(+08.38271778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2508"},
        {"Hipparcos Number", "HIP 2264"},
        {"Smithsonian Astrophysical Observation", "SAO 109227"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.21318266),
        dec: Angle.Degrees(+08.38396024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154477"},
        {"Hipparcos Number", "HIP 83614"},
        {"Smithsonian Astrophysical Observation", "SAO 122062"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34425883),
        dec: Angle.Degrees(+08.38408908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78924"},
        {"Wilson Evans Batten Catalogue", "WEB 13342"},
    },
    visualMagnitude: 11.57,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.67292705),
        dec: Angle.Degrees(+08.38817880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -495.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119288"},
        {"Hipparcos Number", "HIP 66860"},
        {"Cincinnati Publication", "Ci 18 1777"},
        {"Geneva Identification System", "GEN# +1.00119288"},
        {"Smithsonian Astrophysical Observation", "SAO 120075"},
        {"Wilson Evans Batten Catalogue", "WEB 11788"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.55409628),
        dec: Angle.Degrees(+08.38860602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -377.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224090"},
        {"Hipparcos Number", "HIP 117912"},
        {"Smithsonian Astrophysical Observation", "SAO 128463"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.75016243),
        dec: Angle.Degrees(+08.38946965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55352"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01879509),
        dec: Angle.Degrees(+08.39153191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114813"},
        {"Hipparcos Number", "HIP 64473"},
        {"Geneva Identification System", "GEN# +1.00114813"},
        {"Smithsonian Astrophysical Observation", "SAO 119817"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.22322300),
        dec: Angle.Degrees(+08.39323934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225004"},
        {"Hipparcos Number", "HIP 192"},
        {"Geneva Identification System", "GEN# +1.00225004"},
        {"Smithsonian Astrophysical Observation", "SAO 128546"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.61983117),
        dec: Angle.Degrees(+08.39393024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199569"},
        {"Hipparcos Number", "HIP 103477"},
        {"Fundamental Katalog 5th Edition", "FK5 5844"},
        {"Smithsonian Astrophysical Observation", "SAO 126415"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.47369910),
        dec: Angle.Degrees(+08.39444585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75946"},
        {"Geneva Identification System", "GEN# +9.80015024"},
    },
    visualMagnitude: 11.44,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.67498481),
        dec: Angle.Degrees(+08.39486508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2358 AB"},
        {"Henry Draper", "HD 19391"},
        {"Hipparcos Number", "HIP 14504"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83102771),
        dec: Angle.Degrees(+08.39563950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48370"},
        {"Smithsonian Astrophysical Observation", "SAO 117951"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.91086174),
        dec: Angle.Degrees(+08.39576709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183832"},
        {"Hipparcos Number", "HIP 95983"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.76307896),
        dec: Angle.Degrees(+08.39580617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7990"},
        {"Hipparcos Number", "HIP 6195"},
        {"Smithsonian Astrophysical Observation", "SAO 109807"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.86800589),
        dec: Angle.Degrees(+08.39628969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44869"},
        {"Hipparcos Number", "HIP 30485"},
        {"Geneva Identification System", "GEN# +1.00044869"},
        {"Smithsonian Astrophysical Observation", "SAO 113829"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.12336477),
        dec: Angle.Degrees(+08.39702504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4114 AB"},
        {"Henry Draper", "HD 36248"},
        {"Hipparcos Number", "HIP 25814"},
        {"Smithsonian Astrophysical Observation", "SAO 112846"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.69765510),
        dec: Angle.Degrees(+08.39874346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151629"},
        {"Hipparcos Number", "HIP 82248"},
        {"Geneva Identification System", "GEN# +1.00151629"},
        {"Smithsonian Astrophysical Observation", "SAO 121873"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.06704896),
        dec: Angle.Degrees(+08.40066688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148591"},
        {"Hipparcos Number", "HIP 80718"},
        {"Smithsonian Astrophysical Observation", "SAO 121631"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.20333703),
        dec: Angle.Degrees(+08.40107927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92871"},
        {"Geneva Identification System", "GEN# +6.20030188"},
        {"Geneva Identification System 2", "GEN# +6.10010735"},
        {"Wilson Evans Batten Catalogue", "WEB 16083"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.86398515),
        dec: Angle.Degrees(+08.40267585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138484"},
        {"Hipparcos Number", "HIP 76066"},
        {"Geneva Identification System", "GEN# +1.00138484"},
        {"Smithsonian Astrophysical Observation", "SAO 121049"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.02483674),
        dec: Angle.Degrees(+08.40337612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204342"},
        {"Hipparcos Number", "HIP 105968"},
        {"Geneva Identification System", "GEN# +1.00204342"},
        {"Smithsonian Astrophysical Observation", "SAO 126811"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.92444972),
        dec: Angle.Degrees(+08.40489088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124244"},
        {"Hipparcos Number", "HIP 69390"},
        {"Geneva Identification System", "GEN# +1.00124244"},
        {"Smithsonian Astrophysical Observation", "SAO 120340"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.07101569),
        dec: Angle.Degrees(+08.40720696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30677"},
        {"Hipparcos Number", "HIP 22461"},
        {"Celescope Catalog", "CEL 470"},
        {"Geneva Identification System", "GEN# +1.00030677"},
        {"Smithsonian Astrophysical Observation", "SAO 112111"},
        {"Wilson Evans Batten Catalogue", "WEB 4334"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.51506553),
        dec: Angle.Degrees(+08.40785463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120500"},
        {"Hipparcos Number", "HIP 67481"},
        {"Fundamental Katalog 5th Edition", "FK5 1359"},
        {"Geneva Identification System", "GEN# +1.00120500"},
        {"Smithsonian Astrophysical Observation", "SAO 120130"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.43404400),
        dec: Angle.Degrees(+08.40861067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50089"},
        {"Smithsonian Astrophysical Observation", "SAO 118174"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.40908319),
        dec: Angle.Degrees(+08.40909116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27496"},
        {"Hipparcos Number", "HIP 20273"},
        {"Geneva Identification System", "GEN# +1.00027496"},
        {"Smithsonian Astrophysical Observation", "SAO 111757"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.18326135),
        dec: Angle.Degrees(+08.40934284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249273"},
        {"Hipparcos Number", "HIP 28004"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.86094020),
        dec: Angle.Degrees(+08.41159432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92636"},
        {"Hipparcos Number", "HIP 52350"},
        {"Smithsonian Astrophysical Observation", "SAO 118437"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.48053452),
        dec: Angle.Degrees(+08.41444150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26346"},
        {"Hipparcos Number", "HIP 19478"},
        {"Geneva Identification System", "GEN# +1.00026346"},
        {"Smithsonian Astrophysical Observation", "SAO 111638"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.58296209),
        dec: Angle.Degrees(+08.41476694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206466"},
        {"Hipparcos Number", "HIP 107146"},
        {"Smithsonian Astrophysical Observation", "SAO 127001"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.54691032),
        dec: Angle.Degrees(+08.41486685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40491"},
        {"Hipparcos Number", "HIP 28353"},
        {"Smithsonian Astrophysical Observation", "SAO 113327"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.86543141),
        dec: Angle.Degrees(+08.41550814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71795"},
        {"Hipparcos Number", "HIP 41652"},
        {"Smithsonian Astrophysical Observation", "SAO 116818"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40162592),
        dec: Angle.Degrees(+08.41722241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143420"},
        {"Hipparcos Number", "HIP 78364"},
        {"Smithsonian Astrophysical Observation", "SAO 121302"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.98640925),
        dec: Angle.Degrees(+08.41753749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262936"},
        {"Hipparcos Number", "HIP 32260"},
        {"Smithsonian Astrophysical Observation", "SAO 114336"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04577048),
        dec: Angle.Degrees(+08.41795360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164967"},
        {"Hipparcos Number", "HIP 88436"},
        {"Smithsonian Astrophysical Observation", "SAO 123069"},
        {"Wilson Evans Batten Catalogue", "WEB 14952"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.83769265),
        dec: Angle.Degrees(+08.41937418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76037"},
        {"Hipparcos Number", "HIP 43692"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49092470),
        dec: Angle.Degrees(+08.42152939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89091"},
        {"Smithsonian Astrophysical Observation", "SAO 123221"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.74304699),
        dec: Angle.Degrees(+08.42252668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77637"},
        {"Geneva Identification System", "GEN# +0.00803095"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.74613933),
        dec: Angle.Degrees(+08.42365342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75693"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94829706),
        dec: Angle.Degrees(+08.42470936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60910"},
        {"Cincinnati Publication", "Ci 20 711"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.24149764),
        dec: Angle.Degrees(+08.42614568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -634.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213393"},
        {"Hipparcos Number", "HIP 111140"},
        {"Smithsonian Astrophysical Observation", "SAO 127569"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.73768926),
        dec: Angle.Degrees(+08.42680130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21194"},
        {"Hipparcos Number", "HIP 15960"},
        {"Smithsonian Astrophysical Observation", "SAO 111180"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.36230005),
        dec: Angle.Degrees(+08.42720832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34989"},
        {"Hipparcos Number", "HIP 25041"},
        {"Fundamental Katalog 5th Edition", "FK5 2401"},
        {"Geneva Identification System", "GEN# +1.00034989"},
        {"Smithsonian Astrophysical Observation", "SAO 112667"},
        {"Wilson Evans Batten Catalogue", "WEB 4852"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.43150654),
        dec: Angle.Degrees(+08.42856342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41150"},
        {"Smithsonian Astrophysical Observation", "SAO 116709"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.94777139),
        dec: Angle.Degrees(+08.42921772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26884"},
        {"Hipparcos Number", "HIP 19850"},
        {"Geneva Identification System", "GEN# +1.00026884"},
        {"Smithsonian Astrophysical Observation", "SAO 111694"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.82822556),
        dec: Angle.Degrees(+08.42929003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34081"},
        {"Hipparcos Number", "HIP 24477"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79387454),
        dec: Angle.Degrees(+08.43247500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152615"},
        {"Hipparcos Number", "HIP 82680"},
        {"Geneva Identification System", "GEN# +1.00152615"},
        {"Smithsonian Astrophysical Observation", "SAO 121933"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51362455),
        dec: Angle.Degrees(+08.43290469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6570"},
    },
    visualMagnitude: 12.26,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.10480962),
        dec: Angle.Degrees(+08.43735074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194937"},
        {"Hipparcos Number", "HIP 100953"},
        {"Fundamental Katalog 5th Edition", "FK5 3638"},
        {"Geneva Identification System", "GEN# +1.00194937"},
        {"Smithsonian Astrophysical Observation", "SAO 125841"},
        {"Wilson Evans Batten Catalogue", "WEB 18235"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.03131529),
        dec: Angle.Degrees(+08.43740668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216525"},
        {"Hipparcos Number", "HIP 113029"},
        {"Smithsonian Astrophysical Observation", "SAO 127822"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.36781406),
        dec: Angle.Degrees(+08.43863227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34149"},
        {"Hipparcos Number", "HIP 24518"},
        {"Smithsonian Astrophysical Observation", "SAO 112574"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.89774368),
        dec: Angle.Degrees(+08.44132037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106330"},
        {"Smithsonian Astrophysical Observation", "SAO 126872"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02811037),
        dec: Angle.Degrees(+08.44199332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158228"},
        {"Hipparcos Number", "HIP 85450"},
        {"Geneva Identification System", "GEN# +1.00158228"},
        {"Smithsonian Astrophysical Observation", "SAO 122405"},
        {"Wilson Evans Batten Catalogue", "WEB 14433"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.93362195),
        dec: Angle.Degrees(+08.44214144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6972"},
        {"Geneva Identification System", "GEN# +9.80002041"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.43322422),
        dec: Angle.Degrees(+08.44311737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 306.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13443 A"},
        {"Henry Draper", "HD 191533"},
        {"Henry Draper 2", "HD 191533A"},
        {"Hipparcos Number", "HIP 99367"},
        {"Geneva Identification System", "GEN# +1.00191533"},
        {"Smithsonian Astrophysical Observation", "SAO 125517"},
        {"Wilson Evans Batten Catalogue", "WEB 17734"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.53260844),
        dec: Angle.Degrees(+08.44382110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103484"},
        {"Hipparcos Number", "HIP 58110"},
        {"Fundamental Katalog 5th Edition", "FK5 2951"},
        {"Geneva Identification System", "GEN# +1.00103484"},
        {"Smithsonian Astrophysical Observation", "SAO 119111"},
        {"Wilson Evans Batten Catalogue", "WEB 10406"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.76313138),
        dec: Angle.Degrees(+08.44390534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3018 A"},
        {"Hipparcos Number", "HIP 19328"},
        {"Smithsonian Astrophysical Observation", "SAO 111623"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.13362388),
        dec: Angle.Degrees(+08.44488832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110140"},
        {"Geneva Identification System", "GEN# +9.80018039"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.65141126),
        dec: Angle.Degrees(+08.44607070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 283.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43188"},
        {"Hipparcos Number", "HIP 29683"},
        {"Smithsonian Astrophysical Observation", "SAO 113633"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.80022271),
        dec: Angle.Degrees(+08.44631338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9247 ABC"},
        {"Hipparcos Number", "HIP 70327"},
        {"Smithsonian Astrophysical Observation", "SAO 120426"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.84475026),
        dec: Angle.Degrees(+08.44664037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196912"},
        {"Hipparcos Number", "HIP 101979"},
        {"Smithsonian Astrophysical Observation", "SAO 126081"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.99930761),
        dec: Angle.Degrees(+08.44706555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188858"},
        {"Hipparcos Number", "HIP 98158"},
        {"Smithsonian Astrophysical Observation", "SAO 125269"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.22703227),
        dec: Angle.Degrees(+08.44755368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24106"},
        {"Hipparcos Number", "HIP 17995"},
        {"Smithsonian Astrophysical Observation", "SAO 111452"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.69255606),
        dec: Angle.Degrees(+08.44784307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136657"},
        {"Hipparcos Number", "HIP 75166"},
        {"Smithsonian Astrophysical Observation", "SAO 120958"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.40753139),
        dec: Angle.Degrees(+08.44992368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10312 AB"},
        {"Henry Draper", "HD 153914"},
        {"Hipparcos Number", "HIP 83342"},
        {"Geneva Identification System", "GEN# +1.00153914"},
        {"Smithsonian Astrophysical Observation", "SAO 122023"},
        {"Wilson Evans Batten Catalogue", "WEB 14088"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.49566563),
        dec: Angle.Degrees(+08.45066223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5989"},
        {"Hipparcos Number", "HIP 4778"},
        {"Smithsonian Astrophysical Observation", "SAO 109605"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.34628933),
        dec: Angle.Degrees(+08.45070911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20769"},
        {"Hipparcos Number", "HIP 15611"},
        {"Smithsonian Astrophysical Observation", "SAO 111140"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.25351322),
        dec: Angle.Degrees(+08.45108386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72617"},
        {"Hipparcos Number", "HIP 42049"},
        {"Geneva Identification System", "GEN# +1.00072617"},
        {"Smithsonian Astrophysical Observation", "SAO 116894"},
        {"Wilson Evans Batten Catalogue", "WEB 8084"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.55561363),
        dec: Angle.Degrees(+08.45237417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 531"},
        {"Hipparcos Number", "HIP 795"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.46506329),
        dec: Angle.Degrees(+08.45319673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65395"},
        {"Hipparcos Number", "HIP 39000"},
        {"Geneva Identification System", "GEN# +1.00065395"},
        {"Smithsonian Astrophysical Observation", "SAO 116193"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.72045827),
        dec: Angle.Degrees(+08.45325591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15563"},
        {"Smithsonian Astrophysical Observation", "SAO 111134"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.12109014),
        dec: Angle.Degrees(+08.45443742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14915 AB"},
        {"Henry Draper", "HD 203520"},
        {"Hipparcos Number", "HIP 105538"},
        {"Smithsonian Astrophysical Observation", "SAO 126743"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61934244),
        dec: Angle.Degrees(+08.45445974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100304"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)20, 36.0500),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)27, 34.500)
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
    primaryId: "HIP 18763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18763"},
        {"Smithsonian Astrophysical Observation", "SAO 111561"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.28270267),
        dec: Angle.Degrees(+08.45994187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15318"},
        {"Hipparcos Number", "HIP 11484"},
        {"Fundamental Katalog 5th Edition", "FK5 85"},
        {"Geneva Identification System", "GEN# +1.00015318"},
        {"Smithsonian Astrophysical Observation", "SAO 110543"},
        {"Wilson Evans Batten Catalogue", "WEB 2401"},
    },
    visualMagnitude: 4.30,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.03965786),
        dec: Angle.Degrees(+08.46008870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266505"},
        {"Hipparcos Number", "HIP 33310"},
        {"Smithsonian Astrophysical Observation", "SAO 114629"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.92936618),
        dec: Angle.Degrees(+08.46021842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210718"},
        {"Hipparcos Number", "HIP 109608"},
        {"Fundamental Katalog 5th Edition", "FK5 5960"},
        {"Geneva Identification System", "GEN# +1.00210718"},
        {"Smithsonian Astrophysical Observation", "SAO 127366"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.05570041),
        dec: Angle.Degrees(+08.46054804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96339"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.77631587),
        dec: Angle.Degrees(+08.46087333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97938",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Libertas"},
        {"Henry Draper", "HD 188310"},
        {"Hipparcos Number", "HIP 97938"},
        {"Geneva Identification System", "GEN# +1.00188310"},
        {"Smithsonian Astrophysical Observation", "SAO 125210"},
        {"Wilson Evans Batten Catalogue", "WEB 17232"},
    },
    visualMagnitude: 4.71,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.56175736),
        dec: Angle.Degrees(+08.46165027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69746"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.12490906),
        dec: Angle.Degrees(+08.46470259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36390"},
        {"Hipparcos Number", "HIP 25904"},
        {"Smithsonian Astrophysical Observation", "SAO 112871"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93302581),
        dec: Angle.Degrees(+08.46652759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23967"},
        {"Hipparcos Number", "HIP 17883"},
        {"Geneva Identification System", "GEN# +1.00023967"},
        {"Smithsonian Astrophysical Observation", "SAO 111439"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.37767274),
        dec: Angle.Degrees(+08.46704216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3785 AB"},
        {"Henry Draper", "HD 33777"},
        {"Hipparcos Number", "HIP 24310"},
        {"Smithsonian Astrophysical Observation", "SAO 112526"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.25241556),
        dec: Angle.Degrees(+08.46761050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44376"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.58133004),
        dec: Angle.Degrees(+08.46897950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 616.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190517"},
        {"Hipparcos Number", "HIP 98907"},
        {"Smithsonian Astrophysical Observation", "SAO 125424"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.26726409),
        dec: Angle.Degrees(+08.46909645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262068"},
        {"Hipparcos Number", "HIP 32025"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.34720943),
        dec: Angle.Degrees(+08.46947075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19525"},
        {"Hipparcos Number", "HIP 14607"},
        {"Geneva Identification System", "GEN# +1.00019525"},
        {"Smithsonian Astrophysical Observation", "SAO 111002"},
        {"Wilson Evans Batten Catalogue", "WEB 2840"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.16163978),
        dec: Angle.Degrees(+08.47089130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169865"},
        {"Hipparcos Number", "HIP 90360"},
        {"Smithsonian Astrophysical Observation", "SAO 123476"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.58127235),
        dec: Angle.Degrees(+08.47155700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18909"},
        {"Hipparcos Number", "HIP 14176"},
        {"Smithsonian Astrophysical Observation", "SAO 110927"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.70267249),
        dec: Angle.Degrees(+08.47191440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132391"},
        {"Hipparcos Number", "HIP 73292"},
        {"Smithsonian Astrophysical Observation", "SAO 120769"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.67814682),
        dec: Angle.Degrees(+08.47494449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177548"},
        {"Hipparcos Number", "HIP 93707"},
        {"Geneva Identification System", "GEN# +1.00177548"},
        {"Smithsonian Astrophysical Observation", "SAO 124239"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.22123159),
        dec: Angle.Degrees(+08.47629575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74815"},
        {"Hipparcos Number", "HIP 43084"},
        {"Smithsonian Astrophysical Observation", "SAO 117106"},
        {"Wilson Evans Batten Catalogue", "WEB 8314"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.63479943),
        dec: Angle.Degrees(+08.47794048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132611"},
        {"Hipparcos Number", "HIP 73390"},
        {"Geneva Identification System", "GEN# +1.00132611"},
        {"Smithsonian Astrophysical Observation", "SAO 120778"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.97192900),
        dec: Angle.Degrees(+08.47829725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131319"},
        {"Hipparcos Number", "HIP 72790"},
        {"Smithsonian Astrophysical Observation", "SAO 120710"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.17011674),
        dec: Angle.Degrees(+08.48070315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12807"},
        {"Geneva Identification System", "GEN# +9.80004037"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.14634692),
        dec: Angle.Degrees(+08.48114066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137184"},
        {"Hipparcos Number", "HIP 75394"},
        {"Geneva Identification System", "GEN# +1.00137184"},
        {"Smithsonian Astrophysical Observation", "SAO 120983"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08270743),
        dec: Angle.Degrees(+08.48158804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77409"},
        {"Hipparcos Number", "HIP 44398"},
        {"Smithsonian Astrophysical Observation", "SAO 117367"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.65543955),
        dec: Angle.Degrees(+08.48416530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225003"},
        {"Hipparcos Number", "HIP 194"},
        {"Fundamental Katalog 5th Edition", "FK5 3933"},
        {"Geneva Identification System", "GEN# +1.00225003"},
        {"Smithsonian Astrophysical Observation", "SAO 128547"},
        {"Wilson Evans Batten Catalogue", "WEB 34"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.62398938),
        dec: Angle.Degrees(+08.48557854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56793"},
        {"Hipparcos Number", "HIP 35419"},
        {"Smithsonian Astrophysical Observation", "SAO 115238"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.69261093),
        dec: Angle.Degrees(+08.48690839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68697",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9094 AB"},
        {"Henry Draper", "HD 122769"},
        {"Hipparcos Number", "HIP 68697"},
        {"Geneva Identification System", "GEN# +1.00122769J"},
        {"Smithsonian Astrophysical Observation", "SAO 120262"},
        {"Wilson Evans Batten Catalogue", "WEB 12024"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.93027069),
        dec: Angle.Degrees(+08.48703461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115885"},
        {"Hipparcos Number", "HIP 65044"},
        {"Geneva Identification System", "GEN# +1.00115885"},
        {"Smithsonian Astrophysical Observation", "SAO 119882"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.98739826),
        dec: Angle.Degrees(+08.48720422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37355"},
        {"Hipparcos Number", "HIP 26518"},
        {"Geneva Identification System", "GEN# +1.00037355"},
        {"Smithsonian Astrophysical Observation", "SAO 112986"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.59056915),
        dec: Angle.Degrees(+08.48732501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21340"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68876075),
        dec: Angle.Degrees(+08.48759899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122529"},
        {"Hipparcos Number", "HIP 68580"},
        {"Smithsonian Astrophysical Observation", "SAO 120249"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.59489594),
        dec: Angle.Degrees(+08.48846838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39229"},
        {"Hipparcos Number", "HIP 27659"},
        {"Smithsonian Astrophysical Observation", "SAO 113209"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.84257976),
        dec: Angle.Degrees(+08.48850853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137706"},
        {"Hipparcos Number", "HIP 75637"},
        {"Smithsonian Astrophysical Observation", "SAO 121007"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.80449110),
        dec: Angle.Degrees(+08.48992648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47338"},
        {"Hipparcos Number", "HIP 31744"},
        {"Smithsonian Astrophysical Observation", "SAO 114180"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.60967755),
        dec: Angle.Degrees(+08.49228733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45759"},
        {"Hipparcos Number", "HIP 30939"},
        {"Geneva Identification System", "GEN# +1.00045759"},
        {"Smithsonian Astrophysical Observation", "SAO 113947"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.40372704),
        dec: Angle.Degrees(+08.49246928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89814"},
        {"Hipparcos Number", "HIP 50770"},
        {"Smithsonian Astrophysical Observation", "SAO 118257"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.51215833),
        dec: Angle.Degrees(+08.49639532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95982"},
        {"Geneva Identification System", "GEN# +0.00804122"},
        {"Wilson Evans Batten Catalogue", "WEB 16812"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.76231451),
        dec: Angle.Degrees(+08.49761829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146112"},
        {"Hipparcos Number", "HIP 79586"},
        {"Smithsonian Astrophysical Observation", "SAO 121446"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56731961),
        dec: Angle.Degrees(+08.49836671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23879",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3711 AB"},
        {"Henry Draper", "HD 33054"},
        {"Hipparcos Number", "HIP 23879"},
        {"Celescope Catalog", "CEL 538"},
        {"Geneva Identification System", "GEN# +1.00033054"},
        {"Smithsonian Astrophysical Observation", "SAO 112440"},
        {"Wilson Evans Batten Catalogue", "WEB 4659"},
    },
    visualMagnitude: 5.33,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.97030487),
        dec: Angle.Degrees(+08.49857348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15474"},
        {"Hipparcos Number", "HIP 11608"},
        {"Geneva Identification System", "GEN# +1.00015474"},
        {"Smithsonian Astrophysical Observation", "SAO 110568"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.43558721),
        dec: Angle.Degrees(+08.49883696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68925"},
        {"Smithsonian Astrophysical Observation", "SAO 120290"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.66246586),
        dec: Angle.Degrees(+08.50138219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68859"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.50792542),
        dec: Angle.Degrees(+08.50201289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35381"},
        {"Hipparcos Number", "HIP 25294"},
        {"Smithsonian Astrophysical Observation", "SAO 112728"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.17019458),
        dec: Angle.Degrees(+08.50235337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25869"},
        {"Hipparcos Number", "HIP 19147"},
        {"Geneva Identification System", "GEN# +1.00025869"},
        {"Smithsonian Astrophysical Observation", "SAO 111604"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.55431891),
        dec: Angle.Degrees(+08.50262088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62994"},
        {"Geneva Identification System", "GEN# +0.00902690"},
        {"Smithsonian Astrophysical Observation", "SAO 119657"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.62119696),
        dec: Angle.Degrees(+08.50365254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222876"},
        {"Hipparcos Number", "HIP 117110"},
        {"Geneva Identification System", "GEN# +1.00222876"},
        {"Smithsonian Astrophysical Observation", "SAO 128356"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.12997185),
        dec: Angle.Degrees(+08.50415608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222859"},
        {"Hipparcos Number", "HIP 117098"},
        {"Smithsonian Astrophysical Observation", "SAO 128355"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.07745067),
        dec: Angle.Degrees(+08.50462204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81387"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.31880529),
        dec: Angle.Degrees(+08.50649817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23172"},
        {"Hipparcos Number", "HIP 17380"},
        {"Smithsonian Astrophysical Observation", "SAO 111372"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.82773733),
        dec: Angle.Degrees(+08.50822791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22609"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.96330332),
        dec: Angle.Degrees(+08.50923234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11833"},
        {"Hipparcos Number", "HIP 9035"},
        {"Geneva Identification System", "GEN# +1.00011833"},
        {"Smithsonian Astrophysical Observation", "SAO 110238"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.09346611),
        dec: Angle.Degrees(+08.50963760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156404"},
        {"Hipparcos Number", "HIP 84549"},
        {"Smithsonian Astrophysical Observation", "SAO 122232"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.26043021),
        dec: Angle.Degrees(+08.51049073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130319"},
        {"Hipparcos Number", "HIP 72311"},
        {"Smithsonian Astrophysical Observation", "SAO 120664"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.81457752),
        dec: Angle.Degrees(+08.51081506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51571"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00261037),
        dec: Angle.Degrees(+08.51109424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49972"},
        {"Hipparcos Number", "HIP 32899"},
        {"Smithsonian Astrophysical Observation", "SAO 114509"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.82249230),
        dec: Angle.Degrees(+08.51119586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18441"},
        {"Smithsonian Astrophysical Observation", "SAO 111511"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.13303422),
        dec: Angle.Degrees(+08.51180787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148229"},
        {"Hipparcos Number", "HIP 80517"},
        {"Smithsonian Astrophysical Observation", "SAO 121595"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.55249297),
        dec: Angle.Degrees(+08.51301744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37027"},
        {"Smithsonian Astrophysical Observation", "SAO 115689"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13580270),
        dec: Angle.Degrees(+08.51341667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199631"},
        {"Hipparcos Number", "HIP 103512"},
        {"Geneva Identification System", "GEN# +1.00199631"},
        {"Smithsonian Astrophysical Observation", "SAO 126420"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.57258962),
        dec: Angle.Degrees(+08.51533893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60548"},
        {"Hipparcos Number", "HIP 36911"},
        {"Geneva Identification System", "GEN# +1.00060548"},
        {"Smithsonian Astrophysical Observation", "SAO 115663"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.83655699),
        dec: Angle.Degrees(+08.51606723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95118"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.25976864),
        dec: Angle.Degrees(+08.51633882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111257"},
        {"Hipparcos Number", "HIP 62453"},
        {"Geneva Identification System", "GEN# +1.00111257"},
        {"Smithsonian Astrophysical Observation", "SAO 119597"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.98911642),
        dec: Angle.Degrees(+08.51691239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134793"},
        {"Hipparcos Number", "HIP 74334"},
        {"Geneva Identification System", "GEN# +1.00134793"},
        {"Renson", "Renson 38240"},
        {"Smithsonian Astrophysical Observation", "SAO 120885"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89314746),
        dec: Angle.Degrees(+08.51707242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48880"},
        {"Smithsonian Astrophysical Observation", "SAO 118024"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.54844577),
        dec: Angle.Degrees(+08.51736186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70981"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.77335997),
        dec: Angle.Degrees(+08.51751324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263895"},
        {"Hipparcos Number", "HIP 32526"},
        {"Smithsonian Astrophysical Observation", "SAO 114408"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.81201466),
        dec: Angle.Degrees(+08.51884915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193777"},
        {"Hipparcos Number", "HIP 100421"},
        {"Smithsonian Astrophysical Observation", "SAO 125720"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.45000855),
        dec: Angle.Degrees(+08.51944516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174372"},
        {"Hipparcos Number", "HIP 92409"},
        {"Smithsonian Astrophysical Observation", "SAO 123951"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.47834520),
        dec: Angle.Degrees(+08.51971137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221832"},
        {"Hipparcos Number", "HIP 116417"},
        {"Smithsonian Astrophysical Observation", "SAO 128269"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86176596),
        dec: Angle.Degrees(+08.51974047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29896"},
        {"Wilson Evans Batten Catalogue", "WEB 5922"},
    },
    visualMagnitude: 9.34,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.42538584),
        dec: Angle.Degrees(+08.51983908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196726"},
        {"Hipparcos Number", "HIP 101895"},
        {"Geneva Identification System", "GEN# +1.00196726"},
        {"Smithsonian Astrophysical Observation", "SAO 126055"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.73522298),
        dec: Angle.Degrees(+08.52274849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59144"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.91441907),
        dec: Angle.Degrees(+08.52393104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139800"},
        {"Hipparcos Number", "HIP 76710"},
        {"Smithsonian Astrophysical Observation", "SAO 121113"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.96642619),
        dec: Angle.Degrees(+08.52685499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16762"},
        {"Hipparcos Number", "HIP 12542"},
        {"Smithsonian Astrophysical Observation", "SAO 110686"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.34888935),
        dec: Angle.Degrees(+08.52724231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110184"},
        {"Hipparcos Number", "HIP 61824"},
        {"Geneva Identification System", "GEN# +1.00110184"},
        {"Smithsonian Astrophysical Observation", "SAO 119523"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.05869595),
        dec: Angle.Degrees(+08.52726215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121150"},
        {"Hipparcos Number", "HIP 67827"},
        {"Smithsonian Astrophysical Observation", "SAO 120157"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.41240708),
        dec: Angle.Degrees(+08.53054956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162501"},
        {"Hipparcos Number", "HIP 87363"},
        {"Geneva Identification System", "GEN# +1.00162501"},
        {"Smithsonian Astrophysical Observation", "SAO 122829"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.76742945),
        dec: Angle.Degrees(+08.53074567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52558"},
        {"Hipparcos Number", "HIP 33884"},
        {"Smithsonian Astrophysical Observation", "SAO 114802"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.49947305),
        dec: Angle.Degrees(+08.53362018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145002"},
        {"Hipparcos Number", "HIP 79072"},
        {"Geneva Identification System", "GEN# +1.00145002"},
        {"Smithsonian Astrophysical Observation", "SAO 121383"},
        {"Wilson Evans Batten Catalogue", "WEB 13366"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.11701282),
        dec: Angle.Degrees(+08.53432477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5634"},
        {"Smithsonian Astrophysical Observation", "SAO 109726"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.09020950),
        dec: Angle.Degrees(+08.53648831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36601"},
        {"Hipparcos Number", "HIP 26044"},
        {"Smithsonian Astrophysical Observation", "SAO 112896"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.33157051),
        dec: Angle.Degrees(+08.53849171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176112"},
        {"Hipparcos Number", "HIP 93131"},
        {"Geneva Identification System", "GEN# +1.00176112"},
        {"Smithsonian Astrophysical Observation", "SAO 124111"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58522953),
        dec: Angle.Degrees(+08.53906497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19532"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.76897393),
        dec: Angle.Degrees(+08.53959781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74261"},
        {"Hipparcos Number", "HIP 42807"},
        {"Smithsonian Astrophysical Observation", "SAO 117051"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.82625479),
        dec: Angle.Degrees(+08.53990774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215994"},
        {"Hipparcos Number", "HIP 112659"},
        {"Smithsonian Astrophysical Observation", "SAO 127781"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23774918),
        dec: Angle.Degrees(+08.54291468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14754"},
        {"Hipparcos Number", "HIP 11106"},
        {"Fundamental Katalog 5th Edition", "FK5 4221"},
        {"Geneva Identification System", "GEN# +1.00014754"},
        {"Smithsonian Astrophysical Observation", "SAO 110502"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.73599774),
        dec: Angle.Degrees(+08.54546928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99738"},
        {"Hipparcos Number", "HIP 55985"},
        {"Smithsonian Astrophysical Observation", "SAO 118880"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.11129756),
        dec: Angle.Degrees(+08.54720181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115052"},
        {"Smithsonian Astrophysical Observation", "SAO 128097"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.53506195),
        dec: Angle.Degrees(+08.54831166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38623"},
        {"Hipparcos Number", "HIP 27332"},
        {"Celescope Catalog", "CEL 968"},
        {"Geneva Identification System", "GEN# +1.00038623"},
        {"Smithsonian Astrophysical Observation", "SAO 113136"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.84447251),
        dec: Angle.Degrees(+08.54839456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11303"},
        {"Hipparcos Number", "HIP 8612"},
        {"Geneva Identification System", "GEN# +1.00011303"},
        {"Smithsonian Astrophysical Observation", "SAO 110168"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.77858304),
        dec: Angle.Degrees(+08.54857055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211287"},
        {"Hipparcos Number", "HIP 109939"},
        {"Fundamental Katalog 5th Edition", "FK5 3780"},
        {"Geneva Identification System", "GEN# +1.00211287"},
        {"Smithsonian Astrophysical Observation", "SAO 127420"},
        {"Wilson Evans Batten Catalogue", "WEB 19737"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.99922011),
        dec: Angle.Degrees(+08.54959901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8232"},
        {"Hipparcos Number", "HIP 6372"},
        {"Smithsonian Astrophysical Observation", "SAO 109828"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.46875291),
        dec: Angle.Degrees(+08.54982084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95429"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17524529),
        dec: Angle.Degrees(+08.55039690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59605"},
        {"Henry Draper 2", "HD 59604"},
        {"Hipparcos Number", "HIP 36535"},
        {"Geneva Identification System", "GEN# +1.00059604"},
        {"Smithsonian Astrophysical Observation", "SAO 115545"},
        {"Wilson Evans Batten Catalogue", "WEB 7267"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73576152),
        dec: Angle.Degrees(+08.55200641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20547"},
        {"Renson", "Renson 7130"},
    },
    visualMagnitude: 12.62,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.04031694),
        dec: Angle.Degrees(+08.55480627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109638"},
        {"Cincinnati Publication", "Ci 20 1346"},
        {"Geneva Identification System", "GEN# +9.80018036"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.14950918),
        dec: Angle.Degrees(+08.55485737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -661.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22722",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3502 AB"},
        {"Henry Draper", "HD 31087"},
        {"Hipparcos Number", "HIP 22722"},
        {"Smithsonian Astrophysical Observation", "SAO 112173"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.30998986),
        dec: Angle.Degrees(+08.55601792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55465"},
        {"Hipparcos Number", "HIP 34903"},
        {"Smithsonian Astrophysical Observation", "SAO 115088"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.32352962),
        dec: Angle.Degrees(+08.55663203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189695"},
        {"Hipparcos Number", "HIP 98526"},
        {"Geneva Identification System", "GEN# +1.00189695"},
        {"Smithsonian Astrophysical Observation", "SAO 125355"},
        {"Wilson Evans Batten Catalogue", "WEB 17403"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.24571281),
        dec: Angle.Degrees(+08.55776880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10503"},
        {"Hipparcos Number", "HIP 7985"},
        {"Smithsonian Astrophysical Observation", "SAO 110081"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.63841196),
        dec: Angle.Degrees(+08.55856588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18253"},
        {"Geneva Identification System", "GEN# +9.80007011"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.56608960),
        dec: Angle.Degrees(+08.55883272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10783"},
        {"Hipparcos Number", "HIP 8210"},
        {"Geneva Identification System", "GEN# +1.00010783"},
        {"Renson", "Renson 2670"},
        {"Smithsonian Astrophysical Observation", "SAO 110111"},
        {"Wilson Evans Batten Catalogue", "WEB 1747"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.42720410),
        dec: Angle.Degrees(+08.55929739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133565"},
        {"Hipparcos Number", "HIP 73790"},
        {"Smithsonian Astrophysical Observation", "SAO 120825"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23248349),
        dec: Angle.Degrees(+08.55963638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163385"},
        {"Hipparcos Number", "HIP 87752"},
        {"Geneva Identification System", "GEN# +1.00163385"},
        {"Smithsonian Astrophysical Observation", "SAO 122921"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.86600828),
        dec: Angle.Degrees(+08.55982302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85457"},
        {"Smithsonian Astrophysical Observation", "SAO 122407"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.95478843),
        dec: Angle.Degrees(+08.56020760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109440"},
        {"Hipparcos Number", "HIP 61376"},
        {"Smithsonian Astrophysical Observation", "SAO 119481"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.66873074),
        dec: Angle.Degrees(+08.56094528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39936"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.34114872),
        dec: Angle.Degrees(+08.56121049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92576"},
        {"Hipparcos Number", "HIP 52315"},
        {"Smithsonian Astrophysical Observation", "SAO 118431"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.34779736),
        dec: Angle.Degrees(+08.56266319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55625"},
        {"Cincinnati Publication", "Ci 20 632"},
        {"Geneva Identification System", "GEN# +9.80010019"},
        {"Wilson Evans Batten Catalogue", "WEB 9997"},
    },
    visualMagnitude: 11.18,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.93819255),
        dec: Angle.Degrees(+08.56301650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1003.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 195.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71606"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.67653638),
        dec: Angle.Degrees(+08.56754856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53430"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.95167572),
        dec: Angle.Degrees(+08.56982950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13421"},
        {"Hipparcos Number", "HIP 10212"},
        {"Geneva Identification System", "GEN# +1.00013421"},
        {"Smithsonian Astrophysical Observation", "SAO 110390"},
        {"Wilson Evans Batten Catalogue", "WEB 2132"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.83817716),
        dec: Angle.Degrees(+08.57008262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84701"},
        {"Hipparcos Number", "HIP 48014"},
        {"Geneva Identification System", "GEN# +1.00084701"},
        {"Smithsonian Astrophysical Observation", "SAO 117908"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.81907558),
        dec: Angle.Degrees(+08.57056483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103273"},
        {"Hipparcos Number", "HIP 57990"},
        {"Geneva Identification System", "GEN# +1.00103273"},
        {"Smithsonian Astrophysical Observation", "SAO 119099"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.41984189),
        dec: Angle.Degrees(+08.57217502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40351"},
    },
    visualMagnitude: 12.14,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.57820568),
        dec: Angle.Degrees(+08.57352231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21732"},
        {"Hipparcos Number", "HIP 16342"},
        {"Smithsonian Astrophysical Observation", "SAO 111228"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65538883),
        dec: Angle.Degrees(+08.57480787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138528"},
        {"Hipparcos Number", "HIP 76094"},
        {"Smithsonian Astrophysical Observation", "SAO 121052"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.11454332),
        dec: Angle.Degrees(+08.57696785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 120 AB"},
        {"Henry Draper", "HD 542"},
        {"Hipparcos Number", "HIP 807"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.48945297),
        dec: Angle.Degrees(+08.57704143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138290"},
        {"Hipparcos Number", "HIP 75971"},
        {"Fundamental Katalog 5th Edition", "FK5 1408"},
        {"Geneva Identification System", "GEN# +1.00138290"},
        {"Smithsonian Astrophysical Observation", "SAO 121038"},
        {"Wilson Evans Batten Catalogue", "WEB 12916"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.73089659),
        dec: Angle.Degrees(+08.57910008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107400"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.30669529),
        dec: Angle.Degrees(+08.57992209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7128"},
        {"Hipparcos Number", "HIP 5593"},
        {"Smithsonian Astrophysical Observation", "SAO 109721"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.93105456),
        dec: Angle.Degrees(+08.58001774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142500"},
        {"Hipparcos Number", "HIP 77910"},
        {"Fundamental Katalog 5th Edition", "FK5 3256"},
        {"Geneva Identification System", "GEN# +1.00142500"},
        {"Smithsonian Astrophysical Observation", "SAO 121254"},
        {"Wilson Evans Batten Catalogue", "WEB 13176"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.66780783),
        dec: Angle.Degrees(+08.58033887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23805"},
        {"Hipparcos Number", "HIP 17779"},
        {"Geneva Identification System", "GEN# +5.20250136"},
        {"Smithsonian Astrophysical Observation", "SAO 111428"},
        {"Wilson Evans Batten Catalogue", "WEB 3407"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09307609),
        dec: Angle.Degrees(+08.58042083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217106"},
        {"Hipparcos Number", "HIP 113408"},
        {"Smithsonian Astrophysical Observation", "SAO 127864"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.52428324),
        dec: Angle.Degrees(+08.58109970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151217"},
        {"Hipparcos Number", "HIP 82073"},
        {"Fundamental Katalog 5th Edition", "FK5 3332"},
        {"Geneva Identification System", "GEN# +1.00151217"},
        {"Smithsonian Astrophysical Observation", "SAO 121843"},
        {"Wilson Evans Batten Catalogue", "WEB 13858"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45788751),
        dec: Angle.Degrees(+08.58257816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113078"},
        {"Hipparcos Number", "HIP 63525"},
        {"Smithsonian Astrophysical Observation", "SAO 119716"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.25818345),
        dec: Angle.Degrees(+08.58398767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142536"},
        {"Hipparcos Number", "HIP 77924"},
        {"Smithsonian Astrophysical Observation", "SAO 121257"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.70696141),
        dec: Angle.Degrees(+08.58466494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205923"},
        {"Hipparcos Number", "HIP 106841"},
        {"Smithsonian Astrophysical Observation", "SAO 126952"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.60262596),
        dec: Angle.Degrees(+08.58468849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117936"},
        {"Hipparcos Number", "HIP 66147"},
        {"Geneva Identification System", "GEN# +1.00117936"},
        {"Smithsonian Astrophysical Observation", "SAO 119997"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.38624617),
        dec: Angle.Degrees(+08.58653437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -506.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91456"},
        {"Hipparcos Number", "HIP 51696"},
        {"Smithsonian Astrophysical Observation", "SAO 118359"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.42834678),
        dec: Angle.Degrees(+08.58657566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48977"},
        {"Hipparcos Number", "HIP 32463"},
        {"Fundamental Katalog 5th Edition", "FK5 1177"},
        {"Geneva Identification System", "GEN# +1.00048977"},
        {"Smithsonian Astrophysical Observation", "SAO 114388"},
        {"Wilson Evans Batten Catalogue", "WEB 6547"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63507823),
        dec: Angle.Degrees(+08.58716910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41142"},
        {"Hipparcos Number", "HIP 28696"},
        {"Geneva Identification System", "GEN# +1.00041142"},
        {"Smithsonian Astrophysical Observation", "SAO 113407"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.88447829),
        dec: Angle.Degrees(+08.58965506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28114"},
        {"Hipparcos Number", "HIP 20715"},
        {"Fundamental Katalog 5th Edition", "FK5 2327"},
        {"Geneva Identification System", "GEN# +1.00028114"},
        {"Smithsonian Astrophysical Observation", "SAO 111817"},
        {"Wilson Evans Batten Catalogue", "WEB 3974"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.58792035),
        dec: Angle.Degrees(+08.59028189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109360"},
        {"Hipparcos Number", "HIP 61331"},
        {"Smithsonian Astrophysical Observation", "SAO 119471"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.50203659),
        dec: Angle.Degrees(+08.59053068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54789"},
        {"Smithsonian Astrophysical Observation", "SAO 118723"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.25082098),
        dec: Angle.Degrees(+08.59345153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196366"},
        {"Hipparcos Number", "HIP 101688"},
        {"Smithsonian Astrophysical Observation", "SAO 126014"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.17469453),
        dec: Angle.Degrees(+08.59475732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194305"},
        {"Hipparcos Number", "HIP 100666"},
        {"Fundamental Katalog 5th Edition", "FK5 5801"},
        {"Smithsonian Astrophysical Observation", "SAO 125773"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15957304),
        dec: Angle.Degrees(+08.59750375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132051"},
        {"Hipparcos Number", "HIP 73138"},
        {"Cincinnati Publication", "Ci 18 1978"},
        {"Geneva Identification System", "GEN# +1.00132051"},
        {"Smithsonian Astrophysical Observation", "SAO 120752"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.20259457),
        dec: Angle.Degrees(+08.59875851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -298.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67770"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.26755998),
        dec: Angle.Degrees(+08.59980783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121587"},
        {"Hipparcos Number", "HIP 68074"},
        {"Smithsonian Astrophysical Observation", "SAO 120181"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.06580430),
        dec: Angle.Degrees(+08.59987284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22848",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3517 AB"},
        {"Henry Draper", "HD 31306"},
        {"Hipparcos Number", "HIP 22848"},
        {"Celescope Catalog", "CEL 486"},
        {"Geneva Identification System", "GEN# +1.00031306J"},
        {"Smithsonian Astrophysical Observation", "SAO 112205"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.73493713),
        dec: Angle.Degrees(+08.60000165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132756"},
        {"Hipparcos Number", "HIP 73449"},
        {"Cincinnati Publication", "Ci 18 1992"},
        {"Geneva Identification System", "GEN# +1.00132756"},
        {"Smithsonian Astrophysical Observation", "SAO 120789"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.14608525),
        dec: Angle.Degrees(+08.60093793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152514"},
        {"Hipparcos Number", "HIP 82631"},
        {"Smithsonian Astrophysical Observation", "SAO 121928"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37260214),
        dec: Angle.Degrees(+08.60169732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8793"},
        {"Hipparcos Number", "HIP 6738"},
        {"Smithsonian Astrophysical Observation", "SAO 109894"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.68576122),
        dec: Angle.Degrees(+08.60357955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157618"},
        {"Hipparcos Number", "HIP 85143"},
        {"Smithsonian Astrophysical Observation", "SAO 122347"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99274000),
        dec: Angle.Degrees(+08.60468007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3533"},
        {"Hipparcos Number", "HIP 3017"},
        {"Geneva Identification System", "GEN# +1.00003533"},
        {"Smithsonian Astrophysical Observation", "SAO 109333"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.60147645),
        dec: Angle.Degrees(+08.60469969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54165"},
        {"Hipparcos Number", "HIP 34419"},
        {"Smithsonian Astrophysical Observation", "SAO 114956"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.03586529),
        dec: Angle.Degrees(+08.60787976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95640"},
        {"Hipparcos Number", "HIP 53955"},
        {"Smithsonian Astrophysical Observation", "SAO 118626"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.58688433),
        dec: Angle.Degrees(+08.60792993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17912"},
        {"Hipparcos Number", "HIP 13422"},
        {"Geneva Identification System", "GEN# +1.00017912"},
        {"Smithsonian Astrophysical Observation", "SAO 110808"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.21211424),
        dec: Angle.Degrees(+08.61034339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108471"},
        {"Hipparcos Number", "HIP 60804"},
        {"Geneva Identification System", "GEN# +1.00108471"},
        {"Smithsonian Astrophysical Observation", "SAO 119413"},
        {"Wilson Evans Batten Catalogue", "WEB 10818"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.92528655),
        dec: Angle.Degrees(+08.61037129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179564"},
        {"Hipparcos Number", "HIP 94395"},
        {"Smithsonian Astrophysical Observation", "SAO 124393"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18565811),
        dec: Angle.Degrees(+08.61051429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89561"},
        {"Hipparcos Number", "HIP 50604"},
        {"Smithsonian Astrophysical Observation", "SAO 118232"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.05881257),
        dec: Angle.Degrees(+08.61080800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69468"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.33223897),
        dec: Angle.Degrees(+08.61123313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145050"},
        {"Hipparcos Number", "HIP 79086"},
        {"Geneva Identification System", "GEN# +1.00145050"},
        {"Smithsonian Astrophysical Observation", "SAO 121385"},
        {"Wilson Evans Batten Catalogue", "WEB 13369"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.15220976),
        dec: Angle.Degrees(+08.61324825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180815"},
        {"Hipparcos Number", "HIP 94824"},
        {"Smithsonian Astrophysical Observation", "SAO 124479"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.42069946),
        dec: Angle.Degrees(+08.61414583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205604"},
        {"Hipparcos Number", "HIP 106664"},
        {"Smithsonian Astrophysical Observation", "SAO 126919"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.06167765),
        dec: Angle.Degrees(+08.61583462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169889"},
        {"Hipparcos Number", "HIP 90365"},
        {"Cincinnati Publication", "Ci 20 1089"},
        {"Geneva Identification System", "GEN# +1.00169889"},
        {"Smithsonian Astrophysical Observation", "SAO 123479"},
        {"Wilson Evans Batten Catalogue", "WEB 15470"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.59189095),
        dec: Angle.Degrees(+08.61690344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -468.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61480"},
        {"Hipparcos Number", "HIP 37338"},
        {"Fundamental Katalog 5th Edition", "FK5 4690"},
        {"Smithsonian Astrophysical Observation", "SAO 115768"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97275700),
        dec: Angle.Degrees(+08.61787412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143457"},
        {"Hipparcos Number", "HIP 78383"},
        {"Smithsonian Astrophysical Observation", "SAO 121305"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.02591556),
        dec: Angle.Degrees(+08.61873296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50172"},
        {"Smithsonian Astrophysical Observation", "SAO 118177"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.61824550),
        dec: Angle.Degrees(+08.61976695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102172"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.54217957),
        dec: Angle.Degrees(+08.62046956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140488"},
        {"Hipparcos Number", "HIP 77025"},
        {"Geneva Identification System", "GEN# +1.00140488"},
        {"Smithsonian Astrophysical Observation", "SAO 121149"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.89679044),
        dec: Angle.Degrees(+08.62054576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212030"},
        {"Hipparcos Number", "HIP 110372"},
        {"Geneva Identification System", "GEN# +1.00212030"},
        {"Smithsonian Astrophysical Observation", "SAO 127470"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.33441960),
        dec: Angle.Degrees(+08.62132228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146947"},
        {"Hipparcos Number", "HIP 79903"},
        {"Smithsonian Astrophysical Observation", "SAO 121491"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.64491323),
        dec: Angle.Degrees(+08.62174462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154611"},
        {"Hipparcos Number", "HIP 83675"},
        {"Smithsonian Astrophysical Observation", "SAO 122073"},
        {"Wilson Evans Batten Catalogue", "WEB 14148"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.53026522),
        dec: Angle.Degrees(+08.62319474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91653"},
        {"Smithsonian Astrophysical Observation", "SAO 123812"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.35400094),
        dec: Angle.Degrees(+08.62397481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173216"},
        {"Hipparcos Number", "HIP 91881"},
        {"Geneva Identification System", "GEN# +1.00173216"},
        {"Smithsonian Astrophysical Observation", "SAO 123860"},
        {"Wilson Evans Batten Catalogue", "WEB 15820"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.96352826),
        dec: Angle.Degrees(+08.62511933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155484"},
        {"Hipparcos Number", "HIP 84097"},
        {"Smithsonian Astrophysical Observation", "SAO 122160"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.89052166),
        dec: Angle.Degrees(+08.62542782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168761"},
        {"Hipparcos Number", "HIP 89934"},
        {"Smithsonian Astrophysical Observation", "SAO 123381"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25305924),
        dec: Angle.Degrees(+08.62838360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43416"},
        {"Smithsonian Astrophysical Observation", "SAO 117187"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.64928275),
        dec: Angle.Degrees(+08.63095814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220965"},
        {"Hipparcos Number", "HIP 115838"},
        {"Smithsonian Astrophysical Observation", "SAO 128197"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.01855072),
        dec: Angle.Degrees(+08.63146299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52407"},
        {"Hipparcos Number", "HIP 33832"},
        {"Geneva Identification System", "GEN# +1.00052407"},
        {"Smithsonian Astrophysical Observation", "SAO 114787"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.34974619),
        dec: Angle.Degrees(+08.63156281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189069"},
        {"Hipparcos Number", "HIP 98250"},
        {"Smithsonian Astrophysical Observation", "SAO 125285"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47823291),
        dec: Angle.Degrees(+08.63254724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46516"},
        {"Geneva Identification System", "GEN# +0.00902190"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.31435612),
        dec: Angle.Degrees(+08.63421331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23083"},
        {"Hipparcos Number", "HIP 17337"},
        {"Smithsonian Astrophysical Observation", "SAO 111363"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.65529979),
        dec: Angle.Degrees(+08.63467378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199801"},
        {"Hipparcos Number", "HIP 103586"},
        {"Geneva Identification System", "GEN# +1.00199801"},
        {"Smithsonian Astrophysical Observation", "SAO 126435"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.82162086),
        dec: Angle.Degrees(+08.63769640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65066"},
        {"Hipparcos Number", "HIP 38868"},
        {"Geneva Identification System", "GEN# +1.00065066"},
        {"Smithsonian Astrophysical Observation", "SAO 116162"},
        {"Wilson Evans Batten Catalogue", "WEB 7612"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.31617316),
        dec: Angle.Degrees(+08.64127641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72980"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.71922770),
        dec: Angle.Degrees(+08.64315281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21910"},
        {"Smithsonian Astrophysical Observation", "SAO 111994"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.66952348),
        dec: Angle.Degrees(+08.64345803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11975"},
    },
    visualMagnitude: 12.37,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.61780533),
        dec: Angle.Degrees(+08.64347328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209152"},
        {"Hipparcos Number", "HIP 108696"},
        {"Geneva Identification System", "GEN# +1.00209152"},
        {"Smithsonian Astrophysical Observation", "SAO 127238"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.27943648),
        dec: Angle.Degrees(+08.64353967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220773"},
        {"Hipparcos Number", "HIP 115697"},
        {"Geneva Identification System", "GEN# +1.00220773"},
        {"Smithsonian Astrophysical Observation", "SAO 128181"},
        {"Wilson Evans Batten Catalogue", "WEB 20474"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.61428684),
        dec: Angle.Degrees(+08.64438584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115831"},
        {"Hipparcos Number", "HIP 65009"},
        {"Geneva Identification System", "GEN# +1.00115831"},
        {"Smithsonian Astrophysical Observation", "SAO 119878"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.88361245),
        dec: Angle.Degrees(+08.64504356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162829"},
        {"Hipparcos Number", "HIP 87496"},
        {"Geneva Identification System", "GEN# +1.00162829"},
        {"Smithsonian Astrophysical Observation", "SAO 122864"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.16235713),
        dec: Angle.Degrees(+08.64815291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7837 AB"},
        {"Henry Draper", "HD 91636"},
        {"Hipparcos Number", "HIP 51802"},
        {"Geneva Identification System", "GEN# +1.00091636"},
        {"Smithsonian Astrophysical Observation", "SAO 118380"},
        {"Wilson Evans Batten Catalogue", "WEB 9435"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.75912532),
        dec: Angle.Degrees(+08.65043904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104025"},
        {"Smithsonian Astrophysical Observation", "SAO 126516"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.13037064),
        dec: Angle.Degrees(+08.65044452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6591"},
        {"Hipparcos Number", "HIP 5231"},
        {"Smithsonian Astrophysical Observation", "SAO 109681"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.72457232),
        dec: Angle.Degrees(+08.65238012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63796",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8763 AB"},
        {"Henry Draper", "HD 113563"},
        {"Hipparcos Number", "HIP 63796"},
        {"Smithsonian Astrophysical Observation", "SAO 119754"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.12804065),
        dec: Angle.Degrees(+08.65318115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140834"},
        {"Hipparcos Number", "HIP 77175"},
        {"Geneva Identification System", "GEN# +1.00140834"},
        {"Smithsonian Astrophysical Observation", "SAO 121172"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.36810604),
        dec: Angle.Degrees(+08.65331884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169390"},
        {"Hipparcos Number", "HIP 90172"},
        {"Geneva Identification System", "GEN# +1.00169390"},
        {"Smithsonian Astrophysical Observation", "SAO 123431"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.00559181),
        dec: Angle.Degrees(+08.65458047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217621"},
        {"Hipparcos Number", "HIP 113722"},
        {"Geneva Identification System", "GEN# +1.00217621"},
        {"Smithsonian Astrophysical Observation", "SAO 127911"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.47589874),
        dec: Angle.Degrees(+08.65703829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116651"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.59249830),
        dec: Angle.Degrees(+08.65721417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 551"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.68263710),
        dec: Angle.Degrees(+08.65733696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147996"},
        {"Hipparcos Number", "HIP 80413"},
        {"Smithsonian Astrophysical Observation", "SAO 121578"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.19949637),
        dec: Angle.Degrees(+08.65860677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257423"},
        {"Hipparcos Number", "HIP 30686"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.72763677),
        dec: Angle.Degrees(+08.65918407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99393"},
        {"Hipparcos Number", "HIP 55816"},
        {"Fundamental Katalog 5th Edition", "FK5 5007"},
        {"Smithsonian Astrophysical Observation", "SAO 118859"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.57514161),
        dec: Angle.Degrees(+08.65959348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182296"},
        {"Hipparcos Number", "HIP 95325"},
        {"Geneva Identification System", "GEN# +1.00182296"},
        {"Smithsonian Astrophysical Observation", "SAO 124580"},
        {"Wilson Evans Batten Catalogue", "WEB 16659"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91135703),
        dec: Angle.Degrees(+08.66002235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22148"},
        {"Hipparcos Number", "HIP 16660"},
        {"Smithsonian Astrophysical Observation", "SAO 111265"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.59078612),
        dec: Angle.Degrees(+08.66244467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17668"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.75737774),
        dec: Angle.Degrees(+08.66481149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5052"},
        {"Hipparcos Number", "HIP 4094"},
        {"Smithsonian Astrophysical Observation", "SAO 109515"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.13688639),
        dec: Angle.Degrees(+08.66545186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75516"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.40881079),
        dec: Angle.Degrees(+08.66629328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257192"},
        {"Hipparcos Number", "HIP 30631"},
    },
    visualMagnitude: 10.08,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.54797662),
        dec: Angle.Degrees(+08.66723115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42035"},
        {"Hipparcos Number", "HIP 29138"},
        {"Celescope Catalog", "CEL 1090"},
        {"Geneva Identification System", "GEN# +1.00042035"},
        {"Smithsonian Astrophysical Observation", "SAO 113503"},
        {"Wilson Evans Batten Catalogue", "WEB 5713"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.19596249),
        dec: Angle.Degrees(+08.66945788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195379"},
        {"Hipparcos Number", "HIP 101187"},
        {"Geneva Identification System", "GEN# +1.00195379"},
        {"Smithsonian Astrophysical Observation", "SAO 125881"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64910123),
        dec: Angle.Degrees(+08.66980081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49185"},
        {"Smithsonian Astrophysical Observation", "SAO 118064"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.58402373),
        dec: Angle.Degrees(+08.67081005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40141"},
        {"Smithsonian Astrophysical Observation", "SAO 116463"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.96377215),
        dec: Angle.Degrees(+08.67110553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101470"},
        {"Hipparcos Number", "HIP 56968"},
        {"Fundamental Katalog 5th Edition", "FK5 5033"},
        {"Geneva Identification System", "GEN# +1.00101470"},
        {"Smithsonian Astrophysical Observation", "SAO 118986"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17324515),
        dec: Angle.Degrees(+08.67222623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149433"},
        {"Hipparcos Number", "HIP 81150"},
        {"Smithsonian Astrophysical Observation", "SAO 121703"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.61544361),
        dec: Angle.Degrees(+08.67399124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16550 A"},
        {"Henry Draper", "HD 218634"},
        {"Hipparcos Number", "HIP 114347"},
        {"Geneva Identification System", "GEN# +1.00218634"},
        {"Smithsonian Astrophysical Observation", "SAO 128001"},
        {"Wilson Evans Batten Catalogue", "WEB 20301"},
    },
    visualMagnitude: 5.05,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.38106177),
        dec: Angle.Degrees(+08.67717165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67180"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.51303160),
        dec: Angle.Degrees(+08.67761610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21776"},
        {"Renson", "Renson 7620"},
    },
    visualMagnitude: 12.60,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.16388265),
        dec: Angle.Degrees(+08.67928567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110365"},
        {"Smithsonian Astrophysical Observation", "SAO 127468"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.30134294),
        dec: Angle.Degrees(+08.68164332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89309"},
        {"Hipparcos Number", "HIP 50470"},
        {"Smithsonian Astrophysical Observation", "SAO 118211"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.57987981),
        dec: Angle.Degrees(+08.68229229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73626"},
        {"Geneva Identification System", "GEN# +9.80066055"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.75276252),
        dec: Angle.Degrees(+08.68555930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -510.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107034"},
        {"Hipparcos Number", "HIP 60015"},
        {"Smithsonian Astrophysical Observation", "SAO 119319"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.62129186),
        dec: Angle.Degrees(+08.68573689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124475"},
        {"Hipparcos Number", "HIP 69505"},
        {"Smithsonian Astrophysical Observation", "SAO 120352"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.43407470),
        dec: Angle.Degrees(+08.68733515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45513"},
        {"Hipparcos Number", "HIP 30792"},
        {"Smithsonian Astrophysical Observation", "SAO 113924"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.05179307),
        dec: Angle.Degrees(+08.68794988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118305"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.93642583),
        dec: Angle.Degrees(+08.68917169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177958"},
        {"Hipparcos Number", "HIP 93824"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.60410868),
        dec: Angle.Degrees(+08.69024964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168040"},
        {"Hipparcos Number", "HIP 89636"},
        {"Smithsonian Astrophysical Observation", "SAO 123331"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.39436582),
        dec: Angle.Degrees(+08.69328442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48498"},
        {"Smithsonian Astrophysical Observation", "SAO 117974"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.35820040),
        dec: Angle.Degrees(+08.69424744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148149"},
        {"Hipparcos Number", "HIP 80481"},
        {"Smithsonian Astrophysical Observation", "SAO 121589"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43152293),
        dec: Angle.Degrees(+08.69654676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198367"},
        {"Hipparcos Number", "HIP 102795"},
        {"Geneva Identification System", "GEN# +1.00198367"},
        {"Smithsonian Astrophysical Observation", "SAO 126257"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.38644331),
        dec: Angle.Degrees(+08.69668434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63801"},
        {"Smithsonian Astrophysical Observation", "SAO 119755"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.15159934),
        dec: Angle.Degrees(+08.69952341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20665"},
        {"Hipparcos Number", "HIP 15515"},
        {"Geneva Identification System", "GEN# +1.00020665"},
        {"Smithsonian Astrophysical Observation", "SAO 111128"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.98342918),
        dec: Angle.Degrees(+08.69978491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36914"},
        {"Hipparcos Number", "HIP 26223"},
        {"Smithsonian Astrophysical Observation", "SAO 112927"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.81943083),
        dec: Angle.Degrees(+08.70076282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11751 A"},
        {"Henry Draper", "HD 174571"},
        {"Hipparcos Number", "HIP 92477"},
        {"Geneva Identification System", "GEN# +1.00174571"},
        {"Smithsonian Astrophysical Observation", "SAO 123966"},
        {"Wilson Evans Batten Catalogue", "WEB 15980"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.69656407),
        dec: Angle.Degrees(+08.70280499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12908"},
        {"Hipparcos Number", "HIP 9838"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.64710980),
        dec: Angle.Degrees(+08.70381322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179340"},
        {"Hipparcos Number", "HIP 94319"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.96071217),
        dec: Angle.Degrees(+08.70520593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163114"},
        {"Hipparcos Number", "HIP 87652"},
        {"Smithsonian Astrophysical Observation", "SAO 122904"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55576245),
        dec: Angle.Degrees(+08.70716214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120542"},
        {"Hipparcos Number", "HIP 67500"},
        {"Smithsonian Astrophysical Observation", "SAO 120131"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.48963192),
        dec: Angle.Degrees(+08.70874795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94317"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.95857084),
        dec: Angle.Degrees(+08.71090369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42908"},
        {"Hipparcos Number", "HIP 29563"},
        {"Celescope Catalog", "CEL 1127"},
        {"Geneva Identification System", "GEN# +1.00042908"},
        {"Smithsonian Astrophysical Observation", "SAO 113604"},
        {"Wilson Evans Batten Catalogue", "WEB 5811"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42574574),
        dec: Angle.Degrees(+08.71239462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221694"},
        {"Hipparcos Number", "HIP 116332"},
        {"Smithsonian Astrophysical Observation", "SAO 128258"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58334949),
        dec: Angle.Degrees(+08.71315112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4015"},
        {"Hipparcos Number", "HIP 3364"},
        {"Smithsonian Astrophysical Observation", "SAO 109398"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.70400190),
        dec: Angle.Degrees(+08.71485060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191769"},
        {"Hipparcos Number", "HIP 99477"},
        {"Smithsonian Astrophysical Observation", "SAO 125536"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.83579505),
        dec: Angle.Degrees(+08.71716787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105846"},
        {"Hipparcos Number", "HIP 59390"},
        {"Smithsonian Astrophysical Observation", "SAO 119256"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75661594),
        dec: Angle.Degrees(+08.71746640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164044"},
        {"Hipparcos Number", "HIP 88045"},
        {"Smithsonian Astrophysical Observation", "SAO 122980"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.74514776),
        dec: Angle.Degrees(+08.71899268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218918"},
        {"Hipparcos Number", "HIP 114520"},
        {"Fundamental Katalog 5th Edition", "FK5 1606"},
        {"Geneva Identification System", "GEN# +1.00218918"},
        {"Smithsonian Astrophysical Observation", "SAO 128022"},
        {"Wilson Evans Batten Catalogue", "WEB 20323"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.93414513),
        dec: Angle.Degrees(+08.72012785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19912"},
        {"Geneva Identification System", "GEN# +0.00800659"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.07760579),
        dec: Angle.Degrees(+08.72019341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223793"},
        {"Hipparcos Number", "HIP 117740"},
        {"Smithsonian Astrophysical Observation", "SAO 128433"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.17849665),
        dec: Angle.Degrees(+08.72049129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64686"},
        {"Hipparcos Number", "HIP 38708"},
        {"Smithsonian Astrophysical Observation", "SAO 116119"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.87788715),
        dec: Angle.Degrees(+08.72158968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15043"},
        {"Hipparcos Number", "HIP 11314"},
        {"Smithsonian Astrophysical Observation", "SAO 110525"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.40733690),
        dec: Angle.Degrees(+08.72167402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117522"},
        {"Geneva Identification System", "GEN# +9.80029071"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.50476744),
        dec: Angle.Degrees(+08.72326957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 368.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175013"},
        {"Hipparcos Number", "HIP 92675"},
        {"Smithsonian Astrophysical Observation", "SAO 124005"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25862720),
        dec: Angle.Degrees(+08.72391000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84389"},
        {"Hipparcos Number", "HIP 47852"},
        {"Geneva Identification System", "GEN# +1.00084389"},
        {"Smithsonian Astrophysical Observation", "SAO 117889"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31135981),
        dec: Angle.Degrees(+08.72428035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189600"},
        {"Hipparcos Number", "HIP 98487"},
        {"Smithsonian Astrophysical Observation", "SAO 125345"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.12223652),
        dec: Angle.Degrees(+08.72560918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78940"},
        {"Hipparcos Number", "HIP 45093"},
        {"Smithsonian Astrophysical Observation", "SAO 117480"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.78204912),
        dec: Angle.Degrees(+08.72622055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186535"},
        {"Hipparcos Number", "HIP 97144"},
        {"Geneva Identification System", "GEN# +1.00186535"},
        {"Smithsonian Astrophysical Observation", "SAO 125011"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.17197869),
        dec: Angle.Degrees(+08.72658032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1850"},
        {"Hipparcos Number", "HIP 1816"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.75366091),
        dec: Angle.Degrees(+08.73184010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172401"},
        {"Hipparcos Number", "HIP 91503"},
        {"Geneva Identification System", "GEN# +1.00172401"},
        {"Smithsonian Astrophysical Observation", "SAO 123779"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.91535471),
        dec: Angle.Degrees(+08.73283700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104979"},
        {"Hipparcos Number", "HIP 58948"},
        {"Fundamental Katalog 5th Edition", "FK5 450"},
        {"Geneva Identification System", "GEN# +1.00104979"},
        {"Smithsonian Astrophysical Observation", "SAO 119213"},
        {"Wilson Evans Batten Catalogue", "WEB 10494"},
    },
    visualMagnitude: 4.12,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.30279000),
        dec: Angle.Degrees(+08.73284563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165760"},
        {"Hipparcos Number", "HIP 88765"},
        {"Geneva Identification System", "GEN# +1.00165760"},
        {"Smithsonian Astrophysical Observation", "SAO 123140"},
        {"Wilson Evans Batten Catalogue", "WEB 15037"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.82647643),
        dec: Angle.Degrees(+08.73379361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139342"},
        {"Hipparcos Number", "HIP 76488"},
        {"Geneva Identification System", "GEN# +1.00139342"},
        {"Smithsonian Astrophysical Observation", "SAO 121094"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.34015575),
        dec: Angle.Degrees(+08.73550961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212526"},
        {"Hipparcos Number", "HIP 110645"},
        {"Smithsonian Astrophysical Observation", "SAO 127513"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.21380350),
        dec: Angle.Degrees(+08.73664705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160310"},
        {"Hipparcos Number", "HIP 86364"},
        {"Smithsonian Astrophysical Observation", "SAO 122601"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.71474216),
        dec: Angle.Degrees(+08.73732992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31641"},
        {"Hipparcos Number", "HIP 23075"},
        {"Celescope Catalog", "CEL 498"},
        {"Geneva Identification System", "GEN# +1.00031641"},
        {"Smithsonian Astrophysical Observation", "SAO 112266"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.47281938),
        dec: Angle.Degrees(+08.73739673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83646"},
        {"Hipparcos Number", "HIP 47447"},
        {"Smithsonian Astrophysical Observation", "SAO 117837"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.04699156),
        dec: Angle.Degrees(+08.73802625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40911"},
        {"Smithsonian Astrophysical Observation", "SAO 116652"},
    },
    visualMagnitude: 10.65,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.23213952),
        dec: Angle.Degrees(+08.74270310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58299"},
        {"Hipparcos Number", "HIP 36005"},
        {"Smithsonian Astrophysical Observation", "SAO 115413"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.30805379),
        dec: Angle.Degrees(+08.74306230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42217"},
        {"Hipparcos Number", "HIP 29235"},
        {"Smithsonian Astrophysical Observation", "SAO 113525"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.45330696),
        dec: Angle.Degrees(+08.74450588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51074"},
        {"Hipparcos Number", "HIP 33353"},
        {"Smithsonian Astrophysical Observation", "SAO 114642"},
        {"Wilson Evans Batten Catalogue", "WEB 6702"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.05689199),
        dec: Angle.Degrees(+08.74534986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79905"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.64667387),
        dec: Angle.Degrees(+08.74705808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185310"},
        {"Hipparcos Number", "HIP 96593"},
        {"Geneva Identification System", "GEN# +1.00185310"},
        {"Smithsonian Astrophysical Observation", "SAO 124875"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54761515),
        dec: Angle.Degrees(+08.74800309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196911"},
        {"Hipparcos Number", "HIP 101981"},
        {"Smithsonian Astrophysical Observation", "SAO 126083"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.00479664),
        dec: Angle.Degrees(+08.74948271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56217"},
        {"Smithsonian Astrophysical Observation", "SAO 118903"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.86534641),
        dec: Angle.Degrees(+08.75003004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217443"},
        {"Hipparcos Number", "HIP 113608"},
        {"Smithsonian Astrophysical Observation", "SAO 127890"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15457776),
        dec: Angle.Degrees(+08.75045504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176916"},
        {"Hipparcos Number", "HIP 93471"},
        {"Smithsonian Astrophysical Observation", "SAO 124181"},
        {"Wilson Evans Batten Catalogue", "WEB 16224"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.53983437),
        dec: Angle.Degrees(+08.75331493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6088 A"},
        {"Henry Draper", "HD 58782"},
        {"Hipparcos Number", "HIP 36205"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.84477605),
        dec: Angle.Degrees(+08.75388278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136079"},
        {"Hipparcos Number", "HIP 74903"},
        {"Smithsonian Astrophysical Observation", "SAO 120941"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.61257720),
        dec: Angle.Degrees(+08.75648996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247555"},
        {"Hipparcos Number", "HIP 27268"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69190806),
        dec: Angle.Degrees(+08.75754018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85016"},
        {"Smithsonian Astrophysical Observation", "SAO 122328"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.64156457),
        dec: Angle.Degrees(+08.75814328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38096"},
        {"Hipparcos Number", "HIP 26984"},
        {"Geneva Identification System", "GEN# +1.00038096"},
        {"Smithsonian Astrophysical Observation", "SAO 113075"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.88478288),
        dec: Angle.Degrees(+08.75841071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176915"},
        {"Hipparcos Number", "HIP 93468"},
        {"Smithsonian Astrophysical Observation", "SAO 124180"},
        {"Wilson Evans Batten Catalogue", "WEB 16221"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.53361957),
        dec: Angle.Degrees(+08.75921528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16786"},
    },
    visualMagnitude: 12.45,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.00136742),
        dec: Angle.Degrees(+08.76013760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10262"},
        {"Hipparcos Number", "HIP 7819"},
        {"Geneva Identification System", "GEN# +1.00010262"},
        {"Smithsonian Astrophysical Observation", "SAO 110046"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.14535993),
        dec: Angle.Degrees(+08.76076486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74900"},
        {"Smithsonian Astrophysical Observation", "SAO 120940"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.60665457),
        dec: Angle.Degrees(+08.76351919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62879"},
        {"Geneva Identification System", "GEN# +0.00902688"},
        {"Smithsonian Astrophysical Observation", "SAO 119647"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.30474552),
        dec: Angle.Degrees(+08.76373153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21438"},
        {"Hipparcos Number", "HIP 16120"},
        {"Geneva Identification System", "GEN# +1.00021438"},
        {"Smithsonian Astrophysical Observation", "SAO 111204"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.91600097),
        dec: Angle.Degrees(+08.76528653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7541"},
        {"Hipparcos Number", "HIP 5888"},
        {"Geneva Identification System", "GEN# +1.00007541"},
        {"Smithsonian Astrophysical Observation", "SAO 109763"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.90467854),
        dec: Angle.Degrees(+08.76792635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87739"},
        {"Hipparcos Number", "HIP 49562"},
        {"Geneva Identification System", "GEN# +1.00087739"},
        {"Smithsonian Astrophysical Observation", "SAO 118113"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78260664),
        dec: Angle.Degrees(+08.76932322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5946"},
        {"Hipparcos Number", "HIP 4752"},
        {"Geneva Identification System", "GEN# +1.00005946"},
        {"Smithsonian Astrophysical Observation", "SAO 109601"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.27277941),
        dec: Angle.Degrees(+08.76958555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15399"},
        {"Hipparcos Number", "HIP 11557"},
        {"Geneva Identification System", "GEN# +1.00015399"},
        {"Smithsonian Astrophysical Observation", "SAO 110556"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.22783786),
        dec: Angle.Degrees(+08.77044138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5855"},
        {"Smithsonian Astrophysical Observation", "SAO 109757"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.77270889),
        dec: Angle.Degrees(+08.77090614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198704"},
        {"Hipparcos Number", "HIP 102986"},
        {"Smithsonian Astrophysical Observation", "SAO 126306"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.98314714),
        dec: Angle.Degrees(+08.77273712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7764 AB"},
        {"Henry Draper", "HD 90303"},
        {"Hipparcos Number", "HIP 51036"},
        {"Smithsonian Astrophysical Observation", "SAO 118292"},
        {"Wilson Evans Batten Catalogue", "WEB 9330"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.39636132),
        dec: Angle.Degrees(+08.77650342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202463"},
        {"Hipparcos Number", "HIP 104977"},
        {"Smithsonian Astrophysical Observation", "SAO 126661"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.94035032),
        dec: Angle.Degrees(+08.77671068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201842"},
        {"Hipparcos Number", "HIP 104663"},
        {"Fundamental Katalog 5th Edition", "FK5 5870"},
        {"Smithsonian Astrophysical Observation", "SAO 126607"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.00492834),
        dec: Angle.Degrees(+08.77735829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169822"},
        {"Hipparcos Number", "HIP 90355"},
        {"Cincinnati Publication", "Ci 20 1088"},
        {"Cincinnati Publication 2", "Ci 18 2420"},
        {"Geneva Identification System", "GEN# +1.00169822"},
        {"Smithsonian Astrophysical Observation", "SAO 123474"},
        {"Wilson Evans Batten Catalogue", "WEB 15467"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.54251193),
        dec: Angle.Degrees(+08.77868888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -458.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5823"},
        {"Smithsonian Astrophysical Observation", "SAO 109750"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.67468805),
        dec: Angle.Degrees(+08.78017633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11640"},
        {"Hipparcos Number", "HIP 8883"},
        {"Fundamental Katalog 5th Edition", "FK5 2128"},
        {"Geneva Identification System", "GEN# +1.00011640"},
        {"Smithsonian Astrophysical Observation", "SAO 110214"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.59226605),
        dec: Angle.Degrees(+08.78104205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8473 A"},
        {"Henry Draper", "HD 106423"},
        {"Hipparcos Number", "HIP 59690"},
        {"Smithsonian Astrophysical Observation", "SAO 119282"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.61372858),
        dec: Angle.Degrees(+08.78270282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105503"},
        {"Smithsonian Astrophysical Observation", "SAO 126738"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.53073298),
        dec: Angle.Degrees(+08.78466831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90254"},
        {"Hipparcos Number", "HIP 51008"},
        {"Fundamental Katalog 5th Edition", "FK5 2835"},
        {"Geneva Identification System", "GEN# +1.00090254"},
        {"Smithsonian Astrophysical Observation", "SAO 118286"},
        {"Wilson Evans Batten Catalogue", "WEB 9328"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.31328707),
        dec: Angle.Degrees(+08.78493853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54805"},
        {"Hipparcos Number", "HIP 34652"},
        {"Smithsonian Astrophysical Observation", "SAO 115032"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.65525518),
        dec: Angle.Degrees(+08.78496057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8473 B"},
        {"Hipparcos Number", "HIP 59687"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.60783330),
        dec: Angle.Degrees(+08.78551908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26"},
        {"Hipparcos Number", "HIP 447"},
        {"Geneva Identification System", "GEN# +1.00000026"},
        {"Smithsonian Astrophysical Observation", "SAO 109003"},
        {"Wilson Evans Batten Catalogue", "WEB 72"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.34190030),
        dec: Angle.Degrees(+08.78795370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 259.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219362"},
        {"Hipparcos Number", "HIP 114784"},
        {"Smithsonian Astrophysical Observation", "SAO 128066"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.77472214),
        dec: Angle.Degrees(+08.78945031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167473"},
        {"Hipparcos Number", "HIP 89433"},
        {"Smithsonian Astrophysical Observation", "SAO 123294"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.79045134),
        dec: Angle.Degrees(+08.78998642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208203"},
        {"Hipparcos Number", "HIP 108143"},
        {"Smithsonian Astrophysical Observation", "SAO 127150"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.64840688),
        dec: Angle.Degrees(+08.79181092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172588"},
        {"Hipparcos Number", "HIP 91594"},
        {"Geneva Identification System", "GEN# +1.00172588"},
        {"Smithsonian Astrophysical Observation", "SAO 123802"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19203724),
        dec: Angle.Degrees(+08.79282063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83100"},
        {"Hipparcos Number", "HIP 47136"},
        {"Smithsonian Astrophysical Observation", "SAO 117800"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.07749110),
        dec: Angle.Degrees(+08.79604944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64514"},
        {"Geneva Identification System", "GEN# +0.00902730"},
        {"Smithsonian Astrophysical Observation", "SAO 119821"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.34670007),
        dec: Angle.Degrees(+08.79635242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109764"},
        {"Hipparcos Number", "HIP 61579"},
        {"Geneva Identification System", "GEN# +1.00109764"},
        {"Renson", "Renson 31823"},
        {"Smithsonian Astrophysical Observation", "SAO 119497"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.28187436),
        dec: Angle.Degrees(+08.79685974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64317"},
        {"Geneva Identification System", "GEN# +0.00902724"},
        {"Smithsonian Astrophysical Observation", "SAO 119802"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.73828178),
        dec: Angle.Degrees(+08.79806551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81462"},
        {"Hipparcos Number", "HIP 46261"},
        {"Smithsonian Astrophysical Observation", "SAO 117684"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.49282391),
        dec: Angle.Degrees(+08.79942223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199666"},
        {"Hipparcos Number", "HIP 103534"},
        {"Geneva Identification System", "GEN# +1.00199666"},
        {"Smithsonian Astrophysical Observation", "SAO 126424"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.63043170),
        dec: Angle.Degrees(+08.80051851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58607"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.27507156),
        dec: Angle.Degrees(+08.80155332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217178"},
        {"Hipparcos Number", "HIP 113453"},
        {"Smithsonian Astrophysical Observation", "SAO 127871"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64941473),
        dec: Angle.Degrees(+08.80553379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2623"},
        {"Hipparcos Number", "HIP 2340"},
        {"Smithsonian Astrophysical Observation", "SAO 109235"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.47570256),
        dec: Angle.Degrees(+08.80624371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84112"},
        {"Hipparcos Number", "HIP 47656"},
        {"Geneva Identification System", "GEN# +1.00084112"},
        {"Smithsonian Astrophysical Observation", "SAO 117869"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.75136852),
        dec: Angle.Degrees(+08.80914372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61094"},
        {"Cincinnati Publication", "Ci 20 713"},
        {"Geneva Identification System", "GEN# +0.00902636"},
        {"Smithsonian Astrophysical Observation", "SAO 119451"},
        {"Wilson Evans Batten Catalogue", "WEB 10877"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.81741889),
        dec: Angle.Degrees(+08.81187017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -636.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -521.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168039"},
        {"Hipparcos Number", "HIP 89640"},
        {"Smithsonian Astrophysical Observation", "SAO 123333"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.40650964),
        dec: Angle.Degrees(+08.81198528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36620"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.95967308),
        dec: Angle.Degrees(+08.81519319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216735"},
        {"Hipparcos Number", "HIP 113186"},
        {"Geneva Identification System", "GEN# +1.00216735"},
        {"Smithsonian Astrophysical Observation", "SAO 127839"},
        {"Wilson Evans Batten Catalogue", "WEB 20144"},
    },
    visualMagnitude: 4.91,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.80676809),
        dec: Angle.Degrees(+08.81609536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81223"},
        {"Cincinnati Publication", "Ci 18 2210"},
        {"Geneva Identification System", "GEN# +0.00903230"},
        {"Smithsonian Astrophysical Observation", "SAO 121716"},
        {"Wilson Evans Batten Catalogue", "WEB 13730"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.84806850),
        dec: Angle.Degrees(+08.81651946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46199"},
        {"Hipparcos Number", "HIP 31155"},
        {"Smithsonian Astrophysical Observation", "SAO 114019"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.07302398),
        dec: Angle.Degrees(+08.81800444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 191 B"},
        {"Henry Draper", "HD 1061B"},
        {"Hipparcos Number", "HIP 1197"},
        {"Geneva Identification System", "GEN# +1.00001061B"},
        {"Smithsonian Astrophysical Observation", "SAO 109088"},
        {"Wilson Evans Batten Catalogue", "WEB 215"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.74665664),
        dec: Angle.Degrees(+08.81833793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35756"},
        {"Geneva Identification System", "GEN# +9.80089014"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.63067922),
        dec: Angle.Degrees(+08.82093581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 191 A"},
        {"Henry Draper", "HD 1061"},
        {"Hipparcos Number", "HIP 1196"},
        {"Geneva Identification System", "GEN# +1.00001061A"},
        {"Smithsonian Astrophysical Observation", "SAO 109087"},
        {"Wilson Evans Batten Catalogue", "WEB 214"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.74492370),
        dec: Angle.Degrees(+08.82102280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6120"},
        {"Hipparcos Number", "HIP 4858"},
        {"Geneva Identification System", "GEN# +1.00006120"},
        {"Smithsonian Astrophysical Observation", "SAO 109618"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.62350389),
        dec: Angle.Degrees(+08.82160415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31489"},
        {"Hipparcos Number", "HIP 22984"},
        {"Celescope Catalog", "CEL 495"},
        {"Geneva Identification System", "GEN# +1.00031489"},
        {"Smithsonian Astrophysical Observation", "SAO 112240"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.18245945),
        dec: Angle.Degrees(+08.82240617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8327 B"},
        {"Henry Draper", "HD 103046"},
        {"Hipparcos Number", "HIP 57856"},
        {"Geneva Identification System", "GEN# +1.00103046"},
        {"Smithsonian Astrophysical Observation", "SAO 119083"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.98557205),
        dec: Angle.Degrees(+08.82276860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162708"},
        {"Hipparcos Number", "HIP 87451"},
        {"Smithsonian Astrophysical Observation", "SAO 122854"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.03020017),
        dec: Angle.Degrees(+08.82295600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150305"},
        {"Hipparcos Number", "HIP 81600"},
        {"Smithsonian Astrophysical Observation", "SAO 121767"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.96488340),
        dec: Angle.Degrees(+08.82326303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121562"},
        {"Hipparcos Number", "HIP 68052"},
        {"Smithsonian Astrophysical Observation", "SAO 120179"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.01319206),
        dec: Angle.Degrees(+08.82327412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34161"},
        {"Hipparcos Number", "HIP 24522"},
        {"Smithsonian Astrophysical Observation", "SAO 112576"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.91432129),
        dec: Angle.Degrees(+08.82352681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211077"},
        {"Hipparcos Number", "HIP 109825"},
        {"Smithsonian Astrophysical Observation", "SAO 127403"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.66319981),
        dec: Angle.Degrees(+08.82443042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131208"},
        {"Hipparcos Number", "HIP 72706"},
        {"Smithsonian Astrophysical Observation", "SAO 120703"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.98284134),
        dec: Angle.Degrees(+08.82541144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259986"},
        {"Hipparcos Number", "HIP 31383"},
        {"Wilson Evans Batten Catalogue", "WEB 6281"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69122815),
        dec: Angle.Degrees(+08.82561983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44611"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.34529419),
        dec: Angle.Degrees(+08.82913852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8625 AB"},
        {"Henry Draper", "HD 110280"},
        {"Hipparcos Number", "HIP 61889"},
        {"Smithsonian Astrophysical Observation", "SAO 119530"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.22561322),
        dec: Angle.Degrees(+08.82942761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8327 A"},
        {"Henry Draper", "HD 103047"},
        {"Hipparcos Number", "HIP 57858"},
        {"Geneva Identification System", "GEN# +1.00103047"},
        {"Smithsonian Astrophysical Observation", "SAO 119084"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.98987355),
        dec: Angle.Degrees(+08.83011587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180353"},
        {"Hipparcos Number", "HIP 94672"},
        {"Smithsonian Astrophysical Observation", "SAO 124446"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.97019116),
        dec: Angle.Degrees(+08.83040761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93567"},
        {"Hipparcos Number", "HIP 52838"},
        {"Smithsonian Astrophysical Observation", "SAO 118502"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.05456397),
        dec: Angle.Degrees(+08.83234316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65686"},
        {"Smithsonian Astrophysical Observation", "SAO 119938"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02034973),
        dec: Angle.Degrees(+08.83235157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91389",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11524 AB"},
        {"Henry Draper", "HD 172171"},
        {"Hipparcos Number", "HIP 91389"},
        {"Geneva Identification System", "GEN# +1.00172171J"},
        {"Smithsonian Astrophysical Observation", "SAO 123744"},
        {"Wilson Evans Batten Catalogue", "WEB 15703"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.58805709),
        dec: Angle.Degrees(+08.83404702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49492"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.56374478),
        dec: Angle.Degrees(+08.83453549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119802"},
        {"Hipparcos Number", "HIP 67105"},
        {"Smithsonian Astrophysical Observation", "SAO 120095"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.31148455),
        dec: Angle.Degrees(+08.83620856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151605"},
        {"Hipparcos Number", "HIP 82234"},
        {"Smithsonian Astrophysical Observation", "SAO 121870"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.01214332),
        dec: Angle.Degrees(+08.83651242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15810"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.91569535),
        dec: Angle.Degrees(+08.83894110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200690"},
        {"Hipparcos Number", "HIP 104052"},
        {"Geneva Identification System", "GEN# +1.00200690"},
        {"Smithsonian Astrophysical Observation", "SAO 126525"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.20590220),
        dec: Angle.Degrees(+08.84020302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149327"},
        {"Hipparcos Number", "HIP 81081"},
        {"Smithsonian Astrophysical Observation", "SAO 121694"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.40929707),
        dec: Angle.Degrees(+08.84038036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7871 AB"},
        {"Henry Draper", "HD 92323"},
        {"Hipparcos Number", "HIP 52187"},
        {"Geneva Identification System", "GEN# +1.00092323"},
        {"Smithsonian Astrophysical Observation", "SAO 118418"},
        {"Wilson Evans Batten Catalogue", "WEB 9510"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.92574481),
        dec: Angle.Degrees(+08.84298799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56271"},
        {"Hipparcos Number", "HIP 35215"},
        {"Geneva Identification System", "GEN# +1.00056271"},
        {"Smithsonian Astrophysical Observation", "SAO 115183"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.16566912),
        dec: Angle.Degrees(+08.84455185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13026"},
        {"Hipparcos Number", "HIP 9915"},
        {"Geneva Identification System", "GEN# +1.00013026"},
        {"Smithsonian Astrophysical Observation", "SAO 110353"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.90624202),
        dec: Angle.Degrees(+08.84623553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13611"},
        {"Hipparcos Number", "HIP 10324"},
        {"Fundamental Katalog 5th Edition", "FK5 1058"},
        {"Geneva Identification System", "GEN# +1.00013611"},
        {"Smithsonian Astrophysical Observation", "SAO 110408"},
        {"Wilson Evans Batten Catalogue", "WEB 2156"},
    },
    visualMagnitude: 4.36,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.25004577),
        dec: Angle.Degrees(+08.84675230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143896"},
        {"Hipparcos Number", "HIP 78571"},
        {"Smithsonian Astrophysical Observation", "SAO 121331"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.65578672),
        dec: Angle.Degrees(+08.84695018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101321"},
        {"Smithsonian Astrophysical Observation", "SAO 125909"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.04382565),
        dec: Angle.Degrees(+08.84779101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140648"},
        {"Hipparcos Number", "HIP 77093"},
        {"Geneva Identification System", "GEN# +1.00140648"},
        {"Smithsonian Astrophysical Observation", "SAO 121160"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.12472881),
        dec: Angle.Degrees(+08.84908177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13091"},
        {"Hipparcos Number", "HIP 9965"},
        {"Smithsonian Astrophysical Observation", "SAO 110359"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.08109562),
        dec: Angle.Degrees(+08.85013214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47219"},
        {"Smithsonian Astrophysical Observation", "SAO 117809"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.35477685),
        dec: Angle.Degrees(+08.85096211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157617"},
        {"Hipparcos Number", "HIP 85139"},
        {"Geneva Identification System", "GEN# +1.00157617"},
        {"Smithsonian Astrophysical Observation", "SAO 122346"},
        {"Wilson Evans Batten Catalogue", "WEB 14377"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99005723),
        dec: Angle.Degrees(+08.85258733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94148"},
        {"Hipparcos Number", "HIP 53126"},
        {"Smithsonian Astrophysical Observation", "SAO 118547"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01780443),
        dec: Angle.Degrees(+08.85284082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29808"},
        {"Hipparcos Number", "HIP 21871"},
        {"Smithsonian Astrophysical Observation", "SAO 111987"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.53710906),
        dec: Angle.Degrees(+08.85295078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218033"},
        {"Hipparcos Number", "HIP 113958"},
        {"Geneva Identification System", "GEN# +1.00218033"},
        {"Smithsonian Astrophysical Observation", "SAO 127949"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.16644357),
        dec: Angle.Degrees(+08.85331855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155645"},
        {"Hipparcos Number", "HIP 84199"},
        {"Smithsonian Astrophysical Observation", "SAO 122180"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.17154329),
        dec: Angle.Degrees(+08.85342405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170632"},
        {"Hipparcos Number", "HIP 90690"},
        {"Smithsonian Astrophysical Observation", "SAO 123578"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.55032029),
        dec: Angle.Degrees(+08.85505879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48234"},
        {"Hipparcos Number", "HIP 32141"},
        {"Smithsonian Astrophysical Observation", "SAO 114305"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.68149661),
        dec: Angle.Degrees(+08.85523340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164309"},
        {"Hipparcos Number", "HIP 88144"},
        {"Geneva Identification System", "GEN# +1.00164309"},
        {"Smithsonian Astrophysical Observation", "SAO 123007"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.05266294),
        dec: Angle.Degrees(+08.85599980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45608"},
        {"Smithsonian Astrophysical Observation", "SAO 117572"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.44897614),
        dec: Angle.Degrees(+08.85666203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74474"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.26609937),
        dec: Angle.Degrees(+08.85812213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9903"},
        {"Hipparcos Number", "HIP 7525"},
        {"Smithsonian Astrophysical Observation", "SAO 110012"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.22112390),
        dec: Angle.Degrees(+08.86109929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164310"},
        {"Hipparcos Number", "HIP 88153"},
        {"Smithsonian Astrophysical Observation", "SAO 123008"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06942655),
        dec: Angle.Degrees(+08.86112536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64685"},
        {"Hipparcos Number", "HIP 38712"},
        {"Geneva Identification System", "GEN# +1.00064685"},
        {"Smithsonian Astrophysical Observation", "SAO 116120"},
        {"Wilson Evans Batten Catalogue", "WEB 7591"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.88099024),
        dec: Angle.Degrees(+08.86305710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88472"},
        {"Smithsonian Astrophysical Observation", "SAO 123075"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.97296872),
        dec: Angle.Degrees(+08.86347255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183303"},
        {"Hipparcos Number", "HIP 95757"},
        {"Geneva Identification System", "GEN# +1.00183303"},
        {"Smithsonian Astrophysical Observation", "SAO 124670"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.14959739),
        dec: Angle.Degrees(+08.86360870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43317",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7021 AB"},
        {"Aitken 2", "ADS 7021"},
        {"Henry Draper", "HD 75300"},
        {"Hipparcos Number", "HIP 43317"},
        {"Smithsonian Astrophysical Observation", "SAO 117168"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.37137594),
        dec: Angle.Degrees(+08.86468046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49429"},
        {"Hipparcos Number", "HIP 32659"},
        {"Smithsonian Astrophysical Observation", "SAO 114449"},
        {"Wilson Evans Batten Catalogue", "WEB 6584"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.18341878),
        dec: Angle.Degrees(+08.86628529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69478"},
        {"Hipparcos Number", "HIP 40617"},
        {"Geneva Identification System", "GEN# +1.00069478"},
        {"Smithsonian Astrophysical Observation", "SAO 116585"},
        {"Wilson Evans Batten Catalogue", "WEB 7897"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.38191524),
        dec: Angle.Degrees(+08.86632545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97649",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Altair"},
        {"Aitken", "ADS 13009 A"},
        {"Henry Draper", "HD 187642"},
        {"Hipparcos Number", "HIP 97649"},
        {"Cincinnati Publication", "Ci 20 1169"},
        {"Fundamental Katalog 5th Edition", "FK5 745"},
        {"Geneva Identification System", "GEN# +1.00187642"},
        {"Smithsonian Astrophysical Observation", "SAO 125122"},
        {"Wilson Evans Batten Catalogue", "WEB 17173"},
    },
    visualMagnitude: 0.76,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69450860),
        dec: Angle.Degrees(+08.86738491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 536.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 385.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172522"},
        {"Hipparcos Number", "HIP 91571"},
        {"Geneva Identification System", "GEN# +1.00172522"},
        {"Smithsonian Astrophysical Observation", "SAO 123793"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.09420561),
        dec: Angle.Degrees(+08.86846785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6567"},
        {"Hipparcos Number", "HIP 5216"},
        {"Smithsonian Astrophysical Observation", "SAO 109678"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.67495966),
        dec: Angle.Degrees(+08.86864832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14603"},
        {"Smithsonian Astrophysical Observation", "SAO 111001"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.13738574),
        dec: Angle.Degrees(+08.86873757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95622"},
        {"Hipparcos Number", "HIP 53943"},
        {"Geneva Identification System", "GEN# +1.00095622"},
        {"Smithsonian Astrophysical Observation", "SAO 118624"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.56389304),
        dec: Angle.Degrees(+08.86969226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181803"},
        {"Hipparcos Number", "HIP 95152"},
        {"Geneva Identification System", "GEN# +1.00181803"},
        {"Smithsonian Astrophysical Observation", "SAO 124547"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.39465663),
        dec: Angle.Degrees(+08.87295247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3335"},
        {"Hipparcos Number", "HIP 2873"},
        {"Geneva Identification System", "GEN# +1.00003335"},
        {"Smithsonian Astrophysical Observation", "SAO 109308"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.10127728),
        dec: Angle.Degrees(+08.87418627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165670"},
        {"Hipparcos Number", "HIP 88728"},
        {"Geneva Identification System", "GEN# +1.00165670"},
        {"Smithsonian Astrophysical Observation", "SAO 123133"},
        {"Wilson Evans Batten Catalogue", "WEB 15032"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.71147382),
        dec: Angle.Degrees(+08.87630459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 238 ABC"},
        {"Henry Draper", "HD 1317"},
        {"Hipparcos Number", "HIP 1392"},
        {"Geneva Identification System", "GEN# +1.00001317"},
        {"Smithsonian Astrophysical Observation", "SAO 109111"},
        {"Wilson Evans Batten Catalogue", "WEB 252"},
        {"Wilson Evans Batten Catalogue 2", "WEB 255"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.35209754),
        dec: Angle.Degrees(+08.87633388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50975"},
        {"Hipparcos Number", "HIP 33317"},
        {"Geneva Identification System", "GEN# +1.00050975"},
        {"Smithsonian Astrophysical Observation", "SAO 114633"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.95097602),
        dec: Angle.Degrees(+08.87742954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134113"},
        {"Hipparcos Number", "HIP 74033"},
        {"Cincinnati Publication", "Ci 20 908"},
        {"Fundamental Katalog 5th Edition", "FK5 5342"},
        {"Geneva Identification System", "GEN# +1.00134113"},
        {"Smithsonian Astrophysical Observation", "SAO 120853"},
        {"Wilson Evans Batten Catalogue", "WEB 12644"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.94502406),
        dec: Angle.Degrees(+08.87991515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -518.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1801 AB"},
        {"Henry Draper", "HD 14562"},
        {"Hipparcos Number", "HIP 10975"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.34217297),
        dec: Angle.Degrees(+08.88072174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73094"},
        {"Geneva Identification System", "GEN# +9.80066043"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.07040096),
        dec: Angle.Degrees(+08.88195631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -260.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25477"},
        {"Hipparcos Number", "HIP 18911"},
        {"Smithsonian Astrophysical Observation", "SAO 111578"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.79408026),
        dec: Angle.Degrees(+08.88262874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7508 A"},
        {"Henry Draper", "HD 84407"},
        {"Hipparcos Number", "HIP 47862"},
        {"Geneva Identification System", "GEN# +1.00084407"},
        {"Smithsonian Astrophysical Observation", "SAO 117890"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31995804),
        dec: Angle.Degrees(+08.88281942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116289"},
        {"Hipparcos Number", "HIP 65263"},
        {"Geneva Identification System", "GEN# +1.00116289"},
        {"Smithsonian Astrophysical Observation", "SAO 119907"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.62213159),
        dec: Angle.Degrees(+08.88303471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101112"},
        {"Hipparcos Number", "HIP 56756"},
        {"Geneva Identification System", "GEN# +1.00101112"},
        {"Smithsonian Astrophysical Observation", "SAO 118961"},
        {"Wilson Evans Batten Catalogue", "WEB 10211"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.54110656),
        dec: Angle.Degrees(+08.88377717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72281"},
        {"Hipparcos Number", "HIP 41872"},
        {"Geneva Identification System", "GEN# +1.00072281"},
        {"Smithsonian Astrophysical Observation", "SAO 116868"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.06893416),
        dec: Angle.Degrees(+08.88438776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44783"},
        {"Hipparcos Number", "HIP 30448"},
        {"Celescope Catalog", "CEL 1216"},
        {"Geneva Identification System", "GEN# +1.00044783"},
        {"Smithsonian Astrophysical Observation", "SAO 113817"},
        {"Wilson Evans Batten Catalogue", "WEB 6059"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00954036),
        dec: Angle.Degrees(+08.88503625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22354"},
        {"Hipparcos Number", "HIP 16796"},
        {"Smithsonian Astrophysical Observation", "SAO 111283"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.04878700),
        dec: Angle.Degrees(+08.88647898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70475"},
        {"Geneva Identification System", "GEN# +9.80065049"},
    },
    visualMagnitude: 12.23,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.23192023),
        dec: Angle.Degrees(+08.88723465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 546.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6006"},
        {"Smithsonian Astrophysical Observation", "SAO 109784"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.31227547),
        dec: Angle.Degrees(+08.88836496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3063 A"},
        {"Henry Draper", "HD 26677"},
        {"Hipparcos Number", "HIP 19718"},
        {"Geneva Identification System", "GEN# +1.00026677A"},
        {"Renson", "Renson 6820"},
        {"Smithsonian Astrophysical Observation", "SAO 111671"},
        {"Wilson Evans Batten Catalogue", "WEB 3759"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.38019244),
        dec: Angle.Degrees(+08.89035537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26912"},
        {"Hipparcos Number", "HIP 19860"},
        {"Fundamental Katalog 5th Edition", "FK5 1118"},
        {"Geneva Identification System", "GEN# +1.00026912"},
        {"Smithsonian Astrophysical Observation", "SAO 111696"},
        {"Wilson Evans Batten Catalogue", "WEB 3793"},
    },
    visualMagnitude: 4.27,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.88352173),
        dec: Angle.Degrees(+08.89240989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115680"},
        {"Geneva Identification System", "GEN# +9.80029033"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.55025000),
        dec: Angle.Degrees(+08.89331651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 519.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75409"},
        {"Smithsonian Astrophysical Observation", "SAO 120984"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.11809149),
        dec: Angle.Degrees(+08.89376918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122365"},
        {"Hipparcos Number", "HIP 68498"},
        {"Fundamental Katalog 5th Edition", "FK5 3114"},
        {"Geneva Identification System", "GEN# +1.00122365"},
        {"Smithsonian Astrophysical Observation", "SAO 120228"},
        {"Wilson Evans Batten Catalogue", "WEB 11999"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.33504074),
        dec: Angle.Degrees(+08.89490924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218189"},
        {"Hipparcos Number", "HIP 114053"},
        {"Smithsonian Astrophysical Observation", "SAO 127964"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.46686962),
        dec: Angle.Degrees(+08.89603461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210224"},
        {"Hipparcos Number", "HIP 109314"},
        {"Smithsonian Astrophysical Observation", "SAO 127322"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.19219583),
        dec: Angle.Degrees(+08.89697117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35915"},
        {"Wilson Evans Batten Catalogue", "WEB 7153"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.05832404),
        dec: Angle.Degrees(+08.89773196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39201"},
        {"Hipparcos Number", "HIP 27648"},
        {"Geneva Identification System", "GEN# +1.00039201"},
        {"Smithsonian Astrophysical Observation", "SAO 113205"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.79819179),
        dec: Angle.Degrees(+08.89858600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108505"},
        {"Hipparcos Number", "HIP 60815"},
        {"Geneva Identification System", "GEN# +1.00108505"},
        {"Smithsonian Astrophysical Observation", "SAO 119414"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.97370153),
        dec: Angle.Degrees(+08.89861056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17422"},
        {"Hipparcos Number", "HIP 13068"},
        {"Smithsonian Astrophysical Observation", "SAO 110753"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.99554926),
        dec: Angle.Degrees(+08.89918948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63615"},
        {"Hipparcos Number", "HIP 38243"},
        {"Smithsonian Astrophysical Observation", "SAO 115993"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.51727114),
        dec: Angle.Degrees(+08.90011278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30739"},
        {"Hipparcos Number", "HIP 22509"},
        {"Celescope Catalog", "CEL 472"},
        {"Geneva Identification System", "GEN# +1.00030739"},
        {"Smithsonian Astrophysical Observation", "SAO 112124"},
        {"Wilson Evans Batten Catalogue", "WEB 4343"},
    },
    visualMagnitude: 4.35,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.65300943),
        dec: Angle.Degrees(+08.90025258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163334"},
        {"Hipparcos Number", "HIP 87740"},
        {"Smithsonian Astrophysical Observation", "SAO 122919"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.84432917),
        dec: Angle.Degrees(+08.90080177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35750"},
        {"Geneva Identification System", "GEN# +0.00901627"},
        {"Smithsonian Astrophysical Observation", "SAO 115345"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.61085605),
        dec: Angle.Degrees(+08.90277507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -315.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92994"},
        {"Hipparcos Number", "HIP 52528"},
        {"Smithsonian Astrophysical Observation", "SAO 118462"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.10184269),
        dec: Angle.Degrees(+08.90312654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161551"},
        {"Hipparcos Number", "HIP 86940"},
        {"Geneva Identification System", "GEN# +1.00161551"},
        {"Smithsonian Astrophysical Observation", "SAO 122717"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.47583470),
        dec: Angle.Degrees(+08.90511077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137127"},
        {"Hipparcos Number", "HIP 75361"},
        {"Smithsonian Astrophysical Observation", "SAO 120977"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.00045727),
        dec: Angle.Degrees(+08.90580927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143176"},
        {"Hipparcos Number", "HIP 78240"},
        {"Smithsonian Astrophysical Observation", "SAO 121288"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63461269),
        dec: Angle.Degrees(+08.90597016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30365"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.79438197),
        dec: Angle.Degrees(+08.90720423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256294"},
        {"Hipparcos Number", "HIP 30362"},
        {"Smithsonian Astrophysical Observation", "SAO 113796"},
    },
    visualMagnitude: 9.73,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78819358),
        dec: Angle.Degrees(+08.90723904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18604"},
        {"Hipparcos Number", "HIP 13954"},
        {"Fundamental Katalog 5th Edition", "FK5 1083"},
        {"Geneva Identification System", "GEN# +1.00018604"},
        {"Smithsonian Astrophysical Observation", "SAO 110889"},
        {"Wilson Evans Batten Catalogue", "WEB 2752"},
    },
    visualMagnitude: 4.71,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.92873469),
        dec: Angle.Degrees(+08.90740111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202866"},
        {"Hipparcos Number", "HIP 105188"},
        {"Smithsonian Astrophysical Observation", "SAO 126698"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61547483),
        dec: Angle.Degrees(+08.90749790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209616"},
        {"Hipparcos Number", "HIP 108973"},
        {"Geneva Identification System", "GEN# +1.00209616"},
        {"Smithsonian Astrophysical Observation", "SAO 127268"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.14638824),
        dec: Angle.Degrees(+08.91283603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34366"},
        {"Hipparcos Number", "HIP 24637"},
        {"Geneva Identification System", "GEN# +1.00034366"},
        {"Smithsonian Astrophysical Observation", "SAO 112595"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.29918081),
        dec: Angle.Degrees(+08.91324228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136497"},
        {"Hipparcos Number", "HIP 75096"},
        {"Geneva Identification System", "GEN# +1.00136497"},
        {"Smithsonian Astrophysical Observation", "SAO 120953"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.17944320),
        dec: Angle.Degrees(+08.91380229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66011"},
        {"Hipparcos Number", "HIP 39271"},
        {"Fundamental Katalog 5th Edition", "FK5 2621"},
        {"Geneva Identification System", "GEN# +1.00066011"},
        {"Smithsonian Astrophysical Observation", "SAO 116251"},
        {"Wilson Evans Batten Catalogue", "WEB 7696"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.46137519),
        dec: Angle.Degrees(+08.91393208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109284"},
        {"Hipparcos Number", "HIP 61297"},
        {"Smithsonian Astrophysical Observation", "SAO 119467"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39446588),
        dec: Angle.Degrees(+08.91764083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220033"},
        {"Hipparcos Number", "HIP 115242"},
        {"Smithsonian Astrophysical Observation", "SAO 128130"},
        {"Wilson Evans Batten Catalogue", "WEB 20414"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.13593917),
        dec: Angle.Degrees(+08.91897626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17487"},
        {"Hipparcos Number", "HIP 13110"},
        {"Smithsonian Astrophysical Observation", "SAO 110764"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.14163174),
        dec: Angle.Degrees(+08.91982585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16500"},
        {"Hipparcos Number", "HIP 12348"},
        {"Smithsonian Astrophysical Observation", "SAO 110658"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.74809198),
        dec: Angle.Degrees(+08.91996663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195490"},
        {"Hipparcos Number", "HIP 101255"},
        {"Geneva Identification System", "GEN# +1.00195490"},
        {"Renson", "Renson 54480"},
        {"Smithsonian Astrophysical Observation", "SAO 125894"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.86965124),
        dec: Angle.Degrees(+08.92104004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128662"},
        {"Hipparcos Number", "HIP 71545"},
        {"Smithsonian Astrophysical Observation", "SAO 120576"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.49940103),
        dec: Angle.Degrees(+08.92266213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115994"},
        {"Hipparcos Number", "HIP 65115"},
        {"Geneva Identification System", "GEN# +1.00115994"},
        {"Smithsonian Astrophysical Observation", "SAO 119888"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.16161183),
        dec: Angle.Degrees(+08.92298367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99268"},
        {"Hipparcos Number", "HIP 55757"},
        {"Smithsonian Astrophysical Observation", "SAO 118843"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.37385303),
        dec: Angle.Degrees(+08.92327001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68527"},
        {"Cincinnati Publication", "Ci 20 828"},
        {"Wilson Evans Batten Catalogue", "WEB 12003"},
    },
    visualMagnitude: 11.57,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43494415),
        dec: Angle.Degrees(+08.92332937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -749.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212861"},
        {"Hipparcos Number", "HIP 110826"},
        {"Geneva Identification System", "GEN# +1.00212861"},
        {"Smithsonian Astrophysical Observation", "SAO 127535"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.79048026),
        dec: Angle.Degrees(+08.92419274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157823"},
        {"Hipparcos Number", "HIP 85259"},
        {"Smithsonian Astrophysical Observation", "SAO 122366"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.32830548),
        dec: Angle.Degrees(+08.92480291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6100 A"},
        {"Henry Draper", "HD 58972"},
        {"Hipparcos Number", "HIP 36284"},
        {"Geneva Identification System", "GEN# +1.00058972"},
        {"Smithsonian Astrophysical Observation", "SAO 115478"},
        {"Wilson Evans Batten Catalogue", "WEB 7226"},
    },
    visualMagnitude: 4.33,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.04095607),
        dec: Angle.Degrees(+08.92550376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99793"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.70901954),
        dec: Angle.Degrees(+08.92574443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61340"},
        {"Hipparcos Number", "HIP 37258"},
        {"Geneva Identification System", "GEN# +1.00061340"},
        {"Smithsonian Astrophysical Observation", "SAO 115748"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.77488580),
        dec: Angle.Degrees(+08.92622484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220737"},
        {"Hipparcos Number", "HIP 115674"},
        {"Smithsonian Astrophysical Observation", "SAO 128179"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.53564232),
        dec: Angle.Degrees(+08.92967025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 896"},
        {"Hipparcos Number", "HIP 1073"},
        {"Geneva Identification System", "GEN# +1.00000896"},
        {"Smithsonian Astrophysical Observation", "SAO 109069"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.33060043),
        dec: Angle.Degrees(+08.92988028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206527"},
        {"Hipparcos Number", "HIP 107169"},
        {"Smithsonian Astrophysical Observation", "SAO 127006"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.61894006),
        dec: Angle.Degrees(+08.93110827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21015"},
        {"Smithsonian Astrophysical Observation", "SAO 111855"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.59540626),
        dec: Angle.Degrees(+08.93182327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66218"},
        {"Smithsonian Astrophysical Observation", "SAO 120010"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.57664223),
        dec: Angle.Degrees(+08.93236875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86080"},
        {"Hipparcos Number", "HIP 48734"},
        {"Fundamental Katalog 5th Edition", "FK5 2794"},
        {"Geneva Identification System", "GEN# +1.00086080"},
        {"Smithsonian Astrophysical Observation", "SAO 118001"},
        {"Wilson Evans Batten Catalogue", "WEB 9063"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.10844321),
        dec: Angle.Degrees(+08.93310774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74427"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.16876288),
        dec: Angle.Degrees(+08.93470820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122082"},
        {"Hipparcos Number", "HIP 68353"},
        {"Smithsonian Astrophysical Observation", "SAO 120209"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.87387729),
        dec: Angle.Degrees(+08.93837123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147548"},
        {"Hipparcos Number", "HIP 80188"},
        {"Geneva Identification System", "GEN# +1.00147548"},
        {"Smithsonian Astrophysical Observation", "SAO 121548"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.56638524),
        dec: Angle.Degrees(+08.93897921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17613"},
        {"Hipparcos Number", "HIP 13199"},
        {"Smithsonian Astrophysical Observation", "SAO 110777"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.46811561),
        dec: Angle.Degrees(+08.93967875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88330"},
        {"Hipparcos Number", "HIP 49895"},
        {"Smithsonian Astrophysical Observation", "SAO 118152"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.81118290),
        dec: Angle.Degrees(+08.94103925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101744"},
        {"Smithsonian Astrophysical Observation", "SAO 126025"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.32070354),
        dec: Angle.Degrees(+08.94138865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32660"},
        {"Hipparcos Number", "HIP 23666"},
        {"Celescope Catalog", "CEL 528"},
        {"Geneva Identification System", "GEN# +1.00032660"},
        {"Smithsonian Astrophysical Observation", "SAO 112400"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.30436886),
        dec: Angle.Degrees(+08.94214960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173835"},
        {"Hipparcos Number", "HIP 92163"},
        {"Smithsonian Astrophysical Observation", "SAO 123915"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.75700297),
        dec: Angle.Degrees(+08.94291885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86794"},
        {"Hipparcos Number", "HIP 49080"},
        {"Geneva Identification System", "GEN# +1.00086794"},
        {"Smithsonian Astrophysical Observation", "SAO 118051"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.25281500),
        dec: Angle.Degrees(+08.94923390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37232"},
        {"Hipparcos Number", "HIP 26414"},
        {"Celescope Catalog", "CEL 863"},
        {"Geneva Identification System", "GEN# +1.00037232"},
        {"Smithsonian Astrophysical Observation", "SAO 112966"},
        {"Wilson Evans Batten Catalogue", "WEB 5210"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.33046034),
        dec: Angle.Degrees(+08.95188007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153738"},
        {"Hipparcos Number", "HIP 83253"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.23813938),
        dec: Angle.Degrees(+08.95361283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23644"},
        {"Hipparcos Number", "HIP 17670"},
        {"Geneva Identification System", "GEN# +1.00023644"},
        {"Smithsonian Astrophysical Observation", "SAO 111416"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.76498299),
        dec: Angle.Degrees(+08.95482354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40602"},
        {"Hipparcos Number", "HIP 28432"},
        {"Geneva Identification System", "GEN# +1.00040602"},
        {"Renson", "Renson 10860"},
        {"Smithsonian Astrophysical Observation", "SAO 113344"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.06483685),
        dec: Angle.Degrees(+08.95622561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224995"},
        {"Hipparcos Number", "HIP 186"},
        {"Geneva Identification System", "GEN# +1.00224995"},
        {"Smithsonian Astrophysical Observation", "SAO 128544"},
        {"Wilson Evans Batten Catalogue", "WEB 32"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.60069792),
        dec: Angle.Degrees(+08.95683360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134012"},
        {"Hipparcos Number", "HIP 73998"},
        {"Smithsonian Astrophysical Observation", "SAO 120847"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.83032211),
        dec: Angle.Degrees(+08.95854292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66301"},
        {"Smithsonian Astrophysical Observation", "SAO 120023"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.82311552),
        dec: Angle.Degrees(+08.95885239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202884"},
        {"Hipparcos Number", "HIP 105202"},
        {"Fundamental Katalog 5th Edition", "FK5 5880"},
        {"Geneva Identification System", "GEN# +1.00202884"},
        {"Smithsonian Astrophysical Observation", "SAO 126700"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.65455595),
        dec: Angle.Degrees(+08.95975955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12253"},
        {"Smithsonian Astrophysical Observation", "SAO 110650"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.44220051),
        dec: Angle.Degrees(+08.96087758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217855"},
        {"Hipparcos Number", "HIP 113859"},
        {"Geneva Identification System", "GEN# +1.00217855"},
        {"Smithsonian Astrophysical Observation", "SAO 127929"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.87149985),
        dec: Angle.Degrees(+08.96223865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192895"},
        {"Hipparcos Number", "HIP 99985"},
        {"Geneva Identification System", "GEN# +1.00192895"},
        {"Smithsonian Astrophysical Observation", "SAO 125647"},
        {"Wilson Evans Batten Catalogue", "WEB 17993"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.25188501),
        dec: Angle.Degrees(+08.96320144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219081"},
        {"Hipparcos Number", "HIP 114608"},
        {"Smithsonian Astrophysical Observation", "SAO 128037"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.27093740),
        dec: Angle.Degrees(+08.96344879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213448"},
        {"Hipparcos Number", "HIP 111177"},
        {"Smithsonian Astrophysical Observation", "SAO 127575"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84070564),
        dec: Angle.Degrees(+08.96417999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89848"},
        {"Hipparcos Number", "HIP 50792"},
        {"Smithsonian Astrophysical Observation", "SAO 118260"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.55911322),
        dec: Angle.Degrees(+08.96439164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105852"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.58831119),
        dec: Angle.Degrees(+08.96895718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108384"},
        {"Hipparcos Number", "HIP 60754"},
        {"Smithsonian Astrophysical Observation", "SAO 119402"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.76268514),
        dec: Angle.Degrees(+08.96908978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183162"},
        {"Hipparcos Number", "HIP 95696"},
        {"Geneva Identification System", "GEN# +1.00183162"},
        {"Smithsonian Astrophysical Observation", "SAO 124653"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.96548212),
        dec: Angle.Degrees(+08.96946180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22857"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.76658165),
        dec: Angle.Degrees(+08.96984364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70152"},
        {"Geneva Identification System", "GEN# +0.00902879"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.30972794),
        dec: Angle.Degrees(+08.97162667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63108"},
        {"Hipparcos Number", "HIP 38022"},
        {"Geneva Identification System", "GEN# +1.00063108"},
        {"Smithsonian Astrophysical Observation", "SAO 115933"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.88766226),
        dec: Angle.Degrees(+08.97225008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106295"},
        {"Hipparcos Number", "HIP 59636"},
        {"Smithsonian Astrophysical Observation", "SAO 119277"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.45945273),
        dec: Angle.Degrees(+08.97229057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65715"},
        {"Hipparcos Number", "HIP 39134"},
        {"Smithsonian Astrophysical Observation", "SAO 116219"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.07861230),
        dec: Angle.Degrees(+08.97423531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48146"},
        {"Smithsonian Astrophysical Observation", "SAO 117924"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.22146681),
        dec: Angle.Degrees(+08.97445645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31766"},
        {"Hipparcos Number", "HIP 23153"},
        {"Celescope Catalog", "CEL 501"},
        {"Geneva Identification System", "GEN# +1.00031766"},
        {"Smithsonian Astrophysical Observation", "SAO 112283"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.72094269),
        dec: Angle.Degrees(+08.97446727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7335"},
        {"Hipparcos Number", "HIP 5732"},
        {"Geneva Identification System", "GEN# +1.00007335"},
        {"Smithsonian Astrophysical Observation", "SAO 109738"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.42433116),
        dec: Angle.Degrees(+08.97463949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66601"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.78370815),
        dec: Angle.Degrees(+08.97569693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78969"},
        {"Hipparcos Number", "HIP 45111"},
        {"Smithsonian Astrophysical Observation", "SAO 117482"},
        {"Wilson Evans Batten Catalogue", "WEB 8607"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.86197953),
        dec: Angle.Degrees(+08.97604903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117697"},
        {"Hipparcos Number", "HIP 66007"},
        {"Geneva Identification System", "GEN# +1.00117697"},
        {"Smithsonian Astrophysical Observation", "SAO 119985"},
        {"Wilson Evans Batten Catalogue", "WEB 11671"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.99256552),
        dec: Angle.Degrees(+08.97703728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196425"},
        {"Hipparcos Number", "HIP 101714"},
        {"Geneva Identification System", "GEN# +1.00196425"},
        {"Renson", "Renson 54740"},
        {"Smithsonian Astrophysical Observation", "SAO 126022"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.26619755),
        dec: Angle.Degrees(+08.97778475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129134"},
        {"Hipparcos Number", "HIP 71754"},
        {"Smithsonian Astrophysical Observation", "SAO 120597"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.15965182),
        dec: Angle.Degrees(+08.97809696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20165"},
        {"Hipparcos Number", "HIP 15099"},
        {"Cincinnati Publication", "Ci 18 427"},
        {"Cincinnati Publication 2", "Ci 20 216"},
        {"Geneva Identification System", "GEN# +1.00020165"},
        {"Smithsonian Astrophysical Observation", "SAO 111070"},
        {"Wilson Evans Batten Catalogue", "WEB 2910"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.69579281),
        dec: Angle.Degrees(+08.98177593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 401.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -404.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76884"},
        {"Hipparcos Number", "HIP 44133"},
        {"Smithsonian Astrophysical Observation", "SAO 117321"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.83134681),
        dec: Angle.Degrees(+08.98231739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100768"},
        {"Smithsonian Astrophysical Observation", "SAO 125800"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.46736135),
        dec: Angle.Degrees(+08.98395565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31996",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5328 AB"},
        {"Henry Draper", "HD 47888"},
        {"Hipparcos Number", "HIP 31996"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.28923459),
        dec: Angle.Degrees(+08.98477101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147589"},
        {"Hipparcos Number", "HIP 80203"},
        {"Smithsonian Astrophysical Observation", "SAO 121552"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.60202486),
        dec: Angle.Degrees(+08.98660242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30947"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.43206487),
        dec: Angle.Degrees(+08.98789937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103889"},
        {"Hipparcos Number", "HIP 58337"},
        {"Smithsonian Astrophysical Observation", "SAO 119136"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.45266048),
        dec: Angle.Degrees(+08.98967890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9559"},
        {"Hipparcos Number", "HIP 7293"},
        {"Smithsonian Astrophysical Observation", "SAO 109976"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.48235668),
        dec: Angle.Degrees(+08.99362761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104895"},
        {"Smithsonian Astrophysical Observation", "SAO 126649"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.72327793),
        dec: Angle.Degrees(+08.99369357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38368"},
        {"Smithsonian Astrophysical Observation", "SAO 116036"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.90294979),
        dec: Angle.Degrees(+08.99390036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83822"},
        {"Hipparcos Number", "HIP 47518"},
        {"Geneva Identification System", "GEN# +1.00083822"},
        {"Smithsonian Astrophysical Observation", "SAO 117851"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.31101277),
        dec: Angle.Degrees(+08.99552713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112897"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.93973375),
        dec: Angle.Degrees(+08.99589502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139750"},
        {"Hipparcos Number", "HIP 76686"},
        {"Geneva Identification System", "GEN# +1.00139750"},
        {"Smithsonian Astrophysical Observation", "SAO 121110"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.89535616),
        dec: Angle.Degrees(+08.99733315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35622"},
        {"Hipparcos Number", "HIP 25433"},
        {"Smithsonian Astrophysical Observation", "SAO 112759"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.59407984),
        dec: Angle.Degrees(+08.99999154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109598"},
        {"Smithsonian Astrophysical Observation", "SAO 127364"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.02182563),
        dec: Angle.Degrees(+09.00150065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110439"},
        {"Hipparcos Number", "HIP 61973"},
        {"Geneva Identification System", "GEN# +1.00110439"},
        {"Smithsonian Astrophysical Observation", "SAO 119540"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.50243369),
        dec: Angle.Degrees(+09.00306838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89433"},
        {"Hipparcos Number", "HIP 50542"},
        {"Geneva Identification System", "GEN# +1.00089433"},
        {"Smithsonian Astrophysical Observation", "SAO 118219"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.85596360),
        dec: Angle.Degrees(+09.00472963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15466"},
        {"Hipparcos Number", "HIP 11602"},
        {"Geneva Identification System", "GEN# +1.00015466"},
        {"Smithsonian Astrophysical Observation", "SAO 110566"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.39691628),
        dec: Angle.Degrees(+09.00631174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199361"},
        {"Hipparcos Number", "HIP 103365"},
        {"Smithsonian Astrophysical Observation", "SAO 126386"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.12003359),
        dec: Angle.Degrees(+09.00648867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10737"},
        {"Smithsonian Astrophysical Observation", "SAO 110457"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.54971489),
        dec: Angle.Degrees(+09.00777948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202683"},
        {"Hipparcos Number", "HIP 105093"},
        {"Smithsonian Astrophysical Observation", "SAO 126683"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.33476743),
        dec: Angle.Degrees(+09.00819964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154762"},
        {"Hipparcos Number", "HIP 83764"},
        {"Smithsonian Astrophysical Observation", "SAO 122095"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.78600120),
        dec: Angle.Degrees(+09.00895046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12451"},
        {"Geneva Identification System", "GEN# +6.20001027"},
    },
    visualMagnitude: 11.77,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.07359546),
        dec: Angle.Degrees(+09.00951181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58682"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.51638236),
        dec: Angle.Degrees(+09.01167774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166048"},
        {"Hipparcos Number", "HIP 88863"},
        {"Smithsonian Astrophysical Observation", "SAO 123169"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14061056),
        dec: Angle.Degrees(+09.01366230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11793"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.04537304),
        dec: Angle.Degrees(+09.01450617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115231"},
        {"Hipparcos Number", "HIP 64698"},
        {"Cincinnati Publication", "Ci 18 1708"},
        {"Geneva Identification System", "GEN# +1.00115231"},
        {"Smithsonian Astrophysical Observation", "SAO 119836"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.90492512),
        dec: Angle.Degrees(+09.01632548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -362.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30311"},
        {"Hipparcos Number", "HIP 22221"},
        {"Geneva Identification System", "GEN# +5.20250113"},
        {"Smithsonian Astrophysical Observation", "SAO 112069"},
        {"Wilson Evans Batten Catalogue", "WEB 4276"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.68968243),
        dec: Angle.Degrees(+09.01746112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94949"},
        {"Hipparcos Number", "HIP 53591"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.45523770),
        dec: Angle.Degrees(+09.01869253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4044"},
        {"Hipparcos Number", "HIP 3384"},
        {"Geneva Identification System", "GEN# +1.00004044"},
        {"Smithsonian Astrophysical Observation", "SAO 109403"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.75561841),
        dec: Angle.Degrees(+09.01886119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132448"},
        {"Hipparcos Number", "HIP 73316"},
        {"Smithsonian Astrophysical Observation", "SAO 120772"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73454457),
        dec: Angle.Degrees(+09.02101760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150965"},
        {"Hipparcos Number", "HIP 81923"},
        {"Smithsonian Astrophysical Observation", "SAO 121821"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00167574),
        dec: Angle.Degrees(+09.02160992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52886"},
        {"Hipparcos Number", "HIP 33995"},
        {"Geneva Identification System", "GEN# +1.00052886"},
        {"Smithsonian Astrophysical Observation", "SAO 114831"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.80379838),
        dec: Angle.Degrees(+09.02365396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96641"},
        {"Hipparcos Number", "HIP 54417"},
        {"Fundamental Katalog 5th Edition", "FK5 4985"},
        {"Smithsonian Astrophysical Observation", "SAO 118677"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.02588782),
        dec: Angle.Degrees(+09.02367628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154144"},
        {"Hipparcos Number", "HIP 83458"},
        {"Geneva Identification System", "GEN# +1.00154144"},
        {"Smithsonian Astrophysical Observation", "SAO 122041"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.85636391),
        dec: Angle.Degrees(+09.02466956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25012"},
        {"Hipparcos Number", "HIP 18599"},
        {"Smithsonian Astrophysical Observation", "SAO 111537"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.69425274),
        dec: Angle.Degrees(+09.02608894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43405"},
        {"Hipparcos Number", "HIP 29787"},
        {"Smithsonian Astrophysical Observation", "SAO 113663"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.07455946),
        dec: Angle.Degrees(+09.02773700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19106"},
        {"Hipparcos Number", "HIP 14319"},
        {"Smithsonian Astrophysical Observation", "SAO 110943"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.17065208),
        dec: Angle.Degrees(+09.02840059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21120"},
        {"Hipparcos Number", "HIP 15900"},
        {"Fundamental Katalog 5th Edition", "FK5 121"},
        {"Geneva Identification System", "GEN# +1.00021120"},
        {"Smithsonian Astrophysical Observation", "SAO 111172"},
        {"Wilson Evans Batten Catalogue", "WEB 3036"},
    },
    visualMagnitude: 3.61,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.20349011),
        dec: Angle.Degrees(+09.02906504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219002"},
        {"Hipparcos Number", "HIP 114562"},
        {"Geneva Identification System", "GEN# +1.00219002"},
        {"Smithsonian Astrophysical Observation", "SAO 128031"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.09059662),
        dec: Angle.Degrees(+09.02937106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45827"},
        {"Hipparcos Number", "HIP 30977"},
        {"Celescope Catalog", "CEL 1265"},
        {"Geneva Identification System", "GEN# +1.00045827"},
        {"Renson", "Renson 12240"},
        {"Smithsonian Astrophysical Observation", "SAO 113957"},
        {"Wilson Evans Batten Catalogue", "WEB 6170"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.52332845),
        dec: Angle.Degrees(+09.02971927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89990"},
        {"Smithsonian Astrophysical Observation", "SAO 123389"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.41683351),
        dec: Angle.Degrees(+09.03027444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55511"},
        {"Smithsonian Astrophysical Observation", "SAO 118816"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.53518020),
        dec: Angle.Degrees(+09.03125371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153271"},
        {"Hipparcos Number", "HIP 83037"},
        {"Geneva Identification System", "GEN# +1.00153271"},
        {"Smithsonian Astrophysical Observation", "SAO 121964"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.52796176),
        dec: Angle.Degrees(+09.03260722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179870"},
        {"Hipparcos Number", "HIP 94486"},
        {"Smithsonian Astrophysical Observation", "SAO 124415"},
        {"Wilson Evans Batten Catalogue", "WEB 16470"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.47327540),
        dec: Angle.Degrees(+09.03324952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20727"},
        {"Hipparcos Number", "HIP 15572"},
        {"Cincinnati Publication", "Ci 18 447"},
        {"Geneva Identification System", "GEN# +1.00020727"},
        {"Smithsonian Astrophysical Observation", "SAO 111135"},
        {"Wilson Evans Batten Catalogue", "WEB 2992"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.15347162),
        dec: Angle.Degrees(+09.03370429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 287.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8483 AB"},
        {"Henry Draper", "HD 106621"},
        {"Hipparcos Number", "HIP 59804"},
        {"Geneva Identification System", "GEN# +1.00106621J"},
        {"Smithsonian Astrophysical Observation", "SAO 119294"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.95330040),
        dec: Angle.Degrees(+09.03478267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42771"},
        {"Hipparcos Number", "HIP 29496"},
        {"Celescope Catalog", "CEL 1121"},
        {"Geneva Identification System", "GEN# +1.00042771"},
        {"Smithsonian Astrophysical Observation", "SAO 113590"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.22896799),
        dec: Angle.Degrees(+09.03579955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165097"},
        {"Hipparcos Number", "HIP 88478"},
        {"Smithsonian Astrophysical Observation", "SAO 123078"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.00077245),
        dec: Angle.Degrees(+09.03743236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115426"},
        {"Hipparcos Number", "HIP 64806"},
        {"Smithsonian Astrophysical Observation", "SAO 119854"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.23316459),
        dec: Angle.Degrees(+09.03964729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173071"},
        {"Hipparcos Number", "HIP 91818"},
        {"Geneva Identification System", "GEN# +1.00173071"},
        {"Smithsonian Astrophysical Observation", "SAO 123843"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.81556633),
        dec: Angle.Degrees(+09.04120195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207829"},
        {"Hipparcos Number", "HIP 107902"},
        {"Geneva Identification System", "GEN# +1.00207829"},
        {"Smithsonian Astrophysical Observation", "SAO 127117"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.92729365),
        dec: Angle.Degrees(+09.04200576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1511"},
        {"Hipparcos Number", "HIP 1554"},
        {"Geneva Identification System", "GEN# +1.00001511"},
        {"Smithsonian Astrophysical Observation", "SAO 109138"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84320750),
        dec: Angle.Degrees(+09.04416945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85621"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43796880),
        dec: Angle.Degrees(+09.04535626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127070"},
        {"Hipparcos Number", "HIP 70831"},
        {"Smithsonian Astrophysical Observation", "SAO 120492"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.27397724),
        dec: Angle.Degrees(+09.04714533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43821"},
        {"Hipparcos Number", "HIP 29982"},
        {"Geneva Identification System", "GEN# +1.00043821"},
        {"Smithsonian Astrophysical Observation", "SAO 113710"},
        {"Wilson Evans Batten Catalogue", "WEB 5948"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66813687),
        dec: Angle.Degrees(+09.04728472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64984"},
        {"Hipparcos Number", "HIP 38829"},
        {"Geneva Identification System", "GEN# +1.00064984"},
        {"Smithsonian Astrophysical Observation", "SAO 116154"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.19567292),
        dec: Angle.Degrees(+09.04825941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77133"},
        {"Hipparcos Number", "HIP 44272"},
        {"Smithsonian Astrophysical Observation", "SAO 117341"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.22980874),
        dec: Angle.Degrees(+09.05129519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7390 AB"},
        {"Henry Draper", "HD 81858"},
        {"Hipparcos Number", "HIP 46454"},
        {"Geneva Identification System", "GEN# +1.00081858"},
        {"Smithsonian Astrophysical Observation", "SAO 117717"},
        {"Wilson Evans Batten Catalogue", "WEB 8772"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.11407050),
        dec: Angle.Degrees(+09.05677114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9013 AB"},
        {"Henry Draper", "HD 119825"},
        {"Hipparcos Number", "HIP 67115"},
        {"Smithsonian Astrophysical Observation", "SAO 120096"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33696574),
        dec: Angle.Degrees(+09.05793275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22238"},
        {"Smithsonian Astrophysical Observation", "SAO 112073"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.76935163),
        dec: Angle.Degrees(+09.06067752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7953 AB"},
        {"Henry Draper", "HD 94134"},
        {"Hipparcos Number", "HIP 53117"},
        {"Smithsonian Astrophysical Observation", "SAO 118545"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.00031406),
        dec: Angle.Degrees(+09.06141213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170510"},
        {"Hipparcos Number", "HIP 90626"},
        {"Smithsonian Astrophysical Observation", "SAO 123561"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.38250514),
        dec: Angle.Degrees(+09.06191053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48472"},
        {"Hipparcos Number", "HIP 32245"},
        {"Smithsonian Astrophysical Observation", "SAO 114328"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.97487900),
        dec: Angle.Degrees(+09.06395275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111132"},
        {"Hipparcos Number", "HIP 62375"},
        {"Geneva Identification System", "GEN# +1.00111132"},
        {"Smithsonian Astrophysical Observation", "SAO 119586"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.75913381),
        dec: Angle.Degrees(+09.06399757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22711"},
        {"Hipparcos Number", "HIP 17059"},
        {"Smithsonian Astrophysical Observation", "SAO 111325"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85877443),
        dec: Angle.Degrees(+09.06517344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43582"},
        {"Smithsonian Astrophysical Observation", "SAO 117215"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.14196185),
        dec: Angle.Degrees(+09.06738119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2103"},
        {"Hipparcos Number", "HIP 1998"},
        {"Smithsonian Astrophysical Observation", "SAO 109191"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.32961279),
        dec: Angle.Degrees(+09.06802770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218046"},
        {"Hipparcos Number", "HIP 113966"},
        {"Geneva Identification System", "GEN# +1.00218046"},
        {"Smithsonian Astrophysical Observation", "SAO 127951"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.20051156),
        dec: Angle.Degrees(+09.07005727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129849"},
        {"Hipparcos Number", "HIP 72076"},
        {"Smithsonian Astrophysical Observation", "SAO 120632"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.15736294),
        dec: Angle.Degrees(+09.07079743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40774"},
        {"Hipparcos Number", "HIP 28526"},
        {"Geneva Identification System", "GEN# +1.00040774"},
        {"Smithsonian Astrophysical Observation", "SAO 113367"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.32225729),
        dec: Angle.Degrees(+09.07242914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10379"},
        {"Hipparcos Number", "HIP 7883"},
        {"Smithsonian Astrophysical Observation", "SAO 110063"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.35521798),
        dec: Angle.Degrees(+09.07296027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86714"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.77461928),
        dec: Angle.Degrees(+09.07385870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 188.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115161"},
        {"Smithsonian Astrophysical Observation", "SAO 128115"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91248053),
        dec: Angle.Degrees(+09.07410271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61473"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.94815795),
        dec: Angle.Degrees(+09.07430896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8298 A"},
        {"Hipparcos Number", "HIP 57425"},
        {"Smithsonian Astrophysical Observation", "SAO 119042"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.59299180),
        dec: Angle.Degrees(+09.07455006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79273"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.69189843),
        dec: Angle.Degrees(+09.07834602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80294"},
        {"Hipparcos Number", "HIP 45717"},
        {"Smithsonian Astrophysical Observation", "SAO 117585"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.79952221),
        dec: Angle.Degrees(+09.07914150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112276"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12281057),
        dec: Angle.Degrees(+09.07939300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15392 A"},
        {"Henry Draper", "HD 207862"},
        {"Hipparcos Number", "HIP 107925"},
        {"Geneva Identification System", "GEN# +1.00207862"},
        {"Renson", "Renson 57800"},
        {"Smithsonian Astrophysical Observation", "SAO 127121"},
        {"Wilson Evans Batten Catalogue", "WEB 19461"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.98568424),
        dec: Angle.Degrees(+09.07950761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65905"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.65062647),
        dec: Angle.Degrees(+09.08059794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181213"},
        {"Hipparcos Number", "HIP 94946"},
        {"Smithsonian Astrophysical Observation", "SAO 124503"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.81525996),
        dec: Angle.Degrees(+09.08064114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12483"},
        {"Hipparcos Number", "HIP 9537"},
        {"Geneva Identification System", "GEN# +1.00012483"},
        {"Smithsonian Astrophysical Observation", "SAO 110295"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64780438),
        dec: Angle.Degrees(+09.08169698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119084"},
        {"Hipparcos Number", "HIP 66756"},
        {"Smithsonian Astrophysical Observation", "SAO 120063"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.23842201),
        dec: Angle.Degrees(+09.08193308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137183"},
        {"Hipparcos Number", "HIP 75388"},
        {"Geneva Identification System", "GEN# +1.00137183"},
        {"Smithsonian Astrophysical Observation", "SAO 120982"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.07482218),
        dec: Angle.Degrees(+09.08758117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192502"},
        {"Hipparcos Number", "HIP 99802"},
        {"Smithsonian Astrophysical Observation", "SAO 125610"},
        {"Wilson Evans Batten Catalogue", "WEB 17925"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.72976540),
        dec: Angle.Degrees(+09.08922086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171246"},
        {"Hipparcos Number", "HIP 90974"},
        {"Smithsonian Astrophysical Observation", "SAO 123638"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.35994567),
        dec: Angle.Degrees(+09.09192461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194739"},
        {"Hipparcos Number", "HIP 100858"},
        {"Smithsonian Astrophysical Observation", "SAO 125822"},
        {"Wilson Evans Batten Catalogue", "WEB 18223"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.75888912),
        dec: Angle.Degrees(+09.09215928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185784"},
        {"Hipparcos Number", "HIP 96787"},
        {"Fundamental Katalog 5th Edition", "FK5 5732"},
        {"Geneva Identification System", "GEN# +1.00185784"},
        {"Smithsonian Astrophysical Observation", "SAO 124921"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.10489341),
        dec: Angle.Degrees(+09.09272466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190737"},
        {"Hipparcos Number", "HIP 99010"},
        {"Smithsonian Astrophysical Observation", "SAO 125443"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.50820405),
        dec: Angle.Degrees(+09.09339920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61525"},
        {"Hipparcos Number", "HIP 37351"},
        {"Smithsonian Astrophysical Observation", "SAO 115769"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.00233975),
        dec: Angle.Degrees(+09.09453461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167065"},
        {"Hipparcos Number", "HIP 89301"},
        {"Geneva Identification System", "GEN# +1.00167065"},
        {"Smithsonian Astrophysical Observation", "SAO 123264"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.32824556),
        dec: Angle.Degrees(+09.09706315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9485"},
        {"Smithsonian Astrophysical Observation", "SAO 110290"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.50710552),
        dec: Angle.Degrees(+09.10003129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45909"},
        {"Smithsonian Astrophysical Observation", "SAO 117618"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.41221198),
        dec: Angle.Degrees(+09.10077508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67329"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.99581335),
        dec: Angle.Degrees(+09.10260614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18076"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.96232852),
        dec: Angle.Degrees(+09.10421697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81078"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39833751),
        dec: Angle.Degrees(+09.10478893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15298"},
        {"Fundamental Katalog 5th Edition", "FK5 4300"},
        {"Smithsonian Astrophysical Observation", "SAO 111099"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.34327305),
        dec: Angle.Degrees(+09.10597588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99997"},
        {"Hipparcos Number", "HIP 56136"},
        {"Geneva Identification System", "GEN# +1.00099997"},
        {"Smithsonian Astrophysical Observation", "SAO 118896"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60454315),
        dec: Angle.Degrees(+09.10849072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111309"},
        {"Hipparcos Number", "HIP 62489"},
        {"Geneva Identification System", "GEN# +1.00111309"},
        {"Smithsonian Astrophysical Observation", "SAO 119602"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.08100060),
        dec: Angle.Degrees(+09.11160916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128141"},
        {"Hipparcos Number", "HIP 71319"},
        {"Smithsonian Astrophysical Observation", "SAO 120544"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.76547909),
        dec: Angle.Degrees(+09.11392890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197462"},
        {"Hipparcos Number", "HIP 102296"},
        {"Smithsonian Astrophysical Observation", "SAO 126143"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.91206265),
        dec: Angle.Degrees(+09.11449463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255441"},
        {"Hipparcos Number", "HIP 30124"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.08357352),
        dec: Angle.Degrees(+09.11977371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171802"},
        {"Hipparcos Number", "HIP 91217"},
        {"Fundamental Katalog 5th Edition", "FK5 1484"},
        {"Geneva Identification System", "GEN# +1.00171802"},
        {"Smithsonian Astrophysical Observation", "SAO 123690"},
        {"Wilson Evans Batten Catalogue", "WEB 15669"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11598380),
        dec: Angle.Degrees(+09.12281663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33690"},
        {"Hipparcos Number", "HIP 24247"},
        {"Celescope Catalog", "CEL 564"},
        {"Geneva Identification System", "GEN# +1.00033690"},
        {"Smithsonian Astrophysical Observation", "SAO 112515"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.07707504),
        dec: Angle.Degrees(+09.12419180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19623"},
        {"Smithsonian Astrophysical Observation", "SAO 111658"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.07203457),
        dec: Angle.Degrees(+09.12747268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139762"},
        {"Hipparcos Number", "HIP 76700"},
        {"Smithsonian Astrophysical Observation", "SAO 121112"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91879107),
        dec: Angle.Degrees(+09.12751206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121132"},
        {"Hipparcos Number", "HIP 67805"},
        {"Smithsonian Astrophysical Observation", "SAO 120152"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.35869578),
        dec: Angle.Degrees(+09.12789207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214981"},
        {"Hipparcos Number", "HIP 112060"},
        {"Smithsonian Astrophysical Observation", "SAO 127695"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.46115148),
        dec: Angle.Degrees(+09.12806517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26622"},
        {"Hipparcos Number", "HIP 19685"},
        {"Smithsonian Astrophysical Observation", "SAO 111665"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.25313360),
        dec: Angle.Degrees(+09.12870738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213119"},
        {"Hipparcos Number", "HIP 110986"},
        {"Fundamental Katalog 5th Edition", "FK5 1588"},
        {"Geneva Identification System", "GEN# +1.00213119"},
        {"Smithsonian Astrophysical Observation", "SAO 127544"},
        {"Wilson Evans Batten Catalogue", "WEB 19870"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.28313545),
        dec: Angle.Degrees(+09.12908395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103545"},
        {"Hipparcos Number", "HIP 58139"},
        {"Geneva Identification System", "GEN# +1.00103545"},
        {"Smithsonian Astrophysical Observation", "SAO 119116"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86329561),
        dec: Angle.Degrees(+09.12926614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56954"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.12682063),
        dec: Angle.Degrees(+09.12947497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15074"},
        {"Geneva Identification System", "GEN# +9.80079017"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.57348634),
        dec: Angle.Degrees(+09.13110358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 273.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6152"},
        {"Hipparcos Number", "HIP 4878"},
        {"Geneva Identification System", "GEN# +1.00006152"},
        {"Smithsonian Astrophysical Observation", "SAO 109623"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.67751329),
        dec: Angle.Degrees(+09.13301281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61680"},
        {"Hipparcos Number", "HIP 37408"},
        {"Smithsonian Astrophysical Observation", "SAO 115792"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21054924),
        dec: Angle.Degrees(+09.13311969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149823"},
        {"Hipparcos Number", "HIP 81350"},
        {"Smithsonian Astrophysical Observation", "SAO 121729"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.20840983),
        dec: Angle.Degrees(+09.13338647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178479"},
        {"Hipparcos Number", "HIP 94011"},
        {"Smithsonian Astrophysical Observation", "SAO 124312"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10488523),
        dec: Angle.Degrees(+09.13355369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139017"},
        {"Hipparcos Number", "HIP 76319"},
        {"Geneva Identification System", "GEN# +1.00139017"},
        {"Smithsonian Astrophysical Observation", "SAO 121078"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.83754389),
        dec: Angle.Degrees(+09.13511951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225056"},
        {"Hipparcos Number", "HIP 241"},
        {"Smithsonian Astrophysical Observation", "SAO 108986"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.75196696),
        dec: Angle.Degrees(+09.13829706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52913"},
        {"Hipparcos Number", "HIP 34002"},
        {"Geneva Identification System", "GEN# +1.00052913"},
        {"Renson", "Renson 14527"},
        {"Smithsonian Astrophysical Observation", "SAO 114835"},
        {"Wilson Evans Batten Catalogue", "WEB 6818"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.82470567),
        dec: Angle.Degrees(+09.13834729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8101"},
        {"Hipparcos Number", "HIP 6277"},
        {"Geneva Identification System", "GEN# +1.00008101"},
        {"Smithsonian Astrophysical Observation", "SAO 109817"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13513403),
        dec: Angle.Degrees(+09.13845200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 745"},
        {"Hipparcos Number", "HIP 954"},
        {"Geneva Identification System", "GEN# +1.00000745"},
        {"Smithsonian Astrophysical Observation", "SAO 109059"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.94812420),
        dec: Angle.Degrees(+09.14000705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9960 AB"},
        {"Henry Draper", "HD 145744"},
        {"Hipparcos Number", "HIP 79396"},
        {"Smithsonian Astrophysical Observation", "SAO 121424"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.05750001),
        dec: Angle.Degrees(+09.14083305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160293"},
        {"Hipparcos Number", "HIP 86353"},
        {"Geneva Identification System", "GEN# +1.00160293"},
        {"Smithsonian Astrophysical Observation", "SAO 122597"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.68696332),
        dec: Angle.Degrees(+09.14088599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32524"},
        {"Hipparcos Number", "HIP 23580"},
        {"Smithsonian Astrophysical Observation", "SAO 112376"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.04293708),
        dec: Angle.Degrees(+09.14215563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73916"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57777223),
        dec: Angle.Degrees(+09.14216394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22684"},
        {"Hipparcos Number", "HIP 17038"},
        {"Smithsonian Astrophysical Observation", "SAO 111323"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.78401085),
        dec: Angle.Degrees(+09.14377433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10414"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.54557194),
        dec: Angle.Degrees(+09.14402787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31655",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5262 A"},
        {"Henry Draper", "HD 47157"},
        {"Hipparcos Number", "HIP 31655"},
        {"Geneva Identification System", "GEN# +1.00047157"},
        {"Smithsonian Astrophysical Observation", "SAO 114147"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.38262960),
        dec: Angle.Degrees(+09.14447648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178036"},
        {"Hipparcos Number", "HIP 93846"},
        {"Geneva Identification System", "GEN# +1.00178036"},
        {"Smithsonian Astrophysical Observation", "SAO 124274"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.67230797),
        dec: Angle.Degrees(+09.14807041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94030"},
        {"Hipparcos Number", "HIP 53056"},
        {"Geneva Identification System", "GEN# +1.00094030"},
        {"Smithsonian Astrophysical Observation", "SAO 118539"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.82960751),
        dec: Angle.Degrees(+09.14894763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166231"},
        {"Hipparcos Number", "HIP 88946"},
        {"Geneva Identification System", "GEN# +1.00166231"},
        {"Smithsonian Astrophysical Observation", "SAO 123183"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.33868625),
        dec: Angle.Degrees(+09.15100015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69686"},
        {"Hipparcos Number", "HIP 40691"},
        {"Geneva Identification System", "GEN# +1.00069686"},
        {"Smithsonian Astrophysical Observation", "SAO 116602"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59594473),
        dec: Angle.Degrees(+09.15139160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67660"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.94300786),
        dec: Angle.Degrees(+09.15140889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183991"},
        {"Hipparcos Number", "HIP 96055"},
        {"Smithsonian Astrophysical Observation", "SAO 124740"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.96508222),
        dec: Angle.Degrees(+09.15279399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2639"},
        {"Smithsonian Astrophysical Observation", "SAO 109272"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.36665139),
        dec: Angle.Degrees(+09.15318652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131863"},
        {"Hipparcos Number", "HIP 73058"},
        {"Geneva Identification System", "GEN# +1.00131863"},
        {"Smithsonian Astrophysical Observation", "SAO 120742"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.95234672),
        dec: Angle.Degrees(+09.15335100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33235"},
        {"Hipparcos Number", "HIP 23967"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28098202),
        dec: Angle.Degrees(+09.15525503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20068"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.54745368),
        dec: Angle.Degrees(+09.15555293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114234"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.02800905),
        dec: Angle.Degrees(+09.15675377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103718"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.25955021),
        dec: Angle.Degrees(+09.15679229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112447"},
        {"Hipparcos Number", "HIP 63174"},
        {"Geneva Identification System", "GEN# +1.00112447"},
        {"Smithsonian Astrophysical Observation", "SAO 119679"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.14782385),
        dec: Angle.Degrees(+09.15679264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8198",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Torcular"},
        {"Henry Draper", "HD 10761"},
        {"Hipparcos Number", "HIP 8198"},
        {"Fundamental Katalog 5th Edition", "FK5 60"},
        {"Geneva Identification System", "GEN# +1.00010761"},
        {"Smithsonian Astrophysical Observation", "SAO 110110"},
        {"Wilson Evans Batten Catalogue", "WEB 1745"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.34828629),
        dec: Angle.Degrees(+09.15764102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34604"},
        {"Hipparcos Number", "HIP 24802"},
        {"Smithsonian Astrophysical Observation", "SAO 112622"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.76105518),
        dec: Angle.Degrees(+09.15800958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2323"},
        {"Hipparcos Number", "HIP 2154"},
        {"Smithsonian Astrophysical Observation", "SAO 109214"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.80389964),
        dec: Angle.Degrees(+09.15921074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13427"},
        {"Smithsonian Astrophysical Observation", "SAO 110809"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.22378877),
        dec: Angle.Degrees(+09.15959894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2807"},
        {"Hipparcos Number", "HIP 2491"},
        {"Smithsonian Astrophysical Observation", "SAO 109252"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.90566407),
        dec: Angle.Degrees(+09.16121584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175725"},
        {"Hipparcos Number", "HIP 92967"},
        {"Smithsonian Astrophysical Observation", "SAO 124075"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.09936745),
        dec: Angle.Degrees(+09.16268092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173091"},
        {"Hipparcos Number", "HIP 91825"},
        {"Geneva Identification System", "GEN# +1.00173091"},
        {"Smithsonian Astrophysical Observation", "SAO 123845"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.83084885),
        dec: Angle.Degrees(+09.16271338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69500"},
        {"Hipparcos Number", "HIP 40628"},
        {"Geneva Identification System", "GEN# +1.00069500"},
        {"Smithsonian Astrophysical Observation", "SAO 116586"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.41993696),
        dec: Angle.Degrees(+09.16476829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41712"},
        {"Hipparcos Number", "HIP 29002"},
        {"Geneva Identification System", "GEN# +1.00041712"},
        {"Smithsonian Astrophysical Observation", "SAO 113463"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.78902429),
        dec: Angle.Degrees(+09.16612939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67873"},
        {"Hipparcos Number", "HIP 40012"},
        {"Geneva Identification System", "GEN# +1.00067873"},
        {"Smithsonian Astrophysical Observation", "SAO 116428"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.57460160),
        dec: Angle.Degrees(+09.16815442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98747"},
        {"Hipparcos Number", "HIP 55488"},
        {"Geneva Identification System", "GEN# +1.00098747"},
        {"Smithsonian Astrophysical Observation", "SAO 118813"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.45938932),
        dec: Angle.Degrees(+09.16844074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7429 AB"},
        {"Henry Draper", "HD 82605"},
        {"Hipparcos Number", "HIP 46885"},
        {"Smithsonian Astrophysical Observation", "SAO 117767"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.31775873),
        dec: Angle.Degrees(+09.16851931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259654"},
        {"Hipparcos Number", "HIP 31294"},
        {"Smithsonian Astrophysical Observation", "SAO 114049"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.44111847),
        dec: Angle.Degrees(+09.16903813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127031"},
        {"Hipparcos Number", "HIP 70810"},
        {"Smithsonian Astrophysical Observation", "SAO 120488"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.21708899),
        dec: Angle.Degrees(+09.16922805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200778"},
        {"Hipparcos Number", "HIP 104091"},
        {"Geneva Identification System", "GEN# +1.00200778"},
        {"Smithsonian Astrophysical Observation", "SAO 126534"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.33042854),
        dec: Angle.Degrees(+09.16948085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25286",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3997 AB"},
        {"Henry Draper", "HD 35365"},
        {"Hipparcos Number", "HIP 25286"},
        {"Smithsonian Astrophysical Observation", "SAO 112723"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.13808977),
        dec: Angle.Degrees(+09.17086841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44782"},
        {"Hipparcos Number", "HIP 30445"},
        {"Celescope Catalog", "CEL 1215"},
        {"Geneva Identification System", "GEN# +1.00044782"},
        {"Smithsonian Astrophysical Observation", "SAO 113815"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00514162),
        dec: Angle.Degrees(+09.17157749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104924"},
        {"Hipparcos Number", "HIP 58916"},
        {"Smithsonian Astrophysical Observation", "SAO 119208"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.22289640),
        dec: Angle.Degrees(+09.17232979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95651"},
        {"Hipparcos Number", "HIP 53977"},
        {"Geneva Identification System", "GEN# +1.00095651"},
        {"Smithsonian Astrophysical Observation", "SAO 118628"},
        {"Wilson Evans Batten Catalogue", "WEB 9765"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.63700863),
        dec: Angle.Degrees(+09.17298526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39821"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.04600575),
        dec: Angle.Degrees(+09.17381454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24573"},
        {"Hipparcos Number", "HIP 18297"},
        {"Smithsonian Astrophysical Observation", "SAO 111494"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.68960430),
        dec: Angle.Degrees(+09.17767349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13977"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.01252695),
        dec: Angle.Degrees(+09.17846726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108457"},
    },
    visualMagnitude: 12.33,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.56733793),
        dec: Angle.Degrees(+09.18109359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67952"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.73910474),
        dec: Angle.Degrees(+09.18151411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209695"},
        {"Hipparcos Number", "HIP 109025"},
        {"Smithsonian Astrophysical Observation", "SAO 127277"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30392546),
        dec: Angle.Degrees(+09.18432578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206155"},
        {"Hipparcos Number", "HIP 106981"},
        {"Geneva Identification System", "GEN# +1.00206155"},
        {"Renson", "Renson 57410"},
        {"Smithsonian Astrophysical Observation", "SAO 126971"},
        {"Wilson Evans Batten Catalogue", "WEB 19330"},
        {"Wilson Evans Batten Catalogue 2", "WEB 19331"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.00773230),
        dec: Angle.Degrees(+09.18472065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188330"},
        {"Hipparcos Number", "HIP 97942"},
        {"Smithsonian Astrophysical Observation", "SAO 125212"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.57196811),
        dec: Angle.Degrees(+09.18555284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40526",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tarf"},
        {"Common Name 2", "Altarf"},
        {"Aitken", "ADS 6704 A"},
        {"Henry Draper", "HD 69267"},
        {"Hipparcos Number", "HIP 40526"},
        {"Fundamental Katalog 5th Edition", "FK5 312"},
        {"Geneva Identification System", "GEN# +1.00069267"},
        {"Smithsonian Astrophysical Observation", "SAO 116569"},
        {"Wilson Evans Batten Catalogue", "WEB 7886"},
    },
    visualMagnitude: 3.53,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.12895101),
        dec: Angle.Degrees(+09.18566295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75880"},
        {"Hipparcos Number", "HIP 43618"},
        {"Cincinnati Publication", "Ci 18 1044"},
        {"Geneva Identification System", "GEN# +1.00075880"},
        {"Smithsonian Astrophysical Observation", "SAO 117225"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.25640652),
        dec: Angle.Degrees(+09.18578430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53510"},
        {"Hipparcos Number", "HIP 34215"},
        {"Geneva Identification System", "GEN# +1.00053510"},
        {"Smithsonian Astrophysical Observation", "SAO 114899"},
        {"Wilson Evans Batten Catalogue", "WEB 6849"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.41250410),
        dec: Angle.Degrees(+09.18583678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88640"},
        {"Hipparcos Number", "HIP 50081"},
        {"Geneva Identification System", "GEN# +1.00088640"},
        {"Smithsonian Astrophysical Observation", "SAO 118171"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.37500040),
        dec: Angle.Degrees(+09.18604478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155002"},
        {"Hipparcos Number", "HIP 83891"},
        {"Smithsonian Astrophysical Observation", "SAO 122123"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19074832),
        dec: Angle.Degrees(+09.18614915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133033"},
        {"Hipparcos Number", "HIP 73563"},
        {"Smithsonian Astrophysical Observation", "SAO 120803"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.50816916),
        dec: Angle.Degrees(+09.18740741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8379"},
        {"Hipparcos Number", "HIP 6462"},
        {"Geneva Identification System", "GEN# +1.00008379"},
        {"Smithsonian Astrophysical Observation", "SAO 109844"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.77826756),
        dec: Angle.Degrees(+09.18773061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65063"},
        {"Wilson Evans Batten Catalogue", "WEB 11493"},
    },
    visualMagnitude: 11.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.04817404),
        dec: Angle.Degrees(+09.18796516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46764"},
        {"Smithsonian Astrophysical Observation", "SAO 117750"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.97321120),
        dec: Angle.Degrees(+09.18865990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184405"},
        {"Hipparcos Number", "HIP 96218"},
        {"Smithsonian Astrophysical Observation", "SAO 124798"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.49813980),
        dec: Angle.Degrees(+09.18921844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111369"},
        {"Hipparcos Number", "HIP 62519"},
        {"Geneva Identification System", "GEN# +1.00111369"},
        {"Smithsonian Astrophysical Observation", "SAO 119606"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.18400419),
        dec: Angle.Degrees(+09.19017869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114045"},
        {"Hipparcos Number", "HIP 64064"},
        {"Smithsonian Astrophysical Observation", "SAO 119779"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.94539781),
        dec: Angle.Degrees(+09.19054561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171729"},
        {"Hipparcos Number", "HIP 91184"},
        {"Smithsonian Astrophysical Observation", "SAO 123683"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03247051),
        dec: Angle.Degrees(+09.19100580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104828"},
        {"Hipparcos Number", "HIP 58863"},
        {"Geneva Identification System", "GEN# +1.00104828"},
        {"Smithsonian Astrophysical Observation", "SAO 119198"},
        {"Wilson Evans Batten Catalogue", "WEB 10483"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07337455),
        dec: Angle.Degrees(+09.19298138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194385"},
        {"Hipparcos Number", "HIP 100704"},
        {"Geneva Identification System", "GEN# +1.00194385"},
        {"Smithsonian Astrophysical Observation", "SAO 125778"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.24568268),
        dec: Angle.Degrees(+09.19495562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111704"},
        {"Smithsonian Astrophysical Observation", "SAO 127640"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.42574356),
        dec: Angle.Degrees(+09.19534650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14803"},
        {"Geneva Identification System", "GEN# +0.00800469"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.79242765),
        dec: Angle.Degrees(+09.19654149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179151"},
        {"Hipparcos Number", "HIP 94242"},
        {"Smithsonian Astrophysical Observation", "SAO 124357"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75695842),
        dec: Angle.Degrees(+09.19706145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39343"},
        {"Hipparcos Number", "HIP 27735"},
        {"Smithsonian Astrophysical Observation", "SAO 113216"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07566499),
        dec: Angle.Degrees(+09.19767468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92110"},
        {"Hipparcos Number", "HIP 52056"},
        {"Geneva Identification System", "GEN# +1.00092110"},
        {"Smithsonian Astrophysical Observation", "SAO 118403"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.56511384),
        dec: Angle.Degrees(+09.19801925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37786"},
        {"Hipparcos Number", "HIP 26792"},
        {"Celescope Catalog", "CEL 929"},
        {"Geneva Identification System", "GEN# +1.00037786"},
        {"Smithsonian Astrophysical Observation", "SAO 113036"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.35780555),
        dec: Angle.Degrees(+09.19835126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72053"},
        {"Hipparcos Number", "HIP 41776"},
        {"Geneva Identification System", "GEN# +1.00072053"},
        {"Smithsonian Astrophysical Observation", "SAO 116849"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.78167815),
        dec: Angle.Degrees(+09.19837057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170579"},
        {"Hipparcos Number", "HIP 90657"},
        {"Geneva Identification System", "GEN# +1.00170579"},
        {"Smithsonian Astrophysical Observation", "SAO 123567"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.47009502),
        dec: Angle.Degrees(+09.19941516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213788"},
        {"Hipparcos Number", "HIP 111383"},
        {"Geneva Identification System", "GEN# +1.00213788"},
        {"Smithsonian Astrophysical Observation", "SAO 127605"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.48821934),
        dec: Angle.Degrees(+09.20061350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65646"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.87766309),
        dec: Angle.Degrees(+09.20095154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -400.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
