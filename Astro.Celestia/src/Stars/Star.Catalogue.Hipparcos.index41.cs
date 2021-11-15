using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_41() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214828"},
        {"Hipparcos Number", "HIP 111996"},
        {"Smithsonian Astrophysical Observation", "SAO 191325"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.27945649),
        dec: Angle.Degrees(-24.23775207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107661"},
        {"Hipparcos Number", "HIP 60349"},
        {"Smithsonian Astrophysical Observation", "SAO 180733"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.61088030),
        dec: Angle.Degrees(-24.23655453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48427"},
        {"Hipparcos Number", "HIP 32102"},
        {"Smithsonian Astrophysical Observation", "SAO 172193"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.59745724),
        dec: Angle.Degrees(-24.23427527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11888"},
        {"Hipparcos Number", "HIP 9031"},
        {"Smithsonian Astrophysical Observation", "SAO 167413"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.07747617),
        dec: Angle.Degrees(-24.23359119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53139"},
        {"Hipparcos Number", "HIP 33978"},
        {"Smithsonian Astrophysical Observation", "SAO 172840"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.75770524),
        dec: Angle.Degrees(-24.23276062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30656"},
        {"Hipparcos Number", "HIP 22342"},
        {"Smithsonian Astrophysical Observation", "SAO 169785"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16247199),
        dec: Angle.Degrees(-24.23210639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61671"},
        {"Hipparcos Number", "HIP 37302"},
        {"Smithsonian Astrophysical Observation", "SAO 174218"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.87205838),
        dec: Angle.Degrees(-24.22985208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83260"},
        {"Hipparcos Number", "HIP 47154"},
        {"Geneva Identification System", "GEN# +1.00083260"},
        {"Smithsonian Astrophysical Observation", "SAO 177732"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.12963915),
        dec: Angle.Degrees(-24.22964034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223884"},
        {"Hipparcos Number", "HIP 117797"},
        {"Geneva Identification System", "GEN# +1.00223884"},
        {"Smithsonian Astrophysical Observation", "SAO 192218"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.33671573),
        dec: Angle.Degrees(-24.22922404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196430"},
        {"Hipparcos Number", "HIP 101823"},
        {"Smithsonian Astrophysical Observation", "SAO 189509"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.52024700),
        dec: Angle.Degrees(-24.22883896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119321"},
        {"Hipparcos Number", "HIP 66934"},
        {"Smithsonian Astrophysical Observation", "SAO 181892"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.75558018),
        dec: Angle.Degrees(-24.22765770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38683"},
        {"Geneva Identification System", "GEN# +2.24820030"},
        {"New General Catalogue", "NGC 2482 30"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.79943876),
        dec: Angle.Degrees(-24.22739609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191579"},
        {"Hipparcos Number", "HIP 99493"},
        {"Fundamental Katalog 5th Edition", "FK5 5777"},
        {"Smithsonian Astrophysical Observation", "SAO 189001"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.86954439),
        dec: Angle.Degrees(-24.22683163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55693"},
        {"Hipparcos Number", "HIP 34879"},
        {"Geneva Identification System", "GEN# +1.00055693"},
        {"Smithsonian Astrophysical Observation", "SAO 173219"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.26138625),
        dec: Angle.Degrees(-24.22582478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63721"},
        {"Hipparcos Number", "HIP 38178"},
        {"Geneva Identification System", "GEN# +1.00063721"},
        {"Smithsonian Astrophysical Observation", "SAO 174606"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.35222978),
        dec: Angle.Degrees(-24.22395056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146437"},
        {"Hipparcos Number", "HIP 79806"},
        {"Geneva Identification System", "GEN# +1.00146437"},
        {"Smithsonian Astrophysical Observation", "SAO 184287"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.31611045),
        dec: Angle.Degrees(-24.22321897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171237"},
        {"Hipparcos Number", "HIP 91066"},
        {"Geneva Identification System", "GEN# +1.00171237"},
        {"Smithsonian Astrophysical Observation", "SAO 186995"},
        {"Wilson Evans Batten Catalogue", "WEB 15626"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.63650484),
        dec: Angle.Degrees(-24.22238928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46624"},
        {"Hipparcos Number", "HIP 31273"},
        {"Smithsonian Astrophysical Observation", "SAO 171942"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36939097),
        dec: Angle.Degrees(-24.22213771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130624"},
        {"Hipparcos Number", "HIP 72548"},
        {"Smithsonian Astrophysical Observation", "SAO 182906"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.48198327),
        dec: Angle.Degrees(-24.21992735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181948"},
        {"Hipparcos Number", "HIP 95308"},
        {"Smithsonian Astrophysical Observation", "SAO 188057"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.84985917),
        dec: Angle.Degrees(-24.21808452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111563"},
        {"Hipparcos Number", "HIP 62659"},
        {"Geneva Identification System", "GEN# +1.00111563"},
        {"Smithsonian Astrophysical Observation", "SAO 181143"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58354738),
        dec: Angle.Degrees(-24.21758308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4507"},
        {"Hipparcos Number", "HIP 3672"},
        {"Geneva Identification System", "GEN# +1.00004507"},
        {"Renson", "Renson 1225"},
        {"Smithsonian Astrophysical Observation", "SAO 166568"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.74927991),
        dec: Angle.Degrees(-24.21663677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115135"},
        {"Geneva Identification System", "GEN# -0.02417594"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.82154725),
        dec: Angle.Degrees(-24.21630254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101908"},
        {"Hipparcos Number", "HIP 57187"},
        {"Smithsonian Astrophysical Observation", "SAO 180136"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90153036),
        dec: Angle.Degrees(-24.21575444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162602"},
        {"Hipparcos Number", "HIP 87527"},
        {"Smithsonian Astrophysical Observation", "SAO 185883"},
    },
    visualMagnitude: 8.69,
    bvColour: 2.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.22945537),
        dec: Angle.Degrees(-24.21506943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198714"},
        {"Hipparcos Number", "HIP 103065"},
        {"Smithsonian Astrophysical Observation", "SAO 189798"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.22494461),
        dec: Angle.Degrees(-24.21462210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9261 AB"},
        {"Henry Draper", "HD 126473"},
        {"Hipparcos Number", "HIP 70584"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.57656409),
        dec: Angle.Degrees(-24.21223946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74314"},
        {"Hipparcos Number", "HIP 42736"},
        {"Smithsonian Astrophysical Observation", "SAO 176338"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.63815075),
        dec: Angle.Degrees(-24.21183111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181241"},
        {"Hipparcos Number", "HIP 95083"},
        {"Smithsonian Astrophysical Observation", "SAO 187993"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17116069),
        dec: Angle.Degrees(-24.21008068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124610"},
        {"Hipparcos Number", "HIP 69637"},
        {"Smithsonian Astrophysical Observation", "SAO 182378"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.78442075),
        dec: Angle.Degrees(-24.20976839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11596"},
        {"Hipparcos Number", "HIP 8818"},
        {"Smithsonian Astrophysical Observation", "SAO 167378"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.33909764),
        dec: Angle.Degrees(-24.20832885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50779"},
        {"Smithsonian Astrophysical Observation", "SAO 178738"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53645214),
        dec: Angle.Degrees(-24.20807412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162030"},
        {"Hipparcos Number", "HIP 87273"},
        {"Smithsonian Astrophysical Observation", "SAO 185815"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48952778),
        dec: Angle.Degrees(-24.20696815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19317"},
        {"Hipparcos Number", "HIP 14396"},
        {"Smithsonian Astrophysical Observation", "SAO 168295"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.42562218),
        dec: Angle.Degrees(-24.20618452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26903"},
        {"Hipparcos Number", "HIP 19760"},
        {"Geneva Identification System", "GEN# +1.00026903"},
        {"Smithsonian Astrophysical Observation", "SAO 169249"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.54943444),
        dec: Angle.Degrees(-24.20520816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201185"},
        {"Hipparcos Number", "HIP 104362"},
        {"Smithsonian Astrophysical Observation", "SAO 190049"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.13341681),
        dec: Angle.Degrees(-24.20515810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109142"},
        {"Hipparcos Number", "HIP 61214"},
        {"Renson", "Renson 31656"},
        {"Smithsonian Astrophysical Observation", "SAO 180881"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.15533246),
        dec: Angle.Degrees(-24.20088144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57866"},
        {"Hipparcos Number", "HIP 35722"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54423310),
        dec: Angle.Degrees(-24.19864606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221257"},
        {"Hipparcos Number", "HIP 116033"},
        {"Fundamental Katalog 5th Edition", "FK5 6079"},
        {"Geneva Identification System", "GEN# +1.00221257"},
        {"Smithsonian Astrophysical Observation", "SAO 191958"},
        {"Wilson Evans Batten Catalogue", "WEB 20516"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66712140),
        dec: Angle.Degrees(-24.19614056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9039"},
        {"Hipparcos Number", "HIP 6881"},
        {"Smithsonian Astrophysical Observation", "SAO 167074"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.15467138),
        dec: Angle.Degrees(-24.19575966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41698"},
        {"Hipparcos Number", "HIP 28874"},
        {"Geneva Identification System", "GEN# +1.00041698"},
        {"Smithsonian Astrophysical Observation", "SAO 171222"},
        {"Wilson Evans Batten Catalogue", "WEB 5648"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.43976547),
        dec: Angle.Degrees(-24.19551808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223574"},
        {"Hipparcos Number", "HIP 117580"},
        {"Smithsonian Astrophysical Observation", "SAO 192198"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.67701224),
        dec: Angle.Degrees(-24.19419045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133843"},
        {"Hipparcos Number", "HIP 73992"},
        {"Geneva Identification System", "GEN# +1.00133843"},
        {"Smithsonian Astrophysical Observation", "SAO 183193"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.81876040),
        dec: Angle.Degrees(-24.19390202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82977"},
        {"Hipparcos Number", "HIP 47002"},
        {"Smithsonian Astrophysical Observation", "SAO 177692"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.69225250),
        dec: Angle.Degrees(-24.19227692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53359"},
        {"Smithsonian Astrophysical Observation", "SAO 179329"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68271828),
        dec: Angle.Degrees(-24.19131451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77999"},
        {"Hipparcos Number", "HIP 44591"},
        {"Geneva Identification System", "GEN# +1.00077999"},
        {"Smithsonian Astrophysical Observation", "SAO 176923"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.26959997),
        dec: Angle.Degrees(-24.18995046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98764"},
        {"Hipparcos Number", "HIP 55487"},
        {"Geneva Identification System", "GEN# +1.00098764"},
        {"Smithsonian Astrophysical Observation", "SAO 179808"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.45755615),
        dec: Angle.Degrees(-24.18968544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17876"},
        {"Hipparcos Number", "HIP 13331"},
        {"Smithsonian Astrophysical Observation", "SAO 168101"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.89816125),
        dec: Angle.Degrees(-24.18771167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207585"},
        {"Hipparcos Number", "HIP 107818"},
        {"Geneva Identification System", "GEN# +1.00207585"},
        {"Smithsonian Astrophysical Observation", "SAO 190676"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.64459445),
        dec: Angle.Degrees(-24.18648878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189418"},
        {"Hipparcos Number", "HIP 98514"},
        {"Smithsonian Astrophysical Observation", "SAO 188813"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.20885503),
        dec: Angle.Degrees(-24.18532232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178812"},
        {"Hipparcos Number", "HIP 94238"},
        {"Smithsonian Astrophysical Observation", "SAO 187779"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.74925542),
        dec: Angle.Degrees(-24.18485869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3709"},
        {"Hipparcos Number", "HIP 3123"},
        {"Smithsonian Astrophysical Observation", "SAO 166463"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93300987),
        dec: Angle.Degrees(-24.18471175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50877"},
        {"Hipparcos Number", "HIP 33152"},
        {"Geneva Identification System", "GEN# +5.11210001"},
        {"Smithsonian Astrophysical Observation", "SAO 172542"},
        {"Wilson Evans Batten Catalogue", "WEB 6668"},
    },
    visualMagnitude: 3.89,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53314518),
        dec: Angle.Degrees(-24.18422296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49051"},
        {"Hipparcos Number", "HIP 32391"},
        {"Smithsonian Astrophysical Observation", "SAO 172284"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.40705935),
        dec: Angle.Degrees(-24.18366504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152213"},
        {"Hipparcos Number", "HIP 82585"},
        {"Smithsonian Astrophysical Observation", "SAO 184745"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.23852286),
        dec: Angle.Degrees(-24.18054994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51501",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7809 AB"},
        {"Hipparcos Number", "HIP 51501"},
        {"Renson", "Renson 26215"},
        {"Smithsonian Astrophysical Observation", "SAO 178922"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.77069991),
        dec: Angle.Degrees(-24.17979303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8809 A"},
        {"Henry Draper", "HD 114432A"},
        {"Henry Draper 2", "HD 114432"},
        {"Hipparcos Number", "HIP 64303"},
        {"Smithsonian Astrophysical Observation", "SAO 181436"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.69504304),
        dec: Angle.Degrees(-24.17917086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94645",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gumala"},
        {"Henry Draper", "HD 179949"},
        {"Hipparcos Number", "HIP 94645"},
        {"Geneva Identification System", "GEN# +1.00179949"},
        {"Smithsonian Astrophysical Observation", "SAO 187883"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88814331),
        dec: Angle.Degrees(-24.17910471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185276"},
        {"Hipparcos Number", "HIP 96674"},
        {"Geneva Identification System", "GEN# +1.00185276"},
        {"Smithsonian Astrophysical Observation", "SAO 188394"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.81270490),
        dec: Angle.Degrees(-24.17827853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9540"},
        {"Hipparcos Number", "HIP 7235"},
        {"Cincinnati Publication", "Ci 18 209"},
        {"Geneva Identification System", "GEN# +1.00009540A"},
        {"Smithsonian Astrophysical Observation", "SAO 167134"},
        {"Wilson Evans Batten Catalogue", "WEB 1555"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31514505),
        dec: Angle.Degrees(-24.17757411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8104"},
        {"Hipparcos Number", "HIP 6244"},
        {"Geneva Identification System", "GEN# +1.00008104"},
        {"Smithsonian Astrophysical Observation", "SAO 166968"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.02398585),
        dec: Angle.Degrees(-24.17735841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157792"},
        {"Hipparcos Number", "HIP 85340"},
        {"Fundamental Katalog 5th Edition", "FK5 1457"},
        {"Geneva Identification System", "GEN# +1.00157792"},
        {"Renson", "Renson 44360"},
        {"Smithsonian Astrophysical Observation", "SAO 185401"},
        {"Wilson Evans Batten Catalogue", "WEB 14412"},
    },
    visualMagnitude: 4.16,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.59257241),
        dec: Angle.Degrees(-24.17502346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68594"},
        {"Hipparcos Number", "HIP 40176"},
        {"Smithsonian Astrophysical Observation", "SAO 175375"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.07315781),
        dec: Angle.Degrees(-24.17485964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14589"},
    },
    visualMagnitude: 10.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10218246),
        dec: Angle.Degrees(-24.17280917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87637"},
        {"Hipparcos Number", "HIP 49446"},
        {"Smithsonian Astrophysical Observation", "SAO 178395"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.42114764),
        dec: Angle.Degrees(-24.17109234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99585"},
        {"Hipparcos Number", "HIP 55892"},
        {"Smithsonian Astrophysical Observation", "SAO 179898"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.83770297),
        dec: Angle.Degrees(-24.16971444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59279"},
        {"Hipparcos Number", "HIP 36300"},
        {"Celescope Catalog", "CEL 1872"},
        {"Smithsonian Astrophysical Observation", "SAO 173810"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.07959130),
        dec: Angle.Degrees(-24.16945624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224514"},
        {"Hipparcos Number", "HIP 118198"},
        {"Fundamental Katalog 5th Edition", "FK5 6124"},
        {"Geneva Identification System", "GEN# +1.00224514"},
        {"Renson", "Renson 61550"},
        {"Smithsonian Astrophysical Observation", "SAO 192278"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.63026637),
        dec: Angle.Degrees(-24.16937365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147084"},
        {"Hipparcos Number", "HIP 80079"},
        {"Geneva Identification System", "GEN# +1.00147084"},
        {"Smithsonian Astrophysical Observation", "SAO 184329"},
        {"Wilson Evans Batten Catalogue", "WEB 13557"},
    },
    visualMagnitude: 4.55,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.15909758),
        dec: Angle.Degrees(-24.16928427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106204"},
        {"Geneva Identification System", "GEN# -0.02416689"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.67689839),
        dec: Angle.Degrees(-24.16833565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213295"},
        {"Hipparcos Number", "HIP 111133"},
        {"Smithsonian Astrophysical Observation", "SAO 191195"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.70552410),
        dec: Angle.Degrees(-24.16825032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81694"},
        {"Hipparcos Number", "HIP 46313"},
        {"Geneva Identification System", "GEN# +1.00081694"},
        {"Smithsonian Astrophysical Observation", "SAO 177454"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66554394),
        dec: Angle.Degrees(-24.16786890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14593"},
        {"Smithsonian Astrophysical Observation", "SAO 168327"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10699186),
        dec: Angle.Degrees(-24.16718774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50646"},
        {"Hipparcos Number", "HIP 33062"},
        {"Celescope Catalog", "CEL 1419"},
        {"Geneva Identification System", "GEN# +5.11210006"},
        {"Smithsonian Astrophysical Observation", "SAO 172511"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30379978),
        dec: Angle.Degrees(-24.16666641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34817"},
        {"Hipparcos Number", "HIP 24810"},
        {"Smithsonian Astrophysical Observation", "SAO 170307"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.78027009),
        dec: Angle.Degrees(-24.16641288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202057"},
        {"Hipparcos Number", "HIP 104827"},
        {"Smithsonian Astrophysical Observation", "SAO 190151"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.55047672),
        dec: Angle.Degrees(-24.16591651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223490"},
        {"Hipparcos Number", "HIP 117519"},
        {"Smithsonian Astrophysical Observation", "SAO 192183"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.49022263),
        dec: Angle.Degrees(-24.16573457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117720"},
        {"Smithsonian Astrophysical Observation", "SAO 192210"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.12402750),
        dec: Angle.Degrees(-24.16551072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193957"},
        {"Hipparcos Number", "HIP 100593"},
        {"Smithsonian Astrophysical Observation", "SAO 189233"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97297018),
        dec: Angle.Degrees(-24.16511153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194810"},
        {"Hipparcos Number", "HIP 100985"},
        {"Geneva Identification System", "GEN# +1.00194810"},
        {"Smithsonian Astrophysical Observation", "SAO 189321"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.12196818),
        dec: Angle.Degrees(-24.16298183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222485"},
        {"Hipparcos Number", "HIP 116851"},
        {"Geneva Identification System", "GEN# +1.00222485"},
        {"Smithsonian Astrophysical Observation", "SAO 192083"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.27907428),
        dec: Angle.Degrees(-24.16045267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44697",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7185 A"},
        {"Henry Draper", "HD 78257"},
        {"Hipparcos Number", "HIP 44697"},
        {"Geneva Identification System", "GEN# +1.00078257"},
        {"Smithsonian Astrophysical Observation", "SAO 176961"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.62842870),
        dec: Angle.Degrees(-24.15793862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27452"},
        {"Hipparcos Number", "HIP 20126"},
        {"Smithsonian Astrophysical Observation", "SAO 169329"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.72876275),
        dec: Angle.Degrees(-24.15456092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204942"},
        {"Hipparcos Number", "HIP 106368"},
        {"Geneva Identification System", "GEN# +1.00204942"},
        {"Smithsonian Astrophysical Observation", "SAO 190424"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.15439932),
        dec: Angle.Degrees(-24.15426318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11793"},
        {"Hipparcos Number", "HIP 8943"},
        {"Smithsonian Astrophysical Observation", "SAO 167393"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.79866084),
        dec: Angle.Degrees(-24.15376125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77285"},
        {"Hipparcos Number", "HIP 44268"},
        {"Smithsonian Astrophysical Observation", "SAO 176822"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.22231201),
        dec: Angle.Degrees(-24.15366971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216811"},
        {"Hipparcos Number", "HIP 113276"},
        {"Geneva Identification System", "GEN# +1.00216811"},
        {"Smithsonian Astrophysical Observation", "SAO 191507"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.06179933),
        dec: Angle.Degrees(-24.15037708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109722"},
        {"Hipparcos Number", "HIP 61568"},
        {"Smithsonian Astrophysical Observation", "SAO 180953"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.23233470),
        dec: Angle.Degrees(-24.14973476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9092 AB"},
        {"Henry Draper", "HD 122660"},
        {"Hipparcos Number", "HIP 68699"},
    },
    visualMagnitude: 9.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.93706078),
        dec: Angle.Degrees(-24.14779020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225069"},
        {"Hipparcos Number", "HIP 253"},
        {"Geneva Identification System", "GEN# +1.00225069"},
        {"Smithsonian Astrophysical Observation", "SAO 166016"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.78257245),
        dec: Angle.Degrees(-24.14513788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133272"},
        {"Hipparcos Number", "HIP 73737"},
        {"Smithsonian Astrophysical Observation", "SAO 183141"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.09425460),
        dec: Angle.Degrees(-24.14453290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49254"},
        {"Hipparcos Number", "HIP 32471"},
        {"Smithsonian Astrophysical Observation", "SAO 172310"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.65719854),
        dec: Angle.Degrees(-24.14385075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49868"},
        {"Hipparcos Number", "HIP 32729"},
        {"Smithsonian Astrophysical Observation", "SAO 172383"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.40852308),
        dec: Angle.Degrees(-24.14345891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4690"},
        {"Hipparcos Number", "HIP 3794"},
        {"Geneva Identification System", "GEN# +1.00004690"},
        {"Smithsonian Astrophysical Observation", "SAO 166595"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.18482361),
        dec: Angle.Degrees(-24.14318847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158980"},
        {"Hipparcos Number", "HIP 85899"},
        {"Smithsonian Astrophysical Observation", "SAO 185497"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.30179015),
        dec: Angle.Degrees(-24.14293503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5149 AB"},
        {"Henry Draper", "HD 46093"},
        {"Hipparcos Number", "HIP 31005"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.60160134),
        dec: Angle.Degrees(-24.14131324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206548"},
        {"Hipparcos Number", "HIP 107248"},
        {"Smithsonian Astrophysical Observation", "SAO 190577"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.83634450),
        dec: Angle.Degrees(-24.14130706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36347"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21393857),
        dec: Angle.Degrees(-24.14112866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161405"},
        {"Hipparcos Number", "HIP 86970"},
        {"Smithsonian Astrophysical Observation", "SAO 185725"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.60562169),
        dec: Angle.Degrees(-24.14110106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105294"},
        {"Hipparcos Number", "HIP 59127"},
        {"Smithsonian Astrophysical Observation", "SAO 180485"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.87055999),
        dec: Angle.Degrees(-24.14012597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19658"},
        {"Hipparcos Number", "HIP 14642"},
        {"Smithsonian Astrophysical Observation", "SAO 168335"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.30515897),
        dec: Angle.Degrees(-24.13747616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76354"},
        {"Smithsonian Astrophysical Observation", "SAO 183601"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.92277080),
        dec: Angle.Degrees(-24.13686317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 679 A"},
        {"Henry Draper", "HD 4732"},
        {"Hipparcos Number", "HIP 3834"},
        {"Geneva Identification System", "GEN# +1.00004732"},
        {"Smithsonian Astrophysical Observation", "SAO 166602"},
        {"Wilson Evans Batten Catalogue", "WEB 684"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.30791020),
        dec: Angle.Degrees(-24.13652681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2044"},
        {"Henry Draper", "HD 16753"},
        {"Hipparcos Number", "HIP 12466"},
        {"Smithsonian Astrophysical Observation", "SAO 167965"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13118985),
        dec: Angle.Degrees(-24.13540852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2902"},
        {"Hipparcos Number", "HIP 2536"},
        {"Smithsonian Astrophysical Observation", "SAO 166337"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.04559836),
        dec: Angle.Degrees(-24.13280162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23842"},
        {"Smithsonian Astrophysical Observation", "SAO 170090"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89492848),
        dec: Angle.Degrees(-24.13252144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213016"},
        {"Hipparcos Number", "HIP 110966"},
        {"Smithsonian Astrophysical Observation", "SAO 191169"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.23612261),
        dec: Angle.Degrees(-24.13228873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10132 A"},
        {"Henry Draper", "HD 149893"},
        {"Hipparcos Number", "HIP 81485"},
        {"Smithsonian Astrophysical Observation", "SAO 184515"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63991027),
        dec: Angle.Degrees(-24.13200271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80919"},
        {"Hipparcos Number", "HIP 45928"},
        {"Smithsonian Astrophysical Observation", "SAO 177335"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46995013),
        dec: Angle.Degrees(-24.13198823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11887"},
        {"Hipparcos Number", "HIP 9027"},
        {"Smithsonian Astrophysical Observation", "SAO 167411"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.07295414),
        dec: Angle.Degrees(-24.13190316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107043"},
        {"Hipparcos Number", "HIP 60027"},
        {"Smithsonian Astrophysical Observation", "SAO 180670"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.65670580),
        dec: Angle.Degrees(-24.13148796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133627"},
        {"Hipparcos Number", "HIP 73896"},
        {"Geneva Identification System", "GEN# +1.00133627"},
        {"Smithsonian Astrophysical Observation", "SAO 183170"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54433562),
        dec: Angle.Degrees(-24.13129938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129635"},
        {"Hipparcos Number", "HIP 72056"},
        {"Smithsonian Astrophysical Observation", "SAO 182822"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.07391580),
        dec: Angle.Degrees(-24.12875386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1102 AB"},
        {"Henry Draper", "HD 8281"},
        {"Hipparcos Number", "HIP 6367"},
        {"Smithsonian Astrophysical Observation", "SAO 166988"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.44411116),
        dec: Angle.Degrees(-24.12801524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1262"},
        {"Smithsonian Astrophysical Observation", "SAO 166154"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.95932046),
        dec: Angle.Degrees(-24.12304692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20729"},
        {"Hipparcos Number", "HIP 15479"},
        {"Geneva Identification System", "GEN# +1.00020729"},
        {"Smithsonian Astrophysical Observation", "SAO 168462"},
        {"Wilson Evans Batten Catalogue", "WEB 2976"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89542972),
        dec: Angle.Degrees(-24.12284680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215767"},
        {"Hipparcos Number", "HIP 112560"},
        {"Smithsonian Astrophysical Observation", "SAO 191411"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.96115589),
        dec: Angle.Degrees(-24.12162713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83734"},
        {"Smithsonian Astrophysical Observation", "SAO 185032"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.70025993),
        dec: Angle.Degrees(-24.12153932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201725"},
        {"Hipparcos Number", "HIP 104664"},
        {"Fundamental Katalog 5th Edition", "FK5 5871"},
        {"Smithsonian Astrophysical Observation", "SAO 190110"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.01107506),
        dec: Angle.Degrees(-24.12146825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4809"},
        {"Hipparcos Number", "HIP 3898"},
        {"Smithsonian Astrophysical Observation", "SAO 166613"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.50122397),
        dec: Angle.Degrees(-24.11948337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47116"},
        {"Hipparcos Number", "HIP 31532"},
        {"Renson", "Renson 12650"},
        {"Smithsonian Astrophysical Observation", "SAO 172002"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.02108347),
        dec: Angle.Degrees(-24.11878017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131162"},
        {"Hipparcos Number", "HIP 72782"},
        {"Geneva Identification System", "GEN# +1.00131162"},
        {"Smithsonian Astrophysical Observation", "SAO 182951"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.15848158),
        dec: Angle.Degrees(-24.11786398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196800"},
        {"Hipparcos Number", "HIP 102018"},
        {"Geneva Identification System", "GEN# +1.00196800"},
        {"Smithsonian Astrophysical Observation", "SAO 189555"},
        {"Wilson Evans Batten Catalogue", "WEB 18444"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.09257462),
        dec: Angle.Degrees(-24.11731794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50680"},
        {"Hipparcos Number", "HIP 33070"},
        {"Celescope Catalog", "CEL 1421"},
        {"Geneva Identification System", "GEN# +5.11210008"},
        {"Smithsonian Astrophysical Observation", "SAO 172512"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.31439445),
        dec: Angle.Degrees(-24.11656531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113937"},
        {"Smithsonian Astrophysical Observation", "SAO 191625"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.09838260),
        dec: Angle.Degrees(-24.11556175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74035"},
        {"Hipparcos Number", "HIP 42582"},
        {"Smithsonian Astrophysical Observation", "SAO 176278"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18284980),
        dec: Angle.Degrees(-24.11508191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20818"},
        {"Hipparcos Number", "HIP 15561"},
        {"Geneva Identification System", "GEN# +1.00020818"},
        {"Smithsonian Astrophysical Observation", "SAO 168470"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.11608897),
        dec: Angle.Degrees(-24.11455194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50740"},
        {"Hipparcos Number", "HIP 33087"},
        {"Geneva Identification System", "GEN# +5.11210011"},
        {"Smithsonian Astrophysical Observation", "SAO 172519"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.36493638),
        dec: Angle.Degrees(-24.11181089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39240"},
        {"Hipparcos Number", "HIP 27563"},
        {"Smithsonian Astrophysical Observation", "SAO 170898"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.55683080),
        dec: Angle.Degrees(-24.11101370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24290"},
        {"Hipparcos Number", "HIP 18020"},
        {"Renson", "Renson 6257"},
        {"Smithsonian Astrophysical Observation", "SAO 168885"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76475396),
        dec: Angle.Degrees(-24.11052982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28845"},
        {"Hipparcos Number", "HIP 21133"},
        {"Smithsonian Astrophysical Observation", "SAO 169538"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.95176736),
        dec: Angle.Degrees(-24.11021674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170978"},
        {"Hipparcos Number", "HIP 90953"},
        {"Geneva Identification System", "GEN# +1.00170978"},
        {"Smithsonian Astrophysical Observation", "SAO 186959"},
        {"Wilson Evans Batten Catalogue", "WEB 15598"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.31002888),
        dec: Angle.Degrees(-24.10951910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85765"},
        {"Hipparcos Number", "HIP 48505"},
        {"Fundamental Katalog 5th Edition", "FK5 4878"},
        {"Smithsonian Astrophysical Observation", "SAO 178146"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.38079003),
        dec: Angle.Degrees(-24.10881547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61120"},
        {"Hipparcos Number", "HIP 37042"},
        {"Geneva Identification System", "GEN# +1.00061120"},
        {"Smithsonian Astrophysical Observation", "SAO 174115"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.18294469),
        dec: Angle.Degrees(-24.10814273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114606",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16596 A"},
        {"Henry Draper", "HD 219044"},
        {"Hipparcos Number", "HIP 114606"},
        {"Smithsonian Astrophysical Observation", "SAO 191728"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.26572982),
        dec: Angle.Degrees(-24.10572270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15555"},
        {"Hipparcos Number", "HIP 11600"},
        {"Geneva Identification System", "GEN# +1.00015555"},
        {"Smithsonian Astrophysical Observation", "SAO 167829"},
        {"Wilson Evans Batten Catalogue", "WEB 2416"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.39080867),
        dec: Angle.Degrees(-24.10405629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 349.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88551"},
        {"Hipparcos Number", "HIP 49982"},
        {"Smithsonian Astrophysical Observation", "SAO 178530"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.06864992),
        dec: Angle.Degrees(-24.10356129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128872"},
        {"Hipparcos Number", "HIP 71702"},
        {"Smithsonian Astrophysical Observation", "SAO 182749"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.00994484),
        dec: Angle.Degrees(-24.10325837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31669"},
        {"Hipparcos Number", "HIP 22993"},
        {"Smithsonian Astrophysical Observation", "SAO 169910"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.20550480),
        dec: Angle.Degrees(-24.10237980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20632"},
        {"Hipparcos Number", "HIP 15392"},
        {"Fundamental Katalog 5th Edition", "FK5 4303"},
        {"Geneva Identification System", "GEN# +1.00020632"},
        {"Smithsonian Astrophysical Observation", "SAO 168453"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.60725962),
        dec: Angle.Degrees(-24.10181670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21703"},
        {"Hipparcos Number", "HIP 16247"},
        {"Geneva Identification System", "GEN# +1.00021703"},
        {"Smithsonian Astrophysical Observation", "SAO 168581"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.34472201),
        dec: Angle.Degrees(-24.10109865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144018"},
        {"Hipparcos Number", "HIP 78746"},
        {"Wilson Evans Batten Catalogue", "WEB 13316"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.15059165),
        dec: Angle.Degrees(-24.10013317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51962"},
        {"Hipparcos Number", "HIP 33570"},
        {"Smithsonian Astrophysical Observation", "SAO 172664"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.62862319),
        dec: Angle.Degrees(-24.09971010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86226"},
        {"Hipparcos Number", "HIP 48739"},
        {"Geneva Identification System", "GEN# +1.00086226"},
        {"Smithsonian Astrophysical Observation", "SAO 178205"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.12482212),
        dec: Angle.Degrees(-24.09950314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80735"},
        {"Hipparcos Number", "HIP 45848"},
        {"Smithsonian Astrophysical Observation", "SAO 177311"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.21002609),
        dec: Angle.Degrees(-24.09792071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40938"},
        {"Hipparcos Number", "HIP 28505"},
        {"Smithsonian Astrophysical Observation", "SAO 171133"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27042745),
        dec: Angle.Degrees(-24.09524320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183574"},
        {"Hipparcos Number", "HIP 96000"},
        {"Geneva Identification System", "GEN# +1.00183574"},
        {"Smithsonian Astrophysical Observation", "SAO 188229"},
        {"Wilson Evans Batten Catalogue", "WEB 16813"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.79611169),
        dec: Angle.Degrees(-24.09503188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 392"},
        {"Hipparcos Number", "HIP 688"},
        {"Geneva Identification System", "GEN# +1.00000392"},
        {"Smithsonian Astrophysical Observation", "SAO 166073"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.11513383),
        dec: Angle.Degrees(-24.09375148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136821"},
        {"Hipparcos Number", "HIP 75329"},
        {"Smithsonian Astrophysical Observation", "SAO 183426"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.87220957),
        dec: Angle.Degrees(-24.09146518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123540"},
        {"Hipparcos Number", "HIP 69110"},
        {"Smithsonian Astrophysical Observation", "SAO 182283"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.21013274),
        dec: Angle.Degrees(-24.08949628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40173"},
        {"Hipparcos Number", "HIP 28094"},
        {"Smithsonian Astrophysical Observation", "SAO 171037"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.07617351),
        dec: Angle.Degrees(-24.08888870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22800"},
        {"Hipparcos Number", "HIP 17025"},
        {"Geneva Identification System", "GEN# +1.00022800"},
        {"Smithsonian Astrophysical Observation", "SAO 168703"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.74949935),
        dec: Angle.Degrees(-24.08783745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99611"},
        {"Hipparcos Number", "HIP 55898"},
        {"Smithsonian Astrophysical Observation", "SAO 179901"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.87107836),
        dec: Angle.Degrees(-24.08593095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223697"},
        {"Hipparcos Number", "HIP 117671"},
        {"Smithsonian Astrophysical Observation", "SAO 192207"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.96004319),
        dec: Angle.Degrees(-24.08293029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52565"},
        {"Smithsonian Astrophysical Observation", "SAO 179188"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.20383346),
        dec: Angle.Degrees(-24.08215097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3230 AB"},
        {"Henry Draper", "HD 28312"},
        {"Hipparcos Number", "HIP 20765"},
        {"Geneva Identification System", "GEN# +1.00028312J"},
        {"Smithsonian Astrophysical Observation", "SAO 169455"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.73722642),
        dec: Angle.Degrees(-24.08128840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2255"},
        {"Smithsonian Astrophysical Observation", "SAO 166301"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.17791871),
        dec: Angle.Degrees(-24.07848018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5498 AB"},
        {"Henry Draper", "HD 49891"},
        {"Hipparcos Number", "HIP 32744"},
        {"Celescope Catalog", "CEL 1398"},
        {"Geneva Identification System", "GEN# +1.00049891J"},
        {"Smithsonian Astrophysical Observation", "SAO 172389"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.43333940),
        dec: Angle.Degrees(-24.07603332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43804"},
        {"Hipparcos Number", "HIP 29854"},
        {"Geneva Identification System", "GEN# +1.00043804"},
        {"Smithsonian Astrophysical Observation", "SAO 171508"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.30330350),
        dec: Angle.Degrees(-24.07450950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32741",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5498 C"},
        {"Hipparcos Number", "HIP 32741"},
        {"Smithsonian Astrophysical Observation", "SAO 172386"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42434351),
        dec: Angle.Degrees(-24.07424286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59512"},
        {"Smithsonian Astrophysical Observation", "SAO 180559"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.07756820),
        dec: Angle.Degrees(-24.07315604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156365"},
        {"Hipparcos Number", "HIP 84636"},
        {"Geneva Identification System", "GEN# +1.00156365"},
        {"Smithsonian Astrophysical Observation", "SAO 185239"},
        {"Wilson Evans Batten Catalogue", "WEB 14291"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.52946915),
        dec: Angle.Degrees(-24.07284264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159033"},
        {"Hipparcos Number", "HIP 85920"},
        {"Smithsonian Astrophysical Observation", "SAO 185501"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.37122217),
        dec: Angle.Degrees(-24.07146171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195455"},
        {"Hipparcos Number", "HIP 101328"},
        {"Geneva Identification System", "GEN# +1.00195455"},
        {"Smithsonian Astrophysical Observation", "SAO 189402"},
        {"Wilson Evans Batten Catalogue", "WEB 18308"},
    },
    visualMagnitude: 9.21,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.06122696),
        dec: Angle.Degrees(-24.06766234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14177"},
        {"Hipparcos Number", "HIP 10655"},
        {"Geneva Identification System", "GEN# +1.00014177"},
        {"Smithsonian Astrophysical Observation", "SAO 167680"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.28413085),
        dec: Angle.Degrees(-24.06471113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170434"},
        {"Hipparcos Number", "HIP 90705"},
        {"Smithsonian Astrophysical Observation", "SAO 186891"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.60028918),
        dec: Angle.Degrees(-24.06328681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27353"},
        {"Hipparcos Number", "HIP 20060"},
        {"Geneva Identification System", "GEN# +1.00027353"},
        {"Smithsonian Astrophysical Observation", "SAO 169316"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.52676927),
        dec: Angle.Degrees(-24.06030574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203831"},
        {"Hipparcos Number", "HIP 105772"},
        {"Geneva Identification System", "GEN# +1.00203831"},
        {"Smithsonian Astrophysical Observation", "SAO 190315"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.33517287),
        dec: Angle.Degrees(-24.05983398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8514"},
        {"Hipparcos Number", "HIP 6523"},
        {"Smithsonian Astrophysical Observation", "SAO 167014"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.94697287),
        dec: Angle.Degrees(-24.05882849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207950"},
        {"Hipparcos Number", "HIP 108040"},
        {"Smithsonian Astrophysical Observation", "SAO 190710"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.33490664),
        dec: Angle.Degrees(-24.05841106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129008"},
        {"Hipparcos Number", "HIP 71770"},
        {"Geneva Identification System", "GEN# +1.00129008"},
        {"Smithsonian Astrophysical Observation", "SAO 182759"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.21355441),
        dec: Angle.Degrees(-24.05769954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207250"},
        {"Hipparcos Number", "HIP 107641"},
        {"Geneva Identification System", "GEN# +1.00207250"},
        {"Smithsonian Astrophysical Observation", "SAO 190637"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.04529635),
        dec: Angle.Degrees(-24.05540219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155632"},
        {"Hipparcos Number", "HIP 84284"},
        {"Smithsonian Astrophysical Observation", "SAO 185173"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.44162500),
        dec: Angle.Degrees(-24.05220267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8112 A"},
        {"Henry Draper", "HD 98033"},
        {"Hipparcos Number", "HIP 55065"},
        {"Smithsonian Astrophysical Observation", "SAO 179718"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.09200159),
        dec: Angle.Degrees(-24.04739932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17001"},
        {"Geneva Identification System", "GEN# -0.02401782"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.67263931),
        dec: Angle.Degrees(-24.04700118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41260",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6800 A"},
        {"Henry Draper", "HD 71176"},
        {"Hipparcos Number", "HIP 41260"},
        {"Fundamental Katalog 5th Edition", "FK5 1221"},
        {"Geneva Identification System", "GEN# +1.00071176"},
        {"Smithsonian Astrophysical Observation", "SAO 175783"},
        {"Wilson Evans Batten Catalogue", "WEB 7984"},
    },
    visualMagnitude: 5.32,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.26565742),
        dec: Angle.Degrees(-24.04626227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182725"},
        {"Hipparcos Number", "HIP 95623"},
        {"Smithsonian Astrophysical Observation", "SAO 188130"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.74103669),
        dec: Angle.Degrees(-24.04617967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24208"},
        {"Hipparcos Number", "HIP 17958"},
        {"Smithsonian Astrophysical Observation", "SAO 168877"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.58530868),
        dec: Angle.Degrees(-24.04397573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54669"},
        {"Hipparcos Number", "HIP 34489"},
        {"Celescope Catalog", "CEL 1614"},
        {"Geneva Identification System", "GEN# +5.11210032"},
        {"Smithsonian Astrophysical Observation", "SAO 173064"},
        {"Wilson Evans Batten Catalogue", "WEB 6909"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20585434),
        dec: Angle.Degrees(-24.04380025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38944"},
        {"Wilson Evans Batten Catalogue", "WEB 7634"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52142606),
        dec: Angle.Degrees(-24.04177369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57846"},
        {"Hipparcos Number", "HIP 35717"},
        {"Geneva Identification System", "GEN# +1.00057846"},
        {"Renson", "Renson 15775"},
        {"Smithsonian Astrophysical Observation", "SAO 173561"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54141436),
        dec: Angle.Degrees(-24.04092813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29163"},
        {"Hipparcos Number", "HIP 21324"},
        {"Geneva Identification System", "GEN# +1.00029163"},
        {"Smithsonian Astrophysical Observation", "SAO 169581"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65888456),
        dec: Angle.Degrees(-24.04054358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87475"},
        {"Hipparcos Number", "HIP 49369"},
        {"Smithsonian Astrophysical Observation", "SAO 178373"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.17040182),
        dec: Angle.Degrees(-24.02100543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12515"},
        {"Hipparcos Number", "HIP 9497"},
        {"Smithsonian Astrophysical Observation", "SAO 167506"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.54687481),
        dec: Angle.Degrees(-24.03995094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221117"},
        {"Hipparcos Number", "HIP 115941"},
        {"Smithsonian Astrophysical Observation", "SAO 191946"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.35710897),
        dec: Angle.Degrees(-24.03866110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128340"},
        {"Hipparcos Number", "HIP 71470"},
        {"Geneva Identification System", "GEN# +1.00128340"},
        {"Smithsonian Astrophysical Observation", "SAO 182705"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.25169972),
        dec: Angle.Degrees(-24.03851651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95008"},
        {"Hipparcos Number", "HIP 53590"},
        {"Smithsonian Astrophysical Observation", "SAO 179382"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.45479051),
        dec: Angle.Degrees(-24.03802643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4417"},
        {"Geneva Identification System", "GEN# -0.02400407"},
        {"Smithsonian Astrophysical Observation", "SAO 166696"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.15075912),
        dec: Angle.Degrees(-24.03799814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220308"},
        {"Hipparcos Number", "HIP 115430"},
        {"Geneva Identification System", "GEN# +1.00220308"},
        {"Smithsonian Astrophysical Observation", "SAO 191855"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.72890106),
        dec: Angle.Degrees(-24.03512622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24754"},
        {"Hipparcos Number", "HIP 18336"},
        {"Geneva Identification System", "GEN# +1.00024754"},
        {"Smithsonian Astrophysical Observation", "SAO 168950"},
        {"Wilson Evans Batten Catalogue", "WEB 3540"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.80785675),
        dec: Angle.Degrees(-24.03239630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171115"},
        {"Hipparcos Number", "HIP 91004"},
        {"Geneva Identification System", "GEN# +1.00171115"},
        {"Smithsonian Astrophysical Observation", "SAO 186981"},
        {"Wilson Evans Batten Catalogue", "WEB 15614"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.47286565),
        dec: Angle.Degrees(-24.03226534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5186"},
        {"Hipparcos Number", "HIP 4195"},
        {"Geneva Identification System", "GEN# +1.00005186"},
        {"Smithsonian Astrophysical Observation", "SAO 166655"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.39727512),
        dec: Angle.Degrees(-24.02956237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13231"},
        {"Hipparcos Number", "HIP 10002"},
        {"Smithsonian Astrophysical Observation", "SAO 167585"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.20171484),
        dec: Angle.Degrees(-24.02874347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143461"},
        {"Hipparcos Number", "HIP 78482"},
        {"Smithsonian Astrophysical Observation", "SAO 184031"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.32103169),
        dec: Angle.Degrees(-24.02710048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210410"},
        {"Hipparcos Number", "HIP 109476"},
        {"Renson", "Renson 58506"},
        {"Smithsonian Astrophysical Observation", "SAO 190940"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.66682761),
        dec: Angle.Degrees(-24.02597167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10293"},
        {"Smithsonian Astrophysical Observation", "SAO 167633"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.14356276),
        dec: Angle.Degrees(-24.02594986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57281"},
        {"Hipparcos Number", "HIP 35503"},
        {"Celescope Catalog", "CEL 1781"},
        {"Geneva Identification System", "GEN# +1.00057281J"},
        {"Smithsonian Astrophysical Observation", "SAO 173472"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.90621957),
        dec: Angle.Degrees(-24.02437753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213638"},
        {"Hipparcos Number", "HIP 111327"},
        {"Smithsonian Astrophysical Observation", "SAO 191220"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.32893016),
        dec: Angle.Degrees(-24.02185840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59925"},
        {"Smithsonian Astrophysical Observation", "SAO 180653"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.38429668),
        dec: Angle.Degrees(-24.01856775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127643"},
        {"Hipparcos Number", "HIP 71152"},
        {"Geneva Identification System", "GEN# +1.00127643"},
        {"Smithsonian Astrophysical Observation", "SAO 182654"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.28934367),
        dec: Angle.Degrees(-24.01831450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25267"},
        {"Hipparcos Number", "HIP 18673"},
        {"Fundamental Katalog 5th Edition", "FK5 2287"},
        {"Geneva Identification System", "GEN# +1.00025267"},
        {"Renson", "Renson 6440"},
        {"Smithsonian Astrophysical Observation", "SAO 169017"},
        {"Wilson Evans Batten Catalogue", "WEB 3597"},
    },
    visualMagnitude: 4.62,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.98115045),
        dec: Angle.Degrees(-24.01625677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10909"},
        {"Hipparcos Number", "HIP 8281"},
        {"Smithsonian Astrophysical Observation", "SAO 167287"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.67312863),
        dec: Angle.Degrees(-24.01420928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155029"},
        {"Hipparcos Number", "HIP 83981"},
        {"Geneva Identification System", "GEN# +1.00155029"},
        {"Smithsonian Astrophysical Observation", "SAO 185098"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.51865457),
        dec: Angle.Degrees(-24.01369144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106955"},
        {"Hipparcos Number", "HIP 59966"},
        {"Fundamental Katalog 5th Edition", "FK5 5086"},
        {"Geneva Identification System", "GEN# +1.00106955"},
        {"Smithsonian Astrophysical Observation", "SAO 180662"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.48138890),
        dec: Angle.Degrees(-24.01341066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18862"},
        {"Hipparcos Number", "HIP 14072"},
        {"Smithsonian Astrophysical Observation", "SAO 168231"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.33323312),
        dec: Angle.Degrees(-24.01289883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3100 AB"},
        {"Henry Draper", "HD 27117"},
        {"Hipparcos Number", "HIP 19889"},
        {"Smithsonian Astrophysical Observation", "SAO 169276"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.99395569),
        dec: Angle.Degrees(-24.00830177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134946"},
        {"Hipparcos Number", "HIP 74490"},
        {"Geneva Identification System", "GEN# +1.00134946"},
        {"Smithsonian Astrophysical Observation", "SAO 183269"},
        {"Wilson Evans Batten Catalogue", "WEB 12708"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.32260826),
        dec: Angle.Degrees(-24.00827351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22736"},
        {"Hipparcos Number", "HIP 16978"},
        {"Geneva Identification System", "GEN# +1.00022736"},
        {"Smithsonian Astrophysical Observation", "SAO 168694"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.59259152),
        dec: Angle.Degrees(-24.00726602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208448"},
        {"Hipparcos Number", "HIP 108325"},
        {"Geneva Identification System", "GEN# +1.00208448"},
        {"Smithsonian Astrophysical Observation", "SAO 190760"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.17915070),
        dec: Angle.Degrees(-24.00668494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 726 A"},
        {"Henry Draper", "HD 5098"},
        {"Hipparcos Number", "HIP 4104"},
        {"Geneva Identification System", "GEN# +1.00005098A"},
        {"Smithsonian Astrophysical Observation", "SAO 166647"},
        {"Wilson Evans Batten Catalogue", "WEB 733"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16917061),
        dec: Angle.Degrees(-24.00592567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211024"},
        {"Hipparcos Number", "HIP 109838"},
        {"Geneva Identification System", "GEN# +1.00211024"},
        {"Smithsonian Astrophysical Observation", "SAO 190995"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69627363),
        dec: Angle.Degrees(-24.00467301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160459"},
        {"Hipparcos Number", "HIP 86533"},
        {"Smithsonian Astrophysical Observation", "SAO 185616"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.25550584),
        dec: Angle.Degrees(-24.00438340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47365"},
        {"Smithsonian Astrophysical Observation", "SAO 177794"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.76029602),
        dec: Angle.Degrees(-24.00395795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141598"},
        {"Hipparcos Number", "HIP 77617"},
        {"Smithsonian Astrophysical Observation", "SAO 183851"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.68450135),
        dec: Angle.Degrees(-24.00268692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115123"},
        {"Hipparcos Number", "HIP 64670"},
        {"Geneva Identification System", "GEN# +1.00115123"},
        {"Smithsonian Astrophysical Observation", "SAO 181487"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.83476763),
        dec: Angle.Degrees(-24.00055822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6668"},
        {"Hipparcos Number", "HIP 5259"},
        {"Geneva Identification System", "GEN# +1.00006668"},
        {"Renson", "Renson 1723"},
        {"Smithsonian Astrophysical Observation", "SAO 166814"},
        {"Wilson Evans Batten Catalogue", "WEB 1109"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80364889),
        dec: Angle.Degrees(-23.99625645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139034"},
        {"Hipparcos Number", "HIP 76430"},
        {"Smithsonian Astrophysical Observation", "SAO 183611"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.14676085),
        dec: Angle.Degrees(-23.99581071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154866"},
        {"Hipparcos Number", "HIP 83911"},
        {"Geneva Identification System", "GEN# +1.00154866"},
        {"Smithsonian Astrophysical Observation", "SAO 185074"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.24052443),
        dec: Angle.Degrees(-23.99360439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6559"},
        {"Hipparcos Number", "HIP 5170"},
        {"Fundamental Katalog 5th Edition", "FK5 1029"},
        {"Geneva Identification System", "GEN# +1.00006559"},
        {"Smithsonian Astrophysical Observation", "SAO 166799"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.53220740),
        dec: Angle.Degrees(-23.99236906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174820"},
        {"Hipparcos Number", "HIP 92709"},
        {"Geneva Identification System", "GEN# +1.00174820"},
        {"Smithsonian Astrophysical Observation", "SAO 187411"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.36013966),
        dec: Angle.Degrees(-23.99147287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213986"},
        {"Hipparcos Number", "HIP 111515"},
        {"Geneva Identification System", "GEN# +1.00213986"},
        {"Smithsonian Astrophysical Observation", "SAO 191246"},
        {"Wilson Evans Batten Catalogue", "WEB 19932"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.90149675),
        dec: Angle.Degrees(-23.99107868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14426"},
        {"Smithsonian Astrophysical Observation", "SAO 168304"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.55941658),
        dec: Angle.Degrees(-23.98883138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162100"},
        {"Hipparcos Number", "HIP 87304"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.58320209),
        dec: Angle.Degrees(-23.98840293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165921"},
        {"Hipparcos Number", "HIP 88943"},
        {"Geneva Identification System", "GEN# +1.00165921"},
        {"Smithsonian Astrophysical Observation", "SAO 186366"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.32374287),
        dec: Angle.Degrees(-23.98839447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95758"},
        {"Hipparcos Number", "HIP 54009"},
        {"Smithsonian Astrophysical Observation", "SAO 179467"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.73008056),
        dec: Angle.Degrees(-23.98744226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153172"},
        {"Hipparcos Number", "HIP 83097"},
        {"Geneva Identification System", "GEN# +1.00153172"},
        {"Smithsonian Astrophysical Observation", "SAO 184864"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.69635363),
        dec: Angle.Degrees(-23.98665474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134329"},
        {"Hipparcos Number", "HIP 74206"},
        {"Smithsonian Astrophysical Observation", "SAO 183231"},
        {"Wilson Evans Batten Catalogue", "WEB 12670"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.46380766),
        dec: Angle.Degrees(-23.98590734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149508"},
        {"Hipparcos Number", "HIP 81297"},
        {"Smithsonian Astrophysical Observation", "SAO 184488"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.07286339),
        dec: Angle.Degrees(-23.98565039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93064"},
        {"Hipparcos Number", "HIP 52536"},
        {"Fundamental Katalog 5th Edition", "FK5 2859"},
        {"Smithsonian Astrophysical Observation", "SAO 179180"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.11716345),
        dec: Angle.Degrees(-23.98546318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194848"},
        {"Hipparcos Number", "HIP 101013"},
        {"Smithsonian Astrophysical Observation", "SAO 189330"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18417677),
        dec: Angle.Degrees(-23.98369029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190158"},
        {"Hipparcos Number", "HIP 98854"},
        {"Geneva Identification System", "GEN# +1.00190158"},
        {"Smithsonian Astrophysical Observation", "SAO 188877"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11361820),
        dec: Angle.Degrees(-23.98265342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126368"},
        {"Hipparcos Number", "HIP 70526"},
        {"Geneva Identification System", "GEN# +1.00126368"},
        {"Smithsonian Astrophysical Observation", "SAO 182533"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.40884120),
        dec: Angle.Degrees(-23.98193971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12205"},
        {"Hipparcos Number", "HIP 9281"},
        {"Smithsonian Astrophysical Observation", "SAO 167460"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.82616685),
        dec: Angle.Degrees(-23.97989604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142184"},
        {"Hipparcos Number", "HIP 77859"},
        {"Celescope Catalog", "CEL 4401"},
        {"Geneva Identification System", "GEN# +1.00142184"},
        {"Smithsonian Astrophysical Observation", "SAO 183901"},
        {"Wilson Evans Batten Catalogue", "WEB 13169"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.48280036),
        dec: Angle.Degrees(-23.97803598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219579"},
        {"Hipparcos Number", "HIP 114964"},
        {"Smithsonian Astrophysical Observation", "SAO 191791"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.27579796),
        dec: Angle.Degrees(-23.97725515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29872"},
        {"Hipparcos Number", "HIP 21825"},
        {"Smithsonian Astrophysical Observation", "SAO 169670"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.37895302),
        dec: Angle.Degrees(-23.97645726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55174",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hunahpu"},
        {"Henry Draper", "HD 98219"},
        {"Hipparcos Number", "HIP 55174"},
        {"Geneva Identification System", "GEN# +1.00098219"},
        {"Smithsonian Astrophysical Observation", "SAO 179747"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.44848539),
        dec: Angle.Degrees(-23.97537472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105328"},
        {"Hipparcos Number", "HIP 59143"},
        {"Geneva Identification System", "GEN# +1.00105328"},
        {"Smithsonian Astrophysical Observation", "SAO 180488"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.91236753),
        dec: Angle.Degrees(-23.97528514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38421"},
        {"Geneva Identification System", "GEN# -0.02306383"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.06377473),
        dec: Angle.Degrees(-23.97447281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151346"},
        {"Hipparcos Number", "HIP 82217"},
        {"Geneva Identification System", "GEN# +1.00151346"},
        {"Renson", "Renson 42810"},
        {"Smithsonian Astrophysical Observation", "SAO 184646"},
        {"Wilson Evans Batten Catalogue", "WEB 13881"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.94390026),
        dec: Angle.Degrees(-23.97426560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131368"},
        {"Hipparcos Number", "HIP 72895"},
        {"Smithsonian Astrophysical Observation", "SAO 182974"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.47203140),
        dec: Angle.Degrees(-23.97422800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13776"},
        {"Hipparcos Number", "HIP 10386"},
        {"Geneva Identification System", "GEN# +1.00013776"},
        {"Renson", "Renson 3550"},
        {"Smithsonian Astrophysical Observation", "SAO 167648"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.44156932),
        dec: Angle.Degrees(-23.97355905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7629"},
        {"Hipparcos Number", "HIP 5907"},
        {"Geneva Identification System", "GEN# +1.00007629"},
        {"Smithsonian Astrophysical Observation", "SAO 166915"},
        {"Wilson Evans Batten Catalogue", "WEB 1341"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.97378555),
        dec: Angle.Degrees(-23.97314884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15120"},
        {"Hipparcos Number", "HIP 11306"},
        {"Geneva Identification System", "GEN# +1.00015120"},
        {"Smithsonian Astrophysical Observation", "SAO 167777"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.38739254),
        dec: Angle.Degrees(-23.97235064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68799"},
        {"Hipparcos Number", "HIP 40244"},
        {"Smithsonian Astrophysical Observation", "SAO 175400"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.29880050),
        dec: Angle.Degrees(-23.97011413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216691"},
        {"Hipparcos Number", "HIP 113183"},
        {"Smithsonian Astrophysical Observation", "SAO 191489"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.79381769),
        dec: Angle.Degrees(-23.96913584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113605"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15194834),
        dec: Angle.Degrees(-23.96878507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -346.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17165"},
        {"Hipparcos Number", "HIP 12810"},
        {"Smithsonian Astrophysical Observation", "SAO 168017"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.15672713),
        dec: Angle.Degrees(-23.96530618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24318",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3804 AB"},
        {"Henry Draper", "HD 33978"},
        {"Hipparcos Number", "HIP 24318"},
        {"Smithsonian Astrophysical Observation", "SAO 170198"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.27174822),
        dec: Angle.Degrees(-23.96435234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158643"},
        {"Hipparcos Number", "HIP 85755"},
        {"Geneva Identification System", "GEN# +1.00158643"},
        {"Smithsonian Astrophysical Observation", "SAO 185470"},
        {"Wilson Evans Batten Catalogue", "WEB 14471"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.85396193),
        dec: Angle.Degrees(-23.96258036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73432"},
        {"Smithsonian Astrophysical Observation", "SAO 183078"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09450664),
        dec: Angle.Degrees(-23.96247263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182416"},
        {"Hipparcos Number", "HIP 95503"},
        {"Geneva Identification System", "GEN# +1.00182416"},
        {"Smithsonian Astrophysical Observation", "SAO 188105"},
        {"Wilson Evans Batten Catalogue", "WEB 16697"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37363116),
        dec: Angle.Degrees(-23.96242415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162256"},
        {"Hipparcos Number", "HIP 87378"},
        {"Smithsonian Astrophysical Observation", "SAO 185843"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.79252223),
        dec: Angle.Degrees(-23.96174289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13215 AB"},
        {"Henry Draper", "HD 189325"},
        {"Hipparcos Number", "HIP 98471"},
        {"Smithsonian Astrophysical Observation", "SAO 188805"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08468482),
        dec: Angle.Degrees(-23.95616936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68884"},
        {"Hipparcos Number", "HIP 40277"},
        {"Geneva Identification System", "GEN# +1.00068884"},
        {"Smithsonian Astrophysical Observation", "SAO 175409"},
        {"Wilson Evans Batten Catalogue", "WEB 7851"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.37942216),
        dec: Angle.Degrees(-23.95317308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75564"},
        {"Hipparcos Number", "HIP 43365"},
        {"Smithsonian Astrophysical Observation", "SAO 176539"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.49492138),
        dec: Angle.Degrees(-23.95266990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7567"},
        {"Hipparcos Number", "HIP 5875"},
        {"Geneva Identification System", "GEN# +1.00007567"},
        {"Smithsonian Astrophysical Observation", "SAO 166911"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.86355276),
        dec: Angle.Degrees(-23.95265434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183524"},
        {"Hipparcos Number", "HIP 95967"},
        {"Geneva Identification System", "GEN# +1.00183524"},
        {"Smithsonian Astrophysical Observation", "SAO 188216"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.72844807),
        dec: Angle.Degrees(-23.95233316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113602"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.13866696),
        dec: Angle.Degrees(-23.95202473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -345.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79640"},
        {"Hipparcos Number", "HIP 45364"},
        {"Smithsonian Astrophysical Observation", "SAO 177161"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.67366269),
        dec: Angle.Degrees(-23.95115491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60344"},
        {"Hipparcos Number", "HIP 36707"},
        {"Geneva Identification System", "GEN# +1.00060344"},
        {"Renson", "Renson 16490"},
        {"Smithsonian Astrophysical Observation", "SAO 173980"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.25891778),
        dec: Angle.Degrees(-23.93427368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86612"},
        {"Hipparcos Number", "HIP 48943"},
        {"Geneva Identification System", "GEN# +1.00086612"},
        {"Smithsonian Astrophysical Observation", "SAO 178271"},
        {"Wilson Evans Batten Catalogue", "WEB 9088"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77633000),
        dec: Angle.Degrees(-23.95078326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144587"},
        {"Hipparcos Number", "HIP 78996"},
        {"Geneva Identification System", "GEN# +1.00144587"},
        {"Smithsonian Astrophysical Observation", "SAO 184138"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.87471699),
        dec: Angle.Degrees(-23.95062035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187760"},
        {"Hipparcos Number", "HIP 97805"},
        {"Geneva Identification System", "GEN# +1.00187760"},
        {"Smithsonian Astrophysical Observation", "SAO 188654"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.12459698),
        dec: Angle.Degrees(-23.94908031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22395"},
        {"Hipparcos Number", "HIP 16743"},
        {"Smithsonian Astrophysical Observation", "SAO 168654"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.84026347),
        dec: Angle.Degrees(-23.94663558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165345"},
        {"Hipparcos Number", "HIP 88705"},
        {"Smithsonian Astrophysical Observation", "SAO 186285"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.64109001),
        dec: Angle.Degrees(-23.94532699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315534"},
        {"Hipparcos Number", "HIP 89915"},
        {"Smithsonian Astrophysical Observation", "SAO 186682"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.21622445),
        dec: Angle.Degrees(-23.94299339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77905"},
        {"Smithsonian Astrophysical Observation", "SAO 183912"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.65268612),
        dec: Angle.Degrees(-23.94289301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97944",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13072 A"},
        {"Henry Draper", "HD 188088"},
        {"Hipparcos Number", "HIP 97944"},
        {"Cincinnati Publication", "Ci 20 1172"},
        {"Geneva Identification System", "GEN# +1.00188088"},
        {"Smithsonian Astrophysical Observation", "SAO 188692"},
        {"Wilson Evans Batten Catalogue", "WEB 17233"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.57426614),
        dec: Angle.Degrees(-23.94007450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -409.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25083"},
        {"Hipparcos Number", "HIP 18553"},
        {"Smithsonian Astrophysical Observation", "SAO 168995"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.56263149),
        dec: Angle.Degrees(-23.93994975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163428"},
        {"Hipparcos Number", "HIP 87880"},
        {"Geneva Identification System", "GEN# +1.00163428"},
        {"Smithsonian Astrophysical Observation", "SAO 185981"},
        {"Wilson Evans Batten Catalogue", "WEB 14835"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.28108122),
        dec: Angle.Degrees(-23.93924028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 878"},
        {"Hipparcos Number", "HIP 1047"},
        {"Smithsonian Astrophysical Observation", "SAO 166121"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.26710296),
        dec: Angle.Degrees(-23.93908727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220662"},
        {"Hipparcos Number", "HIP 115649"},
        {"Geneva Identification System", "GEN# +1.00220662"},
        {"Smithsonian Astrophysical Observation", "SAO 191895"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.42343291),
        dec: Angle.Degrees(-23.93902919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29053"},
        {"Hipparcos Number", "HIP 21241"},
        {"Smithsonian Astrophysical Observation", "SAO 169567"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.35352737),
        dec: Angle.Degrees(-23.93876467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34163"},
        {"Smithsonian Astrophysical Observation", "SAO 172923"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.26444891),
        dec: Angle.Degrees(-23.93773737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36594"},
        {"Hipparcos Number", "HIP 25913"},
        {"Smithsonian Astrophysical Observation", "SAO 170518"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.95997775),
        dec: Angle.Degrees(-23.93550058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175601B"},
        {"Hipparcos Number", "HIP 93040"},
    },
    visualMagnitude: 10.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.28941484),
        dec: Angle.Degrees(-23.86875817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58256"},
        {"Hipparcos Number", "HIP 35886"},
        {"Geneva Identification System", "GEN# +1.00058256"},
        {"Smithsonian Astrophysical Observation", "SAO 173636"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.97697284),
        dec: Angle.Degrees(-23.93344723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59549"},
        {"Hipparcos Number", "HIP 36400"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.35802768),
        dec: Angle.Degrees(-23.93147755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16688"},
        {"Hipparcos Number", "HIP 12424"},
        {"Geneva Identification System", "GEN# +1.00016688"},
        {"Smithsonian Astrophysical Observation", "SAO 167958"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.97507204),
        dec: Angle.Degrees(-23.93001882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216470"},
        {"Hipparcos Number", "HIP 113024"},
        {"Geneva Identification System", "GEN# +1.00216470"},
        {"Smithsonian Astrophysical Observation", "SAO 191467"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.34780202),
        dec: Angle.Degrees(-23.92893596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15808"},
        {"Hipparcos Number", "HIP 11778"},
        {"Smithsonian Astrophysical Observation", "SAO 167855"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.99412390),
        dec: Angle.Degrees(-23.92890191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50896"},
        {"Hipparcos Number", "HIP 33165"},
        {"Celescope Catalog", "CEL 1426"},
        {"Geneva Identification System", "GEN# +5.11210004"},
        {"Smithsonian Astrophysical Observation", "SAO 172546"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55436047),
        dec: Angle.Degrees(-23.92834798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37490"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.43054582),
        dec: Angle.Degrees(-23.92705518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103949"},
        {"Hipparcos Number", "HIP 58374"},
        {"Geneva Identification System", "GEN# +1.00103949"},
        {"Smithsonian Astrophysical Observation", "SAO 180339"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.54922864),
        dec: Angle.Degrees(-23.92375602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6129 A"},
        {"Henry Draper", "HD 59525"},
        {"Hipparcos Number", "HIP 36398"},
        {"Celescope Catalog", "CEL 1886"},
        {"Smithsonian Astrophysical Observation", "SAO 173845"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.34603434),
        dec: Angle.Degrees(-23.92342409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172480"},
        {"Hipparcos Number", "HIP 91652"},
        {"Renson", "Renson 48320"},
        {"Smithsonian Astrophysical Observation", "SAO 187134"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.35284953),
        dec: Angle.Degrees(-23.92247028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145505"},
        {"Hipparcos Number", "HIP 79392"},
        {"Geneva Identification System", "GEN# +1.00145505"},
        {"Smithsonian Astrophysical Observation", "SAO 184216"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.04124396),
        dec: Angle.Degrees(-23.92147900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72284"},
        {"Hipparcos Number", "HIP 41780"},
        {"Smithsonian Astrophysical Observation", "SAO 175988"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.79401871),
        dec: Angle.Degrees(-23.92058432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201015"},
        {"Hipparcos Number", "HIP 104285"},
        {"Wilson Evans Batten Catalogue", "WEB 18993"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.90273558),
        dec: Angle.Degrees(-23.92040262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5310"},
        {"Hipparcos Number", "HIP 4275"},
        {"Smithsonian Astrophysical Observation", "SAO 166672"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.67926126),
        dec: Angle.Degrees(-23.92025412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16317"},
        {"Hipparcos Number", "HIP 12141"},
        {"Smithsonian Astrophysical Observation", "SAO 167914"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.12272391),
        dec: Angle.Degrees(-23.91912302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84117"},
        {"Hipparcos Number", "HIP 47592"},
        {"Cincinnati Publication", "Ci 20 544"},
        {"Geneva Identification System", "GEN# +1.00084117"},
        {"Smithsonian Astrophysical Observation", "SAO 177866"},
        {"Wilson Evans Batten Catalogue", "WEB 8923"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.56113137),
        dec: Angle.Degrees(-23.91620867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -399.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 263.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63459",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8728 AB"},
        {"Henry Draper", "HD 112890"},
        {"Hipparcos Number", "HIP 63459"},
        {"Smithsonian Astrophysical Observation", "SAO 181301"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.05623988),
        dec: Angle.Degrees(-23.91435583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143007"},
        {"Hipparcos Number", "HIP 78251"},
        {"Geneva Identification System", "GEN# +1.00143007"},
        {"Smithsonian Astrophysical Observation", "SAO 183985"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64948061),
        dec: Angle.Degrees(-23.90788418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -242.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188276"},
        {"Hipparcos Number", "HIP 98024"},
        {"Smithsonian Astrophysical Observation", "SAO 188713"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79505161),
        dec: Angle.Degrees(-23.90760332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29831"},
        {"Smithsonian Astrophysical Observation", "SAO 171495"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22386120),
        dec: Angle.Degrees(-23.90703124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206147"},
        {"Hipparcos Number", "HIP 107037"},
        {"Smithsonian Astrophysical Observation", "SAO 190543"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.17219660),
        dec: Angle.Degrees(-23.90621791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116392"},
        {"Smithsonian Astrophysical Observation", "SAO 192014"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.77884263),
        dec: Angle.Degrees(-23.90592699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167503"},
        {"Hipparcos Number", "HIP 89566"},
        {"Geneva Identification System", "GEN# +1.00167503"},
        {"Smithsonian Astrophysical Observation", "SAO 186573"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.14255600),
        dec: Angle.Degrees(-23.90245876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150193"},
        {"Hipparcos Number", "HIP 81624"},
        {"Geneva Identification System", "GEN# +1.00150193"},
        {"Smithsonian Astrophysical Observation", "SAO 184536"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.07469736),
        dec: Angle.Degrees(-23.89584134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193040"},
        {"Hipparcos Number", "HIP 100148"},
        {"Smithsonian Astrophysical Observation", "SAO 189132"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.72765025),
        dec: Angle.Degrees(-23.89408263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123310"},
        {"Hipparcos Number", "HIP 68981"},
        {"Smithsonian Astrophysical Observation", "SAO 182258"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.83509556),
        dec: Angle.Degrees(-23.89289726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208794"},
        {"Hipparcos Number", "HIP 108532"},
        {"Smithsonian Astrophysical Observation", "SAO 190790"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.80001273),
        dec: Angle.Degrees(-23.89020305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62679"},
        {"Hipparcos Number", "HIP 37729"},
        {"Smithsonian Astrophysical Observation", "SAO 174421"},
        {"New General Catalogue", "NGC 2447 3"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.07689343),
        dec: Angle.Degrees(-23.88992404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42618"},
        {"Smithsonian Astrophysical Observation", "SAO 176298"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.28371681),
        dec: Angle.Degrees(-23.88974490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88199"},
        {"Hipparcos Number", "HIP 49780"},
        {"Geneva Identification System", "GEN# +1.00088199"},
        {"Smithsonian Astrophysical Observation", "SAO 178483"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.42205440),
        dec: Angle.Degrees(-23.88797095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15191"},
        {"Hipparcos Number", "HIP 11359"},
        {"Smithsonian Astrophysical Observation", "SAO 167788"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56418995),
        dec: Angle.Degrees(-23.88763931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12596"},
        {"Hipparcos Number", "HIP 9562"},
        {"Fundamental Katalog 5th Edition", "FK5 2140"},
        {"Smithsonian Astrophysical Observation", "SAO 167516"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.71567005),
        dec: Angle.Degrees(-23.88655058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78625"},
        {"Hipparcos Number", "HIP 44881"},
        {"Smithsonian Astrophysical Observation", "SAO 177019"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.17188182),
        dec: Angle.Degrees(-23.88455663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51821"},
        {"Hipparcos Number", "HIP 33511"},
    },
    visualMagnitude: 9.97,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.48905924),
        dec: Angle.Degrees(-23.88399486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190824"},
        {"Hipparcos Number", "HIP 99143"},
        {"Smithsonian Astrophysical Observation", "SAO 188932"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.91798095),
        dec: Angle.Degrees(-23.88264468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69696"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.99272103),
        dec: Angle.Degrees(-23.88259343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63044"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.77387990),
        dec: Angle.Degrees(-23.88248047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73437"},
        {"Hipparcos Number", "HIP 42317"},
        {"Smithsonian Astrophysical Observation", "SAO 176184"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41886464),
        dec: Angle.Degrees(-23.88146060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51986"},
        {"Hipparcos Number", "HIP 33574"},
        {"Celescope Catalog", "CEL 1466"},
        {"Geneva Identification System", "GEN# +1.00051986"},
        {"Smithsonian Astrophysical Observation", "SAO 172667"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.64900139),
        dec: Angle.Degrees(-23.88086360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138344"},
        {"Hipparcos Number", "HIP 76075"},
        {"Geneva Identification System", "GEN# +1.00138344"},
        {"Smithsonian Astrophysical Observation", "SAO 183548"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.06305493),
        dec: Angle.Degrees(-23.88016785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37467"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.35014378),
        dec: Angle.Degrees(-23.87848145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99319"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39414283),
        dec: Angle.Degrees(-23.87672608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89282"},
        {"Hipparcos Number", "HIP 50408"},
        {"Smithsonian Astrophysical Observation", "SAO 178627"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.38954827),
        dec: Angle.Degrees(-23.87628331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23878"},
        {"Hipparcos Number", "HIP 17717"},
        {"Geneva Identification System", "GEN# +1.00023878"},
        {"Renson", "Renson 6110"},
        {"Smithsonian Astrophysical Observation", "SAO 168836"},
        {"Wilson Evans Batten Catalogue", "WEB 3387"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.91508473),
        dec: Angle.Degrees(-23.87479582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155586"},
        {"Hipparcos Number", "HIP 84261"},
        {"Smithsonian Astrophysical Observation", "SAO 185169"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.36581640),
        dec: Angle.Degrees(-23.87120604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56466"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.65977286),
        dec: Angle.Degrees(-23.87015810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -605.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11107"},
        {"Hipparcos Number", "HIP 8434"},
        {"Geneva Identification System", "GEN# +1.00011107"},
        {"Smithsonian Astrophysical Observation", "SAO 167315"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.17910995),
        dec: Angle.Degrees(-23.86978021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14484"},
        {"Hipparcos Number", "HIP 10865"},
        {"Geneva Identification System", "GEN# +1.00014484"},
        {"Smithsonian Astrophysical Observation", "SAO 167706"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.95788637),
        dec: Angle.Degrees(-23.86699118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175601"},
        {"Hipparcos Number", "HIP 93039"},
        {"Smithsonian Astrophysical Observation", "SAO 187491"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.28844300),
        dec: Angle.Degrees(-23.86615840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177821"},
        {"Hipparcos Number", "HIP 93902"},
        {"Smithsonian Astrophysical Observation", "SAO 187695"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.81120057),
        dec: Angle.Degrees(-23.86585318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14483"},
        {"Hipparcos Number", "HIP 10860"},
        {"Geneva Identification System", "GEN# +1.00014483"},
        {"Smithsonian Astrophysical Observation", "SAO 167705"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.94568624),
        dec: Angle.Degrees(-23.86345314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223088"},
        {"Hipparcos Number", "HIP 117256"},
        {"Smithsonian Astrophysical Observation", "SAO 192142"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.63928418),
        dec: Angle.Degrees(-23.86338792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222126"},
        {"Hipparcos Number", "HIP 116628"},
        {"Geneva Identification System", "GEN# +1.00222126"},
        {"Renson", "Renson 60870"},
        {"Smithsonian Astrophysical Observation", "SAO 192046"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.51884093),
        dec: Angle.Degrees(-23.86301031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43162"},
        {"Hipparcos Number", "HIP 29568"},
        {"Geneva Identification System", "GEN# +1.00043162"},
        {"Smithsonian Astrophysical Observation", "SAO 171428"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.43885743),
        dec: Angle.Degrees(-23.86220749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18454"},
        {"Hipparcos Number", "HIP 13782"},
        {"Geneva Identification System", "GEN# +1.00018454"},
        {"Renson", "Renson 4587"},
        {"Smithsonian Astrophysical Observation", "SAO 168183"},
        {"Wilson Evans Batten Catalogue", "WEB 2729"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.34875521),
        dec: Angle.Degrees(-23.86207670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130855"},
        {"Hipparcos Number", "HIP 72652"},
        {"Geneva Identification System", "GEN# +1.00130855"},
        {"Smithsonian Astrophysical Observation", "SAO 182931"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.81400737),
        dec: Angle.Degrees(-23.85929706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184268"},
        {"Hipparcos Number", "HIP 96274"},
        {"Geneva Identification System", "GEN# +1.00184268"},
        {"Smithsonian Astrophysical Observation", "SAO 188296"},
        {"Wilson Evans Batten Catalogue", "WEB 16874"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.64141424),
        dec: Angle.Degrees(-23.85881177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96683"},
        {"Hipparcos Number", "HIP 54406"},
        {"Smithsonian Astrophysical Observation", "SAO 179559"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.99642431),
        dec: Angle.Degrees(-23.85846225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6428"},
        {"Hipparcos Number", "HIP 5069"},
        {"Smithsonian Astrophysical Observation", "SAO 166786"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20685118),
        dec: Angle.Degrees(-23.85828165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213169"},
        {"Hipparcos Number", "HIP 111054"},
        {"Geneva Identification System", "GEN# +1.00213169"},
        {"Smithsonian Astrophysical Observation", "SAO 191186"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46887911),
        dec: Angle.Degrees(-23.85543733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52511"},
        {"Hipparcos Number", "HIP 33745"},
        {"Celescope Catalog", "CEL 1502"},
        {"Geneva Identification System", "GEN# +1.00052511"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.15074546),
        dec: Angle.Degrees(-23.85539668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96101"},
        {"Geneva Identification System", "GEN# -0.02415398"},
        {"Wilson Evans Batten Catalogue", "WEB 16832"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.08660561),
        dec: Angle.Degrees(-23.85340857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91078"},
        {"Hipparcos Number", "HIP 51447"},
        {"Smithsonian Astrophysical Observation", "SAO 178908"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.60504451),
        dec: Angle.Degrees(-23.85131300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144729"},
        {"Hipparcos Number", "HIP 79054"},
        {"Geneva Identification System", "GEN# +1.00144729"},
        {"Smithsonian Astrophysical Observation", "SAO 184146"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.04380235),
        dec: Angle.Degrees(-23.85061885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132235"},
        {"Hipparcos Number", "HIP 73296"},
        {"Fundamental Katalog 5th Edition", "FK5 5327"},
        {"Smithsonian Astrophysical Observation", "SAO 183061"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.68951084),
        dec: Angle.Degrees(-23.85055322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103002"},
        {"Hipparcos Number", "HIP 57822"},
        {"Geneva Identification System", "GEN# +1.00103002"},
        {"Smithsonian Astrophysical Observation", "SAO 180242"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.85893948),
        dec: Angle.Degrees(-23.84664951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86462"},
        {"Hipparcos Number", "HIP 48879"},
        {"Smithsonian Astrophysical Observation", "SAO 178243"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.53767700),
        dec: Angle.Degrees(-23.84652304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10300"},
        {"Hipparcos Number", "HIP 7787"},
        {"Smithsonian Astrophysical Observation", "SAO 167214"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.06376011),
        dec: Angle.Degrees(-23.84614310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199348"},
        {"Hipparcos Number", "HIP 103429"},
        {"Geneva Identification System", "GEN# +1.00199348"},
        {"Smithsonian Astrophysical Observation", "SAO 189868"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.32153304),
        dec: Angle.Degrees(-23.84589773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117678"},
        {"Hipparcos Number", "HIP 66029"},
        {"Smithsonian Astrophysical Observation", "SAO 181732"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.05709358),
        dec: Angle.Degrees(-23.84579023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37738"},
        {"Geneva Identification System", "GEN# +2.24470042"},
        {"Smithsonian Astrophysical Observation", "SAO 174426"},
        {"New General Catalogue", "NGC 2447 42"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.10240078),
        dec: Angle.Degrees(-23.84554397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157398"},
        {"Hipparcos Number", "HIP 85154"},
        {"Smithsonian Astrophysical Observation", "SAO 185357"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.01461543),
        dec: Angle.Degrees(-23.84430270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36998"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06444965),
        dec: Angle.Degrees(-23.84356172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15154"},
        {"Hipparcos Number", "HIP 11339"},
        {"Smithsonian Astrophysical Observation", "SAO 167785"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.46974948),
        dec: Angle.Degrees(-23.84237283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218019"},
        {"Hipparcos Number", "HIP 113983"},
        {"Geneva Identification System", "GEN# +1.00218019"},
        {"Smithsonian Astrophysical Observation", "SAO 191633"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25270059),
        dec: Angle.Degrees(-23.84203638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110540"},
        {"Hipparcos Number", "HIP 62049"},
        {"Smithsonian Astrophysical Observation", "SAO 181043"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.77038329),
        dec: Angle.Degrees(-23.84195786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158527"},
        {"Hipparcos Number", "HIP 85703"},
        {"Geneva Identification System", "GEN# +1.00158527"},
        {"Smithsonian Astrophysical Observation", "SAO 185466"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.70672319),
        dec: Angle.Degrees(-23.84157459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8997"},
        {"Smithsonian Astrophysical Observation", "SAO 167405"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97337588),
        dec: Angle.Degrees(-23.84150010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54309"},
        {"Hipparcos Number", "HIP 34360"},
        {"Celescope Catalog", "CEL 1598"},
        {"Geneva Identification System", "GEN# +1.00054309"},
        {"Smithsonian Astrophysical Observation", "SAO 173002"},
        {"Wilson Evans Batten Catalogue", "WEB 6888"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84412120),
        dec: Angle.Degrees(-23.84073435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66910"},
        {"Hipparcos Number", "HIP 39537"},
        {"Smithsonian Astrophysical Observation", "SAO 175120"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.19153678),
        dec: Angle.Degrees(-23.84059222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1803"},
        {"Hipparcos Number", "HIP 1765"},
        {"Smithsonian Astrophysical Observation", "SAO 166222"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.58329583),
        dec: Angle.Degrees(-23.84046753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78227"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.61096005),
        dec: Angle.Degrees(-23.83899346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216934"},
        {"Hipparcos Number", "HIP 113348"},
        {"Smithsonian Astrophysical Observation", "SAO 191521"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.32812572),
        dec: Angle.Degrees(-23.83893564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61024"},
        {"Hipparcos Number", "HIP 36995"},
        {"Smithsonian Astrophysical Observation", "SAO 174098"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06198143),
        dec: Angle.Degrees(-23.83838260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37771"},
        {"New General Catalogue", "NGC 2447 73"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.17485903),
        dec: Angle.Degrees(-23.83799834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37780"},
        {"New General Catalogue", "NGC 2447 76"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19587796),
        dec: Angle.Degrees(-23.83704650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160430"},
        {"Hipparcos Number", "HIP 86515"},
        {"Geneva Identification System", "GEN# +1.00160430"},
        {"Smithsonian Astrophysical Observation", "SAO 185611"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.20790380),
        dec: Angle.Degrees(-23.83612485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158233"},
        {"Hipparcos Number", "HIP 85561"},
        {"Smithsonian Astrophysical Observation", "SAO 185446"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.27808430),
        dec: Angle.Degrees(-23.83593582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38509"},
        {"Hipparcos Number", "HIP 27149"},
        {"Smithsonian Astrophysical Observation", "SAO 170789"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.33594626),
        dec: Angle.Degrees(-23.83579688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92403"},
        {"Cincinnati Publication", "Ci 20 1108"},
        {"Geneva Identification System", "GEN# +6.10010729"},
        {"Geneva Identification System 2", "GEN# +6.10220154"},
        {"Geneva Identification System 3", "GEN# +6.00107462"},
        {"Wilson Evans Batten Catalogue", "WEB 15960"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.45398321),
        dec: Angle.Degrees(-23.83576457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 637.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192525"},
        {"Hipparcos Number", "HIP 99901"},
        {"Smithsonian Astrophysical Observation", "SAO 189084"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.04741839),
        dec: Angle.Degrees(-23.83472078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141164"},
        {"Hipparcos Number", "HIP 77435"},
        {"Celescope Catalog", "CEL 4394"},
        {"Geneva Identification System", "GEN# +1.00141164"},
        {"Smithsonian Astrophysical Observation", "SAO 183813"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.11110985),
        dec: Angle.Degrees(-23.83401521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172546"},
        {"Hipparcos Number", "HIP 91689"},
        {"Fundamental Katalog 5th Edition", "FK5 3486"},
        {"Geneva Identification System", "GEN# +1.00172546"},
        {"Renson", "Renson 48330"},
        {"Smithsonian Astrophysical Observation", "SAO 187146"},
        {"Wilson Evans Batten Catalogue", "WEB 15769"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46504286),
        dec: Angle.Degrees(-23.83335457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208793"},
        {"Hipparcos Number", "HIP 108542"},
        {"Smithsonian Astrophysical Observation", "SAO 190793"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.82382322),
        dec: Angle.Degrees(-23.83333482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53138"},
        {"Hipparcos Number", "HIP 33977"},
        {"Celescope Catalog", "CEL 1535"},
        {"Fundamental Katalog 5th Edition", "FK5 270"},
        {"Geneva Identification System", "GEN# +5.11210029"},
        {"Smithsonian Astrophysical Observation", "SAO 172839"},
        {"Wilson Evans Batten Catalogue", "WEB 6816"},
    },
    visualMagnitude: 3.02,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.75613986),
        dec: Angle.Degrees(-23.83330131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84909"},
        {"Smithsonian Astrophysical Observation", "SAO 185301"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.29338996),
        dec: Angle.Degrees(-23.83289836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71834"},
        {"Hipparcos Number", "HIP 41582"},
        {"Smithsonian Astrophysical Observation", "SAO 175907"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17282470),
        dec: Angle.Degrees(-23.82901839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17956"},
        {"Smithsonian Astrophysical Observation", "SAO 168876"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.58133377),
        dec: Angle.Degrees(-23.82858644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10036"},
        {"Hipparcos Number", "HIP 7584"},
        {"Smithsonian Astrophysical Observation", "SAO 167182"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.41806960),
        dec: Angle.Degrees(-23.82837892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56579"},
        {"Hipparcos Number", "HIP 35208"},
        {"Celescope Catalog", "CEL 1735"},
        {"Smithsonian Astrophysical Observation", "SAO 173350"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.15134577),
        dec: Angle.Degrees(-23.82686508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72869"},
        {"Hipparcos Number", "HIP 42064"},
        {"Geneva Identification System", "GEN# +1.00072869"},
        {"Smithsonian Astrophysical Observation", "SAO 176098"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.60841931),
        dec: Angle.Degrees(-23.82680380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99754"},
        {"Hipparcos Number", "HIP 55981"},
        {"Smithsonian Astrophysical Observation", "SAO 179915"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.09731211),
        dec: Angle.Degrees(-23.82663321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81410"},
        {"Hipparcos Number", "HIP 46159"},
        {"Geneva Identification System", "GEN# +1.00081410"},
        {"Smithsonian Astrophysical Observation", "SAO 177412"},
        {"Wilson Evans Batten Catalogue", "WEB 8740"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.20432961),
        dec: Angle.Degrees(-23.82623159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9062"},
        {"Hipparcos Number", "HIP 6901"},
        {"Smithsonian Astrophysical Observation", "SAO 167080"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.22044844),
        dec: Angle.Degrees(-23.82499980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83094"},
        {"Smithsonian Astrophysical Observation", "SAO 184862"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.68934667),
        dec: Angle.Degrees(-23.82470449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203913"},
        {"Hipparcos Number", "HIP 105815"},
        {"Smithsonian Astrophysical Observation", "SAO 190330"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.45226086),
        dec: Angle.Degrees(-23.82205959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114116"},
        {"Hipparcos Number", "HIP 64135"},
        {"Geneva Identification System", "GEN# +1.00114116"},
        {"Smithsonian Astrophysical Observation", "SAO 181409"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16642706),
        dec: Angle.Degrees(-23.82205888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26742"},
        {"Hipparcos Number", "HIP 19666"},
        {"Smithsonian Astrophysical Observation", "SAO 169229"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.20018037),
        dec: Angle.Degrees(-23.82116886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97464"},
        {"Hipparcos Number", "HIP 54771"},
        {"Smithsonian Astrophysical Observation", "SAO 179642"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.19796516),
        dec: Angle.Degrees(-23.82049622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218957"},
        {"Hipparcos Number", "HIP 114568"},
        {"Geneva Identification System", "GEN# +1.00218957"},
        {"Smithsonian Astrophysical Observation", "SAO 191719"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.12505635),
        dec: Angle.Degrees(-23.81948454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283"},
        {"Hipparcos Number", "HIP 616"},
        {"Cincinnati Publication", "Ci 18 5"},
        {"Geneva Identification System", "GEN# +1.00000283"},
        {"Smithsonian Astrophysical Observation", "SAO 166064"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.88473813),
        dec: Angle.Degrees(-23.81894320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76512"},
        {"Hipparcos Number", "HIP 43853"},
        {"Fundamental Katalog 5th Edition", "FK5 2707"},
        {"Geneva Identification System", "GEN# +1.00076512"},
        {"Smithsonian Astrophysical Observation", "SAO 176711"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.98305637),
        dec: Angle.Degrees(-23.81841370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139663"},
        {"Hipparcos Number", "HIP 76742"},
        {"Fundamental Katalog 5th Edition", "FK5 3239"},
        {"Geneva Identification System", "GEN# +1.00139663"},
        {"Smithsonian Astrophysical Observation", "SAO 183686"},
        {"Wilson Evans Batten Catalogue", "WEB 13024"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.07043893),
        dec: Angle.Degrees(-23.81805841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14802"},
        {"Hipparcos Number", "HIP 11072"},
        {"Fundamental Katalog 5th Edition", "FK5 83"},
        {"Geneva Identification System", "GEN# +1.00014802"},
        {"Smithsonian Astrophysical Observation", "SAO 167736"},
        {"Wilson Evans Batten Catalogue", "WEB 2328"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.63508730),
        dec: Angle.Degrees(-23.81631542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163955"},
        {"Hipparcos Number", "HIP 88116"},
        {"Celescope Catalog", "CEL 4585"},
        {"Fundamental Katalog 5th Edition", "FK5 3430"},
        {"Geneva Identification System", "GEN# +1.00163955"},
        {"Smithsonian Astrophysical Observation", "SAO 186061"},
        {"Wilson Evans Batten Catalogue", "WEB 14881"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.94815306),
        dec: Angle.Degrees(-23.81601126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157033"},
        {"Hipparcos Number", "HIP 84960"},
        {"Smithsonian Astrophysical Observation", "SAO 185317"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.47125918),
        dec: Angle.Degrees(-23.81571704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167359"},
        {"Hipparcos Number", "HIP 89497"},
        {"Geneva Identification System", "GEN# +1.00167359"},
        {"Smithsonian Astrophysical Observation", "SAO 186555"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.95428724),
        dec: Angle.Degrees(-23.81554712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88806"},
        {"Hipparcos Number", "HIP 50142"},
        {"Geneva Identification System", "GEN# +1.00088806"},
        {"Smithsonian Astrophysical Observation", "SAO 178558"},
        {"Wilson Evans Batten Catalogue", "WEB 9218"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.53740135),
        dec: Angle.Degrees(-23.81397243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47785"},
        {"Hipparcos Number", "HIP 31836"},
        {"Smithsonian Astrophysical Observation", "SAO 172096"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.83536147),
        dec: Angle.Degrees(-23.81276706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14130"},
        {"Smithsonian Astrophysical Observation", "SAO 168245"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.55692976),
        dec: Angle.Degrees(-23.81036240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110052"},
        {"Hipparcos Number", "HIP 61768"},
        {"Fundamental Katalog 5th Edition", "FK5 5116"},
        {"Geneva Identification System", "GEN# +1.00110052"},
        {"Smithsonian Astrophysical Observation", "SAO 180991"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.89679596),
        dec: Angle.Degrees(-23.81022117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71466"},
        {"Henry Draper 2", "HD 71467"},
        {"Hipparcos Number", "HIP 41412"},
        {"Smithsonian Astrophysical Observation", "SAO 175845"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.70996487),
        dec: Angle.Degrees(-23.80836913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202758"},
        {"Hipparcos Number", "HIP 105217"},
        {"Geneva Identification System", "GEN# +1.00202758"},
        {"Smithsonian Astrophysical Observation", "SAO 190218"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68600569),
        dec: Angle.Degrees(-23.80779850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87019"},
        {"Hipparcos Number", "HIP 49141"},
        {"Geneva Identification System", "GEN# +1.00087019"},
        {"Smithsonian Astrophysical Observation", "SAO 178316"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.43468755),
        dec: Angle.Degrees(-23.80686502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13250"},
        {"Hipparcos Number", "HIP 10016"},
        {"Smithsonian Astrophysical Observation", "SAO 167586"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.24300166),
        dec: Angle.Degrees(-23.80675981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3795"},
        {"Hipparcos Number", "HIP 3185"},
        {"Cincinnati Publication", "Ci 20 45"},
        {"Cincinnati Publication 2", "Ci 18 87"},
        {"Geneva Identification System", "GEN# +1.00003795"},
        {"Smithsonian Astrophysical Observation", "SAO 166475"},
        {"Wilson Evans Batten Catalogue", "WEB 570"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13501584),
        dec: Angle.Degrees(-23.80399309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 635.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80029"},
        {"Smithsonian Astrophysical Observation", "SAO 184322"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.04408992),
        dec: Angle.Degrees(-23.80335768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50304"},
        {"Hipparcos Number", "HIP 32937"},
        {"Geneva Identification System", "GEN# +1.00050304"},
        {"Renson", "Renson 13774"},
        {"Smithsonian Astrophysical Observation", "SAO 172455"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.92230083),
        dec: Angle.Degrees(-23.80289697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211709"},
        {"Hipparcos Number", "HIP 110210"},
        {"Geneva Identification System", "GEN# +1.00211709"},
        {"Smithsonian Astrophysical Observation", "SAO 191056"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.86350479),
        dec: Angle.Degrees(-23.80231254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35677"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.42274769),
        dec: Angle.Degrees(-23.80141806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139556"},
        {"Hipparcos Number", "HIP 76689"},
        {"Geneva Identification System", "GEN# +1.00139556"},
        {"Smithsonian Astrophysical Observation", "SAO 183671"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.89956483),
        dec: Angle.Degrees(-23.80074731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200051"},
        {"Hipparcos Number", "HIP 103773"},
        {"Geneva Identification System", "GEN# +1.00200051"},
        {"Smithsonian Astrophysical Observation", "SAO 189943"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.42826943),
        dec: Angle.Degrees(-23.79920474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27300"},
        {"Hipparcos Number", "HIP 20022"},
        {"Smithsonian Astrophysical Observation", "SAO 169308"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.41962390),
        dec: Angle.Degrees(-23.79854968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63847"},
        {"Hipparcos Number", "HIP 38235"},
        {"Geneva Identification System", "GEN# +1.00063847"},
        {"Smithsonian Astrophysical Observation", "SAO 174625"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.49637277),
        dec: Angle.Degrees(-23.79824265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70097"},
        {"Hipparcos Number", "HIP 40773"},
        {"Smithsonian Astrophysical Observation", "SAO 175590"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.82615975),
        dec: Angle.Degrees(-23.79700662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37814"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.29324570),
        dec: Angle.Degrees(-23.79622582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25117"},
        {"Hipparcos Number", "HIP 18575"},
        {"Smithsonian Astrophysical Observation", "SAO 168998"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.64268660),
        dec: Angle.Degrees(-23.79529796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76948"},
        {"Hipparcos Number", "HIP 44070"},
        {"Geneva Identification System", "GEN# +1.00076948"},
        {"Smithsonian Astrophysical Observation", "SAO 176769"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.64851656),
        dec: Angle.Degrees(-23.79512983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42912",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6974 A"},
        {"Henry Draper", "HD 74690"},
        {"Hipparcos Number", "HIP 42912"},
        {"Smithsonian Astrophysical Observation", "SAO 176395"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.17269395),
        dec: Angle.Degrees(-23.78831338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2696"},
        {"Hipparcos Number", "HIP 2381"},
        {"Fundamental Katalog 5th Edition", "FK5 14"},
        {"Geneva Identification System", "GEN# +1.00002696"},
        {"Smithsonian Astrophysical Observation", "SAO 166318"},
        {"Wilson Evans Batten Catalogue", "WEB 437"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.59446346),
        dec: Angle.Degrees(-23.78771429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105574"},
        {"Hipparcos Number", "HIP 59260"},
        {"Smithsonian Astrophysical Observation", "SAO 180520"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.33843290),
        dec: Angle.Degrees(-23.78681778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106567"},
        {"Hipparcos Number", "HIP 59779"},
        {"Smithsonian Astrophysical Observation", "SAO 180609"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.86232832),
        dec: Angle.Degrees(-23.78536779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32451"},
        {"Hipparcos Number", "HIP 23449"},
        {"Smithsonian Astrophysical Observation", "SAO 170005"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.61134398),
        dec: Angle.Degrees(-23.78397953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70259"},
        {"Hipparcos Number", "HIP 40857"},
        {"Smithsonian Astrophysical Observation", "SAO 175623"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.05283100),
        dec: Angle.Degrees(-23.78351591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90608"},
        {"Hipparcos Number", "HIP 51186"},
        {"Smithsonian Astrophysical Observation", "SAO 178832"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.83416057),
        dec: Angle.Degrees(-23.78311488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14380 AB"},
        {"Henry Draper", "HD 198732"},
        {"Hipparcos Number", "HIP 103071"},
        {"Geneva Identification System", "GEN# +1.00198732"},
        {"Smithsonian Astrophysical Observation", "SAO 189801"},
        {"Wilson Evans Batten Catalogue", "WEB 18710"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.25459112),
        dec: Angle.Degrees(-23.78305045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42749"},
        {"Hipparcos Number", "HIP 29376"},
        {"Smithsonian Astrophysical Observation", "SAO 171358"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88069432),
        dec: Angle.Degrees(-23.78284374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28828"},
        {"Smithsonian Astrophysical Observation", "SAO 171217"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.27810354),
        dec: Angle.Degrees(-23.78204634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105066"},
        {"Hipparcos Number", "HIP 58997"},
        {"Smithsonian Astrophysical Observation", "SAO 180450"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.45443878),
        dec: Angle.Degrees(-23.78119639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133467"},
        {"Hipparcos Number", "HIP 73830"},
        {"Smithsonian Astrophysical Observation", "SAO 183157"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33371405),
        dec: Angle.Degrees(-23.77634894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61227"},
        {"Hipparcos Number", "HIP 37089"},
        {"Geneva Identification System", "GEN# +1.00061227"},
        {"Smithsonian Astrophysical Observation", "SAO 174141"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.32055484),
        dec: Angle.Degrees(-23.77541233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54641"},
        {"Hipparcos Number", "HIP 34478"},
        {"Smithsonian Astrophysical Observation", "SAO 173056"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18528066),
        dec: Angle.Degrees(-23.77515608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196761"},
        {"Hipparcos Number", "HIP 101997"},
        {"Cincinnati Publication", "Ci 20 1218"},
        {"Cincinnati Publication 2", "Ci 18 2672"},
        {"Geneva Identification System", "GEN# +1.00196761"},
        {"Smithsonian Astrophysical Observation", "SAO 189549"},
        {"Wilson Evans Batten Catalogue", "WEB 18438"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.04765218),
        dec: Angle.Degrees(-23.77498736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 500.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 460.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145836"},
        {"Hipparcos Number", "HIP 79557"},
        {"Geneva Identification System", "GEN# +1.00145836"},
        {"Smithsonian Astrophysical Observation", "SAO 184246"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.50853513),
        dec: Angle.Degrees(-23.77405736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14844 A"},
        {"Henry Draper", "HD 202892"},
        {"Hipparcos Number", "HIP 105284"},
        {"Smithsonian Astrophysical Observation", "SAO 190232"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.88166101),
        dec: Angle.Degrees(-23.77205297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8553",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1463 A"},
        {"Henry Draper", "HD 11288"},
        {"Hipparcos Number", "HIP 8553"},
        {"Geneva Identification System", "GEN# +1.00011288J"},
        {"Smithsonian Astrophysical Observation", "SAO 167339"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.58445720),
        dec: Angle.Degrees(-23.77182941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22131"},
        {"Hipparcos Number", "HIP 16549"},
        {"Smithsonian Astrophysical Observation", "SAO 168625"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.27782670),
        dec: Angle.Degrees(-23.76700358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105241"},
        {"Hipparcos Number", "HIP 59087"},
        {"Geneva Identification System", "GEN# +1.00105241"},
        {"Smithsonian Astrophysical Observation", "SAO 180479"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.75586744),
        dec: Angle.Degrees(-23.76634820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216209"},
        {"Hipparcos Number", "HIP 112858"},
        {"Smithsonian Astrophysical Observation", "SAO 191443"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.82373511),
        dec: Angle.Degrees(-23.76536132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215298"},
        {"Hipparcos Number", "HIP 112269"},
        {"Smithsonian Astrophysical Observation", "SAO 191364"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.10596844),
        dec: Angle.Degrees(-23.76495458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115947"},
        {"Hipparcos Number", "HIP 65124"},
        {"Smithsonian Astrophysical Observation", "SAO 181571"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.18882383),
        dec: Angle.Degrees(-23.76344367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146069"},
        {"Hipparcos Number", "HIP 79643"},
        {"Geneva Identification System", "GEN# +1.00146069"},
        {"Smithsonian Astrophysical Observation", "SAO 184261"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.78869016),
        dec: Angle.Degrees(-23.75967540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46583"},
        {"Hipparcos Number", "HIP 31250"},
        {"Smithsonian Astrophysical Observation", "SAO 171935"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.31959453),
        dec: Angle.Degrees(-23.75258737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153190"},
        {"Hipparcos Number", "HIP 83099"},
        {"Smithsonian Astrophysical Observation", "SAO 184869"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.71754934),
        dec: Angle.Degrees(-23.74636324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21792"},
        {"Hipparcos Number", "HIP 16282"},
        {"Smithsonian Astrophysical Observation", "SAO 168589"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47794828),
        dec: Angle.Degrees(-23.74591070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7834 A"},
        {"Henry Draper", "HD 91550"},
        {"Hipparcos Number", "HIP 51718"},
        {"Fundamental Katalog 5th Edition", "FK5 399"},
        {"Geneva Identification System", "GEN# +1.00091550"},
        {"Smithsonian Astrophysical Observation", "SAO 178979"},
        {"Wilson Evans Batten Catalogue", "WEB 9429"},
    },
    visualMagnitude: 5.08,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.50371309),
        dec: Angle.Degrees(-23.74521609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21815"},
        {"Hipparcos Number", "HIP 16312"},
        {"Smithsonian Astrophysical Observation", "SAO 168595"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55903672),
        dec: Angle.Degrees(-23.74506925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16511 AB"},
        {"Henry Draper", "HD 218240"},
        {"Hipparcos Number", "HIP 114119"},
        {"Geneva Identification System", "GEN# +1.00218240J"},
        {"Smithsonian Astrophysical Observation", "SAO 191651"},
        {"Wilson Evans Batten Catalogue", "WEB 20264"},
    },
    visualMagnitude: 4.48,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.67003033),
        dec: Angle.Degrees(-23.74311680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179087"},
        {"Hipparcos Number", "HIP 94333"},
        {"Smithsonian Astrophysical Observation", "SAO 187805"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.01746198),
        dec: Angle.Degrees(-23.74050991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56341"},
        {"Hipparcos Number", "HIP 35132"},
        {"Celescope Catalog", "CEL 1724"},
        {"Geneva Identification System", "GEN# +1.00056341"},
        {"Smithsonian Astrophysical Observation", "SAO 173319"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.94710380),
        dec: Angle.Degrees(-23.74031161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19826"},
        {"Hipparcos Number", "HIP 14757"},
        {"Geneva Identification System", "GEN# +1.00019826"},
        {"Smithsonian Astrophysical Observation", "SAO 168354"},
        {"Wilson Evans Batten Catalogue", "WEB 2857"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.64729714),
        dec: Angle.Degrees(-23.73862338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69705"},
        {"Hipparcos Number", "HIP 40591"},
        {"Smithsonian Astrophysical Observation", "SAO 175515"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31457272),
        dec: Angle.Degrees(-23.73548402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186735"},
        {"Hipparcos Number", "HIP 97349"},
        {"Fundamental Katalog 5th Edition", "FK5 5746"},
        {"Smithsonian Astrophysical Observation", "SAO 188560"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.78090056),
        dec: Angle.Degrees(-23.73473673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43606"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.20932479),
        dec: Angle.Degrees(-23.73385608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 248.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 900"},
        {"Hipparcos Number", "HIP 1071"},
        {"Geneva Identification System", "GEN# +1.00000900"},
        {"Smithsonian Astrophysical Observation", "SAO 166125"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.32358136),
        dec: Angle.Degrees(-23.73251665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210081"},
        {"Hipparcos Number", "HIP 109269"},
        {"Geneva Identification System", "GEN# +1.00210081"},
        {"Smithsonian Astrophysical Observation", "SAO 190911"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.06166939),
        dec: Angle.Degrees(-23.73218275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16063"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.72632653),
        dec: Angle.Degrees(-23.73148812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98864"},
        {"Hipparcos Number", "HIP 55541"},
        {"Smithsonian Astrophysical Observation", "SAO 179820"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.64667194),
        dec: Angle.Degrees(-23.73025500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209562"},
        {"Hipparcos Number", "HIP 108996"},
        {"Smithsonian Astrophysical Observation", "SAO 190870"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.20731179),
        dec: Angle.Degrees(-23.72957665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16064"},
    },
    visualMagnitude: 11.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.73068202),
        dec: Angle.Degrees(-23.72616389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98565"},
        {"Hipparcos Number", "HIP 55375"},
        {"Smithsonian Astrophysical Observation", "SAO 179782"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.07926843),
        dec: Angle.Degrees(-23.72526541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197726"},
        {"Hipparcos Number", "HIP 102494"},
        {"Fundamental Katalog 5th Edition", "FK5 5830"},
        {"Smithsonian Astrophysical Observation", "SAO 189669"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.56953706),
        dec: Angle.Degrees(-23.72398580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37778"},
        {"Hipparcos Number", "HIP 26671"},
        {"Smithsonian Astrophysical Observation", "SAO 170663"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.02463594),
        dec: Angle.Degrees(-23.72364018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16414"},
        {"Hipparcos Number", "HIP 12220"},
        {"Smithsonian Astrophysical Observation", "SAO 167927"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.33941649),
        dec: Angle.Degrees(-23.72248415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12977 A"},
        {"Henry Draper", "HD 187248"},
        {"Hipparcos Number", "HIP 97570"},
    },
    visualMagnitude: 12.05,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)49, 54.1900),
        dec: Angle.DegreesMinutesSeconds((int)-23, (int)43, 02.400)
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
    primaryId: "HIP 36140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58907"},
        {"Hipparcos Number", "HIP 36140"},
        {"Celescope Catalog", "CEL 1855"},
        {"Geneva Identification System", "GEN# +1.00058907"},
        {"Smithsonian Astrophysical Observation", "SAO 173743"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.66954491),
        dec: Angle.Degrees(-23.71262489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10932"},
        {"Smithsonian Astrophysical Observation", "SAO 167720"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.19883167),
        dec: Angle.Degrees(-23.71142505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89816"},
        {"Hipparcos Number", "HIP 50728"},
        {"Fundamental Katalog 5th Edition", "FK5 2832"},
        {"Geneva Identification System", "GEN# +1.00089816"},
        {"Smithsonian Astrophysical Observation", "SAO 178721"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.36956636),
        dec: Angle.Degrees(-23.71087724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3618 AB"},
        {"Henry Draper", "HD 32310"},
        {"Hipparcos Number", "HIP 23347"},
        {"Smithsonian Astrophysical Observation", "SAO 169979"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.32613134),
        dec: Angle.Degrees(-23.70802430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147196"},
        {"Hipparcos Number", "HIP 80126"},
        {"Geneva Identification System", "GEN# +1.00147196"},
        {"Smithsonian Astrophysical Observation", "SAO 184337"},
        {"Wilson Evans Batten Catalogue", "WEB 13562"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.32999233),
        dec: Angle.Degrees(-23.70792311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33136"},
        {"Renson", "Renson 14000"},
        {"Smithsonian Astrophysical Observation", "SAO 172533"},
    },
    visualMagnitude: 10.63,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.49686488),
        dec: Angle.Degrees(-23.70679478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98975"},
        {"Hipparcos Number", "HIP 55596"},
        {"Smithsonian Astrophysical Observation", "SAO 179831"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.82653915),
        dec: Angle.Degrees(-23.70652406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84007"},
        {"Smithsonian Astrophysical Observation", "SAO 185100"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.58456446),
        dec: Angle.Degrees(-23.70567894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47904"},
        {"Hipparcos Number", "HIP 31884"},
        {"Smithsonian Astrophysical Observation", "SAO 172115"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.98274902),
        dec: Angle.Degrees(-23.70386070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39144"},
        {"Geneva Identification System", "GEN# -0.02306645"},
        {"Wilson Evans Batten Catalogue", "WEB 7676"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09547038),
        dec: Angle.Degrees(-23.70318374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74229"},
        {"Smithsonian Astrophysical Observation", "SAO 183236"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.54142845),
        dec: Angle.Degrees(-23.70301896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163665"},
        {"Hipparcos Number", "HIP 87981"},
        {"Smithsonian Astrophysical Observation", "SAO 186018"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.58157686),
        dec: Angle.Degrees(-23.70208228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11133 A"},
        {"Henry Draper", "HD 166464"},
        {"Hipparcos Number", "HIP 89153"},
        {"Geneva Identification System", "GEN# +1.00166464A"},
        {"Smithsonian Astrophysical Observation", "SAO 186437"},
        {"Wilson Evans Batten Catalogue", "WEB 15139"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.93053328),
        dec: Angle.Degrees(-23.70116777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124122"},
        {"Hipparcos Number", "HIP 69375"},
        {"Geneva Identification System", "GEN# +1.00124122"},
        {"Smithsonian Astrophysical Observation", "SAO 182341"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.03129769),
        dec: Angle.Degrees(-23.70114572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9731"},
        {"Hipparcos Number", "HIP 7363"},
        {"Smithsonian Astrophysical Observation", "SAO 167153"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71481184),
        dec: Angle.Degrees(-23.69971287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137858"},
        {"Hipparcos Number", "HIP 75801"},
        {"Smithsonian Astrophysical Observation", "SAO 183511"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28588951),
        dec: Angle.Degrees(-23.69935582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108821"},
        {"Hipparcos Number", "HIP 61015"},
        {"Geneva Identification System", "GEN# +1.00108821"},
        {"Smithsonian Astrophysical Observation", "SAO 180850"},
        {"Wilson Evans Batten Catalogue", "WEB 10862"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.57275779),
        dec: Angle.Degrees(-23.69642033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47827"},
        {"Hipparcos Number", "HIP 31859"},
        {"Geneva Identification System", "GEN# +1.00047827J"},
        {"Smithsonian Astrophysical Observation", "SAO 172102"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.90092445),
        dec: Angle.Degrees(-23.69564336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205707"},
        {"Hipparcos Number", "HIP 106778"},
        {"Smithsonian Astrophysical Observation", "SAO 190505"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42589646),
        dec: Angle.Degrees(-23.69506983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176661"},
        {"Hipparcos Number", "HIP 93480"},
        {"Smithsonian Astrophysical Observation", "SAO 187595"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.55965976),
        dec: Angle.Degrees(-23.69455349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314027"},
        {"Hipparcos Number", "HIP 89084"},
        {"Smithsonian Astrophysical Observation", "SAO 186416"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.72638724),
        dec: Angle.Degrees(-23.69291318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5766"},
        {"Hipparcos Number", "HIP 4610"},
        {"Geneva Identification System", "GEN# +1.00005766"},
        {"Smithsonian Astrophysical Observation", "SAO 166721"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.76916432),
        dec: Angle.Degrees(-23.69120870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94102"},
        {"Hipparcos Number", "HIP 53059"},
        {"Smithsonian Astrophysical Observation", "SAO 179274"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.83982176),
        dec: Angle.Degrees(-23.68952308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18659"},
        {"Hipparcos Number", "HIP 13920"},
        {"Smithsonian Astrophysical Observation", "SAO 168203"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.82931412),
        dec: Angle.Degrees(-23.68952305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71142"},
        {"Hipparcos Number", "HIP 41236"},
        {"Geneva Identification System", "GEN# +1.00071142"},
        {"Smithsonian Astrophysical Observation", "SAO 175775"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.21995433),
        dec: Angle.Degrees(-23.68924795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118598"},
        {"Hipparcos Number", "HIP 66530"},
        {"Geneva Identification System", "GEN# +1.00118598"},
        {"Smithsonian Astrophysical Observation", "SAO 181818"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.55743485),
        dec: Angle.Degrees(-23.68919964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144844"},
        {"Hipparcos Number", "HIP 79098"},
        {"Fundamental Katalog 5th Edition", "FK5 3275"},
        {"Geneva Identification System", "GEN# +1.00144844"},
        {"Renson", "Renson 41040"},
        {"Smithsonian Astrophysical Observation", "SAO 184164"},
        {"Wilson Evans Batten Catalogue", "WEB 13371"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.18219664),
        dec: Angle.Degrees(-23.68535317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161466"},
        {"Hipparcos Number", "HIP 87003"},
        {"Geneva Identification System", "GEN# +1.00161466"},
        {"Smithsonian Astrophysical Observation", "SAO 185736"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67394762),
        dec: Angle.Degrees(-23.68465984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85736"},
        {"Hipparcos Number", "HIP 48479"},
        {"Smithsonian Astrophysical Observation", "SAO 178138"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.31005089),
        dec: Angle.Degrees(-23.68320069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73842"},
        {"Smithsonian Astrophysical Observation", "SAO 183159"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.36156236),
        dec: Angle.Degrees(-23.68306490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212643"},
        {"Hipparcos Number", "HIP 110746"},
        {"Fundamental Katalog 5th Edition", "FK5 3793"},
        {"Geneva Identification System", "GEN# +1.00212643"},
        {"Smithsonian Astrophysical Observation", "SAO 191144"},
        {"Wilson Evans Batten Catalogue", "WEB 19842"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.54456634),
        dec: Angle.Degrees(-23.68244261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314613"},
        {"Hipparcos Number", "HIP 90366"},
        {"Smithsonian Astrophysical Observation", "SAO 186813"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.59277146),
        dec: Angle.Degrees(-23.68118263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152719"},
        {"Hipparcos Number", "HIP 82858"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.00310774),
        dec: Angle.Degrees(-23.68007675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114086"},
        {"Hipparcos Number", "HIP 64124"},
        {"Smithsonian Astrophysical Observation", "SAO 181406"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.13636575),
        dec: Angle.Degrees(-23.67931309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81904"},
        {"Hipparcos Number", "HIP 46425"},
        {"Geneva Identification System", "GEN# +1.00081904"},
        {"Smithsonian Astrophysical Observation", "SAO 177490"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.99223408),
        dec: Angle.Degrees(-23.67927162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161038"},
        {"Hipparcos Number", "HIP 86811"},
        {"Geneva Identification System", "GEN# +1.00161038"},
        {"Smithsonian Astrophysical Observation", "SAO 185674"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.07404230),
        dec: Angle.Degrees(-23.67895603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1034"},
        {"Smithsonian Astrophysical Observation", "SAO 166117"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.23213237),
        dec: Angle.Degrees(-23.67887556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222223"},
        {"Hipparcos Number", "HIP 116690"},
        {"Geneva Identification System", "GEN# +1.00222223"},
        {"Smithsonian Astrophysical Observation", "SAO 192058"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.71022109),
        dec: Angle.Degrees(-23.67825645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162343"},
        {"Hipparcos Number", "HIP 87399"},
        {"Geneva Identification System", "GEN# +1.00162343"},
        {"Smithsonian Astrophysical Observation", "SAO 185850"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.91300408),
        dec: Angle.Degrees(-23.67743364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222723"},
        {"Hipparcos Number", "HIP 117005"},
        {"Geneva Identification System", "GEN# +1.00222723"},
        {"Smithsonian Astrophysical Observation", "SAO 192104"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.79410391),
        dec: Angle.Degrees(-23.67553973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137153"},
        {"Hipparcos Number", "HIP 75478"},
        {"Smithsonian Astrophysical Observation", "SAO 183450"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.28194373),
        dec: Angle.Degrees(-23.67116019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144175"},
        {"Hipparcos Number", "HIP 78809"},
        {"Geneva Identification System", "GEN# +1.00144175"},
        {"Smithsonian Astrophysical Observation", "SAO 184098"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.32980979),
        dec: Angle.Degrees(-23.66906133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9054 A"},
        {"Henry Draper", "HD 121304"},
        {"Hipparcos Number", "HIP 67971"},
        {"Smithsonian Astrophysical Observation", "SAO 182077"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.79422461),
        dec: Angle.Degrees(-23.66753621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38095"},
        {"Geneva Identification System", "GEN# -0.02306243"},
    },
    visualMagnitude: 11.78,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.09553869),
        dec: Angle.Degrees(-23.66675927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224566"},
        {"Hipparcos Number", "HIP 118239"},
        {"Smithsonian Astrophysical Observation", "SAO 192286"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.74111548),
        dec: Angle.Degrees(-23.66544222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210244"},
        {"Hipparcos Number", "HIP 109375"},
        {"Geneva Identification System", "GEN# +1.00210244"},
        {"Smithsonian Astrophysical Observation", "SAO 190922"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.37057515),
        dec: Angle.Degrees(-23.65911659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7350 AB"},
        {"Henry Draper", "HD 81230"},
        {"Hipparcos Number", "HIP 46078"},
        {"Geneva Identification System", "GEN# +1.00081230J"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.95172060),
        dec: Angle.Degrees(-23.65890294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5508"},
        {"Hipparcos Number", "HIP 4420"},
        {"Geneva Identification System", "GEN# +1.00005508"},
        {"Smithsonian Astrophysical Observation", "SAO 166697"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.15730291),
        dec: Angle.Degrees(-23.65660194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118282"},
        {"Hipparcos Number", "HIP 66363"},
        {"Smithsonian Astrophysical Observation", "SAO 181786"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.04612616),
        dec: Angle.Degrees(-23.65385386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76479",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9713 AB"},
        {"Henry Draper", "HD 139121"},
        {"Hipparcos Number", "HIP 76479"},
        {"Smithsonian Astrophysical Observation", "SAO 183624"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.29961097),
        dec: Angle.Degrees(-23.65154928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88259"},
        {"Hipparcos Number", "HIP 49810"},
        {"Smithsonian Astrophysical Observation", "SAO 178493"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.52971097),
        dec: Angle.Degrees(-23.65062237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185678"},
        {"Hipparcos Number", "HIP 96838"},
        {"Smithsonian Astrophysical Observation", "SAO 188439"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.26905675),
        dec: Angle.Degrees(-23.65018616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8923 A"},
        {"Henry Draper", "HD 117408"},
        {"Hipparcos Number", "HIP 65896"},
        {"Geneva Identification System", "GEN# +1.00117408"},
        {"Smithsonian Astrophysical Observation", "SAO 181708"},
        {"Wilson Evans Batten Catalogue", "WEB 11658"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.62297320),
        dec: Angle.Degrees(-23.64948629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9411"},
        {"Hipparcos Number", "HIP 7148"},
        {"Geneva Identification System", "GEN# +1.00009411"},
        {"Smithsonian Astrophysical Observation", "SAO 167116"},
        {"Wilson Evans Batten Catalogue", "WEB 1545"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.03170544),
        dec: Angle.Degrees(-23.64824895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32888"},
        {"Hipparcos Number", "HIP 23687"},
        {"Smithsonian Astrophysical Observation", "SAO 170052"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.36739053),
        dec: Angle.Degrees(-23.64808806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97783"},
        {"Hipparcos Number", "HIP 54924"},
        {"Geneva Identification System", "GEN# +1.00097783"},
        {"Smithsonian Astrophysical Observation", "SAO 179684"},
        {"Wilson Evans Batten Catalogue", "WEB 9911"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.70723207),
        dec: Angle.Degrees(-23.64670961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 307.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50232"},
        {"Hipparcos Number", "HIP 32909"},
        {"Smithsonian Astrophysical Observation", "SAO 172445"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.85482194),
        dec: Angle.Degrees(-23.64665156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23147"},
        {"Hipparcos Number", "HIP 17280"},
        {"Smithsonian Astrophysical Observation", "SAO 168752"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50222120),
        dec: Angle.Degrees(-23.64461963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38628"},
        {"Hipparcos Number", "HIP 27229"},
        {"Smithsonian Astrophysical Observation", "SAO 170809"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.55818406),
        dec: Angle.Degrees(-23.64439938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7735 B"},
        {"Hipparcos Number", "HIP 50636"},
        {"Smithsonian Astrophysical Observation", "SAO 178705"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.13539293),
        dec: Angle.Degrees(-23.64438579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123968"},
        {"Hipparcos Number", "HIP 69319"},
        {"Smithsonian Astrophysical Observation", "SAO 182320"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.81690427),
        dec: Angle.Degrees(-23.64202611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89694"},
        {"Hipparcos Number", "HIP 50638"},
        {"Smithsonian Astrophysical Observation", "SAO 178706"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.13878270),
        dec: Angle.Degrees(-23.64038241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207361"},
        {"Hipparcos Number", "HIP 107691"},
        {"Smithsonian Astrophysical Observation", "SAO 190650"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.22739901),
        dec: Angle.Degrees(-23.63874604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173178"},
        {"Hipparcos Number", "HIP 91993"},
        {"Smithsonian Astrophysical Observation", "SAO 187224"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.25179964),
        dec: Angle.Degrees(-23.63827984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44379"},
        {"Hipparcos Number", "HIP 30141"},
        {"Smithsonian Astrophysical Observation", "SAO 171602"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.14654493),
        dec: Angle.Degrees(-23.63780374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69274"},
        {"Hipparcos Number", "HIP 40435"},
        {"Smithsonian Astrophysical Observation", "SAO 175461"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.85192612),
        dec: Angle.Degrees(-23.63777591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103991"},
        {"Hipparcos Number", "HIP 58397"},
        {"Geneva Identification System", "GEN# +1.00103991"},
        {"Smithsonian Astrophysical Observation", "SAO 180345"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.61692223),
        dec: Angle.Degrees(-23.63611184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -290.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20894"},
        {"Hipparcos Number", "HIP 15643"},
        {"Geneva Identification System", "GEN# +1.00020894"},
        {"Smithsonian Astrophysical Observation", "SAO 168482"},
        {"Wilson Evans Batten Catalogue", "WEB 3001"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.35010618),
        dec: Angle.Degrees(-23.63508924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14496"},
        {"Hipparcos Number", "HIP 10870"},
        {"Smithsonian Astrophysical Observation", "SAO 167707"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.97311596),
        dec: Angle.Degrees(-23.63460286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 732"},
        {"Hipparcos Number", "HIP 937"},
        {"Geneva Identification System", "GEN# +1.00000732"},
        {"Smithsonian Astrophysical Observation", "SAO 166104"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90159981),
        dec: Angle.Degrees(-23.63236655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1667"},
        {"Hipparcos Number", "HIP 1660"},
        {"Geneva Identification System", "GEN# +1.00001667"},
        {"Smithsonian Astrophysical Observation", "SAO 166201"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.20240471),
        dec: Angle.Degrees(-23.63022915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38498"},
        {"Hipparcos Number", "HIP 27143"},
        {"Smithsonian Astrophysical Observation", "SAO 170784"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.32020785),
        dec: Angle.Degrees(-23.63022044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22067"},
        {"Hipparcos Number", "HIP 16510"},
        {"Geneva Identification System", "GEN# +1.00022067"},
        {"Smithsonian Astrophysical Observation", "SAO 168620"},
    },
    visualMagnitude: 9.96,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.14765955),
        dec: Angle.Degrees(-23.62879898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30051"},
        {"Hipparcos Number", "HIP 21965"},
        {"Fundamental Katalog 5th Edition", "FK5 4425"},
        {"Geneva Identification System", "GEN# +1.00030051"},
        {"Smithsonian Astrophysical Observation", "SAO 169694"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.82155014),
        dec: Angle.Degrees(-23.62831614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14285"},
        {"Hipparcos Number", "HIP 10728"},
        {"Geneva Identification System", "GEN# +1.00014285"},
        {"Smithsonian Astrophysical Observation", "SAO 167689"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.51572079),
        dec: Angle.Degrees(-23.62796964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201286"},
        {"Hipparcos Number", "HIP 104423"},
        {"Smithsonian Astrophysical Observation", "SAO 190061"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.30050385),
        dec: Angle.Degrees(-23.62685943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41952"},
        {"Smithsonian Astrophysical Observation", "SAO 176060"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.27101296),
        dec: Angle.Degrees(-23.62494193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92441"},
        {"Hipparcos Number", "HIP 52210"},
        {"Geneva Identification System", "GEN# +1.00092441"},
        {"Smithsonian Astrophysical Observation", "SAO 179095"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.00005271),
        dec: Angle.Degrees(-23.62464193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114345"},
        {"Hipparcos Number", "HIP 64271"},
        {"Smithsonian Astrophysical Observation", "SAO 181426"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58855100),
        dec: Angle.Degrees(-23.62464004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18978"},
        {"Hipparcos Number", "HIP 14146"},
        {"Fundamental Katalog 5th Edition", "FK5 1085"},
        {"Geneva Identification System", "GEN# +1.00018978"},
        {"Renson", "Renson 4760"},
        {"Smithsonian Astrophysical Observation", "SAO 168249"},
        {"Wilson Evans Batten Catalogue", "WEB 2783"},
    },
    visualMagnitude: 4.08,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.59830468),
        dec: Angle.Degrees(-23.62433613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159395"},
        {"Hipparcos Number", "HIP 86082"},
        {"Smithsonian Astrophysical Observation", "SAO 185530"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.88185394),
        dec: Angle.Degrees(-23.62087721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95124",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Belel"},
        {"Henry Draper", "HD 181342"},
        {"Hipparcos Number", "HIP 95124"},
        {"Smithsonian Astrophysical Observation", "SAO 188005"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.26775067),
        dec: Angle.Degrees(-23.61949568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204332"},
        {"Hipparcos Number", "HIP 106025"},
        {"Smithsonian Astrophysical Observation", "SAO 190366"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.11781954),
        dec: Angle.Degrees(-23.61810444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6618 AB"},
        {"Henry Draper", "HD 67698"},
        {"Hipparcos Number", "HIP 39834"},
        {"Geneva Identification System", "GEN# +1.00067698J"},
        {"Smithsonian Astrophysical Observation", "SAO 175239"},
        {"Wilson Evans Batten Catalogue", "WEB 7767"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.08068343),
        dec: Angle.Degrees(-23.61779673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154000"},
        {"Hipparcos Number", "HIP 83488"},
        {"Smithsonian Astrophysical Observation", "SAO 184974"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.95196554),
        dec: Angle.Degrees(-23.61761533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209227"},
        {"Hipparcos Number", "HIP 108785"},
        {"Smithsonian Astrophysical Observation", "SAO 190841"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.55465061),
        dec: Angle.Degrees(-23.61661667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118412"},
        {"Hipparcos Number", "HIP 66433"},
        {"Geneva Identification System", "GEN# +1.00118412"},
        {"Smithsonian Astrophysical Observation", "SAO 181797"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.29411585),
        dec: Angle.Degrees(-23.61589161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204161"},
        {"Hipparcos Number", "HIP 105948"},
        {"Smithsonian Astrophysical Observation", "SAO 190353"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.85503694),
        dec: Angle.Degrees(-23.61586911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16 AB"},
        {"Henry Draper", "HD 225089"},
        {"Hipparcos Number", "HIP 261"},
        {"Smithsonian Astrophysical Observation", "SAO 166019"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.82050122),
        dec: Angle.Degrees(-23.61534569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314031"},
        {"Hipparcos Number", "HIP 88995"},
        {"Geneva Identification System", "GEN# +1.00314031"},
        {"Smithsonian Astrophysical Observation", "SAO 186385"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.46511400),
        dec: Angle.Degrees(-23.61425829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105368"},
        {"Geneva Identification System", "GEN# -0.02416586"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.13606921),
        dec: Angle.Degrees(-23.60654135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -416.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144334"},
        {"Hipparcos Number", "HIP 78877"},
        {"Geneva Identification System", "GEN# +1.00144334"},
        {"Renson", "Renson 40900"},
        {"Smithsonian Astrophysical Observation", "SAO 184113"},
        {"Wilson Evans Batten Catalogue", "WEB 13333"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.52660087),
        dec: Angle.Degrees(-23.60624433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18535"},
        {"Hipparcos Number", "HIP 13835"},
        {"Geneva Identification System", "GEN# +1.00018535"},
        {"Smithsonian Astrophysical Observation", "SAO 168191"},
        {"Wilson Evans Batten Catalogue", "WEB 2737"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.52369967),
        dec: Angle.Degrees(-23.60613828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224181"},
        {"Hipparcos Number", "HIP 117981"},
        {"Geneva Identification System", "GEN# +1.00224181"},
        {"Smithsonian Astrophysical Observation", "SAO 192244"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.95783489),
        dec: Angle.Degrees(-23.60515767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10132"},
        {"Smithsonian Astrophysical Observation", "SAO 167608"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.57340546),
        dec: Angle.Degrees(-23.60313342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1553 AB"},
        {"Henry Draper", "HD 11953"},
        {"Hipparcos Number", "HIP 9071"},
        {"Smithsonian Astrophysical Observation", "SAO 167420"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.19274395),
        dec: Angle.Degrees(-23.60307454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105850"},
        {"Hipparcos Number", "HIP 59394"},
        {"Geneva Identification System", "GEN# +1.00105850"},
        {"Smithsonian Astrophysical Observation", "SAO 180546"},
        {"Wilson Evans Batten Catalogue", "WEB 10563"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.76617138),
        dec: Angle.Degrees(-23.60237239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91352"},
        {"Hipparcos Number", "HIP 51598"},
        {"Smithsonian Astrophysical Observation", "SAO 178948"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.10298933),
        dec: Angle.Degrees(-23.60181607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10701"},
        {"Hipparcos Number", "HIP 8104"},
        {"Geneva Identification System", "GEN# +1.00010701"},
        {"Smithsonian Astrophysical Observation", "SAO 167261"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.02448268),
        dec: Angle.Degrees(-23.60073743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3581"},
        {"Hipparcos Number", "HIP 3035"},
        {"Geneva Identification System", "GEN# +1.00003581"},
        {"Smithsonian Astrophysical Observation", "SAO 166439"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.65067436),
        dec: Angle.Degrees(-23.59913798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52567"},
        {"Hipparcos Number", "HIP 33778"},
        {"Celescope Catalog", "CEL 1505"},
    },
    visualMagnitude: 9.32,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21311614),
        dec: Angle.Degrees(-23.59663042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44735"},
        {"Hipparcos Number", "HIP 30302"},
        {"Renson", "Renson 11847"},
        {"Smithsonian Astrophysical Observation", "SAO 171644"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.60200911),
        dec: Angle.Degrees(-23.59341692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6504"},
        {"Hipparcos Number", "HIP 5137"},
        {"Geneva Identification System", "GEN# +1.00006504"},
        {"Smithsonian Astrophysical Observation", "SAO 166791"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.44957957),
        dec: Angle.Degrees(-23.59302823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17298"},
        {"Hipparcos Number", "HIP 12913"},
        {"Smithsonian Astrophysical Observation", "SAO 168032"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.50799327),
        dec: Angle.Degrees(-23.59229310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83953"},
        {"Hipparcos Number", "HIP 47522"},
        {"Geneva Identification System", "GEN# +1.00083953A"},
        {"Smithsonian Astrophysical Observation", "SAO 177840"},
        {"Wilson Evans Batten Catalogue", "WEB 8914"},
    },
    visualMagnitude: 4.76,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.32094152),
        dec: Angle.Degrees(-23.59152139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191033"},
        {"Hipparcos Number", "HIP 99229"},
        {"Geneva Identification System", "GEN# +1.00191033"},
        {"Smithsonian Astrophysical Observation", "SAO 188948"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14968868),
        dec: Angle.Degrees(-23.59028329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114039"},
        {"Hipparcos Number", "HIP 64095"},
        {"Geneva Identification System", "GEN# +1.00114039"},
        {"Smithsonian Astrophysical Observation", "SAO 181400"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.03034314),
        dec: Angle.Degrees(-23.58859409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314531"},
        {"Hipparcos Number", "HIP 90085"},
        {"Smithsonian Astrophysical Observation", "SAO 186741"},
    },
    visualMagnitude: 9.35,
    bvColour: 2.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76093557),
        dec: Angle.Degrees(-23.58267421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203864"},
        {"Hipparcos Number", "HIP 105789"},
        {"Smithsonian Astrophysical Observation", "SAO 190320"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.36982596),
        dec: Angle.Degrees(-23.58112990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47579"},
        {"Henry Draper 2", "HD 47580"},
        {"Hipparcos Number", "HIP 31736"},
        {"Geneva Identification System", "GEN# +1.00047579"},
        {"Smithsonian Astrophysical Observation", "SAO 172068"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.59545789),
        dec: Angle.Degrees(-23.58030165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4973"},
        {"Hipparcos Number", "HIP 4020"},
        {"Geneva Identification System", "GEN# +1.00004973"},
        {"Smithsonian Astrophysical Observation", "SAO 166630"},
        {"Wilson Evans Batten Catalogue", "WEB 720"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.88080220),
        dec: Angle.Degrees(-23.57940815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176718"},
        {"Hipparcos Number", "HIP 93508"},
        {"Smithsonian Astrophysical Observation", "SAO 187601"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.65738380),
        dec: Angle.Degrees(-23.57921993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14989"},
        {"Smithsonian Astrophysical Observation", "SAO 168388"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.29461696),
        dec: Angle.Degrees(-23.57693682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183763"},
        {"Hipparcos Number", "HIP 96067"},
        {"Smithsonian Astrophysical Observation", "SAO 188245"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.99354909),
        dec: Angle.Degrees(-23.57603121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33666"},
        {"Hipparcos Number", "HIP 24123"},
        {"Smithsonian Astrophysical Observation", "SAO 170152"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.71751276),
        dec: Angle.Degrees(-23.57420406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157073"},
        {"Hipparcos Number", "HIP 84980"},
        {"Smithsonian Astrophysical Observation", "SAO 185322"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.52652599),
        dec: Angle.Degrees(-23.57385506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102837"},
        {"Smithsonian Astrophysical Observation", "SAO 189748"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.50700617),
        dec: Angle.Degrees(-23.57290908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84428"},
        {"Hipparcos Number", "HIP 47798"},
        {"Geneva Identification System", "GEN# +1.00084428"},
        {"Smithsonian Astrophysical Observation", "SAO 177917"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.16363314),
        dec: Angle.Degrees(-23.57275989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6318"},
        {"Smithsonian Astrophysical Observation", "SAO 166979"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28629306),
        dec: Angle.Degrees(-23.57174034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170017"},
        {"Hipparcos Number", "HIP 90523"},
        {"Smithsonian Astrophysical Observation", "SAO 186854"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.07130723),
        dec: Angle.Degrees(-23.56868875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166191"},
        {"Hipparcos Number", "HIP 89046"},
        {"Geneva Identification System", "GEN# +1.00166191"},
        {"Smithsonian Astrophysical Observation", "SAO 186404"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.62642472),
        dec: Angle.Degrees(-23.56664417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12975"},
        {"Hipparcos Number", "HIP 9831"},
        {"Smithsonian Astrophysical Observation", "SAO 167556"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62724480),
        dec: Angle.Degrees(-23.56658100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88110"},
        {"Hipparcos Number", "HIP 49725"},
        {"Smithsonian Astrophysical Observation", "SAO 178471"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28264965),
        dec: Angle.Degrees(-23.56655492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314178"},
        {"Hipparcos Number", "HIP 89503"},
        {"Smithsonian Astrophysical Observation", "SAO 186557"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.96246646),
        dec: Angle.Degrees(-23.56189035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110110"},
        {"Hipparcos Number", "HIP 61794"},
        {"Smithsonian Astrophysical Observation", "SAO 180999"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.97744542),
        dec: Angle.Degrees(-23.56095742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20900"},
    },
    visualMagnitude: 12.02,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.20549724),
        dec: Angle.Degrees(-23.55811726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180902"},
        {"Hipparcos Number", "HIP 94951"},
        {"Smithsonian Astrophysical Observation", "SAO 187961"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.82369479),
        dec: Angle.Degrees(-23.55810627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57012"},
        {"Hipparcos Number", "HIP 35373"},
        {"Smithsonian Astrophysical Observation", "SAO 173436"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.61289197),
        dec: Angle.Degrees(-23.55744807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96483"},
        {"Hipparcos Number", "HIP 54329"},
        {"Geneva Identification System", "GEN# +1.00096483"},
        {"Smithsonian Astrophysical Observation", "SAO 179545"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.71457135),
        dec: Angle.Degrees(-23.55576427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103461"},
        {"Hipparcos Number", "HIP 58089"},
        {"Geneva Identification System", "GEN# +1.00103461"},
        {"Smithsonian Astrophysical Observation", "SAO 180290"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.70100198),
        dec: Angle.Degrees(-23.55017167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52045"},
        {"Smithsonian Astrophysical Observation", "SAO 179058"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.52600737),
        dec: Angle.Degrees(-23.54967568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92844"},
        {"Hipparcos Number", "HIP 52414"},
        {"Smithsonian Astrophysical Observation", "SAO 179147"},
        {"Wilson Evans Batten Catalogue", "WEB 9541"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.71803768),
        dec: Angle.Degrees(-23.54903195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60922"},
        {"Hipparcos Number", "HIP 36961"},
        {"Smithsonian Astrophysical Observation", "SAO 174083"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.97653764),
        dec: Angle.Degrees(-23.54870168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115250"},
        {"Hipparcos Number", "HIP 64753"},
        {"Smithsonian Astrophysical Observation", "SAO 181502"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.06202668),
        dec: Angle.Degrees(-23.54859315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101306"},
        {"Geneva Identification System", "GEN# -0.02316310"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.01329940),
        dec: Angle.Degrees(-23.54779087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109334"},
        {"Hipparcos Number", "HIP 61336"},
        {"Smithsonian Astrophysical Observation", "SAO 180908"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.52027540),
        dec: Angle.Degrees(-23.54601318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87792"},
        {"Hipparcos Number", "HIP 49543"},
        {"Geneva Identification System", "GEN# +1.00087792"},
        {"Smithsonian Astrophysical Observation", "SAO 178428"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.73564635),
        dec: Angle.Degrees(-23.54338843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121138"},
        {"Hipparcos Number", "HIP 67868"},
        {"Smithsonian Astrophysical Observation", "SAO 182059"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.51103108),
        dec: Angle.Degrees(-23.54288556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135029"},
        {"Hipparcos Number", "HIP 74529"},
        {"Smithsonian Astrophysical Observation", "SAO 183282"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.44219400),
        dec: Angle.Degrees(-23.54081479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13920"},
        {"Hipparcos Number", "HIP 10474"},
        {"Geneva Identification System", "GEN# +1.00013920"},
        {"Smithsonian Astrophysical Observation", "SAO 167654"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.75876615),
        dec: Angle.Degrees(-23.54053414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72366"},
        {"Hipparcos Number", "HIP 41829"},
        {"Smithsonian Astrophysical Observation", "SAO 176005"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.91761248),
        dec: Angle.Degrees(-23.53899742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140"},
        {"Hipparcos Number", "HIP 514"},
        {"Geneva Identification System", "GEN# +1.00000140"},
        {"Smithsonian Astrophysical Observation", "SAO 166044"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.54892826),
        dec: Angle.Degrees(-23.53856546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57823"},
        {"Hipparcos Number", "HIP 35701"},
        {"Smithsonian Astrophysical Observation", "SAO 173557"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.49348014),
        dec: Angle.Degrees(-23.53802877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51155"},
        {"Hipparcos Number", "HIP 33276"},
        {"Celescope Catalog", "CEL 1438"},
        {"Geneva Identification System", "GEN# +1.00051155"},
    },
    visualMagnitude: 9.50,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.82591841),
        dec: Angle.Degrees(-23.53795232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90324"},
        {"Hipparcos Number", "HIP 51012"},
        {"Smithsonian Astrophysical Observation", "SAO 178797"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.32015597),
        dec: Angle.Degrees(-23.53771035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196032"},
        {"Hipparcos Number", "HIP 101601"},
        {"Smithsonian Astrophysical Observation", "SAO 189467"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.86888089),
        dec: Angle.Degrees(-23.53593480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27165"},
        {"Hipparcos Number", "HIP 19924"},
        {"Smithsonian Astrophysical Observation", "SAO 169289"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.12194722),
        dec: Angle.Degrees(-23.53390626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44116"},
        {"Hipparcos Number", "HIP 30022"},
        {"Smithsonian Astrophysical Observation", "SAO 171556"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.76339203),
        dec: Angle.Degrees(-23.53352128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58485"},
        {"Smithsonian Astrophysical Observation", "SAO 180359"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.90921932),
        dec: Angle.Degrees(-23.52914646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142884"},
        {"Hipparcos Number", "HIP 78183"},
        {"Celescope Catalog", "CEL 4408"},
        {"Geneva Identification System", "GEN# +1.00142884"},
        {"Renson", "Renson 40510"},
        {"Smithsonian Astrophysical Observation", "SAO 183973"},
        {"Wilson Evans Batten Catalogue", "WEB 13221"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.45336418),
        dec: Angle.Degrees(-23.52726145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3865"},
        {"Hipparcos Number", "HIP 3230"},
        {"Geneva Identification System", "GEN# +1.00003865"},
        {"Smithsonian Astrophysical Observation", "SAO 166483"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.27759250),
        dec: Angle.Degrees(-23.52598336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76296"},
        {"Hipparcos Number", "HIP 43736"},
        {"Geneva Identification System", "GEN# +1.00076296"},
        {"Smithsonian Astrophysical Observation", "SAO 176679"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.62343125),
        dec: Angle.Degrees(-23.52189832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16270"},
        {"Hipparcos Number", "HIP 12110"},
        {"Geneva Identification System", "GEN# +1.00016270"},
        {"Smithsonian Astrophysical Observation", "SAO 167904"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.00301108),
        dec: Angle.Degrees(-23.52135802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214813"},
        {"Hipparcos Number", "HIP 111992"},
        {"Geneva Identification System", "GEN# +1.00214813"},
        {"Smithsonian Astrophysical Observation", "SAO 191323"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.26788793),
        dec: Angle.Degrees(-23.52115663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20520"},
        {"Hipparcos Number", "HIP 15291"},
        {"Smithsonian Astrophysical Observation", "SAO 168441"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.32253088),
        dec: Angle.Degrees(-23.52028242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22472"},
        {"Hipparcos Number", "HIP 16783"},
        {"Smithsonian Astrophysical Observation", "SAO 168669"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.99714852),
        dec: Angle.Degrees(-23.51803212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165204"},
        {"Hipparcos Number", "HIP 88631"},
        {"Geneva Identification System", "GEN# +1.00165204"},
        {"Smithsonian Astrophysical Observation", "SAO 186260"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.44465846),
        dec: Angle.Degrees(-23.51721227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77749"},
        {"Hipparcos Number", "HIP 44479"},
        {"Smithsonian Astrophysical Observation", "SAO 176894"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.93906146),
        dec: Angle.Degrees(-23.51649147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109310"},
        {"Hipparcos Number", "HIP 61323"},
        {"Geneva Identification System", "GEN# +1.00109310"},
        {"Smithsonian Astrophysical Observation", "SAO 180901"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.45415638),
        dec: Angle.Degrees(-23.51546512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132076"},
        {"Hipparcos Number", "HIP 73222"},
        {"Smithsonian Astrophysical Observation", "SAO 183050"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.46682300),
        dec: Angle.Degrees(-23.51344862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120954"},
        {"Hipparcos Number", "HIP 67777"},
        {"Geneva Identification System", "GEN# +1.00120954"},
        {"Smithsonian Astrophysical Observation", "SAO 182048"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.27922554),
        dec: Angle.Degrees(-23.51320657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152534"},
        {"Hipparcos Number", "HIP 82758"},
        {"Smithsonian Astrophysical Observation", "SAO 184786"},
        {"Wilson Evans Batten Catalogue", "WEB 13987"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.71176412),
        dec: Angle.Degrees(-23.51228392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68798"},
        {"Hipparcos Number", "HIP 40246"},
        {"Smithsonian Astrophysical Observation", "SAO 175401"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.30399283),
        dec: Angle.Degrees(-23.51206737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192547"},
        {"Hipparcos Number", "HIP 99903"},
        {"Geneva Identification System", "GEN# +1.00192547"},
        {"Smithsonian Astrophysical Observation", "SAO 189085"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.04872778),
        dec: Angle.Degrees(-23.51013825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140633"},
        {"Hipparcos Number", "HIP 77177"},
        {"Smithsonian Astrophysical Observation", "SAO 183759"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.37191373),
        dec: Angle.Degrees(-23.50939695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137076"},
        {"Hipparcos Number", "HIP 75450"},
        {"Geneva Identification System", "GEN# +1.00137076"},
        {"Smithsonian Astrophysical Observation", "SAO 183443"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.21113488),
        dec: Angle.Degrees(-23.50913608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82450"},
        {"Hipparcos Number", "HIP 46727"},
        {"Smithsonian Astrophysical Observation", "SAO 177602"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.87201083),
        dec: Angle.Degrees(-23.50590391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171961"},
        {"Hipparcos Number", "HIP 91405"},
        {"Geneva Identification System", "GEN# +1.00171961"},
        {"Smithsonian Astrophysical Observation", "SAO 187080"},
        {"Wilson Evans Batten Catalogue", "WEB 15709"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.62798112),
        dec: Angle.Degrees(-23.50484560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31385"},
        {"Hipparcos Number", "HIP 22813"},
        {"Smithsonian Astrophysical Observation", "SAO 169873"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.62293113),
        dec: Angle.Degrees(-23.50440668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222920"},
        {"Hipparcos Number", "HIP 117142"},
        {"Smithsonian Astrophysical Observation", "SAO 192127"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.22113757),
        dec: Angle.Degrees(-23.50409835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52778"},
        {"Hipparcos Number", "HIP 33853"},
        {"Smithsonian Astrophysical Observation", "SAO 172789"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.41502903),
        dec: Angle.Degrees(-23.50144054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84272"},
        {"Smithsonian Astrophysical Observation", "SAO 185171"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.40729163),
        dec: Angle.Degrees(-23.50078046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147681"},
        {"Hipparcos Number", "HIP 80355"},
        {"Smithsonian Astrophysical Observation", "SAO 184362"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.05398406),
        dec: Angle.Degrees(-23.50025659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7896"},
        {"Hipparcos Number", "HIP 6100"},
        {"Geneva Identification System", "GEN# +1.00007896"},
        {"Smithsonian Astrophysical Observation", "SAO 166937"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.57904746),
        dec: Angle.Degrees(-23.49960297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8853"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.46552853),
        dec: Angle.Degrees(-23.49784633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79815"},
        {"Hipparcos Number", "HIP 45440"},
        {"Smithsonian Astrophysical Observation", "SAO 177175"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.90538115),
        dec: Angle.Degrees(-23.49292585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2998"},
        {"Hipparcos Number", "HIP 2598"},
        {"Geneva Identification System", "GEN# +1.00002998"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.24997718),
        dec: Angle.Degrees(-23.49159603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59191"},
        {"Hipparcos Number", "HIP 36256"},
        {"Geneva Identification System", "GEN# +1.00059191"},
        {"Smithsonian Astrophysical Observation", "SAO 173792"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.98177816),
        dec: Angle.Degrees(-23.48970321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56094"},
        {"Hipparcos Number", "HIP 35026"},
        {"Celescope Catalog", "CEL 1705"},
        {"Geneva Identification System", "GEN# +1.00056094"},
        {"Smithsonian Astrophysical Observation", "SAO 173280"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.67543628),
        dec: Angle.Degrees(-23.48940836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2443"},
        {"Smithsonian Astrophysical Observation", "SAO 166326"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76981718),
        dec: Angle.Degrees(-23.48753752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4085"},
        {"Smithsonian Astrophysical Observation", "SAO 166642"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.10141747),
        dec: Angle.Degrees(-23.48448955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84473"},
        {"Hipparcos Number", "HIP 47828"},
        {"Smithsonian Astrophysical Observation", "SAO 177926"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.23391618),
        dec: Angle.Degrees(-23.48445891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3186"},
        {"Hipparcos Number", "HIP 2741"},
        {"Geneva Identification System", "GEN# +1.00003186"},
        {"Smithsonian Astrophysical Observation", "SAO 166379"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75185634),
        dec: Angle.Degrees(-23.48295902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102887"},
        {"Hipparcos Number", "HIP 57750"},
        {"Smithsonian Astrophysical Observation", "SAO 180231"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.65730892),
        dec: Angle.Degrees(-23.48241702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7312 A"},
        {"Henry Draper", "HD 80618"},
        {"Hipparcos Number", "HIP 45792"},
    },
    visualMagnitude: 12.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)20, 15.9300),
        dec: Angle.DegreesMinutesSeconds((int)-23, (int)28, 45.100)
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
    primaryId: "HIP 100386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193545"},
        {"Hipparcos Number", "HIP 100386"},
        {"Smithsonian Astrophysical Observation", "SAO 189192"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37485345),
        dec: Angle.Degrees(-23.47601833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21737"},
        {"Hipparcos Number", "HIP 16261"},
        {"Geneva Identification System", "GEN# +1.00021737"},
        {"Smithsonian Astrophysical Observation", "SAO 168582"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.39584209),
        dec: Angle.Degrees(-23.47581001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194063"},
        {"Hipparcos Number", "HIP 100633"},
        {"Geneva Identification System", "GEN# +1.00194063"},
        {"Smithsonian Astrophysical Observation", "SAO 189244"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.08164407),
        dec: Angle.Degrees(-23.47577369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9024 A"},
        {"Henry Draper", "HD 120013"},
        {"Hipparcos Number", "HIP 67267"},
        {"Smithsonian Astrophysical Observation", "SAO 181955"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80221289),
        dec: Angle.Degrees(-23.47527151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197969"},
        {"Hipparcos Number", "HIP 102636"},
        {"Smithsonian Astrophysical Observation", "SAO 189703"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.95570783),
        dec: Angle.Degrees(-23.47518259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36817",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6190 AB"},
        {"Hipparcos Number", "HIP 36817"},
        {"Geneva Identification System", "GEN# +1.00060584"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57780754),
        dec: Angle.Degrees(-23.47366319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135844"},
        {"Hipparcos Number", "HIP 74870"},
        {"Smithsonian Astrophysical Observation", "SAO 183352"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.51096543),
        dec: Angle.Degrees(-23.47186461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197320"},
        {"Hipparcos Number", "HIP 102298"},
        {"Geneva Identification System", "GEN# +1.00197320"},
        {"Smithsonian Astrophysical Observation", "SAO 189617"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.91402788),
        dec: Angle.Degrees(-23.47016748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14388"},
        {"Smithsonian Astrophysical Observation", "SAO 168293"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.40087440),
        dec: Angle.Degrees(-23.46873280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131293"},
        {"Hipparcos Number", "HIP 72839"},
        {"Geneva Identification System", "GEN# +1.00131293"},
        {"Smithsonian Astrophysical Observation", "SAO 182963"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.32526793),
        dec: Angle.Degrees(-23.46859726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37065"},
        {"Hipparcos Number", "HIP 26175"},
        {"Cincinnati Publication", "Ci 20 337"},
        {"Geneva Identification System", "GEN# +1.00037065"},
        {"Smithsonian Astrophysical Observation", "SAO 170574"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.70174186),
        dec: Angle.Degrees(-23.46793027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 318.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -433.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90093"},
        {"Hipparcos Number", "HIP 50897"},
        {"Geneva Identification System", "GEN# +1.00090093"},
        {"Smithsonian Astrophysical Observation", "SAO 178766"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.90325483),
        dec: Angle.Degrees(-23.46724776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64857"},
        {"Hipparcos Number", "HIP 38668"},
        {"Smithsonian Astrophysical Observation", "SAO 174790"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.75251196),
        dec: Angle.Degrees(-23.46537818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138487"},
        {"Hipparcos Number", "HIP 76155"},
        {"Smithsonian Astrophysical Observation", "SAO 183568"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.31569898),
        dec: Angle.Degrees(-23.46506437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9019"},
        {"Hipparcos Number", "HIP 6876"},
        {"Geneva Identification System", "GEN# +1.00009019"},
        {"Smithsonian Astrophysical Observation", "SAO 167072"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.12297597),
        dec: Angle.Degrees(-23.46308687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49001"},
        {"Hipparcos Number", "HIP 32368"},
        {"Geneva Identification System", "GEN# +1.00049001"},
        {"Smithsonian Astrophysical Observation", "SAO 172273"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.34740523),
        dec: Angle.Degrees(-23.46248865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70245"},
        {"Hipparcos Number", "HIP 40845"},
        {"Smithsonian Astrophysical Observation", "SAO 175616"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.02013514),
        dec: Angle.Degrees(-23.46190285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10049 DE"},
        {"Aitken 2", "ADS 10045"},
        {"Henry Draper", "HD 147888"},
        {"Hipparcos Number", "HIP 80461"},
        {"Geneva Identification System", "GEN# +1.00147888"},
        {"Smithsonian Astrophysical Observation", "SAO 184377"},
        {"Wilson Evans Batten Catalogue", "WEB 13609"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.35119780),
        dec: Angle.Degrees(-23.46016953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7376"},
        {"Smithsonian Astrophysical Observation", "SAO 167155"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.76308375),
        dec: Angle.Degrees(-23.46012851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52849"},
        {"Hipparcos Number", "HIP 33865"},
        {"Celescope Catalog", "CEL 1518"},
        {"Smithsonian Astrophysical Observation", "SAO 172796"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.44913916),
        dec: Angle.Degrees(-23.45907420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51761"},
        {"Hipparcos Number", "HIP 33491"},
        {"Smithsonian Astrophysical Observation", "SAO 172647"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.42576551),
        dec: Angle.Degrees(-23.45705007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205342"},
        {"Hipparcos Number", "HIP 106590"},
        {"Geneva Identification System", "GEN# +1.00205342"},
        {"Smithsonian Astrophysical Observation", "SAO 190469"},
        {"Wilson Evans Batten Catalogue", "WEB 19283"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.81627970),
        dec: Angle.Degrees(-23.45427827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2068"},
        {"Hipparcos Number", "HIP 1961"},
        {"Geneva Identification System", "GEN# +1.00002068A"},
        {"Smithsonian Astrophysical Observation", "SAO 166250"},
        {"Wilson Evans Batten Catalogue", "WEB 371"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.20132727),
        dec: Angle.Degrees(-23.45393844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224746"},
        {"Hipparcos Number", "HIP 24"},
        {"Smithsonian Astrophysical Observation", "SAO 192311"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.07604979),
        dec: Angle.Degrees(-23.45274913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220295"},
        {"Hipparcos Number", "HIP 115425"},
        {"Geneva Identification System", "GEN# +1.00220295"},
        {"Smithsonian Astrophysical Observation", "SAO 191853"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.71216208),
        dec: Angle.Degrees(-23.45172650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103580"},
        {"Hipparcos Number", "HIP 58151"},
        {"Smithsonian Astrophysical Observation", "SAO 180304"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.88322781),
        dec: Angle.Degrees(-23.45083243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4328"},
        {"Hipparcos Number", "HIP 3567"},
        {"Smithsonian Astrophysical Observation", "SAO 166541"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.39786431),
        dec: Angle.Degrees(-23.45039955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66800",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8994 AB"},
        {"Henry Draper", "HD 119086"},
        {"Hipparcos Number", "HIP 66800"},
        {"Fundamental Katalog 5th Edition", "FK5 1354"},
        {"Geneva Identification System", "GEN# +1.00119086J"},
        {"Smithsonian Astrophysical Observation", "SAO 181863"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.37859856),
        dec: Angle.Degrees(-23.44981182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217150"},
        {"Hipparcos Number", "HIP 113471"},
        {"Geneva Identification System", "GEN# +1.00217150"},
        {"Smithsonian Astrophysical Observation", "SAO 191543"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.69457916),
        dec: Angle.Degrees(-23.44924897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151705"},
        {"Hipparcos Number", "HIP 82376"},
        {"Fundamental Katalog 5th Edition", "FK5 5487"},
        {"Smithsonian Astrophysical Observation", "SAO 184687"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.49789704),
        dec: Angle.Degrees(-23.44819634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161887"},
        {"Hipparcos Number", "HIP 87216"},
        {"Smithsonian Astrophysical Observation", "SAO 185792"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.27711228),
        dec: Angle.Degrees(-23.44768105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9769"},
        {"Hipparcos Number", "HIP 7384"},
        {"Geneva Identification System", "GEN# +1.00009769"},
        {"Smithsonian Astrophysical Observation", "SAO 167157"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.78600416),
        dec: Angle.Degrees(-23.44763788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10049 AB"},
        {"Hipparcos Number", "HIP 80473"},
    },
    visualMagnitude: 4.57,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.39633811),
        dec: Angle.Degrees(-23.44711764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127457"},
        {"Hipparcos Number", "HIP 71080"},
        {"Geneva Identification System", "GEN# +1.00127457"},
        {"Smithsonian Astrophysical Observation", "SAO 182641"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.03273482),
        dec: Angle.Degrees(-23.44655591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56339",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8212 A"},
        {"Henry Draper", "HD 100375"},
        {"Hipparcos Number", "HIP 56339"},
        {"Smithsonian Astrophysical Observation", "SAO 179979"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.24142610),
        dec: Angle.Degrees(-23.44382372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158197"},
        {"Hipparcos Number", "HIP 85541"},
        {"Smithsonian Astrophysical Observation", "SAO 185440"},
    },
    visualMagnitude: 8.77,
    bvColour: 2.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.21621949),
        dec: Angle.Degrees(-23.44186491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120586"},
        {"Hipparcos Number", "HIP 67570"},
        {"Smithsonian Astrophysical Observation", "SAO 182016"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70019459),
        dec: Angle.Degrees(-23.44081313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191824"},
        {"Hipparcos Number", "HIP 99592"},
        {"Smithsonian Astrophysical Observation", "SAO 189024"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.16880924),
        dec: Angle.Degrees(-23.44070633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209628"},
        {"Hipparcos Number", "HIP 109037"},
        {"Geneva Identification System", "GEN# +1.00209628"},
        {"Smithsonian Astrophysical Observation", "SAO 190876"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.33111610),
        dec: Angle.Degrees(-23.43830156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12214"},
        {"Hipparcos Number", "HIP 9294"},
        {"Geneva Identification System", "GEN# +1.00012214"},
        {"Smithsonian Astrophysical Observation", "SAO 167462"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.85622208),
        dec: Angle.Degrees(-23.43649106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169657"},
        {"Hipparcos Number", "HIP 90400"},
        {"Smithsonian Astrophysical Observation", "SAO 186822"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.67379431),
        dec: Angle.Degrees(-23.43564598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93332"},
        {"Hipparcos Number", "HIP 52665"},
        {"Smithsonian Astrophysical Observation", "SAO 179205"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.53570684),
        dec: Angle.Degrees(-23.43258292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54551"},
        {"Hipparcos Number", "HIP 34429"},
        {"Celescope Catalog", "CEL 1607"},
        {"Geneva Identification System", "GEN# +1.00054551"},
        {"Smithsonian Astrophysical Observation", "SAO 173040"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.06163046),
        dec: Angle.Degrees(-23.43170671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7209"},
        {"Hipparcos Number", "HIP 5618"},
        {"Geneva Identification System", "GEN# +1.00007209"},
        {"Smithsonian Astrophysical Observation", "SAO 166868"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.03249408),
        dec: Angle.Degrees(-23.43147536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217170"},
        {"Hipparcos Number", "HIP 113473"},
        {"Smithsonian Astrophysical Observation", "SAO 191544"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.70383572),
        dec: Angle.Degrees(-23.43069469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36619"},
        {"Hipparcos Number", "HIP 25933"},
        {"Geneva Identification System", "GEN# +1.00036619"},
        {"Renson", "Renson 9545"},
        {"Smithsonian Astrophysical Observation", "SAO 170523"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.02136646),
        dec: Angle.Degrees(-23.42971593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3783"},
        {"Hipparcos Number", "HIP 3168"},
        {"Geneva Identification System", "GEN# +1.00003783"},
        {"Smithsonian Astrophysical Observation", "SAO 166471"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.10067401),
        dec: Angle.Degrees(-23.42947491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185467"},
        {"Hipparcos Number", "HIP 96760"},
        {"Geneva Identification System", "GEN# +1.00185467"},
        {"Smithsonian Astrophysical Observation", "SAO 188419"},
        {"Wilson Evans Batten Catalogue", "WEB 16973"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02977888),
        dec: Angle.Degrees(-23.42905463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91097"},
        {"Smithsonian Astrophysical Observation", "SAO 187003"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.73377292),
        dec: Angle.Degrees(-23.42809600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76101"},
        {"Smithsonian Astrophysical Observation", "SAO 183556"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.14121944),
        dec: Angle.Degrees(-23.42792805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12741 AB"},
        {"Henry Draper", "HD 185404"},
        {"Hipparcos Number", "HIP 96729"},
        {"Geneva Identification System", "GEN# +1.00185404"},
        {"Smithsonian Astrophysical Observation", "SAO 188407"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.95606457),
        dec: Angle.Degrees(-23.42761000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122065"},
        {"Hipparcos Number", "HIP 68391"},
        {"Smithsonian Astrophysical Observation", "SAO 182155"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01257850),
        dec: Angle.Degrees(-23.42719818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129272"},
        {"Hipparcos Number", "HIP 71901"},
        {"Smithsonian Astrophysical Observation", "SAO 182782"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.59741637),
        dec: Angle.Degrees(-23.42565915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24848"},
        {"Hipparcos Number", "HIP 18412"},
        {"Geneva Identification System", "GEN# +1.00024848"},
        {"Smithsonian Astrophysical Observation", "SAO 168971"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.04913046),
        dec: Angle.Degrees(-23.42532476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31125",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5176 A"},
        {"Henry Draper", "HD 46328"},
        {"Hipparcos Number", "HIP 31125"},
        {"Geneva Identification System", "GEN# +5.11210022"},
        {"Smithsonian Astrophysical Observation", "SAO 171895"},
        {"Wilson Evans Batten Catalogue", "WEB 6207"},
    },
    visualMagnitude: 4.34,
    bvColour: -0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.96403433),
        dec: Angle.Degrees(-23.41843727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120090"},
        {"Hipparcos Number", "HIP 67311"},
        {"Smithsonian Astrophysical Observation", "SAO 181961"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.93324018),
        dec: Angle.Degrees(-23.41833837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95385"},
        {"Hipparcos Number", "HIP 53800"},
        {"Smithsonian Astrophysical Observation", "SAO 179420"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.11337355),
        dec: Angle.Degrees(-23.41825225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41009",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6774 AB"},
        {"Henry Draper", "HD 70636"},
        {"Hipparcos Number", "HIP 41009"},
        {"Smithsonian Astrophysical Observation", "SAO 175683"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53800116),
        dec: Angle.Degrees(-23.41307961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28728"},
        {"Hipparcos Number", "HIP 21055"},
        {"Smithsonian Astrophysical Observation", "SAO 169526"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.70169160),
        dec: Angle.Degrees(-23.40780233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10049 C"},
        {"Henry Draper", "HD 147932"},
        {"Hipparcos Number", "HIP 80474"},
        {"Geneva Identification System", "GEN# +1.00147932"},
        {"Smithsonian Astrophysical Observation", "SAO 184383"},
        {"Wilson Evans Batten Catalogue", "WEB 13616"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.39619609),
        dec: Angle.Degrees(-23.40514716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80465"},
        {"Hipparcos Number", "HIP 45727"},
        {"Smithsonian Astrophysical Observation", "SAO 177274"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.83435831),
        dec: Angle.Degrees(-23.40405067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2008"},
        {"Hipparcos Number", "HIP 1915"},
        {"Geneva Identification System", "GEN# +1.00002008"},
        {"Smithsonian Astrophysical Observation", "SAO 166239"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.05538605),
        dec: Angle.Degrees(-23.40324634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6887"},
        {"Hipparcos Number", "HIP 5403"},
        {"Smithsonian Astrophysical Observation", "SAO 166839"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.28796203),
        dec: Angle.Degrees(-23.40251700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12933"},
        {"Hipparcos Number", "HIP 9801"},
        {"Smithsonian Astrophysical Observation", "SAO 167550"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.50980366),
        dec: Angle.Degrees(-23.40018652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171810"},
        {"Hipparcos Number", "HIP 91341"},
        {"Smithsonian Astrophysical Observation", "SAO 187068"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.45914852),
        dec: Angle.Degrees(-23.39684567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61359",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kraz"},
        {"Henry Draper", "HD 109379"},
        {"Hipparcos Number", "HIP 61359"},
        {"Fundamental Katalog 5th Edition", "FK5 471"},
        {"Geneva Identification System", "GEN# +1.00109379"},
        {"Smithsonian Astrophysical Observation", "SAO 180915"},
        {"Wilson Evans Batten Catalogue", "WEB 10920"},
    },
    visualMagnitude: 2.65,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.59680864),
        dec: Angle.Degrees(-23.39662306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114954"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.25011153),
        dec: Angle.Degrees(-23.39570599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 308.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125552"},
        {"Hipparcos Number", "HIP 70100"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.16679461),
        dec: Angle.Degrees(-23.39481969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45266"},
        {"Wilson Evans Batten Catalogue", "WEB 8624"},
    },
    visualMagnitude: 10.19,
    bvColour: 2.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.38269769),
        dec: Angle.Degrees(-23.39208627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154117"},
        {"Hipparcos Number", "HIP 83542"},
        {"Smithsonian Astrophysical Observation", "SAO 184992"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.11593201),
        dec: Angle.Degrees(-23.39049032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220341"},
        {"Hipparcos Number", "HIP 115447"},
        {"Geneva Identification System", "GEN# +1.00220341"},
        {"Smithsonian Astrophysical Observation", "SAO 191859"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.77191948),
        dec: Angle.Degrees(-23.39014179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86278",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10664 AB"},
        {"Henry Draper", "HD 159843"},
        {"Hipparcos Number", "HIP 86278"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.44522778),
        dec: Angle.Degrees(-23.38928643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75578"},
        {"Smithsonian Astrophysical Observation", "SAO 183471"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.58646304),
        dec: Angle.Degrees(-23.38885050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6079"},
        {"Hipparcos Number", "HIP 4817"},
        {"Smithsonian Astrophysical Observation", "SAO 166757"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.45334951),
        dec: Angle.Degrees(-23.38756388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1776"},
        {"Hipparcos Number", "HIP 1731"},
        {"Geneva Identification System", "GEN# +1.00001776"},
        {"Smithsonian Astrophysical Observation", "SAO 166212"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.46401695),
        dec: Angle.Degrees(-23.38643823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26536"},
        {"Hipparcos Number", "HIP 19524"},
        {"Smithsonian Astrophysical Observation", "SAO 169200"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.74132488),
        dec: Angle.Degrees(-23.38640211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67601"},
        {"Hipparcos Number", "HIP 39797"},
        {"Smithsonian Astrophysical Observation", "SAO 175227"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.98909672),
        dec: Angle.Degrees(-23.38371843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92098"},
        {"Hipparcos Number", "HIP 52011"},
        {"Smithsonian Astrophysical Observation", "SAO 179046"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.39925472),
        dec: Angle.Degrees(-23.38218735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18707"},
        {"Hipparcos Number", "HIP 13955"},
        {"Smithsonian Astrophysical Observation", "SAO 168210"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.92983438),
        dec: Angle.Degrees(-23.38167221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23507"},
        {"Hipparcos Number", "HIP 17500"},
        {"Smithsonian Astrophysical Observation", "SAO 168790"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21896749),
        dec: Angle.Degrees(-23.38045277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205649"},
        {"Hipparcos Number", "HIP 106743"},
        {"Smithsonian Astrophysical Observation", "SAO 190497"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.34732907),
        dec: Angle.Degrees(-23.37572264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77407"},
        {"Smithsonian Astrophysical Observation", "SAO 183806"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.03887238),
        dec: Angle.Degrees(-23.37338254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161945"},
        {"Hipparcos Number", "HIP 87227"},
        {"Geneva Identification System", "GEN# +1.00161945"},
        {"Smithsonian Astrophysical Observation", "SAO 185799"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.33604752),
        dec: Angle.Degrees(-23.36914957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14002"},
        {"Hipparcos Number", "HIP 10522"},
        {"Smithsonian Astrophysical Observation", "SAO 167661"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.89872818),
        dec: Angle.Degrees(-23.36885399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142424"},
        {"Hipparcos Number", "HIP 77960"},
        {"Smithsonian Astrophysical Observation", "SAO 183927"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.82331354),
        dec: Angle.Degrees(-23.36764094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212432"},
        {"Hipparcos Number", "HIP 110616"},
        {"Geneva Identification System", "GEN# +1.00212432"},
        {"Renson", "Renson 58920"},
        {"Smithsonian Astrophysical Observation", "SAO 191117"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.14124693),
        dec: Angle.Degrees(-23.36744094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174776"},
        {"Hipparcos Number", "HIP 92685"},
        {"Smithsonian Astrophysical Observation", "SAO 187404"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.29289224),
        dec: Angle.Degrees(-23.36699556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83118"},
        {"Smithsonian Astrophysical Observation", "SAO 184875"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.77880728),
        dec: Angle.Degrees(-23.36660873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4772"},
        {"Hipparcos Number", "HIP 3858"},
        {"Geneva Identification System", "GEN# +1.00004772"},
        {"Smithsonian Astrophysical Observation", "SAO 166608"},
        {"Wilson Evans Batten Catalogue", "WEB 688"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.38932382),
        dec: Angle.Degrees(-23.36210931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84427"},
        {"Hipparcos Number", "HIP 47788"},
        {"Smithsonian Astrophysical Observation", "SAO 177915"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.14965612),
        dec: Angle.Degrees(-23.36159057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9621 AB"},
        {"Henry Draper", "HD 137094"},
        {"Hipparcos Number", "HIP 75454"},
        {"Smithsonian Astrophysical Observation", "SAO 183445"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.22433154),
        dec: Angle.Degrees(-23.35951731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70258"},
        {"Hipparcos Number", "HIP 40853"},
        {"Smithsonian Astrophysical Observation", "SAO 175621"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.04443575),
        dec: Angle.Degrees(-23.35928409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141106"},
        {"Hipparcos Number", "HIP 77406"},
        {"Smithsonian Astrophysical Observation", "SAO 183805"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.03654974),
        dec: Angle.Degrees(-23.35888957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72769"},
        {"Hipparcos Number", "HIP 42011"},
        {"Geneva Identification System", "GEN# +1.00072769"},
        {"Smithsonian Astrophysical Observation", "SAO 176080"},
        {"Wilson Evans Batten Catalogue", "WEB 8082"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.44135411),
        dec: Angle.Degrees(-23.35594816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -343.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59801",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8481 AB"},
        {"Henry Draper", "HD 106612"},
        {"Hipparcos Number", "HIP 59801"},
        {"Geneva Identification System", "GEN# +1.00106612"},
        {"Smithsonian Astrophysical Observation", "SAO 180617"},
        {"Smithsonian Astrophysical Observation 2", "SAO 180619"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.94460011),
        dec: Angle.Degrees(-23.35380508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83845"},
        {"Hipparcos Number", "HIP 47464"},
        {"Smithsonian Astrophysical Observation", "SAO 177825"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.13580370),
        dec: Angle.Degrees(-23.35227803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74758"},
        {"Hipparcos Number", "HIP 42933"},
        {"Smithsonian Astrophysical Observation", "SAO 176411"},
    },
    visualMagnitude: 9.39,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.25899248),
        dec: Angle.Degrees(-23.35193969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65863"},
        {"Hipparcos Number", "HIP 39108"},
        {"Smithsonian Astrophysical Observation", "SAO 174955"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.01275238),
        dec: Angle.Degrees(-23.35095916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160703"},
        {"Hipparcos Number", "HIP 86655"},
        {"Geneva Identification System", "GEN# +1.00160703"},
        {"Smithsonian Astrophysical Observation", "SAO 185634"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.58469590),
        dec: Angle.Degrees(-23.34932109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43137"},
        {"Hipparcos Number", "HIP 29560"},
        {"Smithsonian Astrophysical Observation", "SAO 171424"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42319372),
        dec: Angle.Degrees(-23.34916092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182816"},
        {"Hipparcos Number", "HIP 95645"},
        {"Geneva Identification System", "GEN# +1.00182816"},
        {"Smithsonian Astrophysical Observation", "SAO 188135"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.82697454),
        dec: Angle.Degrees(-23.34714833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82180"},
        {"Hipparcos Number", "HIP 46569"},
        {"Geneva Identification System", "GEN# +1.00082180"},
        {"Smithsonian Astrophysical Observation", "SAO 177541"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.45781856),
        dec: Angle.Degrees(-23.34533980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64428"},
        {"Smithsonian Astrophysical Observation", "SAO 181455"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.08779077),
        dec: Angle.Degrees(-23.33548231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14452"},
        {"Smithsonian Astrophysical Observation", "SAO 168307"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63699805),
        dec: Angle.Degrees(-23.33443523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165554"},
        {"Hipparcos Number", "HIP 88786"},
        {"Geneva Identification System", "GEN# +2.65460096"},
        {"Smithsonian Astrophysical Observation", "SAO 186307"},
        {"New General Catalogue", "NGC 6546 96"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.86695037),
        dec: Angle.Degrees(-23.33202656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82511"},
        {"Hipparcos Number", "HIP 46767"},
        {"Smithsonian Astrophysical Observation", "SAO 177607"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98045238),
        dec: Angle.Degrees(-23.33199713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211569"},
        {"Hipparcos Number", "HIP 110126"},
        {"Geneva Identification System", "GEN# +1.00211569"},
        {"Smithsonian Astrophysical Observation", "SAO 191039"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62020353),
        dec: Angle.Degrees(-23.33102909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188919"},
        {"Hipparcos Number", "HIP 98300"},
        {"Smithsonian Astrophysical Observation", "SAO 188769"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.59329408),
        dec: Angle.Degrees(-23.33009944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15856"},
        {"Hipparcos Number", "HIP 11820"},
        {"Smithsonian Astrophysical Observation", "SAO 167863"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.10775574),
        dec: Angle.Degrees(-23.32960333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145655"},
        {"Hipparcos Number", "HIP 79462"},
        {"Smithsonian Astrophysical Observation", "SAO 184229"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.23059090),
        dec: Angle.Degrees(-23.32930404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78320"},
        {"Hipparcos Number", "HIP 44730"},
        {"Smithsonian Astrophysical Observation", "SAO 176974"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.71679328),
        dec: Angle.Degrees(-23.32745943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184226"},
        {"Hipparcos Number", "HIP 96249"},
        {"Smithsonian Astrophysical Observation", "SAO 188290"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57235908),
        dec: Angle.Degrees(-23.32548289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150321"},
        {"Hipparcos Number", "HIP 81688"},
        {"Smithsonian Astrophysical Observation", "SAO 184544"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.30578850),
        dec: Angle.Degrees(-23.32411807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133604"},
        {"Hipparcos Number", "HIP 73900"},
        {"Geneva Identification System", "GEN# +1.00133604"},
        {"Smithsonian Astrophysical Observation", "SAO 183171"},
        {"Wilson Evans Batten Catalogue", "WEB 12622"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54778917),
        dec: Angle.Degrees(-23.32292388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203771"},
        {"Hipparcos Number", "HIP 105740"},
        {"Geneva Identification System", "GEN# +1.00203771"},
        {"Smithsonian Astrophysical Observation", "SAO 190309"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.25733616),
        dec: Angle.Degrees(-23.31852649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51324"},
        {"Geneva Identification System", "GEN# -0.02202926"},
        {"Smithsonian Astrophysical Observation", "SAO 178877"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.25553088),
        dec: Angle.Degrees(-23.31775657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170622"},
        {"Hipparcos Number", "HIP 90793"},
        {"Smithsonian Astrophysical Observation", "SAO 186912"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.83522447),
        dec: Angle.Degrees(-23.31567608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35210",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5951 A"},
        {"Henry Draper", "HD 56577"},
        {"Hipparcos Number", "HIP 35210"},
        {"Geneva Identification System", "GEN# +1.00056577A"},
        {"Smithsonian Astrophysical Observation", "SAO 173349"},
        {"Wilson Evans Batten Catalogue", "WEB 7032"},
    },
    visualMagnitude: 4.83,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.15348700),
        dec: Angle.Degrees(-23.31560155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64566"},
        {"Hipparcos Number", "HIP 38551"},
        {"Smithsonian Astrophysical Observation", "SAO 174742"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.41065895),
        dec: Angle.Degrees(-23.31372460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59963"},
        {"Smithsonian Astrophysical Observation", "SAO 180660"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17, 53.8300),
        dec: Angle.DegreesMinutesSeconds((int)-23, (int)18, 48.500)
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
    primaryId: "HIP 71626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128711"},
        {"Hipparcos Number", "HIP 71626"},
        {"Geneva Identification System", "GEN# +1.00128711"},
        {"Smithsonian Astrophysical Observation", "SAO 182732"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.73389566),
        dec: Angle.Degrees(-23.31166801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201496"},
        {"Hipparcos Number", "HIP 104549"},
        {"Geneva Identification System", "GEN# +1.00201496"},
        {"Smithsonian Astrophysical Observation", "SAO 190088"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.66920667),
        dec: Angle.Degrees(-23.31128161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35213",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5951 B"},
        {"Henry Draper", "HD 56578"},
        {"Hipparcos Number", "HIP 35213"},
        {"Geneva Identification System", "GEN# +1.00056578"},
        {"Renson", "Renson 15440"},
        {"Smithsonian Astrophysical Observation", "SAO 173353"},
        {"Wilson Evans Batten Catalogue", "WEB 7033"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.15990595),
        dec: Angle.Degrees(-23.31105320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65699"},
        {"Hipparcos Number", "HIP 39023"},
        {"Geneva Identification System", "GEN# +1.00065699"},
        {"Smithsonian Astrophysical Observation", "SAO 174932"},
        {"Wilson Evans Batten Catalogue", "WEB 7652"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77384363),
        dec: Angle.Degrees(-23.31040264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152189"},
        {"Hipparcos Number", "HIP 82576"},
        {"Smithsonian Astrophysical Observation", "SAO 184741"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.21193151),
        dec: Angle.Degrees(-23.30697477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20838"},
        {"Hipparcos Number", "HIP 15579"},
        {"Geneva Identification System", "GEN# +1.00020838"},
        {"Smithsonian Astrophysical Observation", "SAO 168473"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.17843162),
        dec: Angle.Degrees(-23.30651021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8867"},
        {"Hipparcos Number", "HIP 6766"},
        {"Smithsonian Astrophysical Observation", "SAO 167050"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.75959311),
        dec: Angle.Degrees(-23.30583252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112656"},
        {"Hipparcos Number", "HIP 63321"},
        {"Smithsonian Astrophysical Observation", "SAO 181279"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.64436653),
        dec: Angle.Degrees(-23.30392705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123383"},
        {"Hipparcos Number", "HIP 69022"},
        {"Geneva Identification System", "GEN# +1.00123383"},
        {"Smithsonian Astrophysical Observation", "SAO 182266"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.95269482),
        dec: Angle.Degrees(-23.29719048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209012"},
        {"Hipparcos Number", "HIP 108656"},
        {"Geneva Identification System", "GEN# +1.00209012"},
        {"Smithsonian Astrophysical Observation", "SAO 190820"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.17590330),
        dec: Angle.Degrees(-23.29702757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64299"},
        {"Hipparcos Number", "HIP 38435"},
        {"Geneva Identification System", "GEN# +1.00064299"},
        {"Smithsonian Astrophysical Observation", "SAO 174702"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.10630800),
        dec: Angle.Degrees(-23.29632617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32902"},
        {"Hipparcos Number", "HIP 23697"},
        {"Geneva Identification System", "GEN# +1.00032902"},
        {"Smithsonian Astrophysical Observation", "SAO 170056"},
        {"Wilson Evans Batten Catalogue", "WEB 4625"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.39092594),
        dec: Angle.Degrees(-23.29573406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213768"},
        {"Hipparcos Number", "HIP 111403"},
        {"Smithsonian Astrophysical Observation", "SAO 191230"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.53878536),
        dec: Angle.Degrees(-23.29313306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172623"},
        {"Hipparcos Number", "HIP 91722"},
        {"Smithsonian Astrophysical Observation", "SAO 187156"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.55953338),
        dec: Angle.Degrees(-23.29304434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208249"},
        {"Hipparcos Number", "HIP 108219"},
        {"Smithsonian Astrophysical Observation", "SAO 190737"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.86354682),
        dec: Angle.Degrees(-23.28942653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1513"},
        {"Smithsonian Astrophysical Observation", "SAO 166179"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.72315159),
        dec: Angle.Degrees(-23.28925029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31627"},
        {"Hipparcos Number", "HIP 22963"},
        {"Smithsonian Astrophysical Observation", "SAO 169905"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.11077403),
        dec: Angle.Degrees(-23.28804827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153743"},
        {"Hipparcos Number", "HIP 83356"},
        {"Geneva Identification System", "GEN# +1.00153743"},
        {"Smithsonian Astrophysical Observation", "SAO 184945"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.53632686),
        dec: Angle.Degrees(-23.28803240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61732"},
        {"Hipparcos Number", "HIP 37342"},
        {"Geneva Identification System", "GEN# +1.00061732"},
        {"Smithsonian Astrophysical Observation", "SAO 174236"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97718775),
        dec: Angle.Degrees(-23.28292068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13945"},
        {"Hipparcos Number", "HIP 10492"},
        {"Geneva Identification System", "GEN# +1.00013945"},
        {"Smithsonian Astrophysical Observation", "SAO 167658"},
        {"Wilson Evans Batten Catalogue", "WEB 2202"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.81735061),
        dec: Angle.Degrees(-23.28140736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8920 A"},
        {"Henry Draper", "HD 117287"},
        {"Hipparcos Number", "HIP 65835"},
        {"Geneva Identification System", "GEN# +1.00117287"},
        {"Smithsonian Astrophysical Observation", "SAO 181695"},
        {"Wilson Evans Batten Catalogue", "WEB 11648"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42841193),
        dec: Angle.Degrees(-23.28135784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26007"},
        {"Hipparcos Number", "HIP 19144"},
        {"Smithsonian Astrophysical Observation", "SAO 169122"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.54752872),
        dec: Angle.Degrees(-23.27986462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30692"},
        {"Hipparcos Number", "HIP 22360"},
        {"Geneva Identification System", "GEN# +1.00030692"},
        {"Smithsonian Astrophysical Observation", "SAO 169788"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.20832561),
        dec: Angle.Degrees(-23.27874904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146706"},
        {"Hipparcos Number", "HIP 79897"},
        {"Geneva Identification System", "GEN# +1.00146706"},
        {"Smithsonian Astrophysical Observation", "SAO 184305"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.61776671),
        dec: Angle.Degrees(-23.27423860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7445"},
        {"Smithsonian Astrophysical Observation", "SAO 167163"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96966183),
        dec: Angle.Degrees(-23.27268957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139941"},
        {"Hipparcos Number", "HIP 76874"},
        {"Geneva Identification System", "GEN# +1.00139941"},
        {"Smithsonian Astrophysical Observation", "SAO 183712"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.47168264),
        dec: Angle.Degrees(-23.27201693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207692"},
        {"Hipparcos Number", "HIP 107877"},
        {"Fundamental Katalog 5th Edition", "FK5 1576"},
        {"Geneva Identification System", "GEN# +1.00207692"},
        {"Smithsonian Astrophysical Observation", "SAO 190685"},
        {"Wilson Evans Batten Catalogue", "WEB 19451"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.85162544),
        dec: Angle.Degrees(-23.27041392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176081"},
        {"Hipparcos Number", "HIP 93239"},
        {"Smithsonian Astrophysical Observation", "SAO 187543"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.87312768),
        dec: Angle.Degrees(-23.26590690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12849"},
        {"Hipparcos Number", "HIP 9744"},
        {"Smithsonian Astrophysical Observation", "SAO 167542"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.33455348),
        dec: Angle.Degrees(-23.26528764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186347"},
        {"Hipparcos Number", "HIP 97143"},
        {"Smithsonian Astrophysical Observation", "SAO 188511"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.16907822),
        dec: Angle.Degrees(-23.26407864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107128",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15223 A"},
        {"Henry Draper", "HD 206356"},
        {"Hipparcos Number", "HIP 107128"},
        {"Geneva Identification System", "GEN# +1.00206356"},
        {"Smithsonian Astrophysical Observation", "SAO 190559"},
        {"Wilson Evans Batten Catalogue", "WEB 19349"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.50266207),
        dec: Angle.Degrees(-23.26262557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158356"},
        {"Hipparcos Number", "HIP 85624"},
        {"Renson", "Renson 44585"},
        {"Smithsonian Astrophysical Observation", "SAO 185455"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.45167589),
        dec: Angle.Degrees(-23.26245222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74168"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.31925164),
        dec: Angle.Degrees(-23.26022187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63046"},
        {"Hipparcos Number", "HIP 37896"},
        {"Smithsonian Astrophysical Observation", "SAO 174482"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50545737),
        dec: Angle.Degrees(-23.25990852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35284"},
        {"Hipparcos Number", "HIP 25125"},
        {"Smithsonian Astrophysical Observation", "SAO 170364"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.67208804),
        dec: Angle.Degrees(-23.25901300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141597"},
        {"Hipparcos Number", "HIP 77610"},
        {"Geneva Identification System", "GEN# +1.00141597"},
        {"Smithsonian Astrophysical Observation", "SAO 183850"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.66605737),
        dec: Angle.Degrees(-23.25807932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55295"},
        {"Geneva Identification System", "GEN# -0.02203113"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.86227234),
        dec: Angle.Degrees(-23.25777694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173749"},
        {"Hipparcos Number", "HIP 92240"},
        {"Fundamental Katalog 5th Edition", "FK5 5650"},
        {"Smithsonian Astrophysical Observation", "SAO 187293"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.98101647),
        dec: Angle.Degrees(-23.25713172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95182"},
        {"Hipparcos Number", "HIP 53687"},
        {"Geneva Identification System", "GEN# +1.00095182"},
        {"Smithsonian Astrophysical Observation", "SAO 179397"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.77195906),
        dec: Angle.Degrees(-23.25475415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225199"},
        {"Hipparcos Number", "HIP 341"},
        {"Smithsonian Astrophysical Observation", "SAO 166029"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.07749772),
        dec: Angle.Degrees(-23.25395215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177662"},
        {"Hipparcos Number", "HIP 93832"},
        {"Smithsonian Astrophysical Observation", "SAO 187679"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.63452594),
        dec: Angle.Degrees(-23.25341198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173206"},
        {"Hipparcos Number", "HIP 92001"},
        {"Smithsonian Astrophysical Observation", "SAO 187226"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26913787),
        dec: Angle.Degrees(-23.25176407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110790"},
        {"Hipparcos Number", "HIP 62183"},
        {"Smithsonian Astrophysical Observation", "SAO 181072"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.16163074),
        dec: Angle.Degrees(-23.25117234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170457"},
        {"Hipparcos Number", "HIP 90713"},
        {"Smithsonian Astrophysical Observation", "SAO 186894"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.62150135),
        dec: Angle.Degrees(-23.25063547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23516"},
        {"Geneva Identification System", "GEN# -0.02302363"},
        {"Smithsonian Astrophysical Observation", "SAO 170021"},
        {"Wilson Evans Batten Catalogue", "WEB 4581"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.84052800),
        dec: Angle.Degrees(-23.25062977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 157.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195797"},
        {"Hipparcos Number", "HIP 101500"},
        {"Smithsonian Astrophysical Observation", "SAO 189441"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.53148168),
        dec: Angle.Degrees(-23.24969654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23754"},
        {"Hipparcos Number", "HIP 17651"},
        {"Cincinnati Publication", "Ci 20 262"},
        {"Fundamental Katalog 5th Edition", "FK5 140"},
        {"Geneva Identification System", "GEN# +1.00023754"},
        {"Smithsonian Astrophysical Observation", "SAO 168827"},
        {"Wilson Evans Batten Catalogue", "WEB 3364"},
    },
    visualMagnitude: 4.22,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.71245432),
        dec: Angle.Degrees(-23.24843800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -528.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23164"},
        {"Hipparcos Number", "HIP 17290"},
        {"Smithsonian Astrophysical Observation", "SAO 168753"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.52323024),
        dec: Angle.Degrees(-23.24706213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145504"},
        {"Hipparcos Number", "HIP 79383"},
        {"Geneva Identification System", "GEN# +1.00145504"},
        {"Smithsonian Astrophysical Observation", "SAO 184215"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.02476372),
        dec: Angle.Degrees(-23.24569013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221095"},
        {"Hipparcos Number", "HIP 115922"},
        {"Smithsonian Astrophysical Observation", "SAO 191942"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.29603060),
        dec: Angle.Degrees(-23.24442428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9243"},
        {"Hipparcos Number", "HIP 7026"},
        {"Smithsonian Astrophysical Observation", "SAO 167096"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.63272568),
        dec: Angle.Degrees(-23.24373369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31527"},
        {"Hipparcos Number", "HIP 22905"},
        {"Geneva Identification System", "GEN# +1.00031527"},
        {"Smithsonian Astrophysical Observation", "SAO 169891"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.91010173),
        dec: Angle.Degrees(-23.24219539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7776"},
        {"Hipparcos Number", "HIP 5996"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.27336568),
        dec: Angle.Degrees(-23.23856390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111371"},
        {"Hipparcos Number", "HIP 62553"},
        {"Smithsonian Astrophysical Observation", "SAO 181123"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.25742535),
        dec: Angle.Degrees(-23.23854966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27066"},
        {"Hipparcos Number", "HIP 19878"},
        {"Smithsonian Astrophysical Observation", "SAO 169273"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.94288411),
        dec: Angle.Degrees(-23.23780477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87668"},
    },
    visualMagnitude: 9.24,
    bvColour: 2.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.60888412),
        dec: Angle.Degrees(-23.23601817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102915"},
        {"Hipparcos Number", "HIP 57772"},
        {"Smithsonian Astrophysical Observation", "SAO 180238"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.71002799),
        dec: Angle.Degrees(-23.23580104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39257"},
        {"Hipparcos Number", "HIP 27575"},
        {"Smithsonian Astrophysical Observation", "SAO 170902"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.60742858),
        dec: Angle.Degrees(-23.23559632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12357"},
        {"Hipparcos Number", "HIP 9389"},
        {"Smithsonian Astrophysical Observation", "SAO 167479"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.16102218),
        dec: Angle.Degrees(-23.23326083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10724"},
        {"Smithsonian Astrophysical Observation", "SAO 167687"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50746693),
        dec: Angle.Degrees(-23.23318804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5371 A"},
        {"Henry Draper", "HD 48425"},
        {"Hipparcos Number", "HIP 32112"},
        {"Geneva Identification System", "GEN# +1.00048425A"},
        {"Smithsonian Astrophysical Observation", "SAO 172196"},
        {"Wilson Evans Batten Catalogue", "WEB 6483"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.61490199),
        dec: Angle.Degrees(-23.23259754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161773"},
        {"Hipparcos Number", "HIP 87156"},
        {"Geneva Identification System", "GEN# +1.00161773"},
        {"Smithsonian Astrophysical Observation", "SAO 185780"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.09382812),
        dec: Angle.Degrees(-23.23255953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116833"},
        {"Hipparcos Number", "HIP 65568"},
        {"Smithsonian Astrophysical Observation", "SAO 181656"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.65048285),
        dec: Angle.Degrees(-23.23170340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208648"},
        {"Hipparcos Number", "HIP 108451"},
        {"Smithsonian Astrophysical Observation", "SAO 190779"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.54895732),
        dec: Angle.Degrees(-23.23047737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176473"},
        {"Hipparcos Number", "HIP 93405"},
        {"Geneva Identification System", "GEN# +1.00176473"},
        {"Smithsonian Astrophysical Observation", "SAO 187581"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.34977777),
        dec: Angle.Degrees(-23.22822865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154805"},
        {"Hipparcos Number", "HIP 83875"},
        {"Smithsonian Astrophysical Observation", "SAO 185066"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.13889466),
        dec: Angle.Degrees(-23.22719589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16679 A"},
        {"Henry Draper", "HD 219909"},
        {"Hipparcos Number", "HIP 115173"},
        {"Smithsonian Astrophysical Observation", "SAO 191824"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92319449),
        dec: Angle.Degrees(-23.22550586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219504"},
        {"Hipparcos Number", "HIP 114907"},
        {"Geneva Identification System", "GEN# +1.00219504"},
        {"Smithsonian Astrophysical Observation", "SAO 191779"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.12282443),
        dec: Angle.Degrees(-23.22548009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180276"},
        {"Hipparcos Number", "HIP 94754"},
        {"Smithsonian Astrophysical Observation", "SAO 187910"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.21336973),
        dec: Angle.Degrees(-23.22064365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118538"},
        {"Hipparcos Number", "HIP 66503"},
        {"Smithsonian Astrophysical Observation", "SAO 181815"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.48748821),
        dec: Angle.Degrees(-23.22059851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18323"},
        {"Hipparcos Number", "HIP 13663"},
        {"Smithsonian Astrophysical Observation", "SAO 168154"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.98123230),
        dec: Angle.Degrees(-23.22056016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75690"},
        {"Hipparcos Number", "HIP 43428"},
        {"Smithsonian Astrophysical Observation", "SAO 176569"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.68755685),
        dec: Angle.Degrees(-23.21987216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41256"},
        {"Hipparcos Number", "HIP 28651"},
        {"Smithsonian Astrophysical Observation", "SAO 171176"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.75291156),
        dec: Angle.Degrees(-23.21873171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98649"},
        {"Hipparcos Number", "HIP 55409"},
        {"Geneva Identification System", "GEN# +1.00098649"},
        {"Smithsonian Astrophysical Observation", "SAO 179793"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.21622932),
        dec: Angle.Degrees(-23.21691023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200881"},
        {"Hipparcos Number", "HIP 104216"},
        {"Geneva Identification System", "GEN# +1.00200881"},
        {"Smithsonian Astrophysical Observation", "SAO 190018"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71393514),
        dec: Angle.Degrees(-23.21560415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40235"},
        {"Hipparcos Number", "HIP 28118"},
        {"Geneva Identification System", "GEN# +1.00040235"},
        {"Smithsonian Astrophysical Observation", "SAO 171045"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.14345845),
        dec: Angle.Degrees(-23.21538334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 941"},
        {"Hipparcos Number", "HIP 1102"},
        {"Smithsonian Astrophysical Observation", "SAO 166132"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.43924091),
        dec: Angle.Degrees(-23.21460158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53829"},
        {"Hipparcos Number", "HIP 34199"},
        {"Smithsonian Astrophysical Observation", "SAO 172937"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38248040),
        dec: Angle.Degrees(-23.21455900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4747"},
        {"Hipparcos Number", "HIP 3850"},
        {"Cincinnati Publication", "Ci 18 106"},
        {"Cincinnati Publication 2", "Ci 20 59"},
        {"Geneva Identification System", "GEN# +1.00004747"},
        {"Smithsonian Astrophysical Observation", "SAO 166607"},
        {"Wilson Evans Batten Catalogue", "WEB 686"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.36015525),
        dec: Angle.Degrees(-23.21277388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 516.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34762"},
        {"Smithsonian Astrophysical Observation", "SAO 173173"},
    },
    visualMagnitude: 10.11,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.94299774),
        dec: Angle.Degrees(-23.21082581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73917"},
        {"Hipparcos Number", "HIP 42513"},
        {"Smithsonian Astrophysical Observation", "SAO 176259"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.01629724),
        dec: Angle.Degrees(-23.20844874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15496"},
        {"Hipparcos Number", "HIP 11567"},
        {"Smithsonian Astrophysical Observation", "SAO 167821"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.26090677),
        dec: Angle.Degrees(-23.20805656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49700"},
        {"Hipparcos Number", "HIP 32662"},
        {"Geneva Identification System", "GEN# +1.00049700"},
        {"Smithsonian Astrophysical Observation", "SAO 172361"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.19811117),
        dec: Angle.Degrees(-23.20310451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103850"},
        {"Hipparcos Number", "HIP 58320"},
        {"Smithsonian Astrophysical Observation", "SAO 180330"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.38366032),
        dec: Angle.Degrees(-23.20219501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143229"},
        {"Hipparcos Number", "HIP 78374"},
        {"Smithsonian Astrophysical Observation", "SAO 184010"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.00405824),
        dec: Angle.Degrees(-23.20026628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206034"},
        {"Hipparcos Number", "HIP 106977"},
        {"Smithsonian Astrophysical Observation", "SAO 190531"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.98751101),
        dec: Angle.Degrees(-23.19907447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101650"},
        {"Hipparcos Number", "HIP 57039"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.41807089),
        dec: Angle.Degrees(-23.19901948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90622"},
        {"Hipparcos Number", "HIP 51199"},
        {"Geneva Identification System", "GEN# +1.00090622"},
        {"Smithsonian Astrophysical Observation", "SAO 178836"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.86599019),
        dec: Angle.Degrees(-23.19899718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -313.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23919"},
        {"Hipparcos Number", "HIP 17753"},
        {"Smithsonian Astrophysical Observation", "SAO 168840"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.01030675),
        dec: Angle.Degrees(-23.19764445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56848"},
        {"Hipparcos Number", "HIP 35329"},
        {"Celescope Catalog", "CEL 1749"},
        {"Smithsonian Astrophysical Observation", "SAO 173407"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.45589233),
        dec: Angle.Degrees(-23.19103834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178439"},
        {"Hipparcos Number", "HIP 94122"},
        {"Smithsonian Astrophysical Observation", "SAO 187748"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.39460114),
        dec: Angle.Degrees(-23.19096167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178250"},
        {"Hipparcos Number", "HIP 94041"},
        {"Smithsonian Astrophysical Observation", "SAO 187729"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.18520976),
        dec: Angle.Degrees(-23.19025090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33829"},
        {"Smithsonian Astrophysical Observation", "SAO 172774"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.34276787),
        dec: Angle.Degrees(-23.19007336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96431"},
        {"Geneva Identification System", "GEN# -0.02315564"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.07560231),
        dec: Angle.Degrees(-23.18918269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64565"},
        {"Hipparcos Number", "HIP 38553"},
        {"Smithsonian Astrophysical Observation", "SAO 174744"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.41701516),
        dec: Angle.Degrees(-23.18724053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31180"},
        {"Smithsonian Astrophysical Observation", "SAO 171916"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.14376591),
        dec: Angle.Degrees(-23.18552547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94482"},
        {"Hipparcos Number", "HIP 53301"},
        {"Geneva Identification System", "GEN# +1.00094482"},
        {"Smithsonian Astrophysical Observation", "SAO 179322"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.52699061),
        dec: Angle.Degrees(-23.18447192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142705"},
        {"Hipparcos Number", "HIP 78099"},
        {"Geneva Identification System", "GEN# +1.00142705"},
        {"Smithsonian Astrophysical Observation", "SAO 183958"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.19942875),
        dec: Angle.Degrees(-23.18401586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150937"},
        {"Hipparcos Number", "HIP 82007"},
        {"Geneva Identification System", "GEN# +1.00150937"},
        {"Smithsonian Astrophysical Observation", "SAO 184607"},
        {"Wilson Evans Batten Catalogue", "WEB 13844"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.28617421),
        dec: Angle.Degrees(-23.18397106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56834"},
        {"Hipparcos Number", "HIP 35316"},
        {"Smithsonian Astrophysical Observation", "SAO 173403"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.42098824),
        dec: Angle.Degrees(-23.18307674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194214"},
        {"Hipparcos Number", "HIP 100718"},
        {"Smithsonian Astrophysical Observation", "SAO 189262"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.28964450),
        dec: Angle.Degrees(-23.18291523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172052"},
        {"Hipparcos Number", "HIP 91446"},
        {"Geneva Identification System", "GEN# +1.00172052"},
        {"Smithsonian Astrophysical Observation", "SAO 187088"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.75862981),
        dec: Angle.Degrees(-23.18208209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89420"},
        {"Hipparcos Number", "HIP 50504"},
        {"Geneva Identification System", "GEN# +1.00089420"},
        {"Smithsonian Astrophysical Observation", "SAO 178665"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.70938897),
        dec: Angle.Degrees(-23.18136457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143692"},
        {"Hipparcos Number", "HIP 78586"},
        {"Geneva Identification System", "GEN# +1.00143692"},
        {"Smithsonian Astrophysical Observation", "SAO 184055"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68939590),
        dec: Angle.Degrees(-23.18113425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6244"},
        {"Hipparcos Number", "HIP 4925"},
        {"Geneva Identification System", "GEN# +1.00006244"},
        {"Smithsonian Astrophysical Observation", "SAO 166769"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.80107453),
        dec: Angle.Degrees(-23.18067043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75359"},
        {"Hipparcos Number", "HIP 43264"},
        {"Smithsonian Astrophysical Observation", "SAO 176512"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.19919655),
        dec: Angle.Degrees(-23.17940550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222905"},
        {"Hipparcos Number", "HIP 117135"},
        {"Smithsonian Astrophysical Observation", "SAO 192123"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.20224774),
        dec: Angle.Degrees(-23.17837377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29963"},
        {"Hipparcos Number", "HIP 21893"},
        {"Smithsonian Astrophysical Observation", "SAO 169680"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.59256310),
        dec: Angle.Degrees(-23.17794265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34597"},
        {"Hipparcos Number", "HIP 24686"},
        {"Smithsonian Astrophysical Observation", "SAO 170284"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.42780353),
        dec: Angle.Degrees(-23.17691404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78955"},
        {"Hipparcos Number", "HIP 45037"},
        {"Fundamental Katalog 5th Edition", "FK5 2728"},
        {"Geneva Identification System", "GEN# +1.00078955"},
        {"Smithsonian Astrophysical Observation", "SAO 177066"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.59591763),
        dec: Angle.Degrees(-23.17670877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17898"},
        {"Hipparcos Number", "HIP 13354"},
        {"Smithsonian Astrophysical Observation", "SAO 168104"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.95683337),
        dec: Angle.Degrees(-23.17642492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91706"},
        {"Hipparcos Number", "HIP 51795"},
        {"Geneva Identification System", "GEN# +1.00091706"},
        {"Smithsonian Astrophysical Observation", "SAO 178993"},
        {"Wilson Evans Batten Catalogue", "WEB 9436"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.74067829),
        dec: Angle.Degrees(-23.17633022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182228"},
        {"Hipparcos Number", "HIP 95415"},
        {"Smithsonian Astrophysical Observation", "SAO 188083"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.13949006),
        dec: Angle.Degrees(-23.17566697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175360"},
        {"Hipparcos Number", "HIP 92931"},
        {"Geneva Identification System", "GEN# +1.00175360"},
        {"Smithsonian Astrophysical Observation", "SAO 187468"},
        {"Wilson Evans Batten Catalogue", "WEB 16093"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.00280341),
        dec: Angle.Degrees(-23.17371793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16267 AB"},
        {"Henry Draper", "HD 215737"},
        {"Hipparcos Number", "HIP 112537"},
        {"Smithsonian Astrophysical Observation", "SAO 191406"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.90625049),
        dec: Angle.Degrees(-23.17229166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157747"},
        {"Hipparcos Number", "HIP 85315"},
        {"Geneva Identification System", "GEN# +1.00157747"},
        {"Smithsonian Astrophysical Observation", "SAO 185397"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.50557508),
        dec: Angle.Degrees(-23.17149617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115659"},
        {"Hipparcos Number", "HIP 64962"},
        {"Fundamental Katalog 5th Edition", "FK5 495"},
        {"Geneva Identification System", "GEN# +1.00115659"},
        {"Smithsonian Astrophysical Observation", "SAO 181543"},
        {"Wilson Evans Batten Catalogue", "WEB 11479"},
    },
    visualMagnitude: 2.99,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.73022240),
        dec: Angle.Degrees(-23.17141246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35647"},
        {"Hipparcos Number", "HIP 25347"},
        {"Smithsonian Astrophysical Observation", "SAO 170409"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.32609979),
        dec: Angle.Degrees(-23.17087850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25283"},
        {"Hipparcos Number", "HIP 18693"},
        {"Geneva Identification System", "GEN# +1.00025283"},
        {"Smithsonian Astrophysical Observation", "SAO 169023"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.07362761),
        dec: Angle.Degrees(-23.17053099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206499"},
        {"Hipparcos Number", "HIP 107222"},
        {"Geneva Identification System", "GEN# +1.00206499"},
        {"Smithsonian Astrophysical Observation", "SAO 190573"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.74700196),
        dec: Angle.Degrees(-23.17047289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8054",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1361 A"},
        {"Henry Draper", "HD 10645"},
        {"Henry Draper 2", "HD 10645A"},
        {"Hipparcos Number", "HIP 8054"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.85284293),
        dec: Angle.Degrees(-23.16947223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73795"},
        {"Smithsonian Astrophysical Observation", "SAO 183150"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23846228),
        dec: Angle.Degrees(-23.16853137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111947"},
        {"Hipparcos Number", "HIP 62866"},
        {"Smithsonian Astrophysical Observation", "SAO 181192"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.27740068),
        dec: Angle.Degrees(-23.16619208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122960"},
        {"Hipparcos Number", "HIP 68822"},
        {"Smithsonian Astrophysical Observation", "SAO 182231"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.35239399),
        dec: Angle.Degrees(-23.16488349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128529"},
        {"Hipparcos Number", "HIP 71544"},
        {"Smithsonian Astrophysical Observation", "SAO 182722"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.49858593),
        dec: Angle.Degrees(-23.16432579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1515"},
        {"Smithsonian Astrophysical Observation", "SAO 166180"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.72980652),
        dec: Angle.Degrees(-23.16428893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82627"},
        {"Smithsonian Astrophysical Observation", "SAO 184753"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37043823),
        dec: Angle.Degrees(-23.16394761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146283"},
        {"Hipparcos Number", "HIP 79728"},
        {"Geneva Identification System", "GEN# +1.00146283"},
        {"Smithsonian Astrophysical Observation", "SAO 184274"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.07743317),
        dec: Angle.Degrees(-23.16290350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60438"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86784323),
        dec: Angle.Degrees(-23.16140052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68820"},
    },
    visualMagnitude: 9.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05, 24.1300),
        dec: Angle.DegreesMinutesSeconds((int)-23, (int)09, 37.800)
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
    primaryId: "HIP 34455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54604"},
        {"Hipparcos Number", "HIP 34455"},
        {"Smithsonian Astrophysical Observation", "SAO 173050"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.13496849),
        dec: Angle.Degrees(-23.15901329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218294"},
        {"Hipparcos Number", "HIP 114156"},
        {"Geneva Identification System", "GEN# +6.10010889"},
        {"Geneva Identification System 2", "GEN# +1.00218294A"},
        {"Smithsonian Astrophysical Observation", "SAO 191663"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.77900023),
        dec: Angle.Degrees(-23.15883163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218002"},
        {"Hipparcos Number", "HIP 113972"},
        {"Smithsonian Astrophysical Observation", "SAO 191632"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.22479102),
        dec: Angle.Degrees(-23.15816953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51732"},
        {"Hipparcos Number", "HIP 33480"},
        {"Geneva Identification System", "GEN# +1.00051732"},
        {"Smithsonian Astrophysical Observation", "SAO 172643"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.39467545),
        dec: Angle.Degrees(-23.15785117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6103"},
        {"Smithsonian Astrophysical Observation", "SAO 166938"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.59298963),
        dec: Angle.Degrees(-23.15755254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187841"},
        {"Hipparcos Number", "HIP 97834"},
        {"Smithsonian Astrophysical Observation", "SAO 188667"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.21020283),
        dec: Angle.Degrees(-23.15590384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71141"},
        {"Hipparcos Number", "HIP 41242"},
        {"Geneva Identification System", "GEN# +1.00071141"},
        {"Smithsonian Astrophysical Observation", "SAO 175777"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22998546),
        dec: Angle.Degrees(-23.15381698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129944"},
        {"Hipparcos Number", "HIP 72210"},
        {"Fundamental Katalog 5th Edition", "FK5 3167"},
        {"Geneva Identification System", "GEN# +1.00129944"},
        {"Smithsonian Astrophysical Observation", "SAO 182857"},
        {"Wilson Evans Batten Catalogue", "WEB 12423"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.52813497),
        dec: Angle.Degrees(-23.15286204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153932"},
        {"Hipparcos Number", "HIP 83456"},
        {"Smithsonian Astrophysical Observation", "SAO 184962"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.83993433),
        dec: Angle.Degrees(-23.15160679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10265"},
        {"Henry Draper", "HD 152849"},
        {"Hipparcos Number", "HIP 82925"},
        {"Geneva Identification System", "GEN# +1.00152849"},
        {"Smithsonian Astrophysical Observation", "SAO 184822"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.20015918),
        dec: Angle.Degrees(-23.15032178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139518"},
        {"Hipparcos Number", "HIP 76666"},
        {"Geneva Identification System", "GEN# +1.00139518"},
        {"Smithsonian Astrophysical Observation", "SAO 183665"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.83912225),
        dec: Angle.Degrees(-23.15017112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49233"},
        {"Hipparcos Number", "HIP 32454"},
        {"Celescope Catalog", "CEL 1382"},
        {"Geneva Identification System", "GEN# +1.00049233"},
        {"Smithsonian Astrophysical Observation", "SAO 172305"},
        {"Wilson Evans Batten Catalogue", "WEB 6545"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.60748469),
        dec: Angle.Degrees(-23.14933712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200913"},
        {"Hipparcos Number", "HIP 104229"},
        {"Geneva Identification System", "GEN# +1.00200913"},
        {"Smithsonian Astrophysical Observation", "SAO 190024"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.76514372),
        dec: Angle.Degrees(-23.14889464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175501"},
        {"Hipparcos Number", "HIP 92980"},
        {"Geneva Identification System", "GEN# +1.00175501"},
        {"Smithsonian Astrophysical Observation", "SAO 187480"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.14201309),
        dec: Angle.Degrees(-23.14845030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 571 AB"},
        {"Henry Draper", "HD 3864"},
        {"Hipparcos Number", "HIP 3226"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.26653516),
        dec: Angle.Degrees(-23.14832294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163451"},
        {"Hipparcos Number", "HIP 87893"},
        {"Smithsonian Astrophysical Observation", "SAO 185983"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30624430),
        dec: Angle.Degrees(-23.14813280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86917"},
        {"Hipparcos Number", "HIP 49090"},
        {"Geneva Identification System", "GEN# +1.00086917"},
        {"Smithsonian Astrophysical Observation", "SAO 178305"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.29515243),
        dec: Angle.Degrees(-23.14657006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18099"},
        {"Hipparcos Number", "HIP 13493"},
        {"Smithsonian Astrophysical Observation", "SAO 168125"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.43613039),
        dec: Angle.Degrees(-23.14559336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214937"},
        {"Hipparcos Number", "HIP 112074"},
        {"Smithsonian Astrophysical Observation", "SAO 191334"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.50841006),
        dec: Angle.Degrees(-23.14543299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19161"},
        {"Hipparcos Number", "HIP 14290"},
        {"Smithsonian Astrophysical Observation", "SAO 168275"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.05519396),
        dec: Angle.Degrees(-23.14361364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16101"},
        {"Hipparcos Number", "HIP 11994"},
        {"Smithsonian Astrophysical Observation", "SAO 167886"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66248470),
        dec: Angle.Degrees(-23.14320624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63045"},
        {"Hipparcos Number", "HIP 37906"},
        {"Geneva Identification System", "GEN# +1.00063045"},
        {"Smithsonian Astrophysical Observation", "SAO 174487"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.51506082),
        dec: Angle.Degrees(-23.14159541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139254"},
        {"Hipparcos Number", "HIP 76532"},
        {"Geneva Identification System", "GEN# +1.00139254"},
        {"Smithsonian Astrophysical Observation", "SAO 183637"},
        {"Wilson Evans Batten Catalogue", "WEB 12988"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.45024464),
        dec: Angle.Degrees(-23.14151509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38579"},
        {"Hipparcos Number", "HIP 27197"},
        {"Smithsonian Astrophysical Observation", "SAO 170799"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.47780310),
        dec: Angle.Degrees(-23.14020715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211364"},
        {"Hipparcos Number", "HIP 110018"},
        {"Geneva Identification System", "GEN# +1.00211364"},
        {"Smithsonian Astrophysical Observation", "SAO 191021"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.24911509),
        dec: Angle.Degrees(-23.14009853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7642"},
        {"Henry Draper", "HD 87756"},
        {"Hipparcos Number", "HIP 49521"},
        {"Geneva Identification System", "GEN# +1.00087756"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.66784929),
        dec: Angle.Degrees(-23.13957305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100440"},
        {"Hipparcos Number", "HIP 56372"},
        {"Smithsonian Astrophysical Observation", "SAO 179981"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.33705086),
        dec: Angle.Degrees(-23.13700004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197047"},
        {"Hipparcos Number", "HIP 102146"},
        {"Geneva Identification System", "GEN# +1.00197047"},
        {"Smithsonian Astrophysical Observation", "SAO 189586"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46896267),
        dec: Angle.Degrees(-23.13651606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24616"},
        {"Hipparcos Number", "HIP 18235"},
        {"Cincinnati Publication", "Ci 20 269"},
        {"Geneva Identification System", "GEN# +1.00024616"},
        {"Smithsonian Astrophysical Observation", "SAO 168929"},
        {"Wilson Evans Batten Catalogue", "WEB 3521"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.49687935),
        dec: Angle.Degrees(-23.13634941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 336.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111865"},
        {"Hipparcos Number", "HIP 62834"},
        {"Geneva Identification System", "GEN# +1.00111865"},
        {"Smithsonian Astrophysical Observation", "SAO 181179"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.14163104),
        dec: Angle.Degrees(-23.13622024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28250"},
        {"Hipparcos Number", "HIP 20730"},
        {"Smithsonian Astrophysical Observation", "SAO 169448"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.63287924),
        dec: Angle.Degrees(-23.13509008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124463"},
        {"Hipparcos Number", "HIP 69558"},
        {"Geneva Identification System", "GEN# +1.00124463"},
        {"Smithsonian Astrophysical Observation", "SAO 182361"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58092457),
        dec: Angle.Degrees(-23.13248745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150734"},
        {"Hipparcos Number", "HIP 81908"},
        {"Geneva Identification System", "GEN# +1.00150734"},
        {"Smithsonian Astrophysical Observation", "SAO 184586"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.95882587),
        dec: Angle.Degrees(-23.13117352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163179"},
        {"Hipparcos Number", "HIP 87774"},
        {"Renson", "Renson 46138"},
        {"Smithsonian Astrophysical Observation", "SAO 185951"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.95867379),
        dec: Angle.Degrees(-23.13016125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79934"},
        {"Hipparcos Number", "HIP 45502"},
        {"Smithsonian Astrophysical Observation", "SAO 177195"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.07832374),
        dec: Angle.Degrees(-23.12999893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92943"},
        {"Hipparcos Number", "HIP 52467"},
        {"Smithsonian Astrophysical Observation", "SAO 179167"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.88231115),
        dec: Angle.Degrees(-23.12920122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11642"},
        {"Hipparcos Number", "HIP 8843"},
        {"Smithsonian Astrophysical Observation", "SAO 167382"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.43649905),
        dec: Angle.Degrees(-23.12887644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3067 A"},
        {"Henry Draper", "HD 26757"},
        {"Hipparcos Number", "HIP 19690"},
        {"Smithsonian Astrophysical Observation", "SAO 169231"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.26380136),
        dec: Angle.Degrees(-23.12827946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1302 AB"},
        {"Henry Draper", "HD 10177"},
        {"Hipparcos Number", "HIP 7704"},
        {"Smithsonian Astrophysical Observation", "SAO 167201"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78703150),
        dec: Angle.Degrees(-23.12790622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162167"},
        {"Hipparcos Number", "HIP 87329"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.65743308),
        dec: Angle.Degrees(-23.12478015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10024 AB"},
        {"Henry Draper", "HD 147432"},
        {"Hipparcos Number", "HIP 80238"},
        {"Smithsonian Astrophysical Observation", "SAO 184350"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.71576906),
        dec: Angle.Degrees(-23.11869275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33450"},
        {"Hipparcos Number", "HIP 23991"},
        {"Fundamental Katalog 5th Edition", "FK5 4471"},
        {"Smithsonian Astrophysical Observation", "SAO 170126"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.35518398),
        dec: Angle.Degrees(-23.11863589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114149"},
        {"Hipparcos Number", "HIP 64166"},
        {"Fundamental Katalog 5th Edition", "FK5 3048"},
        {"Geneva Identification System", "GEN# +1.00114149"},
        {"Smithsonian Astrophysical Observation", "SAO 181410"},
        {"Wilson Evans Batten Catalogue", "WEB 11340"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.26367917),
        dec: Angle.Degrees(-23.11797275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205366"},
        {"Hipparcos Number", "HIP 106600"},
        {"Smithsonian Astrophysical Observation", "SAO 190472"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.84472844),
        dec: Angle.Degrees(-23.11795422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166767"},
        {"Hipparcos Number", "HIP 89276"},
        {"Geneva Identification System", "GEN# +1.00166767"},
        {"Smithsonian Astrophysical Observation", "SAO 186478"},
        {"Wilson Evans Batten Catalogue", "WEB 15176"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.26039535),
        dec: Angle.Degrees(-23.11726692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167288"},
        {"Hipparcos Number", "HIP 89468"},
        {"Geneva Identification System", "GEN# +1.00167288"},
        {"Renson", "Renson 47030"},
        {"Smithsonian Astrophysical Observation", "SAO 186548"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.87618127),
        dec: Angle.Degrees(-23.11713323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211450"},
        {"Hipparcos Number", "HIP 110060"},
        {"Smithsonian Astrophysical Observation", "SAO 191026"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.38082490),
        dec: Angle.Degrees(-23.11453270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3699"},
        {"Smithsonian Astrophysical Observation", "SAO 166578"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.86054249),
        dec: Angle.Degrees(-23.11338658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14719"},
        {"Aitken 2", "ADS 14719 A"},
        {"Henry Draper", "HD 201630"},
        {"Henry Draper 2", "HD 201630A"},
        {"Hipparcos Number", "HIP 104619"},
        {"Smithsonian Astrophysical Observation", "SAO 190103"},
    },
    visualMagnitude: 8.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.89257111),
        dec: Angle.Degrees(-23.11273636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4704 A"},
        {"Henry Draper", "HD 41841"},
        {"Hipparcos Number", "HIP 28943"},
        {"Geneva Identification System", "GEN# +1.00041841A"},
        {"Renson", "Renson 11150"},
        {"Smithsonian Astrophysical Observation", "SAO 171236"},
        {"Wilson Evans Batten Catalogue", "WEB 5663"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.63376334),
        dec: Angle.Degrees(-23.11077641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146367"},
        {"Hipparcos Number", "HIP 79779"},
        {"Geneva Identification System", "GEN# +1.00146367"},
        {"Smithsonian Astrophysical Observation", "SAO 184283"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.22243279),
        dec: Angle.Degrees(-23.11041971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112039"},
        {"Hipparcos Number", "HIP 62922"},
        {"Geneva Identification System", "GEN# +1.00112039"},
        {"Smithsonian Astrophysical Observation", "SAO 181203"},
        {"Wilson Evans Batten Catalogue", "WEB 11156"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42506788),
        dec: Angle.Degrees(-23.10919573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216650"},
        {"Hipparcos Number", "HIP 113154"},
        {"Smithsonian Astrophysical Observation", "SAO 191486"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.70628590),
        dec: Angle.Degrees(-23.10894597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57030"},
        {"Hipparcos Number", "HIP 35397"},
        {"Smithsonian Astrophysical Observation", "SAO 173438"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65111270),
        dec: Angle.Degrees(-23.10859530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50590"},
        {"Hipparcos Number", "HIP 33037"},
        {"Geneva Identification System", "GEN# +1.00050590"},
        {"Smithsonian Astrophysical Observation", "SAO 172502"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24791955),
        dec: Angle.Degrees(-23.10788677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8033"},
        {"Hipparcos Number", "HIP 6186"},
        {"Geneva Identification System", "GEN# +1.00008033"},
        {"Smithsonian Astrophysical Observation", "SAO 166955"},
        {"Wilson Evans Batten Catalogue", "WEB 1389"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.84406138),
        dec: Angle.Degrees(-23.10768631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203"},
        {"Hipparcos Number", "HIP 560"},
        {"Fundamental Katalog 5th Edition", "FK5 1003"},
        {"Geneva Identification System", "GEN# +1.00000203"},
        {"Smithsonian Astrophysical Observation", "SAO 166053"},
        {"Wilson Evans Batten Catalogue", "WEB 99"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.70843563),
        dec: Angle.Degrees(-23.10742543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145189"},
        {"Hipparcos Number", "HIP 79250"},
        {"Geneva Identification System", "GEN# +1.00145189"},
        {"Smithsonian Astrophysical Observation", "SAO 184189"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.60569469),
        dec: Angle.Degrees(-23.10642331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114098"},
        {"Hipparcos Number", "HIP 64133"},
        {"Smithsonian Astrophysical Observation", "SAO 181408"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16431672),
        dec: Angle.Degrees(-23.10637572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50895"},
        {"Hipparcos Number", "HIP 33164"},
        {"Geneva Identification System", "GEN# +1.00050895"},
        {"Renson", "Renson 14010"},
        {"Smithsonian Astrophysical Observation", "SAO 172544"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55373606),
        dec: Angle.Degrees(-23.10609758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112331",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16234 A"},
        {"Henry Draper", "HD 215395"},
        {"Hipparcos Number", "HIP 112331"},
        {"Smithsonian Astrophysical Observation", "SAO 191374"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.29250060),
        dec: Angle.Degrees(-23.10570439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44291"},
        {"Hipparcos Number", "HIP 30103"},
        {"Geneva Identification System", "GEN# +1.00044291"},
        {"Smithsonian Astrophysical Observation", "SAO 171586"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.02271046),
        dec: Angle.Degrees(-23.10531999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26187"},
        {"Hipparcos Number", "HIP 19268"},
        {"Smithsonian Astrophysical Observation", "SAO 169150"},
    },
    visualMagnitude: 9.46,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.94649874),
        dec: Angle.Degrees(-23.10488892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218651"},
        {"Hipparcos Number", "HIP 114387"},
        {"Geneva Identification System", "GEN# +1.00218651"},
        {"Smithsonian Astrophysical Observation", "SAO 191689"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49507896),
        dec: Angle.Degrees(-23.10487008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59965"},
        {"Hipparcos Number", "HIP 36585"},
        {"Smithsonian Astrophysical Observation", "SAO 173921"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.87375780),
        dec: Angle.Degrees(-23.10470894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97782"},
        {"Hipparcos Number", "HIP 54922"},
        {"Geneva Identification System", "GEN# +1.00097782J"},
        {"Smithsonian Astrophysical Observation", "SAO 179685"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.70149454),
        dec: Angle.Degrees(-23.10403210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121611"},
        {"Hipparcos Number", "HIP 68136"},
        {"Fundamental Katalog 5th Edition", "FK5 5230"},
        {"Geneva Identification System", "GEN# +1.00121611"},
        {"Smithsonian Astrophysical Observation", "SAO 182110"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.24715801),
        dec: Angle.Degrees(-23.10356475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171960"},
        {"Hipparcos Number", "HIP 91402"},
        {"Geneva Identification System", "GEN# +1.00171960"},
        {"Smithsonian Astrophysical Observation", "SAO 187078"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.61050736),
        dec: Angle.Degrees(-23.10292252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26289"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.97350879),
        dec: Angle.Degrees(-23.10267921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89638"},
        {"Hipparcos Number", "HIP 50601"},
        {"Geneva Identification System", "GEN# +1.00089638"},
        {"Smithsonian Astrophysical Observation", "SAO 178700"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.05495454),
        dec: Angle.Degrees(-23.10261412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209783"},
        {"Hipparcos Number", "HIP 109133"},
        {"Smithsonian Astrophysical Observation", "SAO 190890"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.59303377),
        dec: Angle.Degrees(-23.10061038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218617"},
        {"Hipparcos Number", "HIP 114359"},
        {"Smithsonian Astrophysical Observation", "SAO 191684"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.41569185),
        dec: Angle.Degrees(-23.09967324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65740"},
    },
    visualMagnitude: 11.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.13679351),
        dec: Angle.Degrees(-23.09816992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83608"},
        {"Hipparcos Number", "HIP 47372"},
        {"Smithsonian Astrophysical Observation", "SAO 177795"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.77512799),
        dec: Angle.Degrees(-23.09508802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41897"},
        {"Hipparcos Number", "HIP 28971"},
        {"Fundamental Katalog 5th Edition", "FK5 4557"},
        {"Smithsonian Astrophysical Observation", "SAO 171248"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.71436831),
        dec: Angle.Degrees(-23.09374846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215981"},
        {"Hipparcos Number", "HIP 112693"},
        {"Smithsonian Astrophysical Observation", "SAO 191428"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32154886),
        dec: Angle.Degrees(-23.09253910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140515"},
        {"Hipparcos Number", "HIP 77123"},
        {"Smithsonian Astrophysical Observation", "SAO 183752"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.21962197),
        dec: Angle.Degrees(-23.09080209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102582"},
        {"Hipparcos Number", "HIP 57594"},
        {"Geneva Identification System", "GEN# +1.00102582"},
        {"Smithsonian Astrophysical Observation", "SAO 180204"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.11093046),
        dec: Angle.Degrees(-23.09062490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95697"},
        {"Hipparcos Number", "HIP 53976"},
        {"Smithsonian Astrophysical Observation", "SAO 179458"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.63025336),
        dec: Angle.Degrees(-23.08899060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12961",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Koeia"},
        {"Hipparcos Number", "HIP 12961"},
        {"Smithsonian Astrophysical Observation", "SAO 168043"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.67791744),
        dec: Angle.Degrees(-23.08695475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 292.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58978"},
        {"Hipparcos Number", "HIP 36168"},
        {"Celescope Catalog", "CEL 1859"},
        {"Geneva Identification System", "GEN# +5.11210035"},
        {"Smithsonian Astrophysical Observation", "SAO 173752"},
        {"Wilson Evans Batten Catalogue", "WEB 7202"},
    },
    visualMagnitude: 5.65,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74786303),
        dec: Angle.Degrees(-23.08603328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15807"},
        {"Hipparcos Number", "HIP 11780"},
        {"Geneva Identification System", "GEN# +1.00015807"},
        {"Smithsonian Astrophysical Observation", "SAO 167856"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.00052459),
        dec: Angle.Degrees(-23.08449335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23685"},
        {"Hipparcos Number", "HIP 17598"},
        {"Smithsonian Astrophysical Observation", "SAO 168814"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.54261939),
        dec: Angle.Degrees(-23.08365876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127322"},
        {"Hipparcos Number", "HIP 71010"},
        {"Smithsonian Astrophysical Observation", "SAO 182629"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.84479401),
        dec: Angle.Degrees(-23.08308732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58886"},
        {"Hipparcos Number", "HIP 36136"},
        {"Geneva Identification System", "GEN# +1.00058886"},
        {"Smithsonian Astrophysical Observation", "SAO 173741"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.66151525),
        dec: Angle.Degrees(-23.08205950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169476"},
        {"Hipparcos Number", "HIP 90321"},
        {"Smithsonian Astrophysical Observation", "SAO 186800"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.43312283),
        dec: Angle.Degrees(-23.08088898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88767"},
        {"Hipparcos Number", "HIP 50115"},
        {"Smithsonian Astrophysical Observation", "SAO 178549"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46759040),
        dec: Angle.Degrees(-23.08044817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200024"},
        {"Hipparcos Number", "HIP 103746"},
        {"Smithsonian Astrophysical Observation", "SAO 189940"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.35420340),
        dec: Angle.Degrees(-23.07851813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50046"},
        {"Hipparcos Number", "HIP 32816"},
        {"Geneva Identification System", "GEN# +1.00050046"},
        {"Smithsonian Astrophysical Observation", "SAO 172412"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.61612700),
        dec: Angle.Degrees(-23.07364147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102298"},
        {"Hipparcos Number", "HIP 57437"},
        {"Smithsonian Astrophysical Observation", "SAO 180177"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.62479166),
        dec: Angle.Degrees(-23.07297051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220727"},
        {"Hipparcos Number", "HIP 115688"},
        {"Smithsonian Astrophysical Observation", "SAO 191904"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58435465),
        dec: Angle.Degrees(-23.07200027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71815"},
        {"Hipparcos Number", "HIP 41572"},
        {"Geneva Identification System", "GEN# +1.00071815"},
        {"Smithsonian Astrophysical Observation", "SAO 175902"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15024049),
        dec: Angle.Degrees(-23.07098606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10165"},
        {"Smithsonian Astrophysical Observation", "SAO 167612"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.67586021),
        dec: Angle.Degrees(-23.07066208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205738"},
        {"Hipparcos Number", "HIP 106807"},
        {"Geneva Identification System", "GEN# +1.00205738"},
        {"Smithsonian Astrophysical Observation", "SAO 190508"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48984376),
        dec: Angle.Degrees(-23.06824377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71360"},
        {"Hipparcos Number", "HIP 41354"},
        {"Smithsonian Astrophysical Observation", "SAO 175818"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.55410384),
        dec: Angle.Degrees(-23.06714751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168053"},
        {"Hipparcos Number", "HIP 89741"},
        {"Smithsonian Astrophysical Observation", "SAO 186633"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.71601667),
        dec: Angle.Degrees(-23.06632327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134138"},
        {"Hipparcos Number", "HIP 74119"},
        {"Smithsonian Astrophysical Observation", "SAO 183210"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.22064730),
        dec: Angle.Degrees(-23.06614226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188579"},
        {"Hipparcos Number", "HIP 98135"},
        {"Renson", "Renson 52097"},
        {"Smithsonian Astrophysical Observation", "SAO 188737"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.16705350),
        dec: Angle.Degrees(-23.06607588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176203"},
        {"Hipparcos Number", "HIP 93288"},
        {"Geneva Identification System", "GEN# +1.00176203"},
        {"Smithsonian Astrophysical Observation", "SAO 187556"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.01739446),
        dec: Angle.Degrees(-23.06298514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30732"},
        {"Hipparcos Number", "HIP 22390"},
        {"Smithsonian Astrophysical Observation", "SAO 169794"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.29724656),
        dec: Angle.Degrees(-23.06157274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160257"},
        {"Hipparcos Number", "HIP 86455"},
        {"Smithsonian Astrophysical Observation", "SAO 185602"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98181695),
        dec: Angle.Degrees(-23.06128240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34433"},
        {"Hipparcos Number", "HIP 24582"},
        {"Geneva Identification System", "GEN# +1.00034433"},
        {"Smithsonian Astrophysical Observation", "SAO 170258"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.10591901),
        dec: Angle.Degrees(-23.05907514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181264"},
        {"Hipparcos Number", "HIP 95084"},
        {"Smithsonian Astrophysical Observation", "SAO 187994"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17345343),
        dec: Angle.Degrees(-23.05540295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
