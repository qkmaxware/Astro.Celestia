using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_38() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30308"},
        {"Smithsonian Astrophysical Observation", "SAO 171648"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.61143907),
        dec: Angle.Degrees(-27.70028599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130240"},
        {"Hipparcos Number", "HIP 72353"},
        {"Geneva Identification System", "GEN# +1.00130240"},
        {"Smithsonian Astrophysical Observation", "SAO 182881"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93091588),
        dec: Angle.Degrees(-27.69898212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197873"},
        {"Hipparcos Number", "HIP 102581"},
        {"Geneva Identification System", "GEN# +1.00197873"},
        {"Smithsonian Astrophysical Observation", "SAO 189694"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.81941039),
        dec: Angle.Degrees(-27.69841265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191270"},
        {"Hipparcos Number", "HIP 99363"},
        {"Smithsonian Astrophysical Observation", "SAO 188974"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.52194058),
        dec: Angle.Degrees(-27.69664184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112723"},
        {"Hipparcos Number", "HIP 63374"},
        {"Smithsonian Astrophysical Observation", "SAO 181286"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.78408763),
        dec: Angle.Degrees(-27.69662855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15312"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.39536797),
        dec: Angle.Degrees(-27.69636365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 332.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56838"},
        {"Geneva Identification System", "GEN# -0.02608683"},
        {"Smithsonian Astrophysical Observation", "SAO 180067"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.78303144),
        dec: Angle.Degrees(-27.69554010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 356.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185592"},
        {"Hipparcos Number", "HIP 96823"},
        {"Smithsonian Astrophysical Observation", "SAO 188429"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.20350428),
        dec: Angle.Degrees(-27.69543159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116346"},
        {"Smithsonian Astrophysical Observation", "SAO 192003"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.62760902),
        dec: Angle.Degrees(-27.69123903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142057"},
        {"Hipparcos Number", "HIP 77821"},
        {"Smithsonian Astrophysical Observation", "SAO 183893"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.36744767),
        dec: Angle.Degrees(-27.69050603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206341"},
        {"Hipparcos Number", "HIP 107134"},
        {"Geneva Identification System", "GEN# +1.00206341"},
        {"Smithsonian Astrophysical Observation", "SAO 190560"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.51680828),
        dec: Angle.Degrees(-27.69040089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148040"},
        {"Hipparcos Number", "HIP 80535"},
        {"Smithsonian Astrophysical Observation", "SAO 184388"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.62466453),
        dec: Angle.Degrees(-27.68889764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52731"},
        {"Hipparcos Number", "HIP 33814"},
        {"Celescope Catalog", "CEL 1510"},
        {"Geneva Identification System", "GEN# +1.00052731"},
        {"Smithsonian Astrophysical Observation", "SAO 172772"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.30098717),
        dec: Angle.Degrees(-27.68743354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3844"},
        {"Hipparcos Number", "HIP 3212"},
        {"Geneva Identification System", "GEN# +1.00003844"},
        {"Smithsonian Astrophysical Observation", "SAO 166479"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.21640126),
        dec: Angle.Degrees(-27.68214607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218933"},
        {"Hipparcos Number", "HIP 114544"},
        {"Smithsonian Astrophysical Observation", "SAO 191717"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.03350484),
        dec: Angle.Degrees(-27.68191143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7095 A"},
        {"Henry Draper", "HD 76483"},
        {"Hipparcos Number", "HIP 43825"},
        {"Geneva Identification System", "GEN# +1.00076483"},
        {"Renson", "Renson 21560"},
        {"Smithsonian Astrophysical Observation", "SAO 176697"},
        {"Wilson Evans Batten Catalogue", "WEB 8429"},
    },
    visualMagnitude: 4.87,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.88131490),
        dec: Angle.Degrees(-27.68162589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22840"},
        {"Hipparcos Number", "HIP 17045"},
        {"Smithsonian Astrophysical Observation", "SAO 168710"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.81353231),
        dec: Angle.Degrees(-27.67881449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58907"},
        {"Geneva Identification System", "GEN# -0.02608952"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19714422),
        dec: Angle.Degrees(-27.67856773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220037"},
        {"Hipparcos Number", "HIP 115281"},
        {"Smithsonian Astrophysical Observation", "SAO 191837"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.22516382),
        dec: Angle.Degrees(-27.67736800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82709"},
        {"Hipparcos Number", "HIP 46856"},
        {"Geneva Identification System", "GEN# +1.00082709"},
        {"Smithsonian Astrophysical Observation", "SAO 177634"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23047263),
        dec: Angle.Degrees(-27.67609283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85033",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10499 AB"},
        {"Henry Draper", "HD 157155"},
        {"Hipparcos Number", "HIP 85033"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.69239628),
        dec: Angle.Degrees(-27.67607482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78696"},
    },
    visualMagnitude: 11.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.97188616),
        dec: Angle.Degrees(-27.67515352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210320"},
        {"Hipparcos Number", "HIP 109423"},
        {"Geneva Identification System", "GEN# +1.00210320"},
        {"Smithsonian Astrophysical Observation", "SAO 190933"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.53538403),
        dec: Angle.Degrees(-27.67380097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177716"},
        {"Hipparcos Number", "HIP 93864"},
        {"Fundamental Katalog 5th Edition", "FK5 1496"},
        {"Geneva Identification System", "GEN# +1.00177716"},
        {"Smithsonian Astrophysical Observation", "SAO 187683"},
        {"Wilson Evans Batten Catalogue", "WEB 16322"},
    },
    visualMagnitude: 3.32,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.73517629),
        dec: Angle.Degrees(-27.66981416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10947"},
        {"Hipparcos Number", "HIP 8293"},
        {"Geneva Identification System", "GEN# +1.00010947"},
        {"Smithsonian Astrophysical Observation", "SAO 167289"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.73232851),
        dec: Angle.Degrees(-27.66952083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24661"},
        {"Hipparcos Number", "HIP 18254"},
        {"Smithsonian Astrophysical Observation", "SAO 168933"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.57212295),
        dec: Angle.Degrees(-27.66892941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62475"},
        {"Hipparcos Number", "HIP 37611"},
        {"Smithsonian Astrophysical Observation", "SAO 174367"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.76276579),
        dec: Angle.Degrees(-27.66841012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128514"},
        {"Hipparcos Number", "HIP 71547"},
        {"Smithsonian Astrophysical Observation", "SAO 182721"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.50293579),
        dec: Angle.Degrees(-27.66810604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9062 A"},
        {"Henry Draper", "HD 121579"},
        {"Hipparcos Number", "HIP 68133"},
        {"Geneva Identification System", "GEN# +1.00121579A"},
        {"Smithsonian Astrophysical Observation", "SAO 182105"},
        {"Wilson Evans Batten Catalogue", "WEB 11957"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.21983539),
        dec: Angle.Degrees(-27.66164984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32708"},
        {"Hipparcos Number", "HIP 23559"},
        {"Smithsonian Astrophysical Observation", "SAO 170032"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.98386502),
        dec: Angle.Degrees(-27.65939396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27939"},
        {"Hipparcos Number", "HIP 20489"},
        {"Geneva Identification System", "GEN# +1.00027939"},
        {"Smithsonian Astrophysical Observation", "SAO 169399"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.87014354),
        dec: Angle.Degrees(-27.65782225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9453"},
        {"Aitken 2", "ADS 9453 AB"},
        {"Henry Draper", "HD 132219"},
        {"Hipparcos Number", "HIP 73284"},
        {"Geneva Identification System", "GEN# +1.00132219"},
        {"Smithsonian Astrophysical Observation", "SAO 183058"},
        {"Wilson Evans Batten Catalogue", "WEB 12554"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.66369181),
        dec: Angle.Degrees(-27.65729301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4144 A"},
        {"Henry Draper", "HD 36676"},
        {"Hipparcos Number", "HIP 25946"},
        {"Smithsonian Astrophysical Observation", "SAO 170527"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.05774799),
        dec: Angle.Degrees(-27.65720208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91964"},
        {"Hipparcos Number", "HIP 51943"},
        {"Geneva Identification System", "GEN# +1.00091964"},
        {"Smithsonian Astrophysical Observation", "SAO 179027"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.17752341),
        dec: Angle.Degrees(-27.65637385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74616"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.68394408),
        dec: Angle.Degrees(-27.65629927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25804"},
        {"Hipparcos Number", "HIP 19010"},
        {"Geneva Identification System", "GEN# +1.00025804"},
        {"Smithsonian Astrophysical Observation", "SAO 169092"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.09442359),
        dec: Angle.Degrees(-27.65475172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42344"},
        {"Smithsonian Astrophysical Observation", "SAO 176193"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.49460965),
        dec: Angle.Degrees(-27.65216381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25945"},
        {"Hipparcos Number", "HIP 19095"},
        {"Fundamental Katalog 5th Edition", "FK5 153"},
        {"Geneva Identification System", "GEN# +1.00025945"},
        {"Smithsonian Astrophysical Observation", "SAO 169110"},
        {"Wilson Evans Batten Catalogue", "WEB 3667"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40543294),
        dec: Angle.Degrees(-27.65203636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175978"},
        {"Hipparcos Number", "HIP 93196"},
        {"Smithsonian Astrophysical Observation", "SAO 187531"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.74584260),
        dec: Angle.Degrees(-27.65190055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118394"},
        {"Hipparcos Number", "HIP 66428"},
        {"Geneva Identification System", "GEN# +1.00118394"},
        {"Smithsonian Astrophysical Observation", "SAO 181794"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.27641299),
        dec: Angle.Degrees(-27.65183536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91209"},
        {"Hipparcos Number", "HIP 51518"},
        {"Smithsonian Astrophysical Observation", "SAO 178926"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.83508534),
        dec: Angle.Degrees(-27.65075047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104516"},
        {"Hipparcos Number", "HIP 58689"},
        {"Smithsonian Astrophysical Observation", "SAO 180396"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.55605881),
        dec: Angle.Degrees(-27.64779289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119641"},
        {"Hipparcos Number", "HIP 67075"},
        {"Smithsonian Astrophysical Observation", "SAO 181922"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.21443907),
        dec: Angle.Degrees(-27.64737290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176266"},
        {"Hipparcos Number", "HIP 93328"},
        {"Smithsonian Astrophysical Observation", "SAO 187563"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.13616375),
        dec: Angle.Degrees(-27.64515235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9733 AB"},
        {"Henry Draper", "HD 139519"},
        {"Hipparcos Number", "HIP 76690"},
        {"Smithsonian Astrophysical Observation", "SAO 183668"},
    },
    visualMagnitude: 7.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.90172214),
        dec: Angle.Degrees(-27.64325200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64436"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.09954979),
        dec: Angle.Degrees(-27.64308872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142749"},
        {"Hipparcos Number", "HIP 78130"},
        {"Geneva Identification System", "GEN# +1.00142749"},
        {"Smithsonian Astrophysical Observation", "SAO 183965"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.30705147),
        dec: Angle.Degrees(-27.64243281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75921"},
        {"Hipparcos Number", "HIP 43533"},
        {"Geneva Identification System", "GEN# +1.00075921"},
        {"Smithsonian Astrophysical Observation", "SAO 176599"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.99510391),
        dec: Angle.Degrees(-27.64159038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18819"},
        {"Hipparcos Number", "HIP 14035"},
        {"Geneva Identification System", "GEN# +1.00018819"},
        {"Smithsonian Astrophysical Observation", "SAO 168221"},
        {"Wilson Evans Batten Catalogue", "WEB 2765"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.18145398),
        dec: Angle.Degrees(-27.64154772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70394"},
        {"Hipparcos Number", "HIP 40897"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.20974032),
        dec: Angle.Degrees(-27.64011854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69319"},
        {"Hipparcos Number", "HIP 40440"},
        {"Smithsonian Astrophysical Observation", "SAO 175464"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.86195937),
        dec: Angle.Degrees(-27.63938873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222614"},
        {"Hipparcos Number", "HIP 116943"},
        {"Geneva Identification System", "GEN# +1.00222614"},
        {"Smithsonian Astrophysical Observation", "SAO 192097"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.56826528),
        dec: Angle.Degrees(-27.63864961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121524"},
        {"Hipparcos Number", "HIP 68099"},
        {"Geneva Identification System", "GEN# +1.00121524"},
        {"Smithsonian Astrophysical Observation", "SAO 182102"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.13023150),
        dec: Angle.Degrees(-27.63808622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136460"},
        {"Hipparcos Number", "HIP 75172"},
        {"Geneva Identification System", "GEN# +1.00136460"},
        {"Smithsonian Astrophysical Observation", "SAO 183404"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.41814349),
        dec: Angle.Degrees(-27.63776088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15337"},
        {"Hipparcos Number", "HIP 11433"},
        {"Geneva Identification System", "GEN# +1.00015337"},
        {"Smithsonian Astrophysical Observation", "SAO 167802"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86843798),
        dec: Angle.Degrees(-27.63469292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205650"},
        {"Hipparcos Number", "HIP 106749"},
        {"Geneva Identification System", "GEN# +1.00205650"},
        {"Smithsonian Astrophysical Observation", "SAO 190496"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.35753005),
        dec: Angle.Degrees(-27.63468250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 342.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83232"},
    },
    visualMagnitude: 10.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.14575196),
        dec: Angle.Degrees(-27.63450981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17882"},
        {"Hipparcos Number", "HIP 13325"},
        {"Geneva Identification System", "GEN# +1.00017882"},
        {"Smithsonian Astrophysical Observation", "SAO 168099"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.87106466),
        dec: Angle.Degrees(-27.63340104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58614"},
        {"Hipparcos Number", "HIP 36013"},
        {"Smithsonian Astrophysical Observation", "SAO 173693"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32504301),
        dec: Angle.Degrees(-27.63119699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8479 AB"},
        {"Henry Draper", "HD 106569"},
        {"Hipparcos Number", "HIP 59782"},
        {"Smithsonian Astrophysical Observation", "SAO 180610"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.86933841),
        dec: Angle.Degrees(-27.63050498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15509 A"},
        {"Henry Draper", "HD 208851"},
        {"Hipparcos Number", "HIP 108571"},
        {"Smithsonian Astrophysical Observation", "SAO 190800"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.89471680),
        dec: Angle.Degrees(-27.63046164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84458"},
        {"Hipparcos Number", "HIP 47811"},
        {"Geneva Identification System", "GEN# +1.00084458"},
        {"Smithsonian Astrophysical Observation", "SAO 177923"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.19926605),
        dec: Angle.Degrees(-27.63042977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114894"},
        {"Hipparcos Number", "HIP 64548"},
        {"Smithsonian Astrophysical Observation", "SAO 181470"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.44954204),
        dec: Angle.Degrees(-27.62931297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163937"},
        {"Hipparcos Number", "HIP 88120"},
        {"Smithsonian Astrophysical Observation", "SAO 186062"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.97159863),
        dec: Angle.Degrees(-27.62895605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120391"},
        {"Hipparcos Number", "HIP 67473"},
        {"Smithsonian Astrophysical Observation", "SAO 181991"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.40625208),
        dec: Angle.Degrees(-27.62836251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137670"},
        {"Hipparcos Number", "HIP 75721"},
        {"Smithsonian Astrophysical Observation", "SAO 183489"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.04598665),
        dec: Angle.Degrees(-27.62611819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5023"},
        {"Hipparcos Number", "HIP 4060"},
        {"Smithsonian Astrophysical Observation", "SAO 166637"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.99414647),
        dec: Angle.Degrees(-27.62470962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188516"},
        {"Hipparcos Number", "HIP 98127"},
        {"Smithsonian Astrophysical Observation", "SAO 188732"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.14873952),
        dec: Angle.Degrees(-27.62202417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47186"},
        {"Hipparcos Number", "HIP 31540"},
        {"Geneva Identification System", "GEN# +1.00047186"},
        {"Smithsonian Astrophysical Observation", "SAO 172008"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.03655687),
        dec: Angle.Degrees(-27.62165777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90308"},
        {"Hipparcos Number", "HIP 50991"},
        {"Smithsonian Astrophysical Observation", "SAO 178794"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.24767435),
        dec: Angle.Degrees(-27.62145093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3522"},
        {"Hipparcos Number", "HIP 2998"},
        {"Smithsonian Astrophysical Observation", "SAO 166432"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.52817414),
        dec: Angle.Degrees(-27.62114061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37213"},
        {"Hipparcos Number", "HIP 26273"},
        {"Geneva Identification System", "GEN# +1.00037213"},
        {"Smithsonian Astrophysical Observation", "SAO 170581"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.92111677),
        dec: Angle.Degrees(-27.62029823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103120"},
        {"Hipparcos Number", "HIP 57881"},
        {"Smithsonian Astrophysical Observation", "SAO 180253"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.07190655),
        dec: Angle.Degrees(-27.62001481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201901"},
        {"Hipparcos Number", "HIP 104750"},
        {"Fundamental Katalog 5th Edition", "FK5 1556"},
        {"Geneva Identification System", "GEN# +1.00201901"},
        {"Smithsonian Astrophysical Observation", "SAO 190129"},
        {"Wilson Evans Batten Catalogue", "WEB 19052"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.32194676),
        dec: Angle.Degrees(-27.61905854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2676"},
        {"Geneva Identification System", "GEN# -0.02800154"},
        {"Smithsonian Astrophysical Observation", "SAO 166369"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.47344592),
        dec: Angle.Degrees(-27.61414872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205307"},
        {"Hipparcos Number", "HIP 106576"},
        {"Smithsonian Astrophysical Observation", "SAO 190465"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.76984059),
        dec: Angle.Degrees(-27.61220494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117452"},
        {"Hipparcos Number", "HIP 65918"},
        {"Smithsonian Astrophysical Observation", "SAO 181713"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.70913764),
        dec: Angle.Degrees(-27.61128107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12407"},
        {"Hipparcos Number", "HIP 9428"},
        {"Geneva Identification System", "GEN# +1.00012407"},
        {"Smithsonian Astrophysical Observation", "SAO 167489"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.27504709),
        dec: Angle.Degrees(-27.60888859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23545"},
        {"Hipparcos Number", "HIP 17522"},
        {"Smithsonian Astrophysical Observation", "SAO 168797"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.26787945),
        dec: Angle.Degrees(-27.60735570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197629"},
        {"Hipparcos Number", "HIP 102471"},
        {"Smithsonian Astrophysical Observation", "SAO 189658"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.46322499),
        dec: Angle.Degrees(-27.60563583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6089"},
        {"Smithsonian Astrophysical Observation", "SAO 166936"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.54700955),
        dec: Angle.Degrees(-27.60456737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192568"},
        {"Hipparcos Number", "HIP 99932"},
        {"Geneva Identification System", "GEN# +1.00192568"},
        {"Smithsonian Astrophysical Observation", "SAO 189090"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.14206472),
        dec: Angle.Degrees(-27.60359486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85318",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10538 A"},
        {"Henry Draper", "HD 157736"},
        {"Hipparcos Number", "HIP 85318"},
        {"Geneva Identification System", "GEN# +1.00157736"},
        {"Smithsonian Astrophysical Observation", "SAO 185395"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.52446908),
        dec: Angle.Degrees(-27.59952599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48059",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7518 AB"},
        {"Henry Draper", "HD 84922"},
        {"Hipparcos Number", "HIP 48059"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96166185),
        dec: Angle.Degrees(-27.59853725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111295"},
        {"Hipparcos Number", "HIP 62500"},
        {"Geneva Identification System", "GEN# +1.00111295"},
        {"Smithsonian Astrophysical Observation", "SAO 181114"},
        {"Wilson Evans Batten Catalogue", "WEB 11093"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.10982759),
        dec: Angle.Degrees(-27.59723017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9552 AB"},
        {"Henry Draper", "HD 135390"},
        {"Hipparcos Number", "HIP 74675"},
        {"Smithsonian Astrophysical Observation", "SAO 183316"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.91411020),
        dec: Angle.Degrees(-27.59631485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130993"},
        {"Hipparcos Number", "HIP 72704"},
        {"Smithsonian Astrophysical Observation", "SAO 182938"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.97457949),
        dec: Angle.Degrees(-27.59536623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6548"},
        {"Hipparcos Number", "HIP 5152"},
        {"Geneva Identification System", "GEN# +1.00006548"},
        {"Smithsonian Astrophysical Observation", "SAO 166797"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.48771707),
        dec: Angle.Degrees(-27.59534882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50034"},
        {"Hipparcos Number", "HIP 32795"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.55413989),
        dec: Angle.Degrees(-27.59365957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48777"},
        {"Hipparcos Number", "HIP 32244"},
        {"Smithsonian Astrophysical Observation", "SAO 172240"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.97356927),
        dec: Angle.Degrees(-27.59143954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48289"},
        {"Hipparcos Number", "HIP 32028"},
        {"Smithsonian Astrophysical Observation", "SAO 172170"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.35797952),
        dec: Angle.Degrees(-27.58706310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196816"},
        {"Hipparcos Number", "HIP 102030"},
        {"Smithsonian Astrophysical Observation", "SAO 189558"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.14731853),
        dec: Angle.Degrees(-27.58660754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99462"},
        {"Hipparcos Number", "HIP 55822"},
        {"Smithsonian Astrophysical Observation", "SAO 179885"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.60866032),
        dec: Angle.Degrees(-27.58503078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212177"},
        {"Hipparcos Number", "HIP 110489"},
        {"Smithsonian Astrophysical Observation", "SAO 191097"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.71221032),
        dec: Angle.Degrees(-27.58477922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37459"},
        {"Hipparcos Number", "HIP 26436"},
        {"Smithsonian Astrophysical Observation", "SAO 170604"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.38745156),
        dec: Angle.Degrees(-27.58474208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141180"},
        {"Hipparcos Number", "HIP 77449"},
        {"Geneva Identification System", "GEN# +1.00141180"},
        {"Smithsonian Astrophysical Observation", "SAO 183815"},
        {"Wilson Evans Batten Catalogue", "WEB 13114"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.17877613),
        dec: Angle.Degrees(-27.58228695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21464"},
        {"Smithsonian Astrophysical Observation", "SAO 169608"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.14137621),
        dec: Angle.Degrees(-27.57867139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14880"},
        {"Smithsonian Astrophysical Observation", "SAO 168374"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.02166915),
        dec: Angle.Degrees(-27.57801458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30182"},
        {"Hipparcos Number", "HIP 22036"},
        {"Fundamental Katalog 5th Edition", "FK5 4427"},
        {"Smithsonian Astrophysical Observation", "SAO 169712"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.06367724),
        dec: Angle.Degrees(-27.57782197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118877"},
        {"Hipparcos Number", "HIP 66679"},
        {"Smithsonian Astrophysical Observation", "SAO 181843"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.03655080),
        dec: Angle.Degrees(-27.57776025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65636"},
        {"Hipparcos Number", "HIP 38983"},
        {"Smithsonian Astrophysical Observation", "SAO 174914"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.66020233),
        dec: Angle.Degrees(-27.57748522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32998"},
        {"Hipparcos Number", "HIP 23722"},
        {"Smithsonian Astrophysical Observation", "SAO 170062"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.49842748),
        dec: Angle.Degrees(-27.57573950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193977"},
        {"Hipparcos Number", "HIP 100610"},
        {"Smithsonian Astrophysical Observation", "SAO 189236"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02458643),
        dec: Angle.Degrees(-27.57467203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20142"},
        {"Hipparcos Number", "HIP 15001"},
        {"Smithsonian Astrophysical Observation", "SAO 168390"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.34158112),
        dec: Angle.Degrees(-27.57401895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151597"},
        {"Hipparcos Number", "HIP 82330"},
        {"Smithsonian Astrophysical Observation", "SAO 184673"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.34186799),
        dec: Angle.Degrees(-27.57348208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94209"},
        {"Hipparcos Number", "HIP 53118"},
        {"Smithsonian Astrophysical Observation", "SAO 179287"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.00420279),
        dec: Angle.Degrees(-27.57227724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183332"},
        {"Hipparcos Number", "HIP 95887"},
        {"Smithsonian Astrophysical Observation", "SAO 188200"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.51954749),
        dec: Angle.Degrees(-27.57140778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13168"},
        {"Hipparcos Number", "HIP 9955"},
        {"Fundamental Katalog 5th Edition", "FK5 4196"},
        {"Geneva Identification System", "GEN# +1.00013168"},
        {"Smithsonian Astrophysical Observation", "SAO 167576"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.03593481),
        dec: Angle.Degrees(-27.57131783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151559"},
        {"Hipparcos Number", "HIP 82315"},
        {"Geneva Identification System", "GEN# +1.00151559"},
        {"Smithsonian Astrophysical Observation", "SAO 184665"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.28384654),
        dec: Angle.Degrees(-27.57085188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148499"},
        {"Hipparcos Number", "HIP 80778"},
        {"Geneva Identification System", "GEN# +1.00148499"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.40302678),
        dec: Angle.Degrees(-27.57048846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13288"},
        {"Hipparcos Number", "HIP 10040"},
        {"Smithsonian Astrophysical Observation", "SAO 167593"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.30487313),
        dec: Angle.Degrees(-27.56908335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64448"},
        {"Smithsonian Astrophysical Observation", "SAO 181456"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.14262804),
        dec: Angle.Degrees(-27.56804947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121787"},
        {"Hipparcos Number", "HIP 68242"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.55877946),
        dec: Angle.Degrees(-27.56676038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109086"},
        {"Hipparcos Number", "HIP 61182"},
        {"Smithsonian Astrophysical Observation", "SAO 180870"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.04133667),
        dec: Angle.Degrees(-27.56621414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171226"},
        {"Hipparcos Number", "HIP 91075"},
        {"Geneva Identification System", "GEN# +1.00171226"},
        {"Smithsonian Astrophysical Observation", "SAO 186996"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.65681891),
        dec: Angle.Degrees(-27.56620751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156062"},
        {"Hipparcos Number", "HIP 84497"},
        {"Geneva Identification System", "GEN# +1.00156062"},
        {"Smithsonian Astrophysical Observation", "SAO 185218"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.12444856),
        dec: Angle.Degrees(-27.56524426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71771"},
        {"Hipparcos Number", "HIP 41534"},
        {"Geneva Identification System", "GEN# +1.00071771"},
        {"Smithsonian Astrophysical Observation", "SAO 175896"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05312825),
        dec: Angle.Degrees(-27.56474568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26217"},
        {"Hipparcos Number", "HIP 19274"},
        {"Smithsonian Astrophysical Observation", "SAO 169154"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96534070),
        dec: Angle.Degrees(-27.56437162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52646"},
        {"Hipparcos Number", "HIP 33787"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.23419157),
        dec: Angle.Degrees(-27.56426805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215852"},
        {"Hipparcos Number", "HIP 112612"},
        {"Geneva Identification System", "GEN# +1.00215852"},
        {"Smithsonian Astrophysical Observation", "SAO 191417"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.11745171),
        dec: Angle.Degrees(-27.56408753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11931"},
        {"Hipparcos Number", "HIP 9053"},
        {"Smithsonian Astrophysical Observation", "SAO 167417"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15553036),
        dec: Angle.Degrees(-27.56406753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132412"},
        {"Hipparcos Number", "HIP 73386"},
        {"Smithsonian Astrophysical Observation", "SAO 183069"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.96296556),
        dec: Angle.Degrees(-27.56343218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51040"},
        {"Hipparcos Number", "HIP 33197"},
        {"Geneva Identification System", "GEN# +1.00051040J"},
        {"Smithsonian Astrophysical Observation", "SAO 172556"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.63739268),
        dec: Angle.Degrees(-27.55941322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39234"},
        {"Hipparcos Number", "HIP 27542"},
        {"Smithsonian Astrophysical Observation", "SAO 170897"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.48995818),
        dec: Angle.Degrees(-27.55712026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7947"},
        {"Smithsonian Astrophysical Observation", "SAO 167238"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.52347796),
        dec: Angle.Degrees(-27.55688133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89338"},
        {"Hipparcos Number", "HIP 50438"},
        {"Smithsonian Astrophysical Observation", "SAO 178640"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.47147371),
        dec: Angle.Degrees(-27.55328888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212195"},
        {"Hipparcos Number", "HIP 110491"},
        {"Smithsonian Astrophysical Observation", "SAO 191099"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.72711974),
        dec: Angle.Degrees(-27.55302260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9948 AB"},
        {"Henry Draper", "HD 145408"},
        {"Hipparcos Number", "HIP 79363"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.96124197),
        dec: Angle.Degrees(-27.55263812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26657"},
        {"Hipparcos Number", "HIP 19600"},
        {"Geneva Identification System", "GEN# +1.00026657"},
        {"Smithsonian Astrophysical Observation", "SAO 169215"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99826980),
        dec: Angle.Degrees(-27.55165328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11928 AB"},
        {"Henry Draper", "HD 176419"},
        {"Hipparcos Number", "HIP 93392"},
        {"Smithsonian Astrophysical Observation", "SAO 187578"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.32080875),
        dec: Angle.Degrees(-27.55057434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48363"},
        {"Smithsonian Astrophysical Observation", "SAO 178101"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.89323180),
        dec: Angle.Degrees(-27.55015094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223339"},
        {"Hipparcos Number", "HIP 117440"},
        {"Smithsonian Astrophysical Observation", "SAO 192165"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.19252965),
        dec: Angle.Degrees(-27.54895256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99332"},
        {"Hipparcos Number", "HIP 55774"},
        {"Geneva Identification System", "GEN# +1.00099332"},
        {"Smithsonian Astrophysical Observation", "SAO 179870"},
        {"Wilson Evans Batten Catalogue", "WEB 10024"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.42463273),
        dec: Angle.Degrees(-27.54877764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49870"},
        {"Hipparcos Number", "HIP 32706"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.35384190),
        dec: Angle.Degrees(-27.54852270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38383"},
        {"Hipparcos Number", "HIP 27052"},
        {"Smithsonian Astrophysical Observation", "SAO 170754"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.05159617),
        dec: Angle.Degrees(-27.54520647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88026"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.69722213),
        dec: Angle.Degrees(-27.54496496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6544 A"},
        {"Henry Draper", "HD 66454"},
        {"Henry Draper 2", "HD 66454A"},
        {"Hipparcos Number", "HIP 39352"},
        {"Smithsonian Astrophysical Observation", "SAO 175052"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.65592346),
        dec: Angle.Degrees(-27.54429306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316648"},
        {"Hipparcos Number", "HIP 87719"},
        {"Smithsonian Astrophysical Observation", "SAO 185931"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.77755308),
        dec: Angle.Degrees(-27.54198174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51823"},
        {"Hipparcos Number", "HIP 33492"},
        {"Celescope Catalog", "CEL 1456"},
        {"Geneva Identification System", "GEN# +5.11210039"},
        {"Smithsonian Astrophysical Observation", "SAO 172650"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.42765274),
        dec: Angle.Degrees(-27.53752364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3772"},
        {"Smithsonian Astrophysical Observation", "SAO 166590"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.10802085),
        dec: Angle.Degrees(-27.53692500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5155"},
    },
    visualMagnitude: 12.09,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.50265049),
        dec: Angle.Degrees(-27.53646456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97056"},
        {"Hipparcos Number", "HIP 54578"},
        {"Smithsonian Astrophysical Observation", "SAO 179610"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.53271970),
        dec: Angle.Degrees(-27.53188464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200458"},
        {"Hipparcos Number", "HIP 104011"},
        {"Smithsonian Astrophysical Observation", "SAO 189982"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.08554925),
        dec: Angle.Degrees(-27.53150729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1002"},
        {"Hipparcos Number", "HIP 1144"},
        {"Geneva Identification System", "GEN# +1.00001002"},
        {"Smithsonian Astrophysical Observation", "SAO 166137"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58425700),
        dec: Angle.Degrees(-27.53107904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143194"},
        {"Hipparcos Number", "HIP 78381"},
        {"Smithsonian Astrophysical Observation", "SAO 184009"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.02161886),
        dec: Angle.Degrees(-27.52873396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81528"},
        {"Hipparcos Number", "HIP 46218"},
        {"Geneva Identification System", "GEN# +1.00081528"},
        {"Smithsonian Astrophysical Observation", "SAO 177425"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.34671276),
        dec: Angle.Degrees(-27.52744957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139541"},
        {"Hipparcos Number", "HIP 76694"},
        {"Smithsonian Astrophysical Observation", "SAO 183669"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.90870255),
        dec: Angle.Degrees(-27.52451817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68148",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9064 AB"},
        {"Henry Draper", "HD 121632"},
        {"Hipparcos Number", "HIP 68148"},
        {"Geneva Identification System", "GEN# +1.00121632"},
        {"Smithsonian Astrophysical Observation", "SAO 182111"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27786887),
        dec: Angle.Degrees(-27.52368384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68535"},
        {"Hipparcos Number", "HIP 40139"},
        {"Geneva Identification System", "GEN# +1.00068535"},
        {"Smithsonian Astrophysical Observation", "SAO 175365"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95931922),
        dec: Angle.Degrees(-27.52355232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32968"},
        {"Hipparcos Number", "HIP 23711"},
        {"Smithsonian Astrophysical Observation", "SAO 170060"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.45906028),
        dec: Angle.Degrees(-27.52247158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7452 AB"},
        {"Henry Draper", "HD 83196"},
        {"Hipparcos Number", "HIP 47106"},
        {"Smithsonian Astrophysical Observation", "SAO 177722"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01230828),
        dec: Angle.Degrees(-27.52202781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69894",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9207"},
        {"Henry Draper", "HD 125131"},
        {"Hipparcos Number", "HIP 69894"},
    },
    visualMagnitude: 8.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.55083630),
        dec: Angle.Degrees(-27.52114425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45301"},
        {"Geneva Identification System", "GEN# -0.02706378"},
        {"Smithsonian Astrophysical Observation", "SAO 177146"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.49822041),
        dec: Angle.Degrees(-27.51977378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30984"},
        {"Hipparcos Number", "HIP 22538"},
        {"Smithsonian Astrophysical Observation", "SAO 169814"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.76585487),
        dec: Angle.Degrees(-27.51973266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63487"},
        {"Hipparcos Number", "HIP 38072"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.02509683),
        dec: Angle.Degrees(-27.51971342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16973 AB"},
        {"Henry Draper", "HD 222983"},
        {"Hipparcos Number", "HIP 117189"},
    },
    visualMagnitude: 8.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.41132969),
        dec: Angle.Degrees(-27.51957472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12224"},
        {"Hipparcos Number", "HIP 9302"},
        {"Smithsonian Astrophysical Observation", "SAO 167464"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.88662844),
        dec: Angle.Degrees(-27.51909402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8038 AB"},
        {"Henry Draper", "HD 95855"},
        {"Hipparcos Number", "HIP 54031"},
        {"Renson", "Renson 27600"},
        {"Smithsonian Astrophysical Observation", "SAO 179474"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.81969575),
        dec: Angle.Degrees(-27.51798567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175236"},
        {"Hipparcos Number", "HIP 92883"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.88864294),
        dec: Angle.Degrees(-27.51705905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93263"},
        {"Hipparcos Number", "HIP 52630"},
        {"Geneva Identification System", "GEN# +1.00093263"},
        {"Smithsonian Astrophysical Observation", "SAO 179200"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.44025642),
        dec: Angle.Degrees(-27.51668112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7952"},
        {"Hipparcos Number", "HIP 6123"},
        {"Geneva Identification System", "GEN# +1.00007952"},
        {"Smithsonian Astrophysical Observation", "SAO 166945"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.65203385),
        dec: Angle.Degrees(-27.51633385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16876"},
        {"Hipparcos Number", "HIP 12560"},
        {"Geneva Identification System", "GEN# +1.00016876"},
        {"Smithsonian Astrophysical Observation", "SAO 167974"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.38344593),
        dec: Angle.Degrees(-27.51623682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77339"},
        {"Hipparcos Number", "HIP 44281"},
        {"Smithsonian Astrophysical Observation", "SAO 176829"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.27618427),
        dec: Angle.Degrees(-27.51572719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54447"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.10126655),
        dec: Angle.Degrees(-27.51292727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13614"},
        {"Hipparcos Number", "HIP 10268"},
        {"Smithsonian Astrophysical Observation", "SAO 167629"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.04481543),
        dec: Angle.Degrees(-27.51237778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102639"},
        {"Hipparcos Number", "HIP 57627"},
        {"Smithsonian Astrophysical Observation", "SAO 180210"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.23811486),
        dec: Angle.Degrees(-27.50980676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44663"},
        {"Hipparcos Number", "HIP 30244"},
        {"Geneva Identification System", "GEN# +1.00044663"},
        {"Smithsonian Astrophysical Observation", "SAO 171627"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.43202630),
        dec: Angle.Degrees(-27.50710582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117987"},
        {"Hipparcos Number", "HIP 66229"},
        {"Cincinnati Publication", "Ci 20 788"},
        {"Geneva Identification System", "GEN# +1.00117987"},
        {"Smithsonian Astrophysical Observation", "SAO 181762"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.60528272),
        dec: Angle.Degrees(-27.50625507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -576.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53461"},
        {"Hipparcos Number", "HIP 34067"},
        {"Celescope Catalog", "CEL 1549"},
        {"Smithsonian Astrophysical Observation", "SAO 172886"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.99182930),
        dec: Angle.Degrees(-27.50565027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1931 AB"},
        {"Henry Draper", "HD 15783"},
        {"Hipparcos Number", "HIP 11744"},
        {"Renson", "Renson 3930"},
        {"Smithsonian Astrophysical Observation", "SAO 167853"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.88998940),
        dec: Angle.Degrees(-27.50459538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61026"},
        {"Hipparcos Number", "HIP 36987"},
        {"Geneva Identification System", "GEN# +1.00061026"},
        {"Smithsonian Astrophysical Observation", "SAO 174097"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.03496631),
        dec: Angle.Degrees(-27.50385474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113291"},
        {"Hipparcos Number", "HIP 63679"},
        {"Geneva Identification System", "GEN# +1.00113291"},
        {"Smithsonian Astrophysical Observation", "SAO 181343"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.75404903),
        dec: Angle.Degrees(-27.50335820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89366",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11173 A"},
        {"Henry Draper", "HD 166968"},
        {"Hipparcos Number", "HIP 89366"},
        {"Geneva Identification System", "GEN# +1.00166968"},
        {"Renson", "Renson 47000"},
        {"Smithsonian Astrophysical Observation", "SAO 186505"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.54510988),
        dec: Angle.Degrees(-27.50275589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115167"},
        {"Geneva Identification System", "GEN# +0.00204651"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91780245),
        dec: Angle.Degrees(+03.37164682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 304.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168942"},
        {"Hipparcos Number", "HIP 90121"},
        {"Smithsonian Astrophysical Observation", "SAO 186747"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.85932643),
        dec: Angle.Degrees(-27.50243046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173378"},
        {"Hipparcos Number", "HIP 92086"},
        {"Geneva Identification System", "GEN# +1.00173378"},
        {"Smithsonian Astrophysical Observation", "SAO 187246"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51600626),
        dec: Angle.Degrees(-27.49906167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167683"},
        {"Hipparcos Number", "HIP 89625"},
        {"Smithsonian Astrophysical Observation", "SAO 186595"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.35630317),
        dec: Angle.Degrees(-27.49761454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18874"},
        {"Hipparcos Number", "HIP 14070"},
        {"Smithsonian Astrophysical Observation", "SAO 168233"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.32350072),
        dec: Angle.Degrees(-27.49335988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72466"},
        {"Hipparcos Number", "HIP 41860"},
        {"Smithsonian Astrophysical Observation", "SAO 176027"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.02069511),
        dec: Angle.Degrees(-27.49330256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165269"},
        {"Hipparcos Number", "HIP 88683"},
        {"Geneva Identification System", "GEN# +1.00165269"},
        {"Smithsonian Astrophysical Observation", "SAO 186271"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.55723377),
        dec: Angle.Degrees(-27.49259298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55070"},
        {"Hipparcos Number", "HIP 34624"},
        {"Geneva Identification System", "GEN# +1.00055070"},
        {"Smithsonian Astrophysical Observation", "SAO 173122"},
        {"Wilson Evans Batten Catalogue", "WEB 6931"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.58052770),
        dec: Angle.Degrees(-27.49152460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187991"},
        {"Hipparcos Number", "HIP 97921"},
        {"Smithsonian Astrophysical Observation", "SAO 188684"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.50370355),
        dec: Angle.Degrees(-27.49065298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3892 AB"},
        {"Henry Draper", "HD 34659"},
        {"Hipparcos Number", "HIP 24710"},
        {"Geneva Identification System", "GEN# +1.00034659J"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.50173415),
        dec: Angle.Degrees(-27.49043791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116436",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16850 AB"},
        {"Aitken 2", "ADS 16850"},
        {"Henry Draper", "HD 221839"},
        {"Hipparcos Number", "HIP 116436"},
        {"Geneva Identification System", "GEN# +1.00221839"},
        {"Smithsonian Astrophysical Observation", "SAO 192020"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.91664518),
        dec: Angle.Degrees(-27.49009784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38567"},
        {"Hipparcos Number", "HIP 27169"},
        {"Smithsonian Astrophysical Observation", "SAO 170796"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37767562),
        dec: Angle.Degrees(-27.48444707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75920"},
        {"Hipparcos Number", "HIP 43541"},
        {"Geneva Identification System", "GEN# +1.00075920"},
        {"Smithsonian Astrophysical Observation", "SAO 176601"},
        {"Wilson Evans Batten Catalogue", "WEB 8392"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.01833168),
        dec: Angle.Degrees(-27.48375555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25587"},
        {"Hipparcos Number", "HIP 18870"},
        {"Geneva Identification System", "GEN# +1.00025587"},
        {"Smithsonian Astrophysical Observation", "SAO 169060"},
        {"Wilson Evans Batten Catalogue", "WEB 3634"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.67786946),
        dec: Angle.Degrees(-27.48372965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95248"},
        {"Hipparcos Number", "HIP 53724"},
        {"Smithsonian Astrophysical Observation", "SAO 179405"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.88107939),
        dec: Angle.Degrees(-27.48274715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133802"},
        {"Hipparcos Number", "HIP 73981"},
        {"Geneva Identification System", "GEN# +1.00133802"},
        {"Smithsonian Astrophysical Observation", "SAO 183189"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.78433465),
        dec: Angle.Degrees(-27.47730955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86301"},
        {"Hipparcos Number", "HIP 48776"},
        {"Geneva Identification System", "GEN# +1.00086301"},
        {"Smithsonian Astrophysical Observation", "SAO 178216"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.22558279),
        dec: Angle.Degrees(-27.47521203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55595"},
        {"Hipparcos Number", "HIP 34814"},
        {"Geneva Identification System", "GEN# +1.00055595"},
        {"Smithsonian Astrophysical Observation", "SAO 173200"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10076225),
        dec: Angle.Degrees(-27.47473692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187473"},
        {"Hipparcos Number", "HIP 97684"},
        {"Geneva Identification System", "GEN# +1.00187473"},
        {"Renson", "Renson 51690"},
        {"Smithsonian Astrophysical Observation", "SAO 188626"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.79260323),
        dec: Angle.Degrees(-27.47194867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97850"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.28335061),
        dec: Angle.Degrees(-27.47077697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206358"},
        {"Hipparcos Number", "HIP 107147"},
        {"Smithsonian Astrophysical Observation", "SAO 190563"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.54871164),
        dec: Angle.Degrees(-27.47071465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158981"},
        {"Hipparcos Number", "HIP 85909"},
        {"Geneva Identification System", "GEN# +1.00158981"},
        {"Smithsonian Astrophysical Observation", "SAO 185499"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.33610095),
        dec: Angle.Degrees(-27.46963778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116742"},
        {"Hipparcos Number", "HIP 65529"},
        {"Renson", "Renson 33680"},
        {"Smithsonian Astrophysical Observation", "SAO 181644"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.49869162),
        dec: Angle.Degrees(-27.46920722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134573"},
        {"Hipparcos Number", "HIP 74318"},
        {"Smithsonian Astrophysical Observation", "SAO 183249"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.85200213),
        dec: Angle.Degrees(-27.46879792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115559"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.11529375),
        dec: Angle.Degrees(-27.46811679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220269"},
        {"Hipparcos Number", "HIP 115406"},
        {"Smithsonian Astrophysical Observation", "SAO 191851"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.66837817),
        dec: Angle.Degrees(-27.46494612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6449 AB"},
        {"Henry Draper", "HD 64593"},
        {"Hipparcos Number", "HIP 38550"},
        {"Smithsonian Astrophysical Observation", "SAO 174749"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.40998960),
        dec: Angle.Degrees(-27.46375808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76684"},
        {"Hipparcos Number", "HIP 43926"},
        {"Smithsonian Astrophysical Observation", "SAO 176738"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.21388897),
        dec: Angle.Degrees(-27.46337333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27814"},
        {"Smithsonian Astrophysical Observation", "SAO 170969"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28330831),
        dec: Angle.Degrees(-27.46041508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210834"},
        {"Hipparcos Number", "HIP 109731"},
        {"Smithsonian Astrophysical Observation", "SAO 190975"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.41512117),
        dec: Angle.Degrees(-27.45904706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102334"},
        {"Hipparcos Number", "HIP 120413"},
    },
    visualMagnitude: 10.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)46, 36.4600),
        dec: Angle.DegreesMinutesSeconds((int)-27, (int)27, 32.100)
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
    primaryId: "HIP 114090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114090"},
        {"Smithsonian Astrophysical Observation", "SAO 191648"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.61440141),
        dec: Angle.Degrees(-27.45759527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140403"},
        {"Hipparcos Number", "HIP 77087"},
        {"Smithsonian Astrophysical Observation", "SAO 183746"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.09559508),
        dec: Angle.Degrees(-27.45656425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81939",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10173 AB"},
        {"Henry Draper", "HD 150768"},
        {"Hipparcos Number", "HIP 81939"},
        {"Geneva Identification System", "GEN# +1.00150768J"},
        {"Smithsonian Astrophysical Observation", "SAO 184591"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07251811),
        dec: Angle.Degrees(-27.45621900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150863"},
        {"Hipparcos Number", "HIP 81981"},
        {"Smithsonian Astrophysical Observation", "SAO 184599"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.20777390),
        dec: Angle.Degrees(-27.45606412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184370"},
        {"Hipparcos Number", "HIP 96332"},
        {"Smithsonian Astrophysical Observation", "SAO 188306"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.78676751),
        dec: Angle.Degrees(-27.45163428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81552"},
        {"Hipparcos Number", "HIP 46241"},
        {"Smithsonian Astrophysical Observation", "SAO 177428"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.41048617),
        dec: Angle.Degrees(-27.45152692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199339"},
        {"Hipparcos Number", "HIP 103434"},
        {"Smithsonian Astrophysical Observation", "SAO 189869"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.33885604),
        dec: Angle.Degrees(-27.45111300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56451"},
        {"Hipparcos Number", "HIP 35148"},
        {"Geneva Identification System", "GEN# +1.00056451"},
        {"Smithsonian Astrophysical Observation", "SAO 173325"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98109042),
        dec: Angle.Degrees(-27.44831698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316271"},
        {"Hipparcos Number", "HIP 87128"},
        {"Geneva Identification System", "GEN# +1.00316271"},
        {"Smithsonian Astrophysical Observation", "SAO 185773"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.02721549),
        dec: Angle.Degrees(-27.44619598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194566"},
        {"Hipparcos Number", "HIP 100883"},
        {"Smithsonian Astrophysical Observation", "SAO 189298"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.83314666),
        dec: Angle.Degrees(-27.44555764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172533"},
        {"Hipparcos Number", "HIP 91682"},
        {"Geneva Identification System", "GEN# +1.00172533"},
        {"Smithsonian Astrophysical Observation", "SAO 187141"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.44815867),
        dec: Angle.Degrees(-27.44483775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214385"},
        {"Hipparcos Number", "HIP 111746"},
        {"Cincinnati Publication", "Ci 20 1376"},
        {"Geneva Identification System", "GEN# +1.00214385"},
        {"Smithsonian Astrophysical Observation", "SAO 191284"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.54469988),
        dec: Angle.Degrees(-27.44347400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 446.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74126"},
        {"Hipparcos Number", "HIP 42625"},
        {"Smithsonian Astrophysical Observation", "SAO 176302"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.30657719),
        dec: Angle.Degrees(-27.44095234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68026"},
        {"Hipparcos Number", "HIP 39968"},
        {"Geneva Identification System", "GEN# +1.00068026"},
        {"Smithsonian Astrophysical Observation", "SAO 175290"},
    },
    visualMagnitude: 9.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.41594972),
        dec: Angle.Degrees(-27.43917188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31957"},
        {"Hipparcos Number", "HIP 23133"},
        {"Smithsonian Astrophysical Observation", "SAO 169939"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.67151383),
        dec: Angle.Degrees(-27.43831961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224146"},
        {"Hipparcos Number", "HIP 117951"},
        {"Smithsonian Astrophysical Observation", "SAO 192238"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.88154997),
        dec: Angle.Degrees(-27.43773740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3922"},
        {"Geneva Identification System", "GEN# -0.02800258"},
        {"Smithsonian Astrophysical Observation", "SAO 166618"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.58640031),
        dec: Angle.Degrees(-27.43698365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109634"},
        {"Hipparcos Number", "HIP 61518"},
        {"Smithsonian Astrophysical Observation", "SAO 180941"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.06531430),
        dec: Angle.Degrees(-27.43054527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122430"},
        {"Hipparcos Number", "HIP 68581"},
        {"Geneva Identification System", "GEN# +1.00122430"},
        {"Smithsonian Astrophysical Observation", "SAO 182182"},
        {"Wilson Evans Batten Catalogue", "WEB 12009"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.59501153),
        dec: Angle.Degrees(-27.42976294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4124"},
        {"Smithsonian Astrophysical Observation", "SAO 166648"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.21014351),
        dec: Angle.Degrees(-27.42962738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102019"},
        {"Hipparcos Number", "HIP 57243"},
        {"Smithsonian Astrophysical Observation", "SAO 180148"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.07280812),
        dec: Angle.Degrees(-27.42849530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18622"},
        {"Smithsonian Astrophysical Observation", "SAO 169005"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.77394652),
        dec: Angle.Degrees(-27.42721544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41172"},
        {"Hipparcos Number", "HIP 28591"},
        {"Geneva Identification System", "GEN# +1.00041172"},
        {"Smithsonian Astrophysical Observation", "SAO 171158"},
        {"Wilson Evans Batten Catalogue", "WEB 5587"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.52700196),
        dec: Angle.Degrees(-27.42705401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90198"},
        {"Hipparcos Number", "HIP 50940"},
        {"Geneva Identification System", "GEN# +1.00090198"},
        {"Renson", "Renson 25930"},
        {"Smithsonian Astrophysical Observation", "SAO 178774"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.05496694),
        dec: Angle.Degrees(-27.42599134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26151"},
        {"Hipparcos Number", "HIP 19232"},
        {"Geneva Identification System", "GEN# +1.00026151"},
        {"Smithsonian Astrophysical Observation", "SAO 169142"},
        {"Wilson Evans Batten Catalogue", "WEB 3690"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.83651959),
        dec: Angle.Degrees(-27.42506912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220717"},
        {"Hipparcos Number", "HIP 115681"},
        {"Smithsonian Astrophysical Observation", "SAO 191903"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.55108552),
        dec: Angle.Degrees(-27.42462967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35109"},
        {"Smithsonian Astrophysical Observation", "SAO 173315"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.89462186),
        dec: Angle.Degrees(-27.42267026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127270"},
        {"Hipparcos Number", "HIP 70984"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.78429880),
        dec: Angle.Degrees(-27.42257450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61209"},
        {"Hipparcos Number", "HIP 37070"},
        {"Celescope Catalog", "CEL 1952"},
        {"Geneva Identification System", "GEN# +1.00061209J"},
        {"Smithsonian Astrophysical Observation", "SAO 174137"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.26980420),
        dec: Angle.Degrees(-27.42169730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212127"},
        {"Hipparcos Number", "HIP 110466"},
        {"Smithsonian Astrophysical Observation", "SAO 191092"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.64307090),
        dec: Angle.Degrees(-27.42086606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 514 A"},
        {"Henry Draper", "HD 3389"},
        {"Hipparcos Number", "HIP 2893"},
        {"Geneva Identification System", "GEN# +1.00003389"},
        {"Smithsonian Astrophysical Observation", "SAO 166410"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.17931717),
        dec: Angle.Degrees(-27.41938409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13252"},
        {"Hipparcos Number", "HIP 10012"},
        {"Geneva Identification System", "GEN# +1.00013252"},
        {"Smithsonian Astrophysical Observation", "SAO 167587"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.23567847),
        dec: Angle.Degrees(-27.41906020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84517"},
    },
    visualMagnitude: 10.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.16304511),
        dec: Angle.Degrees(+03.40259155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156882"},
        {"Hipparcos Number", "HIP 84903"},
        {"Geneva Identification System", "GEN# +1.00156882"},
        {"Smithsonian Astrophysical Observation", "SAO 185295"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.27336171),
        dec: Angle.Degrees(-27.41795862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69102"},
        {"Hipparcos Number", "HIP 40370"},
        {"Geneva Identification System", "GEN# +1.00069102"},
        {"Smithsonian Astrophysical Observation", "SAO 175437"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.63082890),
        dec: Angle.Degrees(-27.41680778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85481"},
        {"Hipparcos Number", "HIP 48353"},
        {"Geneva Identification System", "GEN# +1.00085481"},
        {"Smithsonian Astrophysical Observation", "SAO 178096"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.84875816),
        dec: Angle.Degrees(-27.41644805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63624"},
        {"Hipparcos Number", "HIP 38130"},
        {"Smithsonian Astrophysical Observation", "SAO 174590"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.20840110),
        dec: Angle.Degrees(-27.41538122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82678"},
        {"Hipparcos Number", "HIP 46841"},
        {"Smithsonian Astrophysical Observation", "SAO 177626"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.17279526),
        dec: Angle.Degrees(-27.41476271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1988"},
        {"Hipparcos Number", "HIP 1898"},
        {"Geneva Identification System", "GEN# +1.00001988"},
        {"Smithsonian Astrophysical Observation", "SAO 166238"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.99562113),
        dec: Angle.Degrees(-27.41287398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92036"},
        {"Hipparcos Number", "HIP 51979"},
        {"Fundamental Katalog 5th Edition", "FK5 2848"},
        {"Geneva Identification System", "GEN# +1.00092036"},
        {"Smithsonian Astrophysical Observation", "SAO 179041"},
        {"Wilson Evans Batten Catalogue", "WEB 9481"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.30749487),
        dec: Angle.Degrees(-27.41268661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21556"},
        {"Hipparcos Number", "HIP 16127"},
        {"Smithsonian Astrophysical Observation", "SAO 168561"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.92735775),
        dec: Angle.Degrees(-27.41210000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36571"},
        {"Smithsonian Astrophysical Observation", "SAO 173919"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.83804003),
        dec: Angle.Degrees(-27.41180768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115890"},
        {"Hipparcos Number", "HIP 65096"},
        {"Smithsonian Astrophysical Observation", "SAO 181564"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12458045),
        dec: Angle.Degrees(-27.40998659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120606"},
        {"Hipparcos Number", "HIP 67597"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77071698),
        dec: Angle.Degrees(-27.40941848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76995"},
        {"Hipparcos Number", "HIP 44086"},
        {"Smithsonian Astrophysical Observation", "SAO 176778"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69817180),
        dec: Angle.Degrees(-27.40920661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168355"},
        {"Hipparcos Number", "HIP 89871"},
        {"Smithsonian Astrophysical Observation", "SAO 186671"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08810179),
        dec: Angle.Degrees(-27.40765206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15516"},
        {"Hipparcos Number", "HIP 11574"},
        {"Smithsonian Astrophysical Observation", "SAO 167822"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.28297443),
        dec: Angle.Degrees(-27.40715712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152933"},
        {"Hipparcos Number", "HIP 82980"},
        {"Smithsonian Astrophysical Observation", "SAO 184829"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.36339540),
        dec: Angle.Degrees(-27.40625070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46523"},
        {"Hipparcos Number", "HIP 31201"},
        {"Geneva Identification System", "GEN# +1.00046523"},
        {"Smithsonian Astrophysical Observation", "SAO 171925"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.19207584),
        dec: Angle.Degrees(-27.40458430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112019"},
        {"Hipparcos Number", "HIP 62925"},
        {"Geneva Identification System", "GEN# +1.00112019"},
        {"Smithsonian Astrophysical Observation", "SAO 181202"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42784060),
        dec: Angle.Degrees(-27.40419309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207480"},
        {"Hipparcos Number", "HIP 107766"},
        {"Fundamental Katalog 5th Edition", "FK5 3743"},
        {"Geneva Identification System", "GEN# +1.00207480"},
        {"Smithsonian Astrophysical Observation", "SAO 190660"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.47449313),
        dec: Angle.Degrees(-27.40390436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25161"},
        {"Geneva Identification System", "GEN# -0.02702233"},
        {"Smithsonian Astrophysical Observation", "SAO 170372"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75756743),
        dec: Angle.Degrees(-27.40281855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1790"},
        {"Hipparcos Number", "HIP 1750"},
        {"Geneva Identification System", "GEN# +1.00001790"},
        {"Smithsonian Astrophysical Observation", "SAO 166219"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.53844051),
        dec: Angle.Degrees(-27.39978798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59281"},
        {"Hipparcos Number", "HIP 36293"},
        {"Celescope Catalog", "CEL 1871"},
        {"Geneva Identification System", "GEN# +1.00059281"},
        {"Smithsonian Astrophysical Observation", "SAO 173808"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.05139996),
        dec: Angle.Degrees(-27.39967769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207694"},
        {"Hipparcos Number", "HIP 107884"},
        {"Smithsonian Astrophysical Observation", "SAO 190687"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.88162527),
        dec: Angle.Degrees(-27.39910170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31901"},
        {"Geneva Identification System", "GEN# -0.02703180"},
        {"Smithsonian Astrophysical Observation", "SAO 172124"},
    },
    visualMagnitude: 9.21,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.01986608),
        dec: Angle.Degrees(-27.39824403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257"},
        {"Hipparcos Number", "HIP 600"},
        {"Smithsonian Astrophysical Observation", "SAO 166062"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.81932153),
        dec: Angle.Degrees(-27.39777661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122509"},
        {"Hipparcos Number", "HIP 68632"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.73131200),
        dec: Angle.Degrees(-27.39714345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186401"},
        {"Hipparcos Number", "HIP 97195"},
        {"Smithsonian Astrophysical Observation", "SAO 188524"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31215732),
        dec: Angle.Degrees(-27.39635058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162236"},
        {"Hipparcos Number", "HIP 87369"},
        {"Geneva Identification System", "GEN# +1.00162236"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78070309),
        dec: Angle.Degrees(-27.39610817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30394"},
        {"Hipparcos Number", "HIP 22167"},
        {"Smithsonian Astrophysical Observation", "SAO 169748"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.53312237),
        dec: Angle.Degrees(-27.39508837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179452"},
        {"Hipparcos Number", "HIP 94473"},
        {"Smithsonian Astrophysical Observation", "SAO 187844"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.41374944),
        dec: Angle.Degrees(-27.39420292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117105"},
        {"Hipparcos Number", "HIP 65737"},
        {"Geneva Identification System", "GEN# +1.00117105"},
        {"Smithsonian Astrophysical Observation", "SAO 181682"},
        {"Wilson Evans Batten Catalogue", "WEB 11634"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.12792554),
        dec: Angle.Degrees(-27.39236296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2555"},
        {"Hipparcos Number", "HIP 2273"},
        {"Geneva Identification System", "GEN# +1.00002555"},
        {"Smithsonian Astrophysical Observation", "SAO 166305"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.26340982),
        dec: Angle.Degrees(-27.39184214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211395"},
        {"Hipparcos Number", "HIP 110039"},
        {"Smithsonian Astrophysical Observation", "SAO 191022"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.32280182),
        dec: Angle.Degrees(-27.38976194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211753"},
        {"Hipparcos Number", "HIP 110238"},
        {"Smithsonian Astrophysical Observation", "SAO 191060"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.95011656),
        dec: Angle.Degrees(-27.38876309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4002"},
        {"Geneva Identification System", "GEN# -0.02800262"},
        {"Smithsonian Astrophysical Observation", "SAO 166629"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.84455138),
        dec: Angle.Degrees(-27.38704614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207154"},
        {"Hipparcos Number", "HIP 107613"},
        {"Smithsonian Astrophysical Observation", "SAO 190630"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.94308228),
        dec: Angle.Degrees(-27.38696116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215699"},
        {"Hipparcos Number", "HIP 112510"},
        {"Smithsonian Astrophysical Observation", "SAO 191400"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.85079444),
        dec: Angle.Degrees(-27.38358577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154166"},
        {"Hipparcos Number", "HIP 83578"},
        {"Smithsonian Astrophysical Observation", "SAO 184998"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.21983804),
        dec: Angle.Degrees(-27.38310269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214965"},
        {"Hipparcos Number", "HIP 112096"},
        {"Smithsonian Astrophysical Observation", "SAO 191336"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.57621674),
        dec: Angle.Degrees(-27.38249159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112403"},
        {"Hipparcos Number", "HIP 63192"},
        {"Smithsonian Astrophysical Observation", "SAO 181251"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.18764713),
        dec: Angle.Degrees(-27.38201015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49702"},
        {"Hipparcos Number", "HIP 32642"},
        {"Geneva Identification System", "GEN# +1.00049702"},
        {"Smithsonian Astrophysical Observation", "SAO 172356"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.14505389),
        dec: Angle.Degrees(-27.38095070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139557"},
        {"Hipparcos Number", "HIP 76702"},
        {"Geneva Identification System", "GEN# +1.00139557"},
        {"Smithsonian Astrophysical Observation", "SAO 183672"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.92756097),
        dec: Angle.Degrees(-27.37595349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221311"},
        {"Hipparcos Number", "HIP 116073"},
        {"Smithsonian Astrophysical Observation", "SAO 191964"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.80564012),
        dec: Angle.Degrees(-27.37588472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148439"},
        {"Hipparcos Number", "HIP 80753"},
        {"Smithsonian Astrophysical Observation", "SAO 184413"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.31644181),
        dec: Angle.Degrees(-27.37535926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3835"},
        {"Hipparcos Number", "HIP 3204"},
        {"Geneva Identification System", "GEN# +1.00003835"},
        {"Smithsonian Astrophysical Observation", "SAO 166478"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19991938),
        dec: Angle.Degrees(-27.37518606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113083"},
        {"Hipparcos Number", "HIP 63559"},
        {"Cincinnati Publication", "Ci 20 756"},
        {"Geneva Identification System", "GEN# +1.00113083"},
        {"Smithsonian Astrophysical Observation", "SAO 181322"},
        {"Wilson Evans Batten Catalogue", "WEB 11248"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.36076514),
        dec: Angle.Degrees(-27.37403572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -476.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110561"},
        {"Hipparcos Number", "HIP 62063"},
        {"Smithsonian Astrophysical Observation", "SAO 181046"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.80505877),
        dec: Angle.Degrees(-27.37249649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185182"},
        {"Hipparcos Number", "HIP 96645"},
        {"Smithsonian Astrophysical Observation", "SAO 188387"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.73523423),
        dec: Angle.Degrees(-27.37143777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34868"},
        {"Hipparcos Number", "HIP 24831"},
        {"Fundamental Katalog 5th Edition", "FK5 198"},
        {"Geneva Identification System", "GEN# +1.00034868"},
        {"Smithsonian Astrophysical Observation", "SAO 170311"},
        {"Wilson Evans Batten Catalogue", "WEB 4809"},
    },
    visualMagnitude: 5.98,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.84869643),
        dec: Angle.Degrees(-27.36886420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14335 A"},
        {"Henry Draper", "HD 198278"},
        {"Hipparcos Number", "HIP 102845"},
        {"Smithsonian Astrophysical Observation", "SAO 189747"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.52113610),
        dec: Angle.Degrees(-27.36763156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209280"},
        {"Hipparcos Number", "HIP 108817"},
        {"Smithsonian Astrophysical Observation", "SAO 190846"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.67220926),
        dec: Angle.Degrees(-27.36729979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64201"},
        {"Hipparcos Number", "HIP 38380"},
        {"Smithsonian Astrophysical Observation", "SAO 174686"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.94170421),
        dec: Angle.Degrees(-27.36677113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59253"},
        {"Hipparcos Number", "HIP 36267"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01112166),
        dec: Angle.Degrees(-27.36596489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49748"},
        {"Hipparcos Number", "HIP 32666"},
        {"Geneva Identification System", "GEN# +1.00049748"},
        {"Smithsonian Astrophysical Observation", "SAO 172367"},
    },
    visualMagnitude: 9.22,
    bvColour: -0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.20491799),
        dec: Angle.Degrees(-27.36583796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102848",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14335 B"},
        {"Hipparcos Number", "HIP 102848"},
        {"Smithsonian Astrophysical Observation", "SAO 189749"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.52653481),
        dec: Angle.Degrees(-27.36566095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90812"},
        {"Hipparcos Number", "HIP 51297"},
        {"Cincinnati Publication", "Ci 20 581"},
        {"Geneva Identification System", "GEN# +1.00090812"},
        {"Smithsonian Astrophysical Observation", "SAO 178868"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.17776703),
        dec: Angle.Degrees(-27.36539738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 333.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84475"},
        {"Hipparcos Number", "HIP 47823"},
        {"Smithsonian Astrophysical Observation", "SAO 177927"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22138284),
        dec: Angle.Degrees(-27.36463789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315967"},
        {"Hipparcos Number", "HIP 86069"},
        {"Geneva Identification System", "GEN# +1.00315967"},
        {"Smithsonian Astrophysical Observation", "SAO 185527"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.85859659),
        dec: Angle.Degrees(-27.36433992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22883"},
        {"Hipparcos Number", "HIP 17078"},
        {"Smithsonian Astrophysical Observation", "SAO 168716"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.89151311),
        dec: Angle.Degrees(-27.36403504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15386"},
        {"Smithsonian Astrophysical Observation", "SAO 168454"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59742545),
        dec: Angle.Degrees(-27.36340934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9673"},
        {"Hipparcos Number", "HIP 7323"},
        {"Fundamental Katalog 5th Edition", "FK5 4142"},
        {"Geneva Identification System", "GEN# +1.00009673"},
        {"Smithsonian Astrophysical Observation", "SAO 167147"},
        {"Wilson Evans Batten Catalogue", "WEB 1575"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.57646823),
        dec: Angle.Degrees(-27.36315918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54816"},
        {"Hipparcos Number", "HIP 34528"},
        {"Celescope Catalog", "CEL 1621"},
        {"Geneva Identification System", "GEN# +1.00054816"},
        {"Smithsonian Astrophysical Observation", "SAO 173084"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.31427682),
        dec: Angle.Degrees(-27.36282921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16937"},
        {"Hipparcos Number", "HIP 12613"},
        {"Smithsonian Astrophysical Observation", "SAO 167981"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.53701232),
        dec: Angle.Degrees(-27.36073914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41110"},
        {"Hipparcos Number", "HIP 28578"},
        {"Smithsonian Astrophysical Observation", "SAO 171151"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.47180601),
        dec: Angle.Degrees(-27.35759408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10140"},
        {"Hipparcos Number", "HIP 7654"},
        {"Smithsonian Astrophysical Observation", "SAO 167195"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.63975712),
        dec: Angle.Degrees(-27.35733899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55857"},
        {"Hipparcos Number", "HIP 34924"},
        {"Celescope Catalog", "CEL 1686"},
        {"Geneva Identification System", "GEN# +5.11210033"},
        {"Smithsonian Astrophysical Observation", "SAO 173244"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.40188094),
        dec: Angle.Degrees(-27.35637407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129471"},
        {"Hipparcos Number", "HIP 71987"},
        {"Geneva Identification System", "GEN# +1.00129471"},
        {"Smithsonian Astrophysical Observation", "SAO 182798"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.84064486),
        dec: Angle.Degrees(-27.35498215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167774"},
        {"Hipparcos Number", "HIP 89662"},
        {"Smithsonian Astrophysical Observation", "SAO 186606"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46508489),
        dec: Angle.Degrees(-27.35472517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177505"},
        {"Hipparcos Number", "HIP 93790"},
    },
    visualMagnitude: 10.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.51337671),
        dec: Angle.Degrees(-27.35439835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176788"},
        {"Hipparcos Number", "HIP 93531"},
        {"Smithsonian Astrophysical Observation", "SAO 187607"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.75114282),
        dec: Angle.Degrees(-27.35349222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123243"},
        {"Hipparcos Number", "HIP 68961"},
        {"Smithsonian Astrophysical Observation", "SAO 182254"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.75808554),
        dec: Angle.Degrees(-27.35286707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117782"},
        {"Hipparcos Number", "HIP 66099"},
        {"Smithsonian Astrophysical Observation", "SAO 181743"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.24359305),
        dec: Angle.Degrees(-27.35255238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196002"},
        {"Hipparcos Number", "HIP 101600"},
        {"Smithsonian Astrophysical Observation", "SAO 189462"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.86763302),
        dec: Angle.Degrees(-27.35246374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187385"},
        {"Hipparcos Number", "HIP 97648"},
        {"Geneva Identification System", "GEN# +1.00187385"},
        {"Smithsonian Astrophysical Observation", "SAO 188621"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69341106),
        dec: Angle.Degrees(-27.35018047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91551"},
        {"Hipparcos Number", "HIP 51703"},
        {"Smithsonian Astrophysical Observation", "SAO 178978"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.46400653),
        dec: Angle.Degrees(-27.34963140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7037"},
        {"Hipparcos Number", "HIP 5499"},
        {"Geneva Identification System", "GEN# +1.00007037"},
        {"Smithsonian Astrophysical Observation", "SAO 166849"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.60122942),
        dec: Angle.Degrees(-27.34954296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10863"},
        {"Hipparcos Number", "HIP 8233"},
        {"Geneva Identification System", "GEN# +1.00010863"},
        {"Smithsonian Astrophysical Observation", "SAO 167279"},
        {"Wilson Evans Batten Catalogue", "WEB 1752"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.50414338),
        dec: Angle.Degrees(-27.34872151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124718"},
        {"Hipparcos Number", "HIP 69682"},
        {"Geneva Identification System", "GEN# +1.00124718"},
        {"Smithsonian Astrophysical Observation", "SAO 182386"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.95856076),
        dec: Angle.Degrees(-27.34856461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183331"},
        {"Hipparcos Number", "HIP 95882"},
        {"Smithsonian Astrophysical Observation", "SAO 188198"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.50684916),
        dec: Angle.Degrees(-27.34747548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36273"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01900551),
        dec: Angle.Degrees(-27.33051461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11643 AB"},
        {"Henry Draper", "HD 173427"},
        {"Hipparcos Number", "HIP 92104"},
        {"Smithsonian Astrophysical Observation", "SAO 187251"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.56783437),
        dec: Angle.Degrees(-27.34620762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156848"},
        {"Hipparcos Number", "HIP 84888"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.22777226),
        dec: Angle.Degrees(-27.34436729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12022 A"},
        {"Hipparcos Number", "HIP 93792"},
        {"Smithsonian Astrophysical Observation", "SAO 187665"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.51652887),
        dec: Angle.Degrees(-27.34375438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199809"},
        {"Hipparcos Number", "HIP 103670"},
        {"Smithsonian Astrophysical Observation", "SAO 189918"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.07916275),
        dec: Angle.Degrees(-27.34330608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25276"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.08480326),
        dec: Angle.Degrees(-27.34238467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48938"},
        {"Hipparcos Number", "HIP 32322"},
        {"Geneva Identification System", "GEN# +1.00048938"},
        {"Smithsonian Astrophysical Observation", "SAO 172264"},
        {"Wilson Evans Batten Catalogue", "WEB 6521"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.21648345),
        dec: Angle.Degrees(-27.34238072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 293.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212632"},
        {"Hipparcos Number", "HIP 110742"},
        {"Smithsonian Astrophysical Observation", "SAO 191139"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.53923560),
        dec: Angle.Degrees(-27.34040214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142250"},
        {"Hipparcos Number", "HIP 77900"},
        {"Celescope Catalog", "CEL 4402"},
        {"Geneva Identification System", "GEN# +1.00142250"},
        {"Renson", "Renson 40360"},
        {"Smithsonian Astrophysical Observation", "SAO 183907"},
        {"Wilson Evans Batten Catalogue", "WEB 13171"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.62549047),
        dec: Angle.Degrees(-27.33857445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100324",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13707 AB"},
        {"Henry Draper", "HD 193360"},
        {"Hipparcos Number", "HIP 100324"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.19177195),
        dec: Angle.Degrees(-27.33695086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207569"},
        {"Hipparcos Number", "HIP 107817"},
        {"Smithsonian Astrophysical Observation", "SAO 190673"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.63773813),
        dec: Angle.Degrees(-27.33656012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55523"},
        {"Hipparcos Number", "HIP 34786"},
        {"Celescope Catalog", "CEL 1667"},
        {"Geneva Identification System", "GEN# +1.00055523"},
        {"Smithsonian Astrophysical Observation", "SAO 173189"},
        {"Wilson Evans Batten Catalogue", "WEB 6954"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.02248700),
        dec: Angle.Degrees(-27.33495598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50012"},
        {"Hipparcos Number", "HIP 32782"},
        {"Fundamental Katalog 5th Edition", "FK5 2528"},
        {"Geneva Identification System", "GEN# +1.00050012"},
        {"Smithsonian Astrophysical Observation", "SAO 172403"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.52487686),
        dec: Angle.Degrees(-27.33397761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85725"},
        {"Hipparcos Number", "HIP 48468"},
        {"Geneva Identification System", "GEN# +1.00085725"},
        {"Smithsonian Astrophysical Observation", "SAO 178130"},
        {"Wilson Evans Batten Catalogue", "WEB 9036"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.24254341),
        dec: Angle.Degrees(-27.33240371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71997"},
        {"Hipparcos Number", "HIP 41640"},
        {"Geneva Identification System", "GEN# +1.00071997"},
        {"Smithsonian Astrophysical Observation", "SAO 175939"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.36484807),
        dec: Angle.Degrees(-27.33214512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40402"},
        {"Hipparcos Number", "HIP 28184"},
        {"Geneva Identification System", "GEN# +1.00040402"},
        {"Smithsonian Astrophysical Observation", "SAO 171065"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.32890857),
        dec: Angle.Degrees(-27.33145949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191554"},
        {"Hipparcos Number", "HIP 99499"},
        {"Smithsonian Astrophysical Observation", "SAO 189002"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.89256655),
        dec: Angle.Degrees(-27.32823277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70943"},
        {"Hipparcos Number", "HIP 41157"},
        {"Smithsonian Astrophysical Observation", "SAO 175741"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.95926404),
        dec: Angle.Degrees(-27.32788779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132151"},
        {"Hipparcos Number", "HIP 73260"},
        {"Geneva Identification System", "GEN# +1.00132151"},
        {"Smithsonian Astrophysical Observation", "SAO 183056"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.58491990),
        dec: Angle.Degrees(-27.32710853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46812"},
        {"Hipparcos Number", "HIP 31336"},
        {"Smithsonian Astrophysical Observation", "SAO 171966"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.56222714),
        dec: Angle.Degrees(-27.32574294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81184"},
        {"Smithsonian Astrophysical Observation", "SAO 184471"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.73273043),
        dec: Angle.Degrees(-27.32479609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134572"},
        {"Hipparcos Number", "HIP 74317"},
        {"Smithsonian Astrophysical Observation", "SAO 183248"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.85090066),
        dec: Angle.Degrees(-27.32332574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59629",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8463 AB"},
        {"Henry Draper", "HD 106271"},
        {"Hipparcos Number", "HIP 59629"},
        {"Smithsonian Astrophysical Observation", "SAO 180582"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.41949524),
        dec: Angle.Degrees(-27.32114603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21430"},
        {"Hipparcos Number", "HIP 16029"},
        {"Geneva Identification System", "GEN# +1.00021430"},
        {"Smithsonian Astrophysical Observation", "SAO 168544"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.59383221),
        dec: Angle.Degrees(-27.31760910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60880"},
        {"Hipparcos Number", "HIP 36937"},
        {"Geneva Identification System", "GEN# +1.00060880"},
        {"Smithsonian Astrophysical Observation", "SAO 174070"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.89742249),
        dec: Angle.Degrees(-27.31695449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207821"},
        {"Hipparcos Number", "HIP 107972"},
        {"Smithsonian Astrophysical Observation", "SAO 190697"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12100874),
        dec: Angle.Degrees(-27.31519729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45112"},
        {"Hipparcos Number", "HIP 30478"},
        {"Geneva Identification System", "GEN# +1.00045112"},
        {"Smithsonian Astrophysical Observation", "SAO 171703"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.10208440),
        dec: Angle.Degrees(-27.31481869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49187"},
        {"Hipparcos Number", "HIP 32424"},
        {"Smithsonian Astrophysical Observation", "SAO 172299"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.52904282),
        dec: Angle.Degrees(-27.31165132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110889"},
        {"Hipparcos Number", "HIP 62262"},
        {"Smithsonian Astrophysical Observation", "SAO 181081"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.38505503),
        dec: Angle.Degrees(-27.31103307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126820"},
        {"Hipparcos Number", "HIP 70774"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12335222),
        dec: Angle.Degrees(-27.30816388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205905"},
        {"Hipparcos Number", "HIP 106913"},
        {"Geneva Identification System", "GEN# +1.00205905"},
        {"Smithsonian Astrophysical Observation", "SAO 190520"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.79124450),
        dec: Angle.Degrees(-27.30636802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 384.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9616 A"},
        {"Henry Draper", "HD 136894"},
        {"Hipparcos Number", "HIP 75363"},
        {"Geneva Identification System", "GEN# +1.00136894"},
        {"Smithsonian Astrophysical Observation", "SAO 183433"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.01012340),
        dec: Angle.Degrees(-27.30511455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153874"},
        {"Hipparcos Number", "HIP 83428"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77934469),
        dec: Angle.Degrees(-27.30466195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105324",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14852"},
        {"Aitken 2", "ADS 14852 AB"},
        {"Henry Draper", "HD 202982"},
        {"Hipparcos Number", "HIP 105324"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.01006563),
        dec: Angle.Degrees(-27.30438913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21057"},
        {"Hipparcos Number", "HIP 15748"},
        {"Smithsonian Astrophysical Observation", "SAO 168499"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.72708208),
        dec: Angle.Degrees(-27.30183045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208925"},
        {"Hipparcos Number", "HIP 108617"},
        {"Smithsonian Astrophysical Observation", "SAO 190810"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.05128519),
        dec: Angle.Degrees(-27.29913565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92921"},
        {"Hipparcos Number", "HIP 52450"},
        {"Geneva Identification System", "GEN# +1.00092921"},
        {"Smithsonian Astrophysical Observation", "SAO 179160"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.83423715),
        dec: Angle.Degrees(-27.29839990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53914"},
        {"Hipparcos Number", "HIP 34220"},
        {"Celescope Catalog", "CEL 1575"},
        {"Geneva Identification System", "GEN# +1.00053914"},
        {"Smithsonian Astrophysical Observation", "SAO 172946"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.42338415),
        dec: Angle.Degrees(-27.29557362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211559"},
        {"Hipparcos Number", "HIP 110118"},
        {"Smithsonian Astrophysical Observation", "SAO 191036"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.60101144),
        dec: Angle.Degrees(-27.29473935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55906"},
        {"Hipparcos Number", "HIP 34948"},
        {"Smithsonian Astrophysical Observation", "SAO 173251"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.47138856),
        dec: Angle.Degrees(-27.29450020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316466"},
        {"Hipparcos Number", "HIP 87674"},
        {"Geneva Identification System", "GEN# +1.00316466"},
        {"Smithsonian Astrophysical Observation", "SAO 185917"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61717646),
        dec: Angle.Degrees(-27.29408621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96202"},
        {"Hipparcos Number", "HIP 54204"},
        {"Fundamental Katalog 5th Edition", "FK5 419"},
        {"Geneva Identification System", "GEN# +1.00096202"},
        {"Smithsonian Astrophysical Observation", "SAO 179514"},
        {"Wilson Evans Batten Catalogue", "WEB 9794"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.33346925),
        dec: Angle.Degrees(-27.29359566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200952"},
        {"Hipparcos Number", "HIP 104266"},
        {"Smithsonian Astrophysical Observation", "SAO 190028"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.84462688),
        dec: Angle.Degrees(-27.29152269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221267"},
        {"Hipparcos Number", "HIP 116043"},
        {"Smithsonian Astrophysical Observation", "SAO 191961"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.70426317),
        dec: Angle.Degrees(-27.29134110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8418 AB"},
        {"Henry Draper", "HD 105077"},
        {"Hipparcos Number", "HIP 59006"},
        {"Smithsonian Astrophysical Observation", "SAO 180452"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.48118300),
        dec: Angle.Degrees(-27.28980781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96314"},
        {"Hipparcos Number", "HIP 54255"},
        {"Geneva Identification System", "GEN# +1.00096314"},
        {"Smithsonian Astrophysical Observation", "SAO 179522"},
        {"Wilson Evans Batten Catalogue", "WEB 9802"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.48978075),
        dec: Angle.Degrees(-27.28781183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218691"},
        {"Hipparcos Number", "HIP 114410"},
        {"Geneva Identification System", "GEN# +1.00218691"},
        {"Smithsonian Astrophysical Observation", "SAO 191695"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.56215415),
        dec: Angle.Degrees(-27.28777408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177562"},
        {"Hipparcos Number", "HIP 93812"},
        {"Renson", "Renson 49520"},
        {"Smithsonian Astrophysical Observation", "SAO 187672"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.58017765),
        dec: Angle.Degrees(-27.28706944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96020"},
        {"Hipparcos Number", "HIP 54104"},
        {"Geneva Identification System", "GEN# +1.00096020"},
        {"Smithsonian Astrophysical Observation", "SAO 179495"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.06340822),
        dec: Angle.Degrees(-27.28662359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216154"},
        {"Hipparcos Number", "HIP 112824"},
        {"Smithsonian Astrophysical Observation", "SAO 191440"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.72429877),
        dec: Angle.Degrees(-27.28571124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150035"},
        {"Hipparcos Number", "HIP 81566"},
        {"Geneva Identification System", "GEN# +1.00150035"},
        {"Renson", "Renson 42440"},
        {"Smithsonian Astrophysical Observation", "SAO 184527"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.88149500),
        dec: Angle.Degrees(-27.28557756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80299"},
        {"Hipparcos Number", "HIP 45636"},
        {"Geneva Identification System", "GEN# +1.00080299"},
        {"Smithsonian Astrophysical Observation", "SAO 177239"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.53601701),
        dec: Angle.Degrees(-27.28398474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83963"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.45073630),
        dec: Angle.Degrees(-27.28311429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162719"},
        {"Hipparcos Number", "HIP 87589"},
        {"Smithsonian Astrophysical Observation", "SAO 185900"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.39254638),
        dec: Angle.Degrees(-27.28265347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107995"},
        {"Hipparcos Number", "HIP 60538"},
        {"Smithsonian Astrophysical Observation", "SAO 180770"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.15367029),
        dec: Angle.Degrees(-27.28174589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16728 A"},
        {"Henry Draper", "HD 220455"},
        {"Hipparcos Number", "HIP 115518"},
        {"Smithsonian Astrophysical Observation", "SAO 191872"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.00655439),
        dec: Angle.Degrees(-27.28086600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64569"},
        {"Hipparcos Number", "HIP 38545"},
        {"Geneva Identification System", "GEN# +1.00064569"},
        {"Smithsonian Astrophysical Observation", "SAO 174746"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.39689791),
        dec: Angle.Degrees(-27.28070923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143486"},
        {"Hipparcos Number", "HIP 78504"},
        {"Smithsonian Astrophysical Observation", "SAO 184035"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.40146493),
        dec: Angle.Degrees(-27.27882330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220881"},
        {"Hipparcos Number", "HIP 115796"},
        {"Geneva Identification System", "GEN# +1.00220881"},
        {"Smithsonian Astrophysical Observation", "SAO 191919"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.88845587),
        dec: Angle.Degrees(-27.27814799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102888"},
        {"Hipparcos Number", "HIP 57749"},
        {"Geneva Identification System", "GEN# +1.00102888"},
        {"Smithsonian Astrophysical Observation", "SAO 180232"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.65515301),
        dec: Angle.Degrees(-27.27795367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90268"},
        {"Hipparcos Number", "HIP 50977"},
        {"Geneva Identification System", "GEN# +1.00090268J"},
        {"Smithsonian Astrophysical Observation", "SAO 178787"},
        {"Wilson Evans Batten Catalogue", "WEB 9325"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.18709219),
        dec: Angle.Degrees(-27.27664445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84709"},
        {"Hipparcos Number", "HIP 47957"},
        {"Fundamental Katalog 5th Edition", "FK5 4867"},
        {"Geneva Identification System", "GEN# +1.00084709"},
        {"Smithsonian Astrophysical Observation", "SAO 177962"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.59040076),
        dec: Angle.Degrees(-27.27595737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3808"},
        {"Hipparcos Number", "HIP 3181"},
        {"Geneva Identification System", "GEN# +1.00003808"},
        {"Smithsonian Astrophysical Observation", "SAO 166476"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.12789463),
        dec: Angle.Degrees(-27.27586925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3388"},
        {"Hipparcos Number", "HIP 2892"},
        {"Geneva Identification System", "GEN# +1.00003388"},
        {"Smithsonian Astrophysical Observation", "SAO 166409"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.16964902),
        dec: Angle.Degrees(-27.27566428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87659"},
        {"Hipparcos Number", "HIP 49459"},
        {"Smithsonian Astrophysical Observation", "SAO 178397"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46863796),
        dec: Angle.Degrees(-27.27512304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14548"},
        {"Hipparcos Number", "HIP 10903"},
        {"Smithsonian Astrophysical Observation", "SAO 167715"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09185971),
        dec: Angle.Degrees(-27.27299276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60281",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8525 AB"},
        {"Henry Draper", "HD 107539"},
        {"Hipparcos Number", "HIP 60281"},
        {"Smithsonian Astrophysical Observation", "SAO 180718"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.41075185),
        dec: Angle.Degrees(-27.27297650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21340"},
        {"Hipparcos Number", "HIP 15969"},
        {"Geneva Identification System", "GEN# +1.00021340"},
        {"Smithsonian Astrophysical Observation", "SAO 168536"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.40185613),
        dec: Angle.Degrees(-27.27248949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119064"},
        {"Hipparcos Number", "HIP 66801"},
        {"Smithsonian Astrophysical Observation", "SAO 181862"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.38006530),
        dec: Angle.Degrees(-27.27244295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27488"},
        {"Hipparcos Number", "HIP 20163"},
        {"Smithsonian Astrophysical Observation", "SAO 169337"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.81971138),
        dec: Angle.Degrees(-27.27197087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20"},
        {"Hipparcos Number", "HIP 434"},
        {"Geneva Identification System", "GEN# +1.00000020"},
        {"Smithsonian Astrophysical Observation", "SAO 166037"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.31348863),
        dec: Angle.Degrees(-27.27160831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66578"},
        {"Hipparcos Number", "HIP 39399"},
        {"Geneva Identification System", "GEN# +1.00066578"},
        {"Smithsonian Astrophysical Observation", "SAO 175068"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.81321181),
        dec: Angle.Degrees(-27.27107307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131294"},
        {"Hipparcos Number", "HIP 72856"},
        {"Smithsonian Astrophysical Observation", "SAO 182966"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.37318318),
        dec: Angle.Degrees(-27.26935030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36007"},
        {"Hipparcos Number", "HIP 25527"},
        {"Geneva Identification System", "GEN# +1.00036007"},
        {"Smithsonian Astrophysical Observation", "SAO 170447"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.87891218),
        dec: Angle.Degrees(-27.26915650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48968"},
        {"Hipparcos Number", "HIP 32335"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.24601557),
        dec: Angle.Degrees(-27.26645367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25276"},
        {"Hipparcos Number", "HIP 18681"},
        {"Geneva Identification System", "GEN# +1.00025276"},
        {"Smithsonian Astrophysical Observation", "SAO 169020"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.00905626),
        dec: Angle.Degrees(-27.26572268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186579"},
        {"Hipparcos Number", "HIP 97287"},
        {"Smithsonian Astrophysical Observation", "SAO 188544"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.58027992),
        dec: Angle.Degrees(-27.26558854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28286"},
        {"Hipparcos Number", "HIP 20736"},
        {"Smithsonian Astrophysical Observation", "SAO 169450"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.65803548),
        dec: Angle.Degrees(-27.26389668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29542"},
        {"Hipparcos Number", "HIP 21579"},
        {"Smithsonian Astrophysical Observation", "SAO 169626"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.50614315),
        dec: Angle.Degrees(-27.26115065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124206"},
        {"Hipparcos Number", "HIP 69415"},
        {"Geneva Identification System", "GEN# +1.00124206"},
        {"Smithsonian Astrophysical Observation", "SAO 182349"},
        {"Wilson Evans Batten Catalogue", "WEB 12100"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.19180466),
        dec: Angle.Degrees(-27.26110002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48659"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.84970832),
        dec: Angle.Degrees(-27.26093136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7683 AB"},
        {"Henry Draper", "HD 88538"},
        {"Hipparcos Number", "HIP 49977"},
        {"Smithsonian Astrophysical Observation", "SAO 178528"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.04555248),
        dec: Angle.Degrees(-27.26063292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48622"},
        {"Smithsonian Astrophysical Observation", "SAO 178171"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72528701),
        dec: Angle.Degrees(-27.26043610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136822"},
        {"Hipparcos Number", "HIP 75335"},
        {"Smithsonian Astrophysical Observation", "SAO 183428"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.89984081),
        dec: Angle.Degrees(-27.26028340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118662"},
        {"Hipparcos Number", "HIP 66571"},
        {"Smithsonian Astrophysical Observation", "SAO 181827"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68534505),
        dec: Angle.Degrees(-27.25974246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41535"},
        {"Geneva Identification System", "GEN# -0.02606080"},
    },
    visualMagnitude: 9.38,
    bvColour: 2.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05627380),
        dec: Angle.Degrees(-27.25790221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74024"},
        {"Hipparcos Number", "HIP 42555"},
        {"Smithsonian Astrophysical Observation", "SAO 176271"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.11197545),
        dec: Angle.Degrees(-27.25786589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15530"},
        {"Hipparcos Number", "HIP 11580"},
        {"Geneva Identification System", "GEN# +1.00015530"},
        {"Smithsonian Astrophysical Observation", "SAO 167824"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.31013355),
        dec: Angle.Degrees(-27.25783661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214853"},
        {"Hipparcos Number", "HIP 112024"},
        {"Smithsonian Astrophysical Observation", "SAO 191329"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35890831),
        dec: Angle.Degrees(-27.25703659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120304"},
        {"Hipparcos Number", "HIP 67427"},
        {"Smithsonian Astrophysical Observation", "SAO 181985"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.28724531),
        dec: Angle.Degrees(-27.25481929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180469"},
        {"Hipparcos Number", "HIP 94825"},
        {"Smithsonian Astrophysical Observation", "SAO 187926"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.42064884),
        dec: Angle.Degrees(-27.25371484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10166"},
        {"Hipparcos Number", "HIP 7687"},
        {"Geneva Identification System", "GEN# +1.00010166"},
        {"Smithsonian Astrophysical Observation", "SAO 167200"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.74031300),
        dec: Angle.Degrees(-27.25222274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9102"},
        {"Smithsonian Astrophysical Observation", "SAO 167426"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.30620111),
        dec: Angle.Degrees(-27.25104339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58611"},
        {"Geneva Identification System", "GEN# -0.02608918"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.29281186),
        dec: Angle.Degrees(-27.25013792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46582"},
        {"Smithsonian Astrophysical Observation", "SAO 177548"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.48315494),
        dec: Angle.Degrees(-27.24891667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130095"},
        {"Hipparcos Number", "HIP 72278"},
        {"Geneva Identification System", "GEN# +1.00130095"},
        {"Smithsonian Astrophysical Observation", "SAO 182865"},
        {"Wilson Evans Batten Catalogue", "WEB 12430"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.71397090),
        dec: Angle.Degrees(-27.24812832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197540"},
        {"Hipparcos Number", "HIP 102414"},
        {"Geneva Identification System", "GEN# +1.00197540"},
        {"Smithsonian Astrophysical Observation", "SAO 189641"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.30467248),
        dec: Angle.Degrees(-27.24729815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34566"},
        {"Hipparcos Number", "HIP 24644"},
        {"Smithsonian Astrophysical Observation", "SAO 170279"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.31514868),
        dec: Angle.Degrees(-27.24587487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30201"},
        {"Hipparcos Number", "HIP 22045"},
        {"Smithsonian Astrophysical Observation", "SAO 169713"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.11939063),
        dec: Angle.Degrees(-27.24579419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 411 AB"},
        {"Henry Draper", "HD 2650"},
        {"Hipparcos Number", "HIP 2346"},
        {"Smithsonian Astrophysical Observation", "SAO 166310"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.48895655),
        dec: Angle.Degrees(-27.24538056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11523"},
        {"Hipparcos Number", "HIP 8758"},
        {"Geneva Identification System", "GEN# +1.00011523"},
        {"Smithsonian Astrophysical Observation", "SAO 167373"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.17580408),
        dec: Angle.Degrees(-27.24535682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188848"},
        {"Hipparcos Number", "HIP 98284"},
        {"Smithsonian Astrophysical Observation", "SAO 188765"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.54639965),
        dec: Angle.Degrees(-27.24500304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198500"},
        {"Hipparcos Number", "HIP 102954"},
        {"Geneva Identification System", "GEN# +1.00198500"},
        {"Smithsonian Astrophysical Observation", "SAO 189775"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.89004876),
        dec: Angle.Degrees(-27.24470619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115889"},
        {"Hipparcos Number", "HIP 65092"},
        {"Smithsonian Astrophysical Observation", "SAO 181563"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11545856),
        dec: Angle.Degrees(-27.24447270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112991"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.24778664),
        dec: Angle.Degrees(-27.24405240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316178"},
        {"Hipparcos Number", "HIP 86730"},
        {"Smithsonian Astrophysical Observation", "SAO 185656"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.83633212),
        dec: Angle.Degrees(-27.24196324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87801",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10886 AB"},
        {"Henry Draper", "HD 314883"},
        {"Hipparcos Number", "HIP 87801"},
        {"Smithsonian Astrophysical Observation", "SAO 185958"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.04565278),
        dec: Angle.Degrees(-27.24081092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98092"},
        {"Hipparcos Number", "HIP 55099"},
        {"Geneva Identification System", "GEN# +1.00098092"},
        {"Smithsonian Astrophysical Observation", "SAO 179732"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.21676635),
        dec: Angle.Degrees(-27.23950380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42034"},
        {"Smithsonian Astrophysical Observation", "SAO 116892"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.52466384),
        dec: Angle.Degrees(+03.47959547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21042"},
        {"Hipparcos Number", "HIP 15736"},
        {"Geneva Identification System", "GEN# +1.00021042"},
        {"Smithsonian Astrophysical Observation", "SAO 168498"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.68601851),
        dec: Angle.Degrees(-27.23827645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8313"},
        {"Hipparcos Number", "HIP 6386"},
        {"Smithsonian Astrophysical Observation", "SAO 166992"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.51074616),
        dec: Angle.Degrees(-27.23386128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62191"},
        {"Hipparcos Number", "HIP 37482"},
        {"Celescope Catalog", "CEL 1981"},
        {"Geneva Identification System", "GEN# +1.00062191"},
        {"Smithsonian Astrophysical Observation", "SAO 174311"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.41590541),
        dec: Angle.Degrees(-27.23312157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119063"},
        {"Hipparcos Number", "HIP 66797"},
        {"Geneva Identification System", "GEN# +1.00119063"},
        {"Smithsonian Astrophysical Observation", "SAO 181861"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.37266670),
        dec: Angle.Degrees(-27.23222397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147166"},
        {"Hipparcos Number", "HIP 80123"},
        {"Geneva Identification System", "GEN# +1.00147166"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.32669428),
        dec: Angle.Degrees(-27.23152613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195861"},
        {"Hipparcos Number", "HIP 101546"},
        {"Smithsonian Astrophysical Observation", "SAO 189449"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68789975),
        dec: Angle.Degrees(-27.23144575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42814"},
        {"Hipparcos Number", "HIP 29398"},
        {"Smithsonian Astrophysical Observation", "SAO 171367"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92385109),
        dec: Angle.Degrees(-27.23083785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124593"},
        {"Hipparcos Number", "HIP 69636"},
        {"Smithsonian Astrophysical Observation", "SAO 182377"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.78134319),
        dec: Angle.Degrees(-27.23001975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5790"},
        {"Smithsonian Astrophysical Observation", "SAO 166893"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.57669776),
        dec: Angle.Degrees(-27.22877011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4408"},
        {"Geneva Identification System", "GEN# -0.02700303"},
        {"Smithsonian Astrophysical Observation", "SAO 166695"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12572743),
        dec: Angle.Degrees(-27.22747159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178296"},
        {"Hipparcos Number", "HIP 94078"},
        {"Smithsonian Astrophysical Observation", "SAO 187736"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.26895945),
        dec: Angle.Degrees(-27.22703946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66058"},
        {"Hipparcos Number", "HIP 39186"},
        {"Smithsonian Astrophysical Observation", "SAO 174980"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.22619412),
        dec: Angle.Degrees(-27.22655951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190643"},
        {"Hipparcos Number", "HIP 99082"},
        {"Smithsonian Astrophysical Observation", "SAO 188923"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.73011598),
        dec: Angle.Degrees(-27.22482501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52812"},
        {"Hipparcos Number", "HIP 33846"},
        {"Celescope Catalog", "CEL 1516"},
        {"Geneva Identification System", "GEN# +5.11210027"},
        {"Smithsonian Astrophysical Observation", "SAO 172788"},
        {"Wilson Evans Batten Catalogue", "WEB 6796"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.39003791),
        dec: Angle.Degrees(-27.22295272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10075"},
        {"Hipparcos Number", "HIP 7606"},
        {"Geneva Identification System", "GEN# +1.00010075"},
        {"Smithsonian Astrophysical Observation", "SAO 167188"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.49610827),
        dec: Angle.Degrees(-27.22244118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13469"},
        {"Hipparcos Number", "HIP 10189"},
        {"Geneva Identification System", "GEN# +1.00013469"},
        {"Smithsonian Astrophysical Observation", "SAO 167616"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.74551693),
        dec: Angle.Degrees(-27.22098237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197027"},
        {"Hipparcos Number", "HIP 102152"},
        {"Geneva Identification System", "GEN# +1.00197027"},
        {"Smithsonian Astrophysical Observation", "SAO 189585"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.47715948),
        dec: Angle.Degrees(-27.21591092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59252"},
        {"Hipparcos Number", "HIP 36274"},
    },
    visualMagnitude: 9.78,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.02077978),
        dec: Angle.Degrees(-27.21556524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154038"},
        {"Hipparcos Number", "HIP 83511"},
        {"Geneva Identification System", "GEN# +1.00154038"},
        {"Smithsonian Astrophysical Observation", "SAO 184981"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.00850359),
        dec: Angle.Degrees(-27.21512809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166789"},
        {"Hipparcos Number", "HIP 89302"},
        {"Geneva Identification System", "GEN# +1.00166789J"},
        {"Smithsonian Astrophysical Observation", "SAO 186481"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.32958241),
        dec: Angle.Degrees(-27.21512152)
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
    primaryId: "HIP 39282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66306"},
        {"Hipparcos Number", "HIP 39282"},
        {"Smithsonian Astrophysical Observation", "SAO 175018"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.48800274),
        dec: Angle.Degrees(-27.21478925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8462"},
        {"Hipparcos Number", "HIP 6488"},
        {"Geneva Identification System", "GEN# +1.00008462"},
        {"Smithsonian Astrophysical Observation", "SAO 167008"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.84315972),
        dec: Angle.Degrees(-27.21449059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37530"},
        {"Hipparcos Number", "HIP 26495"},
        {"Fundamental Katalog 5th Edition", "FK5 1153"},
        {"Geneva Identification System", "GEN# +1.00037530"},
        {"Smithsonian Astrophysical Observation", "SAO 170618"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.52877805),
        dec: Angle.Degrees(-27.21074737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146070"},
        {"Hipparcos Number", "HIP 79658"},
        {"Fundamental Katalog 5th Edition", "FK5 5432"},
        {"Geneva Identification System", "GEN# +1.00146070"},
        {"Smithsonian Astrophysical Observation", "SAO 184262"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.82972739),
        dec: Angle.Degrees(-27.20993225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202941"},
        {"Hipparcos Number", "HIP 105318"},
        {"Smithsonian Astrophysical Observation", "SAO 190238"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.96424786),
        dec: Angle.Degrees(-27.20913748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212915"},
        {"Hipparcos Number", "HIP 110908"},
        {"Smithsonian Astrophysical Observation", "SAO 191161"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.04680549),
        dec: Angle.Degrees(-27.20761419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129803"},
        {"Hipparcos Number", "HIP 72141"},
        {"Smithsonian Astrophysical Observation", "SAO 182844"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33931933),
        dec: Angle.Degrees(-27.20755508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14525"},
        {"Hipparcos Number", "HIP 10883"},
        {"Smithsonian Astrophysical Observation", "SAO 167711"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.01776326),
        dec: Angle.Degrees(-27.20606599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86327"},
        {"Cincinnati Publication", "Ci 20 1048"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.58300039),
        dec: Angle.Degrees(-27.20504819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -443.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47519"},
        {"Geneva Identification System", "GEN# -0.02607338"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.31269349),
        dec: Angle.Degrees(-27.20378938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184229"},
        {"Hipparcos Number", "HIP 96273"},
        {"Geneva Identification System", "GEN# +1.00184229"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.63900167),
        dec: Angle.Degrees(-27.15997093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158466"},
        {"Hipparcos Number", "HIP 85681"},
        {"Smithsonian Astrophysical Observation", "SAO 185463"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.64021095),
        dec: Angle.Degrees(-27.20327331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200570"},
        {"Hipparcos Number", "HIP 104063"},
        {"Smithsonian Astrophysical Observation", "SAO 189990"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.23726511),
        dec: Angle.Degrees(-27.20074463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16959 A"},
        {"Henry Draper", "HD 222834"},
        {"Henry Draper 2", "HD 222834A"},
        {"Hipparcos Number", "HIP 117081"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.03047473),
        dec: Angle.Degrees(-27.19631628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79894"},
        {"Hipparcos Number", "HIP 45472"},
        {"Smithsonian Astrophysical Observation", "SAO 177186"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.99504500),
        dec: Angle.Degrees(-27.19585006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123560"},
        {"Hipparcos Number", "HIP 69132"},
        {"Geneva Identification System", "GEN# +1.00123560"},
        {"Smithsonian Astrophysical Observation", "SAO 182288"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.26206134),
        dec: Angle.Degrees(-27.19525080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166021"},
        {"Hipparcos Number", "HIP 88991"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.45599338),
        dec: Angle.Degrees(-27.19402455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41682"},
        {"Hipparcos Number", "HIP 28858"},
        {"Geneva Identification System", "GEN# +1.00041682"},
        {"Smithsonian Astrophysical Observation", "SAO 171221"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.37690344),
        dec: Angle.Degrees(-27.19310407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89370"},
        {"Hipparcos Number", "HIP 50458"},
        {"Smithsonian Astrophysical Observation", "SAO 178646"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.54253935),
        dec: Angle.Degrees(-27.19212914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170840"},
        {"Hipparcos Number", "HIP 90909"},
        {"Smithsonian Astrophysical Observation", "SAO 186943"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.15974069),
        dec: Angle.Degrees(-27.18958797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10062 A"},
        {"Henry Draper", "HD 148153"},
        {"Hipparcos Number", "HIP 80586"},
        {"Smithsonian Astrophysical Observation", "SAO 184393"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80221745),
        dec: Angle.Degrees(-27.18936651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150543"},
        {"Hipparcos Number", "HIP 81821"},
        {"Geneva Identification System", "GEN# +1.00150543"},
        {"Smithsonian Astrophysical Observation", "SAO 184563"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.69577635),
        dec: Angle.Degrees(-27.18762168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16751"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.87796390),
        dec: Angle.Degrees(-27.18568587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23879"},
        {"Hipparcos Number", "HIP 17712"},
        {"Smithsonian Astrophysical Observation", "SAO 168838"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.90762861),
        dec: Angle.Degrees(-27.18465655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62312"},
        {"Hipparcos Number", "HIP 37544"},
        {"Celescope Catalog", "CEL 1986"},
        {"Geneva Identification System", "GEN# +1.00062312"},
        {"Smithsonian Astrophysical Observation", "SAO 174337"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.58021730),
        dec: Angle.Degrees(-27.18381249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108291"},
        {"Hipparcos Number", "HIP 60722"},
        {"Smithsonian Astrophysical Observation", "SAO 180799"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.65896273),
        dec: Angle.Degrees(-27.18375784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197804"},
        {"Hipparcos Number", "HIP 102538"},
        {"Geneva Identification System", "GEN# +1.00197804"},
        {"Smithsonian Astrophysical Observation", "SAO 189687"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.68773729),
        dec: Angle.Degrees(-27.18310171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98518"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.22069284),
        dec: Angle.Degrees(-27.18138585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62556"},
        {"Hipparcos Number", "HIP 37646"},
        {"Renson", "Renson 17180"},
        {"Smithsonian Astrophysical Observation", "SAO 174388"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.88405365),
        dec: Angle.Degrees(-27.17921441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219391"},
        {"Hipparcos Number", "HIP 114841"},
        {"Geneva Identification System", "GEN# +1.00219391"},
        {"Renson", "Renson 60260"},
        {"Smithsonian Astrophysical Observation", "SAO 191765"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92840771),
        dec: Angle.Degrees(-27.17835191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16280"},
        {"Hipparcos Number", "HIP 12109"},
        {"Geneva Identification System", "GEN# +1.00016280"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.00305347),
        dec: Angle.Degrees(-27.17795724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33980"},
        {"Hipparcos Number", "HIP 24299"},
        {"Smithsonian Astrophysical Observation", "SAO 170194"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.21588592),
        dec: Angle.Degrees(-27.17758884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148643"},
        {"Hipparcos Number", "HIP 80846"},
        {"Smithsonian Astrophysical Observation", "SAO 184430"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.64573769),
        dec: Angle.Degrees(-27.17642954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139498"},
        {"Hipparcos Number", "HIP 76673"},
        {"Smithsonian Astrophysical Observation", "SAO 183664"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.85177186),
        dec: Angle.Degrees(-27.17271768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81110"},
        {"Hipparcos Number", "HIP 46007"},
        {"Geneva Identification System", "GEN# +1.00081110"},
        {"Smithsonian Astrophysical Observation", "SAO 177364"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.74885708),
        dec: Angle.Degrees(-27.17246659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3049",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 543 AB"},
        {"Henry Draper", "HD 3606"},
        {"Hipparcos Number", "HIP 3049"},
        {"Geneva Identification System", "GEN# +1.00003606J"},
        {"Smithsonian Astrophysical Observation", "SAO 166442"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.68826062),
        dec: Angle.Degrees(-27.17153962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195719"},
        {"Hipparcos Number", "HIP 101472"},
        {"Geneva Identification System", "GEN# +1.00195719"},
        {"Smithsonian Astrophysical Observation", "SAO 189432"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47170054),
        dec: Angle.Degrees(-27.17129088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188603"},
        {"Hipparcos Number", "HIP 98162"},
        {"Geneva Identification System", "GEN# +1.00188603"},
        {"Smithsonian Astrophysical Observation", "SAO 188742"},
        {"Wilson Evans Batten Catalogue", "WEB 17302"},
    },
    visualMagnitude: 4.54,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.23677038),
        dec: Angle.Degrees(-27.16986250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1018"},
        {"Hipparcos Number", "HIP 1154"},
        {"Smithsonian Astrophysical Observation", "SAO 166140"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.60639304),
        dec: Angle.Degrees(-27.16976811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203997"},
        {"Hipparcos Number", "HIP 105845"},
        {"Smithsonian Astrophysical Observation", "SAO 190334"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.57192653),
        dec: Angle.Degrees(-27.16969159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51925"},
        {"Hipparcos Number", "HIP 33532"},
        {"Celescope Catalog", "CEL 1462"},
        {"Geneva Identification System", "GEN# +1.00051925J"},
        {"Smithsonian Astrophysical Observation", "SAO 172656"},
        {"Wilson Evans Batten Catalogue", "WEB 6743"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.53147991),
        dec: Angle.Degrees(-27.16439185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174405"},
        {"Hipparcos Number", "HIP 92535"},
        {"Smithsonian Astrophysical Observation", "SAO 187363"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.86001841),
        dec: Angle.Degrees(-27.16416564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33979"},
        {"Hipparcos Number", "HIP 24306"},
        {"Smithsonian Astrophysical Observation", "SAO 170196"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.23267933),
        dec: Angle.Degrees(-27.15900755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222283"},
        {"Hipparcos Number", "HIP 116730"},
        {"Smithsonian Astrophysical Observation", "SAO 192065"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.84445457),
        dec: Angle.Degrees(-27.15691489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86830"},
        {"Hipparcos Number", "HIP 49054"},
        {"Smithsonian Astrophysical Observation", "SAO 178296"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.15029478),
        dec: Angle.Degrees(-27.15548426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42621"},
        {"Hipparcos Number", "HIP 29294"},
        {"Geneva Identification System", "GEN# +1.00042621"},
        {"Smithsonian Astrophysical Observation", "SAO 171339"},
        {"Wilson Evans Batten Catalogue", "WEB 5750"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.64452684),
        dec: Angle.Degrees(-27.15420421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214091"},
        {"Hipparcos Number", "HIP 111578"},
        {"Smithsonian Astrophysical Observation", "SAO 191261"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.07178583),
        dec: Angle.Degrees(-27.15333735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138753"},
        {"Hipparcos Number", "HIP 76284"},
        {"Geneva Identification System", "GEN# +1.00138753"},
        {"Smithsonian Astrophysical Observation", "SAO 183587"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.72251797),
        dec: Angle.Degrees(-27.15298727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184212"},
        {"Hipparcos Number", "HIP 96263"},
        {"Smithsonian Astrophysical Observation", "SAO 188292"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.60369211),
        dec: Angle.Degrees(-27.15244230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210524"},
        {"Hipparcos Number", "HIP 109551"},
        {"Smithsonian Astrophysical Observation", "SAO 190953"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.86310368),
        dec: Angle.Degrees(-27.15228682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147703"},
        {"Hipparcos Number", "HIP 80387"},
        {"Geneva Identification System", "GEN# +1.00147703"},
        {"Smithsonian Astrophysical Observation", "SAO 184365"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.12682408),
        dec: Angle.Degrees(-27.15107620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145353"},
        {"Hipparcos Number", "HIP 79343"},
        {"Geneva Identification System", "GEN# +1.00145353"},
        {"Smithsonian Astrophysical Observation", "SAO 184205"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.88973964),
        dec: Angle.Degrees(-27.15079811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201575"},
        {"Hipparcos Number", "HIP 104585"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.79245103),
        dec: Angle.Degrees(-27.14926353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53654"},
        {"Hipparcos Number", "HIP 34139"},
        {"Smithsonian Astrophysical Observation", "SAO 172910"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.18553380),
        dec: Angle.Degrees(-27.14795430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100779"},
        {"Hipparcos Number", "HIP 56566"},
        {"Smithsonian Astrophysical Observation", "SAO 180016"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.95206412),
        dec: Angle.Degrees(-27.14757161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61447"},
        {"Hipparcos Number", "HIP 37171"},
        {"Geneva Identification System", "GEN# +1.00061447"},
        {"Smithsonian Astrophysical Observation", "SAO 174177"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.57232089),
        dec: Angle.Degrees(-27.14591824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71399"},
        {"Hipparcos Number", "HIP 41360"},
        {"Geneva Identification System", "GEN# +1.00071399"},
        {"Smithsonian Astrophysical Observation", "SAO 175821"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.57310922),
        dec: Angle.Degrees(-27.14482647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15155"},
        {"Hipparcos Number", "HIP 11322"},
        {"Geneva Identification System", "GEN# +1.00015155"},
        {"Smithsonian Astrophysical Observation", "SAO 167780"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.42564026),
        dec: Angle.Degrees(-27.14417523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116162"},
        {"Hipparcos Number", "HIP 65237"},
        {"Smithsonian Astrophysical Observation", "SAO 181595"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.53179483),
        dec: Angle.Degrees(-27.14414405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45748"},
        {"Hipparcos Number", "HIP 30786"},
        {"Smithsonian Astrophysical Observation", "SAO 171803"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.02343426),
        dec: Angle.Degrees(-27.14360414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125279"},
        {"Hipparcos Number", "HIP 69977"},
        {"Smithsonian Astrophysical Observation", "SAO 182435"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77988682),
        dec: Angle.Degrees(-27.14115459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204694"},
        {"Hipparcos Number", "HIP 106229"},
        {"Smithsonian Astrophysical Observation", "SAO 190398"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.75348825),
        dec: Angle.Degrees(-27.13984725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221401"},
        {"Hipparcos Number", "HIP 116152"},
        {"Smithsonian Astrophysical Observation", "SAO 191975"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.00219356),
        dec: Angle.Degrees(-27.13967479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131094"},
        {"Hipparcos Number", "HIP 72744"},
        {"Smithsonian Astrophysical Observation", "SAO 182946"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.07649336),
        dec: Angle.Degrees(-27.13914366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148118"},
        {"Hipparcos Number", "HIP 80565"},
        {"Geneva Identification System", "GEN# +1.00148118"},
        {"Smithsonian Astrophysical Observation", "SAO 184391"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.73802892),
        dec: Angle.Degrees(-27.13879903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8612 AB"},
        {"Henry Draper", "HD 109799"},
        {"Hipparcos Number", "HIP 61621"},
        {"Geneva Identification System", "GEN# +1.00109799J"},
        {"Smithsonian Astrophysical Observation", "SAO 180965"},
        {"Wilson Evans Batten Catalogue", "WEB 10963"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.42594398),
        dec: Angle.Degrees(-27.13865883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57990"},
        {"Hipparcos Number", "HIP 35763"},
        {"Smithsonian Astrophysical Observation", "SAO 173577"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.64907212),
        dec: Angle.Degrees(-27.13766368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51255"},
        {"Hipparcos Number", "HIP 33288"},
        {"Geneva Identification System", "GEN# +1.00051255"},
        {"Smithsonian Astrophysical Observation", "SAO 172581"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.87815777),
        dec: Angle.Degrees(-27.13712232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137654"},
        {"Hipparcos Number", "HIP 75716"},
        {"Smithsonian Astrophysical Observation", "SAO 183487"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.02731950),
        dec: Angle.Degrees(-27.13641133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218003"},
        {"Hipparcos Number", "HIP 113967"},
        {"Fundamental Katalog 5th Edition", "FK5 6042"},
        {"Renson", "Renson 60093"},
        {"Smithsonian Astrophysical Observation", "SAO 191631"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.20917764),
        dec: Angle.Degrees(-27.13604837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17177 AB"},
        {"Henry Draper", "HD 224989"},
        {"Hipparcos Number", "HIP 178"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.56779620),
        dec: Angle.Degrees(-27.13517299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38827"},
        {"Hipparcos Number", "HIP 27330"},
        {"Geneva Identification System", "GEN# +1.00038827"},
        {"Smithsonian Astrophysical Observation", "SAO 170841"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.84120322),
        dec: Angle.Degrees(-27.13444153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204474"},
        {"Hipparcos Number", "HIP 106102"},
        {"Smithsonian Astrophysical Observation", "SAO 190386"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.38754903),
        dec: Angle.Degrees(-27.13431699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 154.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128853"},
        {"Hipparcos Number", "HIP 71697"},
        {"Geneva Identification System", "GEN# +1.00128853"},
        {"Smithsonian Astrophysical Observation", "SAO 182746"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.99668641),
        dec: Angle.Degrees(-27.13405097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51344"},
        {"Hipparcos Number", "HIP 33319"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.95531901),
        dec: Angle.Degrees(-27.13052565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103363"},
        {"Hipparcos Number", "HIP 58022"},
        {"Smithsonian Astrophysical Observation", "SAO 180279"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.50990440),
        dec: Angle.Degrees(-27.13008490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223514"},
        {"Hipparcos Number", "HIP 117532"},
        {"Smithsonian Astrophysical Observation", "SAO 192185"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.53868360),
        dec: Angle.Degrees(-27.12931341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20397"},
        {"Hipparcos Number", "HIP 15200"},
        {"Smithsonian Astrophysical Observation", "SAO 168424"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.97284102),
        dec: Angle.Degrees(-27.12838079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52217"},
        {"Hipparcos Number", "HIP 33634"},
        {"Geneva Identification System", "GEN# +1.00052217"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.80665750),
        dec: Angle.Degrees(-27.12788373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8729 AB"},
        {"Henry Draper", "HD 112904"},
        {"Hipparcos Number", "HIP 63469"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.08200819),
        dec: Angle.Degrees(-27.12750360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131719"},
        {"Hipparcos Number", "HIP 73066"},
        {"Geneva Identification System", "GEN# +1.00131719"},
        {"Smithsonian Astrophysical Observation", "SAO 183007"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.97952375),
        dec: Angle.Degrees(-27.12723683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174033"},
        {"Hipparcos Number", "HIP 92385"},
        {"Smithsonian Astrophysical Observation", "SAO 187318"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.40360107),
        dec: Angle.Degrees(-27.12509198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 738"},
        {"Geneva Identification System", "GEN# +6.00246048"},
        {"Geneva Identification System 2", "GEN# -0.02700016"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26626900),
        dec: Angle.Degrees(-27.12235235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 696.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18734"},
        {"Hipparcos Number", "HIP 13961"},
        {"Smithsonian Astrophysical Observation", "SAO 168211"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.94946274),
        dec: Angle.Degrees(-27.11745772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178469"},
        {"Hipparcos Number", "HIP 94136"},
        {"Smithsonian Astrophysical Observation", "SAO 187749"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.43247351),
        dec: Angle.Degrees(-27.11434932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67409"},
        {"Hipparcos Number", "HIP 39700"},
        {"Fundamental Katalog 5th Edition", "FK5 2629"},
        {"Smithsonian Astrophysical Observation", "SAO 175196"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.71476179),
        dec: Angle.Degrees(-27.11427724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65033"},
        {"Hipparcos Number", "HIP 38733"},
        {"Smithsonian Astrophysical Observation", "SAO 174820"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.94678635),
        dec: Angle.Degrees(-27.11337819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11445"},
        {"Hipparcos Number", "HIP 8706"},
        {"Smithsonian Astrophysical Observation", "SAO 167358"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.00226254),
        dec: Angle.Degrees(-27.11316244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112256"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.05280328),
        dec: Angle.Degrees(-27.10004911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127644"},
        {"Hipparcos Number", "HIP 71164"},
        {"Smithsonian Astrophysical Observation", "SAO 182656"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.32994553),
        dec: Angle.Degrees(-27.11311492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153120"},
        {"Hipparcos Number", "HIP 83073"},
        {"Smithsonian Astrophysical Observation", "SAO 184855"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.62735604),
        dec: Angle.Degrees(-27.11228170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30721"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.81546492),
        dec: Angle.Degrees(-27.11209140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8975"},
        {"Hipparcos Number", "HIP 6842"},
        {"Geneva Identification System", "GEN# +1.00008975"},
        {"Smithsonian Astrophysical Observation", "SAO 167066"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.00826845),
        dec: Angle.Degrees(-27.10948939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6255"},
        {"Hipparcos Number", "HIP 4924"},
        {"Geneva Identification System", "GEN# +1.00006255"},
        {"Smithsonian Astrophysical Observation", "SAO 166770"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.80100430),
        dec: Angle.Degrees(-27.10817749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201262"},
        {"Hipparcos Number", "HIP 104413"},
        {"Smithsonian Astrophysical Observation", "SAO 190058"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.27967233),
        dec: Angle.Degrees(-27.10761265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213135"},
        {"Hipparcos Number", "HIP 111045"},
        {"Fundamental Katalog 5th Edition", "FK5 3798"},
        {"Geneva Identification System", "GEN# +1.00213135"},
        {"Smithsonian Astrophysical Observation", "SAO 191182"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.44142048),
        dec: Angle.Degrees(-27.10723481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150383"},
        {"Hipparcos Number", "HIP 81747"},
        {"Geneva Identification System", "GEN# +1.00150383"},
        {"Smithsonian Astrophysical Observation", "SAO 184551"},
        {"Wilson Evans Batten Catalogue", "WEB 13815"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.45731968),
        dec: Angle.Degrees(-27.10537148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13334"},
        {"Hipparcos Number", "HIP 10092"},
        {"Smithsonian Astrophysical Observation", "SAO 167601"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.43898686),
        dec: Angle.Degrees(-27.10346670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8491 AB"},
        {"Henry Draper", "HD 106701"},
        {"Hipparcos Number", "HIP 59845"},
        {"Smithsonian Astrophysical Observation", "SAO 180636"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.07607278),
        dec: Angle.Degrees(-27.10303969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165426"},
        {"Hipparcos Number", "HIP 88746"},
        {"Smithsonian Astrophysical Observation", "SAO 186297"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.75686286),
        dec: Angle.Degrees(-27.10200897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30047"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.83553267),
        dec: Angle.Degrees(-27.10148636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30918"},
        {"Hipparcos Number", "HIP 22503"},
        {"Smithsonian Astrophysical Observation", "SAO 169810"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.63269111),
        dec: Angle.Degrees(-27.10085603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149069"},
        {"Hipparcos Number", "HIP 81070"},
        {"Geneva Identification System", "GEN# +1.00149069"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.38136022),
        dec: Angle.Degrees(-27.10068810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31081"},
        {"Smithsonian Astrophysical Observation", "SAO 171881"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.83253017),
        dec: Angle.Degrees(-27.10059632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144499"},
        {"Hipparcos Number", "HIP 78963"},
        {"Geneva Identification System", "GEN# +1.00144499"},
        {"Smithsonian Astrophysical Observation", "SAO 184129"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.80283732),
        dec: Angle.Degrees(-27.09943048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39702"},
        {"Smithsonian Astrophysical Observation", "SAO 175197"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.72711755),
        dec: Angle.Degrees(-27.09836987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218579"},
        {"Hipparcos Number", "HIP 114337"},
        {"Smithsonian Astrophysical Observation", "SAO 191682"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.34585630),
        dec: Angle.Degrees(-27.09829164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72913"},
        {"Hipparcos Number", "HIP 42071"},
        {"Smithsonian Astrophysical Observation", "SAO 176103"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.62386686),
        dec: Angle.Degrees(-27.09819859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164742"},
        {"Hipparcos Number", "HIP 88459"},
        {"Smithsonian Astrophysical Observation", "SAO 186190"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.92257760),
        dec: Angle.Degrees(-27.09808872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153873"},
        {"Hipparcos Number", "HIP 83422"},
        {"Geneva Identification System", "GEN# +1.00153873"},
        {"Smithsonian Astrophysical Observation", "SAO 184955"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.76869921),
        dec: Angle.Degrees(-27.09776634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8566 AB"},
        {"Henry Draper", "HD 108618"},
        {"Hipparcos Number", "HIP 60895"},
        {"Smithsonian Astrophysical Observation", "SAO 180828"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.19643634),
        dec: Angle.Degrees(-27.09726842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217326"},
        {"Hipparcos Number", "HIP 113574"},
        {"Smithsonian Astrophysical Observation", "SAO 191561"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.06148715),
        dec: Angle.Degrees(-27.09597864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5684"},
        {"Hipparcos Number", "HIP 4556"},
        {"Geneva Identification System", "GEN# +1.00005684"},
        {"Smithsonian Astrophysical Observation", "SAO 166714"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.57064633),
        dec: Angle.Degrees(-27.09239799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141939"},
        {"Hipparcos Number", "HIP 77766"},
        {"Geneva Identification System", "GEN# +1.00141939"},
        {"Smithsonian Astrophysical Observation", "SAO 183884"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.17888073),
        dec: Angle.Degrees(-27.09056415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77937"},
        {"Hipparcos Number", "HIP 44546"},
        {"Smithsonian Astrophysical Observation", "SAO 176909"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.14356723),
        dec: Angle.Degrees(-27.08853038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140956"},
        {"Hipparcos Number", "HIP 77339"},
        {"Smithsonian Astrophysical Observation", "SAO 183788"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.83483834),
        dec: Angle.Degrees(-27.08715214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108822"},
        {"Hipparcos Number", "HIP 61024"},
        {"Smithsonian Astrophysical Observation", "SAO 180852"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.59850276),
        dec: Angle.Degrees(-27.08580136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210678"},
        {"Hipparcos Number", "HIP 109640"},
        {"Smithsonian Astrophysical Observation", "SAO 190961"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.15389253),
        dec: Angle.Degrees(-27.08498177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70188"},
        {"Hipparcos Number", "HIP 40804"},
        {"Smithsonian Astrophysical Observation", "SAO 175606"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.92807541),
        dec: Angle.Degrees(-27.08177522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8435"},
        {"Geneva Identification System", "GEN# +6.10163802"},
    },
    visualMagnitude: 12.32,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.18324409),
        dec: Angle.Degrees(-26.60344957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219505"},
        {"Hipparcos Number", "HIP 114908"},
        {"Smithsonian Astrophysical Observation", "SAO 191778"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.12667706),
        dec: Angle.Degrees(-27.08065031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102962"},
        {"Hipparcos Number", "HIP 57798"},
        {"Smithsonian Astrophysical Observation", "SAO 180240"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.77171646),
        dec: Angle.Degrees(-27.08020986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145377"},
        {"Hipparcos Number", "HIP 79346"},
        {"Geneva Identification System", "GEN# +1.00145377"},
        {"Smithsonian Astrophysical Observation", "SAO 184208"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.90180085),
        dec: Angle.Degrees(-27.07820752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52325",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7889 AB"},
        {"Henry Draper", "HD 92655"},
        {"Hipparcos Number", "HIP 52325"},
        {"Geneva Identification System", "GEN# +1.00092655"},
        {"Smithsonian Astrophysical Observation", "SAO 179120"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.37728757),
        dec: Angle.Degrees(-27.07783200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192975"},
        {"Hipparcos Number", "HIP 100136"},
        {"Smithsonian Astrophysical Observation", "SAO 189129"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.69661578),
        dec: Angle.Degrees(-27.07574154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105934"},
        {"Hipparcos Number", "HIP 59443"},
        {"Smithsonian Astrophysical Observation", "SAO 180549"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.88930113),
        dec: Angle.Degrees(-27.07090632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163894"},
        {"Hipparcos Number", "HIP 88100"},
        {"Smithsonian Astrophysical Observation", "SAO 186055"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90261294),
        dec: Angle.Degrees(-27.06963766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133334"},
        {"Hipparcos Number", "HIP 73759"},
        {"Smithsonian Astrophysical Observation", "SAO 183147"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.16357437),
        dec: Angle.Degrees(-27.06926250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94928"},
        {"Smithsonian Astrophysical Observation", "SAO 187951"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.74820596),
        dec: Angle.Degrees(-27.06883982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315965"},
        {"Hipparcos Number", "HIP 86110"},
        {"Smithsonian Astrophysical Observation", "SAO 185536"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.96590631),
        dec: Angle.Degrees(-27.06761262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86581"},
        {"Hipparcos Number", "HIP 48930"},
        {"Smithsonian Astrophysical Observation", "SAO 178264"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.73523683),
        dec: Angle.Degrees(-27.06595183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30409"},
        {"Geneva Identification System", "GEN# -0.02602983"},
        {"Wilson Evans Batten Catalogue", "WEB 6050"},
    },
    visualMagnitude: 8.50,
    bvColour: 2.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.91301709),
        dec: Angle.Degrees(-27.06575063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23127"},
        {"Geneva Identification System", "GEN# -0.02701987"},
        {"Smithsonian Astrophysical Observation", "SAO 169935"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.64317584),
        dec: Angle.Degrees(-27.06467900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31128"},
        {"Hipparcos Number", "HIP 22632"},
        {"Geneva Identification System", "GEN# +1.00031128"},
        {"Smithsonian Astrophysical Observation", "SAO 169828"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.04084050),
        dec: Angle.Degrees(-27.06408558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44043"},
        {"Hipparcos Number", "HIP 29956"},
        {"Smithsonian Astrophysical Observation", "SAO 171535"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.58960696),
        dec: Angle.Degrees(-27.06221225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162083"},
        {"Hipparcos Number", "HIP 87306"},
        {"Smithsonian Astrophysical Observation", "SAO 185826"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.58814639),
        dec: Angle.Degrees(-27.06156209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6688"},
        {"Smithsonian Astrophysical Observation", "SAO 167042"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.47240623),
        dec: Angle.Degrees(-27.06127649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106533"},
        {"Hipparcos Number", "HIP 59763"},
        {"Smithsonian Astrophysical Observation", "SAO 180606"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.82555923),
        dec: Angle.Degrees(-27.06091250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42779"},
        {"Hipparcos Number", "HIP 29370"},
        {"Smithsonian Astrophysical Observation", "SAO 171359"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.86620169),
        dec: Angle.Degrees(-27.05811243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103868"},
        {"Hipparcos Number", "HIP 58317"},
        {"Geneva Identification System", "GEN# +1.00103868"},
        {"Smithsonian Astrophysical Observation", "SAO 180329"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.37896782),
        dec: Angle.Degrees(-27.05578529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203741"},
        {"Hipparcos Number", "HIP 105723"},
        {"Smithsonian Astrophysical Observation", "SAO 190306"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.19856838),
        dec: Angle.Degrees(-27.05409167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47328"},
        {"Hipparcos Number", "HIP 31607"},
        {"Smithsonian Astrophysical Observation", "SAO 172034"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.22642953),
        dec: Angle.Degrees(-27.05201794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75144"},
        {"Hipparcos Number", "HIP 43153"},
        {"Smithsonian Astrophysical Observation", "SAO 176469"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.84009333),
        dec: Angle.Degrees(-27.05159633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15570 AB"},
        {"Henry Draper", "HD 209325"},
        {"Hipparcos Number", "HIP 108856"},
        {"Renson", "Renson 58220"},
        {"Smithsonian Astrophysical Observation", "SAO 190848"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.78594079),
        dec: Angle.Degrees(-27.05121371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3342 AB"},
        {"Henry Draper", "HD 29377"},
        {"Hipparcos Number", "HIP 21466"},
        {"Fundamental Katalog 5th Edition", "FK5 4413"},
        {"Smithsonian Astrophysical Observation", "SAO 169609"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.14850908),
        dec: Angle.Degrees(-27.04780746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143401"},
        {"Hipparcos Number", "HIP 78465"},
        {"Geneva Identification System", "GEN# +1.00143401"},
        {"Smithsonian Astrophysical Observation", "SAO 184024"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26769865),
        dec: Angle.Degrees(-27.04772315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193338"},
        {"Hipparcos Number", "HIP 100315"},
        {"Geneva Identification System", "GEN# +1.00193338"},
        {"Smithsonian Astrophysical Observation", "SAO 189175"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17607088),
        dec: Angle.Degrees(-27.04769077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40823"},
        {"Hipparcos Number", "HIP 28422"},
        {"Smithsonian Astrophysical Observation", "SAO 171117"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.03439256),
        dec: Angle.Degrees(-27.04634210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200140"},
        {"Hipparcos Number", "HIP 103826"},
        {"Smithsonian Astrophysical Observation", "SAO 189954"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.59739734),
        dec: Angle.Degrees(-27.04460044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214748"},
        {"Hipparcos Number", "HIP 111954"},
        {"Fundamental Katalog 5th Edition", "FK5 854"},
        {"Geneva Identification System", "GEN# +1.00214748"},
        {"Smithsonian Astrophysical Observation", "SAO 191318"},
        {"Wilson Evans Batten Catalogue", "WEB 19990"},
    },
    visualMagnitude: 4.18,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.16385653),
        dec: Angle.Degrees(-27.04361480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117860",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17090 AB"},
        {"Henry Draper", "HD 223991"},
        {"Hipparcos Number", "HIP 117860"},
        {"Geneva Identification System", "GEN# +1.00223991J"},
        {"Smithsonian Astrophysical Observation", "SAO 192231"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.58911989),
        dec: Angle.Degrees(-27.04290947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167818"},
        {"Hipparcos Number", "HIP 89678"},
        {"Geneva Identification System", "GEN# +1.00167818"},
        {"Smithsonian Astrophysical Observation", "SAO 186612"},
        {"Wilson Evans Batten Catalogue", "WEB 15280"},
    },
    visualMagnitude: 4.66,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.51328312),
        dec: Angle.Degrees(-27.04263452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10388 AB"},
        {"Henry Draper", "HD 155363"},
        {"Hipparcos Number", "HIP 84144"},
        {"Smithsonian Astrophysical Observation", "SAO 185137"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.04570254),
        dec: Angle.Degrees(-27.04215168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12265"},
        {"Hipparcos Number", "HIP 9331"},
        {"Smithsonian Astrophysical Observation", "SAO 167469"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.95435350),
        dec: Angle.Degrees(-27.04077054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56160"},
        {"Hipparcos Number", "HIP 35044"},
        {"Geneva Identification System", "GEN# +1.00056160"},
        {"Smithsonian Astrophysical Observation", "SAO 173283"},
        {"Wilson Evans Batten Catalogue", "WEB 7008"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71328410),
        dec: Angle.Degrees(-27.03792355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149808"},
        {"Hipparcos Number", "HIP 81456"},
        {"Smithsonian Astrophysical Observation", "SAO 184505"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.55862242),
        dec: Angle.Degrees(-27.03633272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88885"},
        {"Hipparcos Number", "HIP 50176"},
        {"Geneva Identification System", "GEN# +1.00088885"},
        {"Smithsonian Astrophysical Observation", "SAO 178561"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.63692349),
        dec: Angle.Degrees(-27.03632448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113161"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.73183834),
        dec: Angle.Degrees(-27.03436535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29615"},
        {"Hipparcos Number", "HIP 21632"},
        {"Smithsonian Astrophysical Observation", "SAO 169633"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.68293816),
        dec: Angle.Degrees(-27.03380820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192310"},
        {"Hipparcos Number", "HIP 99825"},
        {"Cincinnati Publication", "Ci 20 1199"},
        {"Geneva Identification System", "GEN# +1.00192310"},
        {"Smithsonian Astrophysical Observation", "SAO 189065"},
        {"Wilson Evans Batten Catalogue", "WEB 17937"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.81907470),
        dec: Angle.Degrees(-27.03253576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1241.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31148"},
        {"Geneva Identification System", "GEN# -0.02603096"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.03563085),
        dec: Angle.Degrees(-27.03222883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 400.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1815"},
        {"Hipparcos Number", "HIP 1768"},
        {"Cincinnati Publication", "Ci 20 25"},
        {"Geneva Identification System", "GEN# +1.00001815"},
        {"Smithsonian Astrophysical Observation", "SAO 166223"},
        {"Wilson Evans Batten Catalogue", "WEB 317"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.59779902),
        dec: Angle.Degrees(-27.03160232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -399.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78737"},
        {"Hipparcos Number", "HIP 44919"},
        {"Geneva Identification System", "GEN# +1.00078737"},
        {"Smithsonian Astrophysical Observation", "SAO 177029"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.26384887),
        dec: Angle.Degrees(-27.03033426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88699"},
        {"Hipparcos Number", "HIP 50066"},
        {"Geneva Identification System", "GEN# +1.00088699"},
        {"Renson", "Renson 25380"},
        {"Smithsonian Astrophysical Observation", "SAO 178544"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.33117633),
        dec: Angle.Degrees(-27.02897817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171543"},
        {"Hipparcos Number", "HIP 91222"},
        {"Smithsonian Astrophysical Observation", "SAO 187034"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.12170615),
        dec: Angle.Degrees(-27.02793997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2025"},
        {"Hipparcos Number", "HIP 1936"},
        {"Cincinnati Publication", "Ci 18 41"},
        {"Cincinnati Publication 2", "Ci 20 28"},
        {"Geneva Identification System", "GEN# +1.00002025"},
        {"Smithsonian Astrophysical Observation", "SAO 166242"},
        {"Wilson Evans Batten Catalogue", "WEB 361"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.10623866),
        dec: Angle.Degrees(-27.02697608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 667.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199671"},
        {"Hipparcos Number", "HIP 103609"},
        {"Geneva Identification System", "GEN# +1.00199671"},
        {"Smithsonian Astrophysical Observation", "SAO 189904"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.87957845),
        dec: Angle.Degrees(-27.02380866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59138"},
        {"Hipparcos Number", "HIP 36222"},
        {"Celescope Catalog", "CEL 1863"},
        {"Geneva Identification System", "GEN# +1.00059138"},
        {"Smithsonian Astrophysical Observation", "SAO 173777"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.89158800),
        dec: Angle.Degrees(-27.02355874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135426"},
        {"Hipparcos Number", "HIP 74694"},
        {"Geneva Identification System", "GEN# +1.00135426"},
        {"Smithsonian Astrophysical Observation", "SAO 183323"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.97256237),
        dec: Angle.Degrees(-27.02280595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70205"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.45797209),
        dec: Angle.Degrees(-27.02269607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -307.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99140"},
        {"Hipparcos Number", "HIP 55668"},
        {"Smithsonian Astrophysical Observation", "SAO 179846"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.09745741),
        dec: Angle.Degrees(-27.02011504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155431"},
        {"Hipparcos Number", "HIP 84192"},
        {"Smithsonian Astrophysical Observation", "SAO 185147"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.15192380),
        dec: Angle.Degrees(-27.01926810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143112"},
        {"Hipparcos Number", "HIP 78316"},
        {"Geneva Identification System", "GEN# +1.00143112"},
        {"Smithsonian Astrophysical Observation", "SAO 183995"},
        {"Wilson Evans Batten Catalogue", "WEB 13242"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.86501150),
        dec: Angle.Degrees(-27.01627057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208484"},
        {"Hipparcos Number", "HIP 108343"},
        {"Smithsonian Astrophysical Observation", "SAO 190764"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25242276),
        dec: Angle.Degrees(-27.01567940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70794"},
        {"Hipparcos Number", "HIP 41095"},
        {"Smithsonian Astrophysical Observation", "SAO 175713"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76073113),
        dec: Angle.Degrees(-27.01511168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182210"},
        {"Hipparcos Number", "HIP 95412"},
        {"Smithsonian Astrophysical Observation", "SAO 188082"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.13624425),
        dec: Angle.Degrees(-27.01268872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60666"},
        {"Hipparcos Number", "HIP 36848"},
        {"Geneva Identification System", "GEN# +1.00060666"},
        {"Smithsonian Astrophysical Observation", "SAO 174033"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.64510631),
        dec: Angle.Degrees(-27.01244868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7840"},
        {"Hipparcos Number", "HIP 6044"},
        {"Smithsonian Astrophysical Observation", "SAO 166930"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.40419352),
        dec: Angle.Degrees(-27.01242292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113247"},
        {"Hipparcos Number", "HIP 63650"},
        {"Geneva Identification System", "GEN# +1.00113247"},
        {"Smithsonian Astrophysical Observation", "SAO 181337"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.68074737),
        dec: Angle.Degrees(-27.01042910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2573"},
        {"Hipparcos Number", "HIP 2278"},
        {"Smithsonian Astrophysical Observation", "SAO 166306"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.28055117),
        dec: Angle.Degrees(-27.01029179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122640"},
        {"Hipparcos Number", "HIP 68688"},
        {"Smithsonian Astrophysical Observation", "SAO 182199"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90584428),
        dec: Angle.Degrees(-27.00971751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -335.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11237"},
        {"Hipparcos Number", "HIP 8517"},
        {"Smithsonian Astrophysical Observation", "SAO 167330"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.46804906),
        dec: Angle.Degrees(-27.00796897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10677"},
        {"Hipparcos Number", "HIP 8076"},
        {"Smithsonian Astrophysical Observation", "SAO 167258"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.93201062),
        dec: Angle.Degrees(-27.00513142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45231"},
        {"Smithsonian Astrophysical Observation", "SAO 177123"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.27357024),
        dec: Angle.Degrees(-27.00412044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15887"},
        {"Hipparcos Number", "HIP 11821"},
        {"Smithsonian Astrophysical Observation", "SAO 167866"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.12518853),
        dec: Angle.Degrees(-27.00306777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71755"},
        {"Hipparcos Number", "HIP 41522"},
        {"Geneva Identification System", "GEN# +1.00071755"},
        {"Smithsonian Astrophysical Observation", "SAO 175889"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.02449567),
        dec: Angle.Degrees(-27.00017881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179270"},
        {"Hipparcos Number", "HIP 94415"},
        {"Smithsonian Astrophysical Observation", "SAO 187827"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.24550913),
        dec: Angle.Degrees(-26.99954299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70262"},
        {"Hipparcos Number", "HIP 40854"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.04468898),
        dec: Angle.Degrees(-26.99861998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12922"},
        {"Smithsonian Astrophysical Observation", "SAO 168035"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.55313837),
        dec: Angle.Degrees(-26.99566563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14880"},
        {"Hipparcos Number", "HIP 11143"},
        {"Geneva Identification System", "GEN# +1.00014880"},
        {"Smithsonian Astrophysical Observation", "SAO 167744"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84720759),
        dec: Angle.Degrees(-26.99524763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164866"},
        {"Hipparcos Number", "HIP 88501"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.07625416),
        dec: Angle.Degrees(-26.99264063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38510"},
        {"Hipparcos Number", "HIP 27128"},
        {"Geneva Identification System", "GEN# +1.00038510"},
        {"Smithsonian Astrophysical Observation", "SAO 170782"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.29049334),
        dec: Angle.Degrees(-26.99249018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 289.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10534 AB"},
        {"Henry Draper", "HD 157671"},
        {"Hipparcos Number", "HIP 85292"},
        {"Smithsonian Astrophysical Observation", "SAO 185388"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.43135008),
        dec: Angle.Degrees(-26.99138843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173300"},
        {"Hipparcos Number", "HIP 92041"},
        {"Fundamental Katalog 5th Edition", "FK5 1487"},
        {"Geneva Identification System", "GEN# +1.00173300"},
        {"Smithsonian Astrophysical Observation", "SAO 187239"},
        {"Wilson Evans Batten Catalogue", "WEB 15861"},
    },
    visualMagnitude: 3.17,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.41397083),
        dec: Angle.Degrees(-26.99077940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149883"},
        {"Hipparcos Number", "HIP 81487"},
        {"Geneva Identification System", "GEN# +1.00149883"},
        {"Smithsonian Astrophysical Observation", "SAO 184513"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.65122098),
        dec: Angle.Degrees(-26.98931456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59480"},
        {"Hipparcos Number", "HIP 36359"},
        {"Celescope Catalog", "CEL 1882"},
        {"Smithsonian Astrophysical Observation", "SAO 173836"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.26308690),
        dec: Angle.Degrees(-26.98783849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220096"},
        {"Hipparcos Number", "HIP 115312"},
        {"Fundamental Katalog 5th Edition", "FK5 1611"},
        {"Geneva Identification System", "GEN# +1.00220096"},
        {"Smithsonian Astrophysical Observation", "SAO 191840"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.31462908),
        dec: Angle.Degrees(-26.98674162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27469"},
        {"Hipparcos Number", "HIP 20148"},
        {"Smithsonian Astrophysical Observation", "SAO 169334"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.78541218),
        dec: Angle.Degrees(-26.98603075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21445"},
        {"Hipparcos Number", "HIP 16035"},
        {"Smithsonian Astrophysical Observation", "SAO 168546"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.63468628),
        dec: Angle.Degrees(-26.98597980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95865",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12506 A"},
        {"Henry Draper", "HD 183275"},
        {"Henry Draper 2", "HD 183275A"},
        {"Hipparcos Number", "HIP 95865"},
        {"Geneva Identification System", "GEN# +1.00183275A"},
        {"Smithsonian Astrophysical Observation", "SAO 188192"},
        {"Wilson Evans Batten Catalogue", "WEB 16784"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.46738503),
        dec: Angle.Degrees(-26.98551060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155685"},
        {"Hipparcos Number", "HIP 84314"},
        {"Geneva Identification System", "GEN# +1.00155685"},
        {"Smithsonian Astrophysical Observation", "SAO 185178"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.55936153),
        dec: Angle.Degrees(-26.98425470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44264"},
        {"Hipparcos Number", "HIP 30066"},
        {"Smithsonian Astrophysical Observation", "SAO 171576"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.91549111),
        dec: Angle.Degrees(-26.98395934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7844"},
        {"Smithsonian Astrophysical Observation", "SAO 167223"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21865139),
        dec: Angle.Degrees(-26.98334295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220838"},
        {"Hipparcos Number", "HIP 115771"},
        {"Geneva Identification System", "GEN# +1.00220838"},
        {"Smithsonian Astrophysical Observation", "SAO 191915"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.81867899),
        dec: Angle.Degrees(-26.98279416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63048"},
        {"Hipparcos Number", "HIP 37890"},
        {"Smithsonian Astrophysical Observation", "SAO 174483"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.48632671),
        dec: Angle.Degrees(-26.98163111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19048"},
        {"Hipparcos Number", "HIP 14193"},
        {"Smithsonian Astrophysical Observation", "SAO 168260"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.75494027),
        dec: Angle.Degrees(-26.98137003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215466"},
        {"Hipparcos Number", "HIP 112383"},
        {"Smithsonian Astrophysical Observation", "SAO 191384"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.42640436),
        dec: Angle.Degrees(-26.97913015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116347"},
        {"Hipparcos Number", "HIP 65333"},
        {"Geneva Identification System", "GEN# +1.00116347"},
        {"Smithsonian Astrophysical Observation", "SAO 181612"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.85773375),
        dec: Angle.Degrees(-26.97897402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94692"},
        {"Hipparcos Number", "HIP 53412"},
        {"Smithsonian Astrophysical Observation", "SAO 179340"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.86786922),
        dec: Angle.Degrees(-26.97892668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205019"},
        {"Hipparcos Number", "HIP 106404"},
        {"Smithsonian Astrophysical Observation", "SAO 190432"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.26550501),
        dec: Angle.Degrees(-26.97637974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4586"},
        {"Hipparcos Number", "HIP 3711"},
        {"Geneva Identification System", "GEN# +1.00004586"},
        {"Smithsonian Astrophysical Observation", "SAO 166581"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.92043227),
        dec: Angle.Degrees(-26.97573353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161756"},
        {"Hipparcos Number", "HIP 87163"},
        {"Geneva Identification System", "GEN# +1.00161756"},
        {"Smithsonian Astrophysical Observation", "SAO 185779"},
        {"Wilson Evans Batten Catalogue", "WEB 14706"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.11598733),
        dec: Angle.Degrees(-26.97493164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72999"},
        {"Smithsonian Astrophysical Observation", "SAO 182996"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.78038612),
        dec: Angle.Degrees(-26.97447174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142868"},
        {"Hipparcos Number", "HIP 78191"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.48705435),
        dec: Angle.Degrees(-26.97436893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8966 B"},
        {"Henry Draper", "HD 118349B"},
        {"Hipparcos Number", "HIP 66398"},
        {"Geneva Identification System", "GEN# +1.00118349B"},
        {"Smithsonian Astrophysical Observation", "SAO 181789"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20154559),
        dec: Angle.Degrees(-26.49801375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118236"},
        {"Hipparcos Number", "HIP 66346"},
        {"Smithsonian Astrophysical Observation", "SAO 181784"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.97393841),
        dec: Angle.Degrees(-26.97410136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66740"},
        {"Hipparcos Number", "HIP 39468"},
        {"Geneva Identification System", "GEN# +1.00066740"},
        {"Smithsonian Astrophysical Observation", "SAO 175094"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.00551918),
        dec: Angle.Degrees(-26.97342538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161327"},
        {"Hipparcos Number", "HIP 86949"},
        {"Geneva Identification System", "GEN# +1.00161327"},
        {"Smithsonian Astrophysical Observation", "SAO 185716"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.50658921),
        dec: Angle.Degrees(-26.97229101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9190"},
        {"Hipparcos Number", "HIP 6994"},
        {"Smithsonian Astrophysical Observation", "SAO 167089"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.50556140),
        dec: Angle.Degrees(-26.97145201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57782"},
        {"Hipparcos Number", "HIP 35678"},
        {"Smithsonian Astrophysical Observation", "SAO 173552"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.42764459),
        dec: Angle.Degrees(-26.96772915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132724"},
        {"Hipparcos Number", "HIP 73501"},
        {"Smithsonian Astrophysical Observation", "SAO 183088"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.34613619),
        dec: Angle.Degrees(-26.96650465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6015 A"},
        {"Henry Draper", "HD 57593"},
        {"Hipparcos Number", "HIP 35611"},
        {"Celescope Catalog", "CEL 1797"},
        {"Geneva Identification System", "GEN# +1.00057593J"},
        {"Smithsonian Astrophysical Observation", "SAO 173522"},
        {"Wilson Evans Batten Catalogue", "WEB 7096"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.22882941),
        dec: Angle.Degrees(-26.96385160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41491"},
        {"Hipparcos Number", "HIP 28758"},
        {"Renson", "Renson 11100"},
        {"Smithsonian Astrophysical Observation", "SAO 171204"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08648448),
        dec: Angle.Degrees(-26.96315025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52616"},
        {"Hipparcos Number", "HIP 33775"},
        {"Smithsonian Astrophysical Observation", "SAO 172756"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21119029),
        dec: Angle.Degrees(-26.95963551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144176"},
        {"Hipparcos Number", "HIP 78827"},
        {"Smithsonian Astrophysical Observation", "SAO 184100"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.37058562),
        dec: Angle.Degrees(-26.95929593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125027"},
        {"Hipparcos Number", "HIP 69838"},
        {"Geneva Identification System", "GEN# +1.00125027"},
        {"Smithsonian Astrophysical Observation", "SAO 182414"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.38916202),
        dec: Angle.Degrees(-26.95849967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194605"},
        {"Hipparcos Number", "HIP 100888"},
        {"Smithsonian Astrophysical Observation", "SAO 189301"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.85326376),
        dec: Angle.Degrees(-26.95837444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99060"},
        {"Hipparcos Number", "HIP 55640"},
        {"Smithsonian Astrophysical Observation", "SAO 179839"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.97089277),
        dec: Angle.Degrees(-26.95809707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33040",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5548 A"},
        {"Henry Draper", "HD 50648"},
        {"Hipparcos Number", "HIP 33040"},
        {"Geneva Identification System", "GEN# +1.00050648"},
        {"Smithsonian Astrophysical Observation", "SAO 172504"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.25127657),
        dec: Angle.Degrees(-26.95747344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17767"},
    },
    visualMagnitude: 12.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.05318989),
        dec: Angle.Degrees(-26.95568838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6491"},
        {"Hipparcos Number", "HIP 5118"},
        {"Geneva Identification System", "GEN# +1.00006491"},
        {"Smithsonian Astrophysical Observation", "SAO 166790"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.39412284),
        dec: Angle.Degrees(-26.95501174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215199"},
        {"Hipparcos Number", "HIP 112233"},
        {"Smithsonian Astrophysical Observation", "SAO 191356"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.96220381),
        dec: Angle.Degrees(-26.95402399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153350"},
        {"Hipparcos Number", "HIP 83195"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03866703),
        dec: Angle.Degrees(-26.95384383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20057"},
        {"Hipparcos Number", "HIP 14931"},
        {"Smithsonian Astrophysical Observation", "SAO 168381"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.14029443),
        dec: Angle.Degrees(-26.95348471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168941"},
        {"Hipparcos Number", "HIP 90119"},
        {"Geneva Identification System", "GEN# +1.00168941"},
        {"Smithsonian Astrophysical Observation", "SAO 186748"},
        {"Wilson Evans Batten Catalogue", "WEB 15408"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.85650399),
        dec: Angle.Degrees(-26.95299542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 331"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.05951147),
        dec: Angle.Degrees(-26.95235161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35421"},
        {"Celescope Catalog", "CEL 1767"},
        {"Geneva Identification System", "GEN# -0.02604162"},
        {"Smithsonian Astrophysical Observation", "SAO 173451"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.69692243),
        dec: Angle.Degrees(-26.95186840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115960"},
        {"Hipparcos Number", "HIP 65137"},
        {"Smithsonian Astrophysical Observation", "SAO 181572"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.22227224),
        dec: Angle.Degrees(-26.95147771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65669"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.97539393),
        dec: Angle.Degrees(-26.95014730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186265"},
        {"Hipparcos Number", "HIP 97125"},
        {"Geneva Identification System", "GEN# +1.00186265"},
        {"Smithsonian Astrophysical Observation", "SAO 188503"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.09878730),
        dec: Angle.Degrees(-26.94888216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144073"},
        {"Hipparcos Number", "HIP 78782"},
        {"Geneva Identification System", "GEN# +1.00144073"},
        {"Smithsonian Astrophysical Observation", "SAO 184092"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.25564743),
        dec: Angle.Degrees(-26.94777340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76028"},
        {"Hipparcos Number", "HIP 43597"},
        {"Geneva Identification System", "GEN# +1.00076028"},
        {"Smithsonian Astrophysical Observation", "SAO 176623"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19243592),
        dec: Angle.Degrees(-26.94747112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187886"},
        {"Hipparcos Number", "HIP 97880"},
        {"Smithsonian Astrophysical Observation", "SAO 188677"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.35356874),
        dec: Angle.Degrees(-26.94355819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34310"},
        {"Hipparcos Number", "HIP 24505"},
        {"Geneva Identification System", "GEN# +1.00034310"},
        {"Smithsonian Astrophysical Observation", "SAO 170238"},
        {"Wilson Evans Batten Catalogue", "WEB 4747"},
    },
    visualMagnitude: 5.06,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.85152247),
        dec: Angle.Degrees(-26.94343723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9369 AB"},
        {"Henry Draper", "HD 129831"},
        {"Hipparcos Number", "HIP 72158"},
        {"Smithsonian Astrophysical Observation", "SAO 182848"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.38537868),
        dec: Angle.Degrees(-26.94260168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37810"},
        {"Hipparcos Number", "HIP 26667"},
        {"Smithsonian Astrophysical Observation", "SAO 170664"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.01603777),
        dec: Angle.Degrees(-26.94172079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12256"},
        {"Hipparcos Number", "HIP 9323"},
        {"Geneva Identification System", "GEN# +1.00012256"},
        {"Smithsonian Astrophysical Observation", "SAO 167467"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.93757817),
        dec: Angle.Degrees(-26.93924575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160089"},
        {"Hipparcos Number", "HIP 86385"},
        {"Geneva Identification System", "GEN# +1.00160089"},
        {"Smithsonian Astrophysical Observation", "SAO 185589"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77486519),
        dec: Angle.Degrees(-26.93738228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12077"},
        {"Hipparcos Number", "HIP 9162"},
        {"Smithsonian Astrophysical Observation", "SAO 167438"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.49268417),
        dec: Angle.Degrees(-26.93622796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202264"},
        {"Hipparcos Number", "HIP 104934"},
        {"Smithsonian Astrophysical Observation", "SAO 190167"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.83282263),
        dec: Angle.Degrees(-26.93474807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43828"},
        {"Hipparcos Number", "HIP 29855"},
        {"Geneva Identification System", "GEN# +1.00043828"},
        {"Smithsonian Astrophysical Observation", "SAO 171513"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.30797212),
        dec: Angle.Degrees(-26.93293150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58563"},
        {"Hipparcos Number", "HIP 35996"},
        {"Smithsonian Astrophysical Observation", "SAO 173686"},
    },
    visualMagnitude: 9.62,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.27949541),
        dec: Angle.Degrees(-26.93279211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18607"},
        {"Hipparcos Number", "HIP 13873"},
        {"Geneva Identification System", "GEN# +1.00018607"},
        {"Smithsonian Astrophysical Observation", "SAO 168199"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.67404941),
        dec: Angle.Degrees(-26.92757311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157485"},
        {"Hipparcos Number", "HIP 85189"},
        {"Geneva Identification System", "GEN# +1.00157485"},
        {"Smithsonian Astrophysical Observation", "SAO 185363"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.14508120),
        dec: Angle.Degrees(-26.92472774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92444"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.58856166),
        dec: Angle.Degrees(-26.92357833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221748"},
        {"Hipparcos Number", "HIP 116376"},
        {"Smithsonian Astrophysical Observation", "SAO 192010"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.72726884),
        dec: Angle.Degrees(-26.92168012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71979"},
        {"Hipparcos Number", "HIP 41633"},
        {"Smithsonian Astrophysical Observation", "SAO 175933"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.33559045),
        dec: Angle.Degrees(-26.92148127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166195"},
        {"Hipparcos Number", "HIP 89063"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.66571228),
        dec: Angle.Degrees(-26.92089796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152057"},
        {"Hipparcos Number", "HIP 82534"},
        {"Geneva Identification System", "GEN# +1.00152057"},
        {"Smithsonian Astrophysical Observation", "SAO 184732"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.05550725),
        dec: Angle.Degrees(-26.91960322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118188"},
        {"Hipparcos Number", "HIP 66331"},
        {"Smithsonian Astrophysical Observation", "SAO 181778"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.90840798),
        dec: Angle.Degrees(-26.91932478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198542"},
        {"Hipparcos Number", "HIP 102978"},
        {"Fundamental Katalog 5th Edition", "FK5 1546"},
        {"Geneva Identification System", "GEN# +1.00198542"},
        {"Smithsonian Astrophysical Observation", "SAO 189781"},
        {"Wilson Evans Batten Catalogue", "WEB 18687"},
    },
    visualMagnitude: 4.12,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.95540084),
        dec: Angle.Degrees(-26.91912642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6264 A"},
        {"Henry Draper", "HD 61687"},
        {"Hipparcos Number", "HIP 37304"},
        {"Geneva Identification System", "GEN# +1.00061687J"},
        {"Smithsonian Astrophysical Observation", "SAO 174223"},
        {"Wilson Evans Batten Catalogue", "WEB 7384"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.87438779),
        dec: Angle.Degrees(-26.91898650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71505"},
        {"Hipparcos Number", "HIP 41415"},
        {"Smithsonian Astrophysical Observation", "SAO 175848"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.71543314),
        dec: Angle.Degrees(-26.91718377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76225"},
        {"Hipparcos Number", "HIP 43703"},
        {"Renson", "Renson 21350"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50370924),
        dec: Angle.Degrees(-26.91581196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125931"},
        {"Hipparcos Number", "HIP 70315"},
        {"Smithsonian Astrophysical Observation", "SAO 182485"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.79424820),
        dec: Angle.Degrees(-26.91202168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195385"},
        {"Hipparcos Number", "HIP 101288"},
        {"Smithsonian Astrophysical Observation", "SAO 189395"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.96309482),
        dec: Angle.Degrees(-26.91041532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21515"},
        {"Hipparcos Number", "HIP 16089"},
        {"Smithsonian Astrophysical Observation", "SAO 168555"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.80895564),
        dec: Angle.Degrees(-26.90951176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87319"},
        {"Hipparcos Number", "HIP 49292"},
        {"Geneva Identification System", "GEN# +1.00087319"},
        {"Smithsonian Astrophysical Observation", "SAO 178356"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.91601803),
        dec: Angle.Degrees(-26.90950554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145102"},
        {"Hipparcos Number", "HIP 79235"},
        {"Geneva Identification System", "GEN# +1.00145102"},
        {"Renson", "Renson 41120"},
        {"Smithsonian Astrophysical Observation", "SAO 184184"},
        {"Wilson Evans Batten Catalogue", "WEB 13397"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.56638035),
        dec: Angle.Degrees(-26.90904616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1409"},
        {"Hipparcos Number", "HIP 1453"},
        {"Smithsonian Astrophysical Observation", "SAO 166173"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.52543207),
        dec: Angle.Degrees(-26.90789226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200823"},
        {"Hipparcos Number", "HIP 104200"},
        {"Smithsonian Astrophysical Observation", "SAO 190010"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.66561331),
        dec: Angle.Degrees(-26.90724283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32165"},
        {"Hipparcos Number", "HIP 23236"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00321969),
        dec: Angle.Degrees(-26.90581729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118627"},
        {"Hipparcos Number", "HIP 66550"},
        {"Smithsonian Astrophysical Observation", "SAO 181823"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.62978584),
        dec: Angle.Degrees(-26.90567942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110767"},
        {"Hipparcos Number", "HIP 62180"},
        {"Smithsonian Astrophysical Observation", "SAO 181071"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.14841633),
        dec: Angle.Degrees(-26.90488915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60057"},
        {"Hipparcos Number", "HIP 36605"},
        {"Celescope Catalog", "CEL 1910"},
        {"Geneva Identification System", "GEN# +1.00060057"},
        {"Smithsonian Astrophysical Observation", "SAO 173928"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.91910531),
        dec: Angle.Degrees(-26.90141654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98414"},
        {"Hipparcos Number", "HIP 55259"},
        {"Smithsonian Astrophysical Observation", "SAO 179766"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.77433446),
        dec: Angle.Degrees(-26.89719389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64220"},
        {"Hipparcos Number", "HIP 38386"},
        {"Smithsonian Astrophysical Observation", "SAO 174689"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.95186135),
        dec: Angle.Degrees(-26.89637191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45267"},
        {"Hipparcos Number", "HIP 30551"},
        {"Smithsonian Astrophysical Observation", "SAO 171724"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.33377925),
        dec: Angle.Degrees(-26.89530399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8326"},
        {"Hipparcos Number", "HIP 6390"},
        {"Geneva Identification System", "GEN# +1.00008326"},
        {"Smithsonian Astrophysical Observation", "SAO 166994"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53188179),
        dec: Angle.Degrees(-26.89255267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175046"},
        {"Hipparcos Number", "HIP 92808"},
        {"Smithsonian Astrophysical Observation", "SAO 187438"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.65871688),
        dec: Angle.Degrees(-26.89005367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84429"},
        {"Hipparcos Number", "HIP 47794"},
        {"Geneva Identification System", "GEN# +1.00084429"},
        {"Smithsonian Astrophysical Observation", "SAO 177919"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15579508),
        dec: Angle.Degrees(-26.88825072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222402"},
        {"Hipparcos Number", "HIP 116801"},
        {"Geneva Identification System", "GEN# +1.00222402"},
        {"Smithsonian Astrophysical Observation", "SAO 192076"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.08139999),
        dec: Angle.Degrees(-26.88785508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5365"},
        {"Geneva Identification System", "GEN# +6.10161000"},
        {"Geneva Identification System 2", "GEN# +6.20021460"},
    },
    visualMagnitude: 12.54,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.15554558),
        dec: Angle.Degrees(-26.88602157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68385"},
        {"Hipparcos Number", "HIP 40074"},
        {"Smithsonian Astrophysical Observation", "SAO 175344"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79385384),
        dec: Angle.Degrees(-26.88417927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123811"},
        {"Hipparcos Number", "HIP 69228"},
        {"Geneva Identification System", "GEN# +1.00123811"},
        {"Smithsonian Astrophysical Observation", "SAO 182307"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.60842843),
        dec: Angle.Degrees(-26.88147881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200052"},
        {"Hipparcos Number", "HIP 103777"},
        {"Geneva Identification System", "GEN# +1.00200052"},
        {"Renson", "Renson 55700"},
        {"Smithsonian Astrophysical Observation", "SAO 189942"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.43862372),
        dec: Angle.Degrees(-26.88093351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116713"},
    },
    visualMagnitude: 11.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.79176026),
        dec: Angle.Degrees(-26.87812097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93217"},
    },
    visualMagnitude: 10.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.82064293),
        dec: Angle.Degrees(-26.87680724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221907"},
        {"Hipparcos Number", "HIP 116482"},
        {"Fundamental Katalog 5th Edition", "FK5 6088"},
        {"Renson", "Renson 60820"},
        {"Smithsonian Astrophysical Observation", "SAO 192030"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.04024223),
        dec: Angle.Degrees(-26.87631670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179520"},
        {"Hipparcos Number", "HIP 94491"},
        {"Geneva Identification System", "GEN# +1.00179520"},
        {"Smithsonian Astrophysical Observation", "SAO 187848"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.48484790),
        dec: Angle.Degrees(-26.87603441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146899"},
        {"Hipparcos Number", "HIP 79987"},
        {"Geneva Identification System", "GEN# +1.00146899"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.90772059),
        dec: Angle.Degrees(-26.87524323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151982"},
        {"Hipparcos Number", "HIP 82512"},
        {"Geneva Identification System", "GEN# +1.00151982"},
        {"Smithsonian Astrophysical Observation", "SAO 184724"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.96554951),
        dec: Angle.Degrees(-26.87378010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143441"},
        {"Hipparcos Number", "HIP 78483"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.32678779),
        dec: Angle.Degrees(-26.87258570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99273"},
        {"Hipparcos Number", "HIP 55742"},
        {"Smithsonian Astrophysical Observation", "SAO 179863"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.31939222),
        dec: Angle.Degrees(-26.87085007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214427"},
        {"Hipparcos Number", "HIP 111760"},
        {"Smithsonian Astrophysical Observation", "SAO 191287"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59208959),
        dec: Angle.Degrees(-26.86977414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102507",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14258 A"},
        {"Henry Draper", "HD 197746"},
        {"Hipparcos Number", "HIP 102507"},
        {"Smithsonian Astrophysical Observation", "SAO 189675"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.61414137),
        dec: Angle.Degrees(-26.86863642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91174"},
        {"Hipparcos Number", "HIP 51494"},
        {"Smithsonian Astrophysical Observation", "SAO 178920"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.75395393),
        dec: Angle.Degrees(-26.86747200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90906"},
        {"Hipparcos Number", "HIP 51341"},
        {"Smithsonian Astrophysical Observation", "SAO 178884"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.30398382),
        dec: Angle.Degrees(-26.86687662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9932"},
        {"Geneva Identification System", "GEN# -0.02700737"},
        {"Smithsonian Astrophysical Observation", "SAO 167572"},
        {"Wilson Evans Batten Catalogue", "WEB 2085"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.96649931),
        dec: Angle.Degrees(-26.86585647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102505",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14258 B"},
        {"Hipparcos Number", "HIP 102505"},
        {"Smithsonian Astrophysical Observation", "SAO 189674"},
    },
    visualMagnitude: 10.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.61482632),
        dec: Angle.Degrees(-26.86500410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89257"},
        {"Hipparcos Number", "HIP 50387"},
        {"Smithsonian Astrophysical Observation", "SAO 178621"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.31590911),
        dec: Angle.Degrees(-26.86318904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61672"},
        {"Hipparcos Number", "HIP 37293"},
        {"Celescope Catalog", "CEL 1965"},
        {"Geneva Identification System", "GEN# +1.00061672"},
        {"Smithsonian Astrophysical Observation", "SAO 174219"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86243597),
        dec: Angle.Degrees(-26.86309474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7883"},
        {"Hipparcos Number", "HIP 6088"},
        {"Geneva Identification System", "GEN# +1.00007883"},
        {"Smithsonian Astrophysical Observation", "SAO 166935"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.54350211),
        dec: Angle.Degrees(-26.86198447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212448"},
        {"Hipparcos Number", "HIP 110641"},
        {"Smithsonian Astrophysical Observation", "SAO 191119"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.19374674),
        dec: Angle.Degrees(-26.85984353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83317"},
        {"Hipparcos Number", "HIP 47180"},
        {"Smithsonian Astrophysical Observation", "SAO 177746"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.22043659),
        dec: Angle.Degrees(-26.85815735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126500"},
        {"Hipparcos Number", "HIP 70614"},
        {"Fundamental Katalog 5th Edition", "FK5 5276"},
        {"Smithsonian Astrophysical Observation", "SAO 182546"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.66072540),
        dec: Angle.Degrees(-26.85724829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56373"},
        {"Hipparcos Number", "HIP 35117"},
        {"Celescope Catalog", "CEL 1721"},
        {"Geneva Identification System", "GEN# +1.00056373"},
        {"Smithsonian Astrophysical Observation", "SAO 173317"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.90967577),
        dec: Angle.Degrees(-26.85676797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28035"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.92919885),
        dec: Angle.Degrees(-26.85648122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 314.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3257"},
        {"Hipparcos Number", "HIP 2798"},
        {"Geneva Identification System", "GEN# +1.00003257"},
        {"Smithsonian Astrophysical Observation", "SAO 166388"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.90921499),
        dec: Angle.Degrees(-26.85626057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97608"},
        {"Hipparcos Number", "HIP 54847"},
        {"Smithsonian Astrophysical Observation", "SAO 179663"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.43113599),
        dec: Angle.Degrees(-26.85461707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30628"},
        {"Hipparcos Number", "HIP 22308"},
        {"Smithsonian Astrophysical Observation", "SAO 169780"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.07817902),
        dec: Angle.Degrees(-26.85376833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 834"},
        {"Hipparcos Number", "HIP 1013"},
        {"Geneva Identification System", "GEN# +1.00000834"},
        {"Smithsonian Astrophysical Observation", "SAO 166114"},
        {"Wilson Evans Batten Catalogue", "WEB 176"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16145690),
        dec: Angle.Degrees(-26.85334216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80620"},
        {"Hipparcos Number", "HIP 45786"},
        {"Smithsonian Astrophysical Observation", "SAO 177294"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.02938810),
        dec: Angle.Degrees(-26.85248786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126400"},
        {"Hipparcos Number", "HIP 70538"},
        {"Geneva Identification System", "GEN# +1.00126400"},
        {"Smithsonian Astrophysical Observation", "SAO 182535"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.44905121),
        dec: Angle.Degrees(-26.85210525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133468"},
        {"Hipparcos Number", "HIP 73835"},
        {"Smithsonian Astrophysical Observation", "SAO 183156"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.34378913),
        dec: Angle.Degrees(-26.85166963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122476"},
        {"Hipparcos Number", "HIP 68608"},
        {"Geneva Identification System", "GEN# +1.00122476"},
        {"Smithsonian Astrophysical Observation", "SAO 182187"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.66084895),
        dec: Angle.Degrees(-26.84791249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315602"},
        {"Hipparcos Number", "HIP 90048"},
        {"Smithsonian Astrophysical Observation", "SAO 186731"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.62349363),
        dec: Angle.Degrees(-26.84562805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160627"},
        {"Hipparcos Number", "HIP 86633"},
        {"Geneva Identification System", "GEN# +1.00160627"},
        {"Smithsonian Astrophysical Observation", "SAO 185630"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.52203230),
        dec: Angle.Degrees(-26.84559284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101295"},
        {"Hipparcos Number", "HIP 56846"},
        {"Smithsonian Astrophysical Observation", "SAO 180070"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.82735319),
        dec: Angle.Degrees(-26.84446795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107403"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.31657210),
        dec: Angle.Degrees(-26.84409153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73072"},
        {"Hipparcos Number", "HIP 42147"},
        {"Geneva Identification System", "GEN# +1.00073072"},
        {"Smithsonian Astrophysical Observation", "SAO 176131"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.86967445),
        dec: Angle.Degrees(-26.84353277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64908",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8850 AB"},
        {"Henry Draper", "HD 115560"},
        {"Hipparcos Number", "HIP 64908"},
        {"Smithsonian Astrophysical Observation", "SAO 181534"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.56340631),
        dec: Angle.Degrees(-26.84217157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139383"},
        {"Hipparcos Number", "HIP 76611"},
        {"Smithsonian Astrophysical Observation", "SAO 183651"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.68019492),
        dec: Angle.Degrees(-26.84092707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164768"},
        {"Hipparcos Number", "HIP 88465"},
        {"Geneva Identification System", "GEN# +1.00164768"},
        {"Smithsonian Astrophysical Observation", "SAO 186199"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.95365742),
        dec: Angle.Degrees(-26.83977818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59235"},
        {"Hipparcos Number", "HIP 36264"},
        {"Smithsonian Astrophysical Observation", "SAO 173797"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.00800583),
        dec: Angle.Degrees(-26.83899600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96109"},
        {"Hipparcos Number", "HIP 54167"},
        {"Smithsonian Astrophysical Observation", "SAO 179507"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.20566518),
        dec: Angle.Degrees(-26.83842202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125277"},
        {"Hipparcos Number", "HIP 69971"},
        {"Smithsonian Astrophysical Observation", "SAO 182434"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77078053),
        dec: Angle.Degrees(-26.83836706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194895"},
        {"Hipparcos Number", "HIP 101042"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.25746220),
        dec: Angle.Degrees(-26.83813891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25314"},
        {"Hipparcos Number", "HIP 18705"},
        {"Geneva Identification System", "GEN# +1.00025314"},
        {"Smithsonian Astrophysical Observation", "SAO 169026"},
        {"Wilson Evans Batten Catalogue", "WEB 3599"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.10520440),
        dec: Angle.Degrees(-26.83694777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154781"},
        {"Hipparcos Number", "HIP 83878"},
        {"Smithsonian Astrophysical Observation", "SAO 185065"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.15252170),
        dec: Angle.Degrees(-26.83672519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127189"},
        {"Hipparcos Number", "HIP 70948"},
        {"Geneva Identification System", "GEN# +1.00127189"},
        {"Smithsonian Astrophysical Observation", "SAO 182612"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.68631556),
        dec: Angle.Degrees(-26.83589968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178049"},
        {"Hipparcos Number", "HIP 93982"},
        {"Geneva Identification System", "GEN# +1.00178049"},
        {"Smithsonian Astrophysical Observation", "SAO 187716"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.03374237),
        dec: Angle.Degrees(-26.83465167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53963",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8028 AB"},
        {"Henry Draper", "HD 95698"},
        {"Hipparcos Number", "HIP 53963"},
        {"Geneva Identification System", "GEN# +1.00095698J"},
        {"Smithsonian Astrophysical Observation", "SAO 179456"},
        {"Wilson Evans Batten Catalogue", "WEB 9764"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60170418),
        dec: Angle.Degrees(-26.83120466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110213"},
        {"Hipparcos Number", "HIP 61870"},
        {"Smithsonian Astrophysical Observation", "SAO 181010"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.18288743),
        dec: Angle.Degrees(-26.83072308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103119"},
        {"Hipparcos Number", "HIP 57880"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.06924490),
        dec: Angle.Degrees(-26.82831352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163738"},
        {"Hipparcos Number", "HIP 88029"},
        {"Smithsonian Astrophysical Observation", "SAO 186029"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.70853990),
        dec: Angle.Degrees(-26.82825699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12999"},
        {"Hipparcos Number", "HIP 9844"},
        {"Smithsonian Astrophysical Observation", "SAO 167557"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.66661397),
        dec: Angle.Degrees(-26.82675053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170769"},
        {"Hipparcos Number", "HIP 90868"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.04993271),
        dec: Angle.Degrees(-26.82635683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133749"},
        {"Hipparcos Number", "HIP 73957"},
        {"Smithsonian Astrophysical Observation", "SAO 183183"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.71348992),
        dec: Angle.Degrees(-26.82527490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56472"},
        {"Hipparcos Number", "HIP 35166"},
        {"Celescope Catalog", "CEL 1731"},
        {"Smithsonian Astrophysical Observation", "SAO 173334"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.02519537),
        dec: Angle.Degrees(-26.82303802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40174"},
        {"Hipparcos Number", "HIP 28075"},
        {"Smithsonian Astrophysical Observation", "SAO 171033"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.02957102),
        dec: Angle.Degrees(-26.82261117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209522"},
        {"Hipparcos Number", "HIP 108975"},
        {"Fundamental Katalog 5th Edition", "FK5 3767"},
        {"Geneva Identification System", "GEN# +1.00209522"},
        {"Smithsonian Astrophysical Observation", "SAO 190864"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.15316181),
        dec: Angle.Degrees(-26.82233560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15307"},
        {"Hipparcos Number", "HIP 11418"},
        {"Smithsonian Astrophysical Observation", "SAO 167800"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.79832005),
        dec: Angle.Degrees(-26.82122965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153569"},
        {"Hipparcos Number", "HIP 83302"},
        {"Geneva Identification System", "GEN# +1.00153569"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.36504325),
        dec: Angle.Degrees(-26.81970906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67185"},
        {"Hipparcos Number", "HIP 39631"},
        {"Smithsonian Astrophysical Observation", "SAO 175164"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.48710310),
        dec: Angle.Degrees(-26.81955164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223025"},
        {"Hipparcos Number", "HIP 117223"},
        {"Geneva Identification System", "GEN# +1.00223025"},
        {"Smithsonian Astrophysical Observation", "SAO 192138"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.51298183),
        dec: Angle.Degrees(-26.81785050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61191"},
        {"Hipparcos Number", "HIP 37069"},
        {"Geneva Identification System", "GEN# +1.00061191"},
        {"Smithsonian Astrophysical Observation", "SAO 174134"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.26461447),
        dec: Angle.Degrees(-26.81631515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52910",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7939 AB"},
        {"Henry Draper", "HD 93785"},
        {"Hipparcos Number", "HIP 52910"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.31262104),
        dec: Angle.Degrees(-26.81516454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91473"},
        {"Hipparcos Number", "HIP 51657"},
        {"Smithsonian Astrophysical Observation", "SAO 178967"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.30673227),
        dec: Angle.Degrees(-26.81422204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217825"},
        {"Hipparcos Number", "HIP 113872"},
        {"Geneva Identification System", "GEN# +1.00217825"},
        {"Smithsonian Astrophysical Observation", "SAO 191612"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.90884732),
        dec: Angle.Degrees(-26.81331649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190285"},
        {"Hipparcos Number", "HIP 98926"},
        {"Fundamental Katalog 5th Edition", "FK5 5768"},
        {"Geneva Identification System", "GEN# +1.00190285"},
        {"Smithsonian Astrophysical Observation", "SAO 188892"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.30000994),
        dec: Angle.Degrees(-26.81324381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108163"},
        {"Hipparcos Number", "HIP 60635"},
        {"Geneva Identification System", "GEN# +1.00108163"},
        {"Smithsonian Astrophysical Observation", "SAO 180789"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.40078692),
        dec: Angle.Degrees(-26.81132257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162044"},
        {"Hipparcos Number", "HIP 87282"},
        {"Geneva Identification System", "GEN# +1.00162044"},
        {"Smithsonian Astrophysical Observation", "SAO 185817"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.52288439),
        dec: Angle.Degrees(-26.81075839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25234"},
        {"Smithsonian Astrophysical Observation", "SAO 170387"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.94865789),
        dec: Angle.Degrees(-26.81060835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150698"},
        {"Hipparcos Number", "HIP 81910"},
        {"Geneva Identification System", "GEN# +1.00150698"},
        {"Smithsonian Astrophysical Observation", "SAO 184581"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.96436285),
        dec: Angle.Degrees(-26.80869636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147743"},
        {"Hipparcos Number", "HIP 80400"},
        {"Geneva Identification System", "GEN# +1.00147743"},
        {"Smithsonian Astrophysical Observation", "SAO 184370"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.16867828),
        dec: Angle.Degrees(-26.80717644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97344"},
        {"Hipparcos Number", "HIP 54703"},
        {"Geneva Identification System", "GEN# +1.00097344"},
        {"Smithsonian Astrophysical Observation", "SAO 179628"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.99107396),
        dec: Angle.Degrees(-26.80615228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37229",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Markeb"},
        {"Aitken", "ADS 6255 AB"},
        {"Hipparcos Number", "HIP 37229"},
        {"Geneva Identification System", "GEN# +1.00061555"},
    },
    visualMagnitude: 3.80,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.70783872),
        dec: Angle.Degrees(-26.80389240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70098"},
        {"Hipparcos Number", "HIP 40767"},
        {"Smithsonian Astrophysical Observation", "SAO 175591"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81308323),
        dec: Angle.Degrees(-26.79986723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86265"},
        {"Smithsonian Astrophysical Observation", "SAO 185557"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.40057620),
        dec: Angle.Degrees(-26.79794620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56876"},
        {"Hipparcos Number", "HIP 35326"},
        {"Celescope Catalog", "CEL 1750"},
        {"Geneva Identification System", "GEN# +1.00056876"},
        {"Smithsonian Astrophysical Observation", "SAO 173411"},
        {"Wilson Evans Batten Catalogue", "WEB 7049"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.45005353),
        dec: Angle.Degrees(-26.79755949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33283"},
        {"Hipparcos Number", "HIP 23889"},
        {"Fundamental Katalog 5th Edition", "FK5 4470"},
        {"Geneva Identification System", "GEN# +1.00033283"},
        {"Smithsonian Astrophysical Observation", "SAO 170100"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.00406453),
        dec: Angle.Degrees(-26.79735879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216955"},
        {"Hipparcos Number", "HIP 113358"},
        {"Smithsonian Astrophysical Observation", "SAO 191523"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.37228468),
        dec: Angle.Degrees(-26.79645973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2903"},
        {"Hipparcos Number", "HIP 2538"},
        {"Geneva Identification System", "GEN# +1.00002903"},
        {"Smithsonian Astrophysical Observation", "SAO 166338"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.05841759),
        dec: Angle.Degrees(-26.79607481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82451"},
        {"Hipparcos Number", "HIP 46703"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.81871384),
        dec: Angle.Degrees(-26.79585022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34183"},
        {"Hipparcos Number", "HIP 24420"},
        {"Geneva Identification System", "GEN# +1.00034183"},
        {"Smithsonian Astrophysical Observation", "SAO 170227"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.58718516),
        dec: Angle.Degrees(-26.79379084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58797"},
        {"Hipparcos Number", "HIP 36083"},
        {"Smithsonian Astrophysical Observation", "SAO 173724"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.52161768),
        dec: Angle.Degrees(-26.79037175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47944"},
        {"Hipparcos Number", "HIP 31882"},
        {"Smithsonian Astrophysical Observation", "SAO 172116"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.97514209),
        dec: Angle.Degrees(-26.78790580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22474"},
        {"Hipparcos Number", "HIP 16773"},
        {"Geneva Identification System", "GEN# +1.00022474"},
        {"Smithsonian Astrophysical Observation", "SAO 168666"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.96069391),
        dec: Angle.Degrees(-26.78735415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125841"},
        {"Hipparcos Number", "HIP 70273"},
        {"Smithsonian Astrophysical Observation", "SAO 182475"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.67267310),
        dec: Angle.Degrees(-26.78670061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113194"},
        {"Hipparcos Number", "HIP 63618"},
        {"Geneva Identification System", "GEN# +1.00113194"},
        {"Smithsonian Astrophysical Observation", "SAO 181333"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.58664003),
        dec: Angle.Degrees(-26.78661820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92563"},
        {"Hipparcos Number", "HIP 52266"},
        {"Geneva Identification System", "GEN# +1.00092563"},
        {"Smithsonian Astrophysical Observation", "SAO 179105"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.19667152),
        dec: Angle.Degrees(-26.78540781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127459"},
        {"Hipparcos Number", "HIP 71084"},
        {"Smithsonian Astrophysical Observation", "SAO 182642"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.05141516),
        dec: Angle.Degrees(-26.78464676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192452"},
        {"Hipparcos Number", "HIP 99884"},
        {"Geneva Identification System", "GEN# +1.00192452"},
        {"Smithsonian Astrophysical Observation", "SAO 189078"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.98024138),
        dec: Angle.Degrees(-26.78334015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151831"},
        {"Hipparcos Number", "HIP 82451"},
        {"Geneva Identification System", "GEN# +1.00151831"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.74613907),
        dec: Angle.Degrees(-26.78096802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119592"},
        {"Hipparcos Number", "HIP 67064"},
        {"Geneva Identification System", "GEN# +1.00119592"},
        {"Smithsonian Astrophysical Observation", "SAO 181919"},
        {"Wilson Evans Batten Catalogue", "WEB 11812"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.15582170),
        dec: Angle.Degrees(-26.78007170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198465"},
        {"Hipparcos Number", "HIP 102940"},
        {"Smithsonian Astrophysical Observation", "SAO 189770"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.84433536),
        dec: Angle.Degrees(-26.77979596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29507"},
        {"Hipparcos Number", "HIP 21560"},
        {"Smithsonian Astrophysical Observation", "SAO 169623"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43177326),
        dec: Angle.Degrees(-26.77960592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31228"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.25103000),
        dec: Angle.Degrees(-26.77934135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196081"},
        {"Hipparcos Number", "HIP 101629"},
        {"Geneva Identification System", "GEN# +1.00196081"},
        {"Smithsonian Astrophysical Observation", "SAO 189471"},
        {"Wilson Evans Batten Catalogue", "WEB 18358"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.97672886),
        dec: Angle.Degrees(-26.77346812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163272"},
        {"Hipparcos Number", "HIP 87824"},
        {"Fundamental Katalog 5th Edition", "FK5 5578"},
        {"Geneva Identification System", "GEN# +1.00163272"},
        {"Smithsonian Astrophysical Observation", "SAO 185965"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10184452),
        dec: Angle.Degrees(-26.77318719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56139"},
        {"Hipparcos Number", "HIP 35037"},
        {"Celescope Catalog", "CEL 1708"},
        {"Geneva Identification System", "GEN# +1.00056139"},
        {"Smithsonian Astrophysical Observation", "SAO 173282"},
        {"Wilson Evans Batten Catalogue", "WEB 7007"},
    },
    visualMagnitude: 4.01,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70275679),
        dec: Angle.Degrees(-26.77268601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50033"},
        {"Hipparcos Number", "HIP 32799"},
        {"Smithsonian Astrophysical Observation", "SAO 172407"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.56495409),
        dec: Angle.Degrees(-26.77120745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92463",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11724 A"},
        {"Henry Draper", "HD 174229"},
        {"Hipparcos Number", "HIP 92463"},
        {"Renson", "Renson 48790"},
        {"Smithsonian Astrophysical Observation", "SAO 187336"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.65630302),
        dec: Angle.Degrees(-26.77041555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113869"},
        {"Hipparcos Number", "HIP 64002"},
        {"Smithsonian Astrophysical Observation", "SAO 181391"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.72518136),
        dec: Angle.Degrees(-26.76959854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142523"},
        {"Hipparcos Number", "HIP 78031"},
        {"Smithsonian Astrophysical Observation", "SAO 183938"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.99958028),
        dec: Angle.Degrees(-26.76919155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95235"},
        {"Henry Draper 2", "HD 95236"},
        {"Hipparcos Number", "HIP 53712"},
        {"Geneva Identification System", "GEN# +1.00095235"},
        {"Smithsonian Astrophysical Observation", "SAO 179404"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.85057473),
        dec: Angle.Degrees(-26.76850486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11285"},
        {"Smithsonian Astrophysical Observation", "SAO 110522"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.34264455),
        dec: Angle.Degrees(+03.60930515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30240"},
        {"Hipparcos Number", "HIP 22065"},
        {"Geneva Identification System", "GEN# +1.00030240"},
        {"Smithsonian Astrophysical Observation", "SAO 169725"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.19612948),
        dec: Angle.Degrees(-26.76837724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78676"},
        {"Hipparcos Number", "HIP 44887"},
        {"Fundamental Katalog 5th Edition", "FK5 2726"},
        {"Geneva Identification System", "GEN# +1.00078676"},
        {"Renson", "Renson 22300"},
        {"Smithsonian Astrophysical Observation", "SAO 177022"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.18150569),
        dec: Angle.Degrees(-26.76762631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27196"},
        {"Hipparcos Number", "HIP 19950"},
        {"Smithsonian Astrophysical Observation", "SAO 169293"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.18419257),
        dec: Angle.Degrees(-26.76562234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26611"},
        {"Hipparcos Number", "HIP 19568"},
        {"Smithsonian Astrophysical Observation", "SAO 169207"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.87972775),
        dec: Angle.Degrees(-26.76398935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3338"},
        {"Hipparcos Number", "HIP 2857"},
        {"Geneva Identification System", "GEN# +1.00003338"},
        {"Smithsonian Astrophysical Observation", "SAO 166402"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.05035349),
        dec: Angle.Degrees(-26.76039966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126146"},
        {"Hipparcos Number", "HIP 70419"},
        {"Smithsonian Astrophysical Observation", "SAO 182510"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09413042),
        dec: Angle.Degrees(-26.75873346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169938"},
        {"Hipparcos Number", "HIP 90510"},
        {"Geneva Identification System", "GEN# +1.00169938"},
        {"Smithsonian Astrophysical Observation", "SAO 186843"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02571606),
        dec: Angle.Degrees(-26.75715814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85693"},
        {"Hipparcos Number", "HIP 48466"},
        {"Geneva Identification System", "GEN# +1.00085693"},
        {"Smithsonian Astrophysical Observation", "SAO 178129"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.23482124),
        dec: Angle.Degrees(-26.75567140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136105"},
        {"Hipparcos Number", "HIP 75007"},
        {"Smithsonian Astrophysical Observation", "SAO 183373"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.90516572),
        dec: Angle.Degrees(-26.75475996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96710"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89971054),
        dec: Angle.Degrees(-26.75131985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 369.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152178"},
        {"Hipparcos Number", "HIP 82583"},
        {"Smithsonian Astrophysical Observation", "SAO 184742"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.23336245),
        dec: Angle.Degrees(-26.75061861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26041"},
        {"Smithsonian Astrophysical Observation", "SAO 170548"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32629302),
        dec: Angle.Degrees(-26.75053884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53040"},
        {"Hipparcos Number", "HIP 33924"},
        {"Smithsonian Astrophysical Observation", "SAO 172823"},
    },
    visualMagnitude: 9.83,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.59602401),
        dec: Angle.Degrees(-26.75028214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79015"},
        {"Hipparcos Number", "HIP 45059"},
        {"Smithsonian Astrophysical Observation", "SAO 177077"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.66625289),
        dec: Angle.Degrees(-26.75021061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219020"},
        {"Hipparcos Number", "HIP 114599"},
        {"Smithsonian Astrophysical Observation", "SAO 191727"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.23592509),
        dec: Angle.Degrees(-26.74985237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102620"},
        {"Hipparcos Number", "HIP 57613"},
        {"Fundamental Katalog 5th Edition", "FK5 1305"},
        {"Geneva Identification System", "GEN# +1.00102620"},
        {"Smithsonian Astrophysical Observation", "SAO 180208"},
        {"Wilson Evans Batten Catalogue", "WEB 10345"},
    },
    visualMagnitude: 5.10,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.18793920),
        dec: Angle.Degrees(-26.74975369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11020"},
        {"Hipparcos Number", "HIP 8346"},
        {"Geneva Identification System", "GEN# +1.00011020"},
        {"Smithsonian Astrophysical Observation", "SAO 167300"},
        {"Wilson Evans Batten Catalogue", "WEB 1775"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91014516),
        dec: Angle.Degrees(-26.74935383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24951"},
        {"Hipparcos Number", "HIP 18479"},
        {"Smithsonian Astrophysical Observation", "SAO 168980"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.23959125),
        dec: Angle.Degrees(-26.74898247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8155"},
        {"Hipparcos Number", "HIP 6275"},
        {"Smithsonian Astrophysical Observation", "SAO 166974"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13367812),
        dec: Angle.Degrees(-26.74830744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9836 AB"},
        {"Henry Draper", "HD 142456"},
        {"Hipparcos Number", "HIP 78002"},
        {"Geneva Identification System", "GEN# +1.00142456J"},
        {"Smithsonian Astrophysical Observation", "SAO 183933"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92470062),
        dec: Angle.Degrees(-26.74701733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100307"},
        {"Hipparcos Number", "HIP 56293"},
        {"Geneva Identification System", "GEN# +1.00100307"},
        {"Smithsonian Astrophysical Observation", "SAO 179969"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.09723921),
        dec: Angle.Degrees(-26.74685306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94473"},
        {"Hipparcos Number", "HIP 53294"},
        {"Geneva Identification System", "GEN# +1.00094473"},
        {"Smithsonian Astrophysical Observation", "SAO 179318"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.49435853),
        dec: Angle.Degrees(-26.74612765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3188"},
        {"Hipparcos Number", "HIP 2744"},
        {"Geneva Identification System", "GEN# +1.00003188"},
        {"Smithsonian Astrophysical Observation", "SAO 166380"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75648501),
        dec: Angle.Degrees(-26.74567136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151721"},
        {"Hipparcos Number", "HIP 82397"},
        {"Smithsonian Astrophysical Observation", "SAO 184689"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.54464001),
        dec: Angle.Degrees(-26.74247881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12562"},
        {"Hipparcos Number", "HIP 9535"},
        {"Smithsonian Astrophysical Observation", "SAO 167513"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64727310),
        dec: Angle.Degrees(-26.74145675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172407"},
        {"Hipparcos Number", "HIP 91621"},
        {"Geneva Identification System", "GEN# +1.00172407"},
        {"Smithsonian Astrophysical Observation", "SAO 187127"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.27658944),
        dec: Angle.Degrees(-26.74062724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20123"},
    },
    visualMagnitude: 10.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.71499310),
        dec: Angle.Degrees(-26.73993075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159254"},
        {"Hipparcos Number", "HIP 86020"},
        {"Renson", "Renson 44780"},
        {"Smithsonian Astrophysical Observation", "SAO 185519"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.69284494),
        dec: Angle.Degrees(-26.73968924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111786"},
        {"Hipparcos Number", "HIP 62788"},
        {"Geneva Identification System", "GEN# +1.00111786"},
        {"Smithsonian Astrophysical Observation", "SAO 181169"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.99153012),
        dec: Angle.Degrees(-26.73835190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36109"},
        {"Hipparcos Number", "HIP 25601"},
        {"Smithsonian Astrophysical Observation", "SAO 170459"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.05477450),
        dec: Angle.Degrees(-26.73798664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107246"},
        {"Hipparcos Number", "HIP 60132"},
        {"Smithsonian Astrophysical Observation", "SAO 180689"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.98045464),
        dec: Angle.Degrees(-26.73688929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200486"},
        {"Hipparcos Number", "HIP 104022"},
        {"Smithsonian Astrophysical Observation", "SAO 189984"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.11844310),
        dec: Angle.Degrees(-26.73508856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13770 A"},
        {"Henry Draper", "HD 193883"},
        {"Hipparcos Number", "HIP 100566"},
        {"Smithsonian Astrophysical Observation", "SAO 189223"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.88922451),
        dec: Angle.Degrees(-26.73498286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77953"},
        {"Smithsonian Astrophysical Observation", "SAO 183922"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.79591142),
        dec: Angle.Degrees(-26.73381506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27438"},
        {"Hipparcos Number", "HIP 20124"},
        {"Geneva Identification System", "GEN# +1.00027438"},
        {"Smithsonian Astrophysical Observation", "SAO 169331"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.72053120),
        dec: Angle.Degrees(-26.73348284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91917"},
        {"Hipparcos Number", "HIP 51927"},
        {"Smithsonian Astrophysical Observation", "SAO 179020"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.10577525),
        dec: Angle.Degrees(-26.73278420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107475"},
        {"Hipparcos Number", "HIP 60253"},
        {"Smithsonian Astrophysical Observation", "SAO 180711"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.31777105),
        dec: Angle.Degrees(-26.73246337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128959"},
        {"Hipparcos Number", "HIP 71761"},
        {"Geneva Identification System", "GEN# +1.00128959"},
        {"Smithsonian Astrophysical Observation", "SAO 182758"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.18081850),
        dec: Angle.Degrees(-26.72977712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158173"},
        {"Hipparcos Number", "HIP 85538"},
        {"Geneva Identification System", "GEN# +1.00158173"},
        {"Smithsonian Astrophysical Observation", "SAO 185438"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.20808682),
        dec: Angle.Degrees(-26.72958631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31406"},
        {"Hipparcos Number", "HIP 22815"},
        {"Smithsonian Astrophysical Observation", "SAO 169876"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.63664173),
        dec: Angle.Degrees(-26.72894858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6532"},
        {"Hipparcos Number", "HIP 5150"},
        {"Geneva Identification System", "GEN# +1.00006532"},
        {"Renson", "Renson 1670"},
        {"Smithsonian Astrophysical Observation", "SAO 166796"},
        {"Wilson Evans Batten Catalogue", "WEB 1070"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.48218878),
        dec: Angle.Degrees(-26.72883731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19124"},
        {"Hipparcos Number", "HIP 14253"},
        {"Geneva Identification System", "GEN# +1.00019124"},
        {"Smithsonian Astrophysical Observation", "SAO 168269"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.95162383),
        dec: Angle.Degrees(-26.72740397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93347"},
        {"Hipparcos Number", "HIP 52680"},
        {"Smithsonian Astrophysical Observation", "SAO 179209"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.57220180),
        dec: Angle.Degrees(-26.72608269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26013"},
        {"Geneva Identification System", "GEN# -0.02602288"},
        {"Smithsonian Astrophysical Observation", "SAO 170544"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26912293),
        dec: Angle.Degrees(-26.72488551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65085"},
        {"Hipparcos Number", "HIP 38760"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.02252302),
        dec: Angle.Degrees(-26.72448052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71682",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9330 A"},
        {"Henry Draper", "HD 128787"},
        {"Hipparcos Number", "HIP 71682"},
        {"Geneva Identification System", "GEN# +1.00128787A"},
        {"Smithsonian Astrophysical Observation", "SAO 182739"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.92053587),
        dec: Angle.Degrees(-26.72362903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181812"},
        {"Hipparcos Number", "HIP 95275"},
        {"Smithsonian Astrophysical Observation", "SAO 188048"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76015764),
        dec: Angle.Degrees(-26.72312056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80619"},
        {"Hipparcos Number", "HIP 45780"},
        {"Smithsonian Astrophysical Observation", "SAO 177292"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.01979829),
        dec: Angle.Degrees(-26.72163209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124870"},
        {"Hipparcos Number", "HIP 69764"},
        {"Smithsonian Astrophysical Observation", "SAO 182398"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.16184523),
        dec: Angle.Degrees(-26.72108612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17979"},
        {"Hipparcos Number", "HIP 13405"},
        {"Smithsonian Astrophysical Observation", "SAO 168115"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.14990018),
        dec: Angle.Degrees(-26.72066429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77827"},
        {"Hipparcos Number", "HIP 44498"},
        {"Smithsonian Astrophysical Observation", "SAO 176897"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99218566),
        dec: Angle.Degrees(-26.72020869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37472"},
        {"Hipparcos Number", "HIP 26457"},
        {"Geneva Identification System", "GEN# +1.00037472"},
        {"Smithsonian Astrophysical Observation", "SAO 170609"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.42282941),
        dec: Angle.Degrees(-26.71813781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143766"},
        {"Hipparcos Number", "HIP 78647"},
        {"Geneva Identification System", "GEN# +1.00143766"},
        {"Smithsonian Astrophysical Observation", "SAO 184064"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.81723088),
        dec: Angle.Degrees(-26.71666193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206563"},
        {"Hipparcos Number", "HIP 107260"},
        {"Smithsonian Astrophysical Observation", "SAO 190579"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.88206253),
        dec: Angle.Degrees(-26.71638693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217024"},
        {"Hipparcos Number", "HIP 113400"},
        {"Smithsonian Astrophysical Observation", "SAO 191532"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.48704472),
        dec: Angle.Degrees(-26.71606781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187308"},
        {"Hipparcos Number", "HIP 97613"},
        {"Geneva Identification System", "GEN# +1.00187308"},
        {"Smithsonian Astrophysical Observation", "SAO 188613"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.59156992),
        dec: Angle.Degrees(-26.71576482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19678"},
        {"Hipparcos Number", "HIP 14643"},
        {"Fundamental Katalog 5th Edition", "FK5 4287"},
        {"Smithsonian Astrophysical Observation", "SAO 168336"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.30639763),
        dec: Angle.Degrees(-26.71568877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52054"},
        {"Hipparcos Number", "HIP 33576"},
        {"Smithsonian Astrophysical Observation", "SAO 172671"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65016157),
        dec: Angle.Degrees(-26.71371292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109454"},
        {"Hipparcos Number", "HIP 61412"},
        {"Geneva Identification System", "GEN# +1.00109454"},
        {"Smithsonian Astrophysical Observation", "SAO 180924"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.75404693),
        dec: Angle.Degrees(-26.71257952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88462"},
        {"Hipparcos Number", "HIP 49931"},
        {"Smithsonian Astrophysical Observation", "SAO 178516"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.91812236),
        dec: Angle.Degrees(-26.71056952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1779"},
        {"Hipparcos Number", "HIP 1746"},
        {"Cincinnati Publication", "Ci 18 35"},
        {"Cincinnati Publication 2", "Ci 20 24"},
        {"Geneva Identification System", "GEN# +1.00001779"},
        {"Smithsonian Astrophysical Observation", "SAO 166215"},
        {"Wilson Evans Batten Catalogue", "WEB 313"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.51774848),
        dec: Angle.Degrees(-26.70947231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 411.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102557"},
        {"Hipparcos Number", "HIP 57580"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.05925628),
        dec: Angle.Degrees(-26.70884039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70171"},
        {"Hipparcos Number", "HIP 40798"},
        {"Smithsonian Astrophysical Observation", "SAO 175603"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.90248781),
        dec: Angle.Degrees(-26.70814456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121052"},
        {"Hipparcos Number", "HIP 67834"},
        {"Smithsonian Astrophysical Observation", "SAO 182053"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42543482),
        dec: Angle.Degrees(-26.70733372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137303"},
        {"Hipparcos Number", "HIP 75542"},
        {"Geneva Identification System", "GEN# +1.00137303"},
        {"Smithsonian Astrophysical Observation", "SAO 183462"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.49598885),
        dec: Angle.Degrees(-26.70575821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -818.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35386"},
        {"Hipparcos Number", "HIP 25180"},
        {"Fundamental Katalog 5th Edition", "FK5 4495"},
        {"Geneva Identification System", "GEN# +1.00035386"},
        {"Smithsonian Astrophysical Observation", "SAO 170375"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.79991836),
        dec: Angle.Degrees(-26.70548911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82157"},
        {"Smithsonian Astrophysical Observation", "SAO 184633"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.76358457),
        dec: Angle.Degrees(-26.70475000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72434"},
        {"Hipparcos Number", "HIP 41846"},
        {"Smithsonian Astrophysical Observation", "SAO 176020"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.98435832),
        dec: Angle.Degrees(-26.70370287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33736"},
        {"Hipparcos Number", "HIP 24149"},
        {"Smithsonian Astrophysical Observation", "SAO 170164"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.79413560),
        dec: Angle.Degrees(-26.70367242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201812"},
        {"Hipparcos Number", "HIP 104722"},
        {"Smithsonian Astrophysical Observation", "SAO 190126"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.19977712),
        dec: Angle.Degrees(-26.70293698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84103",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10384 AB"},
        {"Henry Draper", "HD 155270"},
        {"Hipparcos Number", "HIP 84103"},
        {"Smithsonian Astrophysical Observation", "SAO 185126"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.90320784),
        dec: Angle.Degrees(-26.70245234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42486"},
        {"Hipparcos Number", "HIP 29233"},
        {"Geneva Identification System", "GEN# +1.00042486"},
        {"Smithsonian Astrophysical Observation", "SAO 171318"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.44648871),
        dec: Angle.Degrees(-26.70111783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57527"},
        {"Hipparcos Number", "HIP 35578"},
        {"Geneva Identification System", "GEN# +1.00057527"},
        {"Renson", "Renson 15720"},
        {"Smithsonian Astrophysical Observation", "SAO 173505"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.13565302),
        dec: Angle.Degrees(-26.70034238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16279"},
        {"Hipparcos Number", "HIP 12106"},
        {"Smithsonian Astrophysical Observation", "SAO 167905"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.99963533),
        dec: Angle.Degrees(-26.69894755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71686",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9330 CD"},
        {"Hipparcos Number", "HIP 71686"},
        {"Geneva Identification System", "GEN# -0.02610417"},
        {"Smithsonian Astrophysical Observation", "SAO 182743"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.94585878),
        dec: Angle.Degrees(-26.69797068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15420 AB"},
        {"Henry Draper", "HD 208014"},
        {"Hipparcos Number", "HIP 108088"},
        {"Smithsonian Astrophysical Observation", "SAO 190720"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.48875098),
        dec: Angle.Degrees(-26.69724811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111964"},
        {"Hipparcos Number", "HIP 62892"},
        {"Geneva Identification System", "GEN# +1.00111964"},
        {"Smithsonian Astrophysical Observation", "SAO 181197"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.33474944),
        dec: Angle.Degrees(-26.69712811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16253"},
        {"Hipparcos Number", "HIP 12084"},
        {"Smithsonian Astrophysical Observation", "SAO 167901"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.93431948),
        dec: Angle.Degrees(-26.69680502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188028"},
        {"Hipparcos Number", "HIP 97931"},
        {"Geneva Identification System", "GEN# +1.00188028"},
        {"Smithsonian Astrophysical Observation", "SAO 188688"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.54299165),
        dec: Angle.Degrees(-26.69603265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136703"},
        {"Hipparcos Number", "HIP 75288"},
        {"Fundamental Katalog 5th Edition", "FK5 1404"},
        {"Geneva Identification System", "GEN# +1.00136703"},
        {"Smithsonian Astrophysical Observation", "SAO 183423"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.73769711),
        dec: Angle.Degrees(-26.68877567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137917"},
        {"Hipparcos Number", "HIP 75854"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.40919938),
        dec: Angle.Degrees(-26.68866177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113470"},
        {"Hipparcos Number", "HIP 63778"},
        {"Smithsonian Astrophysical Observation", "SAO 181364"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.08827826),
        dec: Angle.Degrees(-26.68670936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123123"},
        {"Hipparcos Number", "HIP 68895"},
        {"Fundamental Katalog 5th Edition", "FK5 519"},
        {"Geneva Identification System", "GEN# +1.00123123"},
        {"Smithsonian Astrophysical Observation", "SAO 182244"},
        {"Wilson Evans Batten Catalogue", "WEB 12040"},
    },
    visualMagnitude: 3.25,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.59278733),
        dec: Angle.Degrees(-26.68201883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3734"},
        {"Hipparcos Number", "HIP 3139"},
        {"Geneva Identification System", "GEN# +1.00003734"},
        {"Smithsonian Astrophysical Observation", "SAO 166467"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.98335060),
        dec: Angle.Degrees(-26.68082912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72266"},
        {"Hipparcos Number", "HIP 41759"},
        {"Geneva Identification System", "GEN# +1.00072266"},
        {"Smithsonian Astrophysical Observation", "SAO 175983"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.73297459),
        dec: Angle.Degrees(-26.67899354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115815",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16767 AB"},
        {"Henry Draper", "HD 220902"},
        {"Hipparcos Number", "HIP 115815"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.93857022),
        dec: Angle.Degrees(-26.67837905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7846 AB"},
        {"Henry Draper", "HD 91881"},
        {"Hipparcos Number", "HIP 51885"},
        {"Geneva Identification System", "GEN# +1.00091881"},
        {"Smithsonian Astrophysical Observation", "SAO 179014"},
        {"Wilson Evans Batten Catalogue", "WEB 9468"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.01877664),
        dec: Angle.Degrees(-26.67528564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35315"},
        {"Smithsonian Astrophysical Observation", "SAO 173406"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.42042525),
        dec: Angle.Degrees(-26.67480212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90016"},
        {"Hipparcos Number", "HIP 50836"},
        {"Smithsonian Astrophysical Observation", "SAO 178751"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71080311),
        dec: Angle.Degrees(-26.67358482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176336"},
        {"Hipparcos Number", "HIP 93339"},
        {"Smithsonian Astrophysical Observation", "SAO 187565"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.17760317),
        dec: Angle.Degrees(-26.67131355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121885"},
        {"Hipparcos Number", "HIP 68289"},
        {"Smithsonian Astrophysical Observation", "SAO 182136"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.68888014),
        dec: Angle.Degrees(-26.67087955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8282"},
        {"Hipparcos Number", "HIP 6361"},
        {"Geneva Identification System", "GEN# +1.00008282"},
        {"Smithsonian Astrophysical Observation", "SAO 166986"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.42807613),
        dec: Angle.Degrees(-26.66779894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101612"},
        {"Hipparcos Number", "HIP 57017"},
        {"Geneva Identification System", "GEN# +1.00101612"},
        {"Smithsonian Astrophysical Observation", "SAO 180103"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.34423883),
        dec: Angle.Degrees(-26.66728204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203072"},
        {"Hipparcos Number", "HIP 105377"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.15964112),
        dec: Angle.Degrees(-26.66571291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28452"},
        {"Hipparcos Number", "HIP 20858"},
        {"Smithsonian Astrophysical Observation", "SAO 169486"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.05038204),
        dec: Angle.Degrees(-26.66538653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217324"},
        {"Hipparcos Number", "HIP 113566"},
        {"Smithsonian Astrophysical Observation", "SAO 191557"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.03808093),
        dec: Angle.Degrees(-26.66475171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77361"},
        {"Hipparcos Number", "HIP 44290"},
        {"Geneva Identification System", "GEN# +1.00077361"},
        {"Smithsonian Astrophysical Observation", "SAO 176833"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.29751141),
        dec: Angle.Degrees(-26.66358657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41149"},
        {"Hipparcos Number", "HIP 28594"},
        {"Geneva Identification System", "GEN# +1.00041149"},
        {"Smithsonian Astrophysical Observation", "SAO 171159"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.53173454),
        dec: Angle.Degrees(-26.66241528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39945"},
        {"Hipparcos Number", "HIP 27935"},
        {"Fundamental Katalog 5th Edition", "FK5 4538"},
        {"Smithsonian Astrophysical Observation", "SAO 171001"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.66321608),
        dec: Angle.Degrees(-26.66037815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111575"},
        {"Hipparcos Number", "HIP 62669"},
        {"Geneva Identification System", "GEN# +1.00111575"},
        {"Smithsonian Astrophysical Observation", "SAO 181145"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.62223523),
        dec: Angle.Degrees(-26.65877819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216770"},
        {"Hipparcos Number", "HIP 113238"},
        {"Geneva Identification System", "GEN# +1.00216770"},
        {"Smithsonian Astrophysical Observation", "SAO 191502"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.97316853),
        dec: Angle.Degrees(-26.65833011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166504"},
        {"Hipparcos Number", "HIP 89180"},
    },
    visualMagnitude: 9.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.00504574),
        dec: Angle.Degrees(-26.65825295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117715"},
        {"Hipparcos Number", "HIP 66055"},
        {"Geneva Identification System", "GEN# +1.00117715"},
        {"Smithsonian Astrophysical Observation", "SAO 181734"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.13257948),
        dec: Angle.Degrees(-26.65773887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138359"},
        {"Hipparcos Number", "HIP 76099"},
        {"Smithsonian Astrophysical Observation", "SAO 183551"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.13168268),
        dec: Angle.Degrees(-26.65703187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54224"},
        {"Hipparcos Number", "HIP 34331"},
        {"Celescope Catalog", "CEL 1595"},
        {"Geneva Identification System", "GEN# +1.00054224"},
        {"Smithsonian Astrophysical Observation", "SAO 172989"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.74996075),
        dec: Angle.Degrees(-26.65676332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25982"},
        {"Hipparcos Number", "HIP 19113"},
        {"Smithsonian Astrophysical Observation", "SAO 169117"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47308107),
        dec: Angle.Degrees(-26.65672507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123479"},
        {"Hipparcos Number", "HIP 69094"},
        {"Smithsonian Astrophysical Observation", "SAO 182279"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.14057086),
        dec: Angle.Degrees(-26.65302486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114524"},
        {"Hipparcos Number", "HIP 64343"},
        {"Smithsonian Astrophysical Observation", "SAO 181443"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.83919108),
        dec: Angle.Degrees(-26.65212407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174630"},
        {"Hipparcos Number", "HIP 92635"},
        {"Geneva Identification System", "GEN# +1.00174630"},
        {"Smithsonian Astrophysical Observation", "SAO 187388"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11798729),
        dec: Angle.Degrees(-26.65062176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161273"},
        {"Hipparcos Number", "HIP 86924"},
        {"Smithsonian Astrophysical Observation", "SAO 185709"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.41764116),
        dec: Angle.Degrees(-26.65002582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6965 AB"},
        {"Henry Draper", "HD 74553"},
        {"Hipparcos Number", "HIP 42842"},
        {"Geneva Identification System", "GEN# +1.00074553"},
        {"Smithsonian Astrophysical Observation", "SAO 176368"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.94295851),
        dec: Angle.Degrees(-26.64959525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151012"},
        {"Hipparcos Number", "HIP 82069"},
        {"Geneva Identification System", "GEN# +1.00151012"},
        {"Smithsonian Astrophysical Observation", "SAO 184617"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45198023),
        dec: Angle.Degrees(-26.64933901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130274"},
        {"Hipparcos Number", "HIP 72378"},
        {"Geneva Identification System", "GEN# +1.00130274"},
        {"Smithsonian Astrophysical Observation", "SAO 182883"},
        {"Wilson Evans Batten Catalogue", "WEB 12443"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.98985195),
        dec: Angle.Degrees(-26.64613329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11992"},
        {"Hipparcos Number", "HIP 9100"},
        {"Smithsonian Astrophysical Observation", "SAO 167425"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.30545802),
        dec: Angle.Degrees(-26.64524400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196815"},
        {"Hipparcos Number", "HIP 102032"},
        {"Geneva Identification System", "GEN# +1.00196815"},
        {"Smithsonian Astrophysical Observation", "SAO 189559"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.14953066),
        dec: Angle.Degrees(-26.64508658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68374"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.93988331),
        dec: Angle.Degrees(-26.64444488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153567"},
        {"Hipparcos Number", "HIP 83296"},
        {"Smithsonian Astrophysical Observation", "SAO 184923"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.35120462),
        dec: Angle.Degrees(-26.64376205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223525"},
        {"Hipparcos Number", "HIP 117548"},
        {"Smithsonian Astrophysical Observation", "SAO 192190"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.58172338),
        dec: Angle.Degrees(-26.64253864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53398"},
        {"Hipparcos Number", "HIP 34054"},
        {"Smithsonian Astrophysical Observation", "SAO 172878"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.95995826),
        dec: Angle.Degrees(-26.64216366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177451"},
        {"Hipparcos Number", "HIP 93767"},
        {"Smithsonian Astrophysical Observation", "SAO 187662"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.43663916),
        dec: Angle.Degrees(-26.64197281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31864"},
        {"Smithsonian Astrophysical Observation", "SAO 172108"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.91307417),
        dec: Angle.Degrees(-26.64168398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13626"},
        {"Hipparcos Number", "HIP 10277"},
        {"Smithsonian Astrophysical Observation", "SAO 167631"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.07954835),
        dec: Angle.Degrees(-26.63987888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115309"},
        {"Hipparcos Number", "HIP 64784"},
        {"Smithsonian Astrophysical Observation", "SAO 181507"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.16740740),
        dec: Angle.Degrees(-26.63889576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24677"},
        {"Smithsonian Astrophysical Observation", "SAO 170285"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.41463300),
        dec: Angle.Degrees(-26.63794178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4720"},
        {"Geneva Identification System", "GEN# -0.02700323"},
        {"Smithsonian Astrophysical Observation", "SAO 166741"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.15439055),
        dec: Angle.Degrees(-26.63759808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208091"},
        {"Hipparcos Number", "HIP 108135"},
        {"Smithsonian Astrophysical Observation", "SAO 190723"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.61862845),
        dec: Angle.Degrees(-26.63538133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32530"},
        {"Hipparcos Number", "HIP 23468"},
        {"Geneva Identification System", "GEN# +1.00032530"},
        {"Smithsonian Astrophysical Observation", "SAO 170013"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68048487),
        dec: Angle.Degrees(-26.63492767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11354 AB"},
        {"Henry Draper", "HD 169851"},
        {"Hipparcos Number", "HIP 90478"},
        {"Geneva Identification System", "GEN# +1.00169851J"},
        {"Smithsonian Astrophysical Observation", "SAO 186837"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.93233601),
        dec: Angle.Degrees(-26.63475516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162907"},
        {"Hipparcos Number", "HIP 87679"},
        {"Geneva Identification System", "GEN# +1.00162907"},
        {"Smithsonian Astrophysical Observation", "SAO 185918"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.62531743),
        dec: Angle.Degrees(-26.63175431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143747"},
        {"Hipparcos Number", "HIP 78635"},
        {"Geneva Identification System", "GEN# +1.00143747"},
        {"Smithsonian Astrophysical Observation", "SAO 184062"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.79290898),
        dec: Angle.Degrees(-26.62974318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10436 AB"},
        {"Henry Draper", "HD 156252"},
        {"Hipparcos Number", "HIP 84605"},
        {"Geneva Identification System", "GEN# +1.00156252"},
        {"Smithsonian Astrophysical Observation", "SAO 185233"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.41471913),
        dec: Angle.Degrees(-26.62896579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162043"},
        {"Hipparcos Number", "HIP 87281"},
        {"Smithsonian Astrophysical Observation", "SAO 185816"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.52114135),
        dec: Angle.Degrees(-26.62872955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60862"},
        {"Hipparcos Number", "HIP 36934"},
        {"Smithsonian Astrophysical Observation", "SAO 174065"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.88994535),
        dec: Angle.Degrees(-26.62869383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3379",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 600 A"},
        {"Henry Draper", "HD 4073"},
        {"Hipparcos Number", "HIP 3379"},
        {"Smithsonian Astrophysical Observation", "SAO 166511"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.73863414),
        dec: Angle.Degrees(-26.62817696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38943"},
        {"Smithsonian Astrophysical Observation", "SAO 174890"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52099582),
        dec: Angle.Degrees(-26.62797870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74993"},
        {"Hipparcos Number", "HIP 43076"},
        {"Smithsonian Astrophysical Observation", "SAO 176451"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.61146812),
        dec: Angle.Degrees(-26.62777103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37146"},
        {"Smithsonian Astrophysical Observation", "SAO 174168"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.50283313),
        dec: Angle.Degrees(-26.62654366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198906"},
        {"Hipparcos Number", "HIP 103182"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.57719272),
        dec: Angle.Degrees(-26.62599124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224350"},
        {"Hipparcos Number", "HIP 118076"},
        {"Geneva Identification System", "GEN# +1.00224350"},
        {"Smithsonian Astrophysical Observation", "SAO 192262"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.28384615),
        dec: Angle.Degrees(-26.62349762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9415 AB"},
        {"Henry Draper", "HD 131073"},
        {"Hipparcos Number", "HIP 72733"},
        {"Smithsonian Astrophysical Observation", "SAO 182943"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.05599329),
        dec: Angle.Degrees(-26.62284272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21920"},
        {"Hipparcos Number", "HIP 16383"},
        {"Smithsonian Astrophysical Observation", "SAO 168603"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.75958969),
        dec: Angle.Degrees(-26.62100411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63599"},
        {"Hipparcos Number", "HIP 38125"},
        {"Geneva Identification System", "GEN# +1.00063599"},
        {"Smithsonian Astrophysical Observation", "SAO 174584"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.19092566),
        dec: Angle.Degrees(-26.61869607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23768"},
        {"Hipparcos Number", "HIP 17640"},
        {"Geneva Identification System", "GEN# +1.00023768"},
        {"Smithsonian Astrophysical Observation", "SAO 168828"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.69954113),
        dec: Angle.Degrees(-26.61853724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203119"},
        {"Hipparcos Number", "HIP 105396"},
        {"Smithsonian Astrophysical Observation", "SAO 190249"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.22151592),
        dec: Angle.Degrees(-26.61525876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73694"},
        {"Smithsonian Astrophysical Observation", "SAO 183134"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.94662514),
        dec: Angle.Degrees(-26.61438695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74946"},
        {"Henry Draper 2", "HD 74947"},
        {"Hipparcos Number", "HIP 43041"},
        {"Fundamental Katalog 5th Edition", "FK5 4786"},
        {"Smithsonian Astrophysical Observation", "SAO 176444"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.54201024),
        dec: Angle.Degrees(-26.61280174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124281"},
        {"Hipparcos Number", "HIP 69458"},
        {"Geneva Identification System", "GEN# +1.00124281"},
        {"Smithsonian Astrophysical Observation", "SAO 182354"},
        {"Wilson Evans Batten Catalogue", "WEB 12104"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30519927),
        dec: Angle.Degrees(-26.61226602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122996"},
        {"Hipparcos Number", "HIP 68834"},
        {"Geneva Identification System", "GEN# +1.00122996"},
        {"Smithsonian Astrophysical Observation", "SAO 182233"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.41463671),
        dec: Angle.Degrees(-26.61161328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21616"},
        {"Hipparcos Number", "HIP 16180"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.11052026),
        dec: Angle.Degrees(-26.61084209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53673"},
        {"Hipparcos Number", "HIP 34153"},
        {"Smithsonian Astrophysical Observation", "SAO 172917"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.22575093),
        dec: Angle.Degrees(-26.61079704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91416"},
        {"Hipparcos Number", "HIP 51631"},
        {"Smithsonian Astrophysical Observation", "SAO 178955"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.21361242),
        dec: Angle.Degrees(-26.60945373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26505"},
        {"Hipparcos Number", "HIP 19494"},
        {"Smithsonian Astrophysical Observation", "SAO 169194"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.64410709),
        dec: Angle.Degrees(-26.60833854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201149"},
        {"Hipparcos Number", "HIP 104360"},
        {"Smithsonian Astrophysical Observation", "SAO 190047"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.12339935),
        dec: Angle.Degrees(-26.60715293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20853"},
        {"Hipparcos Number", "HIP 15585"},
        {"Geneva Identification System", "GEN# +1.00020853"},
        {"Smithsonian Astrophysical Observation", "SAO 168475"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.18823634),
        dec: Angle.Degrees(-26.60656152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137887"},
        {"Hipparcos Number", "HIP 75834"},
        {"Smithsonian Astrophysical Observation", "SAO 183518"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.36003529),
        dec: Angle.Degrees(-26.60579095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172684"},
        {"Hipparcos Number", "HIP 91750"},
        {"Smithsonian Astrophysical Observation", "SAO 187162"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.64490608),
        dec: Angle.Degrees(-26.60418425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224145"},
        {"Hipparcos Number", "HIP 117959"},
        {"Smithsonian Astrophysical Observation", "SAO 192240"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.89656794),
        dec: Angle.Degrees(-26.60236561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24246"},
        {"Hipparcos Number", "HIP 17979"},
        {"Smithsonian Astrophysical Observation", "SAO 168882"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64837562),
        dec: Angle.Degrees(-26.60055737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84405",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Guniibuu"},
        {"Aitken", "ADS 10417 AB"},
        {"Hipparcos Number", "HIP 84405"},
        {"Geneva Identification System", "GEN# +1.00155886"},
    },
    visualMagnitude: 4.33,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.83869698),
        dec: Angle.Degrees(-26.60004896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -473.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1143.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51289"},
        {"Smithsonian Astrophysical Observation", "SAO 178862"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.15170459),
        dec: Angle.Degrees(-26.59956168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106788"},
        {"Hipparcos Number", "HIP 59884"},
        {"Smithsonian Astrophysical Observation", "SAO 180642"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.21537657),
        dec: Angle.Degrees(-26.59837689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87726"},
        {"Hipparcos Number", "HIP 49500"},
        {"Smithsonian Astrophysical Observation", "SAO 178414"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.60642162),
        dec: Angle.Degrees(-26.59794347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85819"},
        {"Hipparcos Number", "HIP 48529"},
        {"Smithsonian Astrophysical Observation", "SAO 178153"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.45997152),
        dec: Angle.Degrees(-26.59776280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127340"},
        {"Hipparcos Number", "HIP 71019"},
        {"Cincinnati Publication", "Ci 20 866"},
        {"Geneva Identification System", "GEN# +1.00127340"},
        {"Smithsonian Astrophysical Observation", "SAO 182631"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.87565837),
        dec: Angle.Degrees(-26.59752018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -446.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109073"},
        {"Hipparcos Number", "HIP 61171"},
        {"Smithsonian Astrophysical Observation", "SAO 180868"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01660444),
        dec: Angle.Degrees(-26.59643969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24713"},
        {"Hipparcos Number", "HIP 18302"},
        {"Smithsonian Astrophysical Observation", "SAO 168944"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.69860590),
        dec: Angle.Degrees(-26.59611884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98347"},
        {"Hipparcos Number", "HIP 55221"},
        {"Smithsonian Astrophysical Observation", "SAO 179758"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.62825785),
        dec: Angle.Degrees(-26.59571747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105004"},
        {"Hipparcos Number", "HIP 58962"},
        {"Geneva Identification System", "GEN# +1.00105004"},
        {"Smithsonian Astrophysical Observation", "SAO 180445"},
        {"Wilson Evans Batten Catalogue", "WEB 10499"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.35433196),
        dec: Angle.Degrees(-26.59482334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
