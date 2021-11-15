using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_65() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 263"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.82923787),
        dec: Angle.Degrees(+04.68713578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104860",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14774 A"},
        {"Henry Draper", "HD 202276"},
        {"Hipparcos Number", "HIP 104860"},
        {"Smithsonian Astrophysical Observation", "SAO 126642"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.62901734),
        dec: Angle.Degrees(+04.68973040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155423"},
        {"Hipparcos Number", "HIP 84082"},
        {"Geneva Identification System", "GEN# +1.00155423"},
        {"Smithsonian Astrophysical Observation", "SAO 122157"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.84424878),
        dec: Angle.Degrees(+04.69027496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30961"},
        {"Hipparcos Number", "HIP 22635"},
        {"Smithsonian Astrophysical Observation", "SAO 112159"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.04683178),
        dec: Angle.Degrees(+04.69247266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25850"},
        {"Hipparcos Number", "HIP 19125"},
        {"Smithsonian Astrophysical Observation", "SAO 111602"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.50240940),
        dec: Angle.Degrees(+04.69419109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47032"},
        {"Hipparcos Number", "HIP 31598"},
        {"Geneva Identification System", "GEN# +1.00047032"},
        {"Smithsonian Astrophysical Observation", "SAO 114129"},
        {"Wilson Evans Batten Catalogue", "WEB 6325"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.19417390),
        dec: Angle.Degrees(+04.69447773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212943"},
        {"Hipparcos Number", "HIP 110882"},
        {"Fundamental Katalog 5th Edition", "FK5 3796"},
        {"Geneva Identification System", "GEN# +1.00212943"},
        {"Smithsonian Astrophysical Observation", "SAO 127540"},
        {"Wilson Evans Batten Catalogue", "WEB 19854"},
    },
    visualMagnitude: 4.78,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.96448769),
        dec: Angle.Degrees(+04.69641070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214797"},
        {"Hipparcos Number", "HIP 111945"},
        {"Smithsonian Astrophysical Observation", "SAO 127682"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.12826751),
        dec: Angle.Degrees(+04.69695662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223685"},
        {"Hipparcos Number", "HIP 117656"},
        {"Smithsonian Astrophysical Observation", "SAO 128424"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.91751123),
        dec: Angle.Degrees(+04.69783845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1438"},
    },
    visualMagnitude: 12.22,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.48310352),
        dec: Angle.Degrees(+04.69894314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27935"},
        {"Hipparcos Number", "HIP 20601"},
        {"Geneva Identification System", "GEN# +5.20250140"},
        {"Smithsonian Astrophysical Observation", "SAO 111800"},
        {"Wilson Evans Batten Catalogue", "WEB 3947"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.17986454),
        dec: Angle.Degrees(+04.69994856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47431"},
        {"Hipparcos Number", "HIP 31790"},
        {"Geneva Identification System", "GEN# +1.00047431"},
        {"Smithsonian Astrophysical Observation", "SAO 114194"},
        {"Wilson Evans Batten Catalogue", "WEB 6382"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.70586402),
        dec: Angle.Degrees(+04.70060964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83872"},
        {"Hipparcos Number", "HIP 47526"},
        {"Smithsonian Astrophysical Observation", "SAO 117852"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.33777819),
        dec: Angle.Degrees(+04.70222160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38798"},
        {"Hipparcos Number", "HIP 27427"},
        {"Celescope Catalog", "CEL 983"},
        {"Geneva Identification System", "GEN# +1.00038798J"},
        {"Smithsonian Astrophysical Observation", "SAO 113161"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.11758716),
        dec: Angle.Degrees(+04.70395878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140750"},
        {"Hipparcos Number", "HIP 77159"},
        {"Geneva Identification System", "GEN# +1.00140750"},
        {"Smithsonian Astrophysical Observation", "SAO 121168"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.31315514),
        dec: Angle.Degrees(+04.70856424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183085"},
        {"Hipparcos Number", "HIP 95680"},
        {"Geneva Identification System", "GEN# +1.00183085"},
        {"Renson", "Renson 50613"},
        {"Smithsonian Astrophysical Observation", "SAO 124646"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.92117107),
        dec: Angle.Degrees(+04.70969574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17163"},
        {"Hipparcos Number", "HIP 12862"},
        {"Geneva Identification System", "GEN# +1.00017163"},
        {"Smithsonian Astrophysical Observation", "SAO 110730"},
        {"Wilson Evans Batten Catalogue", "WEB 2614"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.33694010),
        dec: Angle.Degrees(+04.71173043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89388"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.61514815),
        dec: Angle.Degrees(+04.71184030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58871"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.10482294),
        dec: Angle.Degrees(+04.71511485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189811"},
        {"Hipparcos Number", "HIP 98615"},
        {"Smithsonian Astrophysical Observation", "SAO 125371"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.44582145),
        dec: Angle.Degrees(+04.71554734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8334"},
        {"Smithsonian Astrophysical Observation", "SAO 110129"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.87257806),
        dec: Angle.Degrees(+04.71609449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42203"},
        {"Hipparcos Number", "HIP 29212"},
        {"Smithsonian Astrophysical Observation", "SAO 113523"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.40681539),
        dec: Angle.Degrees(+04.71760771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42300"},
        {"Hipparcos Number", "HIP 29262"},
        {"Smithsonian Astrophysical Observation", "SAO 113537"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.54307526),
        dec: Angle.Degrees(+04.71820072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218919"},
        {"Hipparcos Number", "HIP 114525"},
        {"Smithsonian Astrophysical Observation", "SAO 128023"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.95295324),
        dec: Angle.Degrees(+04.72078331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19847"},
        {"Hipparcos Number", "HIP 14835"},
        {"Smithsonian Astrophysical Observation", "SAO 111037"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.89327531),
        dec: Angle.Degrees(+04.72328523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118054",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17111 AB"},
        {"Henry Draper", "HD 224315"},
        {"Hipparcos Number", "HIP 118054"},
        {"Smithsonian Astrophysical Observation", "SAO 128487"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.19704781),
        dec: Angle.Degrees(+04.72511081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143499"},
        {"Hipparcos Number", "HIP 78418"},
        {"Smithsonian Astrophysical Observation", "SAO 121311"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.13878127),
        dec: Angle.Degrees(+04.72705905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185985"},
        {"Hipparcos Number", "HIP 96890"},
        {"Fundamental Katalog 5th Edition", "FK5 5735"},
        {"Smithsonian Astrophysical Observation", "SAO 124948"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.43177507),
        dec: Angle.Degrees(+04.72853436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190095"},
        {"Hipparcos Number", "HIP 98730"},
        {"Fundamental Katalog 5th Edition", "FK5 3603"},
        {"Geneva Identification System", "GEN# +1.00190095"},
        {"Smithsonian Astrophysical Observation", "SAO 125384"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.80243673),
        dec: Angle.Degrees(+04.73024614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138833"},
        {"Hipparcos Number", "HIP 76251"},
        {"Smithsonian Astrophysical Observation", "SAO 121067"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.63178481),
        dec: Angle.Degrees(+04.73066798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23312"},
        {"Smithsonian Astrophysical Observation", "SAO 112309"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.20351596),
        dec: Angle.Degrees(+04.73308807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8333"},
        {"Hipparcos Number", "HIP 6441"},
        {"Geneva Identification System", "GEN# +1.00008333"},
        {"Smithsonian Astrophysical Observation", "SAO 109835"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.68118523),
        dec: Angle.Degrees(+04.73828716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29913"},
        {"Hipparcos Number", "HIP 21929"},
        {"Smithsonian Astrophysical Observation", "SAO 112003"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.72911135),
        dec: Angle.Degrees(+04.74077770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74150"},
        {"Smithsonian Astrophysical Observation", "SAO 120865"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26982198),
        dec: Angle.Degrees(+04.74168613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77997"},
        {"Hipparcos Number", "HIP 44652"},
        {"Geneva Identification System", "GEN# +1.00077997"},
        {"Smithsonian Astrophysical Observation", "SAO 117418"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.47105583),
        dec: Angle.Degrees(+04.74226383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70012"},
        {"Hipparcos Number", "HIP 40820"},
        {"Fundamental Katalog 5th Edition", "FK5 4747"},
        {"Smithsonian Astrophysical Observation", "SAO 116633"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.96880983),
        dec: Angle.Degrees(+04.74290226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223707"},
        {"Hipparcos Number", "HIP 117674"},
        {"Smithsonian Astrophysical Observation", "SAO 128425"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.97318276),
        dec: Angle.Degrees(+04.74534804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14651"},
        {"Hipparcos Number", "HIP 11028"},
        {"Fundamental Katalog 5th Edition", "FK5 4219"},
        {"Geneva Identification System", "GEN# +1.00014651"},
        {"Smithsonian Astrophysical Observation", "SAO 110496"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.50360859),
        dec: Angle.Degrees(+04.74656417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39884"},
        {"Hipparcos Number", "HIP 28027"},
        {"Smithsonian Astrophysical Observation", "SAO 113273"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91160804),
        dec: Angle.Degrees(+04.74660519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101690"},
        {"Hipparcos Number", "HIP 57083"},
        {"Geneva Identification System", "GEN# +1.00101690"},
        {"Smithsonian Astrophysical Observation", "SAO 119000"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.53111946),
        dec: Angle.Degrees(+04.74725997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154052"},
        {"Hipparcos Number", "HIP 83416"},
        {"Fundamental Katalog 5th Edition", "FK5 5501"},
        {"Smithsonian Astrophysical Observation", "SAO 122038"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.75262305),
        dec: Angle.Degrees(+04.74769185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52452",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7902"},
        {"Henry Draper", "HD 92841"},
        {"Hipparcos Number", "HIP 52452"},
        {"Geneva Identification System", "GEN# +1.00092841"},
        {"Smithsonian Astrophysical Observation", "SAO 118449"},
        {"Wilson Evans Batten Catalogue", "WEB 9551"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.83711787),
        dec: Angle.Degrees(+04.74774961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212598"},
        {"Hipparcos Number", "HIP 110686"},
        {"Geneva Identification System", "GEN# +1.00212598"},
        {"Smithsonian Astrophysical Observation", "SAO 127523"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.37171568),
        dec: Angle.Degrees(+04.74791402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13651"},
        {"Hipparcos Number", "HIP 10345"},
        {"Geneva Identification System", "GEN# +1.00013651"},
        {"Smithsonian Astrophysical Observation", "SAO 110411"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.31496175),
        dec: Angle.Degrees(+04.74980550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20111",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3116 AB"},
        {"Henry Draper", "HD 27283"},
        {"Hipparcos Number", "HIP 20111"},
        {"Smithsonian Astrophysical Observation", "SAO 111737"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.67423782),
        dec: Angle.Degrees(+04.75073913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90071"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.70966393),
        dec: Angle.Degrees(+04.75263889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4169"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.31151868),
        dec: Angle.Degrees(+04.75454122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143129"},
        {"Hipparcos Number", "HIP 78232"},
        {"Smithsonian Astrophysical Observation", "SAO 121287"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.61977818),
        dec: Angle.Degrees(+04.75486909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72561"},
        {"Hipparcos Number", "HIP 42008"},
        {"Geneva Identification System", "GEN# +1.00072561"},
        {"Smithsonian Astrophysical Observation", "SAO 116890"},
        {"Wilson Evans Batten Catalogue", "WEB 8080"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.43119460),
        dec: Angle.Degrees(+04.75701524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73258"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.58038291),
        dec: Angle.Degrees(+04.75997942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81213"},
        {"Hipparcos Number", "HIP 46130"},
        {"Smithsonian Astrophysical Observation", "SAO 117660"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.10611992),
        dec: Angle.Degrees(+04.76487180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184855"},
        {"Hipparcos Number", "HIP 96427"},
        {"Cincinnati Publication", "Ci 18 2563"},
        {"Geneva Identification System", "GEN# +1.00184855"},
        {"Smithsonian Astrophysical Observation", "SAO 124837"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.06493266),
        dec: Angle.Degrees(+04.76584659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17021"},
        {"Smithsonian Astrophysical Observation", "SAO 111319"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.73886887),
        dec: Angle.Degrees(+04.76738488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4217 AB"},
        {"Henry Draper", "HD 37234"},
        {"Hipparcos Number", "HIP 26402"},
        {"Celescope Catalog", "CEL 861"},
        {"Geneva Identification System", "GEN# +1.00037234J"},
        {"Smithsonian Astrophysical Observation", "SAO 112965"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.30553385),
        dec: Angle.Degrees(+04.76859770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15559 A"},
        {"Henry Draper", "HD 209262"},
        {"Hipparcos Number", "HIP 108761"},
        {"Geneva Identification System", "GEN# +1.00209262"},
        {"Smithsonian Astrophysical Observation", "SAO 127243"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.47537321),
        dec: Angle.Degrees(+04.77070373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119215"},
        {"Hipparcos Number", "HIP 66823"},
        {"Smithsonian Astrophysical Observation", "SAO 120070"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43811033),
        dec: Angle.Degrees(+04.77095316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127337"},
        {"Hipparcos Number", "HIP 70949"},
        {"Fundamental Katalog 5th Edition", "FK5 3149"},
        {"Geneva Identification System", "GEN# +1.00127337"},
        {"Smithsonian Astrophysical Observation", "SAO 120504"},
        {"Wilson Evans Batten Catalogue", "WEB 12279"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.68911903),
        dec: Angle.Degrees(+04.77231676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31307"},
        {"Hipparcos Number", "HIP 22828"},
        {"Geneva Identification System", "GEN# +1.00031307"},
        {"Smithsonian Astrophysical Observation", "SAO 112204"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.68653445),
        dec: Angle.Degrees(+04.77361308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9449"},
        {"Hipparcos Number", "HIP 7210"},
        {"Geneva Identification System", "GEN# +1.00009449"},
        {"Smithsonian Astrophysical Observation", "SAO 109957"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21985617),
        dec: Angle.Degrees(+04.77449845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190662"},
        {"Hipparcos Number", "HIP 98998"},
        {"Smithsonian Astrophysical Observation", "SAO 125438"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.48333380),
        dec: Angle.Degrees(+04.77556419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208919"},
        {"Hipparcos Number", "HIP 108561"},
        {"Smithsonian Astrophysical Observation", "SAO 127210"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.85935278),
        dec: Angle.Degrees(+04.77635070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44975"},
        {"Smithsonian Astrophysical Observation", "SAO 117461"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.42326879),
        dec: Angle.Degrees(+04.77790208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181414"},
        {"Hipparcos Number", "HIP 95045"},
        {"Cincinnati Publication", "Ci 18 2521"},
        {"Fundamental Katalog 5th Edition", "FK5 5700"},
        {"Smithsonian Astrophysical Observation", "SAO 124520"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.08125845),
        dec: Angle.Degrees(+04.77814030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122948"},
        {"Hipparcos Number", "HIP 68783"},
        {"Smithsonian Astrophysical Observation", "SAO 120271"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.18014458),
        dec: Angle.Degrees(+04.77891258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 196.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20203"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94565986),
        dec: Angle.Degrees(+04.77894987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1608"},
        {"Hipparcos Number", "HIP 1628"},
        {"Geneva Identification System", "GEN# +1.00001608"},
        {"Smithsonian Astrophysical Observation", "SAO 109149"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.09018945),
        dec: Angle.Degrees(+04.77899775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152068"},
        {"Hipparcos Number", "HIP 82457"},
        {"Smithsonian Astrophysical Observation", "SAO 121903"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.76716596),
        dec: Angle.Degrees(+04.78319762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125093"},
        {"Hipparcos Number", "HIP 69806"},
        {"Smithsonian Astrophysical Observation", "SAO 120383"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.29481827),
        dec: Angle.Degrees(+04.78361910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83515"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.02097738),
        dec: Angle.Degrees(+04.78435927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41286"},
        {"Hipparcos Number", "HIP 28762"},
        {"Smithsonian Astrophysical Observation", "SAO 113421"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.11140154),
        dec: Angle.Degrees(+04.78581813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216296"},
        {"Hipparcos Number", "HIP 112891"},
        {"Geneva Identification System", "GEN# +1.00216296"},
        {"Smithsonian Astrophysical Observation", "SAO 127806"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.92329038),
        dec: Angle.Degrees(+04.78598352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25708"},
        {"Hipparcos Number", "HIP 19048"},
        {"Geneva Identification System", "GEN# +1.00025708"},
        {"Smithsonian Astrophysical Observation", "SAO 111594"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.21957562),
        dec: Angle.Degrees(+04.79088398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209501"},
        {"Hipparcos Number", "HIP 108920"},
        {"Smithsonian Astrophysical Observation", "SAO 127264"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.94823254),
        dec: Angle.Degrees(+04.79216029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148571"},
        {"Hipparcos Number", "HIP 80722"},
        {"Geneva Identification System", "GEN# +1.00148571"},
        {"Smithsonian Astrophysical Observation", "SAO 121630"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.21114341),
        dec: Angle.Degrees(+04.79364365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44260"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.20221700),
        dec: Angle.Degrees(+04.79423770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75168"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.41221689),
        dec: Angle.Degrees(+04.79813572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166333"},
        {"Hipparcos Number", "HIP 89015"},
        {"Smithsonian Astrophysical Observation", "SAO 123201"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.51179498),
        dec: Angle.Degrees(+04.80527892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38575"},
        {"Smithsonian Astrophysical Observation", "SAO 116086"},
    },
    visualMagnitude: 10.98,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.48142069),
        dec: Angle.Degrees(+04.80603022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222410"},
        {"Hipparcos Number", "HIP 116799"},
        {"Smithsonian Astrophysical Observation", "SAO 128314"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.07547215),
        dec: Angle.Degrees(+04.80648514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41605"},
        {"Smithsonian Astrophysical Observation", "SAO 116807"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.22844007),
        dec: Angle.Degrees(+04.80781826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86476"},
        {"Hipparcos Number", "HIP 48923"},
        {"Geneva Identification System", "GEN# +1.00086476"},
        {"Smithsonian Astrophysical Observation", "SAO 118029"},
        {"Wilson Evans Batten Catalogue", "WEB 9086"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.70319278),
        dec: Angle.Degrees(+04.80861806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3319"},
        {"Smithsonian Astrophysical Observation", "SAO 109390"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.58295763),
        dec: Angle.Degrees(+04.81051140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223903"},
        {"Hipparcos Number", "HIP 117804"},
        {"Geneva Identification System", "GEN# +1.00223903"},
        {"Smithsonian Astrophysical Observation", "SAO 128444"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.38430536),
        dec: Angle.Degrees(+04.81301120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10894"},
        {"Smithsonian Astrophysical Observation", "SAO 110479"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.05596357),
        dec: Angle.Degrees(+04.81318150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52479"},
        {"Hipparcos Number", "HIP 33854"},
        {"Geneva Identification System", "GEN# +1.00052479"},
        {"Smithsonian Astrophysical Observation", "SAO 114798"},
        {"Wilson Evans Batten Catalogue", "WEB 6798"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.42267559),
        dec: Angle.Degrees(+04.81809882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121199"},
        {"Hipparcos Number", "HIP 67853"},
        {"Smithsonian Astrophysical Observation", "SAO 120159"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.47330419),
        dec: Angle.Degrees(+04.81828390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14961"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.21322231),
        dec: Angle.Degrees(+04.81939786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26588"},
        {"Hipparcos Number", "HIP 19636"},
        {"Smithsonian Astrophysical Observation", "SAO 111660"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.11906319),
        dec: Angle.Degrees(+04.81981715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71497"},
        {"Hipparcos Number", "HIP 41509"},
        {"Geneva Identification System", "GEN# +1.00071497"},
        {"Smithsonian Astrophysical Observation", "SAO 116786"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98402382),
        dec: Angle.Degrees(+04.82146219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91667"},
        {"Hipparcos Number", "HIP 51825"},
        {"Smithsonian Astrophysical Observation", "SAO 118382"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.81373460),
        dec: Angle.Degrees(+04.82280073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62123"},
        {"Hipparcos Number", "HIP 37561"},
        {"Geneva Identification System", "GEN# +1.00062123"},
        {"Smithsonian Astrophysical Observation", "SAO 115827"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.64393630),
        dec: Angle.Degrees(+04.82340410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46223"},
        {"Hipparcos Number", "HIP 31149"},
        {"Celescope Catalog", "CEL 1287"},
        {"Geneva Identification System", "GEN# +2.22440203"},
        {"Smithsonian Astrophysical Observation", "SAO 114017"},
        {"Wilson Evans Batten Catalogue", "WEB 6217"},
        {"New General Catalogue", "NGC 2244 203"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.03878243),
        dec: Angle.Degrees(+04.82352893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19283"},
        {"Hipparcos Number", "HIP 14421"},
        {"Smithsonian Astrophysical Observation", "SAO 110965"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.54621382),
        dec: Angle.Degrees(+04.82369175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36776"},
        {"Hipparcos Number", "HIP 26132"},
        {"Celescope Catalog", "CEL 794"},
        {"Geneva Identification System", "GEN# +1.00036776"},
        {"Smithsonian Astrophysical Observation", "SAO 112905"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.58259660),
        dec: Angle.Degrees(+04.82507694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115983"},
        {"Hipparcos Number", "HIP 65106"},
        {"Smithsonian Astrophysical Observation", "SAO 119886"},
        {"Wilson Evans Batten Catalogue", "WEB 11499"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.14114147),
        dec: Angle.Degrees(+04.82712864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55575"},
        {"Smithsonian Astrophysical Observation", "SAO 118821"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.76334847),
        dec: Angle.Degrees(+04.82832129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104025"},
        {"Hipparcos Number", "HIP 58426"},
        {"Smithsonian Astrophysical Observation", "SAO 119146"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.69821919),
        dec: Angle.Degrees(+04.83139570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 543"},
        {"Hipparcos Number", "HIP 802"},
        {"Geneva Identification System", "GEN# +1.00000543"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.47912630),
        dec: Angle.Degrees(+04.83249243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8775"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21350698),
        dec: Angle.Degrees(+04.83276439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5929"},
        {"Hipparcos Number", "HIP 4737"},
        {"Geneva Identification System", "GEN# +1.00005929"},
        {"Smithsonian Astrophysical Observation", "SAO 109599"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.21116960),
        dec: Angle.Degrees(+04.83397162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139878"},
        {"Hipparcos Number", "HIP 76765"},
        {"Geneva Identification System", "GEN# +1.00139878"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.10933691),
        dec: Angle.Degrees(+04.83411756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133233"},
        {"Hipparcos Number", "HIP 73652"},
        {"Geneva Identification System", "GEN# +1.00133233"},
        {"Smithsonian Astrophysical Observation", "SAO 120814"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.83515719),
        dec: Angle.Degrees(+04.83414241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206467"},
        {"Hipparcos Number", "HIP 107142"},
        {"Smithsonian Astrophysical Observation", "SAO 126998"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.53632869),
        dec: Angle.Degrees(+04.83449528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43819"},
        {"Smithsonian Astrophysical Observation", "SAO 117266"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.86448954),
        dec: Angle.Degrees(+04.83472982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180482"},
        {"Hipparcos Number", "HIP 94727"},
        {"Geneva Identification System", "GEN# +1.00180482"},
        {"Smithsonian Astrophysical Observation", "SAO 124455"},
        {"Wilson Evans Batten Catalogue", "WEB 16523"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.12926242),
        dec: Angle.Degrees(+04.83482079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40616"},
        {"Hipparcos Number", "HIP 28428"},
        {"Geneva Identification System", "GEN# +1.00040616"},
        {"Smithsonian Astrophysical Observation", "SAO 113346"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.05758139),
        dec: Angle.Degrees(+04.83519391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35821"},
        {"Hipparcos Number", "HIP 25538"},
        {"Smithsonian Astrophysical Observation", "SAO 112790"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90846804),
        dec: Angle.Degrees(+04.83528931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132642"},
        {"Hipparcos Number", "HIP 73406"},
        {"Smithsonian Astrophysical Observation", "SAO 120780"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.01891494),
        dec: Angle.Degrees(+04.83616089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4446"},
        {"Hipparcos Number", "HIP 3658"},
        {"Smithsonian Astrophysical Observation", "SAO 109455"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.70810269),
        dec: Angle.Degrees(+04.83632867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108723"},
        {"Hipparcos Number", "HIP 60942"},
        {"Geneva Identification System", "GEN# +1.00108723"},
        {"Smithsonian Astrophysical Observation", "SAO 119428"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.36767893),
        dec: Angle.Degrees(+04.83814230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173274"},
        {"Hipparcos Number", "HIP 91909"},
        {"Smithsonian Astrophysical Observation", "SAO 123869"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.04846535),
        dec: Angle.Degrees(+04.83868836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157567"},
        {"Hipparcos Number", "HIP 85122"},
        {"Cincinnati Publication", "Ci 18 2321"},
        {"Smithsonian Astrophysical Observation", "SAO 122341"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95228467),
        dec: Angle.Degrees(+04.83889632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36979"},
        {"Hipparcos Number", "HIP 26255"},
        {"Celescope Catalog", "CEL 833"},
        {"Smithsonian Astrophysical Observation", "SAO 112933"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.87680370),
        dec: Angle.Degrees(+04.84102005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159737"},
        {"Hipparcos Number", "HIP 86135"},
        {"Smithsonian Astrophysical Observation", "SAO 122550"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.04061285),
        dec: Angle.Degrees(+04.84360892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2842"},
        {"Hipparcos Number", "HIP 2510"},
        {"Geneva Identification System", "GEN# +1.00002842"},
        {"Smithsonian Astrophysical Observation", "SAO 109254"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.95729925),
        dec: Angle.Degrees(+04.84621221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170316"},
        {"Hipparcos Number", "HIP 90547"},
        {"Geneva Identification System", "GEN# +1.00170316"},
        {"Smithsonian Astrophysical Observation", "SAO 123539"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.13969148),
        dec: Angle.Degrees(+04.84870114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38351"},
        {"Hipparcos Number", "HIP 27151"},
        {"Smithsonian Astrophysical Observation", "SAO 113104"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.33902793),
        dec: Angle.Degrees(+04.84891390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58369"},
        {"Hipparcos Number", "HIP 36028"},
        {"Smithsonian Astrophysical Observation", "SAO 115420"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.36203538),
        dec: Angle.Degrees(+04.85076825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38013"},
        {"Hipparcos Number", "HIP 26914"},
        {"Smithsonian Astrophysical Observation", "SAO 113060"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.70353673),
        dec: Angle.Degrees(+04.85239866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38674"},
        {"Hipparcos Number", "HIP 27360"},
        {"Smithsonian Astrophysical Observation", "SAO 113145"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.91600175),
        dec: Angle.Degrees(+04.85261935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128722"},
        {"Hipparcos Number", "HIP 71584"},
        {"Geneva Identification System", "GEN# +1.00128722"},
        {"Smithsonian Astrophysical Observation", "SAO 120583"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.60312765),
        dec: Angle.Degrees(+04.85426848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11526 AB"},
        {"Henry Draper", "HD 172190"},
        {"Hipparcos Number", "HIP 91418"},
        {"Geneva Identification System", "GEN# +3.47560095"},
        {"Smithsonian Astrophysical Observation", "SAO 123756"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.66606001),
        dec: Angle.Degrees(+04.85490696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107657"},
        {"Hipparcos Number", "HIP 60333"},
        {"Smithsonian Astrophysical Observation", "SAO 119357"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.56260808),
        dec: Angle.Degrees(+04.85495493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46241"},
        {"Hipparcos Number", "HIP 31159"},
        {"Geneva Identification System", "GEN# +2.22440266"},
        {"Smithsonian Astrophysical Observation", "SAO 114023"},
        {"Wilson Evans Batten Catalogue", "WEB 6221"},
        {"New General Catalogue", "NGC 2244 266"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08010878),
        dec: Angle.Degrees(+04.85599529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115819"},
        {"Geneva Identification System", "GEN# +0.00405012"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.95055097),
        dec: Angle.Degrees(+04.85621708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 435.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 180.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9611"},
        {"Smithsonian Astrophysical Observation", "SAO 110309"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88776854),
        dec: Angle.Degrees(+04.85688797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126514"},
        {"Hipparcos Number", "HIP 70549"},
        {"Geneva Identification System", "GEN# +1.00126514"},
        {"Smithsonian Astrophysical Observation", "SAO 120453"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.47846929),
        dec: Angle.Degrees(+04.85732170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162954"},
        {"Hipparcos Number", "HIP 87592"},
        {"Smithsonian Astrophysical Observation", "SAO 122886"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.39924264),
        dec: Angle.Degrees(+04.85898197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18385"},
        {"Smithsonian Astrophysical Observation", "SAO 111504"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.95149599),
        dec: Angle.Degrees(+04.86002623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2648"},
        {"Hipparcos Number", "HIP 2358"},
        {"Geneva Identification System", "GEN# +1.00002648"},
        {"Smithsonian Astrophysical Observation", "SAO 109238"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.53623440),
        dec: Angle.Degrees(+04.86007602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15614 AB"},
        {"Henry Draper", "HD 209795"},
        {"Hipparcos Number", "HIP 109078"},
        {"Smithsonian Astrophysical Observation", "SAO 127289"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46014234),
        dec: Angle.Degrees(+04.86503603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12939"},
        {"Smithsonian Astrophysical Observation", "SAO 110739"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.60286357),
        dec: Angle.Degrees(+04.86860736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223974"},
        {"Hipparcos Number", "HIP 117847"},
        {"Smithsonian Astrophysical Observation", "SAO 128451"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.52190110),
        dec: Angle.Degrees(+04.87121384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11182"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.00113318),
        dec: Angle.Degrees(+04.87176050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150525"},
        {"Hipparcos Number", "HIP 81717"},
        {"Fundamental Katalog 5th Edition", "FK5 5476"},
        {"Geneva Identification System", "GEN# +1.00150525"},
        {"Smithsonian Astrophysical Observation", "SAO 121788"},
        {"Wilson Evans Batten Catalogue", "WEB 13802"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.37582777),
        dec: Angle.Degrees(+04.87189353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44966"},
        {"Hipparcos Number", "HIP 30513"},
        {"Geneva Identification System", "GEN# +1.00044966"},
        {"Smithsonian Astrophysical Observation", "SAO 113840"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.20917400),
        dec: Angle.Degrees(+04.87208478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106362",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15067 A"},
        {"Henry Draper", "HD 205053"},
        {"Hipparcos Number", "HIP 106362"},
        {"Geneva Identification System", "GEN# +1.00205053"},
        {"Smithsonian Astrophysical Observation", "SAO 126875"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.13516697),
        dec: Angle.Degrees(+04.87328444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15938"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30580364),
        dec: Angle.Degrees(+04.87362324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218441"},
        {"Hipparcos Number", "HIP 114230"},
        {"Smithsonian Astrophysical Observation", "SAO 127986"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.01348706),
        dec: Angle.Degrees(+04.87425972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67027"},
        {"Cincinnati Publication", "Ci 20 798"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.04229593),
        dec: Angle.Degrees(+04.87701324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -450.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103340"},
        {"Hipparcos Number", "HIP 58027"},
        {"Fundamental Katalog 5th Edition", "FK5 5047"},
        {"Smithsonian Astrophysical Observation", "SAO 119101"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.51938067),
        dec: Angle.Degrees(+04.87911681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65900"},
        {"Hipparcos Number", "HIP 39213"},
        {"Geneva Identification System", "GEN# +1.00065900"},
        {"Smithsonian Astrophysical Observation", "SAO 116244"},
        {"Wilson Evans Batten Catalogue", "WEB 7688"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30795569),
        dec: Angle.Degrees(+04.87977849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36200"},
        {"Hipparcos Number", "HIP 25782"},
        {"Smithsonian Astrophysical Observation", "SAO 112835"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.57094415),
        dec: Angle.Degrees(+04.88004939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98631"},
        {"Hipparcos Number", "HIP 55423"},
        {"Geneva Identification System", "GEN# +1.00098631"},
        {"Smithsonian Astrophysical Observation", "SAO 118802"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.24608889),
        dec: Angle.Degrees(+04.88057723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101337"},
        {"Hipparcos Number", "HIP 56891"},
        {"Smithsonian Astrophysical Observation", "SAO 118978"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.94143286),
        dec: Angle.Degrees(+04.88080157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23645"},
        {"Hipparcos Number", "HIP 17645"},
        {"Smithsonian Astrophysical Observation", "SAO 111413"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70759338),
        dec: Angle.Degrees(+04.88080462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8055"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.86418912),
        dec: Angle.Degrees(+04.88084608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54213"},
        {"Smithsonian Astrophysical Observation", "SAO 118652"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.39140537),
        dec: Angle.Degrees(+04.88163570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75668"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.89455806),
        dec: Angle.Degrees(+04.88164564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2509 A"},
        {"Henry Draper", "HD 21018"},
        {"Henry Draper 2", "HD 21018A"},
        {"Hipparcos Number", "HIP 15807"},
        {"Geneva Identification System", "GEN# +1.00021018"},
        {"Smithsonian Astrophysical Observation", "SAO 111161"},
        {"Wilson Evans Batten Catalogue", "WEB 3019"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.91247448),
        dec: Angle.Degrees(+04.88211155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151292"},
        {"Hipparcos Number", "HIP 82107"},
        {"Cincinnati Publication", "Ci 18 2237"},
        {"Smithsonian Astrophysical Observation", "SAO 121848"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.57255713),
        dec: Angle.Degrees(+04.88521269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 988"},
        {"Hipparcos Number", "HIP 1149"},
        {"Geneva Identification System", "GEN# +1.00000988"},
        {"Smithsonian Astrophysical Observation", "SAO 109082"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58950411),
        dec: Angle.Degrees(+04.88585462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82675"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.50701798),
        dec: Angle.Degrees(+04.88615125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65604"},
        {"Hipparcos Number", "HIP 39075"},
        {"Smithsonian Astrophysical Observation", "SAO 116209"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.92138896),
        dec: Angle.Degrees(+04.88696563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33589"},
        {"Hipparcos Number", "HIP 24182"},
        {"Smithsonian Astrophysical Observation", "SAO 112503"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.88808779),
        dec: Angle.Degrees(+04.88697214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163697"},
        {"Hipparcos Number", "HIP 87901"},
        {"Smithsonian Astrophysical Observation", "SAO 122955"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.33287439),
        dec: Angle.Degrees(+04.88749277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25952"},
        {"Hipparcos Number", "HIP 19193"},
        {"Smithsonian Astrophysical Observation", "SAO 111607"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.69925491),
        dec: Angle.Degrees(+04.88838614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102376"},
        {"Hipparcos Number", "HIP 57490"},
        {"Smithsonian Astrophysical Observation", "SAO 119046"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75723775),
        dec: Angle.Degrees(+04.89273704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197607"},
        {"Hipparcos Number", "HIP 102383"},
        {"Smithsonian Astrophysical Observation", "SAO 126164"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.18710111),
        dec: Angle.Degrees(+04.89317246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223447"},
        {"Hipparcos Number", "HIP 117498"},
        {"Smithsonian Astrophysical Observation", "SAO 128403"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.39275077),
        dec: Angle.Degrees(+04.89363465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195909"},
        {"Hipparcos Number", "HIP 101489"},
        {"Fundamental Katalog 5th Edition", "FK5 1537"},
        {"Geneva Identification System", "GEN# +1.00195909"},
        {"Smithsonian Astrophysical Observation", "SAO 125961"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.49967349),
        dec: Angle.Degrees(+04.89868547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108157"},
        {"Hipparcos Number", "HIP 60626"},
        {"Geneva Identification System", "GEN# +1.00108157"},
        {"Smithsonian Astrophysical Observation", "SAO 119388"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.37611563),
        dec: Angle.Degrees(+04.89892225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18234"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.49027868),
        dec: Angle.Degrees(+04.90024075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122797"},
        {"Hipparcos Number", "HIP 68707"},
        {"Fundamental Katalog 5th Edition", "FK5 3118"},
        {"Geneva Identification System", "GEN# +1.00122797"},
        {"Smithsonian Astrophysical Observation", "SAO 120265"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.98234323),
        dec: Angle.Degrees(+04.90097991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155211"},
        {"Hipparcos Number", "HIP 83982"},
        {"Geneva Identification System", "GEN# +1.00155211"},
        {"Smithsonian Astrophysical Observation", "SAO 122143"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.52011336),
        dec: Angle.Degrees(+04.90252487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34098"},
        {"Hipparcos Number", "HIP 24467"},
        {"Geneva Identification System", "GEN# +1.00034098"},
        {"Smithsonian Astrophysical Observation", "SAO 112563"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.77435851),
        dec: Angle.Degrees(+04.90521498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97184"},
        {"Wilson Evans Batten Catalogue", "WEB 17063"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.29095812),
        dec: Angle.Degrees(+04.90617928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102800"},
        {"Hipparcos Number", "HIP 57713"},
        {"Geneva Identification System", "GEN# +1.00102800"},
        {"Smithsonian Astrophysical Observation", "SAO 119074"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.53330619),
        dec: Angle.Degrees(+04.90786166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -251.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215667"},
        {"Hipparcos Number", "HIP 112444"},
        {"Smithsonian Astrophysical Observation", "SAO 127752"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.66772225),
        dec: Angle.Degrees(+04.90801683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 903 A"},
        {"Henry Draper", "HD 6479"},
        {"Hipparcos Number", "HIP 5141"},
        {"Geneva Identification System", "GEN# +1.00006479"},
        {"Smithsonian Astrophysical Observation", "SAO 109666"},
        {"Wilson Evans Batten Catalogue", "WEB 1060"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.45509251),
        dec: Angle.Degrees(+04.90866194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 903 B"},
        {"Henry Draper", "HD 6480"},
        {"Hipparcos Number", "HIP 5144"},
        {"Geneva Identification System", "GEN# +1.00006480"},
        {"Smithsonian Astrophysical Observation", "SAO 109667"},
        {"Wilson Evans Batten Catalogue", "WEB 1068"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.46423982),
        dec: Angle.Degrees(+04.90971755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217018"},
        {"Hipparcos Number", "HIP 113361"},
        {"Smithsonian Astrophysical Observation", "SAO 127861"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.38965103),
        dec: Angle.Degrees(+04.91000117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53929"},
        {"Hipparcos Number", "HIP 34338"},
        {"Geneva Identification System", "GEN# +1.00053929"},
        {"Renson", "Renson 14830"},
        {"Smithsonian Astrophysical Observation", "SAO 114935"},
        {"Wilson Evans Batten Catalogue", "WEB 6877"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.77700298),
        dec: Angle.Degrees(+04.91059836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38361"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.85229454),
        dec: Angle.Degrees(+04.91090955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118128"},
        {"Hipparcos Number", "HIP 66256"},
        {"Smithsonian Astrophysical Observation", "SAO 120015"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.68502816),
        dec: Angle.Degrees(+04.91138574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47733"},
        {"Hipparcos Number", "HIP 31923"},
        {"Fundamental Katalog 5th Edition", "FK5 4607"},
        {"Smithsonian Astrophysical Observation", "SAO 114237"},
        {"Wilson Evans Batten Catalogue", "WEB 6415"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.07210686),
        dec: Angle.Degrees(+04.91140982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151027"},
        {"Hipparcos Number", "HIP 81969"},
        {"Smithsonian Astrophysical Observation", "SAO 121827"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.17216238),
        dec: Angle.Degrees(+04.91253193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40814"},
        {"Hipparcos Number", "HIP 28540"},
        {"Smithsonian Astrophysical Observation", "SAO 113375"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.37651624),
        dec: Angle.Degrees(+04.91288480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63140"},
        {"Hipparcos Number", "HIP 38024"},
        {"Geneva Identification System", "GEN# +1.00063140"},
        {"Smithsonian Astrophysical Observation", "SAO 115936"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89091880),
        dec: Angle.Degrees(+04.91413435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106544"},
        {"Hipparcos Number", "HIP 59762"},
        {"Smithsonian Astrophysical Observation", "SAO 119286"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.82366654),
        dec: Angle.Degrees(+04.91499893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155843"},
        {"Hipparcos Number", "HIP 84294"},
        {"Smithsonian Astrophysical Observation", "SAO 122197"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.49390310),
        dec: Angle.Degrees(+04.92063700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220619"},
        {"Hipparcos Number", "HIP 115611"},
        {"Smithsonian Astrophysical Observation", "SAO 128170"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.29887566),
        dec: Angle.Degrees(+04.92239960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156949"},
        {"Hipparcos Number", "HIP 84826"},
        {"Smithsonian Astrophysical Observation", "SAO 122287"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.05242780),
        dec: Angle.Degrees(+04.92338811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63021"},
        {"Hipparcos Number", "HIP 37974"},
        {"Smithsonian Astrophysical Observation", "SAO 115919"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.75168178),
        dec: Angle.Degrees(+04.92531609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167878"},
        {"Hipparcos Number", "HIP 89598"},
        {"Smithsonian Astrophysical Observation", "SAO 123321"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.25967227),
        dec: Angle.Degrees(+04.92614475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173245"},
        {"Hipparcos Number", "HIP 91908"},
        {"Geneva Identification System", "GEN# +1.00173245"},
        {"Smithsonian Astrophysical Observation", "SAO 123868"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.04692351),
        dec: Angle.Degrees(+04.92617155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342"},
        {"Hipparcos Number", "HIP 658"},
        {"Geneva Identification System", "GEN# +1.00000342"},
        {"Smithsonian Astrophysical Observation", "SAO 109025"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.02420888),
        dec: Angle.Degrees(+04.92733420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160885"},
        {"Hipparcos Number", "HIP 86644"},
        {"Geneva Identification System", "GEN# +1.00160885"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55685964),
        dec: Angle.Degrees(+04.92742286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68504"},
        {"Hipparcos Number", "HIP 40217"},
        {"Smithsonian Astrophysical Observation", "SAO 116481"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.21117393),
        dec: Angle.Degrees(+04.92854950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84298"},
        {"Hipparcos Number", "HIP 47767"},
        {"Geneva Identification System", "GEN# +1.00084298"},
        {"Smithsonian Astrophysical Observation", "SAO 117877"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.08648652),
        dec: Angle.Degrees(+04.92900292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220487"},
        {"Hipparcos Number", "HIP 115524"},
        {"Geneva Identification System", "GEN# +1.00220487"},
        {"Smithsonian Astrophysical Observation", "SAO 128159"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01828343),
        dec: Angle.Degrees(+04.93142506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104831"},
        {"Hipparcos Number", "HIP 58866"},
        {"Smithsonian Astrophysical Observation", "SAO 119200"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07840843),
        dec: Angle.Degrees(+04.93182700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37368"},
        {"Hipparcos Number", "HIP 26513"},
        {"Smithsonian Astrophysical Observation", "SAO 112985"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.56754497),
        dec: Angle.Degrees(+04.93397602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91193"},
        {"Hipparcos Number", "HIP 51555"},
        {"Smithsonian Astrophysical Observation", "SAO 118348"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.96197750),
        dec: Angle.Degrees(+04.93561337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179596"},
        {"Hipparcos Number", "HIP 94423"},
        {"Geneva Identification System", "GEN# +1.00179596"},
        {"Smithsonian Astrophysical Observation", "SAO 124397"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.27896725),
        dec: Angle.Degrees(+04.93567948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13169 AB"},
        {"Henry Draper", "HD 189044"},
        {"Hipparcos Number", "HIP 98272"},
        {"Geneva Identification System", "GEN# +1.00189044J"},
        {"Smithsonian Astrophysical Observation", "SAO 125286"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.51152384),
        dec: Angle.Degrees(+04.93576393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11477 A"},
        {"Henry Draper", "HD 171586"},
        {"Hipparcos Number", "HIP 91142"},
        {"Renson", "Renson 48090"},
        {"Smithsonian Astrophysical Observation", "SAO 123673"},
        {"Wilson Evans Batten Catalogue", "WEB 15652"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.90198202),
        dec: Angle.Degrees(+04.93606108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193840"},
        {"Hipparcos Number", "HIP 100459"},
        {"Smithsonian Astrophysical Observation", "SAO 125732"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.58084685),
        dec: Angle.Degrees(+04.93656405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135482"},
        {"Hipparcos Number", "HIP 74649"},
        {"Fundamental Katalog 5th Edition", "FK5 562"},
        {"Geneva Identification System", "GEN# +1.00135482"},
        {"Smithsonian Astrophysical Observation", "SAO 120916"},
        {"Wilson Evans Batten Catalogue", "WEB 12737"},
    },
    visualMagnitude: 5.32,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.79736045),
        dec: Angle.Degrees(+04.93935226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161848"},
        {"Hipparcos Number", "HIP 87089"},
        {"Cincinnati Publication", "Ci 20 1066"},
        {"Cincinnati Publication 2", "Ci 18 2366"},
        {"Geneva Identification System", "GEN# +3.46650096"},
        {"Smithsonian Astrophysical Observation", "SAO 122752"},
        {"Wilson Evans Batten Catalogue", "WEB 14693"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92671356),
        dec: Angle.Degrees(+04.94016994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -545.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217801"},
        {"Hipparcos Number", "HIP 113832"},
        {"Geneva Identification System", "GEN# +1.00217801"},
        {"Smithsonian Astrophysical Observation", "SAO 127926"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.77939575),
        dec: Angle.Degrees(+04.94034056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43516"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.94573406),
        dec: Angle.Degrees(+04.94079284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55088"},
        {"Hipparcos Number", "HIP 34759"},
        {"Geneva Identification System", "GEN# +1.00055088"},
        {"Smithsonian Astrophysical Observation", "SAO 115059"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.93268637),
        dec: Angle.Degrees(+04.94149233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105774"},
        {"Smithsonian Astrophysical Observation", "SAO 126785"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.33640074),
        dec: Angle.Degrees(+04.94283445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31130",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5165"},
        {"Henry Draper", "HD 46150"},
        {"Hipparcos Number", "HIP 31130"},
        {"Celescope Catalog", "CEL 1283"},
        {"Geneva Identification System", "GEN# +2.22440122"},
        {"Smithsonian Astrophysical Observation", "SAO 114010"},
        {"Wilson Evans Batten Catalogue", "WEB 6206"},
        {"New General Catalogue", "NGC 2244 122"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.98133765),
        dec: Angle.Degrees(+04.94285712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85762"},
        {"Hipparcos Number", "HIP 48552"},
        {"Smithsonian Astrophysical Observation", "SAO 117980"},
        {"Wilson Evans Batten Catalogue", "WEB 9042"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52799793),
        dec: Angle.Degrees(+04.94538293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62286"},
        {"Hipparcos Number", "HIP 37634"},
        {"Smithsonian Astrophysical Observation", "SAO 115846"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.83835851),
        dec: Angle.Degrees(+04.94580067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112829"},
        {"Hipparcos Number", "HIP 63396"},
        {"Smithsonian Astrophysical Observation", "SAO 119697"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.86377758),
        dec: Angle.Degrees(+04.94645318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3030"},
        {"Hipparcos Number", "HIP 2659"},
        {"Smithsonian Astrophysical Observation", "SAO 109276"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.42039564),
        dec: Angle.Degrees(+04.94783361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35969"},
        {"Hipparcos Number", "HIP 25640"},
        {"Smithsonian Astrophysical Observation", "SAO 112805"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.15041793),
        dec: Angle.Degrees(+04.94972736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24584"},
        {"Hipparcos Number", "HIP 18289"},
        {"Smithsonian Astrophysical Observation", "SAO 111495"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.67383127),
        dec: Angle.Degrees(+04.94978096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130191"},
        {"Hipparcos Number", "HIP 72269"},
        {"Geneva Identification System", "GEN# +1.00130191"},
        {"Smithsonian Astrophysical Observation", "SAO 120654"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.68717324),
        dec: Angle.Degrees(+04.94981572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130428"},
        {"Hipparcos Number", "HIP 72396"},
        {"Fundamental Katalog 5th Edition", "FK5 5311"},
        {"Smithsonian Astrophysical Observation", "SAO 120670"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.02702670),
        dec: Angle.Degrees(+04.95022909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27270"},
        {"Hipparcos Number", "HIP 20099"},
        {"Smithsonian Astrophysical Observation", "SAO 111732"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.63434017),
        dec: Angle.Degrees(+04.95189572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77389"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.96357221),
        dec: Angle.Degrees(+04.95266124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121459"},
        {"Hipparcos Number", "HIP 67987"},
        {"Smithsonian Astrophysical Observation", "SAO 120172"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.84016017),
        dec: Angle.Degrees(+04.95288116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1366"},
        {"Hipparcos Number", "HIP 1432"},
        {"Smithsonian Astrophysical Observation", "SAO 109120"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.46503064),
        dec: Angle.Degrees(+04.95335850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186143"},
        {"Hipparcos Number", "HIP 96962"},
        {"Smithsonian Astrophysical Observation", "SAO 124960"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64442564),
        dec: Angle.Degrees(+04.95386432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164045"},
        {"Hipparcos Number", "HIP 88056"},
        {"Geneva Identification System", "GEN# +1.00164045"},
        {"Smithsonian Astrophysical Observation", "SAO 122981"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76744901),
        dec: Angle.Degrees(+04.95474054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100837"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.68803653),
        dec: Angle.Degrees(+04.95493934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11494 A"},
        {"Henry Draper", "HD 171767"},
        {"Hipparcos Number", "HIP 91220"},
        {"Geneva Identification System", "GEN# +3.47560025"},
        {"Smithsonian Astrophysical Observation", "SAO 123688"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.12083367),
        dec: Angle.Degrees(+04.95508010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97859"},
        {"Hipparcos Number", "HIP 54985"},
        {"Geneva Identification System", "GEN# +0.00502468"},
        {"Geneva Identification System 2", "GEN# +1.00097859"},
        {"Renson", "Renson 28210"},
        {"Smithsonian Astrophysical Observation", "SAO 118749"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.87882721),
        dec: Angle.Degrees(+04.95655548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47240"},
        {"Hipparcos Number", "HIP 31697"},
        {"Geneva Identification System", "GEN# +1.00047240"},
        {"Smithsonian Astrophysical Observation", "SAO 114162"},
        {"Wilson Evans Batten Catalogue", "WEB 6357"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46960090),
        dec: Angle.Degrees(+04.95666675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39082"},
        {"Hipparcos Number", "HIP 27573"},
        {"Celescope Catalog", "CEL 1000"},
        {"Geneva Identification System", "GEN# +1.00039082"},
        {"Renson", "Renson 10500"},
        {"Smithsonian Astrophysical Observation", "SAO 113191"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.59937322),
        dec: Angle.Degrees(+04.95674386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14740"},
        {"Hipparcos Number", "HIP 11085"},
        {"Smithsonian Astrophysical Observation", "SAO 110500"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.68759450),
        dec: Angle.Degrees(+04.95705540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4941"},
        {"Smithsonian Astrophysical Observation", "SAO 109635"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85315912),
        dec: Angle.Degrees(+04.95767228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16548"},
    },
    visualMagnitude: 11.88,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.27180569),
        dec: Angle.Degrees(+04.95806359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61341"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.53303587),
        dec: Angle.Degrees(+04.96154228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94292"},
        {"Hipparcos Number", "HIP 53212"},
        {"Geneva Identification System", "GEN# +1.00094292"},
        {"Smithsonian Astrophysical Observation", "SAO 118562"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.25958987),
        dec: Angle.Degrees(+04.96195231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70986"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.79428633),
        dec: Angle.Degrees(+04.96298195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100948"},
        {"Hipparcos Number", "HIP 56668"},
        {"Smithsonian Astrophysical Observation", "SAO 118950"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.28881704),
        dec: Angle.Degrees(+04.96299304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10813 B"},
        {"Hipparcos Number", "HIP 87201"},
        {"Geneva Identification System", "GEN# +3.46650109"},
        {"Smithsonian Astrophysical Observation", "SAO 122779"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.23837057),
        dec: Angle.Degrees(+04.96326572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83651"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.45832463),
        dec: Angle.Degrees(+04.96343009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 135.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29959"},
        {"Hipparcos Number", "HIP 21976"},
        {"Geneva Identification System", "GEN# +1.00029959"},
        {"Smithsonian Astrophysical Observation", "SAO 112013"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.86373405),
        dec: Angle.Degrees(+04.96380565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116917"},
        {"Smithsonian Astrophysical Observation", "SAO 128334"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48437699),
        dec: Angle.Degrees(+04.96540559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10813 A"},
        {"Henry Draper", "HD 162056"},
        {"Hipparcos Number", "HIP 87202"},
        {"Geneva Identification System", "GEN# +3.46650108"},
        {"Smithsonian Astrophysical Observation", "SAO 122780"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.24100701),
        dec: Angle.Degrees(+04.96763981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46612"},
        {"Hipparcos Number", "HIP 31363"},
        {"Smithsonian Astrophysical Observation", "SAO 114079"},
        {"Wilson Evans Batten Catalogue", "WEB 6275"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.64838573),
        dec: Angle.Degrees(+04.96803126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215128"},
        {"Hipparcos Number", "HIP 112138"},
        {"Fundamental Katalog 5th Edition", "FK5 6001"},
        {"Smithsonian Astrophysical Observation", "SAO 127705"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72076358),
        dec: Angle.Degrees(+04.96876250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124351"},
        {"Hipparcos Number", "HIP 69436"},
        {"Smithsonian Astrophysical Observation", "SAO 120346"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24434671),
        dec: Angle.Degrees(+04.96922166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20513"},
        {"Hipparcos Number", "HIP 15365"},
        {"Geneva Identification System", "GEN# +1.00020513"},
        {"Smithsonian Astrophysical Observation", "SAO 111108"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.52694013),
        dec: Angle.Degrees(+04.96946229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111808"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.70883208),
        dec: Angle.Degrees(+04.96976397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83969"},
        {"Hipparcos Number", "HIP 47573"},
        {"Geneva Identification System", "GEN# +1.00083969"},
        {"Smithsonian Astrophysical Observation", "SAO 117858"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.50767272),
        dec: Angle.Degrees(+04.97004508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28880"},
        {"Hipparcos Number", "HIP 21226"},
        {"Geneva Identification System", "GEN# +1.00028880"},
        {"Smithsonian Astrophysical Observation", "SAO 111887"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.29100829),
        dec: Angle.Degrees(+04.97029707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135870"},
        {"Hipparcos Number", "HIP 74813"},
        {"Smithsonian Astrophysical Observation", "SAO 120929"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.33548897),
        dec: Angle.Degrees(+04.97102672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196795"},
        {"Hipparcos Number", "HIP 101955"},
        {"Cincinnati Publication", "Ci 20 1219"},
        {"Geneva Identification System", "GEN# +1.00196795"},
        {"Smithsonian Astrophysical Observation", "SAO 126068"},
        {"Wilson Evans Batten Catalogue", "WEB 18426"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90501773),
        dec: Angle.Degrees(+04.97185386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 862.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59644"},
        {"Hipparcos Number", "HIP 36548"},
        {"Smithsonian Astrophysical Observation", "SAO 115551"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.77372527),
        dec: Angle.Degrees(+04.97407326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1022"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.18764257),
        dec: Angle.Degrees(+04.97584483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108103"},
        {"Cincinnati Publication", "Ci 18 2847"},
        {"Geneva Identification System", "GEN# +0.00404762"},
        {"Smithsonian Astrophysical Observation", "SAO 127144"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54659951),
        dec: Angle.Degrees(+04.97914678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186490"},
        {"Hipparcos Number", "HIP 97136"},
        {"Smithsonian Astrophysical Observation", "SAO 125008"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.13182610),
        dec: Angle.Degrees(+04.97948350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85271"},
        {"Hipparcos Number", "HIP 48295"},
        {"Smithsonian Astrophysical Observation", "SAO 117940"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.70263417),
        dec: Angle.Degrees(+04.98133455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223416"},
        {"Hipparcos Number", "HIP 117475"},
        {"Smithsonian Astrophysical Observation", "SAO 128400"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.31042017),
        dec: Angle.Degrees(+04.98246730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175962"},
        {"Hipparcos Number", "HIP 93081"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.42041767),
        dec: Angle.Degrees(+04.98248541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29354"},
        {"Hipparcos Number", "HIP 21549"},
        {"Geneva Identification System", "GEN# +1.00029354"},
        {"Smithsonian Astrophysical Observation", "SAO 111937"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.40559480),
        dec: Angle.Degrees(+04.98281017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70466"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20107298),
        dec: Angle.Degrees(+04.98474802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109824"},
        {"Hipparcos Number", "HIP 61624"},
        {"Smithsonian Astrophysical Observation", "SAO 119501"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.45031909),
        dec: Angle.Degrees(+04.98541775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247829"},
        {"Hipparcos Number", "HIP 27389"},
        {"Smithsonian Astrophysical Observation", "SAO 113152"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.00801529),
        dec: Angle.Degrees(+04.98643020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144046"},
        {"Hipparcos Number", "HIP 78685"},
        {"Geneva Identification System", "GEN# +1.00144046"},
        {"Smithsonian Astrophysical Observation", "SAO 121339"},
        {"Wilson Evans Batten Catalogue", "WEB 13301"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.94047189),
        dec: Angle.Degrees(+04.98679189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163611"},
        {"Hipparcos Number", "HIP 87860"},
        {"Geneva Identification System", "GEN# +1.00163611"},
        {"Smithsonian Astrophysical Observation", "SAO 122946"},
        {"Wilson Evans Batten Catalogue", "WEB 14832"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21824571),
        dec: Angle.Degrees(+04.98741050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57555"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.95438150),
        dec: Angle.Degrees(+04.98804440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37884"},
        {"Hipparcos Number", "HIP 26835"},
        {"Geneva Identification System", "GEN# +1.00037884"},
        {"Smithsonian Astrophysical Observation", "SAO 113046"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.47339437),
        dec: Angle.Degrees(+04.98821462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16122"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.91706695),
        dec: Angle.Degrees(+04.98936282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19373"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.25027953),
        dec: Angle.Degrees(+04.99111791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96762"},
        {"Hipparcos Number", "HIP 54481"},
        {"Geneva Identification System", "GEN# +1.00096762"},
        {"Smithsonian Astrophysical Observation", "SAO 118684"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.19204819),
        dec: Angle.Degrees(+04.99238891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119301"},
        {"Hipparcos Number", "HIP 66881"},
        {"Smithsonian Astrophysical Observation", "SAO 120078"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59842987),
        dec: Angle.Degrees(+04.99371973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135325"},
        {"Hipparcos Number", "HIP 74585"},
        {"Smithsonian Astrophysical Observation", "SAO 120911"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.58975872),
        dec: Angle.Degrees(+04.99379283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153115"},
        {"Hipparcos Number", "HIP 82972"},
        {"Geneva Identification System", "GEN# +1.00153115"},
        {"Smithsonian Astrophysical Observation", "SAO 121958"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.33523410),
        dec: Angle.Degrees(+04.99456964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103359"},
        {"Hipparcos Number", "HIP 58037"},
        {"Geneva Identification System", "GEN# +1.00103359"},
        {"Smithsonian Astrophysical Observation", "SAO 119103"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.54157858),
        dec: Angle.Degrees(+04.99495618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86802"},
        {"Hipparcos Number", "HIP 49074"},
        {"Smithsonian Astrophysical Observation", "SAO 118050"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.24121462),
        dec: Angle.Degrees(+04.99538568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106350"},
        {"Hipparcos Number", "HIP 59655"},
        {"Geneva Identification System", "GEN# +1.00106350"},
        {"Smithsonian Astrophysical Observation", "SAO 119281"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.51544608),
        dec: Angle.Degrees(+04.99581876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14071"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.32841301),
        dec: Angle.Degrees(+04.99632506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219188"},
        {"Hipparcos Number", "HIP 114690"},
        {"Geneva Identification System", "GEN# +1.00219188"},
        {"Smithsonian Astrophysical Observation", "SAO 128051"},
        {"Wilson Evans Batten Catalogue", "WEB 20337"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.50213644),
        dec: Angle.Degrees(+04.99713232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191402"},
        {"Hipparcos Number", "HIP 99325"},
        {"Smithsonian Astrophysical Observation", "SAO 125509"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.40420053),
        dec: Angle.Degrees(+04.99759489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69235"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61902224),
        dec: Angle.Degrees(+04.99833463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10498 A"},
        {"Henry Draper", "HD 157261"},
        {"Hipparcos Number", "HIP 84975"},
        {"Fundamental Katalog 5th Edition", "FK5 5530"},
        {"Smithsonian Astrophysical Observation", "SAO 122316"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.51715715),
        dec: Angle.Degrees(+05.00097264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40188"},
        {"Hipparcos Number", "HIP 28190"},
        {"Geneva Identification System", "GEN# +1.00040188"},
        {"Smithsonian Astrophysical Observation", "SAO 113292"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.36551935),
        dec: Angle.Degrees(+05.00123868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40247"},
        {"Smithsonian Astrophysical Observation", "SAO 116485"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.30505393),
        dec: Angle.Degrees(+05.00180408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53165",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7959 AB"},
        {"Henry Draper", "HD 94220"},
        {"Hipparcos Number", "HIP 53165"},
        {"Cincinnati Publication", "Ci 18 1311"},
        {"Smithsonian Astrophysical Observation", "SAO 118554"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.14323746),
        dec: Angle.Degrees(+05.00270756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -333.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69341",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9146 AB"},
        {"Henry Draper", "HD 124140"},
        {"Hipparcos Number", "HIP 69341"},
        {"Smithsonian Astrophysical Observation", "SAO 120335"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.88104027),
        dec: Angle.Degrees(+05.00300320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87392"},
        {"Hipparcos Number", "HIP 49374"},
        {"Fundamental Katalog 5th Edition", "FK5 4895"},
        {"Geneva Identification System", "GEN# +1.00087392"},
        {"Smithsonian Astrophysical Observation", "SAO 118093"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.19810098),
        dec: Angle.Degrees(+05.00402360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218853"},
        {"Hipparcos Number", "HIP 114489"},
        {"Fundamental Katalog 5th Edition", "FK5 6047"},
        {"Smithsonian Astrophysical Observation", "SAO 128019"},
        {"Wilson Evans Batten Catalogue", "WEB 20318"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.80863417),
        dec: Angle.Degrees(+05.00432800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5130"},
        {"Hipparcos Number", "HIP 4173"},
        {"Smithsonian Astrophysical Observation", "SAO 109521"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.32947578),
        dec: Angle.Degrees(+05.00511136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6638"},
        {"Hipparcos Number", "HIP 5263"},
        {"Smithsonian Astrophysical Observation", "SAO 109685"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80843437),
        dec: Angle.Degrees(+05.00557504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216260"},
        {"Hipparcos Number", "HIP 112873"},
        {"Smithsonian Astrophysical Observation", "SAO 127801"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.86504721),
        dec: Angle.Degrees(+05.00703364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246268"},
        {"Hipparcos Number", "HIP 26705"},
        {"Smithsonian Astrophysical Observation", "SAO 113026"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12924168),
        dec: Angle.Degrees(+05.00807426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114417"},
        {"Hipparcos Number", "HIP 64265"},
        {"Smithsonian Astrophysical Observation", "SAO 119799"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58194372),
        dec: Angle.Degrees(+05.00908370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9753"},
        {"Hipparcos Number", "HIP 7414"},
        {"Smithsonian Astrophysical Observation", "SAO 109997"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.89409939),
        dec: Angle.Degrees(+05.01123239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65258"},
        {"Hipparcos Number", "HIP 38946"},
        {"Geneva Identification System", "GEN# +1.00065258"},
        {"Smithsonian Astrophysical Observation", "SAO 116180"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52573833),
        dec: Angle.Degrees(+05.01137178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71318"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.75691349),
        dec: Angle.Degrees(+05.01224413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158182"},
        {"Hipparcos Number", "HIP 85443"},
        {"Smithsonian Astrophysical Observation", "SAO 122403"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.90718652),
        dec: Angle.Degrees(+05.01252873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221235"},
        {"Hipparcos Number", "HIP 116004"},
        {"Smithsonian Astrophysical Observation", "SAO 128211"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.55616837),
        dec: Angle.Degrees(+05.01274673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13683"},
        {"Hipparcos Number", "HIP 10356"},
        {"Geneva Identification System", "GEN# +1.00013683"},
        {"Smithsonian Astrophysical Observation", "SAO 110415"},
        {"Wilson Evans Batten Catalogue", "WEB 2168"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.37386067),
        dec: Angle.Degrees(+05.01283375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2165"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.83047976),
        dec: Angle.Degrees(+05.01368811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70494"},
        {"Hipparcos Number", "HIP 41032"},
        {"Smithsonian Astrophysical Observation", "SAO 116685"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.61326614),
        dec: Angle.Degrees(+05.01610927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208642"},
        {"Hipparcos Number", "HIP 108395"},
        {"Smithsonian Astrophysical Observation", "SAO 127191"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40523213),
        dec: Angle.Degrees(+05.01623540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103209"},
        {"Smithsonian Astrophysical Observation", "SAO 126356"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.65261072),
        dec: Angle.Degrees(+05.01633121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159627"},
        {"Hipparcos Number", "HIP 86084"},
        {"Smithsonian Astrophysical Observation", "SAO 122541"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.88580472),
        dec: Angle.Degrees(+05.01684368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35773"},
        {"Hipparcos Number", "HIP 25507"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.81584911),
        dec: Angle.Degrees(+05.01918346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19392"},
        {"Hipparcos Number", "HIP 14496"},
        {"Smithsonian Astrophysical Observation", "SAO 110982"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.81151660),
        dec: Angle.Degrees(+05.01984236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2444 AB"},
        {"Henry Draper", "HD 20369"},
        {"Hipparcos Number", "HIP 15253"},
        {"Cincinnati Publication", "Ci 18 433"},
        {"Smithsonian Astrophysical Observation", "SAO 111089"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.19025515),
        dec: Angle.Degrees(+05.02012706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206298"},
        {"Hipparcos Number", "HIP 107063"},
        {"Geneva Identification System", "GEN# +1.00206298"},
        {"Smithsonian Astrophysical Observation", "SAO 126987"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.25920217),
        dec: Angle.Degrees(+05.02064693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145892"},
        {"Hipparcos Number", "HIP 79488"},
        {"Fundamental Katalog 5th Edition", "FK5 3283"},
        {"Geneva Identification System", "GEN# +1.00145892"},
        {"Smithsonian Astrophysical Observation", "SAO 121431"},
        {"Wilson Evans Batten Catalogue", "WEB 13448"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.31420074),
        dec: Angle.Degrees(+05.02109890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183919"},
        {"Hipparcos Number", "HIP 96038"},
        {"Smithsonian Astrophysical Observation", "SAO 124728"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.90992775),
        dec: Angle.Degrees(+05.02125228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160218"},
        {"Hipparcos Number", "HIP 86336"},
        {"Geneva Identification System", "GEN# +1.00160218"},
        {"Smithsonian Astrophysical Observation", "SAO 122591"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.62471766),
        dec: Angle.Degrees(+05.02198024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116459"},
        {"Geneva Identification System", "GEN# +9.80029051"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.96739667),
        dec: Angle.Degrees(+05.02219971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 395.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -370.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108397"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40789539),
        dec: Angle.Degrees(+05.02306507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203473"},
        {"Hipparcos Number", "HIP 105521"},
        {"Geneva Identification System", "GEN# +1.00203473"},
        {"Smithsonian Astrophysical Observation", "SAO 126740"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.57819249),
        dec: Angle.Degrees(+05.02359426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173705"},
        {"Hipparcos Number", "HIP 92123"},
        {"Smithsonian Astrophysical Observation", "SAO 123909"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.64520754),
        dec: Angle.Degrees(+05.02434600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27131"},
        {"Hipparcos Number", "HIP 19985"},
        {"Geneva Identification System", "GEN# +1.00027131"},
        {"Smithsonian Astrophysical Observation", "SAO 111719"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.29757254),
        dec: Angle.Degrees(+05.02460682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14962"},
        {"Hipparcos Number", "HIP 11251"},
        {"Geneva Identification System", "GEN# +1.00014962"},
        {"Smithsonian Astrophysical Observation", "SAO 110519"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.21006665),
        dec: Angle.Degrees(+05.02475965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198292"},
        {"Hipparcos Number", "HIP 102756"},
        {"Smithsonian Astrophysical Observation", "SAO 126252"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.30353310),
        dec: Angle.Degrees(+05.02524329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46106"},
        {"Hipparcos Number", "HIP 31106"},
        {"Celescope Catalog", "CEL 1278"},
        {"Geneva Identification System", "GEN# +2.22440115"},
        {"Smithsonian Astrophysical Observation", "SAO 114001"},
        {"Wilson Evans Batten Catalogue", "WEB 6196"},
        {"New General Catalogue", "NGC 2244 115"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.90999021),
        dec: Angle.Degrees(+05.02677445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201435"},
        {"Hipparcos Number", "HIP 104438"},
        {"Smithsonian Astrophysical Observation", "SAO 126581"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.33814273),
        dec: Angle.Degrees(+05.02841270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37053"},
        {"Hipparcos Number", "HIP 26287"},
        {"Geneva Identification System", "GEN# +1.00037053"},
        {"Smithsonian Astrophysical Observation", "SAO 112939"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.96439304),
        dec: Angle.Degrees(+05.02891833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184201"},
        {"Hipparcos Number", "HIP 96159"},
        {"Smithsonian Astrophysical Observation", "SAO 124777"},
        {"Wilson Evans Batten Catalogue", "WEB 16847"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.28235990),
        dec: Angle.Degrees(+05.02939398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26606"},
        {"Hipparcos Number", "HIP 19657"},
        {"Geneva Identification System", "GEN# +1.00026606"},
        {"Smithsonian Astrophysical Observation", "SAO 111663"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.18105428),
        dec: Angle.Degrees(+05.03087607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140255"},
        {"Hipparcos Number", "HIP 76925"},
        {"Smithsonian Astrophysical Observation", "SAO 121135"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.60802869),
        dec: Angle.Degrees(+05.03183054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93981"},
        {"Hipparcos Number", "HIP 53032"},
        {"Smithsonian Astrophysical Observation", "SAO 118531"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.76073614),
        dec: Angle.Degrees(+05.03229978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46149"},
        {"Hipparcos Number", "HIP 31128"},
        {"Celescope Catalog", "CEL 1282"},
        {"Geneva Identification System", "GEN# +2.22440114"},
        {"Smithsonian Astrophysical Observation", "SAO 114009"},
        {"Wilson Evans Batten Catalogue", "WEB 6205"},
        {"New General Catalogue", "NGC 2244 114"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.96888705),
        dec: Angle.Degrees(+05.03310484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108024"},
        {"Hipparcos Number", "HIP 60541"},
        {"Geneva Identification System", "GEN# +1.00108024"},
        {"Smithsonian Astrophysical Observation", "SAO 119380"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.16420272),
        dec: Angle.Degrees(+05.03551648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60044"},
        {"Hipparcos Number", "HIP 36693"},
        {"Smithsonian Astrophysical Observation", "SAO 115601"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.21891470),
        dec: Angle.Degrees(+05.03585708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218303"},
        {"Hipparcos Number", "HIP 114126"},
        {"Smithsonian Astrophysical Observation", "SAO 127971"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.69407579),
        dec: Angle.Degrees(+05.03589266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111292"},
        {"Hipparcos Number", "HIP 62477"},
        {"Smithsonian Astrophysical Observation", "SAO 119601"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.05972443),
        dec: Angle.Degrees(+05.03600295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77210"},
        {"Geneva Identification System", "GEN# +0.00503080"},
        {"Smithsonian Astrophysical Observation", "SAO 121177"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46894832),
        dec: Angle.Degrees(+05.04054416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110028"},
        {"Hipparcos Number", "HIP 61745"},
        {"Smithsonian Astrophysical Observation", "SAO 119515"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81726555),
        dec: Angle.Degrees(+05.04077216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50628"},
        {"Smithsonian Astrophysical Observation", "SAO 118239"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.11774632),
        dec: Angle.Degrees(+05.04104884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174717"},
        {"Hipparcos Number", "HIP 92566"},
        {"Smithsonian Astrophysical Observation", "SAO 123983"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.93297712),
        dec: Angle.Degrees(+05.04411730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135166"},
        {"Hipparcos Number", "HIP 74508"},
        {"Smithsonian Astrophysical Observation", "SAO 120902"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.38318440),
        dec: Angle.Degrees(+05.04428550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35119"},
        {"Smithsonian Astrophysical Observation", "SAO 115161"},
    },
    visualMagnitude: 10.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.91098530),
        dec: Angle.Degrees(+05.04464306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9797 AB"},
        {"Henry Draper", "HD 141512"},
        {"Hipparcos Number", "HIP 77489"},
        {"Smithsonian Astrophysical Observation", "SAO 121206"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.33391305),
        dec: Angle.Degrees(+05.04535880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75204"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.52681735),
        dec: Angle.Degrees(+05.04568927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18060"},
        {"Hipparcos Number", "HIP 13526"},
        {"Smithsonian Astrophysical Observation", "SAO 110822"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.55229448),
        dec: Angle.Degrees(+05.04833981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42493"},
        {"Hipparcos Number", "HIP 29341"},
        {"Smithsonian Astrophysical Observation", "SAO 113561"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.79888664),
        dec: Angle.Degrees(+05.05005022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83087"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.66399740),
        dec: Angle.Degrees(+05.05043824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82029"},
        {"Hipparcos Number", "HIP 46542"},
        {"Smithsonian Astrophysical Observation", "SAO 117729"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.38173516),
        dec: Angle.Degrees(+05.05189868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54120"},
        {"Smithsonian Astrophysical Observation", "SAO 118647"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10272456),
        dec: Angle.Degrees(+05.05221667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108986"},
        {"Hipparcos Number", "HIP 61104"},
        {"Geneva Identification System", "GEN# +1.00108986"},
        {"Smithsonian Astrophysical Observation", "SAO 119454"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.84329224),
        dec: Angle.Degrees(+05.05284793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17435"},
        {"Smithsonian Astrophysical Observation", "SAO 111382"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.02447994),
        dec: Angle.Degrees(+05.05554611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7671"},
        {"Hipparcos Number", "HIP 5969"},
        {"Smithsonian Astrophysical Observation", "SAO 109776"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.18529927),
        dec: Angle.Degrees(+05.05565535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47157",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7453 AB"},
        {"Henry Draper", "HD 83148"},
        {"Hipparcos Number", "HIP 47157"},
        {"Smithsonian Astrophysical Observation", "SAO 117803"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.13907371),
        dec: Angle.Degrees(+05.05573928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224032"},
        {"Hipparcos Number", "HIP 117877"},
        {"Smithsonian Astrophysical Observation", "SAO 128459"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.65126014),
        dec: Angle.Degrees(+05.05672546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209747"},
        {"Hipparcos Number", "HIP 109068"},
        {"Geneva Identification System", "GEN# +1.00209747"},
        {"Smithsonian Astrophysical Observation", "SAO 127285"},
        {"Wilson Evans Batten Catalogue", "WEB 19610"},
    },
    visualMagnitude: 4.86,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.41954990),
        dec: Angle.Degrees(+05.05828453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90616"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.35484142),
        dec: Angle.Degrees(+05.05945762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212456"},
        {"Hipparcos Number", "HIP 110596"},
        {"Smithsonian Astrophysical Observation", "SAO 127508"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.08738239),
        dec: Angle.Degrees(+05.06056544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6101"},
        {"Hipparcos Number", "HIP 4849"},
        {"Cincinnati Publication", "Ci 20 69"},
        {"Geneva Identification System", "GEN# +1.00006101"},
        {"Smithsonian Astrophysical Observation", "SAO 109617"},
        {"Wilson Evans Batten Catalogue", "WEB 937"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.60155392),
        dec: Angle.Degrees(+05.06090960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 221.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102867"},
        {"Smithsonian Astrophysical Observation", "SAO 126276"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.61175314),
        dec: Angle.Degrees(+05.06134250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9334 AB"},
        {"Henry Draper", "HD 129006"},
        {"Hipparcos Number", "HIP 71710"},
        {"Smithsonian Astrophysical Observation", "SAO 120592"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.02547186),
        dec: Angle.Degrees(+05.06693864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165030"},
        {"Hipparcos Number", "HIP 88468"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.96316295),
        dec: Angle.Degrees(+05.06836529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177257"},
        {"Hipparcos Number", "HIP 93606"},
        {"Smithsonian Astrophysical Observation", "SAO 124211"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.93738118),
        dec: Angle.Degrees(+05.06958426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142575"},
        {"Hipparcos Number", "HIP 77946"},
        {"Geneva Identification System", "GEN# +1.00142575"},
        {"Smithsonian Astrophysical Observation", "SAO 121258"},
        {"Wilson Evans Batten Catalogue", "WEB 13181"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.76250733),
        dec: Angle.Degrees(+05.06997331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -280.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69720"},
        {"Hipparcos Number", "HIP 40684"},
        {"Smithsonian Astrophysical Observation", "SAO 116603"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.58891235),
        dec: Angle.Degrees(+05.07418523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108894"},
        {"Hipparcos Number", "HIP 61046"},
        {"Smithsonian Astrophysical Observation", "SAO 119440"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.67831801),
        dec: Angle.Degrees(+05.07427476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56202"},
        {"Hipparcos Number", "HIP 35185"},
        {"Geneva Identification System", "GEN# +1.00056202"},
        {"Smithsonian Astrophysical Observation", "SAO 115174"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.07735741),
        dec: Angle.Degrees(+05.07618337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42318"},
        {"Smithsonian Astrophysical Observation", "SAO 116966"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41910144),
        dec: Angle.Degrees(+05.07685494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188266"},
        {"Hipparcos Number", "HIP 97932"},
        {"Smithsonian Astrophysical Observation", "SAO 125203"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.54367680),
        dec: Angle.Degrees(+05.08008873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199454"},
        {"Hipparcos Number", "HIP 103419"},
        {"Smithsonian Astrophysical Observation", "SAO 126399"},
        {"Wilson Evans Batten Catalogue", "WEB 18806"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.30346657),
        dec: Angle.Degrees(+05.08039486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244618"},
        {"Hipparcos Number", "HIP 25909"},
        {"Smithsonian Astrophysical Observation", "SAO 112875"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.94703890),
        dec: Angle.Degrees(+05.08140237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2928 AB"},
        {"Henry Draper", "HD 25248"},
        {"Hipparcos Number", "HIP 18734"},
        {"Geneva Identification System", "GEN# +1.00025248J"},
        {"Smithsonian Astrophysical Observation", "SAO 111558"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.19704586),
        dec: Angle.Degrees(+05.08284210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147353"},
        {"Hipparcos Number", "HIP 80138"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.35159602),
        dec: Angle.Degrees(+05.08400947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50083"},
        {"Hipparcos Number", "HIP 32947"},
        {"Geneva Identification System", "GEN# +1.00050083"},
        {"Smithsonian Astrophysical Observation", "SAO 114528"},
        {"Wilson Evans Batten Catalogue", "WEB 6634"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.94063899),
        dec: Angle.Degrees(+05.08441060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169578"},
        {"Hipparcos Number", "HIP 90271"},
        {"Geneva Identification System", "GEN# +1.00169578"},
        {"Smithsonian Astrophysical Observation", "SAO 123453"},
        {"Wilson Evans Batten Catalogue", "WEB 15444"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.28698192),
        dec: Angle.Degrees(+05.08455364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10184"},
        {"Smithsonian Astrophysical Observation", "SAO 110385"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.73314923),
        dec: Angle.Degrees(+05.08492443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92014"},
        {"Hipparcos Number", "HIP 52014"},
        {"Smithsonian Astrophysical Observation", "SAO 118399"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.40272994),
        dec: Angle.Degrees(+05.08636529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139424"},
        {"Hipparcos Number", "HIP 76544"},
        {"Geneva Identification System", "GEN# +1.00139424"},
        {"Smithsonian Astrophysical Observation", "SAO 121099"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.49907857),
        dec: Angle.Degrees(+05.09203982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77996"},
        {"Hipparcos Number", "HIP 44659"},
        {"Fundamental Katalog 5th Edition", "FK5 2717"},
        {"Geneva Identification System", "GEN# +1.00077996"},
        {"Smithsonian Astrophysical Observation", "SAO 117420"},
        {"Wilson Evans Batten Catalogue", "WEB 8543"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.49324097),
        dec: Angle.Degrees(+05.09234249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187658"},
        {"Hipparcos Number", "HIP 97672"},
        {"Smithsonian Astrophysical Observation", "SAO 125128"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.74991133),
        dec: Angle.Degrees(+05.09494822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54660"},
        {"Smithsonian Astrophysical Observation", "SAO 118707"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.83491997),
        dec: Angle.Degrees(+05.09659577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3596 AB"},
        {"Henry Draper", "HD 32022"},
        {"Hipparcos Number", "HIP 23277"},
        {"Geneva Identification System", "GEN# +1.00032022"},
        {"Smithsonian Astrophysical Observation", "SAO 112303"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.12360707),
        dec: Angle.Degrees(+05.09904387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91740"},
        {"Hipparcos Number", "HIP 51855"},
        {"Smithsonian Astrophysical Observation", "SAO 118386"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.92454860),
        dec: Angle.Degrees(+05.09933148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43587"},
        {"Hipparcos Number", "HIP 29860"},
        {"Geneva Identification System", "GEN# +1.00043587A"},
        {"Smithsonian Astrophysical Observation", "SAO 113683"},
        {"Wilson Evans Batten Catalogue", "WEB 5912"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.31770235),
        dec: Angle.Degrees(+05.09969578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38443"},
        {"Hipparcos Number", "HIP 27211"},
        {"Fundamental Katalog 5th Edition", "FK5 4529"},
        {"Smithsonian Astrophysical Observation", "SAO 113116"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.51095278),
        dec: Angle.Degrees(+05.10074360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95529"},
        {"Hipparcos Number", "HIP 53899"},
        {"Smithsonian Astrophysical Observation", "SAO 118622"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.42540428),
        dec: Angle.Degrees(+05.10208169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51331"},
        {"Hipparcos Number", "HIP 33435"},
        {"Smithsonian Astrophysical Observation", "SAO 114675"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.28803766),
        dec: Angle.Degrees(+05.10233352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86277"},
        {"Hipparcos Number", "HIP 48820"},
        {"Geneva Identification System", "GEN# +1.00086277"},
        {"Smithsonian Astrophysical Observation", "SAO 118016"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.37585182),
        dec: Angle.Degrees(+05.10338578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3743"},
        {"Smithsonian Astrophysical Observation", "SAO 109464"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.01022731),
        dec: Angle.Degrees(+05.10353872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112756"},
        {"Hipparcos Number", "HIP 63354"},
        {"Geneva Identification System", "GEN# +1.00112756"},
        {"Smithsonian Astrophysical Observation", "SAO 119691"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.72979802),
        dec: Angle.Degrees(+05.10628544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65717"},
        {"Smithsonian Astrophysical Observation", "SAO 119943"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.09584858),
        dec: Angle.Degrees(+05.10684662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206634"},
        {"Hipparcos Number", "HIP 107245"},
        {"Smithsonian Astrophysical Observation", "SAO 127013"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.82643109),
        dec: Angle.Degrees(+05.10894656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18011"},
        {"Hipparcos Number", "HIP 13494"},
        {"Geneva Identification System", "GEN# +1.00018011"},
        {"Smithsonian Astrophysical Observation", "SAO 110818"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.43742256),
        dec: Angle.Degrees(+05.10939376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50636"},
        {"Hipparcos Number", "HIP 33174"},
        {"Smithsonian Astrophysical Observation", "SAO 114587"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.57619354),
        dec: Angle.Degrees(+05.11013165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140102"},
        {"Hipparcos Number", "HIP 76861"},
        {"Smithsonian Astrophysical Observation", "SAO 121128"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.43184012),
        dec: Angle.Degrees(+05.11120965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181636"},
        {"Hipparcos Number", "HIP 95121"},
        {"Smithsonian Astrophysical Observation", "SAO 124533"},
        {"Wilson Evans Batten Catalogue", "WEB 16614"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.26419038),
        dec: Angle.Degrees(+05.11169091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98452"},
        {"Hipparcos Number", "HIP 55321"},
        {"Smithsonian Astrophysical Observation", "SAO 118790"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92858208),
        dec: Angle.Degrees(+05.11415009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43406"},
        {"Hipparcos Number", "HIP 29780"},
        {"Celescope Catalog", "CEL 1153"},
        {"Fundamental Katalog 5th Edition", "FK5 4568"},
        {"Geneva Identification System", "GEN# +1.00043406"},
        {"Smithsonian Astrophysical Observation", "SAO 113664"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.05779070),
        dec: Angle.Degrees(+05.11417130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18732"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.18811101),
        dec: Angle.Degrees(+05.11538931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67186",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9019 AB"},
        {"Henry Draper", "HD 119931"},
        {"Hipparcos Number", "HIP 67186"},
        {"Geneva Identification System", "GEN# +1.00119931"},
        {"Smithsonian Astrophysical Observation", "SAO 120102"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.52838488),
        dec: Angle.Degrees(+05.11565888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16967 AB"},
        {"Henry Draper", "HD 222948"},
        {"Hipparcos Number", "HIP 117169"},
        {"Smithsonian Astrophysical Observation", "SAO 128364"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.32598137),
        dec: Angle.Degrees(+05.11628458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121862"},
        {"Hipparcos Number", "HIP 68215"},
        {"Geneva Identification System", "GEN# +1.00121862"},
        {"Smithsonian Astrophysical Observation", "SAO 120196"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.48663328),
        dec: Angle.Degrees(+05.11777463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98333"},
        {"Hipparcos Number", "HIP 55232"},
        {"Smithsonian Astrophysical Observation", "SAO 118775"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.65916045),
        dec: Angle.Degrees(+05.12206624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82541"},
        {"Hipparcos Number", "HIP 46846"},
        {"Smithsonian Astrophysical Observation", "SAO 117758"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.18502321),
        dec: Angle.Degrees(+05.12294714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160199"},
        {"Hipparcos Number", "HIP 86332"},
        {"Smithsonian Astrophysical Observation", "SAO 122589"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.60049332),
        dec: Angle.Degrees(+05.12509221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44586"},
        {"Hipparcos Number", "HIP 30327"},
        {"Celescope Catalog", "CEL 1202"},
        {"Geneva Identification System", "GEN# +1.00044586"},
        {"Smithsonian Astrophysical Observation", "SAO 113788"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.68588592),
        dec: Angle.Degrees(+05.12553067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2681 A"},
        {"Henry Draper", "HD 22878"},
        {"Hipparcos Number", "HIP 17155"},
        {"Geneva Identification System", "GEN# +1.00022878"},
        {"Smithsonian Astrophysical Observation", "SAO 111340"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.11682406),
        dec: Angle.Degrees(+05.12589327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45762"},
        {"Smithsonian Astrophysical Observation", "SAO 117592"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.97213082),
        dec: Angle.Degrees(+05.12720097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45444"},
        {"Smithsonian Astrophysical Observation", "SAO 117543"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.91669871),
        dec: Angle.Degrees(+05.12741624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156286"},
        {"Hipparcos Number", "HIP 84495"},
        {"Smithsonian Astrophysical Observation", "SAO 122228"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.12051135),
        dec: Angle.Degrees(+05.12824683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2681 B"},
        {"Hipparcos Number", "HIP 17158"},
        {"Smithsonian Astrophysical Observation", "SAO 111341"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.12295330),
        dec: Angle.Degrees(+05.12992020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180945"},
        {"Hipparcos Number", "HIP 94873"},
        {"Geneva Identification System", "GEN# +1.00180945"},
        {"Smithsonian Astrophysical Observation", "SAO 124484"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.59696645),
        dec: Angle.Degrees(+05.13099892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53113"},
        {"Hipparcos Number", "HIP 34078"},
        {"Smithsonian Astrophysical Observation", "SAO 114858"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00952936),
        dec: Angle.Degrees(+05.13197984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4790"},
        {"Smithsonian Astrophysical Observation", "SAO 109606"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.38306247),
        dec: Angle.Degrees(+05.13454264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168202"},
        {"Hipparcos Number", "HIP 89705"},
        {"Smithsonian Astrophysical Observation", "SAO 123343"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.61735997),
        dec: Angle.Degrees(+05.13528231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114822"},
        {"Hipparcos Number", "HIP 64483"},
        {"Smithsonian Astrophysical Observation", "SAO 119819"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.25968644),
        dec: Angle.Degrees(+05.13633443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67373"},
        {"Hipparcos Number", "HIP 39789"},
        {"Geneva Identification System", "GEN# +1.00067373"},
        {"Smithsonian Astrophysical Observation", "SAO 116375"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.96157768),
        dec: Angle.Degrees(+05.13719405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72304"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.78640131),
        dec: Angle.Degrees(+05.13944293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101443"},
        {"Hipparcos Number", "HIP 56951"},
        {"Geneva Identification System", "GEN# +1.00101443"},
        {"Smithsonian Astrophysical Observation", "SAO 118983"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.12190286),
        dec: Angle.Degrees(+05.13994188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101495"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.51920892),
        dec: Angle.Degrees(+05.14162427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57058"},
        {"Geneva Identification System", "GEN# +0.00502529"},
        {"Wilson Evans Batten Catalogue", "WEB 10272"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.45608550),
        dec: Angle.Degrees(+05.14184525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -476.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7355"},
        {"Hipparcos Number", "HIP 5752"},
        {"Fundamental Katalog 5th Edition", "FK5 4108"},
        {"Geneva Identification System", "GEN# +1.00007355"},
        {"Smithsonian Astrophysical Observation", "SAO 109743"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46487383),
        dec: Angle.Degrees(+05.14189295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21569"},
        {"Hipparcos Number", "HIP 16219"},
        {"Smithsonian Astrophysical Observation", "SAO 111213"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.23792523),
        dec: Angle.Degrees(+05.14190564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110168"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.72122119),
        dec: Angle.Degrees(+05.14274616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211516"},
        {"Hipparcos Number", "HIP 110058"},
        {"Fundamental Katalog 5th Edition", "FK5 5966"},
        {"Smithsonian Astrophysical Observation", "SAO 127434"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.37401052),
        dec: Angle.Degrees(+05.14419906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88818"},
        {"Hipparcos Number", "HIP 50193"},
        {"Smithsonian Astrophysical Observation", "SAO 118182"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.69074603),
        dec: Angle.Degrees(+05.14736856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265555"},
        {"Hipparcos Number", "HIP 32997"},
        {"Smithsonian Astrophysical Observation", "SAO 114549"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.11990682),
        dec: Angle.Degrees(+05.14917873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28069"},
        {"Hipparcos Number", "HIP 20693"},
        {"Geneva Identification System", "GEN# +5.20250061"},
        {"Smithsonian Astrophysical Observation", "SAO 111811"},
        {"Wilson Evans Batten Catalogue", "WEB 3967"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.48867647),
        dec: Angle.Degrees(+05.15013362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104324",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14666 AB"},
        {"Henry Draper", "HD 201221"},
        {"Hipparcos Number", "HIP 104324"},
        {"Smithsonian Astrophysical Observation", "SAO 126562"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00283720),
        dec: Angle.Degrees(+05.15165727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54188"},
        {"Smithsonian Astrophysical Observation", "SAO 118649"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.27070538),
        dec: Angle.Degrees(+05.15192782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21788"},
        {"Hipparcos Number", "HIP 16363"},
        {"Geneva Identification System", "GEN# +1.00021788"},
        {"Smithsonian Astrophysical Observation", "SAO 111233"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.69863765),
        dec: Angle.Degrees(+05.15266418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173669"},
        {"Hipparcos Number", "HIP 92109"},
        {"Smithsonian Astrophysical Observation", "SAO 123904"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.58184664),
        dec: Angle.Degrees(+05.15317218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81185"},
        {"Smithsonian Astrophysical Observation", "SAO 121708"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.73979048),
        dec: Angle.Degrees(+05.15346920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116235"},
        {"Hipparcos Number", "HIP 65241"},
        {"Geneva Identification System", "GEN# +1.00116235"},
        {"Renson", "Renson 33550"},
        {"Smithsonian Astrophysical Observation", "SAO 119905"},
        {"Wilson Evans Batten Catalogue", "WEB 11514"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.54054052),
        dec: Angle.Degrees(+05.15485074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34043"},
        {"Hipparcos Number", "HIP 24450"},
        {"Fundamental Katalog 5th Edition", "FK5 2394"},
        {"Geneva Identification System", "GEN# +1.00034043"},
        {"Smithsonian Astrophysical Observation", "SAO 112556"},
        {"Wilson Evans Batten Catalogue", "WEB 4737"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.68355139),
        dec: Angle.Degrees(+05.15612934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223870"},
        {"Hipparcos Number", "HIP 117787"},
        {"Smithsonian Astrophysical Observation", "SAO 128441"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.30031060),
        dec: Angle.Degrees(+05.15756932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217352"},
        {"Hipparcos Number", "HIP 113556"},
        {"Smithsonian Astrophysical Observation", "SAO 127885"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.99735139),
        dec: Angle.Degrees(+05.15959402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163442"},
        {"Hipparcos Number", "HIP 87790"},
        {"Geneva Identification System", "GEN# +1.00163442"},
        {"Smithsonian Astrophysical Observation", "SAO 122929"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.00492030),
        dec: Angle.Degrees(+05.16147646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115407"},
        {"Hipparcos Number", "HIP 64800"},
        {"Smithsonian Astrophysical Observation", "SAO 119851"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.21940521),
        dec: Angle.Degrees(+05.16157034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28487"},
        {"Hipparcos Number", "HIP 20958"},
        {"Geneva Identification System", "GEN# +1.00028487"},
        {"Smithsonian Astrophysical Observation", "SAO 111851"},
        {"Wilson Evans Batten Catalogue", "WEB 4030"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.41220970),
        dec: Angle.Degrees(+05.16430847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39398"},
        {"Hipparcos Number", "HIP 27773"},
        {"Geneva Identification System", "GEN# +1.00039398"},
        {"Smithsonian Astrophysical Observation", "SAO 113223"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.15475485),
        dec: Angle.Degrees(+05.16460382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24180"},
        {"Hipparcos Number", "HIP 18026"},
        {"Geneva Identification System", "GEN# +1.00024180"},
        {"Smithsonian Astrophysical Observation", "SAO 111461"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.78750303),
        dec: Angle.Degrees(+05.16643257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154598"},
        {"Hipparcos Number", "HIP 83685"},
        {"Geneva Identification System", "GEN# +1.00154598"},
        {"Smithsonian Astrophysical Observation", "SAO 122074"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54934671),
        dec: Angle.Degrees(+05.16838140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203615"},
        {"Hipparcos Number", "HIP 105591"},
        {"Smithsonian Astrophysical Observation", "SAO 126753"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.80630748),
        dec: Angle.Degrees(+05.16850847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43062"},
        {"Hipparcos Number", "HIP 29611"},
        {"Geneva Identification System", "GEN# +1.00043062"},
        {"Smithsonian Astrophysical Observation", "SAO 113616"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.60165281),
        dec: Angle.Degrees(+05.16876762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12633"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58246737),
        dec: Angle.Degrees(+05.17199188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180617"},
        {"Hipparcos Number", "HIP 94761"},
        {"Cincinnati Publication", "Ci 20 1143"},
        {"Geneva Identification System", "GEN# +1.00180617A"},
        {"Wilson Evans Batten Catalogue", "WEB 16538"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.23164974),
        dec: Angle.Degrees(+05.17214064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -578.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1331.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111470"},
        {"Hipparcos Number", "HIP 62585"},
        {"Geneva Identification System", "GEN# +1.00111470"},
        {"Smithsonian Astrophysical Observation", "SAO 119609"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.36257938),
        dec: Angle.Degrees(+05.17231127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215043"},
        {"Hipparcos Number", "HIP 112099"},
        {"Smithsonian Astrophysical Observation", "SAO 127699"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.58815711),
        dec: Angle.Degrees(+05.17371147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18265",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2849 A"},
        {"Henry Draper", "HD 24550"},
        {"Hipparcos Number", "HIP 18265"},
        {"Geneva Identification System", "GEN# +1.00024550A"},
        {"Smithsonian Astrophysical Observation", "SAO 111492"},
        {"Wilson Evans Batten Catalogue", "WEB 3529"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.61343901),
        dec: Angle.Degrees(+05.17467050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190364"},
        {"Hipparcos Number", "HIP 98860"},
        {"Smithsonian Astrophysical Observation", "SAO 125410"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.12559892),
        dec: Angle.Degrees(+05.17504996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45431"},
        {"Hipparcos Number", "HIP 30735"},
        {"Geneva Identification System", "GEN# +1.00045431"},
        {"Renson", "Renson 12030"},
        {"Smithsonian Astrophysical Observation", "SAO 113911"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.86638542),
        dec: Angle.Degrees(+05.17542697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90280"},
        {"Hipparcos Number", "HIP 51017"},
        {"Smithsonian Astrophysical Observation", "SAO 118289"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.33913849),
        dec: Angle.Degrees(+05.17702009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19818"},
        {"Smithsonian Astrophysical Observation", "SAO 111687"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.74706492),
        dec: Angle.Degrees(+05.17774688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78644"},
        {"Smithsonian Astrophysical Observation", "SAO 121336"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.81081306),
        dec: Angle.Degrees(+05.17829119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113712"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.44689577),
        dec: Angle.Degrees(+05.17910374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179104"},
        {"Hipparcos Number", "HIP 94247"},
        {"Smithsonian Astrophysical Observation", "SAO 124356"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.77239572),
        dec: Angle.Degrees(+05.17983485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4255"},
        {"Hipparcos Number", "HIP 3534"},
        {"Geneva Identification System", "GEN# +1.00004255"},
        {"Smithsonian Astrophysical Observation", "SAO 109431"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.26855313),
        dec: Angle.Degrees(+05.18168063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102649"},
        {"Hipparcos Number", "HIP 57636"},
        {"Smithsonian Astrophysical Observation", "SAO 119061"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.27981356),
        dec: Angle.Degrees(+05.18373797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69752"},
        {"Hipparcos Number", "HIP 40704"},
        {"Geneva Identification System", "GEN# +1.00069752"},
        {"Smithsonian Astrophysical Observation", "SAO 116608"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.63608242),
        dec: Angle.Degrees(+05.18485197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113285"},
        {"Hipparcos Number", "HIP 63642"},
        {"Geneva Identification System", "GEN# +1.00113285"},
        {"Smithsonian Astrophysical Observation", "SAO 119734"},
        {"Wilson Evans Batten Catalogue", "WEB 11263"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.65816476),
        dec: Angle.Degrees(+05.18570442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144408"},
        {"Hipparcos Number", "HIP 78846"},
        {"Smithsonian Astrophysical Observation", "SAO 121362"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.42334927),
        dec: Angle.Degrees(+05.18633485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23486"},
        {"Geneva Identification System", "GEN# +9.80084030"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.73115584),
        dec: Angle.Degrees(+05.18880259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63756",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8760 AB"},
        {"Henry Draper", "HD 113497"},
        {"Hipparcos Number", "HIP 63756"},
        {"Smithsonian Astrophysical Observation", "SAO 119748"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.02012892),
        dec: Angle.Degrees(+05.18896056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40892"},
        {"Geneva Identification System", "GEN# +6.20058034"},
        {"Wilson Evans Batten Catalogue", "WEB 7931"},
    },
    visualMagnitude: 9.92,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.17229733),
        dec: Angle.Degrees(+05.18936058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18264",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2849 BC"},
        {"Hipparcos Number", "HIP 18264"},
        {"Geneva Identification System", "GEN# +1.00024550B"},
        {"Smithsonian Astrophysical Observation", "SAO 111491"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.61286530),
        dec: Angle.Degrees(+05.19116866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73863"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.43830336),
        dec: Angle.Degrees(+05.19358294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106290"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.91863142),
        dec: Angle.Degrees(+05.19467763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209903"},
        {"Hipparcos Number", "HIP 109145"},
        {"Smithsonian Astrophysical Observation", "SAO 127301"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.63972123),
        dec: Angle.Degrees(+05.19468435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218057"},
        {"Hipparcos Number", "HIP 113978"},
        {"Smithsonian Astrophysical Observation", "SAO 127956"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.24691736),
        dec: Angle.Degrees(+05.19622967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102718"},
        {"Geneva Identification System", "GEN# +0.00404551"},
        {"Smithsonian Astrophysical Observation", "SAO 126242"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.21135914),
        dec: Angle.Degrees(+05.19947818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66012"},
        {"Hipparcos Number", "HIP 39268"},
        {"Smithsonian Astrophysical Observation", "SAO 116252"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.44930042),
        dec: Angle.Degrees(+05.20112357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15503"},
        {"Smithsonian Astrophysical Observation", "SAO 111125"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.94262547),
        dec: Angle.Degrees(+05.20262016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2373 AB"},
        {"Henry Draper", "HD 19620"},
        {"Hipparcos Number", "HIP 14676"},
        {"Geneva Identification System", "GEN# +1.00019620J"},
        {"Smithsonian Astrophysical Observation", "SAO 111013"},
        {"Wilson Evans Batten Catalogue", "WEB 2848"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.40126430),
        dec: Angle.Degrees(+05.20294871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65931"},
        {"Smithsonian Astrophysical Observation", "SAO 119972"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.74196977),
        dec: Angle.Degrees(+05.20296994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48594"},
        {"Hipparcos Number", "HIP 32290"},
        {"Smithsonian Astrophysical Observation", "SAO 114346"},
        {"Wilson Evans Batten Catalogue", "WEB 6509"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.11172788),
        dec: Angle.Degrees(+05.20608043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22384"},
        {"Smithsonian Astrophysical Observation", "SAO 112101"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.28250691),
        dec: Angle.Degrees(+05.20854321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37850"},
        {"Wilson Evans Batten Catalogue", "WEB 7476"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.39064172),
        dec: Angle.Degrees(+05.20860918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 898"},
        {"Geneva Identification System", "GEN# +9.80031029"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.76870081),
        dec: Angle.Degrees(+05.20868148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114174"},
        {"Hipparcos Number", "HIP 64150"},
        {"Cincinnati Publication", "Ci 20 760"},
        {"Cincinnati Publication 2", "Ci 18 1687"},
        {"Fundamental Katalog 5th Edition", "FK5 3047"},
        {"Geneva Identification System", "GEN# +1.00114174"},
        {"Smithsonian Astrophysical Observation", "SAO 119789"},
        {"Wilson Evans Batten Catalogue", "WEB 11339"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.21239048),
        dec: Angle.Degrees(+05.20886950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -669.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48534"},
        {"Hipparcos Number", "HIP 32257"},
        {"Smithsonian Astrophysical Observation", "SAO 114339"},
        {"Wilson Evans Batten Catalogue", "WEB 6504"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04059947),
        dec: Angle.Degrees(+05.20911592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142478"},
        {"Hipparcos Number", "HIP 77912"},
        {"Smithsonian Astrophysical Observation", "SAO 121251"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.67412011),
        dec: Angle.Degrees(+05.20969095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130088"},
        {"Hipparcos Number", "HIP 72213"},
        {"Smithsonian Astrophysical Observation", "SAO 120647"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.53578605),
        dec: Angle.Degrees(+05.20974450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15819"},
        {"Hipparcos Number", "HIP 11836"},
        {"Smithsonian Astrophysical Observation", "SAO 110605"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.20608750),
        dec: Angle.Degrees(+05.21011422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98203",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13156"},
        {"Aitken 2", "ADS 13156 AB"},
        {"Henry Draper", "HD 188914"},
        {"Hipparcos Number", "HIP 98203"},
        {"Geneva Identification System", "GEN# +1.00188914J"},
        {"Smithsonian Astrophysical Observation", "SAO 125274"},
        {"Wilson Evans Batten Catalogue", "WEB 17319"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.33115396),
        dec: Angle.Degrees(+05.21253299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53157"},
        {"Hipparcos Number", "HIP 34095"},
        {"Smithsonian Astrophysical Observation", "SAO 114861"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.04362812),
        dec: Angle.Degrees(+05.21292716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207581"},
        {"Hipparcos Number", "HIP 107764"},
        {"Smithsonian Astrophysical Observation", "SAO 127100"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.46353444),
        dec: Angle.Degrees(+05.21294794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48771"},
        {"Hipparcos Number", "HIP 32357"},
        {"Smithsonian Astrophysical Observation", "SAO 114362"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.30770736),
        dec: Angle.Degrees(+05.21326381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157279"},
        {"Hipparcos Number", "HIP 84983"},
        {"Geneva Identification System", "GEN# +1.00157279"},
        {"Smithsonian Astrophysical Observation", "SAO 122319"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.53905296),
        dec: Angle.Degrees(+05.21399906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80425"},
        {"Hipparcos Number", "HIP 45758"},
        {"Fundamental Katalog 5th Edition", "FK5 2740"},
        {"Geneva Identification System", "GEN# +1.00080425"},
        {"Smithsonian Astrophysical Observation", "SAO 117590"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.96334092),
        dec: Angle.Degrees(+05.21608440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6844 AB"},
        {"Henry Draper", "HD 71908"},
        {"Hipparcos Number", "HIP 41699"},
        {"Smithsonian Astrophysical Observation", "SAO 116826"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.52362401),
        dec: Angle.Degrees(+05.21797739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222520"},
        {"Hipparcos Number", "HIP 116862"},
        {"Smithsonian Astrophysical Observation", "SAO 128328"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32291989),
        dec: Angle.Degrees(+05.21814671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13940 AB"},
        {"Henry Draper", "HD 195434"},
        {"Hipparcos Number", "HIP 101236"},
        {"Cincinnati Publication", "Ci 18 2661"},
        {"Cincinnati Publication 2", "Ci 20 1210"},
        {"Geneva Identification System", "GEN# +1.00195434"},
        {"Smithsonian Astrophysical Observation", "SAO 125889"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.80535623),
        dec: Angle.Degrees(+05.21834806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 307.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 280.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106534"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.65680677),
        dec: Angle.Degrees(+05.21836001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30590"},
        {"Hipparcos Number", "HIP 22385"},
        {"Smithsonian Astrophysical Observation", "SAO 112102"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.28549373),
        dec: Angle.Degrees(+05.21850747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81067"},
        {"Hipparcos Number", "HIP 46068"},
        {"Geneva Identification System", "GEN# +1.00081067"},
        {"Smithsonian Astrophysical Observation", "SAO 117648"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.91774925),
        dec: Angle.Degrees(+05.21957677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162974"},
        {"Hipparcos Number", "HIP 87596"},
        {"Smithsonian Astrophysical Observation", "SAO 122887"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.40239785),
        dec: Angle.Degrees(+05.22074817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85178"},
        {"Hipparcos Number", "HIP 48261"},
        {"Smithsonian Astrophysical Observation", "SAO 117935"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.57759568),
        dec: Angle.Degrees(+05.22154855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86610"},
        {"Hipparcos Number", "HIP 48989"},
        {"Geneva Identification System", "GEN# +1.00086610"},
        {"Smithsonian Astrophysical Observation", "SAO 118040"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.92625572),
        dec: Angle.Degrees(+05.22163583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125882"},
        {"Hipparcos Number", "HIP 70233"},
        {"Smithsonian Astrophysical Observation", "SAO 120413"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.55361506),
        dec: Angle.Degrees(+05.22472908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95960"},
        {"Hipparcos Number", "HIP 54108"},
        {"Smithsonian Astrophysical Observation", "SAO 118644"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.07948948),
        dec: Angle.Degrees(+05.22492428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1802"},
        {"Hipparcos Number", "HIP 1770"},
        {"Smithsonian Astrophysical Observation", "SAO 109165"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.59976195),
        dec: Angle.Degrees(+05.22522573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81215"},
        {"Smithsonian Astrophysical Observation", "SAO 121713"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83332585),
        dec: Angle.Degrees(+05.22632237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36115"},
        {"Hipparcos Number", "HIP 25725"},
        {"Celescope Catalog", "CEL 734"},
        {"Geneva Identification System", "GEN# +1.00036115"},
        {"Smithsonian Astrophysical Observation", "SAO 112825"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.40161525),
        dec: Angle.Degrees(+05.22721551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37279",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Procyon"},
        {"Common Name 2", "Procyon A"},
        {"Henry Draper", "HD 61421"},
        {"Hipparcos Number", "HIP 37279"},
        {"Cincinnati Publication", "Ci 20 432"},
        {"Fundamental Katalog 5th Edition", "FK5 291"},
        {"Geneva Identification System", "GEN# +1.00061421"},
        {"Smithsonian Astrophysical Observation", "SAO 115756"},
        {"Wilson Evans Batten Catalogue", "WEB 7381"},
    },
    visualMagnitude: 0.40,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.82724194),
        dec: Angle.Degrees(+05.22750767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -716.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1034.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162486"},
        {"Hipparcos Number", "HIP 87365"},
        {"Smithsonian Astrophysical Observation", "SAO 122827"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.77036132),
        dec: Angle.Degrees(+05.22898166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68911"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62282679),
        dec: Angle.Degrees(+05.23279973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97459"},
        {"Hipparcos Number", "HIP 54788"},
        {"Smithsonian Astrophysical Observation", "SAO 118724"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.24678511),
        dec: Angle.Degrees(+05.23475380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36208",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Luyten's star"},
        {"Hipparcos Number", "HIP 36208"},
        {"Geneva Identification System", "GEN# +0.00501668"},
        {"Wilson Evans Batten Catalogue", "WEB 7213"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.85068549),
        dec: Angle.Degrees(+05.23476432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 571.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3694.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6266"},
        {"Hipparcos Number", "HIP 4968"},
        {"Geneva Identification System", "GEN# +1.00006266"},
        {"Smithsonian Astrophysical Observation", "SAO 109641"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.91954337),
        dec: Angle.Degrees(+05.23545059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38022"},
        {"Hipparcos Number", "HIP 26928"},
        {"Geneva Identification System", "GEN# +1.00038022"},
        {"Smithsonian Astrophysical Observation", "SAO 113063"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.73467245),
        dec: Angle.Degrees(+05.23580956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137591"},
        {"Hipparcos Number", "HIP 75599"},
        {"Smithsonian Astrophysical Observation", "SAO 121003"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.68931092),
        dec: Angle.Degrees(+05.23690661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178011"},
        {"Hipparcos Number", "HIP 93856"},
        {"Geneva Identification System", "GEN# +1.00178011"},
        {"Smithsonian Astrophysical Observation", "SAO 124277"},
        {"Wilson Evans Batten Catalogue", "WEB 16324"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.71843000),
        dec: Angle.Degrees(+05.24163763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44263"},
        {"Cincinnati Publication", "Ci 20 505"},
        {"Geneva Identification System", "GEN# +9.80046016"},
        {"Wilson Evans Batten Catalogue", "WEB 8492"},
    },
    visualMagnitude: 12.37,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.21031134),
        dec: Angle.Degrees(+05.24204999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -247.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14261"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.97819936),
        dec: Angle.Degrees(+05.24269921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101937"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.85904691),
        dec: Angle.Degrees(+05.24401734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16803 B"},
        {"Hipparcos Number", "HIP 116036"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66963320),
        dec: Angle.Degrees(+05.24645923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151525"},
        {"Hipparcos Number", "HIP 82216"},
        {"Fundamental Katalog 5th Edition", "FK5 3333"},
        {"Geneva Identification System", "GEN# +1.00151525A"},
        {"Renson", "Renson 42850"},
        {"Smithsonian Astrophysical Observation", "SAO 121865"},
        {"Wilson Evans Batten Catalogue", "WEB 13882"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.94346342),
        dec: Angle.Degrees(+05.24684013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47008",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7435 AB"},
        {"Henry Draper", "HD 82867"},
        {"Hipparcos Number", "HIP 47008"},
        {"Smithsonian Astrophysical Observation", "SAO 117781"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.71273259),
        dec: Angle.Degrees(+05.24764829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104987",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kitalpha"},
        {"Henry Draper", "HD 202448"},
        {"Henry Draper 2", "HD 202447"},
        {"Hipparcos Number", "HIP 104987"},
        {"Fundamental Katalog 5th Edition", "FK5 800"},
        {"Geneva Identification System", "GEN# +1.00202447"},
        {"Smithsonian Astrophysical Observation", "SAO 126662"},
        {"Wilson Evans Batten Catalogue", "WEB 19079"},
    },
    visualMagnitude: 3.92,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.95581976),
        dec: Angle.Degrees(+05.24807390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116035",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16803 A"},
        {"Henry Draper", "HD 221272"},
        {"Hipparcos Number", "HIP 116035"},
        {"Smithsonian Astrophysical Observation", "SAO 128216"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66987529),
        dec: Angle.Degrees(+05.24944678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8302"},
        {"Hipparcos Number", "HIP 6416"},
        {"Geneva Identification System", "GEN# +1.00008302"},
        {"Smithsonian Astrophysical Observation", "SAO 109832"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.59758849),
        dec: Angle.Degrees(+05.25146263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65525"},
        {"Hipparcos Number", "HIP 39037"},
        {"Geneva Identification System", "GEN# +1.00065525"},
        {"Smithsonian Astrophysical Observation", "SAO 116204"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.80312648),
        dec: Angle.Degrees(+05.25160607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16995 AB"},
        {"Henry Draper", "HD 223139"},
        {"Hipparcos Number", "HIP 117298"},
        {"Smithsonian Astrophysical Observation", "SAO 128377"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.75416287),
        dec: Angle.Degrees(+05.25186630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202587"},
        {"Hipparcos Number", "HIP 105053"},
        {"Geneva Identification System", "GEN# +1.00202587"},
        {"Smithsonian Astrophysical Observation", "SAO 126675"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.19225945),
        dec: Angle.Degrees(+05.25217713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88315"},
        {"Hipparcos Number", "HIP 49880"},
        {"Smithsonian Astrophysical Observation", "SAO 118150"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.77560200),
        dec: Angle.Degrees(+05.25218445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99014"},
        {"Geneva Identification System", "GEN# +0.00404344"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.52056736),
        dec: Angle.Degrees(+05.25389172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36499",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6140 AB"},
        {"Henry Draper", "HD 59538"},
        {"Hipparcos Number", "HIP 36499"},
        {"Smithsonian Astrophysical Observation", "SAO 115532"},
        {"Wilson Evans Batten Catalogue", "WEB 7260"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.64003510),
        dec: Angle.Degrees(+05.25466063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21993"},
        {"Hipparcos Number", "HIP 16530"},
        {"Geneva Identification System", "GEN# +1.00021993"},
        {"Smithsonian Astrophysical Observation", "SAO 111249"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.21275518),
        dec: Angle.Degrees(+05.25466146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89180"},
        {"Hipparcos Number", "HIP 50388"},
        {"Smithsonian Astrophysical Observation", "SAO 118199"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.32364518),
        dec: Angle.Degrees(+05.25672814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138199"},
        {"Hipparcos Number", "HIP 75926"},
        {"Smithsonian Astrophysical Observation", "SAO 121034"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.61332841),
        dec: Angle.Degrees(+05.26296115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8098 A"},
        {"Henry Draper", "HD 97676"},
        {"Hipparcos Number", "HIP 54900"},
        {"Smithsonian Astrophysical Observation", "SAO 118741"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.62283217),
        dec: Angle.Degrees(+05.26307909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245983"},
        {"Hipparcos Number", "HIP 26583"},
        {"Smithsonian Astrophysical Observation", "SAO 112999"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.76407979),
        dec: Angle.Degrees(+05.26403141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11650"},
        {"Geneva Identification System", "GEN# +6.20001022"},
    },
    visualMagnitude: 12.79,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.56909300),
        dec: Angle.Degrees(+05.26414062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172365"},
        {"Hipparcos Number", "HIP 91499"},
        {"Fundamental Katalog 5th Edition", "FK5 3485"},
        {"Geneva Identification System", "GEN# +3.47560145"},
        {"Smithsonian Astrophysical Observation", "SAO 123778"},
        {"Wilson Evans Batten Catalogue", "WEB 15725"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.90364920),
        dec: Angle.Degrees(+05.26428186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29952"},
        {"Hipparcos Number", "HIP 21975"},
        {"Smithsonian Astrophysical Observation", "SAO 112012"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.85396528),
        dec: Angle.Degrees(+05.26457048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103564"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.75052737),
        dec: Angle.Degrees(+05.26521420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74279"},
        {"Hipparcos Number", "HIP 42804"},
        {"Geneva Identification System", "GEN# +1.00074279"},
        {"Smithsonian Astrophysical Observation", "SAO 117052"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.81666251),
        dec: Angle.Degrees(+05.26603076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8639 AB"},
        {"Henry Draper", "HD 110555"},
        {"Hipparcos Number", "HIP 62034"},
        {"Smithsonian Astrophysical Observation", "SAO 119550"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.73088567),
        dec: Angle.Degrees(+05.26664024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85248"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.30090302),
        dec: Angle.Degrees(+05.26769934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55793"},
        {"Hipparcos Number", "HIP 35010"},
        {"Smithsonian Astrophysical Observation", "SAO 115124"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64124559),
        dec: Angle.Degrees(+05.27076709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48453"},
        {"Hipparcos Number", "HIP 32233"},
        {"Smithsonian Astrophysical Observation", "SAO 114325"},
        {"Wilson Evans Batten Catalogue", "WEB 6498"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.93192428),
        dec: Angle.Degrees(+05.27106606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126735"},
        {"Hipparcos Number", "HIP 70668"},
        {"Geneva Identification System", "GEN# +1.00126735"},
        {"Smithsonian Astrophysical Observation", "SAO 120470"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.81659525),
        dec: Angle.Degrees(+05.27155115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5097 A"},
        {"Henry Draper", "HD 45530"},
        {"Hipparcos Number", "HIP 30793"},
        {"Celescope Catalog", "CEL 1254"},
        {"Geneva Identification System", "GEN# +1.00045530"},
        {"Renson", "Renson 12070"},
        {"Smithsonian Astrophysical Observation", "SAO 113926"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.05815921),
        dec: Angle.Degrees(+05.27225241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166028"},
        {"Hipparcos Number", "HIP 88869"},
        {"Smithsonian Astrophysical Observation", "SAO 123168"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15006536),
        dec: Angle.Degrees(+05.27326998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94766"},
        {"Hipparcos Number", "HIP 53485"},
        {"Smithsonian Astrophysical Observation", "SAO 118579"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.12900924),
        dec: Angle.Degrees(+05.27342603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67874"},
        {"Hipparcos Number", "HIP 40004"},
        {"Smithsonian Astrophysical Observation", "SAO 116427"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.55041815),
        dec: Angle.Degrees(+05.27378605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195634"},
        {"Hipparcos Number", "HIP 101347"},
        {"Geneva Identification System", "GEN# +1.00195634"},
        {"Smithsonian Astrophysical Observation", "SAO 125914"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.10024449),
        dec: Angle.Degrees(+05.27447359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179124"},
        {"Hipparcos Number", "HIP 94250"},
        {"Smithsonian Astrophysical Observation", "SAO 124358"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.77678917),
        dec: Angle.Degrees(+05.27465807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82990"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.38381227),
        dec: Angle.Degrees(+05.27471088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109756"},
        {"Geneva Identification System", "GEN# +6.10141019"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47176854),
        dec: Angle.Degrees(+05.27662819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100340"},
        {"Hipparcos Number", "HIP 56322"},
        {"Geneva Identification System", "GEN# +1.00100340"},
        {"Renson", "Renson 28830"},
    },
    visualMagnitude: 10.12,
    bvColour: -0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20808257),
        dec: Angle.Degrees(+05.27670131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36603"},
        {"Hipparcos Number", "HIP 26025"},
        {"Geneva Identification System", "GEN# +1.00036603"},
        {"Smithsonian Astrophysical Observation", "SAO 112893"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28751810),
        dec: Angle.Degrees(+05.27708059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149908"},
        {"Hipparcos Number", "HIP 81404"},
        {"Smithsonian Astrophysical Observation", "SAO 121738"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.39068306),
        dec: Angle.Degrees(+05.27755599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88464"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.93369596),
        dec: Angle.Degrees(+05.27770083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44195"},
        {"Hipparcos Number", "HIP 30154"},
        {"Geneva Identification System", "GEN# +1.00044195"},
        {"Smithsonian Astrophysical Observation", "SAO 113739"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.17813877),
        dec: Angle.Degrees(+05.27843946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19293"},
        {"Hipparcos Number", "HIP 14437"},
        {"Smithsonian Astrophysical Observation", "SAO 110967"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.59293865),
        dec: Angle.Degrees(+05.27854022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93797"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.52893192),
        dec: Angle.Degrees(+05.28000141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73151"},
    },
    visualMagnitude: 11.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.24328397),
        dec: Angle.Degrees(+05.28018479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4628"},
        {"Hipparcos Number", "HIP 3765"},
        {"Cincinnati Publication", "Ci 20 55"},
        {"Fundamental Katalog 5th Edition", "FK5 1019"},
        {"Geneva Identification System", "GEN# +1.00004628"},
        {"Smithsonian Astrophysical Observation", "SAO 109471"},
        {"Wilson Evans Batten Catalogue", "WEB 670"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.09388786),
        dec: Angle.Degrees(+05.28338873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 758.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1141.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65139"},
        {"Hipparcos Number", "HIP 38888"},
        {"Geneva Identification System", "GEN# +1.00065139"},
        {"Smithsonian Astrophysical Observation", "SAO 116170"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.36753379),
        dec: Angle.Degrees(+05.28514140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51839"},
        {"Hipparcos Number", "HIP 33626"},
        {"Geneva Identification System", "GEN# +1.00051839"},
        {"Smithsonian Astrophysical Observation", "SAO 114727"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.78846021),
        dec: Angle.Degrees(+05.28523288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74486"},
        {"Hipparcos Number", "HIP 42899"},
        {"Smithsonian Astrophysical Observation", "SAO 117081"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.12999513),
        dec: Angle.Degrees(+05.28582767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74782"},
        {"Hipparcos Number", "HIP 43047"},
        {"Geneva Identification System", "GEN# +1.00074782"},
        {"Smithsonian Astrophysical Observation", "SAO 117099"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.55201100),
        dec: Angle.Degrees(+05.28685405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223"},
        {"Hipparcos Number", "HIP 579"},
        {"Smithsonian Astrophysical Observation", "SAO 109013"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.76013095),
        dec: Angle.Degrees(+05.28802852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18747"},
        {"Hipparcos Number", "HIP 14054"},
        {"Geneva Identification System", "GEN# +1.00018747"},
        {"Smithsonian Astrophysical Observation", "SAO 110903"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.24030573),
        dec: Angle.Degrees(+05.28816830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171782"},
        {"Hipparcos Number", "HIP 91224"},
        {"Geneva Identification System", "GEN# +3.47560026"},
        {"Renson", "Renson 48130"},
        {"Smithsonian Astrophysical Observation", "SAO 123689"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.12343796),
        dec: Angle.Degrees(+05.28869417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30101"},
        {"Hipparcos Number", "HIP 22067"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.20099661),
        dec: Angle.Degrees(+05.28953834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91312"},
        {"Geneva Identification System", "GEN# +3.47560048"},
        {"Smithsonian Astrophysical Observation", "SAO 123720"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38471365),
        dec: Angle.Degrees(+05.28959008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9060 AB"},
        {"Henry Draper", "HD 121605"},
        {"Hipparcos Number", "HIP 68081"},
        {"Smithsonian Astrophysical Observation", "SAO 120182"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.08521469),
        dec: Angle.Degrees(+05.28984442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204968"},
        {"Hipparcos Number", "HIP 106312"},
        {"Smithsonian Astrophysical Observation", "SAO 126868"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.97923421),
        dec: Angle.Degrees(+05.29324827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142443"},
        {"Hipparcos Number", "HIP 77893"},
        {"Smithsonian Astrophysical Observation", "SAO 121248"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60645913),
        dec: Angle.Degrees(+05.29394629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77739"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.07201284),
        dec: Angle.Degrees(+05.29578075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120200"},
        {"Hipparcos Number", "HIP 67318"},
        {"Smithsonian Astrophysical Observation", "SAO 120118"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.97996615),
        dec: Angle.Degrees(+05.29600525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60502"},
        {"Hipparcos Number", "HIP 36889"},
        {"Smithsonian Astrophysical Observation", "SAO 115662"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.76296322),
        dec: Angle.Degrees(+05.29684386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3266 A"},
        {"Hipparcos Number", "HIP 21000"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.55216585),
        dec: Angle.Degrees(+05.29852669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105185"},
        {"Hipparcos Number", "HIP 59063"},
        {"Smithsonian Astrophysical Observation", "SAO 119222"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69070052),
        dec: Angle.Degrees(+05.29921028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23184"},
        {"Smithsonian Astrophysical Observation", "SAO 112290"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.83186087),
        dec: Angle.Degrees(+05.29941874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112249"},
        {"Hipparcos Number", "HIP 63062"},
        {"Geneva Identification System", "GEN# +1.00112249"},
        {"Smithsonian Astrophysical Observation", "SAO 119668"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.81326588),
        dec: Angle.Degrees(+05.30035359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196507"},
        {"Hipparcos Number", "HIP 101796"},
        {"Smithsonian Astrophysical Observation", "SAO 126034"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45186339),
        dec: Angle.Degrees(+05.30095133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54759"},
        {"Hipparcos Number", "HIP 34625"},
        {"Geneva Identification System", "GEN# +1.00054759"},
        {"Smithsonian Astrophysical Observation", "SAO 115022"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.58407633),
        dec: Angle.Degrees(+05.30177417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88332"},
        {"Smithsonian Astrophysical Observation", "SAO 123050"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59686774),
        dec: Angle.Degrees(+05.30208640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108317"},
        {"Hipparcos Number", "HIP 60719"},
        {"Geneva Identification System", "GEN# +1.00108317"},
        {"Smithsonian Astrophysical Observation", "SAO 119398"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.65388342),
        dec: Angle.Degrees(+05.30256922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202817"},
        {"Hipparcos Number", "HIP 105174"},
        {"Smithsonian Astrophysical Observation", "SAO 126696"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.59205588),
        dec: Angle.Degrees(+05.30351060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8531 A"},
        {"Henry Draper", "HD 107705"},
        {"Hipparcos Number", "HIP 60353"},
        {"Geneva Identification System", "GEN# +1.00107705A"},
        {"Smithsonian Astrophysical Observation", "SAO 119360"},
        {"Wilson Evans Batten Catalogue", "WEB 10735"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.63390170),
        dec: Angle.Degrees(+05.30557355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12826"},
        {"Hipparcos Number", "HIP 9791"},
        {"Fundamental Katalog 5th Edition", "FK5 4189"},
        {"Smithsonian Astrophysical Observation", "SAO 110335"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.47937536),
        dec: Angle.Degrees(+05.30559261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46868"},
        {"Hipparcos Number", "HIP 31515"},
        {"Geneva Identification System", "GEN# +1.00046868"},
        {"Renson", "Renson 12575"},
        {"Smithsonian Astrophysical Observation", "SAO 114113"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.98784181),
        dec: Angle.Degrees(+05.30739935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192170"},
        {"Hipparcos Number", "HIP 99650"},
        {"Smithsonian Astrophysical Observation", "SAO 125587"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34433094),
        dec: Angle.Degrees(+05.30945774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46867"},
        {"Hipparcos Number", "HIP 31513"},
        {"Geneva Identification System", "GEN# +1.00046867"},
        {"Smithsonian Astrophysical Observation", "SAO 114112"},
        {"Wilson Evans Batten Catalogue", "WEB 6304"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97975234),
        dec: Angle.Degrees(+05.30977605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8455"},
        {"Hipparcos Number", "HIP 6525"},
        {"Smithsonian Astrophysical Observation", "SAO 109858"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.95824826),
        dec: Angle.Degrees(+05.31067979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8531 B"},
        {"Hipparcos Number", "HIP 60352"},
        {"Geneva Identification System", "GEN# +1.00107705B"},
        {"Wilson Evans Batten Catalogue", "WEB 10736"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.63173094),
        dec: Angle.Degrees(+05.31091978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33447"},
        {"Hipparcos Number", "HIP 24093"},
        {"Smithsonian Astrophysical Observation", "SAO 112490"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.63758830),
        dec: Angle.Degrees(+05.31495819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88418"},
        {"Hipparcos Number", "HIP 49936"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94403399),
        dec: Angle.Degrees(+05.31583587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31516"},
        {"Smithsonian Astrophysical Observation", "SAO 114114"},
    },
    visualMagnitude: 9.39,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.98837116),
        dec: Angle.Degrees(+05.31669635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71907"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.61992111),
        dec: Angle.Degrees(+05.31704127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34510"},
        {"Hipparcos Number", "HIP 24734"},
        {"Geneva Identification System", "GEN# +1.00034510"},
        {"Smithsonian Astrophysical Observation", "SAO 112608"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.56093689),
        dec: Angle.Degrees(+05.31851028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35242"},
        {"Hipparcos Number", "HIP 25205"},
        {"Geneva Identification System", "GEN# +1.00035242"},
        {"Smithsonian Astrophysical Observation", "SAO 112708"},
        {"Wilson Evans Batten Catalogue", "WEB 4886"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.87951408),
        dec: Angle.Degrees(+05.32304571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26501"},
        {"Hipparcos Number", "HIP 19575"},
        {"Geneva Identification System", "GEN# +1.00026501"},
        {"Smithsonian Astrophysical Observation", "SAO 111650"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.91697808),
        dec: Angle.Degrees(+05.32309086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127742"},
        {"Hipparcos Number", "HIP 71146"},
        {"Fundamental Katalog 5th Edition", "FK5 5286"},
        {"Geneva Identification System", "GEN# +1.00127742"},
        {"Smithsonian Astrophysical Observation", "SAO 120522"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.26256188),
        dec: Angle.Degrees(+05.32346241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185156"},
        {"Hipparcos Number", "HIP 96537"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.39482018),
        dec: Angle.Degrees(+05.32387762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44870"},
        {"Hipparcos Number", "HIP 30473"},
        {"Celescope Catalog", "CEL 1220"},
        {"Geneva Identification System", "GEN# +1.00044870"},
        {"Smithsonian Astrophysical Observation", "SAO 113827"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.09494454),
        dec: Angle.Degrees(+05.32410878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140870"},
        {"Hipparcos Number", "HIP 77204"},
        {"Smithsonian Astrophysical Observation", "SAO 121176"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46186589),
        dec: Angle.Degrees(+05.32982622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169224"},
        {"Hipparcos Number", "HIP 90126"},
        {"Geneva Identification System", "GEN# +1.00169224"},
        {"Smithsonian Astrophysical Observation", "SAO 123422"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.88584919),
        dec: Angle.Degrees(+05.33184984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95421"},
        {"Hipparcos Number", "HIP 53856"},
        {"Smithsonian Astrophysical Observation", "SAO 118619"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.26478520),
        dec: Angle.Degrees(+05.33358609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148254"},
        {"Hipparcos Number", "HIP 80542"},
        {"Smithsonian Astrophysical Observation", "SAO 121601"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.66297348),
        dec: Angle.Degrees(+05.33400010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18709"},
        {"Smithsonian Astrophysical Observation", "SAO 111554"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.11342881),
        dec: Angle.Degrees(+05.33459903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18832"},
        {"Hipparcos Number", "HIP 14104"},
        {"Geneva Identification System", "GEN# +1.00018832"},
        {"Smithsonian Astrophysical Observation", "SAO 110915"},
        {"Wilson Evans Batten Catalogue", "WEB 2776"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46782491),
        dec: Angle.Degrees(+05.33610360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12343"},
        {"Hipparcos Number", "HIP 9431"},
        {"Geneva Identification System", "GEN# +1.00012343"},
        {"Smithsonian Astrophysical Observation", "SAO 110280"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.28274953),
        dec: Angle.Degrees(+05.33675767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218551"},
        {"Hipparcos Number", "HIP 114288"},
        {"Smithsonian Astrophysical Observation", "SAO 127994"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21014248),
        dec: Angle.Degrees(+05.33756260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91437"},
        {"Geneva Identification System", "GEN# +3.47560109"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.72053889),
        dec: Angle.Degrees(+05.33793117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29700"},
        {"Hipparcos Number", "HIP 21782"},
        {"Smithsonian Astrophysical Observation", "SAO 111971"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.19228385),
        dec: Angle.Degrees(+05.33993557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7061 AB"},
        {"Henry Draper", "HD 75811"},
        {"Hipparcos Number", "HIP 43570"},
        {"Geneva Identification System", "GEN# +1.00075811J"},
        {"Renson", "Renson 21226"},
        {"Smithsonian Astrophysical Observation", "SAO 117214"},
        {"Wilson Evans Batten Catalogue", "WEB 8397"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.10076514),
        dec: Angle.Degrees(+05.34032996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91085"},
        {"Hipparcos Number", "HIP 51493"},
        {"Fundamental Katalog 5th Edition", "FK5 4931"},
        {"Smithsonian Astrophysical Observation", "SAO 118344"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.75338606),
        dec: Angle.Degrees(+05.34133429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106028"},
        {"Hipparcos Number", "HIP 59479"},
        {"Geneva Identification System", "GEN# +1.00106028"},
        {"Smithsonian Astrophysical Observation", "SAO 119264"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99385924),
        dec: Angle.Degrees(+05.34134505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217187"},
        {"Hipparcos Number", "HIP 113464"},
        {"Geneva Identification System", "GEN# +1.00217187"},
        {"Smithsonian Astrophysical Observation", "SAO 127873"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.67642213),
        dec: Angle.Degrees(+05.34193648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177064"},
        {"Hipparcos Number", "HIP 93525"},
        {"Smithsonian Astrophysical Observation", "SAO 124193"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.72340013),
        dec: Angle.Degrees(+05.34274780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112683"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.27493230),
        dec: Angle.Degrees(+05.34306992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194013"},
        {"Hipparcos Number", "HIP 100541"},
        {"Fundamental Katalog 5th Edition", "FK5 1531"},
        {"Geneva Identification System", "GEN# +1.00194013"},
        {"Smithsonian Astrophysical Observation", "SAO 125747"},
        {"Wilson Evans Batten Catalogue", "WEB 18161"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.79462251),
        dec: Angle.Degrees(+05.34307747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103740"},
        {"Hipparcos Number", "HIP 58251"},
        {"Smithsonian Astrophysical Observation", "SAO 119125"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.20137832),
        dec: Angle.Degrees(+05.34488560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4445"},
        {"Hipparcos Number", "HIP 3651"},
        {"Smithsonian Astrophysical Observation", "SAO 109451"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.68672084),
        dec: Angle.Degrees(+05.34575668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4616"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.79890502),
        dec: Angle.Degrees(+05.34700355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183165"},
        {"Hipparcos Number", "HIP 95710"},
        {"Smithsonian Astrophysical Observation", "SAO 124655"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.01333158),
        dec: Angle.Degrees(+05.34703261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64021"},
        {"Hipparcos Number", "HIP 38397"},
        {"Geneva Identification System", "GEN# +1.00064021"},
        {"Smithsonian Astrophysical Observation", "SAO 116050"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.99505434),
        dec: Angle.Degrees(+05.34965510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70936"},
        {"Hipparcos Number", "HIP 41240"},
        {"Smithsonian Astrophysical Observation", "SAO 116735"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22251075),
        dec: Angle.Degrees(+05.35065937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4496 B"},
        {"Hipparcos Number", "HIP 27930"},
        {"Smithsonian Astrophysical Observation", "SAO 113259"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.65177984),
        dec: Angle.Degrees(+05.35103827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6815",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1158 AB"},
        {"Henry Draper", "HD 8875"},
        {"Hipparcos Number", "HIP 6815"},
        {"Geneva Identification System", "GEN# +1.00008875J"},
        {"Smithsonian Astrophysical Observation", "SAO 109905"},
        {"Wilson Evans Batten Catalogue", "WEB 1489"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.91589322),
        dec: Angle.Degrees(+05.35312049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27932",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4496 A"},
        {"Henry Draper", "HD 39731"},
        {"Hipparcos Number", "HIP 27932"},
        {"Geneva Identification System", "GEN# +1.00039731"},
        {"Smithsonian Astrophysical Observation", "SAO 113262"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.64929839),
        dec: Angle.Degrees(+05.35371113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39774"},
        {"Hipparcos Number", "HIP 27963"},
        {"Geneva Identification System", "GEN# +1.00039774"},
        {"Smithsonian Astrophysical Observation", "SAO 113268"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73528111),
        dec: Angle.Degrees(+05.35386033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116273"},
        {"Smithsonian Astrophysical Observation", "SAO 128247"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37945271),
        dec: Angle.Degrees(+05.35651170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105059"},
        {"Hipparcos Number", "HIP 59002"},
        {"Geneva Identification System", "GEN# +1.00105059"},
        {"Smithsonian Astrophysical Observation", "SAO 119216"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.46231361),
        dec: Angle.Degrees(+05.35741794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38098"},
        {"Hipparcos Number", "HIP 26971"},
        {"Celescope Catalog", "CEL 943"},
        {"Geneva Identification System", "GEN# +1.00038098"},
        {"Smithsonian Astrophysical Observation", "SAO 113074"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.84965476),
        dec: Angle.Degrees(+05.35865423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14127"},
        {"Hipparcos Number", "HIP 10672"},
        {"Smithsonian Astrophysical Observation", "SAO 110453"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.33197020),
        dec: Angle.Degrees(+05.36070032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2657"},
        {"Hipparcos Number", "HIP 2369"},
        {"Geneva Identification System", "GEN# +1.00002657"},
        {"Smithsonian Astrophysical Observation", "SAO 109239"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.56224742),
        dec: Angle.Degrees(+05.36227013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50639"},
        {"Smithsonian Astrophysical Observation", "SAO 118242"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.14023361),
        dec: Angle.Degrees(+05.36306422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104243"},
        {"Hipparcos Number", "HIP 58536"},
        {"Geneva Identification System", "GEN# +1.00104243"},
        {"Smithsonian Astrophysical Observation", "SAO 119159"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.06067548),
        dec: Angle.Degrees(+05.36383329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151812"},
        {"Hipparcos Number", "HIP 82342"},
        {"Geneva Identification System", "GEN# +1.00151812"},
        {"Smithsonian Astrophysical Observation", "SAO 121886"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.37535725),
        dec: Angle.Degrees(+05.36510734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78305"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.83451857),
        dec: Angle.Degrees(+05.36576228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67503"},
        {"Hipparcos Number", "HIP 39848"},
        {"Smithsonian Astrophysical Observation", "SAO 116388"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.11485209),
        dec: Angle.Degrees(+05.36679137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21778"},
        {"Hipparcos Number", "HIP 16362"},
        {"Geneva Identification System", "GEN# +1.00021778"},
        {"Smithsonian Astrophysical Observation", "SAO 111232"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.69569848),
        dec: Angle.Degrees(+05.36704841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138869"},
        {"Hipparcos Number", "HIP 76270"},
        {"Smithsonian Astrophysical Observation", "SAO 121068"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.68108352),
        dec: Angle.Degrees(+05.36802061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4325"},
        {"Smithsonian Astrophysical Observation", "SAO 109534"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.84349729),
        dec: Angle.Degrees(+05.36869881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9180"},
        {"Hipparcos Number", "HIP 7029"},
        {"Geneva Identification System", "GEN# +1.00009180"},
        {"Smithsonian Astrophysical Observation", "SAO 109931"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.64141751),
        dec: Angle.Degrees(+05.37117767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10333"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.28949720),
        dec: Angle.Degrees(+05.37265708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224897"},
        {"Hipparcos Number", "HIP 129"},
        {"Geneva Identification System", "GEN# +1.00224897"},
        {"Smithsonian Astrophysical Observation", "SAO 128539"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.41560234),
        dec: Angle.Degrees(+05.37275092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89253"},
        {"Hipparcos Number", "HIP 50428"},
        {"Smithsonian Astrophysical Observation", "SAO 118204"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.45158364),
        dec: Angle.Degrees(+05.37285644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214059"},
        {"Hipparcos Number", "HIP 111517"},
        {"Cincinnati Publication", "Ci 20 1372"},
        {"Cincinnati Publication 2", "Ci 18 2937"},
        {"Geneva Identification System", "GEN# +1.00214059"},
        {"Smithsonian Astrophysical Observation", "SAO 127621"},
        {"Wilson Evans Batten Catalogue", "WEB 19933"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.90798947),
        dec: Angle.Degrees(+05.37388043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 426.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193447"},
        {"Hipparcos Number", "HIP 100264"},
        {"Smithsonian Astrophysical Observation", "SAO 125690"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.05191956),
        dec: Angle.Degrees(+05.37559829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179284"},
        {"Hipparcos Number", "HIP 94316"},
        {"Smithsonian Astrophysical Observation", "SAO 124372"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.95736784),
        dec: Angle.Degrees(+05.37729893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30701"},
        {"Wilson Evans Batten Catalogue", "WEB 6123"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.75408001),
        dec: Angle.Degrees(+05.37882236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57838"},
        {"Hipparcos Number", "HIP 35814"},
        {"Smithsonian Astrophysical Observation", "SAO 115367"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.79120958),
        dec: Angle.Degrees(+05.37933777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68061"},
    },
    visualMagnitude: 11.35,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.03784686),
        dec: Angle.Degrees(+05.38011482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220009"},
        {"Hipparcos Number", "HIP 115227"},
        {"Fundamental Katalog 5th Edition", "FK5 3871"},
        {"Geneva Identification System", "GEN# +1.00220009"},
        {"Smithsonian Astrophysical Observation", "SAO 128126"},
        {"Wilson Evans Batten Catalogue", "WEB 20412"},
    },
    visualMagnitude: 5.05,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08557117),
        dec: Angle.Degrees(+05.38145156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22852"},
        {"Geneva Identification System", "GEN# +9.80097005"},
    },
    visualMagnitude: 12.39,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.74556904),
        dec: Angle.Degrees(+05.38207214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9459"},
        {"Hipparcos Number", "HIP 7220"},
        {"Smithsonian Astrophysical Observation", "SAO 109961"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.25390508),
        dec: Angle.Degrees(+05.38223908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136565"},
        {"Hipparcos Number", "HIP 75133"},
        {"Smithsonian Astrophysical Observation", "SAO 120956"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.30395510),
        dec: Angle.Degrees(+05.38290044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93180"},
        {"Hipparcos Number", "HIP 52627"},
        {"Geneva Identification System", "GEN# +1.00093180"},
        {"Smithsonian Astrophysical Observation", "SAO 118480"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.43028206),
        dec: Angle.Degrees(+05.38344746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42635"},
        {"Smithsonian Astrophysical Observation", "SAO 117024"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.32925203),
        dec: Angle.Degrees(+05.38397344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205375"},
        {"Hipparcos Number", "HIP 106532"},
        {"Smithsonian Astrophysical Observation", "SAO 126900"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.64962020),
        dec: Angle.Degrees(+05.38478412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28946"},
        {"Hipparcos Number", "HIP 21272"},
        {"Cincinnati Publication", "Ci 18 592"},
        {"Geneva Identification System", "GEN# +1.00028946"},
        {"Smithsonian Astrophysical Observation", "SAO 111893"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.46020928),
        dec: Angle.Degrees(+05.38569734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20361",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3153 AB"},
        {"Henry Draper", "HD 27610"},
        {"Hipparcos Number", "HIP 20361"},
        {"Smithsonian Astrophysical Observation", "SAO 111770"},
        {"Wilson Evans Batten Catalogue", "WEB 3889"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.40849194),
        dec: Angle.Degrees(+05.38917623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155229"},
        {"Hipparcos Number", "HIP 83986"},
        {"Geneva Identification System", "GEN# +1.00155229"},
        {"Smithsonian Astrophysical Observation", "SAO 122145"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.53472612),
        dec: Angle.Degrees(+05.38949715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197448"},
        {"Hipparcos Number", "HIP 102299"},
        {"Smithsonian Astrophysical Observation", "SAO 126141"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.91710921),
        dec: Angle.Degrees(+05.39021225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204265"},
        {"Hipparcos Number", "HIP 105933"},
        {"Geneva Identification System", "GEN# +1.00204265"},
        {"Smithsonian Astrophysical Observation", "SAO 126805"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82065672),
        dec: Angle.Degrees(+05.39167108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107543"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.72149854),
        dec: Angle.Degrees(+05.39250875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63353"},
        {"Hipparcos Number", "HIP 38124"},
        {"Geneva Identification System", "GEN# +1.00063353"},
        {"Smithsonian Astrophysical Observation", "SAO 115963"},
        {"Wilson Evans Batten Catalogue", "WEB 7514"},
    },
    visualMagnitude: 8.87,
    bvColour: 2.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.18969651),
        dec: Angle.Degrees(+05.39317488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170032"},
        {"Hipparcos Number", "HIP 90440"},
        {"Smithsonian Astrophysical Observation", "SAO 123500"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.80159956),
        dec: Angle.Degrees(+05.39508968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3829",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "van Maanen's Star"},
        {"Common Name 2", "van Maanen Star"},
        {"Common Name 3", "van Maanen 2"},
        {"Common Name 4", "vMA 2"},
        {"Hipparcos Number", "HIP 3829"},
        {"Cincinnati Publication", "Ci 20 58"},
        {"Geneva Identification System", "GEN# +9.80001027"},
        {"Wilson Evans Batten Catalogue", "WEB 681"},
    },
    visualMagnitude: 12.37,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.28823784),
        dec: Angle.Degrees(+05.39519773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1233.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2710.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3949 A"},
        {"Henry Draper", "HD 35066"},
        {"Hipparcos Number", "HIP 25082"},
        {"Geneva Identification System", "GEN# +1.00035066"},
        {"Smithsonian Astrophysical Observation", "SAO 112681"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.54658250),
        dec: Angle.Degrees(+05.39542809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12737 A"},
        {"Henry Draper", "HD 185507"},
        {"Hipparcos Number", "HIP 96665"},
        {"Geneva Identification System", "GEN# +1.00185507"},
        {"Geneva Identification System 2", "GEN# +1.00185507A"},
        {"Smithsonian Astrophysical Observation", "SAO 124903"},
        {"Wilson Evans Batten Catalogue", "WEB 16958"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.79850093),
        dec: Angle.Degrees(+05.39778241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183993"},
        {"Hipparcos Number", "HIP 96072"},
        {"Cincinnati Publication", "Ci 18 2543"},
        {"Smithsonian Astrophysical Observation", "SAO 124741"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00389419),
        dec: Angle.Degrees(+05.39885442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131989"},
        {"Hipparcos Number", "HIP 73125"},
        {"Smithsonian Astrophysical Observation", "SAO 120749"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.17623605),
        dec: Angle.Degrees(+05.39894162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31411"},
        {"Hipparcos Number", "HIP 22923"},
        {"Geneva Identification System", "GEN# +1.00031411"},
        {"Smithsonian Astrophysical Observation", "SAO 112220"},
        {"Wilson Evans Batten Catalogue", "WEB 4452"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.99317516),
        dec: Angle.Degrees(+05.39905815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182474"},
        {"Hipparcos Number", "HIP 95421"},
        {"Smithsonian Astrophysical Observation", "SAO 124592"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.15108813),
        dec: Angle.Degrees(+05.39961331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124407"},
        {"Hipparcos Number", "HIP 69476"},
        {"Smithsonian Astrophysical Observation", "SAO 120349"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.35093919),
        dec: Angle.Degrees(+05.40088245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89215"},
        {"Geneva Identification System", "GEN# +0.00503640"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.09237606),
        dec: Angle.Degrees(+05.40279675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -500.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -645.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83864"},
        {"Smithsonian Astrophysical Observation", "SAO 122114"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.09624225),
        dec: Angle.Degrees(+05.40295967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224430"},
        {"Hipparcos Number", "HIP 118137"},
        {"Smithsonian Astrophysical Observation", "SAO 128498"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44834427),
        dec: Angle.Degrees(+05.40437650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103367"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.13143442),
        dec: Angle.Degrees(+05.40454079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16665 AB"},
        {"Henry Draper", "HD 219829"},
        {"Hipparcos Number", "HIP 115112"},
        {"Cincinnati Publication", "Ci 20 1417"},
        {"Smithsonian Astrophysical Observation", "SAO 128108"},
        {"Wilson Evans Batten Catalogue", "WEB 20391"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.72577444),
        dec: Angle.Degrees(+05.40573419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 435.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145051"},
        {"Hipparcos Number", "HIP 79093"},
        {"Smithsonian Astrophysical Observation", "SAO 121386"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.16987520),
        dec: Angle.Degrees(+05.40575047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204563"},
        {"Hipparcos Number", "HIP 106088"},
        {"Smithsonian Astrophysical Observation", "SAO 126829"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.34405695),
        dec: Angle.Degrees(+05.40777362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64374"},
        {"Hipparcos Number", "HIP 38572"},
        {"Smithsonian Astrophysical Observation", "SAO 116083"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.46288140),
        dec: Angle.Degrees(+05.40815057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33635"},
        {"Hipparcos Number", "HIP 24207"},
        {"Smithsonian Astrophysical Observation", "SAO 112508"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.95755341),
        dec: Angle.Degrees(+05.40885989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63241"},
        {"Hipparcos Number", "HIP 38062"},
        {"Fundamental Katalog 5th Edition", "FK5 2606"},
        {"Geneva Identification System", "GEN# +1.00063241J"},
        {"Smithsonian Astrophysical Observation", "SAO 115947"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01424811),
        dec: Angle.Degrees(+05.40987484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28736"},
        {"Hipparcos Number", "HIP 21152"},
        {"Geneva Identification System", "GEN# +5.20250090"},
        {"Smithsonian Astrophysical Observation", "SAO 111879"},
        {"Wilson Evans Batten Catalogue", "WEB 4069"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.01975915),
        dec: Angle.Degrees(+05.41001999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3398"},
        {"Hipparcos Number", "HIP 2918"},
        {"Geneva Identification System", "GEN# +1.00003398"},
        {"Smithsonian Astrophysical Observation", "SAO 109311"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.23781189),
        dec: Angle.Degrees(+05.41248476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144582"},
        {"Hipparcos Number", "HIP 78901"},
        {"Geneva Identification System", "GEN# +1.00144582"},
        {"Smithsonian Astrophysical Observation", "SAO 121367"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.59645190),
        dec: Angle.Degrees(+05.41262630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122970"},
        {"Hipparcos Number", "HIP 68790"},
        {"Geneva Identification System", "GEN# +1.00122970"},
        {"Renson", "Renson 35236"},
        {"Smithsonian Astrophysical Observation", "SAO 120273"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.20406962),
        dec: Angle.Degrees(+05.41428506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110424"},
        {"Hipparcos Number", "HIP 61970"},
        {"Smithsonian Astrophysical Observation", "SAO 119539"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.49544364),
        dec: Angle.Degrees(+05.41664207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171658"},
        {"Hipparcos Number", "HIP 91171"},
        {"Geneva Identification System", "GEN# +3.47560014"},
        {"Smithsonian Astrophysical Observation", "SAO 123680"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.99358690),
        dec: Angle.Degrees(+05.41667780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44393"},
        {"Hipparcos Number", "HIP 30255"},
        {"Geneva Identification System", "GEN# +1.00044393"},
        {"Smithsonian Astrophysical Observation", "SAO 113768"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.46924755),
        dec: Angle.Degrees(+05.41693224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66777"},
        {"Hipparcos Number", "HIP 39582"},
        {"Smithsonian Astrophysical Observation", "SAO 116320"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.32673348),
        dec: Angle.Degrees(+05.41870557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36797"},
        {"Hipparcos Number", "HIP 26136"},
        {"Smithsonian Astrophysical Observation", "SAO 112906"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.59877225),
        dec: Angle.Degrees(+05.41976411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41361"},
        {"Hipparcos Number", "HIP 28812"},
        {"Geneva Identification System", "GEN# +1.00041361"},
        {"Smithsonian Astrophysical Observation", "SAO 113429"},
        {"Wilson Evans Batten Catalogue", "WEB 5636"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.24244795),
        dec: Angle.Degrees(+05.41997005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181709"},
        {"Hipparcos Number", "HIP 95133"},
        {"Geneva Identification System", "GEN# +1.00181709"},
        {"Smithsonian Astrophysical Observation", "SAO 124538"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.32617936),
        dec: Angle.Degrees(+05.42271315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81490"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.66941680),
        dec: Angle.Degrees(+05.42440081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188265"},
        {"Hipparcos Number", "HIP 97933"},
        {"Smithsonian Astrophysical Observation", "SAO 125205"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.54479157),
        dec: Angle.Degrees(+05.42477955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161734"},
        {"Hipparcos Number", "HIP 87032"},
        {"Geneva Identification System", "GEN# +3.46650081"},
        {"Smithsonian Astrophysical Observation", "SAO 122741"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.74069838),
        dec: Angle.Degrees(+05.42571069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139286"},
        {"Hipparcos Number", "HIP 76478"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.29784466),
        dec: Angle.Degrees(+05.42907512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96375"},
        {"Hipparcos Number", "HIP 54313"},
        {"Geneva Identification System", "GEN# +1.00096375"},
        {"Smithsonian Astrophysical Observation", "SAO 118664"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.66887265),
        dec: Angle.Degrees(+05.43003894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132071"},
        {"Hipparcos Number", "HIP 73157"},
        {"Smithsonian Astrophysical Observation", "SAO 120756"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.26851359),
        dec: Angle.Degrees(+05.43081377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148980"},
        {"Hipparcos Number", "HIP 80939"},
        {"Renson", "Renson 42100"},
        {"Smithsonian Astrophysical Observation", "SAO 121667"},
        {"Wilson Evans Batten Catalogue", "WEB 13690"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.91069177),
        dec: Angle.Degrees(+05.43375686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50868"},
        {"Hipparcos Number", "HIP 33267"},
        {"Geneva Identification System", "GEN# +1.00050868"},
        {"Smithsonian Astrophysical Observation", "SAO 114617"},
        {"Wilson Evans Batten Catalogue", "WEB 6690"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.80687333),
        dec: Angle.Degrees(+05.43401702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25558"},
        {"Hipparcos Number", "HIP 18957"},
        {"Geneva Identification System", "GEN# +1.00025558"},
        {"Smithsonian Astrophysical Observation", "SAO 111585"},
        {"Wilson Evans Batten Catalogue", "WEB 3644"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93584928),
        dec: Angle.Degrees(+05.43563754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168797"},
        {"Hipparcos Number", "HIP 89977"},
        {"Geneva Identification System", "GEN# +1.00168797"},
        {"Geneva Identification System 2", "GEN# +5.13590002"},
        {"Smithsonian Astrophysical Observation", "SAO 123385"},
        {"Wilson Evans Batten Catalogue", "WEB 15369"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.36834467),
        dec: Angle.Degrees(+05.43574551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17677"},
        {"Smithsonian Astrophysical Observation", "SAO 111417"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.80630890),
        dec: Angle.Degrees(+05.43997770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209464"},
        {"Hipparcos Number", "HIP 108886"},
        {"Smithsonian Astrophysical Observation", "SAO 127256"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.85324945),
        dec: Angle.Degrees(+05.44069990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204155"},
        {"Hipparcos Number", "HIP 105888"},
        {"Cincinnati Publication", "Ci 18 2784"},
        {"Geneva Identification System", "GEN# +0.00404674"},
        {"Geneva Identification System 2", "GEN# +1.00204155"},
        {"Smithsonian Astrophysical Observation", "SAO 126797"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67836543),
        dec: Angle.Degrees(+05.44223859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6877"},
        {"Hipparcos Number", "HIP 5432"},
        {"Smithsonian Astrophysical Observation", "SAO 109705"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.36356688),
        dec: Angle.Degrees(+05.44424699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171219"},
        {"Hipparcos Number", "HIP 90958"},
        {"Geneva Identification System", "GEN# +1.00171219"},
        {"Smithsonian Astrophysical Observation", "SAO 123633"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.32432311),
        dec: Angle.Degrees(+05.44555431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110121"},
        {"Hipparcos Number", "HIP 61793"},
        {"Smithsonian Astrophysical Observation", "SAO 119520"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.97478412),
        dec: Angle.Degrees(+05.44581443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140775"},
        {"Hipparcos Number", "HIP 77163"},
        {"Geneva Identification System", "GEN# +1.00140775"},
        {"Smithsonian Astrophysical Observation", "SAO 121170"},
        {"Wilson Evans Batten Catalogue", "WEB 13080"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.34778279),
        dec: Angle.Degrees(+05.44732255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11983"},
        {"Cincinnati Publication", "Ci 20 173"},
        {"Geneva Identification System", "GEN# +0.00400415"},
        {"Wilson Evans Batten Catalogue", "WEB 2473"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.64469159),
        dec: Angle.Degrees(+05.44770594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -575.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142128"},
        {"Hipparcos Number", "HIP 77757"},
        {"Smithsonian Astrophysical Observation", "SAO 121234"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.15301640),
        dec: Angle.Degrees(+05.44977976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185760"},
        {"Hipparcos Number", "HIP 96793"},
        {"Geneva Identification System", "GEN# +1.00185760"},
        {"Smithsonian Astrophysical Observation", "SAO 124923"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14277315),
        dec: Angle.Degrees(+05.45069603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59301"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.49491289),
        dec: Angle.Degrees(+05.45472085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185121"},
        {"Hipparcos Number", "HIP 96525"},
        {"Smithsonian Astrophysical Observation", "SAO 124860"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.35417795),
        dec: Angle.Degrees(+05.45472885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8613"},
        {"Hipparcos Number", "HIP 6638"},
        {"Smithsonian Astrophysical Observation", "SAO 109877"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.28642799),
        dec: Angle.Degrees(+05.45490498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92194"},
        {"Geneva Identification System", "GEN# +0.00503950A"},
        {"Wilson Evans Batten Catalogue", "WEB 15898"},
    },
    visualMagnitude: 9.24,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83759198),
        dec: Angle.Degrees(+05.45516554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93363"},
        {"Geneva Identification System", "GEN# +0.00504011"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25404564),
        dec: Angle.Degrees(+05.46167488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -459.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36897"},
        {"Hipparcos Number", "HIP 26211"},
        {"Geneva Identification System", "GEN# +1.00036897"},
        {"Smithsonian Astrophysical Observation", "SAO 112924"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.78986411),
        dec: Angle.Degrees(+05.46220993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171442"},
        {"Hipparcos Number", "HIP 91087"},
        {"Smithsonian Astrophysical Observation", "SAO 123656"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.69286485),
        dec: Angle.Degrees(+05.46313366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46375"},
        {"Henry Draper 2", "HD 46375A"},
        {"Hipparcos Number", "HIP 31246"},
        {"Geneva Identification System", "GEN# +2.22440400"},
        {"Smithsonian Astrophysical Observation", "SAO 114040"},
        {"Wilson Evans Batten Catalogue", "WEB 6245"},
        {"New General Catalogue", "NGC 2244 400"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.30231992),
        dec: Angle.Degrees(+05.46316076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9096"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.29207910),
        dec: Angle.Degrees(+05.46354230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115832"},
        {"Hipparcos Number", "HIP 65013"},
        {"Geneva Identification System", "GEN# +1.00115832"},
        {"Smithsonian Astrophysical Observation", "SAO 119880"},
        {"Wilson Evans Batten Catalogue", "WEB 11488"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.89981621),
        dec: Angle.Degrees(+05.46358318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245965"},
        {"Hipparcos Number", "HIP 26573"},
        {"Smithsonian Astrophysical Observation", "SAO 112996"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73982898),
        dec: Angle.Degrees(+05.46386693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76148"},
        {"Hipparcos Number", "HIP 43739"},
        {"Smithsonian Astrophysical Observation", "SAO 117252"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.62846489),
        dec: Angle.Degrees(+05.46445145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175117"},
        {"Hipparcos Number", "HIP 92724"},
        {"Smithsonian Astrophysical Observation", "SAO 124015"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.42282903),
        dec: Angle.Degrees(+05.46493519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184313"},
        {"Hipparcos Number", "HIP 96204"},
        {"Geneva Identification System", "GEN# +1.00184313"},
        {"Smithsonian Astrophysical Observation", "SAO 124789"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.44180953),
        dec: Angle.Degrees(+05.46576513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92458"},
        {"Hipparcos Number", "HIP 52259"},
        {"Smithsonian Astrophysical Observation", "SAO 118427"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.15999456),
        dec: Angle.Degrees(+05.46618859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71483"},
        {"Smithsonian Astrophysical Observation", "SAO 120565"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.27473318),
        dec: Angle.Degrees(+05.46824808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79066"},
        {"Hipparcos Number", "HIP 45150"},
        {"Geneva Identification System", "GEN# +1.00079066"},
        {"Renson", "Renson 22420"},
        {"Smithsonian Astrophysical Observation", "SAO 117487"},
        {"Wilson Evans Batten Catalogue", "WEB 8612"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98204681),
        dec: Angle.Degrees(+05.46865324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46196"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.28697588),
        dec: Angle.Degrees(+05.46904814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12320"},
        {"Geneva Identification System", "GEN# +6.20001025"},
    },
    visualMagnitude: 12.04,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65743064),
        dec: Angle.Degrees(+05.46980535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115521"},
        {"Hipparcos Number", "HIP 64852"},
        {"Fundamental Katalog 5th Edition", "FK5 1344"},
        {"Geneva Identification System", "GEN# +1.00115521"},
        {"Smithsonian Astrophysical Observation", "SAO 119855"},
        {"Wilson Evans Batten Catalogue", "WEB 11462"},
    },
    visualMagnitude: 4.78,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40119538),
        dec: Angle.Degrees(+05.46984502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16150"},
    },
    visualMagnitude: 11.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.03514429),
        dec: Angle.Degrees(+17.16271929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221701"},
        {"Hipparcos Number", "HIP 116338"},
        {"Geneva Identification System", "GEN# +1.00221701"},
        {"Smithsonian Astrophysical Observation", "SAO 128260"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.60458795),
        dec: Angle.Degrees(+05.47054421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69245"},
        {"Smithsonian Astrophysical Observation", "SAO 120324"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.63888073),
        dec: Angle.Degrees(+05.47222560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3344 AB"},
        {"Hipparcos Number", "HIP 21529"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.34244035),
        dec: Angle.Degrees(+05.47230217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49162"},
        {"Hipparcos Number", "HIP 32535"},
        {"Geneva Identification System", "GEN# +1.00049162"},
        {"Smithsonian Astrophysical Observation", "SAO 114411"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.83621520),
        dec: Angle.Degrees(+05.47381264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55184"},
        {"Hipparcos Number", "HIP 34789"},
        {"Geneva Identification System", "GEN# +1.00055184"},
        {"Smithsonian Astrophysical Observation", "SAO 115065"},
        {"Wilson Evans Batten Catalogue", "WEB 6952"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.03126799),
        dec: Angle.Degrees(+05.47436198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6069"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.47166330),
        dec: Angle.Degrees(+05.47546960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -629.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34428"},
        {"Hipparcos Number", "HIP 24666"},
        {"Fundamental Katalog 5th Edition", "FK5 4479"},
        {"Geneva Identification System", "GEN# +1.00034428"},
        {"Smithsonian Astrophysical Observation", "SAO 112598"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.38424024),
        dec: Angle.Degrees(+05.48233783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44693"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.61432858),
        dec: Angle.Degrees(+05.48321887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10380"},
        {"Hipparcos Number", "HIP 7884"},
        {"Fundamental Katalog 5th Edition", "FK5 56"},
        {"Geneva Identification System", "GEN# +1.00010380"},
        {"Smithsonian Astrophysical Observation", "SAO 110065"},
        {"Wilson Evans Batten Catalogue", "WEB 1682"},
    },
    visualMagnitude: 4.45,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.35794814),
        dec: Angle.Degrees(+05.48760445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152067"},
        {"Hipparcos Number", "HIP 82449"},
        {"Geneva Identification System", "GEN# +1.00152067"},
        {"Smithsonian Astrophysical Observation", "SAO 121902"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.74565135),
        dec: Angle.Degrees(+05.48904017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107472"},
        {"Hipparcos Number", "HIP 60247"},
        {"Geneva Identification System", "GEN# +1.00107472"},
        {"Smithsonian Astrophysical Observation", "SAO 119346"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.30362258),
        dec: Angle.Degrees(+05.49031584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9493 A"},
        {"Henry Draper", "HD 133408"},
        {"Henry Draper 2", "HD 133408A"},
        {"Hipparcos Number", "HIP 73716"},
        {"Geneva Identification System", "GEN# +1.00133408A"},
        {"Smithsonian Astrophysical Observation", "SAO 120822"},
        {"Wilson Evans Batten Catalogue", "WEB 12602"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.02684183),
        dec: Angle.Degrees(+05.49290415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79394"},
        {"Geneva Identification System", "GEN# +9.80016034"},
        {"Wilson Evans Batten Catalogue", "WEB 13428"},
    },
    visualMagnitude: 11.85,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.04947395),
        dec: Angle.Degrees(+05.49292645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -354.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -638.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74790"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.26761917),
        dec: Angle.Degrees(+05.49362698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104606"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.85278744),
        dec: Angle.Degrees(+05.49393274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18215"},
        {"Hipparcos Number", "HIP 13641"},
        {"Smithsonian Astrophysical Observation", "SAO 110844"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.90933898),
        dec: Angle.Degrees(+05.49616639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183992"},
        {"Hipparcos Number", "HIP 96079"},
        {"Smithsonian Astrophysical Observation", "SAO 124743"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.01769809),
        dec: Angle.Degrees(+05.49679906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120602"},
        {"Hipparcos Number", "HIP 67545"},
        {"Fundamental Katalog 5th Edition", "FK5 3100"},
        {"Geneva Identification System", "GEN# +1.00120602"},
        {"Smithsonian Astrophysical Observation", "SAO 120132"},
        {"Wilson Evans Batten Catalogue", "WEB 11877"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.60280332),
        dec: Angle.Degrees(+05.49722180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219347"},
        {"Hipparcos Number", "HIP 114783"},
        {"Smithsonian Astrophysical Observation", "SAO 128065"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.77456154),
        dec: Angle.Degrees(+05.49755001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134047"},
        {"Hipparcos Number", "HIP 74026"},
        {"Fundamental Katalog 5th Edition", "FK5 3196"},
        {"Geneva Identification System", "GEN# +1.00134047"},
        {"Smithsonian Astrophysical Observation", "SAO 120852"},
        {"Wilson Evans Batten Catalogue", "WEB 12642"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.91801634),
        dec: Angle.Degrees(+05.49808887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38038"},
        {"Hipparcos Number", "HIP 26936"},
        {"Smithsonian Astrophysical Observation", "SAO 113064"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74607647),
        dec: Angle.Degrees(+05.49815035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52547",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7911 AB"},
        {"Henry Draper", "HD 93017"},
        {"Hipparcos Number", "HIP 52547"},
        {"Smithsonian Astrophysical Observation", "SAO 118465"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16128693),
        dec: Angle.Degrees(+05.49859810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102180"},
        {"Hipparcos Number", "HIP 57369"},
        {"Smithsonian Astrophysical Observation", "SAO 119032"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.42031596),
        dec: Angle.Degrees(+05.50008881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11640 ABCD"},
        {"Henry Draper", "HD 173495"},
        {"Hipparcos Number", "HIP 92027"},
        {"Geneva Identification System", "GEN# +1.00173495J"},
        {"Smithsonian Astrophysical Observation", "SAO 123886"},
        {"Wilson Evans Batten Catalogue", "WEB 15856"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36814952),
        dec: Angle.Degrees(+05.50012301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200644"},
        {"Hipparcos Number", "HIP 104031"},
        {"Geneva Identification System", "GEN# +1.00200644"},
        {"Smithsonian Astrophysical Observation", "SAO 126518"},
        {"Wilson Evans Batten Catalogue", "WEB 18951"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.14434879),
        dec: Angle.Degrees(+05.50286035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72722"},
        {"Hipparcos Number", "HIP 42076"},
        {"Smithsonian Astrophysical Observation", "SAO 116903"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.63836728),
        dec: Angle.Degrees(+05.50392957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80700"},
        {"Hipparcos Number", "HIP 45882"},
        {"Smithsonian Astrophysical Observation", "SAO 117615"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.33499440),
        dec: Angle.Degrees(+05.50426853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92331"},
        {"Smithsonian Astrophysical Observation", "SAO 123941"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.26922818),
        dec: Angle.Degrees(+05.50442619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101729"},
        {"Hipparcos Number", "HIP 57109"},
        {"Smithsonian Astrophysical Observation", "SAO 119004"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.61453864),
        dec: Angle.Degrees(+05.50546023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220225"},
        {"Hipparcos Number", "HIP 115364"},
        {"Smithsonian Astrophysical Observation", "SAO 128142"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.51295638),
        dec: Angle.Degrees(+05.50613638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158556"},
        {"Hipparcos Number", "HIP 85625"},
        {"Smithsonian Astrophysical Observation", "SAO 122438"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.45244363),
        dec: Angle.Degrees(+05.50666027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70232"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.54687910),
        dec: Angle.Degrees(+05.50743884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150281"},
        {"Hipparcos Number", "HIP 81598"},
        {"Cincinnati Publication", "Ci 18 2221"},
        {"Geneva Identification System", "GEN# +1.00150281"},
        {"Smithsonian Astrophysical Observation", "SAO 121764"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.95802026),
        dec: Angle.Degrees(+05.50794653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138596"},
        {"Hipparcos Number", "HIP 76129"},
        {"Smithsonian Astrophysical Observation", "SAO 121056"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23818644),
        dec: Angle.Degrees(+05.50894753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100654",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13810 A"},
        {"Henry Draper", "HD 194262"},
        {"Hipparcos Number", "HIP 100654"},
        {"Smithsonian Astrophysical Observation", "SAO 125770"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.13849198),
        dec: Angle.Degrees(+05.50948086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64513"},
        {"Hipparcos Number", "HIP 38617"},
        {"Geneva Identification System", "GEN# +1.00064513"},
        {"Smithsonian Astrophysical Observation", "SAO 116094"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.61324352),
        dec: Angle.Degrees(+05.51023856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208476"},
        {"Hipparcos Number", "HIP 108284"},
        {"Smithsonian Astrophysical Observation", "SAO 127170"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.07131120),
        dec: Angle.Degrees(+05.51190488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46784"},
        {"Hipparcos Number", "HIP 31466"},
        {"Geneva Identification System", "GEN# +1.00046784"},
        {"Smithsonian Astrophysical Observation", "SAO 114100"},
        {"Wilson Evans Batten Catalogue", "WEB 6295"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.86995531),
        dec: Angle.Degrees(+05.51256460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21777"},
        {"Hipparcos Number", "HIP 16356"},
        {"Geneva Identification System", "GEN# +1.00021777"},
        {"Smithsonian Astrophysical Observation", "SAO 111231"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.68639552),
        dec: Angle.Degrees(+05.51308576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139972"},
        {"Hipparcos Number", "HIP 76815"},
        {"Smithsonian Astrophysical Observation", "SAO 121125"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.25698250),
        dec: Angle.Degrees(+05.51444550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45420"},
        {"Smithsonian Astrophysical Observation", "SAO 117539"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.83001912),
        dec: Angle.Degrees(+05.51545328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179791"},
        {"Hipparcos Number", "HIP 94478"},
        {"Geneva Identification System", "GEN# +1.00179791"},
        {"Renson", "Renson 49910"},
        {"Smithsonian Astrophysical Observation", "SAO 124410"},
        {"Wilson Evans Batten Catalogue", "WEB 16466"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.43342490),
        dec: Angle.Degrees(+05.51563787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53645"},
        {"Hipparcos Number", "HIP 34255"},
        {"Smithsonian Astrophysical Observation", "SAO 114912"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.51026804),
        dec: Angle.Degrees(+05.51670737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149525"},
        {"Hipparcos Number", "HIP 81205"},
        {"Smithsonian Astrophysical Observation", "SAO 121710"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.80041432),
        dec: Angle.Degrees(+05.51791525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5256 AB"},
        {"Henry Draper", "HD 47072"},
        {"Hipparcos Number", "HIP 31622"},
        {"Geneva Identification System", "GEN# +1.00047072J"},
        {"Renson", "Renson 12610"},
        {"Smithsonian Astrophysical Observation", "SAO 114136"},
        {"Wilson Evans Batten Catalogue", "WEB 6329"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.26458452),
        dec: Angle.Degrees(+05.51937165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14148"},
        {"Hipparcos Number", "HIP 10678"},
        {"Smithsonian Astrophysical Observation", "SAO 110454"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.34577118),
        dec: Angle.Degrees(+05.51964071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138643"},
        {"Hipparcos Number", "HIP 76151"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.30603960),
        dec: Angle.Degrees(+05.52010776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149121"},
        {"Hipparcos Number", "HIP 81007"},
        {"Fundamental Katalog 5th Edition", "FK5 3309"},
        {"Geneva Identification System", "GEN# +1.00149121"},
        {"Renson", "Renson 42160"},
        {"Smithsonian Astrophysical Observation", "SAO 121676"},
        {"Wilson Evans Batten Catalogue", "WEB 13700"},
    },
    visualMagnitude: 5.63,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.14865065),
        dec: Angle.Degrees(+05.52122134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26462"},
        {"Hipparcos Number", "HIP 19554"},
        {"Fundamental Katalog 5th Edition", "FK5 2301"},
        {"Geneva Identification System", "GEN# +5.20250014"},
        {"Smithsonian Astrophysical Observation", "SAO 111648"},
        {"Wilson Evans Batten Catalogue", "WEB 3743"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.83414887),
        dec: Angle.Degrees(+05.52303505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156913"},
        {"Hipparcos Number", "HIP 84812"},
        {"Smithsonian Astrophysical Observation", "SAO 122283"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01112012),
        dec: Angle.Degrees(+05.52814580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88389"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.73998064),
        dec: Angle.Degrees(+05.52863849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161573"},
        {"Hipparcos Number", "HIP 86954"},
        {"Geneva Identification System", "GEN# +3.46650062"},
        {"Smithsonian Astrophysical Observation", "SAO 122723"},
        {"Wilson Evans Batten Catalogue", "WEB 14669"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.53052153),
        dec: Angle.Degrees(+05.53021692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62320"},
        {"Smithsonian Astrophysical Observation", "SAO 119577"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.56773808),
        dec: Angle.Degrees(+05.53116948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124970"},
        {"Hipparcos Number", "HIP 69756"},
        {"Geneva Identification System", "GEN# +1.00124970"},
        {"Smithsonian Astrophysical Observation", "SAO 120376"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.14482726),
        dec: Angle.Degrees(+05.53198397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147905"},
        {"Hipparcos Number", "HIP 80380"},
        {"Smithsonian Astrophysical Observation", "SAO 121572"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.11141508),
        dec: Angle.Degrees(+05.53260587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51813"},
        {"Hipparcos Number", "HIP 33608"},
        {"Geneva Identification System", "GEN# +1.00051813"},
        {"Smithsonian Astrophysical Observation", "SAO 114721"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.74614332),
        dec: Angle.Degrees(+05.53525852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21270"},
        {"Hipparcos Number", "HIP 16003"},
        {"Smithsonian Astrophysical Observation", "SAO 111185"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.52020553),
        dec: Angle.Degrees(+05.53560901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147062"},
        {"Hipparcos Number", "HIP 79975"},
        {"Geneva Identification System", "GEN# +1.00147062"},
        {"Smithsonian Astrophysical Observation", "SAO 121502"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.85802642),
        dec: Angle.Degrees(+05.53817335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109374"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36841158),
        dec: Angle.Degrees(+05.54005485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130670"},
        {"Hipparcos Number", "HIP 72502"},
        {"Smithsonian Astrophysical Observation", "SAO 120678"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36686160),
        dec: Angle.Degrees(+05.54104126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49368"},
        {"Hipparcos Number", "HIP 32627"},
        {"Geneva Identification System", "GEN# +1.00049368"},
        {"Smithsonian Astrophysical Observation", "SAO 114437"},
        {"Wilson Evans Batten Catalogue", "WEB 6580"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09290394),
        dec: Angle.Degrees(+05.54168547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112162"},
        {"Hipparcos Number", "HIP 62989"},
        {"Smithsonian Astrophysical Observation", "SAO 119656"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.60577076),
        dec: Angle.Degrees(+05.54224260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37574"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66709764),
        dec: Angle.Degrees(+05.54228869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164283"},
        {"Hipparcos Number", "HIP 88139"},
        {"Smithsonian Astrophysical Observation", "SAO 123003"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.04062381),
        dec: Angle.Degrees(+05.54286499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107931"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.00623677),
        dec: Angle.Degrees(+05.54295109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198404"},
        {"Hipparcos Number", "HIP 102833"},
        {"Geneva Identification System", "GEN# +1.00198404"},
        {"Smithsonian Astrophysical Observation", "SAO 126267"},
        {"Wilson Evans Batten Catalogue", "WEB 18652"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.49613207),
        dec: Angle.Degrees(+05.54455718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22362"},
        {"Geneva Identification System", "GEN# +0.00500735"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.21266889),
        dec: Angle.Degrees(+05.54472581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8510 AB"},
        {"Henry Draper", "HD 107228"},
        {"Hipparcos Number", "HIP 60112"},
        {"Smithsonian Astrophysical Observation", "SAO 119331"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91850179),
        dec: Angle.Degrees(+05.54527109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85665"},
        {"Geneva Identification System", "GEN# +0.00503409"},
        {"Smithsonian Astrophysical Observation", "SAO 122446"},
        {"Wilson Evans Batten Catalogue", "WEB 14456"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.59462845),
        dec: Angle.Degrees(+05.54912350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133818"},
        {"Hipparcos Number", "HIP 73914"},
        {"Geneva Identification System", "GEN# +1.00133818"},
        {"Smithsonian Astrophysical Observation", "SAO 120837"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57565830),
        dec: Angle.Degrees(+05.55042031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111691"},
        {"Hipparcos Number", "HIP 62712"},
        {"Smithsonian Astrophysical Observation", "SAO 119627"},
        {"Wilson Evans Batten Catalogue", "WEB 11120"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.77393087),
        dec: Angle.Degrees(+05.55320365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6693 B"},
        {"Hipparcos Number", "HIP 40425"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.81517993),
        dec: Angle.Degrees(+05.55434294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137871"},
        {"Hipparcos Number", "HIP 75740"},
        {"Fundamental Katalog 5th Edition", "FK5 5369"},
        {"Smithsonian Astrophysical Observation", "SAO 121016"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.10124535),
        dec: Angle.Degrees(+05.55483847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210859"},
        {"Hipparcos Number", "HIP 109697"},
        {"Smithsonian Astrophysical Observation", "SAO 127378"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29963776),
        dec: Angle.Degrees(+05.55514377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52559"},
        {"Hipparcos Number", "HIP 33875"},
        {"Geneva Identification System", "GEN# +1.00052559"},
        {"Renson", "Renson 14394"},
        {"Smithsonian Astrophysical Observation", "SAO 114801"},
        {"Wilson Evans Batten Catalogue", "WEB 6802"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48025897),
        dec: Angle.Degrees(+05.55716475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241253"},
        {"Hipparcos Number", "HIP 24030"},
        {"Geneva Identification System", "GEN# +1.00241253"},
        {"Smithsonian Astrophysical Observation", "SAO 112483"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.48666987),
        dec: Angle.Degrees(+05.55760078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104755"},
        {"Hipparcos Number", "HIP 58809"},
        {"Geneva Identification System", "GEN# +1.00104755"},
        {"Smithsonian Astrophysical Observation", "SAO 119189"},
        {"Wilson Evans Batten Catalogue", "WEB 10479"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93554059),
        dec: Angle.Degrees(+05.55795197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6693 A"},
        {"Henry Draper", "HD 69033"},
        {"Hipparcos Number", "HIP 40428"},
        {"Smithsonian Astrophysical Observation", "SAO 116535"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.81591893),
        dec: Angle.Degrees(+05.55801449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48044"},
        {"Smithsonian Astrophysical Observation", "SAO 117913"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.90682244),
        dec: Angle.Degrees(+05.55928163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200274"},
        {"Hipparcos Number", "HIP 103835"},
        {"Smithsonian Astrophysical Observation", "SAO 126484"},
        {"Wilson Evans Batten Catalogue", "WEB 18902"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.61001014),
        dec: Angle.Degrees(+05.56043808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12856"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.31971185),
        dec: Angle.Degrees(+05.56099637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118792"},
        {"Hipparcos Number", "HIP 66586"},
        {"Smithsonian Astrophysical Observation", "SAO 120052"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.74131719),
        dec: Angle.Degrees(+05.56268240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182407"},
        {"Hipparcos Number", "HIP 95401"},
        {"Geneva Identification System", "GEN# +1.00182407"},
        {"Smithsonian Astrophysical Observation", "SAO 124586"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.09584601),
        dec: Angle.Degrees(+05.56438239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76311"},
        {"Hipparcos Number", "HIP 43816"},
        {"Geneva Identification System", "GEN# +1.00076311"},
        {"Smithsonian Astrophysical Observation", "SAO 117265"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.85882161),
        dec: Angle.Degrees(+05.56591992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28978"},
        {"Hipparcos Number", "HIP 21295"},
        {"Fundamental Katalog 5th Edition", "FK5 2335"},
        {"Geneva Identification System", "GEN# +1.00028978"},
        {"Smithsonian Astrophysical Observation", "SAO 111896"},
        {"Wilson Evans Batten Catalogue", "WEB 4093"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.53448353),
        dec: Angle.Degrees(+05.56863495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194039"},
        {"Hipparcos Number", "HIP 100552"},
        {"Smithsonian Astrophysical Observation", "SAO 125750"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.83144543),
        dec: Angle.Degrees(+05.57054283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3905"},
        {"Hipparcos Number", "HIP 3270"},
        {"Smithsonian Astrophysical Observation", "SAO 109374"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.41795260),
        dec: Angle.Degrees(+05.57362501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123440"},
        {"Hipparcos Number", "HIP 69015"},
        {"Smithsonian Astrophysical Observation", "SAO 120296"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.92435700),
        dec: Angle.Degrees(+05.57501332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7824"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.16075600),
        dec: Angle.Degrees(+05.57718542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7701"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78258689),
        dec: Angle.Degrees(+05.57854420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80823"},
        {"Hipparcos Number", "HIP 45942"},
        {"Geneva Identification System", "GEN# +1.00080823"},
        {"Smithsonian Astrophysical Observation", "SAO 117624"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.53428750),
        dec: Angle.Degrees(+05.57882821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204832"},
        {"Hipparcos Number", "HIP 106242"},
        {"Smithsonian Astrophysical Observation", "SAO 126860"},
        {"Wilson Evans Batten Catalogue", "WEB 19247"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.78844984),
        dec: Angle.Degrees(+05.57919099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58500"},
        {"Hipparcos Number", "HIP 36082"},
        {"Smithsonian Astrophysical Observation", "SAO 115437"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.51907710),
        dec: Angle.Degrees(+05.58019742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24947"},
        {"Hipparcos Number", "HIP 18550"},
        {"Smithsonian Astrophysical Observation", "SAO 111528"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.52999831),
        dec: Angle.Degrees(+05.58136975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118069"},
        {"Hipparcos Number", "HIP 66227"},
        {"Smithsonian Astrophysical Observation", "SAO 120013"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.60053490),
        dec: Angle.Degrees(+05.58214978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24603"},
        {"Hipparcos Number", "HIP 18308"},
        {"Smithsonian Astrophysical Observation", "SAO 111498"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.70712017),
        dec: Angle.Degrees(+05.58380615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191548"},
        {"Hipparcos Number", "HIP 99392"},
        {"Geneva Identification System", "GEN# +1.00191548"},
        {"Smithsonian Astrophysical Observation", "SAO 125522"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.60740588),
        dec: Angle.Degrees(+05.58409233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216613"},
        {"Hipparcos Number", "HIP 113090"},
        {"Smithsonian Astrophysical Observation", "SAO 127829"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.54185838),
        dec: Angle.Degrees(+05.58411416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93967"},
        {"Hipparcos Number", "HIP 53021"},
        {"Fundamental Katalog 5th Edition", "FK5 4957"},
        {"Geneva Identification System", "GEN# +1.00093967"},
        {"Smithsonian Astrophysical Observation", "SAO 118529"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.72143908),
        dec: Angle.Degrees(+05.58582434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193016"},
        {"Hipparcos Number", "HIP 100050"},
        {"Geneva Identification System", "GEN# +1.00193016"},
        {"Smithsonian Astrophysical Observation", "SAO 125658"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.47586289),
        dec: Angle.Degrees(+05.58639433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181365"},
        {"Hipparcos Number", "HIP 95017"},
        {"Geneva Identification System", "GEN# +1.00181365"},
        {"Smithsonian Astrophysical Observation", "SAO 124514"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.00455620),
        dec: Angle.Degrees(+05.58768912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1076"},
        {"Hipparcos Number", "HIP 1199"},
        {"Smithsonian Astrophysical Observation", "SAO 109089"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.75013144),
        dec: Angle.Degrees(+05.58836463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14829"},
        {"Smithsonian Astrophysical Observation", "SAO 111035"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.87330803),
        dec: Angle.Degrees(+05.58897184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17250"},
        {"Hipparcos Number", "HIP 12925"},
        {"Fundamental Katalog 5th Edition", "FK5 4252"},
        {"Geneva Identification System", "GEN# +1.00017250"},
        {"Smithsonian Astrophysical Observation", "SAO 110736"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.56068842),
        dec: Angle.Degrees(+05.59269943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12093",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1971 A"},
        {"Henry Draper", "HD 16161"},
        {"Hipparcos Number", "HIP 12093"},
        {"Fundamental Katalog 5th Edition", "FK5 1072"},
        {"Geneva Identification System", "GEN# +1.00016161A"},
        {"Smithsonian Astrophysical Observation", "SAO 110635"},
        {"Wilson Evans Batten Catalogue", "WEB 2490"},
    },
    visualMagnitude: 4.87,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.96870420),
        dec: Angle.Degrees(+05.59330163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103649"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.00970279),
        dec: Angle.Degrees(+05.59342538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35805"},
        {"Hipparcos Number", "HIP 25525"},
        {"Smithsonian Astrophysical Observation", "SAO 112788"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.87527257),
        dec: Angle.Degrees(+05.59522803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95016"},
        {"Smithsonian Astrophysical Observation", "SAO 124513"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.00403240),
        dec: Angle.Degrees(+05.59600808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136696"},
        {"Hipparcos Number", "HIP 75196"},
        {"Geneva Identification System", "GEN# +1.00136696"},
        {"Smithsonian Astrophysical Observation", "SAO 120960"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.50056202),
        dec: Angle.Degrees(+05.59658019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214114"},
        {"Hipparcos Number", "HIP 111555"},
        {"Smithsonian Astrophysical Observation", "SAO 127627"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.99942362),
        dec: Angle.Degrees(+05.59863493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26922",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4294 AB"},
        {"Henry Draper", "HD 38012"},
        {"Hipparcos Number", "HIP 26922"},
        {"Smithsonian Astrophysical Observation", "SAO 113061"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.71422148),
        dec: Angle.Degrees(+05.60327704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91513"},
        {"Geneva Identification System", "GEN# +3.47560151"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95073714),
        dec: Angle.Degrees(+05.60414941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30836"},
        {"Hipparcos Number", "HIP 22549"},
        {"Fundamental Katalog 5th Edition", "FK5 179"},
        {"Geneva Identification System", "GEN# +1.00030836"},
        {"Smithsonian Astrophysical Observation", "SAO 112142"},
        {"Wilson Evans Batten Catalogue", "WEB 4358"},
    },
    visualMagnitude: 3.68,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80152507),
        dec: Angle.Degrees(+05.60510146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99483"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.85027943),
        dec: Angle.Degrees(+05.60553789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171263"},
        {"Hipparcos Number", "HIP 90990"},
        {"Geneva Identification System", "GEN# +1.00171263"},
        {"Renson", "Renson 47960"},
        {"Smithsonian Astrophysical Observation", "SAO 123641"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.40040644),
        dec: Angle.Degrees(+05.60676178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78554"},
        {"Hipparcos Number", "HIP 44917"},
        {"Geneva Identification System", "GEN# +1.00078554"},
        {"Smithsonian Astrophysical Observation", "SAO 117456"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.25892560),
        dec: Angle.Degrees(+05.60749636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70158"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32383103),
        dec: Angle.Degrees(+05.60982590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86621"},
        {"Hipparcos Number", "HIP 49004"},
        {"Smithsonian Astrophysical Observation", "SAO 118042"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.96022783),
        dec: Angle.Degrees(+05.60983888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87682"},
        {"Hipparcos Number", "HIP 49530"},
        {"Fundamental Katalog 5th Edition", "FK5 2811"},
        {"Geneva Identification System", "GEN# +1.00087682"},
        {"Smithsonian Astrophysical Observation", "SAO 118111"},
        {"Wilson Evans Batten Catalogue", "WEB 9138"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.69768400),
        dec: Angle.Degrees(+05.61153274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208907"},
        {"Hipparcos Number", "HIP 108539"},
        {"Smithsonian Astrophysical Observation", "SAO 127208"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.81945179),
        dec: Angle.Degrees(+05.61218677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97747"},
        {"Geneva Identification System", "GEN# +0.00504314"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.95704243),
        dec: Angle.Degrees(+05.61329675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111306"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.23659251),
        dec: Angle.Degrees(+05.61454232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26358"},
        {"Hipparcos Number", "HIP 19495"},
        {"Smithsonian Astrophysical Observation", "SAO 111641"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.64869976),
        dec: Angle.Degrees(+05.61496175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20822"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.92709503),
        dec: Angle.Degrees(+05.61522839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126381"},
        {"Hipparcos Number", "HIP 70486"},
        {"Smithsonian Astrophysical Observation", "SAO 120442"},
        {"Wilson Evans Batten Catalogue", "WEB 12228"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.26410235),
        dec: Angle.Degrees(+05.61537811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19961"},
    },
    visualMagnitude: 12.19,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.20336992),
        dec: Angle.Degrees(+05.61867021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38987",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6492 A"},
        {"Henry Draper", "HD 65396"},
        {"Hipparcos Number", "HIP 38987"},
        {"Smithsonian Astrophysical Observation", "SAO 116192"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.68826315),
        dec: Angle.Degrees(+05.62327036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19312"},
        {"Hipparcos Number", "HIP 14454"},
        {"Geneva Identification System", "GEN# +1.00019312"},
        {"Smithsonian Astrophysical Observation", "SAO 110972"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63886609),
        dec: Angle.Degrees(+05.62503308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28748"},
        {"Hipparcos Number", "HIP 21155"},
        {"Smithsonian Astrophysical Observation", "SAO 111881"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.02949437),
        dec: Angle.Degrees(+05.62573222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11115"},
        {"Hipparcos Number", "HIP 8494"},
        {"Smithsonian Astrophysical Observation", "SAO 110150"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.37594533),
        dec: Angle.Degrees(+05.62638234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103073"},
        {"Hipparcos Number", "HIP 57868"},
        {"Smithsonian Astrophysical Observation", "SAO 119086"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04166107),
        dec: Angle.Degrees(+05.62683858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107948"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.04311663),
        dec: Angle.Degrees(+05.62699381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222368"},
        {"Hipparcos Number", "HIP 116771"},
        {"Cincinnati Publication", "Ci 20 1444"},
        {"Fundamental Katalog 5th Edition", "FK5 892"},
        {"Geneva Identification System", "GEN# +1.00222368"},
        {"Smithsonian Astrophysical Observation", "SAO 128310"},
        {"Wilson Evans Batten Catalogue", "WEB 20603"},
    },
    visualMagnitude: 4.13,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.98675133),
        dec: Angle.Degrees(+05.62735374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 376.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -437.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9920"},
        {"Hipparcos Number", "HIP 7532"},
        {"Smithsonian Astrophysical Observation", "SAO 110014"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.25883303),
        dec: Angle.Degrees(+05.63097605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1050"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.27097933),
        dec: Angle.Degrees(+05.63141884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53513"},
        {"Smithsonian Astrophysical Observation", "SAO 118582"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.20962913),
        dec: Angle.Degrees(+05.63144595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132952"},
        {"Hipparcos Number", "HIP 73529"},
        {"Smithsonian Astrophysical Observation", "SAO 120799"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.43821730),
        dec: Angle.Degrees(+05.63174697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31354"},
        {"Hipparcos Number", "HIP 22889"},
        {"Geneva Identification System", "GEN# +1.00031354"},
        {"Smithsonian Astrophysical Observation", "SAO 112209"},
        {"Wilson Evans Batten Catalogue", "WEB 4439"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.84449180),
        dec: Angle.Degrees(+05.63631416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73531"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.44003151),
        dec: Angle.Degrees(+05.63650084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2331"},
        {"Hipparcos Number", "HIP 2156"},
        {"Smithsonian Astrophysical Observation", "SAO 109215"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.80794034),
        dec: Angle.Degrees(+05.63761088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73786"},
        {"Geneva Identification System", "GEN# +0.00602986"},
        {"Wilson Evans Batten Catalogue", "WEB 12610"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.22450988),
        dec: Angle.Degrees(+05.63933100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -606.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -507.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59816",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8486 AB"},
        {"Hipparcos Number", "HIP 59816"},
        {"Geneva Identification System", "GEN# +0.00602573J"},
        {"Smithsonian Astrophysical Observation", "SAO 119296"},
        {"Wilson Evans Batten Catalogue", "WEB 10629"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.99382622),
        dec: Angle.Degrees(+05.64032242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -343.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72678"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.89755613),
        dec: Angle.Degrees(+05.64037729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77250"},
        {"Hipparcos Number", "HIP 44315"},
        {"Geneva Identification System", "GEN# +1.00077250"},
        {"Smithsonian Astrophysical Observation", "SAO 117351"},
        {"Wilson Evans Batten Catalogue", "WEB 8497"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38084948),
        dec: Angle.Degrees(+05.64099518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22556"},
        {"Hipparcos Number", "HIP 16930"},
        {"Geneva Identification System", "GEN# +1.00022556"},
        {"Smithsonian Astrophysical Observation", "SAO 111305"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.46868532),
        dec: Angle.Degrees(+05.64127859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15985 A"},
        {"Henry Draper", "HD 213194"},
        {"Hipparcos Number", "HIP 111030"},
        {"Smithsonian Astrophysical Observation", "SAO 127549"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.39716848),
        dec: Angle.Degrees(+05.64155518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63517"},
        {"Hipparcos Number", "HIP 38194"},
        {"Smithsonian Astrophysical Observation", "SAO 115980"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.38027495),
        dec: Angle.Degrees(+05.64519147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34700"},
        {"Hipparcos Number", "HIP 24855"},
        {"Smithsonian Astrophysical Observation", "SAO 112630"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.92253558),
        dec: Angle.Degrees(+05.64521312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28026"},
        {"Hipparcos Number", "HIP 20660"},
        {"Smithsonian Astrophysical Observation", "SAO 111807"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.40342984),
        dec: Angle.Degrees(+05.64533521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110513",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15889 AB"},
        {"Henry Draper", "HD 212317"},
        {"Hipparcos Number", "HIP 110513"},
        {"Smithsonian Astrophysical Observation", "SAO 127491"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.81293050),
        dec: Angle.Degrees(+05.64673170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115210"},
        {"Smithsonian Astrophysical Observation", "SAO 128123"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.02774580),
        dec: Angle.Degrees(+05.64735627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189712"},
        {"Hipparcos Number", "HIP 98565"},
        {"Fundamental Katalog 5th Edition", "FK5 5764"},
        {"Geneva Identification System", "GEN# +1.00189712"},
        {"Smithsonian Astrophysical Observation", "SAO 125360"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31631057),
        dec: Angle.Degrees(+05.64830270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19345"},
        {"Hipparcos Number", "HIP 14477"},
        {"Geneva Identification System", "GEN# +1.00019345"},
        {"Smithsonian Astrophysical Observation", "SAO 110979"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.70902227),
        dec: Angle.Degrees(+05.65017365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104351"},
    },
    visualMagnitude: 12.39,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.10376291),
        dec: Angle.Degrees(+05.65019869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6763"},
        {"Hipparcos Number", "HIP 5346"},
        {"Fundamental Katalog 5th Edition", "FK5 2073"},
        {"Geneva Identification System", "GEN# +1.00006763"},
        {"Smithsonian Astrophysical Observation", "SAO 109697"},
        {"Wilson Evans Batten Catalogue", "WEB 1157"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.09309979),
        dec: Angle.Degrees(+05.65022130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77293"},
        {"Hipparcos Number", "HIP 44344"},
        {"Geneva Identification System", "GEN# +1.00077293"},
        {"Smithsonian Astrophysical Observation", "SAO 117361"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.45499662),
        dec: Angle.Degrees(+05.65173871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46111"},
        {"Smithsonian Astrophysical Observation", "SAO 117658"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.05961108),
        dec: Angle.Degrees(+05.65263441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32815"},
        {"Hipparcos Number", "HIP 23723"},
        {"Smithsonian Astrophysical Observation", "SAO 112415"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.49941428),
        dec: Angle.Degrees(+05.65316941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55111"},
        {"Hipparcos Number", "HIP 34768"},
        {"Geneva Identification System", "GEN# +1.00055111"},
        {"Smithsonian Astrophysical Observation", "SAO 115062"},
        {"Wilson Evans Batten Catalogue", "WEB 6950"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.96412663),
        dec: Angle.Degrees(+05.65471549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82106"},
        {"Hipparcos Number", "HIP 46580"},
        {"Cincinnati Publication", "Ci 18 1126"},
        {"Cincinnati Publication 2", "Ci 20 529"},
        {"Geneva Identification System", "GEN# +1.00082106"},
        {"Smithsonian Astrophysical Observation", "SAO 117737"},
        {"Wilson Evans Batten Catalogue", "WEB 8787"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.47966660),
        dec: Angle.Degrees(+05.65486700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -504.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6386"},
        {"Hipparcos Number", "HIP 5074"},
        {"Geneva Identification System", "GEN# +1.00006386"},
        {"Smithsonian Astrophysical Observation", "SAO 109656"},
        {"Wilson Evans Batten Catalogue", "WEB 1041"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.21925150),
        dec: Angle.Degrees(+05.65630133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17065"},
        {"Hipparcos Number", "HIP 12802"},
        {"Geneva Identification System", "GEN# +1.00017065"},
        {"Smithsonian Astrophysical Observation", "SAO 110717"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.13589278),
        dec: Angle.Degrees(+05.65783465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114062"},
        {"Smithsonian Astrophysical Observation", "SAO 127965"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.49599046),
        dec: Angle.Degrees(+05.65813797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161603"},
        {"Hipparcos Number", "HIP 86960"},
        {"Geneva Identification System", "GEN# +3.46650064"},
        {"Smithsonian Astrophysical Observation", "SAO 122725"},
        {"Wilson Evans Batten Catalogue", "WEB 14670"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.54551298),
        dec: Angle.Degrees(+05.65823384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104079"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.29249759),
        dec: Angle.Degrees(+05.65983769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36824"},
        {"Hipparcos Number", "HIP 26166"},
        {"Celescope Catalog", "CEL 801"},
        {"Geneva Identification System", "GEN# +1.00036824"},
        {"Smithsonian Astrophysical Observation", "SAO 112912"},
        {"Wilson Evans Batten Catalogue", "WEB 5098"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.68066144),
        dec: Angle.Degrees(+05.66086634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195180"},
        {"Hipparcos Number", "HIP 101105"},
        {"Smithsonian Astrophysical Observation", "SAO 125862"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.42042227),
        dec: Angle.Degrees(+05.66126737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49841"},
        {"Hipparcos Number", "HIP 32831"},
        {"Smithsonian Astrophysical Observation", "SAO 114500"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.66239033),
        dec: Angle.Degrees(+05.66287398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42181"},
        {"Hipparcos Number", "HIP 29200"},
        {"Smithsonian Astrophysical Observation", "SAO 113521"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.38871402),
        dec: Angle.Degrees(+05.66327838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34834"},
        {"Hipparcos Number", "HIP 24933"},
        {"Geneva Identification System", "GEN# +1.00034834"},
        {"Smithsonian Astrophysical Observation", "SAO 112646"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13344035),
        dec: Angle.Degrees(+05.66382668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15985 BC"},
        {"Hipparcos Number", "HIP 111034"},
        {"Smithsonian Astrophysical Observation", "SAO 127550"},
    },
    visualMagnitude: 10.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.41276431),
        dec: Angle.Degrees(+05.66411363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37632"},
        {"Hipparcos Number", "HIP 26678"},
        {"Smithsonian Astrophysical Observation", "SAO 113017"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.04388506),
        dec: Angle.Degrees(+05.66498979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65428"},
        {"Smithsonian Astrophysical Observation", "SAO 119914"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.15917529),
        dec: Angle.Degrees(+05.66555830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42182"},
        {"Hipparcos Number", "HIP 29208"},
        {"Geneva Identification System", "GEN# +1.00042182"},
        {"Smithsonian Astrophysical Observation", "SAO 113522"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39948938),
        dec: Angle.Degrees(+05.66878655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107258"},
        {"Hipparcos Number", "HIP 60133"},
        {"Geneva Identification System", "GEN# +1.00107258"},
        {"Smithsonian Astrophysical Observation", "SAO 119334"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.98075954),
        dec: Angle.Degrees(+05.67159922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49739"},
        {"Hipparcos Number", "HIP 32793"},
        {"Geneva Identification System", "GEN# +1.00049739"},
        {"Smithsonian Astrophysical Observation", "SAO 114487"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.55146553),
        dec: Angle.Degrees(+05.67350105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3992"},
        {"Hipparcos Number", "HIP 3338"},
        {"Renson", "Renson 1103"},
        {"Smithsonian Astrophysical Observation", "SAO 109393"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.63667621),
        dec: Angle.Degrees(+05.67536372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3489 AB"},
        {"Henry Draper", "HD 30975"},
        {"Hipparcos Number", "HIP 22642"},
        {"Smithsonian Astrophysical Observation", "SAO 112164"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.07689842),
        dec: Angle.Degrees(+05.67695947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178774"},
        {"Hipparcos Number", "HIP 94139"},
        {"Smithsonian Astrophysical Observation", "SAO 124335"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.44020703),
        dec: Angle.Degrees(+05.67725003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10056"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.35904102),
        dec: Angle.Degrees(+05.67808079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -240.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206487"},
        {"Henry Draper 2", "HD 62122"},
        {"Hipparcos Number", "HIP 107151"},
        {"Fundamental Katalog 5th Edition", "FK5 3732"},
        {"Geneva Identification System", "GEN# +1.00206487"},
        {"Smithsonian Astrophysical Observation", "SAO 127002"},
        {"Wilson Evans Batten Catalogue", "WEB 19355"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.56435406),
        dec: Angle.Degrees(+05.68015144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74591"},
        {"Hipparcos Number", "HIP 42931"},
        {"Geneva Identification System", "GEN# +1.00074591"},
        {"Smithsonian Astrophysical Observation", "SAO 117088"},
        {"Wilson Evans Batten Catalogue", "WEB 8300"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.25532956),
        dec: Angle.Degrees(+05.68059675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126947"},
        {"Hipparcos Number", "HIP 70772"},
        {"Smithsonian Astrophysical Observation", "SAO 120480"},
        {"Wilson Evans Batten Catalogue", "WEB 12260"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.11906868),
        dec: Angle.Degrees(+05.68093068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106505"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.58063713),
        dec: Angle.Degrees(+05.68323854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206156"},
        {"Hipparcos Number", "HIP 106987"},
        {"Smithsonian Astrophysical Observation", "SAO 126972"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02372316),
        dec: Angle.Degrees(+05.68494078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13940"},
    },
    visualMagnitude: 12.10,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.89591019),
        dec: Angle.Degrees(+05.68572239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47430"},
        {"Hipparcos Number", "HIP 31793"},
        {"Celescope Catalog", "CEL 1335"},
        {"Smithsonian Astrophysical Observation", "SAO 114195"},
        {"Wilson Evans Batten Catalogue", "WEB 6386"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.71453267),
        dec: Angle.Degrees(+05.68574405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2993 AB"},
        {"Henry Draper", "HD 25942"},
        {"Hipparcos Number", "HIP 19189"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.68636100),
        dec: Angle.Degrees(+05.68678892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172961"},
        {"Hipparcos Number", "HIP 91766"},
        {"Geneva Identification System", "GEN# +1.00172961"},
        {"Smithsonian Astrophysical Observation", "SAO 123833"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.69119635),
        dec: Angle.Degrees(+05.68755507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13170"},
    },
    visualMagnitude: 12.18,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.34191600),
        dec: Angle.Degrees(+05.68809692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91299"},
        {"Geneva Identification System", "GEN# +3.47560043"},
        {"Smithsonian Astrophysical Observation", "SAO 123713"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.35048487),
        dec: Angle.Degrees(+05.68886509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14546"},
        {"Hipparcos Number", "HIP 10957"},
        {"Smithsonian Astrophysical Observation", "SAO 110486"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.28264851),
        dec: Angle.Degrees(+05.69130911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244459"},
        {"Hipparcos Number", "HIP 25831"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.72228820),
        dec: Angle.Degrees(+05.69282095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19271"},
        {"Smithsonian Astrophysical Observation", "SAO 111615"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96290999),
        dec: Angle.Degrees(+05.69290268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135856"},
        {"Hipparcos Number", "HIP 74811"},
        {"Smithsonian Astrophysical Observation", "SAO 120928"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.33170195),
        dec: Angle.Degrees(+05.69419140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20425"},
        {"Smithsonian Astrophysical Observation", "SAO 111777"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.63745337),
        dec: Angle.Degrees(+05.69425846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89995"},
        {"Hipparcos Number", "HIP 50870"},
        {"Fundamental Katalog 5th Edition", "FK5 2833"},
        {"Geneva Identification System", "GEN# +1.00089995"},
        {"Smithsonian Astrophysical Observation", "SAO 118271"},
        {"Wilson Evans Batten Catalogue", "WEB 9307"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.81146847),
        dec: Angle.Degrees(+05.69440723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161572"},
        {"Hipparcos Number", "HIP 86944"},
        {"Geneva Identification System", "GEN# +3.46650058"},
        {"Smithsonian Astrophysical Observation", "SAO 122716"},
        {"Wilson Evans Batten Catalogue", "WEB 14666"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.48778242),
        dec: Angle.Degrees(+05.69445645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159696"},
        {"Hipparcos Number", "HIP 86116"},
        {"Smithsonian Astrophysical Observation", "SAO 122546"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.97959421),
        dec: Angle.Degrees(+05.69552290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114941"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.21588833),
        dec: Angle.Degrees(+05.69606922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9762"},
    },
    visualMagnitude: 12.02,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37576685),
        dec: Angle.Degrees(+05.69724088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17335"},
        {"Smithsonian Astrophysical Observation", "SAO 111365"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.65368397),
        dec: Angle.Degrees(+05.69812364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15670"},
        {"Smithsonian Astrophysical Observation", "SAO 111153"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.47228630),
        dec: Angle.Degrees(+05.69930717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15904"},
        {"Hipparcos Number", "HIP 11895"},
        {"Smithsonian Astrophysical Observation", "SAO 110612"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.36573446),
        dec: Angle.Degrees(+05.70017304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159243"},
        {"Hipparcos Number", "HIP 85911"},
        {"Geneva Identification System", "GEN# +1.00159243"},
        {"Smithsonian Astrophysical Observation", "SAO 122503"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.33990687),
        dec: Angle.Degrees(+05.70067865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162028"},
        {"Hipparcos Number", "HIP 87184"},
        {"Geneva Identification System", "GEN# +3.46650105"},
        {"Smithsonian Astrophysical Observation", "SAO 122776"},
        {"Wilson Evans Batten Catalogue", "WEB 14709"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.18073388),
        dec: Angle.Degrees(+05.70127741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148129"},
        {"Hipparcos Number", "HIP 80492"},
        {"Geneva Identification System", "GEN# +1.00148129"},
        {"Smithsonian Astrophysical Observation", "SAO 121590"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.46159949),
        dec: Angle.Degrees(+05.70198085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215075"},
        {"Hipparcos Number", "HIP 112118"},
        {"Smithsonian Astrophysical Observation", "SAO 127702"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.65526266),
        dec: Angle.Degrees(+05.70253773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104623"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.90187054),
        dec: Angle.Degrees(+05.70280370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188386"},
        {"Hipparcos Number", "HIP 97984"},
        {"Smithsonian Astrophysical Observation", "SAO 125223"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.69906718),
        dec: Angle.Degrees(+05.70284445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33588"},
        {"Hipparcos Number", "HIP 24180"},
        {"Smithsonian Astrophysical Observation", "SAO 112502"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87905825),
        dec: Angle.Degrees(+05.70355036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73262"},
        {"Hipparcos Number", "HIP 42313"},
        {"Fundamental Katalog 5th Edition", "FK5 1223"},
        {"Geneva Identification System", "GEN# +1.00073262"},
        {"Smithsonian Astrophysical Observation", "SAO 116965"},
        {"Wilson Evans Batten Catalogue", "WEB 8133"},
    },
    visualMagnitude: 4.14,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41419739),
        dec: Angle.Degrees(+05.70379868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122083"},
        {"Hipparcos Number", "HIP 68345"},
        {"Smithsonian Astrophysical Observation", "SAO 120208"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.85754179),
        dec: Angle.Degrees(+05.70421279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163311"},
        {"Hipparcos Number", "HIP 87735"},
        {"Smithsonian Astrophysical Observation", "SAO 122916"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.82033941),
        dec: Angle.Degrees(+05.70429160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9560"},
        {"Cincinnati Publication", "Ci 20 141"},
        {"Geneva Identification System", "GEN# +9.80003036"},
    },
    visualMagnitude: 12.26,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.71160752),
        dec: Angle.Degrees(+05.70754051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2338.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -704.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142682"},
        {"Hipparcos Number", "HIP 78000"},
        {"Smithsonian Astrophysical Observation", "SAO 121267"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92201574),
        dec: Angle.Degrees(+05.70868044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116868"},
        {"Hipparcos Number", "HIP 65555"},
        {"Smithsonian Astrophysical Observation", "SAO 119924"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.60674367),
        dec: Angle.Degrees(+05.70870771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164162"},
        {"Hipparcos Number", "HIP 88110"},
        {"Smithsonian Astrophysical Observation", "SAO 122995"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.92389387),
        dec: Angle.Degrees(+05.70914486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42255"},
        {"Hipparcos Number", "HIP 29244"},
        {"Smithsonian Astrophysical Observation", "SAO 113532"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.48757187),
        dec: Angle.Degrees(+05.70953416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109071"},
        {"Hipparcos Number", "HIP 61149"},
        {"Smithsonian Astrophysical Observation", "SAO 119455"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.96286090),
        dec: Angle.Degrees(+05.70992904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52810"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.94747682),
        dec: Angle.Degrees(+05.71074770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1938"},
        {"Smithsonian Astrophysical Observation", "SAO 109183"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.11645914),
        dec: Angle.Degrees(+05.71196446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22255"},
        {"Hipparcos Number", "HIP 16723"},
        {"Geneva Identification System", "GEN# +1.00022255"},
        {"Smithsonian Astrophysical Observation", "SAO 111275"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.79230644),
        dec: Angle.Degrees(+05.71409597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161261"},
        {"Hipparcos Number", "HIP 86805"},
        {"Geneva Identification System", "GEN# +3.46650032"},
        {"Smithsonian Astrophysical Observation", "SAO 122687"},
        {"Wilson Evans Batten Catalogue", "WEB 14640"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06556821),
        dec: Angle.Degrees(+05.71432403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18953"},
        {"Smithsonian Astrophysical Observation", "SAO 111583"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.92994736),
        dec: Angle.Degrees(+05.71662375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75301"},
        {"Hipparcos Number", "HIP 43306"},
        {"Geneva Identification System", "GEN# +1.00075301"},
        {"Smithsonian Astrophysical Observation", "SAO 117165"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34092604),
        dec: Angle.Degrees(+05.71741271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147189"},
        {"Hipparcos Number", "HIP 80030"},
        {"Smithsonian Astrophysical Observation", "SAO 121512"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.04651495),
        dec: Angle.Degrees(+05.71742654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72360"},
        {"Hipparcos Number", "HIP 41898"},
        {"Smithsonian Astrophysical Observation", "SAO 116874"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.15477328),
        dec: Angle.Degrees(+05.71754231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27269"},
        {"Hipparcos Number", "HIP 20104"},
        {"Geneva Identification System", "GEN# +1.00027269"},
        {"Smithsonian Astrophysical Observation", "SAO 111734"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.64403029),
        dec: Angle.Degrees(+05.71787679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13410"},
        {"Geneva Identification System", "GEN# +0.00500405"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.16624567),
        dec: Angle.Degrees(+05.71800653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47130"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.05394526),
        dec: Angle.Degrees(+05.71803293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113782"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63647899),
        dec: Angle.Degrees(+05.71832255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196727"},
        {"Hipparcos Number", "HIP 101907"},
        {"Smithsonian Astrophysical Observation", "SAO 126057"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.76817028),
        dec: Angle.Degrees(+05.72433557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16739"},
    },
    visualMagnitude: 12.16,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.83001749),
        dec: Angle.Degrees(+05.72537887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53817"},
        {"Smithsonian Astrophysical Observation", "SAO 118611"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15920449),
        dec: Angle.Degrees(+05.72769218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212031"},
        {"Hipparcos Number", "HIP 110370"},
        {"Smithsonian Astrophysical Observation", "SAO 127469"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.32679710),
        dec: Angle.Degrees(+05.72849843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150014"},
        {"Hipparcos Number", "HIP 81452"},
        {"Smithsonian Astrophysical Observation", "SAO 121749"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.54356657),
        dec: Angle.Degrees(+05.73152325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7864 AB"},
        {"Henry Draper", "HD 92184"},
        {"Hipparcos Number", "HIP 52097"},
        {"Smithsonian Astrophysical Observation", "SAO 118410"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.67983201),
        dec: Angle.Degrees(+05.73400063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220934"},
        {"Hipparcos Number", "HIP 115817"},
        {"Smithsonian Astrophysical Observation", "SAO 128195"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.94155317),
        dec: Angle.Degrees(+05.73657727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173158"},
        {"Hipparcos Number", "HIP 91870"},
        {"Smithsonian Astrophysical Observation", "SAO 123856"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.93877217),
        dec: Angle.Degrees(+05.73740894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41501"},
        {"Hipparcos Number", "HIP 28882"},
        {"Celescope Catalog", "CEL 1074"},
        {"Geneva Identification System", "GEN# +1.00041501"},
        {"Smithsonian Astrophysical Observation", "SAO 113442"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.46908233),
        dec: Angle.Degrees(+05.73793343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190073"},
        {"Hipparcos Number", "HIP 98719"},
        {"Geneva Identification System", "GEN# +1.00190073"},
        {"Renson", "Renson 52740"},
        {"Smithsonian Astrophysical Observation", "SAO 125381"},
        {"Wilson Evans Batten Catalogue", "WEB 17484"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.76045614),
        dec: Angle.Degrees(+05.73798474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219101"},
        {"Hipparcos Number", "HIP 114627"},
        {"Smithsonian Astrophysical Observation", "SAO 128040"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31357254),
        dec: Angle.Degrees(+05.73878480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24900"},
        {"Hipparcos Number", "HIP 18528"},
        {"Smithsonian Astrophysical Observation", "SAO 111524"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.43571783),
        dec: Angle.Degrees(+05.73885395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99225"},
        {"Hipparcos Number", "HIP 55733"},
        {"Smithsonian Astrophysical Observation", "SAO 118838"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.29681682),
        dec: Angle.Degrees(+05.73949536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44213"},
        {"Hipparcos Number", "HIP 30162"},
        {"Geneva Identification System", "GEN# +1.00044213"},
        {"Smithsonian Astrophysical Observation", "SAO 113741"},
        {"Wilson Evans Batten Catalogue", "WEB 5999"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.20139441),
        dec: Angle.Degrees(+05.74060401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44214"},
        {"Hipparcos Number", "HIP 30164"},
        {"Smithsonian Astrophysical Observation", "SAO 113743"},
        {"Wilson Evans Batten Catalogue", "WEB 6000"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.20833012),
        dec: Angle.Degrees(+05.74483162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10609"},
        {"Hipparcos Number", "HIP 8064"},
        {"Smithsonian Astrophysical Observation", "SAO 110088"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.91046322),
        dec: Angle.Degrees(+05.74549241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99304"},
        {"Hipparcos Number", "HIP 55778"},
        {"Smithsonian Astrophysical Observation", "SAO 118848"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.42879259),
        dec: Angle.Degrees(+05.74796017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88802"},
        {"Hipparcos Number", "HIP 50190"},
        {"Smithsonian Astrophysical Observation", "SAO 118181"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.68095336),
        dec: Angle.Degrees(+05.74950357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170782"},
        {"Hipparcos Number", "HIP 90755"},
        {"Geneva Identification System", "GEN# +1.00170782"},
        {"Smithsonian Astrophysical Observation", "SAO 123593"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.75607855),
        dec: Angle.Degrees(+05.75252627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15299"},
        {"Smithsonian Astrophysical Observation", "SAO 111102"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.34340834),
        dec: Angle.Degrees(+05.75305227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167946"},
        {"Hipparcos Number", "HIP 89612"},
        {"Smithsonian Astrophysical Observation", "SAO 123325"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.30988992),
        dec: Angle.Degrees(+05.75362260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109049"},
        {"Geneva Identification System", "GEN# +9.80018027"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.36739727),
        dec: Angle.Degrees(+05.75464934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265312"},
        {"Hipparcos Number", "HIP 32933"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.91820809),
        dec: Angle.Degrees(+05.75499728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113244"},
        {"Geneva Identification System", "GEN# +9.80028024"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.98587767),
        dec: Angle.Degrees(+05.75574999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 356.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34162"},
        {"Hipparcos Number", "HIP 24515"},
        {"Geneva Identification System", "GEN# +1.00034162"},
        {"Renson", "Renson 8700"},
        {"Smithsonian Astrophysical Observation", "SAO 112573"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.88032960),
        dec: Angle.Degrees(+05.75975385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103396"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.21563973),
        dec: Angle.Degrees(+05.75984905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170201"},
        {"Hipparcos Number", "HIP 90500"},
        {"Smithsonian Astrophysical Observation", "SAO 123519"},
        {"New General Catalogue", "NGC 6633 107"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.01321105),
        dec: Angle.Degrees(+05.76021279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1521"},
        {"Hipparcos Number", "HIP 1566"},
        {"Smithsonian Astrophysical Observation", "SAO 109139"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.87168832),
        dec: Angle.Degrees(+05.76039023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17095"},
        {"Hipparcos Number", "HIP 12813"},
        {"Smithsonian Astrophysical Observation", "SAO 110721"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.17745499),
        dec: Angle.Degrees(+05.76088303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28715"},
        {"Hipparcos Number", "HIP 21135"},
        {"Smithsonian Astrophysical Observation", "SAO 111876"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.96016414),
        dec: Angle.Degrees(+05.76449602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96955"},
        {"Hipparcos Number", "HIP 54563"},
        {"Geneva Identification System", "GEN# +1.00096955"},
        {"Smithsonian Astrophysical Observation", "SAO 118695"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47369401),
        dec: Angle.Degrees(+05.76477409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6913 A"},
        {"Henry Draper", "HD 73668"},
        {"Henry Draper 2", "HD 73668A"},
        {"Hipparcos Number", "HIP 42488"},
        {"Geneva Identification System", "GEN# +1.00073668A"},
        {"Smithsonian Astrophysical Observation", "SAO 117000"},
        {"Wilson Evans Batten Catalogue", "WEB 8176"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.93206875),
        dec: Angle.Degrees(+05.76499958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6121"},
        {"Hipparcos Number", "HIP 4865"},
        {"Geneva Identification System", "GEN# +1.00006121"},
        {"Smithsonian Astrophysical Observation", "SAO 109620"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.64179621),
        dec: Angle.Degrees(+05.76502566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63691"},
        {"Hipparcos Number", "HIP 38265"},
        {"Smithsonian Astrophysical Observation", "SAO 116003"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.59470853),
        dec: Angle.Degrees(+05.76520838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15467"},
        {"Hipparcos Number", "HIP 11599"},
        {"Smithsonian Astrophysical Observation", "SAO 110564"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.38432428),
        dec: Angle.Degrees(+05.76726242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33865"},
        {"Hipparcos Number", "HIP 24351"},
        {"Geneva Identification System", "GEN# +1.00033865"},
        {"Smithsonian Astrophysical Observation", "SAO 112533"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38278015),
        dec: Angle.Degrees(+05.76824164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101165"},
        {"Hipparcos Number", "HIP 56795"},
        {"Geneva Identification System", "GEN# +1.00101165"},
        {"Smithsonian Astrophysical Observation", "SAO 118967"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.65448660),
        dec: Angle.Degrees(+05.76865833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183936"},
        {"Hipparcos Number", "HIP 96047"},
        {"Geneva Identification System", "GEN# +1.00183936"},
        {"Smithsonian Astrophysical Observation", "SAO 124732"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.93002534),
        dec: Angle.Degrees(+05.76904741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57616"},
        {"Smithsonian Astrophysical Observation", "SAO 119060"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.20603908),
        dec: Angle.Degrees(+05.76910389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5162 A"},
        {"Henry Draper", "HD 46105"},
        {"Hipparcos Number", "HIP 31110"},
        {"Celescope Catalog", "CEL 1279"},
        {"Geneva Identification System", "GEN# +1.00046105A"},
        {"Renson", "Renson 12340"},
        {"Smithsonian Astrophysical Observation", "SAO 114003"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.91890454),
        dec: Angle.Degrees(+05.76912015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5162 B"},
        {"Hipparcos Number", "HIP 31109"},
        {"Smithsonian Astrophysical Observation", "SAO 114002"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.91572086),
        dec: Angle.Degrees(+05.76943140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29389"},
        {"Hipparcos Number", "HIP 21572"},
        {"Smithsonian Astrophysical Observation", "SAO 111941"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.47457694),
        dec: Angle.Degrees(+05.77034406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6913 B"},
        {"Hipparcos Number", "HIP 42491"},
        {"Geneva Identification System", "GEN# +0.00602008"},
        {"Geneva Identification System 2", "GEN# +1.00073668B"},
        {"Smithsonian Astrophysical Observation", "SAO 117001"},
        {"Wilson Evans Batten Catalogue", "WEB 8179"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.93575504),
        dec: Angle.Degrees(+05.77126662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15157 A"},
        {"Henry Draper", "HD 205924"},
        {"Hipparcos Number", "HIP 106856"},
        {"Geneva Identification System", "GEN# +1.00205924"},
        {"Renson", "Renson 57330"},
        {"Smithsonian Astrophysical Observation", "SAO 126956"},
        {"Wilson Evans Batten Catalogue", "WEB 19314"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.63280732),
        dec: Angle.Degrees(+05.77167281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180641"},
        {"Hipparcos Number", "HIP 94778"},
        {"Smithsonian Astrophysical Observation", "SAO 124463"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.27214328),
        dec: Angle.Degrees(+05.77198638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161677"},
        {"Hipparcos Number", "HIP 87002"},
        {"Geneva Identification System", "GEN# +3.46650073"},
        {"Smithsonian Astrophysical Observation", "SAO 122735"},
        {"Wilson Evans Batten Catalogue", "WEB 14677"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67101035),
        dec: Angle.Degrees(+05.77429430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210985"},
        {"Hipparcos Number", "HIP 109771"},
        {"Geneva Identification System", "GEN# +1.00210985"},
        {"Smithsonian Astrophysical Observation", "SAO 127393"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.51134278),
        dec: Angle.Degrees(+05.77494677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
