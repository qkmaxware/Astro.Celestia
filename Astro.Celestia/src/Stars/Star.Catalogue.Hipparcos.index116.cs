using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_116() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90696"},
        {"Hipparcos Number", "HIP 51521"},
        {"Smithsonian Astrophysical Observation", "SAO 7154"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.84247692),
        dec: Angle.Degrees(+73.33081649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35197"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.10309473),
        dec: Angle.Degrees(+73.33251519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125405"},
        {"Hipparcos Number", "HIP 69634"},
        {"Fundamental Katalog 5th Edition", "FK5 5259"},
        {"Smithsonian Astrophysical Observation", "SAO 7972"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.77643059),
        dec: Angle.Degrees(+73.33366154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68744"},
        {"Hipparcos Number", "HIP 40841"},
        {"Cincinnati Publication", "Ci 18 973"},
        {"Geneva Identification System", "GEN# +1.00068744"},
        {"Smithsonian Astrophysical Observation", "SAO 6494"},
        {"Wilson Evans Batten Catalogue", "WEB 7921"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.01161493),
        dec: Angle.Degrees(+73.33675998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13685"},
        {"Hipparcos Number", "HIP 10691"},
        {"Smithsonian Astrophysical Observation", "SAO 4611"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.39590927),
        dec: Angle.Degrees(+73.34013707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114374"},
        {"Hipparcos Number", "HIP 64090"},
        {"Smithsonian Astrophysical Observation", "SAO 7755"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.01087961),
        dec: Angle.Degrees(+73.34324636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21610"},
        {"Hipparcos Number", "HIP 16725"},
        {"Fundamental Katalog 5th Edition", "FK5 2251"},
        {"Geneva Identification System", "GEN# +1.00021610"},
        {"Smithsonian Astrophysical Observation", "SAO 4936"},
        {"Wilson Evans Batten Catalogue", "WEB 3185"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.80122561),
        dec: Angle.Degrees(+73.34698742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69303"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.77298892),
        dec: Angle.Degrees(+73.34732383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181984"},
        {"Hipparcos Number", "HIP 94648"},
        {"Fundamental Katalog 5th Edition", "FK5 729"},
        {"Geneva Identification System", "GEN# +1.00181984"},
        {"Smithsonian Astrophysical Observation", "SAO 9366"},
        {"Wilson Evans Batten Catalogue", "WEB 16501"},
    },
    visualMagnitude: 4.45,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88872380),
        dec: Angle.Degrees(+73.35521457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4923"},
        {"Smithsonian Astrophysical Observation", "SAO 4306"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.79840417),
        dec: Angle.Degrees(+73.35712801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71246"},
        {"Smithsonian Astrophysical Observation", "SAO 8050"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.55447607),
        dec: Angle.Degrees(+73.35746992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95625",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12524 AB"},
        {"Henry Draper", "HD 184292"},
        {"Hipparcos Number", "HIP 95625"},
        {"Smithsonian Astrophysical Observation", "SAO 9428"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.74781783),
        dec: Angle.Degrees(+73.36629176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24319"},
        {"Hipparcos Number", "HIP 18568"},
        {"Smithsonian Astrophysical Observation", "SAO 5047"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.62987879),
        dec: Angle.Degrees(+73.36961790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222840"},
        {"Hipparcos Number", "HIP 117046"},
        {"Smithsonian Astrophysical Observation", "SAO 10844"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.91447470),
        dec: Angle.Degrees(+73.37039084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2426"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.72954364),
        dec: Angle.Degrees(+73.37047110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17696"},
        {"Hipparcos Number", "HIP 13621"},
        {"Smithsonian Astrophysical Observation", "SAO 4763"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86753146),
        dec: Angle.Degrees(+73.37115710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178944"},
        {"Hipparcos Number", "HIP 93573"},
        {"Geneva Identification System", "GEN# +1.00178944"},
        {"Smithsonian Astrophysical Observation", "SAO 9314"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.87267742),
        dec: Angle.Degrees(+73.37907395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1036 AB"},
        {"Henry Draper", "HD 7610"},
        {"Hipparcos Number", "HIP 6114"},
        {"Smithsonian Astrophysical Observation", "SAO 4370"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.62437256),
        dec: Angle.Degrees(+73.38399484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210806"},
        {"Hipparcos Number", "HIP 109389"},
        {"Geneva Identification System", "GEN# +1.00210806"},
        {"Smithsonian Astrophysical Observation", "SAO 10264"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.41715201),
        dec: Angle.Degrees(+73.39089174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1131"},
        {"Fundamental Katalog 5th Edition", "FK5 4025"},
        {"Smithsonian Astrophysical Observation", "SAO 4063"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.52493003),
        dec: Angle.Degrees(+73.39091650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100532"},
        {"Hipparcos Number", "HIP 56499"},
        {"Geneva Identification System", "GEN# +1.00100532"},
        {"Smithsonian Astrophysical Observation", "SAO 7381"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.74290187),
        dec: Angle.Degrees(+73.39303776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147321"},
        {"Hipparcos Number", "HIP 79601"},
        {"Fundamental Katalog 5th Edition", "FK5 3289"},
        {"Geneva Identification System", "GEN# +1.00147321"},
        {"Smithsonian Astrophysical Observation", "SAO 8462"},
        {"Wilson Evans Batten Catalogue", "WEB 13470"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.63944201),
        dec: Angle.Degrees(+73.39480814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49308"},
        {"Hipparcos Number", "HIP 33244"},
        {"Smithsonian Astrophysical Observation", "SAO 6002"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.75719318),
        dec: Angle.Degrees(+73.39605467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122727"},
        {"Hipparcos Number", "HIP 68382"},
        {"Geneva Identification System", "GEN# +1.00122727"},
        {"Smithsonian Astrophysical Observation", "SAO 7924"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.96179234),
        dec: Angle.Degrees(+73.39819745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22500"},
        {"Hipparcos Number", "HIP 17374"},
        {"Geneva Identification System", "GEN# +1.00022500"},
        {"Smithsonian Astrophysical Observation", "SAO 4966"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.80012471),
        dec: Angle.Degrees(+73.40006013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45042"},
        {"Geneva Identification System", "GEN# +0.07300447"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.61491698),
        dec: Angle.Degrees(+73.40733614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68788"},
        {"Hipparcos Number", "HIP 40848"},
        {"Cincinnati Publication", "Ci 18 974"},
        {"Cincinnati Publication 2", "Ci 20 467"},
        {"Geneva Identification System", "GEN# +1.00068788"},
        {"Smithsonian Astrophysical Observation", "SAO 6497"},
        {"Wilson Evans Batten Catalogue", "WEB 7922"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.02257975),
        dec: Angle.Degrees(+73.41637353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -312.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -487.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133430"},
        {"Hipparcos Number", "HIP 73330"},
        {"Geneva Identification System", "GEN# +1.00133430"},
        {"Smithsonian Astrophysical Observation", "SAO 8136"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.77497055),
        dec: Angle.Degrees(+73.42572156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11958"},
        {"Hipparcos Number", "HIP 9419"},
        {"Geneva Identification System", "GEN# +1.00011958"},
        {"Smithsonian Astrophysical Observation", "SAO 4544"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.25432649),
        dec: Angle.Degrees(+73.42646029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51396"},
        {"Hipparcos Number", "HIP 34124"},
        {"Geneva Identification System", "GEN# +1.00051396"},
        {"Smithsonian Astrophysical Observation", "SAO 6059"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.13725916),
        dec: Angle.Degrees(+73.42790716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202948"},
        {"Hipparcos Number", "HIP 104849"},
        {"Smithsonian Astrophysical Observation", "SAO 9999"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.58983052),
        dec: Angle.Degrees(+73.43250217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43810"},
        {"Hipparcos Number", "HIP 30597"},
        {"Smithsonian Astrophysical Observation", "SAO 5835"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.45167866),
        dec: Angle.Degrees(+73.43506637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104986"},
        {"Hipparcos Number", "HIP 58947"},
        {"Smithsonian Astrophysical Observation", "SAO 7499"},
        {"Wilson Evans Batten Catalogue", "WEB 10497"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.30141693),
        dec: Angle.Degrees(+73.45448306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191762"},
        {"Hipparcos Number", "HIP 98932"},
        {"Smithsonian Astrophysical Observation", "SAO 9638"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32252187),
        dec: Angle.Degrees(+73.45743694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162130"},
        {"Hipparcos Number", "HIP 86630"},
        {"Smithsonian Astrophysical Observation", "SAO 8893"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.51592996),
        dec: Angle.Degrees(+73.46166046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8100 B"},
        {"Hipparcos Number", "HIP 54976"},
        {"Geneva Identification System", "GEN# +1.20097584"},
        {"Smithsonian Astrophysical Observation", "SAO 7321"},
        {"Wilson Evans Batten Catalogue", "WEB 9922"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.85742589),
        dec: Angle.Degrees(+73.47131423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8314"},
        {"Geneva Identification System", "GEN# +0.07200094"},
        {"Wilson Evans Batten Catalogue", "WEB 1773"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.80337780),
        dec: Angle.Degrees(+73.47382233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8100 A"},
        {"Henry Draper", "HD 97584"},
        {"Henry Draper 2", "HD 97584A"},
        {"Hipparcos Number", "HIP 54952"},
        {"Cincinnati Publication", "Ci 20 620"},
        {"Geneva Identification System", "GEN# +1.10097584"},
        {"Geneva Identification System 2", "GEN# +1.00097584"},
        {"Smithsonian Astrophysical Observation", "SAO 7320"},
        {"Wilson Evans Batten Catalogue", "WEB 9918"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.80304208),
        dec: Angle.Degrees(+73.47493336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -403.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137686"},
        {"Hipparcos Number", "HIP 75152"},
        {"Geneva Identification System", "GEN# +1.00137686"},
        {"Smithsonian Astrophysical Observation", "SAO 8227"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.37717629),
        dec: Angle.Degrees(+73.47640441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109096"},
        {"Hipparcos Number", "HIP 61092"},
        {"Smithsonian Astrophysical Observation", "SAO 7577"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.81336224),
        dec: Angle.Degrees(+73.47725020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205409"},
        {"Hipparcos Number", "HIP 106201"},
        {"Smithsonian Astrophysical Observation", "SAO 10070"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.67045478),
        dec: Angle.Degrees(+73.47749316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71703"},
        {"Hipparcos Number", "HIP 42103"},
        {"Smithsonian Astrophysical Observation", "SAO 6579"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.72916997),
        dec: Angle.Degrees(+73.48026114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9363"},
        {"Hipparcos Number", "HIP 7377"},
        {"Smithsonian Astrophysical Observation", "SAO 4437"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.76581387),
        dec: Angle.Degrees(+73.48185648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89742"},
        {"Hipparcos Number", "HIP 50961"},
        {"Geneva Identification System", "GEN# +1.00089742"},
        {"Smithsonian Astrophysical Observation", "SAO 7130"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.13562382),
        dec: Angle.Degrees(+73.48883202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44725"},
        {"Smithsonian Astrophysical Observation", "SAO 6743"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.69936014),
        dec: Angle.Degrees(+73.48921711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84915"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)21, 12.1800),
        dec: Angle.DegreesMinutesSeconds((int)+73, (int)29, 21.600)
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
    primaryId: "HIP 24329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24329"},
        {"Smithsonian Astrophysical Observation", "SAO 5459"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.31783880),
        dec: Angle.Degrees(+73.49107057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85854"},
        {"Hipparcos Number", "HIP 48910"},
        {"Geneva Identification System", "GEN# +1.00085854"},
        {"Smithsonian Astrophysical Observation", "SAO 7010"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.65663982),
        dec: Angle.Degrees(+73.49835382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14487"},
        {"Hipparcos Number", "HIP 11243"},
        {"Smithsonian Astrophysical Observation", "SAO 4643"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.17574860),
        dec: Angle.Degrees(+73.49843135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34730"},
        {"Hipparcos Number", "HIP 25495"},
        {"Smithsonian Astrophysical Observation", "SAO 5529"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.78895221),
        dec: Angle.Degrees(+73.51161847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80466"},
        {"Smithsonian Astrophysical Observation", "SAO 8517"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.36814339),
        dec: Angle.Degrees(+73.52093116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26891"},
        {"Smithsonian Astrophysical Observation", "SAO 5618"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.63528116),
        dec: Angle.Degrees(+73.52355685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186405"},
        {"Hipparcos Number", "HIP 96526"},
        {"Smithsonian Astrophysical Observation", "SAO 9485"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.35630419),
        dec: Angle.Degrees(+73.52479105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131233"},
        {"Hipparcos Number", "HIP 72314"},
        {"Smithsonian Astrophysical Observation", "SAO 8083"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.82322200),
        dec: Angle.Degrees(+73.52820484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29597"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.55865701),
        dec: Angle.Degrees(+73.53008247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108466"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.59770801),
        dec: Angle.Degrees(+73.53481636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 172.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182689"},
        {"Hipparcos Number", "HIP 94921"},
        {"Geneva Identification System", "GEN# +1.00182689"},
        {"Smithsonian Astrophysical Observation", "SAO 9390"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.73323743),
        dec: Angle.Degrees(+73.55074472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35557"},
        {"Fundamental Katalog 5th Edition", "FK5 4661"},
        {"Smithsonian Astrophysical Observation", "SAO 6149"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.05717433),
        dec: Angle.Degrees(+73.55540763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44208"},
        {"Hipparcos Number", "HIP 30791"},
        {"Smithsonian Astrophysical Observation", "SAO 5856"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.04767119),
        dec: Angle.Degrees(+73.55700042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65732"},
        {"Hipparcos Number", "HIP 39689"},
        {"Smithsonian Astrophysical Observation", "SAO 6417"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.66721535),
        dec: Angle.Degrees(+73.56656737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4726"},
        {"Hipparcos Number", "HIP 3966"},
        {"Smithsonian Astrophysical Observation", "SAO 4248"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.74028981),
        dec: Angle.Degrees(+73.56732296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49154"},
        {"Smithsonian Astrophysical Observation", "SAO 7032"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.48543895),
        dec: Angle.Degrees(+73.56866447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25473"},
        {"Hipparcos Number", "HIP 19402"},
        {"Geneva Identification System", "GEN# +1.00025473"},
        {"Smithsonian Astrophysical Observation", "SAO 5104"},
        {"Wilson Evans Batten Catalogue", "WEB 3725"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34344501),
        dec: Angle.Degrees(+73.57031765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213208"},
        {"Hipparcos Number", "HIP 110801"},
        {"Smithsonian Astrophysical Observation", "SAO 10373"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.72455204),
        dec: Angle.Degrees(+73.57477838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16646"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.55144734),
        dec: Angle.Degrees(+73.57548098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26905"},
        {"Hipparcos Number", "HIP 20392"},
        {"Smithsonian Astrophysical Observation", "SAO 5174"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.49803246),
        dec: Angle.Degrees(+73.58693144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15962"},
        {"Hipparcos Number", "HIP 12315"},
        {"Smithsonian Astrophysical Observation", "SAO 4696"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.64606766),
        dec: Angle.Degrees(+73.58731422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71387"},
        {"Hipparcos Number", "HIP 41971"},
        {"Geneva Identification System", "GEN# +1.00071387"},
        {"Smithsonian Astrophysical Observation", "SAO 6571"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.33436589),
        dec: Angle.Degrees(+73.58801484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4646"},
        {"Hipparcos Number", "HIP 3902"},
        {"Smithsonian Astrophysical Observation", "SAO 4242"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.51378898),
        dec: Angle.Degrees(+73.58842500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23891",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3658 AB"},
        {"Henry Draper", "HD 32086"},
        {"Hipparcos Number", "HIP 23891"},
        {"Renson", "Renson 8180"},
        {"Smithsonian Astrophysical Observation", "SAO 5428"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.01318254),
        dec: Angle.Degrees(+73.59147832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59762"},
        {"Hipparcos Number", "HIP 37205"},
        {"Geneva Identification System", "GEN# +1.00059762"},
        {"Smithsonian Astrophysical Observation", "SAO 6259"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.64017372),
        dec: Angle.Degrees(+73.59595624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213000"},
        {"Hipparcos Number", "HIP 110679"},
        {"Geneva Identification System", "GEN# +1.00213000"},
        {"Smithsonian Astrophysical Observation", "SAO 10360"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.33793238),
        dec: Angle.Degrees(+73.60299620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211771"},
        {"Hipparcos Number", "HIP 109962"},
        {"Geneva Identification System", "GEN# +1.00211771"},
        {"Smithsonian Astrophysical Observation", "SAO 10299"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.07462297),
        dec: Angle.Degrees(+73.60451482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112685"},
        {"Smithsonian Astrophysical Observation", "SAO 10509"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.28371424),
        dec: Angle.Degrees(+73.60759937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224890"},
        {"Hipparcos Number", "HIP 128"},
        {"Fundamental Katalog 5th Edition", "FK5 3930"},
        {"Geneva Identification System", "GEN# +1.00224890"},
        {"Renson", "Renson 61660"},
        {"Smithsonian Astrophysical Observation", "SAO 10934"},
        {"Wilson Evans Batten Catalogue", "WEB 17"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.41376473),
        dec: Angle.Degrees(+73.61187664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190020"},
        {"Hipparcos Number", "HIP 98118"},
        {"Smithsonian Astrophysical Observation", "SAO 9579"},
        {"Wilson Evans Batten Catalogue", "WEB 17294"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.11995099),
        dec: Angle.Degrees(+73.61599069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72582"},
        {"Hipparcos Number", "HIP 42484"},
        {"Fundamental Katalog 5th Edition", "FK5 322"},
        {"Geneva Identification System", "GEN# +1.00072582"},
        {"Smithsonian Astrophysical Observation", "SAO 6605"},
        {"Wilson Evans Batten Catalogue", "WEB 8172"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.92765434),
        dec: Angle.Degrees(+73.62991882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95417"},
        {"Hipparcos Number", "HIP 54008"},
        {"Smithsonian Astrophysical Observation", "SAO 7269"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.72975238),
        dec: Angle.Degrees(+73.63316155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1414"},
        {"Renson", "Renson 275"},
        {"Smithsonian Astrophysical Observation", "SAO 4076"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.42279017),
        dec: Angle.Degrees(+73.63756435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214470"},
        {"Hipparcos Number", "HIP 111532"},
        {"Fundamental Katalog 5th Edition", "FK5 851"},
        {"Geneva Identification System", "GEN# +1.00214470"},
        {"Smithsonian Astrophysical Observation", "SAO 10425"},
        {"Wilson Evans Batten Catalogue", "WEB 19935"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94073618),
        dec: Angle.Degrees(+73.64312707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21741"},
        {"Hipparcos Number", "HIP 16832"},
        {"Smithsonian Astrophysical Observation", "SAO 4943"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.13972424),
        dec: Angle.Degrees(+73.66184345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205479"},
        {"Hipparcos Number", "HIP 106244"},
        {"Smithsonian Astrophysical Observation", "SAO 10072"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.79002395),
        dec: Angle.Degrees(+73.66278773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204790"},
        {"Hipparcos Number", "HIP 105855"},
        {"Smithsonian Astrophysical Observation", "SAO 10049"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.59715774),
        dec: Angle.Degrees(+73.66506577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83678"},
        {"Smithsonian Astrophysical Observation", "SAO 8712"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54296863),
        dec: Angle.Degrees(+73.67084103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32450"},
        {"Smithsonian Astrophysical Observation", "SAO 5958"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58719307),
        dec: Angle.Degrees(+73.67914878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219889"},
        {"Hipparcos Number", "HIP 115039"},
        {"Smithsonian Astrophysical Observation", "SAO 10686"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.48743247),
        dec: Angle.Degrees(+73.68854106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27634"},
        {"Hipparcos Number", "HIP 20881"},
        {"Smithsonian Astrophysical Observation", "SAO 5205"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.12559205),
        dec: Angle.Degrees(+73.69349512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45947"},
        {"Hipparcos Number", "HIP 31703"},
        {"Fundamental Katalog 5th Edition", "FK5 2503"},
        {"Geneva Identification System", "GEN# +1.00045947"},
        {"Smithsonian Astrophysical Observation", "SAO 5909"},
        {"Wilson Evans Batten Catalogue", "WEB 6355"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.48017707),
        dec: Angle.Degrees(+73.69562922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202123"},
        {"Hipparcos Number", "HIP 104375"},
        {"Cincinnati Publication", "Ci 18 2753"},
        {"Cincinnati Publication 2", "Ci 20 1268"},
        {"Geneva Identification System", "GEN# +1.00202123"},
        {"Smithsonian Astrophysical Observation", "SAO 9971"},
        {"Wilson Evans Batten Catalogue", "WEB 19005"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.17220695),
        dec: Angle.Degrees(+73.69777798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -322.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -399.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81857"},
        {"Smithsonian Astrophysical Observation", "SAO 8607"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.78089766),
        dec: Angle.Degrees(+73.69791405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20255"},
        {"Hipparcos Number", "HIP 15615"},
        {"Smithsonian Astrophysical Observation", "SAO 4884"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.26370897),
        dec: Angle.Degrees(+73.69915669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208509"},
        {"Hipparcos Number", "HIP 107995"},
        {"Fundamental Katalog 5th Edition", "FK5 1578"},
        {"Geneva Identification System", "GEN# +1.00208509"},
        {"Smithsonian Astrophysical Observation", "SAO 10186"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.19524614),
        dec: Angle.Degrees(+73.70221638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34450"},
        {"Hipparcos Number", "HIP 25322"},
        {"Smithsonian Astrophysical Observation", "SAO 5517"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.24763705),
        dec: Angle.Degrees(+73.70720010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7748"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.93923850),
        dec: Angle.Degrees(+73.70925656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40489"},
        {"Smithsonian Astrophysical Observation", "SAO 6469"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.00172005),
        dec: Angle.Degrees(+73.71119676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14836"},
        {"Hipparcos Number", "HIP 11467"},
        {"Geneva Identification System", "GEN# +1.00014836"},
        {"Smithsonian Astrophysical Observation", "SAO 4649"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.97798920),
        dec: Angle.Degrees(+73.71274374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28942"},
        {"Smithsonian Astrophysical Observation", "SAO 5740"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.62521394),
        dec: Angle.Degrees(+73.72378721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106126"},
        {"Hipparcos Number", "HIP 59523"},
        {"Smithsonian Astrophysical Observation", "SAO 7523"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10080608),
        dec: Angle.Degrees(+73.72446981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8822"},
        {"Hipparcos Number", "HIP 6977"},
        {"Smithsonian Astrophysical Observation", "SAO 4412"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.45710068),
        dec: Angle.Degrees(+73.73784557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25121"},
        {"Hipparcos Number", "HIP 19138"},
        {"Smithsonian Astrophysical Observation", "SAO 5084"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.53292518),
        dec: Angle.Degrees(+73.74708769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74653"},
        {"Hipparcos Number", "HIP 43451"},
        {"Smithsonian Astrophysical Observation", "SAO 6661"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.75125604),
        dec: Angle.Degrees(+73.75209789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57994",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8337 ABC"},
        {"Henry Draper", "HD 103246"},
        {"Hipparcos Number", "HIP 57994"},
        {"Smithsonian Astrophysical Observation", "SAO 7445"},
        {"Wilson Evans Batten Catalogue", "WEB 10386"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.42992176),
        dec: Angle.Degrees(+73.75635119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31563"},
        {"Hipparcos Number", "HIP 23582"},
        {"Smithsonian Astrophysical Observation", "SAO 5403"},
        {"Wilson Evans Batten Catalogue", "WEB 4593"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.05319837),
        dec: Angle.Degrees(+73.76393288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171565"},
        {"Hipparcos Number", "HIP 90502"},
        {"Smithsonian Astrophysical Observation", "SAO 9136"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.01797070),
        dec: Angle.Degrees(+73.76962568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13474"},
        {"Smithsonian Astrophysical Observation", "SAO 4752"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39477689),
        dec: Angle.Degrees(+73.77119185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92148"},
        {"Hipparcos Number", "HIP 52290"},
        {"Geneva Identification System", "GEN# +1.00092148"},
        {"Smithsonian Astrophysical Observation", "SAO 7186"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.26526449),
        dec: Angle.Degrees(+73.77178144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90759"},
        {"Hipparcos Number", "HIP 51552"},
        {"Fundamental Katalog 5th Edition", "FK5 4933"},
        {"Geneva Identification System", "GEN# +1.00090759"},
        {"Smithsonian Astrophysical Observation", "SAO 7156"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.95328159),
        dec: Angle.Degrees(+73.78046688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103885"},
        {"Hipparcos Number", "HIP 58353"},
        {"Smithsonian Astrophysical Observation", "SAO 7465"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49952703),
        dec: Angle.Degrees(+73.78173324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100426"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.47195746),
        dec: Angle.Degrees(+73.78533604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90006"},
        {"Hipparcos Number", "HIP 51111"},
        {"Smithsonian Astrophysical Observation", "SAO 7139"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.63842221),
        dec: Angle.Degrees(+73.78770267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101940"},
        {"Smithsonian Astrophysical Observation", "SAO 9842"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.86377587),
        dec: Angle.Degrees(+73.80922459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14381"},
        {"Hipparcos Number", "HIP 11165"},
        {"Smithsonian Astrophysical Observation", "SAO 4637"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.92091043),
        dec: Angle.Degrees(+73.81016341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73902"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.55803373),
        dec: Angle.Degrees(+73.82111074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209886"},
        {"Hipparcos Number", "HIP 108826"},
        {"Smithsonian Astrophysical Observation", "SAO 10236"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70123320),
        dec: Angle.Degrees(+73.82483573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181873"},
        {"Hipparcos Number", "HIP 94594"},
        {"Smithsonian Astrophysical Observation", "SAO 9362"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.75382072),
        dec: Angle.Degrees(+73.82931112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7824 A"},
        {"Henry Draper", "HD 91114"},
        {"Hipparcos Number", "HIP 51734"},
        {"Geneva Identification System", "GEN# +1.00091114"},
        {"Smithsonian Astrophysical Observation", "SAO 7161"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.55618444),
        dec: Angle.Degrees(+73.83453199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142005"},
        {"Hipparcos Number", "HIP 77176"},
        {"Smithsonian Astrophysical Observation", "SAO 8331"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.37112638),
        dec: Angle.Degrees(+73.83579663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7824 B"},
        {"Hipparcos Number", "HIP 51727"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.53436112),
        dec: Angle.Degrees(+73.83682061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23016"},
        {"Smithsonian Astrophysical Observation", "SAO 5356"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24981629),
        dec: Angle.Degrees(+73.83995259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1606 A"},
        {"Henry Draper", "HD 12173"},
        {"Hipparcos Number", "HIP 9586"},
        {"Renson", "Renson 3100"},
        {"Smithsonian Astrophysical Observation", "SAO 4559"},
        {"Wilson Evans Batten Catalogue", "WEB 2012"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.79378002),
        dec: Angle.Degrees(+73.85056527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56842"},
        {"Hipparcos Number", "HIP 36069"},
        {"Smithsonian Astrophysical Observation", "SAO 6180"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48445043),
        dec: Angle.Degrees(+73.85086426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64349"},
        {"Cincinnati Publication", "Ci 18 1702"},
        {"Geneva Identification System", "GEN# +0.07400526"},
        {"Smithsonian Astrophysical Observation", "SAO 7771"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.85085830),
        dec: Angle.Degrees(+73.85581881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224414"},
        {"Hipparcos Number", "HIP 118117"},
        {"Geneva Identification System", "GEN# +1.00224414"},
        {"Smithsonian Astrophysical Observation", "SAO 10911"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39194231),
        dec: Angle.Degrees(+73.86587307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19615"},
        {"Hipparcos Number", "HIP 15135"},
        {"Smithsonian Astrophysical Observation", "SAO 4858"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.78149623),
        dec: Angle.Degrees(+73.86821795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101239"},
        {"Hipparcos Number", "HIP 56906"},
        {"Smithsonian Astrophysical Observation", "SAO 7410"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.97583967),
        dec: Angle.Degrees(+73.87119270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79253"},
        {"Smithsonian Astrophysical Observation", "SAO 8444"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.62324464),
        dec: Angle.Degrees(+73.88462042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151746"},
        {"Hipparcos Number", "HIP 81757"},
        {"Renson", "Renson 42934"},
        {"Smithsonian Astrophysical Observation", "SAO 8602"},
        {"Wilson Evans Batten Catalogue", "WEB 13819"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.48840912),
        dec: Angle.Degrees(+73.88729450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134584"},
        {"Hipparcos Number", "HIP 73808"},
        {"Smithsonian Astrophysical Observation", "SAO 8160"},
        {"Wilson Evans Batten Catalogue", "WEB 12612"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.28039187),
        dec: Angle.Degrees(+73.89179100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181204"},
        {"Hipparcos Number", "HIP 94361"},
        {"Smithsonian Astrophysical Observation", "SAO 9351"},
        {"Wilson Evans Batten Catalogue", "WEB 16441"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.09421713),
        dec: Angle.Degrees(+73.89231423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87850"},
        {"Hipparcos Number", "HIP 49915"},
        {"Smithsonian Astrophysical Observation", "SAO 7069"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.87590221),
        dec: Angle.Degrees(+73.89278787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95628"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.75119723),
        dec: Angle.Degrees(+73.89673169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23309"},
        {"Hipparcos Number", "HIP 17985"},
        {"Smithsonian Astrophysical Observation", "SAO 5004"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.66116128),
        dec: Angle.Degrees(+73.90843435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191632"},
        {"Hipparcos Number", "HIP 98853"},
        {"Fundamental Katalog 5th Edition", "FK5 3614"},
        {"Geneva Identification System", "GEN# +1.00191632"},
        {"Smithsonian Astrophysical Observation", "SAO 9631"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11134592),
        dec: Angle.Degrees(+73.90940954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4957 AB"},
        {"Henry Draper", "HD 43494"},
        {"Hipparcos Number", "HIP 30462"},
        {"Smithsonian Astrophysical Observation", "SAO 5828"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.05239566),
        dec: Angle.Degrees(+73.91580878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120815"},
        {"Hipparcos Number", "HIP 67352"},
        {"Smithsonian Astrophysical Observation", "SAO 7884"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.05962428),
        dec: Angle.Degrees(+73.91794134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64307"},
        {"Hipparcos Number", "HIP 39117"},
        {"Fundamental Katalog 5th Edition", "FK5 300"},
        {"Geneva Identification System", "GEN# +1.00064307"},
        {"Smithsonian Astrophysical Observation", "SAO 6378"},
        {"Wilson Evans Batten Catalogue", "WEB 7672"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.04898399),
        dec: Angle.Degrees(+73.91801010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26716"},
        {"Hipparcos Number", "HIP 20254"},
        {"Smithsonian Astrophysical Observation", "SAO 5160"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.10288967),
        dec: Angle.Degrees(+73.91803960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7071"},
        {"Hipparcos Number", "HIP 5707"},
        {"Geneva Identification System", "GEN# +1.00007071"},
        {"Smithsonian Astrophysical Observation", "SAO 4347"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.35306235),
        dec: Angle.Degrees(+73.92068926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217540"},
        {"Hipparcos Number", "HIP 113518"},
        {"Smithsonian Astrophysical Observation", "SAO 10577"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.85673215),
        dec: Angle.Degrees(+73.92359230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115165",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16683 A"},
        {"Henry Draper", "HD 220086"},
        {"Hipparcos Number", "HIP 115165"},
        {"Geneva Identification System", "GEN# +1.00220086"},
        {"Smithsonian Astrophysical Observation", "SAO 10696"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91843649),
        dec: Angle.Degrees(+73.92440312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144652"},
        {"Hipparcos Number", "HIP 78392"},
        {"Smithsonian Astrophysical Observation", "SAO 8392"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06514819),
        dec: Angle.Degrees(+73.93555504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18639"},
        {"Hipparcos Number", "HIP 14369"},
        {"Smithsonian Astrophysical Observation", "SAO 4811"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34591247),
        dec: Angle.Degrees(+73.94512951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32650"},
        {"Hipparcos Number", "HIP 24254"},
        {"Fundamental Katalog 5th Edition", "FK5 2387"},
        {"Geneva Identification System", "GEN# +1.00032650"},
        {"Renson", "Renson 8350"},
        {"Smithsonian Astrophysical Observation", "SAO 5455"},
        {"Wilson Evans Batten Catalogue", "WEB 4707"},
    },
    visualMagnitude: 5.44,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.09353950),
        dec: Angle.Degrees(+73.94674435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138197"},
        {"Hipparcos Number", "HIP 75402"},
        {"Smithsonian Astrophysical Observation", "SAO 8244"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.09650648),
        dec: Angle.Degrees(+73.94886589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105618"},
        {"Smithsonian Astrophysical Observation", "SAO 10039"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.87685154),
        dec: Angle.Degrees(+73.95419897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81547"},
        {"Hipparcos Number", "HIP 46693"},
        {"Smithsonian Astrophysical Observation", "SAO 6880"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.78377211),
        dec: Angle.Degrees(+73.95827526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64251"},
        {"Smithsonian Astrophysical Observation", "SAO 7765"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.54072011),
        dec: Angle.Degrees(+73.96099898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8825"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.36592629),
        dec: Angle.Degrees(+73.96371147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 545.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27807"},
        {"Hipparcos Number", "HIP 21018"},
        {"Smithsonian Astrophysical Observation", "SAO 5216"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.61019967),
        dec: Angle.Degrees(+73.96555924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114743"},
        {"Hipparcos Number", "HIP 64252"},
        {"Smithsonian Astrophysical Observation", "SAO 7766"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.54141917),
        dec: Angle.Degrees(+73.96875513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221186"},
        {"Hipparcos Number", "HIP 115903"},
        {"Smithsonian Astrophysical Observation", "SAO 10753"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.24504157),
        dec: Angle.Degrees(+73.97965577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26940",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4246 AB"},
        {"Henry Draper", "HD 36971"},
        {"Hipparcos Number", "HIP 26940"},
        {"Geneva Identification System", "GEN# +1.00040469J"},
        {"Smithsonian Astrophysical Observation", "SAO 5620"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75313207),
        dec: Angle.Degrees(+73.98576860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5580"},
        {"Hipparcos Number", "HIP 4636"},
        {"Fundamental Katalog 5th Edition", "FK5 4091"},
        {"Smithsonian Astrophysical Observation", "SAO 4282"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.87721077),
        dec: Angle.Degrees(+73.98768208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61690"},
        {"Hipparcos Number", "HIP 38033"},
        {"Geneva Identification System", "GEN# +1.00061690"},
        {"Smithsonian Astrophysical Observation", "SAO 6306"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.91499152),
        dec: Angle.Degrees(+73.99183441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4603 AB"},
        {"Henry Draper", "HD 40225"},
        {"Hipparcos Number", "HIP 28842"},
        {"Smithsonian Astrophysical Observation", "SAO 5732"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.31663367),
        dec: Angle.Degrees(+73.99970649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75696"},
        {"Hipparcos Number", "HIP 43960"},
        {"Geneva Identification System", "GEN# +1.00075696"},
        {"Smithsonian Astrophysical Observation", "SAO 6689"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28837637),
        dec: Angle.Degrees(+73.99996692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25225"},
        {"Hipparcos Number", "HIP 19222"},
        {"Fundamental Katalog 5th Edition", "FK5 4372"},
        {"Geneva Identification System", "GEN# +1.00025225"},
        {"Smithsonian Astrophysical Observation", "SAO 5088"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.79467780),
        dec: Angle.Degrees(+74.00051743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222387"},
        {"Hipparcos Number", "HIP 116728"},
        {"Fundamental Katalog 5th Edition", "FK5 3898"},
        {"Geneva Identification System", "GEN# +1.00222387"},
        {"Smithsonian Astrophysical Observation", "SAO 10817"},
        {"Wilson Evans Batten Catalogue", "WEB 20598"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.83819674),
        dec: Angle.Degrees(+74.00261499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9020"},
        {"Smithsonian Astrophysical Observation", "SAO 4516"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.03636432),
        dec: Angle.Degrees(+74.00271925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161128"},
        {"Hipparcos Number", "HIP 86137"},
        {"Geneva Identification System", "GEN# +1.00161128"},
        {"Smithsonian Astrophysical Observation", "SAO 8858"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.04255325),
        dec: Angle.Degrees(+74.00912345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11399"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.71554879),
        dec: Angle.Degrees(+74.01149963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79517"},
        {"Hipparcos Number", "HIP 45764"},
        {"Fundamental Katalog 5th Edition", "FK5 4829"},
        {"Geneva Identification System", "GEN# +1.00079517"},
        {"Smithsonian Astrophysical Observation", "SAO 6816"},
        {"Wilson Evans Batten Catalogue", "WEB 8681"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.98243737),
        dec: Angle.Degrees(+74.01675676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7406"},
        {"Hipparcos Number", "HIP 5950"},
        {"Smithsonian Astrophysical Observation", "SAO 4360"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15102163),
        dec: Angle.Degrees(+74.02682372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13222"},
        {"Hipparcos Number", "HIP 10350"},
        {"Fundamental Katalog 5th Edition", "FK5 2149"},
        {"Geneva Identification System", "GEN# +1.00013222"},
        {"Smithsonian Astrophysical Observation", "SAO 4599"},
        {"Wilson Evans Batten Catalogue", "WEB 2165"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.33768876),
        dec: Angle.Degrees(+74.02781030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107005"},
        {"Smithsonian Astrophysical Observation", "SAO 10119"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.07787522),
        dec: Angle.Degrees(+74.02874833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75893"},
    },
    visualMagnitude: 11.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.52212937),
        dec: Angle.Degrees(+74.03194436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220179"},
        {"Hipparcos Number", "HIP 115240"},
        {"Smithsonian Astrophysical Observation", "SAO 10706"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.12233805),
        dec: Angle.Degrees(+74.04062677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61906"},
        {"Hipparcos Number", "HIP 38109"},
        {"Geneva Identification System", "GEN# +1.00061906"},
        {"Smithsonian Astrophysical Observation", "SAO 6315"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.15073260),
        dec: Angle.Degrees(+74.04337140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136919"},
        {"Hipparcos Number", "HIP 74818"},
        {"Fundamental Katalog 5th Edition", "FK5 3208"},
        {"Geneva Identification System", "GEN# +1.00136919"},
        {"Smithsonian Astrophysical Observation", "SAO 8211"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.34438410),
        dec: Angle.Degrees(+74.04505944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170374"},
        {"Hipparcos Number", "HIP 89971"},
        {"Smithsonian Astrophysical Observation", "SAO 9092"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.35799073),
        dec: Angle.Degrees(+74.04803992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46419"},
        {"Hipparcos Number", "HIP 31984"},
        {"Geneva Identification System", "GEN# +1.00046419"},
        {"Smithsonian Astrophysical Observation", "SAO 5924"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.25717594),
        dec: Angle.Degrees(+74.05048606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14762 A"},
        {"Henry Draper", "HD 202506"},
        {"Hipparcos Number", "HIP 104584"},
        {"Smithsonian Astrophysical Observation", "SAO 9983"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.78818816),
        dec: Angle.Degrees(+74.05846291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12201"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.28013392),
        dec: Angle.Degrees(+74.05867334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97166"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.24416245),
        dec: Angle.Degrees(+74.06267016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3890"},
        {"Hipparcos Number", "HIP 3372"},
        {"Smithsonian Astrophysical Observation", "SAO 4192"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.72096170),
        dec: Angle.Degrees(+74.06519971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31590"},
        {"Hipparcos Number", "HIP 23617"},
        {"Smithsonian Astrophysical Observation", "SAO 5407"},
        {"Wilson Evans Batten Catalogue", "WEB 4605"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.16522092),
        dec: Angle.Degrees(+74.06699380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214071"},
        {"Hipparcos Number", "HIP 111302"},
        {"Smithsonian Astrophysical Observation", "SAO 10417"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.21401528),
        dec: Angle.Degrees(+74.07335184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77635"},
        {"Hipparcos Number", "HIP 44945"},
        {"Smithsonian Astrophysical Observation", "SAO 6758"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.33686635),
        dec: Angle.Degrees(+74.07713397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24064"},
        {"Hipparcos Number", "HIP 18451"},
        {"Smithsonian Astrophysical Observation", "SAO 5038"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15136351),
        dec: Angle.Degrees(+74.08000986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174980"},
        {"Hipparcos Number", "HIP 92056"},
        {"Geneva Identification System", "GEN# +1.00174980"},
        {"Smithsonian Astrophysical Observation", "SAO 9241"},
        {"Wilson Evans Batten Catalogue", "WEB 15866"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.44481933),
        dec: Angle.Degrees(+74.08535352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176523"},
        {"Hipparcos Number", "HIP 92677"},
        {"Geneva Identification System", "GEN# +1.00176523"},
        {"Smithsonian Astrophysical Observation", "SAO 9281"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.26888209),
        dec: Angle.Degrees(+74.08811148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31815"},
        {"Hipparcos Number", "HIP 23769"},
        {"Smithsonian Astrophysical Observation", "SAO 5421"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.63218409),
        dec: Angle.Degrees(+74.09208980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95601"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.67129470),
        dec: Angle.Degrees(+74.09729170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211879"},
        {"Hipparcos Number", "HIP 110016"},
        {"Geneva Identification System", "GEN# +1.00211879"},
        {"Smithsonian Astrophysical Observation", "SAO 10301"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.23816779),
        dec: Angle.Degrees(+74.10639062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8344"},
        {"Hipparcos Number", "HIP 6661"},
        {"Fundamental Katalog 5th Edition", "FK5 4132"},
        {"Smithsonian Astrophysical Observation", "SAO 4400"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.36895241),
        dec: Angle.Degrees(+74.11529875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64374"},
        {"Geneva Identification System", "GEN# +0.07400528"},
        {"Smithsonian Astrophysical Observation", "SAO 7774"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.91309068),
        dec: Angle.Degrees(+74.11888875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16775 AB"},
        {"Henry Draper", "HD 221071"},
        {"Hipparcos Number", "HIP 115810"},
        {"Smithsonian Astrophysical Observation", "SAO 10742"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.92873904),
        dec: Angle.Degrees(+74.11930288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23167"},
        {"Hipparcos Number", "HIP 17875"},
        {"Smithsonian Astrophysical Observation", "SAO 4998"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36365896),
        dec: Angle.Degrees(+74.12069898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222693"},
        {"Hipparcos Number", "HIP 116932"},
        {"Smithsonian Astrophysical Observation", "SAO 10838"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.53830528),
        dec: Angle.Degrees(+74.12948794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177807"},
        {"Hipparcos Number", "HIP 93165"},
        {"Geneva Identification System", "GEN# +1.00177807"},
        {"Smithsonian Astrophysical Observation", "SAO 9293"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.65661536),
        dec: Angle.Degrees(+74.13303737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48840"},
        {"Hipparcos Number", "HIP 33043"},
        {"Geneva Identification System", "GEN# +1.00048840"},
        {"Smithsonian Astrophysical Observation", "SAO 5996"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.26148577),
        dec: Angle.Degrees(+74.13690634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224272"},
        {"Hipparcos Number", "HIP 118014"},
        {"Smithsonian Astrophysical Observation", "SAO 10904"},
        {"Wilson Evans Batten Catalogue", "WEB 20752"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08040699),
        dec: Angle.Degrees(+74.13778580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88003"},
    },
    visualMagnitude: 11.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.64010886),
        dec: Angle.Degrees(+74.14333708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10550"},
        {"Smithsonian Astrophysical Observation", "SAO 4603"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.97144420),
        dec: Angle.Degrees(+74.14365746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94440"},
        {"Smithsonian Astrophysical Observation", "SAO 9356"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31641295),
        dec: Angle.Degrees(+74.14429576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35247"},
        {"Smithsonian Astrophysical Observation", "SAO 6130"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.25086988),
        dec: Angle.Degrees(+74.14468506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157663"},
        {"Hipparcos Number", "HIP 84538"},
        {"Smithsonian Astrophysical Observation", "SAO 8757"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.24036665),
        dec: Angle.Degrees(+74.14669804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57509"},
        {"Hipparcos Number", "HIP 36356"},
        {"Geneva Identification System", "GEN# +1.00057509"},
        {"Smithsonian Astrophysical Observation", "SAO 6200"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.24345932),
        dec: Angle.Degrees(+74.14822707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72607",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kochab"},
        {"Henry Draper", "HD 131873"},
        {"Hipparcos Number", "HIP 72607"},
        {"Fundamental Katalog 5th Edition", "FK5 550"},
        {"Geneva Identification System", "GEN# +1.00131873"},
        {"Smithsonian Astrophysical Observation", "SAO 8102"},
        {"Wilson Evans Batten Catalogue", "WEB 12482"},
    },
    visualMagnitude: 2.07,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67664751),
        dec: Angle.Degrees(+74.15547596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107360"},
        {"Hipparcos Number", "HIP 60127"},
        {"Smithsonian Astrophysical Observation", "SAO 7542"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.96900137),
        dec: Angle.Degrees(+74.16686759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93581"},
        {"Hipparcos Number", "HIP 53009"},
        {"Smithsonian Astrophysical Observation", "SAO 7216"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.67241013),
        dec: Angle.Degrees(+74.16775567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56277"},
        {"Smithsonian Astrophysical Observation", "SAO 7373"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.05924829),
        dec: Angle.Degrees(+74.17040475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20507"},
        {"Hipparcos Number", "HIP 15843"},
        {"Cincinnati Publication", "Ci 18 440"},
        {"Geneva Identification System", "GEN# +1.00020507"},
        {"Smithsonian Astrophysical Observation", "SAO 4897"},
        {"Wilson Evans Batten Catalogue", "WEB 3023"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.01706296),
        dec: Angle.Degrees(+74.17135844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27422"},
        {"Smithsonian Astrophysical Observation", "SAO 5657"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.10336242),
        dec: Angle.Degrees(+74.18639492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6007"},
        {"Hipparcos Number", "HIP 4942"},
        {"Smithsonian Astrophysical Observation", "SAO 4308"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85468071),
        dec: Angle.Degrees(+74.18933978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48783"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.25420303),
        dec: Angle.Degrees(+74.19246011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19372"},
        {"Hipparcos Number", "HIP 14947"},
        {"Geneva Identification System", "GEN# +1.00019372"},
        {"Smithsonian Astrophysical Observation", "SAO 4845"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.17071568),
        dec: Angle.Degrees(+74.19708181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110317"},
        {"Geneva Identification System", "GEN# +0.07300975"},
        {"Smithsonian Astrophysical Observation", "SAO 10328"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16513840),
        dec: Angle.Degrees(+74.20288149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8730"},
        {"Hipparcos Number", "HIP 6914"},
        {"Smithsonian Astrophysical Observation", "SAO 4407"},
        {"Wilson Evans Batten Catalogue", "WEB 1504"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.25693873),
        dec: Angle.Degrees(+74.20533813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65206"},
        {"Wilson Evans Batten Catalogue", "WEB 11516"},
    },
    visualMagnitude: 11.66,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.45238702),
        dec: Angle.Degrees(+74.20902504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -446.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 370"},
        {"Hipparcos Number", "HIP 701"},
        {"Smithsonian Astrophysical Observation", "SAO 4043"},
        {"Wilson Evans Batten Catalogue", "WEB 118"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.18307102),
        dec: Angle.Degrees(+74.21471191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218996"},
        {"Hipparcos Number", "HIP 114462"},
        {"Smithsonian Astrophysical Observation", "SAO 10643"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.72658987),
        dec: Angle.Degrees(+74.21492139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111716"},
        {"Hipparcos Number", "HIP 62598"},
        {"Smithsonian Astrophysical Observation", "SAO 7673"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.40559196),
        dec: Angle.Degrees(+74.21616175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221697"},
        {"Hipparcos Number", "HIP 116260"},
        {"Smithsonian Astrophysical Observation", "SAO 10780"},
        {"Wilson Evans Batten Catalogue", "WEB 20545"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.35631208),
        dec: Angle.Degrees(+74.22584131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160538"},
        {"Hipparcos Number", "HIP 85852"},
        {"Fundamental Katalog 5th Edition", "FK5 3396"},
        {"Geneva Identification System", "GEN# +1.00160538"},
        {"Smithsonian Astrophysical Observation", "SAO 8842"},
        {"Wilson Evans Batten Catalogue", "WEB 14491"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.17228538),
        dec: Angle.Degrees(+74.22726469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219485"},
        {"Hipparcos Number", "HIP 114745"},
        {"Geneva Identification System", "GEN# +1.00219485"},
        {"Smithsonian Astrophysical Observation", "SAO 10664"},
        {"Wilson Evans Batten Catalogue", "WEB 20344"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.65423592),
        dec: Angle.Degrees(+74.23125488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64724"},
        {"Hipparcos Number", "HIP 39318"},
        {"Smithsonian Astrophysical Observation", "SAO 6389"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.58438841),
        dec: Angle.Degrees(+74.23869134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100573"},
        {"Hipparcos Number", "HIP 56530"},
        {"Geneva Identification System", "GEN# +1.00100573"},
        {"Smithsonian Astrophysical Observation", "SAO 7383"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.86590793),
        dec: Angle.Degrees(+74.24121433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19534"},
        {"Hipparcos Number", "HIP 15073"},
        {"Smithsonian Astrophysical Observation", "SAO 4855"},
        {"Wilson Evans Batten Catalogue", "WEB 2904"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.57164316),
        dec: Angle.Degrees(+74.24310899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22135"},
    },
    visualMagnitude: 12.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.45264866),
        dec: Angle.Degrees(+74.24399668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98244",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13250 AB"},
        {"Henry Draper", "HD 190379"},
        {"Hipparcos Number", "HIP 98244"},
        {"Geneva Identification System", "GEN# +1.00190379J"},
        {"Smithsonian Astrophysical Observation", "SAO 9591"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47227785),
        dec: Angle.Degrees(+74.24439550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22131"},
        {"Smithsonian Astrophysical Observation", "SAO 5292"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.43962836),
        dec: Angle.Degrees(+74.24997214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103809"},
        {"Hipparcos Number", "HIP 58299"},
        {"Smithsonian Astrophysical Observation", "SAO 7461"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.32783176),
        dec: Angle.Degrees(+74.26333230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31312"},
        {"Hipparcos Number", "HIP 23442"},
        {"Geneva Identification System", "GEN# +1.00031312"},
        {"Smithsonian Astrophysical Observation", "SAO 5385"},
        {"Wilson Evans Batten Catalogue", "WEB 4555"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.58245040),
        dec: Angle.Degrees(+74.26926858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1500"},
        {"Hipparcos Number", "HIP 1580"},
        {"Smithsonian Astrophysical Observation", "SAO 4090"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.94636984),
        dec: Angle.Degrees(+74.27656372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10299 A"},
        {"Henry Draper", "HD 154181"},
        {"Henry Draper 2", "HD 154181A"},
        {"Hipparcos Number", "HIP 82886"},
        {"Smithsonian Astrophysical Observation", "SAO 8670"},
        {"Wilson Evans Batten Catalogue", "WEB 14013"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07823500),
        dec: Angle.Degrees(+74.28283119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129149"},
        {"Hipparcos Number", "HIP 71393"},
        {"Smithsonian Astrophysical Observation", "SAO 8059"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.98543249),
        dec: Angle.Degrees(+74.28335331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221185"},
        {"Hipparcos Number", "HIP 115885"},
        {"Smithsonian Astrophysical Observation", "SAO 10751"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.18278149),
        dec: Angle.Degrees(+74.28629731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14557 AB"},
        {"Henry Draper", "HD 200707"},
        {"Hipparcos Number", "HIP 103619"},
        {"Smithsonian Astrophysical Observation", "SAO 9927"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.91551850),
        dec: Angle.Degrees(+74.28630843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153752"},
        {"Hipparcos Number", "HIP 82648"},
        {"Geneva Identification System", "GEN# +1.00153752"},
        {"Smithsonian Astrophysical Observation", "SAO 8655"},
        {"Wilson Evans Batten Catalogue", "WEB 13953"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.40895361),
        dec: Angle.Degrees(+74.29169383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31528"},
        {"Cincinnati Publication", "Ci 18 804"},
        {"Smithsonian Astrophysical Observation", "SAO 5897"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.01247062),
        dec: Angle.Degrees(+74.29335673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19438"},
        {"Hipparcos Number", "HIP 15009"},
        {"Geneva Identification System", "GEN# +1.00019438"},
        {"Smithsonian Astrophysical Observation", "SAO 4849"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.36449441),
        dec: Angle.Degrees(+74.29639585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9612"},
        {"Hipparcos Number", "HIP 7557"},
        {"Geneva Identification System", "GEN# +1.00009612"},
        {"Smithsonian Astrophysical Observation", "SAO 4448"},
        {"Wilson Evans Batten Catalogue", "WEB 1617"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.34243051),
        dec: Angle.Degrees(+74.30096200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34885"},
        {"Hipparcos Number", "HIP 25630"},
        {"Smithsonian Astrophysical Observation", "SAO 5539"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.12476272),
        dec: Angle.Degrees(+74.30751920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119227"},
        {"Hipparcos Number", "HIP 66562"},
        {"Geneva Identification System", "GEN# +1.00119227"},
        {"Smithsonian Astrophysical Observation", "SAO 7859"},
        {"Wilson Evans Batten Catalogue", "WEB 11745"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.67094838),
        dec: Angle.Degrees(+74.31011277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87014"},
        {"Hipparcos Number", "HIP 49495"},
        {"Geneva Identification System", "GEN# +1.00087014"},
        {"Smithsonian Astrophysical Observation", "SAO 7045"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.57597547),
        dec: Angle.Degrees(+74.31081675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4959"},
        {"Hipparcos Number", "HIP 4172"},
        {"Geneva Identification System", "GEN# +1.00004959"},
        {"Smithsonian Astrophysical Observation", "SAO 4256"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.32917996),
        dec: Angle.Degrees(+74.31273756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82327"},
        {"Hipparcos Number", "HIP 47119"},
        {"Geneva Identification System", "GEN# +1.00082327"},
        {"Smithsonian Astrophysical Observation", "SAO 6900"},
        {"Wilson Evans Batten Catalogue", "WEB 8868"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02829338),
        dec: Angle.Degrees(+74.31887605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36065"},
        {"Hipparcos Number", "HIP 26372"},
        {"Geneva Identification System", "GEN# +1.00036065"},
        {"Smithsonian Astrophysical Observation", "SAO 5578"},
        {"Wilson Evans Batten Catalogue", "WEB 5198"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.23159766),
        dec: Angle.Degrees(+74.31949201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91316"},
        {"Wilson Evans Batten Catalogue", "WEB 15694"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38943101),
        dec: Angle.Degrees(+74.32847468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215439"},
        {"Hipparcos Number", "HIP 112114"},
        {"Geneva Identification System", "GEN# +1.00215439"},
        {"Smithsonian Astrophysical Observation", "SAO 10474"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.64992371),
        dec: Angle.Degrees(+74.33121627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168497"},
        {"Hipparcos Number", "HIP 89188"},
        {"Smithsonian Astrophysical Observation", "SAO 9050"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02549752),
        dec: Angle.Degrees(+74.33402854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94573"},
        {"Hipparcos Number", "HIP 53564"},
        {"Smithsonian Astrophysical Observation", "SAO 7244"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.36487766),
        dec: Angle.Degrees(+74.33638683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97904"},
        {"Hipparcos Number", "HIP 55144"},
        {"Smithsonian Astrophysical Observation", "SAO 7329"},
        {"Wilson Evans Batten Catalogue", "WEB 9939"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.33979460),
        dec: Angle.Degrees(+74.33793156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82619"},
        {"Hipparcos Number", "HIP 47259"},
        {"Geneva Identification System", "GEN# +1.00082619"},
        {"Smithsonian Astrophysical Observation", "SAO 6913"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.48519733),
        dec: Angle.Degrees(+74.34301309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191606"},
        {"Hipparcos Number", "HIP 98816"},
        {"Smithsonian Astrophysical Observation", "SAO 9627"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.01750153),
        dec: Angle.Degrees(+74.34626758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188458"},
        {"Hipparcos Number", "HIP 97445"},
        {"Geneva Identification System", "GEN# +1.00188458"},
        {"Smithsonian Astrophysical Observation", "SAO 9547"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.08965366),
        dec: Angle.Degrees(+74.34948167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37830"},
        {"Smithsonian Astrophysical Observation", "SAO 6295"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.34114501),
        dec: Angle.Degrees(+74.35335372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52037"},
        {"Smithsonian Astrophysical Observation", "SAO 7175"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.48192561),
        dec: Angle.Degrees(+74.35696733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58710"},
        {"Hipparcos Number", "HIP 36805"},
        {"Geneva Identification System", "GEN# +1.00058710"},
        {"Smithsonian Astrophysical Observation", "SAO 6234"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.54559660),
        dec: Angle.Degrees(+74.35961370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6608 AB"},
        {"Henry Draper", "HD 66633"},
        {"Hipparcos Number", "HIP 40090"},
        {"Geneva Identification System", "GEN# +1.00066633"},
        {"Smithsonian Astrophysical Observation", "SAO 6439"},
        {"Wilson Evans Batten Catalogue", "WEB 7823"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.83672864),
        dec: Angle.Degrees(+74.36299943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6163"},
        {"Hipparcos Number", "HIP 5070"},
        {"Smithsonian Astrophysical Observation", "SAO 4316"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20781995),
        dec: Angle.Degrees(+74.37212887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34224"},
        {"Smithsonian Astrophysical Observation", "SAO 6067"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.43179160),
        dec: Angle.Degrees(+74.37683232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186063"},
        {"Hipparcos Number", "HIP 96335"},
        {"Fundamental Katalog 5th Edition", "FK5 3568"},
        {"Geneva Identification System", "GEN# +1.00186063J"},
        {"Smithsonian Astrophysical Observation", "SAO 9477"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79252507),
        dec: Angle.Degrees(+74.37744727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95545"},
        {"Hipparcos Number", "HIP 54070"},
        {"Geneva Identification System", "GEN# +1.00095545"},
        {"Smithsonian Astrophysical Observation", "SAO 7273"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.95881114),
        dec: Angle.Degrees(+74.38461597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128251"},
        {"Hipparcos Number", "HIP 70967"},
        {"Smithsonian Astrophysical Observation", "SAO 8040"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.73639980),
        dec: Angle.Degrees(+74.38740891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168411"},
        {"Hipparcos Number", "HIP 89140"},
        {"Smithsonian Astrophysical Observation", "SAO 9043"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.88485959),
        dec: Angle.Degrees(+74.39146546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19275"},
        {"Hipparcos Number", "HIP 14862"},
        {"Fundamental Katalog 5th Edition", "FK5 2222"},
        {"Geneva Identification System", "GEN# +1.00019275"},
        {"Smithsonian Astrophysical Observation", "SAO 4840"},
        {"Wilson Evans Batten Catalogue", "WEB 2869"},
    },
    visualMagnitude: 4.85,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98432711),
        dec: Angle.Degrees(+74.39386878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222589"},
        {"Hipparcos Number", "HIP 116845"},
        {"Geneva Identification System", "GEN# +1.00222589"},
        {"Smithsonian Astrophysical Observation", "SAO 10832"},
        {"Wilson Evans Batten Catalogue", "WEB 20616"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.26721714),
        dec: Angle.Degrees(+74.40230154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75417"},
        {"Hipparcos Number", "HIP 43844"},
        {"Geneva Identification System", "GEN# +1.00075417"},
        {"Smithsonian Astrophysical Observation", "SAO 6679"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.95871333),
        dec: Angle.Degrees(+74.40479250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224098"},
        {"Hipparcos Number", "HIP 117893"},
        {"Fundamental Katalog 5th Edition", "FK5 1627"},
        {"Geneva Identification System", "GEN# +1.00224098"},
        {"Smithsonian Astrophysical Observation", "SAO 10893"},
        {"Wilson Evans Batten Catalogue", "WEB 20736"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.70533194),
        dec: Angle.Degrees(+74.41010950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142474"},
        {"Hipparcos Number", "HIP 77409"},
        {"Cincinnati Publication", "Ci 18 2124"},
        {"Smithsonian Astrophysical Observation", "SAO 8344"},
        {"Wilson Evans Batten Catalogue", "WEB 13108"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.04047902),
        dec: Angle.Degrees(+74.41485339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98365"},
        {"Hipparcos Number", "HIP 55378"},
        {"Smithsonian Astrophysical Observation", "SAO 7339"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.09679617),
        dec: Angle.Degrees(+74.42054363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61799",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8622 A"},
        {"Henry Draper", "HD 110312"},
        {"Hipparcos Number", "HIP 61799"},
        {"Geneva Identification System", "GEN# +1.00110312"},
        {"Smithsonian Astrophysical Observation", "SAO 7625"},
        {"Wilson Evans Batten Catalogue", "WEB 10993"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98661274),
        dec: Angle.Degrees(+74.42077938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84820"},
        {"Hipparcos Number", "HIP 48425"},
        {"Smithsonian Astrophysical Observation", "SAO 6982"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.08547167),
        dec: Angle.Degrees(+74.42518453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192635"},
        {"Hipparcos Number", "HIP 99285"},
        {"Geneva Identification System", "GEN# +1.00192635"},
        {"Smithsonian Astrophysical Observation", "SAO 9659"},
        {"Wilson Evans Batten Catalogue", "WEB 17705"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.31379143),
        dec: Angle.Degrees(+74.42573150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69659"},
        {"Hipparcos Number", "HIP 41210"},
        {"Smithsonian Astrophysical Observation", "SAO 6525"},
        {"Wilson Evans Batten Catalogue", "WEB 7973"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.14004327),
        dec: Angle.Degrees(+74.43805969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107236"},
        {"Cincinnati Publication", "Ci 18 2830"},
        {"Geneva Identification System", "GEN# +0.07300943"},
        {"Smithsonian Astrophysical Observation", "SAO 10132"},
        {"Wilson Evans Batten Catalogue", "WEB 19368"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.78493769),
        dec: Angle.Degrees(+74.44570319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162027"},
        {"Hipparcos Number", "HIP 86525"},
        {"Smithsonian Astrophysical Observation", "SAO 8884"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.23331624),
        dec: Angle.Degrees(+74.44747240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75495"},
    },
    visualMagnitude: 9.42,
    bvColour: 2.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.32485723),
        dec: Angle.Degrees(+74.45340008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21991"},
        {"Hipparcos Number", "HIP 17041"},
        {"Smithsonian Astrophysical Observation", "SAO 4954"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.80084383),
        dec: Angle.Degrees(+74.45967139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176281"},
        {"Hipparcos Number", "HIP 92568"},
        {"Renson", "Renson 49173"},
        {"Smithsonian Astrophysical Observation", "SAO 9271"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.94513743),
        dec: Angle.Degrees(+74.46062062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28723"},
        {"Hipparcos Number", "HIP 21675"},
        {"Smithsonian Astrophysical Observation", "SAO 5266"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.79032763),
        dec: Angle.Degrees(+74.46902514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4039"},
        {"Geneva Identification System", "GEN# +0.07300039"},
        {"Smithsonian Astrophysical Observation", "SAO 4252"},
        {"Wilson Evans Batten Catalogue", "WEB 724"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.95123784),
        dec: Angle.Degrees(+74.47382832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81792"},
        {"Smithsonian Astrophysical Observation", "SAO 8604"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.58492908),
        dec: Angle.Degrees(+74.47513974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82773"},
        {"Smithsonian Astrophysical Observation", "SAO 8661"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.74161690),
        dec: Angle.Degrees(+74.47566370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218168"},
        {"Hipparcos Number", "HIP 113905"},
        {"Geneva Identification System", "GEN# +1.00218168"},
        {"Smithsonian Astrophysical Observation", "SAO 10607"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.00817439),
        dec: Angle.Degrees(+74.47733814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32085"},
        {"Smithsonian Astrophysical Observation", "SAO 5932"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.54688864),
        dec: Angle.Degrees(+74.48081664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 678"},
        {"Hipparcos Number", "HIP 918"},
        {"Smithsonian Astrophysical Observation", "SAO 4054"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.84178323),
        dec: Angle.Degrees(+74.48458019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119703"},
        {"Hipparcos Number", "HIP 66791"},
        {"Geneva Identification System", "GEN# +1.00119703"},
        {"Smithsonian Astrophysical Observation", "SAO 7868"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.34177442),
        dec: Angle.Degrees(+74.48547179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61177",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Funi"},
        {"Henry Draper", "HD 109246"},
        {"Hipparcos Number", "HIP 61177"},
        {"Geneva Identification System", "GEN# +1.00109246"},
        {"Smithsonian Astrophysical Observation", "SAO 7585"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.03150734),
        dec: Angle.Degrees(+74.48966460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102699"},
        {"Smithsonian Astrophysical Observation", "SAO 9889"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.13544546),
        dec: Angle.Degrees(+74.48973066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2939"},
        {"Hipparcos Number", "HIP 2664"},
        {"Smithsonian Astrophysical Observation", "SAO 4143"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.44458142),
        dec: Angle.Degrees(+74.49396421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67739"},
        {"Hipparcos Number", "HIP 40513"},
        {"Geneva Identification System", "GEN# +1.00067739"},
        {"Smithsonian Astrophysical Observation", "SAO 6470"},
        {"Wilson Evans Batten Catalogue", "WEB 7884"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.07022459),
        dec: Angle.Degrees(+74.49423458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109132",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15655 A"},
        {"Hipparcos Number", "HIP 109132"},
        {"Smithsonian Astrophysical Observation", "SAO 10247"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.59044631),
        dec: Angle.Degrees(+74.49545447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62213"},
        {"Hipparcos Number", "HIP 38251"},
        {"Smithsonian Astrophysical Observation", "SAO 6322"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.54207571),
        dec: Angle.Degrees(+74.49864247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85509",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10617 AB"},
        {"Henry Draper", "HD 159754"},
        {"Hipparcos Number", "HIP 85509"},
        {"Smithsonian Astrophysical Observation", "SAO 8816"},
        {"Wilson Evans Batten Catalogue", "WEB 14439"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.12104784),
        dec: Angle.Degrees(+74.50011289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66267"},
        {"Cincinnati Publication", "Ci 20 793"},
        {"Geneva Identification System", "GEN# +0.07500511"},
        {"Smithsonian Astrophysical Observation", "SAO 7849"},
        {"Wilson Evans Batten Catalogue", "WEB 11712"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.72756103),
        dec: Angle.Degrees(+74.50044906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -438.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3500"},
        {"Smithsonian Astrophysical Observation", "SAO 4206"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.16913443),
        dec: Angle.Degrees(+74.51524606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52322"},
        {"Smithsonian Astrophysical Observation", "SAO 7188"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.36386319),
        dec: Angle.Degrees(+74.51687485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54590"},
        {"Smithsonian Astrophysical Observation", "SAO 7296"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.57738128),
        dec: Angle.Degrees(+74.51938409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41159"},
        {"Hipparcos Number", "HIP 29369"},
        {"Geneva Identification System", "GEN# +1.00041159"},
        {"Smithsonian Astrophysical Observation", "SAO 5765"},
        {"Wilson Evans Batten Catalogue", "WEB 5766"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.85705374),
        dec: Angle.Degrees(+74.52795859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93060"},
        {"Hipparcos Number", "HIP 52783"},
        {"Smithsonian Astrophysical Observation", "SAO 7205"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.87282314),
        dec: Angle.Degrees(+74.52843682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33355"},
        {"Hipparcos Number", "HIP 24664"},
        {"Smithsonian Astrophysical Observation", "SAO 5478"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.38178463),
        dec: Angle.Degrees(+74.53588077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43042"},
        {"Geneva Identification System", "GEN# +0.07500348"},
        {"Smithsonian Astrophysical Observation", "SAO 6630"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.54858648),
        dec: Angle.Degrees(+74.54200734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22648"},
        {"Hipparcos Number", "HIP 17523"},
        {"Fundamental Katalog 5th Edition", "FK5 2262"},
        {"Geneva Identification System", "GEN# +1.00022648"},
        {"Smithsonian Astrophysical Observation", "SAO 4972"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.27955638),
        dec: Angle.Degrees(+74.54253422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69334"},
        {"Smithsonian Astrophysical Observation", "SAO 7966"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.85625939),
        dec: Angle.Degrees(+74.54572799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28095"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.08093059),
        dec: Angle.Degrees(+74.54591145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74959"},
        {"Hipparcos Number", "HIP 43627"},
        {"Smithsonian Astrophysical Observation", "SAO 6671"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27743636),
        dec: Angle.Degrees(+74.54775557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32850"},
        {"Smithsonian Astrophysical Observation", "SAO 5985"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.70681314),
        dec: Angle.Degrees(+74.54797229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42259"},
        {"Smithsonian Astrophysical Observation", "SAO 6593"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.26218619),
        dec: Angle.Degrees(+74.55112640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215855"},
        {"Hipparcos Number", "HIP 112373"},
        {"Smithsonian Astrophysical Observation", "SAO 10491"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40663471),
        dec: Angle.Degrees(+74.55409809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3982 AB"},
        {"Henry Draper", "HD 34740"},
        {"Hipparcos Number", "HIP 25543"},
        {"Renson", "Renson 8870"},
        {"Smithsonian Astrophysical Observation", "SAO 5531"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.91436021),
        dec: Angle.Degrees(+74.55666108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193485"},
        {"Hipparcos Number", "HIP 99697"},
        {"Smithsonian Astrophysical Observation", "SAO 9691"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.46330755),
        dec: Angle.Degrees(+74.55857228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80122"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.31990106),
        dec: Angle.Degrees(+74.56306395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85887"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.27800679),
        dec: Angle.Degrees(+74.56640684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 384.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164056"},
        {"Hipparcos Number", "HIP 87385"},
        {"Smithsonian Astrophysical Observation", "SAO 8945"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.85357982),
        dec: Angle.Degrees(+74.56908733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123710"},
        {"Hipparcos Number", "HIP 68796"},
        {"Geneva Identification System", "GEN# +1.00123710"},
        {"Smithsonian Astrophysical Observation", "SAO 7945"},
        {"Wilson Evans Batten Catalogue", "WEB 12033"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.23914425),
        dec: Angle.Degrees(+74.57336150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107449"},
        {"Smithsonian Astrophysical Observation", "SAO 10148"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.45145294),
        dec: Angle.Degrees(+74.57908405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7926"},
        {"Hipparcos Number", "HIP 6347"},
        {"Smithsonian Astrophysical Observation", "SAO 4384"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.38048358),
        dec: Angle.Degrees(+74.58032049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82746"},
        {"Smithsonian Astrophysical Observation", "SAO 8660"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.68155542),
        dec: Angle.Degrees(+74.58320130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14694"},
        {"Hipparcos Number", "HIP 11403"},
        {"Fundamental Katalog 5th Edition", "FK5 4227"},
        {"Smithsonian Astrophysical Observation", "SAO 4646"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.73425029),
        dec: Angle.Degrees(+74.58339566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12441"},
        {"Hipparcos Number", "HIP 9802"},
        {"Smithsonian Astrophysical Observation", "SAO 4570"},
        {"Wilson Evans Batten Catalogue", "WEB 2057"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.51102909),
        dec: Angle.Degrees(+74.58370931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83599"},
        {"Hipparcos Number", "HIP 47777"},
        {"Geneva Identification System", "GEN# +1.00083599"},
        {"Smithsonian Astrophysical Observation", "SAO 6945"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.11144085),
        dec: Angle.Degrees(+74.58757452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14208"},
        {"Smithsonian Astrophysical Observation", "SAO 4799"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.80084486),
        dec: Angle.Degrees(+74.59355295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124063"},
        {"Hipparcos Number", "HIP 68956"},
        {"Fundamental Katalog 5th Edition", "FK5 3125"},
        {"Geneva Identification System", "GEN# +1.00124063"},
        {"Smithsonian Astrophysical Observation", "SAO 7953"},
        {"Wilson Evans Batten Catalogue", "WEB 12049"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.73534316),
        dec: Angle.Degrees(+74.59375041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10259"},
        {"Hipparcos Number", "HIP 8082"},
        {"Smithsonian Astrophysical Observation", "SAO 4473"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.95010483),
        dec: Angle.Degrees(+74.60454680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37393"},
        {"Hipparcos Number", "HIP 27246"},
        {"Cincinnati Publication", "Ci 18 714"},
        {"Fundamental Katalog 5th Edition", "FK5 4531"},
        {"Geneva Identification System", "GEN# +1.00037393"},
        {"Smithsonian Astrophysical Observation", "SAO 5641"},
        {"Wilson Evans Batten Catalogue", "WEB 5354"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.62284503),
        dec: Angle.Degrees(+74.61057117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216848"},
        {"Hipparcos Number", "HIP 113083"},
        {"Geneva Identification System", "GEN# +1.00216848"},
        {"Smithsonian Astrophysical Observation", "SAO 10536"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52793734),
        dec: Angle.Degrees(+74.61200195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119820"},
        {"Hipparcos Number", "HIP 66847"},
        {"Smithsonian Astrophysical Observation", "SAO 7872"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.49410066),
        dec: Angle.Degrees(+74.62050053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203182"},
        {"Hipparcos Number", "HIP 104953"},
        {"Smithsonian Astrophysical Observation", "SAO 10003"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89490961),
        dec: Angle.Degrees(+74.62240052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9131"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.42522623),
        dec: Angle.Degrees(+74.62493302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173628"},
        {"Hipparcos Number", "HIP 91400"},
        {"Geneva Identification System", "GEN# +1.00173628"},
        {"Smithsonian Astrophysical Observation", "SAO 9198"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.60738137),
        dec: Angle.Degrees(+74.62544558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9164"},
        {"Hipparcos Number", "HIP 7249"},
        {"Smithsonian Astrophysical Observation", "SAO 4428"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.35010517),
        dec: Angle.Degrees(+74.62848314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6370"},
        {"Hipparcos Number", "HIP 5229"},
        {"Smithsonian Astrophysical Observation", "SAO 4325"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.71883645),
        dec: Angle.Degrees(+74.63181976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26579"},
        {"Hipparcos Number", "HIP 20173"},
        {"Smithsonian Astrophysical Observation", "SAO 5155"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.86907784),
        dec: Angle.Degrees(+74.63607255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25213"},
        {"Hipparcos Number", "HIP 19243"},
        {"Smithsonian Astrophysical Observation", "SAO 5089"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.85715972),
        dec: Angle.Degrees(+74.63665430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199492"},
        {"Hipparcos Number", "HIP 102982"},
        {"Smithsonian Astrophysical Observation", "SAO 9901"},
        {"Wilson Evans Batten Catalogue", "WEB 18688"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.95918482),
        dec: Angle.Degrees(+74.63912556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16862"},
        {"Smithsonian Astrophysical Observation", "SAO 4946"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.24994567),
        dec: Angle.Degrees(+74.63922484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15223"},
        {"Hipparcos Number", "HIP 11775"},
        {"Smithsonian Astrophysical Observation", "SAO 4666"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.99011552),
        dec: Angle.Degrees(+74.65256179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79340"},
        {"Smithsonian Astrophysical Observation", "SAO 8447"},
        {"Wilson Evans Batten Catalogue", "WEB 13411"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.88453950),
        dec: Angle.Degrees(+74.65309078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62947",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53, 56.7600),
        dec: Angle.DegreesMinutesSeconds((int)+74, (int)39, 34.900)
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
    primaryId: "HIP 62940",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8701 A"},
        {"Henry Draper", "HD 112310"},
        {"Hipparcos Number", "HIP 62940"},
        {"Geneva Identification System", "GEN# +1.00112310"},
        {"Renson", "Renson 32610"},
        {"Smithsonian Astrophysical Observation", "SAO 7691"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.47621260),
        dec: Angle.Degrees(+74.66060733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105678"},
        {"Hipparcos Number", "HIP 59291"},
        {"Fundamental Katalog 5th Edition", "FK5 5077"},
        {"Geneva Identification System", "GEN# +1.00105678"},
        {"Smithsonian Astrophysical Observation", "SAO 7512"},
        {"Wilson Evans Batten Catalogue", "WEB 10546"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.44619077),
        dec: Angle.Degrees(+74.66136609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26660"},
        {"Hipparcos Number", "HIP 20249"},
        {"Smithsonian Astrophysical Observation", "SAO 5158"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.08368648),
        dec: Angle.Degrees(+74.66196126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158692"},
        {"Hipparcos Number", "HIP 85021"},
        {"Smithsonian Astrophysical Observation", "SAO 8788"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.66970756),
        dec: Angle.Degrees(+74.66278918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53656"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.65796327),
        dec: Angle.Degrees(+74.66376656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -342.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23688"},
        {"Hipparcos Number", "HIP 18232"},
        {"Geneva Identification System", "GEN# +1.00023688"},
        {"Smithsonian Astrophysical Observation", "SAO 5021"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.48281500),
        dec: Angle.Degrees(+74.66607000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105179"},
        {"Hipparcos Number", "HIP 59052"},
        {"Smithsonian Astrophysical Observation", "SAO 7502"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.63312809),
        dec: Angle.Degrees(+74.67142431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23292"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.15410671),
        dec: Angle.Degrees(+74.68199582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111494"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.82985636),
        dec: Angle.Degrees(+74.68835127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36130"},
        {"Hipparcos Number", "HIP 26437"},
        {"Geneva Identification System", "GEN# +1.00036130"},
        {"Smithsonian Astrophysical Observation", "SAO 5581"},
        {"Wilson Evans Batten Catalogue", "WEB 5212"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.38972509),
        dec: Angle.Degrees(+74.68920658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76974"},
        {"Hipparcos Number", "HIP 44610"},
        {"Geneva Identification System", "GEN# +1.00076974"},
        {"Smithsonian Astrophysical Observation", "SAO 6734"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.33883967),
        dec: Angle.Degrees(+74.69675584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68072"},
        {"Geneva Identification System", "GEN# +0.07500523"},
        {"Smithsonian Astrophysical Observation", "SAO 7915"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.06201472),
        dec: Angle.Degrees(+74.71286695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123802"},
        {"Hipparcos Number", "HIP 68825"},
        {"Geneva Identification System", "GEN# +1.00123802"},
        {"Smithsonian Astrophysical Observation", "SAO 7947"},
        {"Wilson Evans Batten Catalogue", "WEB 12035"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.37654304),
        dec: Angle.Degrees(+74.71565632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6872 AB"},
        {"Henry Draper", "HD 71973"},
        {"Hipparcos Number", "HIP 42249"},
        {"Renson", "Renson 19860"},
        {"Smithsonian Astrophysical Observation", "SAO 6592"},
        {"Wilson Evans Batten Catalogue", "WEB 8116"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.20324261),
        dec: Angle.Degrees(+74.72372003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175305"},
        {"Hipparcos Number", "HIP 92167"},
        {"Cincinnati Publication", "Ci 18 2469"},
        {"Geneva Identification System", "GEN# +1.00175305"},
        {"Smithsonian Astrophysical Observation", "SAO 9252"},
        {"Wilson Evans Batten Catalogue", "WEB 15891"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.77388765),
        dec: Angle.Degrees(+74.72520982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21910"},
        {"Hipparcos Number", "HIP 16997"},
        {"Geneva Identification System", "GEN# +1.00021910"},
        {"Smithsonian Astrophysical Observation", "SAO 4951"},
        {"Wilson Evans Batten Catalogue", "WEB 3232"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.65151297),
        dec: Angle.Degrees(+74.73786691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17377"},
        {"Hipparcos Number", "HIP 13413"},
        {"Smithsonian Astrophysical Observation", "SAO 4747"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.17660635),
        dec: Angle.Degrees(+74.73814720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10229"},
        {"Hipparcos Number", "HIP 8057"},
        {"Smithsonian Astrophysical Observation", "SAO 4471"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.87306048),
        dec: Angle.Degrees(+74.74227551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30785"},
        {"Smithsonian Astrophysical Observation", "SAO 5852"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.02054076),
        dec: Angle.Degrees(+74.74310735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30315"},
        {"Smithsonian Astrophysical Observation", "SAO 5822"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.64116715),
        dec: Angle.Degrees(+74.74834390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3097"},
        {"Geneva Identification System", "GEN# +0.07300026"},
        {"Wilson Evans Batten Catalogue", "WEB 553"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.85771167),
        dec: Angle.Degrees(+74.74992020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114170"},
        {"Hipparcos Number", "HIP 63969"},
        {"Geneva Identification System", "GEN# +1.00114170"},
        {"Renson", "Renson 33043"},
        {"Smithsonian Astrophysical Observation", "SAO 7747"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.63548967),
        dec: Angle.Degrees(+74.75439712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86322"},
        {"Hipparcos Number", "HIP 49163"},
        {"Fundamental Katalog 5th Edition", "FK5 2805"},
        {"Geneva Identification System", "GEN# +1.00086322"},
        {"Smithsonian Astrophysical Observation", "SAO 7031"},
        {"Wilson Evans Batten Catalogue", "WEB 9108"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.49763139),
        dec: Angle.Degrees(+74.75917990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185327"},
        {"Hipparcos Number", "HIP 96001"},
        {"Fundamental Katalog 5th Edition", "FK5 5717"},
        {"Geneva Identification System", "GEN# +1.00185327"},
        {"Smithsonian Astrophysical Observation", "SAO 9453"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.79985485),
        dec: Angle.Degrees(+74.76919994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89717"},
        {"Hipparcos Number", "HIP 50972"},
        {"Geneva Identification System", "GEN# +1.00089717"},
        {"Smithsonian Astrophysical Observation", "SAO 7133"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.17871447),
        dec: Angle.Degrees(+74.77411072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199476"},
        {"Hipparcos Number", "HIP 102970"},
        {"Cincinnati Publication", "Ci 20 1240"},
        {"Cincinnati Publication 2", "Ci 18 2709"},
        {"Geneva Identification System", "GEN# +1.00199476"},
        {"Smithsonian Astrophysical Observation", "SAO 9899"},
        {"Wilson Evans Batten Catalogue", "WEB 18686"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.93354182),
        dec: Angle.Degrees(+74.77892856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 402.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 575.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95000"},
        {"Hipparcos Number", "HIP 53795"},
        {"Geneva Identification System", "GEN# +1.00095000"},
        {"Smithsonian Astrophysical Observation", "SAO 7262"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.09497347),
        dec: Angle.Degrees(+74.78813814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223401"},
        {"Hipparcos Number", "HIP 117434"},
        {"Geneva Identification System", "GEN# +1.00223401"},
        {"Smithsonian Astrophysical Observation", "SAO 10865"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.17202416),
        dec: Angle.Degrees(+74.79148159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57810"},
        {"Hipparcos Number", "HIP 36504"},
        {"Geneva Identification System", "GEN# +1.00057810"},
        {"Smithsonian Astrophysical Observation", "SAO 6208"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.65658325),
        dec: Angle.Degrees(+74.79880362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17143 AB"},
        {"Henry Draper", "HD 224610"},
        {"Hipparcos Number", "HIP 118257"},
        {"Smithsonian Astrophysical Observation", "SAO 10921"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.79434507),
        dec: Angle.Degrees(+74.80724941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8591 AB"},
        {"Henry Draper", "HD 109213"},
        {"Hipparcos Number", "HIP 61169"},
        {"Geneva Identification System", "GEN# +1.00109213J"},
        {"Smithsonian Astrophysical Observation", "SAO 7584"},
        {"Wilson Evans Batten Catalogue", "WEB 10891"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01235399),
        dec: Angle.Degrees(+74.81154945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6736 A"},
        {"Henry Draper", "HD 69054"},
        {"Hipparcos Number", "HIP 41011"},
        {"Geneva Identification System", "GEN# +1.00069054A"},
        {"Smithsonian Astrophysical Observation", "SAO 6511"},
        {"Wilson Evans Batten Catalogue", "WEB 7948"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53959122),
        dec: Angle.Degrees(+74.82025381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10523"},
        {"Hipparcos Number", "HIP 8245"},
        {"Smithsonian Astrophysical Observation", "SAO 4483"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.54040822),
        dec: Angle.Degrees(+74.82275959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213021"},
        {"Hipparcos Number", "HIP 110681"},
        {"Smithsonian Astrophysical Observation", "SAO 10363"},
        {"Wilson Evans Batten Catalogue", "WEB 19829"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.34843953),
        dec: Angle.Degrees(+74.82819152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106339"},
        {"Smithsonian Astrophysical Observation", "SAO 10080"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.05637782),
        dec: Angle.Degrees(+74.84355436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43167"},
        {"Hipparcos Number", "HIP 30355"},
        {"Geneva Identification System", "GEN# +1.00043167"},
        {"Smithsonian Astrophysical Observation", "SAO 5826"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.77406061),
        dec: Angle.Degrees(+74.84614299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4382"},
        {"Hipparcos Number", "HIP 3721"},
        {"Geneva Identification System", "GEN# +1.00004382"},
        {"Renson", "Renson 1200"},
        {"Smithsonian Astrophysical Observation", "SAO 4226"},
        {"Wilson Evans Batten Catalogue", "WEB 662"},
    },
    visualMagnitude: 5.42,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.94174879),
        dec: Angle.Degrees(+74.84758739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212955"},
        {"Hipparcos Number", "HIP 110635"},
        {"Geneva Identification System", "GEN# +1.00212955"},
        {"Smithsonian Astrophysical Observation", "SAO 10357"},
        {"Wilson Evans Batten Catalogue", "WEB 19825"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.17688948),
        dec: Angle.Degrees(+74.85021143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137292"},
        {"Hipparcos Number", "HIP 74942"},
        {"Smithsonian Astrophysical Observation", "SAO 8215"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.70905086),
        dec: Angle.Degrees(+74.85802313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11695"},
        {"Smithsonian Astrophysical Observation", "SAO 4659"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.70652762),
        dec: Angle.Degrees(+74.86200838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52618"},
        {"Smithsonian Astrophysical Observation", "SAO 7198"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.39563257),
        dec: Angle.Degrees(+74.86750925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12527"},
        {"Hipparcos Number", "HIP 9881"},
        {"Smithsonian Astrophysical Observation", "SAO 4575"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.78826616),
        dec: Angle.Degrees(+74.86981741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51482"},
        {"Smithsonian Astrophysical Observation", "SAO 7151"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.72685201),
        dec: Angle.Degrees(+74.88002873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117814"},
        {"Hipparcos Number", "HIP 65828"},
        {"Smithsonian Astrophysical Observation", "SAO 7828"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.41537320),
        dec: Angle.Degrees(+74.88069371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132770"},
        {"Hipparcos Number", "HIP 72992"},
        {"Smithsonian Astrophysical Observation", "SAO 8120"},
        {"Wilson Evans Batten Catalogue", "WEB 12522"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.75078287),
        dec: Angle.Degrees(+74.88120566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44943"},
        {"Smithsonian Astrophysical Observation", "SAO 6755"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.31574878),
        dec: Angle.Degrees(+74.88906428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114787"},
        {"Smithsonian Astrophysical Observation", "SAO 10668"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.78116771),
        dec: Angle.Degrees(+74.89065528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72101"},
        {"Smithsonian Astrophysical Observation", "SAO 8080"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23990986),
        dec: Angle.Degrees(+74.89176594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81544"},
        {"Smithsonian Astrophysical Observation", "SAO 8591"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.82457101),
        dec: Angle.Degrees(+74.89729010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73136",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Baekdu"},
        {"Henry Draper", "HD 133086"},
        {"Hipparcos Number", "HIP 73136"},
        {"Geneva Identification System", "GEN# +1.00133086"},
        {"Smithsonian Astrophysical Observation", "SAO 8127"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.20134602),
        dec: Angle.Degrees(+74.90091329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18399"},
        {"Hipparcos Number", "HIP 14205"},
        {"Geneva Identification System", "GEN# +1.00018399"},
        {"Smithsonian Astrophysical Observation", "SAO 4798"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.79646430),
        dec: Angle.Degrees(+74.90984013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79870"},
        {"Hipparcos Number", "HIP 45938"},
        {"Renson", "Renson 22726"},
        {"Smithsonian Astrophysical Observation", "SAO 6825"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.50712954),
        dec: Angle.Degrees(+74.91273047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182469"},
        {"Hipparcos Number", "HIP 94775"},
        {"Smithsonian Astrophysical Observation", "SAO 9376"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.26839869),
        dec: Angle.Degrees(+74.92679372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8533"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.50485740),
        dec: Angle.Degrees(+74.93336144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19340"},
        {"Hipparcos Number", "HIP 14948"},
        {"Geneva Identification System", "GEN# +1.00019340"},
        {"Smithsonian Astrophysical Observation", "SAO 4844"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.17715207),
        dec: Angle.Degrees(+74.93662627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31546"},
        {"Smithsonian Astrophysical Observation", "SAO 5896"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.05051306),
        dec: Angle.Degrees(+74.93714125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90888"},
        {"Hipparcos Number", "HIP 51628"},
        {"Geneva Identification System", "GEN# +1.00090888"},
        {"Smithsonian Astrophysical Observation", "SAO 7158"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.20897100),
        dec: Angle.Degrees(+74.93909129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50313"},
        {"Hipparcos Number", "HIP 33773"},
        {"Geneva Identification System", "GEN# +1.00050313"},
        {"Smithsonian Astrophysical Observation", "SAO 6029"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.20702501),
        dec: Angle.Degrees(+74.94086916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16179"},
        {"Smithsonian Astrophysical Observation", "SAO 4907"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.10525245),
        dec: Angle.Degrees(+74.95183944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196502"},
        {"Hipparcos Number", "HIP 101260"},
        {"Fundamental Katalog 5th Edition", "FK5 770"},
        {"Geneva Identification System", "GEN# +1.00196502"},
        {"Renson", "Renson 54780"},
        {"Smithsonian Astrophysical Observation", "SAO 9802"},
        {"Wilson Evans Batten Catalogue", "WEB 18293"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.87666197),
        dec: Angle.Degrees(+74.95465942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103081"},
        {"Hipparcos Number", "HIP 57905"},
        {"Smithsonian Astrophysical Observation", "SAO 7440"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.15882491),
        dec: Angle.Degrees(+74.96509173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40047"},
        {"Geneva Identification System", "GEN# +0.07500325"},
        {"Renson", "Renson 18360"},
        {"Smithsonian Astrophysical Observation", "SAO 6435"},
    },
    visualMagnitude: 9.55,
    bvColour: -0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.70614066),
        dec: Angle.Degrees(+74.96606811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80195"},
        {"Hipparcos Number", "HIP 46080"},
        {"Smithsonian Astrophysical Observation", "SAO 6837"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.95709782),
        dec: Angle.Degrees(+74.97534735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 624 A"},
        {"Henry Draper", "HD 4161"},
        {"Hipparcos Number", "HIP 3572"},
        {"Fundamental Katalog 5th Edition", "FK5 24"},
        {"Geneva Identification System", "GEN# +1.00004161A"},
        {"Renson", "Renson 1140"},
        {"Smithsonian Astrophysical Observation", "SAO 4216"},
        {"Wilson Evans Batten Catalogue", "WEB 632"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.41296370),
        dec: Angle.Degrees(+74.98812620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70374"},
        {"Smithsonian Astrophysical Observation", "SAO 8011"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.98108509),
        dec: Angle.Degrees(+74.99461872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209258"},
        {"Hipparcos Number", "HIP 108420"},
        {"Fundamental Katalog 5th Edition", "FK5 3758"},
        {"Geneva Identification System", "GEN# +1.00209258"},
        {"Smithsonian Astrophysical Observation", "SAO 10208"},
        {"Wilson Evans Batten Catalogue", "WEB 19526"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46277535),
        dec: Angle.Degrees(+74.99673998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110985"},
        {"Hipparcos Number", "HIP 62163"},
        {"Geneva Identification System", "GEN# +1.00110985"},
        {"Renson", "Renson 32255"},
        {"Smithsonian Astrophysical Observation", "SAO 7648"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10114682),
        dec: Angle.Degrees(+74.99786411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7556"},
        {"Hipparcos Number", "HIP 6110"},
        {"Smithsonian Astrophysical Observation", "SAO 4369"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.61284025),
        dec: Angle.Degrees(+74.99923906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208002"},
        {"Hipparcos Number", "HIP 107700"},
        {"Cincinnati Publication", "Ci 18 2846"},
        {"Geneva Identification System", "GEN# +1.00208002"},
        {"Smithsonian Astrophysical Observation", "SAO 10171"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.25397112),
        dec: Angle.Degrees(+75.00046757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35042"},
        {"Smithsonian Astrophysical Observation", "SAO 6119"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71124854),
        dec: Angle.Degrees(+75.00214202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212687"},
        {"Hipparcos Number", "HIP 110488"},
        {"Smithsonian Astrophysical Observation", "SAO 10342"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.71140292),
        dec: Angle.Degrees(+75.00484198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66074"},
        {"Geneva Identification System", "GEN# +0.07500510"},
        {"Smithsonian Astrophysical Observation", "SAO 7841"},
        {"Wilson Evans Batten Catalogue", "WEB 11678"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17503409),
        dec: Angle.Degrees(+75.00676966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -438.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197878"},
        {"Hipparcos Number", "HIP 102005"},
        {"Smithsonian Astrophysical Observation", "SAO 9845"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05811933),
        dec: Angle.Degrees(+75.00812747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186094"},
        {"Hipparcos Number", "HIP 96300"},
        {"Smithsonian Astrophysical Observation", "SAO 9476"},
    },
    visualMagnitude: 9.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.70410550),
        dec: Angle.Degrees(+75.01788667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13179"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.39663836),
        dec: Angle.Degrees(+75.02403150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181797"},
        {"Hipparcos Number", "HIP 94508"},
        {"Smithsonian Astrophysical Observation", "SAO 9359"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.52709690),
        dec: Angle.Degrees(+75.03082975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 215"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.67449039),
        dec: Angle.Degrees(+75.03619342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36384"},
        {"Hipparcos Number", "HIP 26638"},
        {"Fundamental Katalog 5th Edition", "FK5 205"},
        {"Geneva Identification System", "GEN# +1.00036384"},
        {"Smithsonian Astrophysical Observation", "SAO 5593"},
        {"Wilson Evans Batten Catalogue", "WEB 5253"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93217244),
        dec: Angle.Degrees(+75.04380982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52253"},
        {"Hipparcos Number", "HIP 34466"},
        {"Smithsonian Astrophysical Observation", "SAO 6087"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.16052550),
        dec: Angle.Degrees(+75.04744153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178275"},
        {"Hipparcos Number", "HIP 93284"},
        {"Smithsonian Astrophysical Observation", "SAO 9305"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00566213),
        dec: Angle.Degrees(+75.05685252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126565"},
        {"Hipparcos Number", "HIP 70167"},
        {"Smithsonian Astrophysical Observation", "SAO 8000"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34157472),
        dec: Angle.Degrees(+75.06085669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19286"},
        {"Hipparcos Number", "HIP 14902"},
        {"Geneva Identification System", "GEN# +1.00019286"},
        {"Smithsonian Astrophysical Observation", "SAO 4841"},
        {"Wilson Evans Batten Catalogue", "WEB 2875"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.08076467),
        dec: Angle.Degrees(+75.06576408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46744"},
        {"Hipparcos Number", "HIP 32201"},
        {"Geneva Identification System", "GEN# +1.00046744"},
        {"Smithsonian Astrophysical Observation", "SAO 5940"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.82239248),
        dec: Angle.Degrees(+75.06861850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209610"},
        {"Hipparcos Number", "HIP 108646"},
        {"Fundamental Katalog 5th Edition", "FK5 5944"},
        {"Smithsonian Astrophysical Observation", "SAO 10225"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.15271450),
        dec: Angle.Degrees(+75.07291703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48840"},
        {"Smithsonian Astrophysical Observation", "SAO 7005"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.43350252),
        dec: Angle.Degrees(+75.08452220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98183"},
        {"Hipparcos Number", "HIP 55296"},
        {"Smithsonian Astrophysical Observation", "SAO 7335"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.86309302),
        dec: Angle.Degrees(+75.08685569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55667"},
        {"Hipparcos Number", "HIP 35690"},
        {"Renson", "Renson 15134"},
        {"Smithsonian Astrophysical Observation", "SAO 6156"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.46142955),
        dec: Angle.Degrees(+75.08963038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156677"},
        {"Hipparcos Number", "HIP 84041"},
        {"Smithsonian Astrophysical Observation", "SAO 8732"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.70525000),
        dec: Angle.Degrees(+75.09776274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80930"},
        {"Hipparcos Number", "HIP 46410"},
        {"Fundamental Katalog 5th Edition", "FK5 2749"},
        {"Geneva Identification System", "GEN# +1.00080930"},
        {"Renson", "Renson 22973"},
        {"Smithsonian Astrophysical Observation", "SAO 6858"},
        {"Wilson Evans Batten Catalogue", "WEB 8770"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.96510916),
        dec: Angle.Degrees(+75.09829976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29384"},
        {"Hipparcos Number", "HIP 22127"},
        {"Wilson Evans Batten Catalogue", "WEB 4251"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.42581505),
        dec: Angle.Degrees(+75.10097728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155859"},
        {"Hipparcos Number", "HIP 83664"},
        {"Geneva Identification System", "GEN# +1.00155859"},
        {"Smithsonian Astrophysical Observation", "SAO 8714"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.50082135),
        dec: Angle.Degrees(+75.10347313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58984"},
        {"Hipparcos Number", "HIP 36956"},
        {"Smithsonian Astrophysical Observation", "SAO 6246"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.96533931),
        dec: Angle.Degrees(+75.10759962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195445"},
        {"Hipparcos Number", "HIP 100677"},
        {"Smithsonian Astrophysical Observation", "SAO 9761"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18115283),
        dec: Angle.Degrees(+75.10875204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100795"},
        {"Hipparcos Number", "HIP 56650"},
        {"Smithsonian Astrophysical Observation", "SAO 7391"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24396068),
        dec: Angle.Degrees(+75.11904223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104982"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.95049571),
        dec: Angle.Degrees(+75.13009772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28376"},
        {"Smithsonian Astrophysical Observation", "SAO 5705"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.91991753),
        dec: Angle.Degrees(+75.13309885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49868"},
        {"Geneva Identification System", "GEN# +0.07500403"},
        {"Smithsonian Astrophysical Observation", "SAO 7063"},
        {"Wilson Evans Batten Catalogue", "WEB 9182"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.74177521),
        dec: Angle.Degrees(+75.14072829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 260.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79714"},
        {"Smithsonian Astrophysical Observation", "SAO 8466"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.02507988),
        dec: Angle.Degrees(+75.14285803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18503"},
        {"Hipparcos Number", "HIP 14295"},
        {"Smithsonian Astrophysical Observation", "SAO 4804"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.07079354),
        dec: Angle.Degrees(+75.14955747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107193"},
        {"Hipparcos Number", "HIP 60044"},
        {"Fundamental Katalog 5th Edition", "FK5 2986"},
        {"Geneva Identification System", "GEN# +1.00107193"},
        {"Smithsonian Astrophysical Observation", "SAO 7540"},
        {"Wilson Evans Batten Catalogue", "WEB 10672"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.70860512),
        dec: Angle.Degrees(+75.16055020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216367"},
        {"Hipparcos Number", "HIP 112738"},
        {"Smithsonian Astrophysical Observation", "SAO 10514"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.47748522),
        dec: Angle.Degrees(+75.16227222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49874"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.75671231),
        dec: Angle.Degrees(+75.16234758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164780"},
        {"Hipparcos Number", "HIP 87670"},
        {"Geneva Identification System", "GEN# +1.00164780"},
        {"Smithsonian Astrophysical Observation", "SAO 8962"},
        {"Wilson Evans Batten Catalogue", "WEB 14797"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61144130),
        dec: Angle.Degrees(+75.17121497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25173"},
        {"Hipparcos Number", "HIP 19237"},
        {"Geneva Identification System", "GEN# +1.00025173"},
        {"Smithsonian Astrophysical Observation", "SAO 5087"},
        {"Wilson Evans Batten Catalogue", "WEB 3692"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.84850943),
        dec: Angle.Degrees(+75.17579040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89228"},
        {"Smithsonian Astrophysical Observation", "SAO 9051"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.12682576),
        dec: Angle.Degrees(+75.17683486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71657"},
        {"Hipparcos Number", "HIP 42135"},
        {"Geneva Identification System", "GEN# +1.00071657"},
        {"Smithsonian Astrophysical Observation", "SAO 6581"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.83596108),
        dec: Angle.Degrees(+75.17970929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75642"},
        {"Smithsonian Astrophysical Observation", "SAO 8255"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.81318492),
        dec: Angle.Degrees(+75.18090268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114632"},
        {"Hipparcos Number", "HIP 64183"},
        {"Geneva Identification System", "GEN# +1.00114632"},
        {"Smithsonian Astrophysical Observation", "SAO 7762"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.31551400),
        dec: Angle.Degrees(+75.18162120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84136"},
        {"Smithsonian Astrophysical Observation", "SAO 8738"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.02400980),
        dec: Angle.Degrees(+75.18845217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53079"},
        {"Smithsonian Astrophysical Observation", "SAO 7220"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.88883056),
        dec: Angle.Degrees(+75.19108203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54508"},
        {"Hipparcos Number", "HIP 35270"},
        {"Geneva Identification System", "GEN# +1.00054508"},
        {"Smithsonian Astrophysical Observation", "SAO 6128"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.30411716),
        dec: Angle.Degrees(+75.19533721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88637"},
        {"Hipparcos Number", "HIP 50386"},
        {"Geneva Identification System", "GEN# +1.00088637"},
        {"Smithsonian Astrophysical Observation", "SAO 7093"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.31375473),
        dec: Angle.Degrees(+75.19540961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33940"},
        {"Hipparcos Number", "HIP 25071"},
        {"Geneva Identification System", "GEN# +1.00033940"},
        {"Smithsonian Astrophysical Observation", "SAO 5503"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.51585803),
        dec: Angle.Degrees(+75.19555474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49801"},
        {"Hipparcos Number", "HIP 33563"},
        {"Geneva Identification System", "GEN# +1.00049801"},
        {"Smithsonian Astrophysical Observation", "SAO 6017"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61243194),
        dec: Angle.Degrees(+75.19811743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104449"},
        {"Hipparcos Number", "HIP 58666"},
        {"Geneva Identification System", "GEN# +1.00104449"},
        {"Smithsonian Astrophysical Observation", "SAO 7486"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43860871),
        dec: Angle.Degrees(+75.19851435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7405"},
        {"Hipparcos Number", "HIP 5976"},
        {"Smithsonian Astrophysical Observation", "SAO 4362"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.19926347),
        dec: Angle.Degrees(+75.20062062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17705"},
        {"Hipparcos Number", "HIP 13683"},
        {"Geneva Identification System", "GEN# +1.00017705"},
        {"Smithsonian Astrophysical Observation", "SAO 4768"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.06290380),
        dec: Angle.Degrees(+75.20246926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82701"},
        {"Hipparcos Number", "HIP 47330"},
        {"Smithsonian Astrophysical Observation", "SAO 6917"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.67475414),
        dec: Angle.Degrees(+75.20543340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147142"},
        {"Hipparcos Number", "HIP 79420"},
        {"Geneva Identification System", "GEN# +1.00147142"},
        {"Smithsonian Astrophysical Observation", "SAO 8452"},
        {"Wilson Evans Batten Catalogue", "WEB 13432"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.13415319),
        dec: Angle.Degrees(+75.21059442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109460"},
        {"Hipparcos Number", "HIP 61315"},
        {"Smithsonian Astrophysical Observation", "SAO 7596"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.42835648),
        dec: Angle.Degrees(+75.21248883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85947"},
        {"Smithsonian Astrophysical Observation", "SAO 8849"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.48872926),
        dec: Angle.Degrees(+75.21737533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11945"},
        {"Hipparcos Number", "HIP 9446"},
        {"Smithsonian Astrophysical Observation", "SAO 4546"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.34979256),
        dec: Angle.Degrees(+75.22187435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15180 AB"},
        {"Henry Draper", "HD 206460"},
        {"Hipparcos Number", "HIP 106748"},
        {"Smithsonian Astrophysical Observation", "SAO 10108"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.35560032),
        dec: Angle.Degrees(+75.22206228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154955"},
        {"Hipparcos Number", "HIP 83218"},
        {"Geneva Identification System", "GEN# +1.00154955"},
        {"Smithsonian Astrophysical Observation", "SAO 8690"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11501281),
        dec: Angle.Degrees(+75.22525905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221215"},
        {"Hipparcos Number", "HIP 115902"},
        {"Geneva Identification System", "GEN# +1.00221215"},
        {"Smithsonian Astrophysical Observation", "SAO 10754"},
        {"Wilson Evans Batten Catalogue", "WEB 20500"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.24027466),
        dec: Angle.Degrees(+75.22543126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202345"},
        {"Hipparcos Number", "HIP 104458"},
        {"Fundamental Katalog 5th Edition", "FK5 5865"},
        {"Geneva Identification System", "GEN# +1.00202345"},
        {"Smithsonian Astrophysical Observation", "SAO 9975"},
        {"Wilson Evans Batten Catalogue", "WEB 19017"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39694851),
        dec: Angle.Degrees(+75.22782000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34085",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5669 A"},
        {"Henry Draper", "HD 51067"},
        {"Hipparcos Number", "HIP 34085"},
        {"Geneva Identification System", "GEN# +1.00051067A"},
        {"Smithsonian Astrophysical Observation", "SAO 6050"},
        {"Wilson Evans Batten Catalogue", "WEB 6833"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01723364),
        dec: Angle.Degrees(+75.22815779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5669 B"},
        {"Henry Draper", "HD 51067B"},
        {"Hipparcos Number", "HIP 34087"},
        {"Geneva Identification System", "GEN# +1.00051067B"},
        {"Smithsonian Astrophysical Observation", "SAO 6052"},
        {"Wilson Evans Batten Catalogue", "WEB 6837"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.02447191),
        dec: Angle.Degrees(+75.23115499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80353"},
        {"Hipparcos Number", "HIP 46158"},
        {"Smithsonian Astrophysical Observation", "SAO 6843"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.20013313),
        dec: Angle.Degrees(+75.23317762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219382"},
        {"Hipparcos Number", "HIP 114662"},
        {"Smithsonian Astrophysical Observation", "SAO 10657"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.41334273),
        dec: Angle.Degrees(+75.23600220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1558"},
        {"Smithsonian Astrophysical Observation", "SAO 4088"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84708518),
        dec: Angle.Degrees(+75.23691742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20085"},
        {"Hipparcos Number", "HIP 15516"},
        {"Smithsonian Astrophysical Observation", "SAO 4878"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.98694295),
        dec: Angle.Degrees(+75.23755609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2520"},
        {"Hipparcos Number", "HIP 2352"},
        {"Geneva Identification System", "GEN# +1.00002520"},
        {"Smithsonian Astrophysical Observation", "SAO 4127"},
        {"Wilson Evans Batten Catalogue", "WEB 428"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.50728307),
        dec: Angle.Degrees(+75.24285940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195351"},
        {"Hipparcos Number", "HIP 100605"},
        {"Smithsonian Astrophysical Observation", "SAO 9757"},
        {"Wilson Evans Batten Catalogue", "WEB 18184"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.01489689),
        dec: Angle.Degrees(+75.25373035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21026"},
        {"Hipparcos Number", "HIP 16297"},
        {"Smithsonian Astrophysical Observation", "SAO 4912"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.52574292),
        dec: Angle.Degrees(+75.25914161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136918"},
        {"Hipparcos Number", "HIP 74763"},
        {"Geneva Identification System", "GEN# +1.00136918"},
        {"Smithsonian Astrophysical Observation", "SAO 8210"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.19620072),
        dec: Angle.Degrees(+75.25934217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73481"},
        {"Smithsonian Astrophysical Observation", "SAO 8146"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25715695),
        dec: Angle.Degrees(+75.26214089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197617"},
        {"Hipparcos Number", "HIP 101863"},
        {"Smithsonian Astrophysical Observation", "SAO 9837"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.62161114),
        dec: Angle.Degrees(+75.26245272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76688"},
        {"Smithsonian Astrophysical Observation", "SAO 8311"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.89990709),
        dec: Angle.Degrees(+75.27290857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128525"},
        {"Hipparcos Number", "HIP 71069"},
        {"Smithsonian Astrophysical Observation", "SAO 8045"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00816919),
        dec: Angle.Degrees(+75.27685795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78374"},
        {"Hipparcos Number", "HIP 45291"},
        {"Geneva Identification System", "GEN# +1.00078374"},
        {"Smithsonian Astrophysical Observation", "SAO 6778"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.45208118),
        dec: Angle.Degrees(+75.27932732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222386"},
        {"Hipparcos Number", "HIP 116714"},
        {"Geneva Identification System", "GEN# +1.00222386"},
        {"Smithsonian Astrophysical Observation", "SAO 10814"},
        {"Wilson Evans Batten Catalogue", "WEB 20597"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.79233254),
        dec: Angle.Degrees(+75.29284842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21990"},
        {"Hipparcos Number", "HIP 17064"},
        {"Smithsonian Astrophysical Observation", "SAO 4955"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.86835133),
        dec: Angle.Degrees(+75.29487645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155154"},
        {"Hipparcos Number", "HIP 83317"},
        {"Geneva Identification System", "GEN# +1.00155154"},
        {"Smithsonian Astrophysical Observation", "SAO 8697"},
        {"Wilson Evans Batten Catalogue", "WEB 14082"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.41700268),
        dec: Angle.Degrees(+75.29766654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219841"},
        {"Hipparcos Number", "HIP 114984"},
        {"Fundamental Katalog 5th Edition", "FK5 3865"},
        {"Geneva Identification System", "GEN# +1.00219841"},
        {"Smithsonian Astrophysical Observation", "SAO 10684"},
        {"Wilson Evans Batten Catalogue", "WEB 20371"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.32856740),
        dec: Angle.Degrees(+75.29903267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174257"},
        {"Hipparcos Number", "HIP 91656"},
        {"Geneva Identification System", "GEN# +1.00174257"},
        {"Smithsonian Astrophysical Observation", "SAO 9215"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.36161200),
        dec: Angle.Degrees(+75.29956231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93119"},
        {"Geneva Identification System", "GEN# +6.20030191J"},
        {"Smithsonian Astrophysical Observation", "SAO 9292"},
        {"Wilson Evans Batten Catalogue", "WEB 16134"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.54772312),
        dec: Angle.Degrees(+75.30183935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188251"},
        {"Hipparcos Number", "HIP 97328"},
        {"Renson", "Renson 52000"},
        {"Smithsonian Astrophysical Observation", "SAO 9538"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.70672714),
        dec: Angle.Degrees(+75.30381978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38389"},
        {"Smithsonian Astrophysical Observation", "SAO 6326"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.95684970),
        dec: Angle.Degrees(+75.32089328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36495"},
        {"Hipparcos Number", "HIP 26702"},
        {"Smithsonian Astrophysical Observation", "SAO 5599"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12582295),
        dec: Angle.Degrees(+75.32781235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187687"},
        {"Hipparcos Number", "HIP 97074"},
        {"Smithsonian Astrophysical Observation", "SAO 9524"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.92001293),
        dec: Angle.Degrees(+75.32899929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185731"},
        {"Hipparcos Number", "HIP 96137"},
        {"Smithsonian Astrophysical Observation", "SAO 9461"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.21741963),
        dec: Angle.Degrees(+75.33103964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36633",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6103 AB"},
        {"Henry Draper", "HD 58070"},
        {"Hipparcos Number", "HIP 36633"},
        {"Smithsonian Astrophysical Observation", "SAO 6214"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.00800242),
        dec: Angle.Degrees(+75.33350677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27623"},
        {"Hipparcos Number", "HIP 20928"},
        {"Renson", "Renson 7070"},
        {"Smithsonian Astrophysical Observation", "SAO 5206"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.31051904),
        dec: Angle.Degrees(+75.33374620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11588"},
        {"Hipparcos Number", "HIP 9147"},
        {"Geneva Identification System", "GEN# +1.00011588"},
        {"Smithsonian Astrophysical Observation", "SAO 4524"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.47109538),
        dec: Angle.Degrees(+75.33613755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58903"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19168316),
        dec: Angle.Degrees(+75.34934090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97853"},
        {"Hipparcos Number", "HIP 55123"},
        {"Smithsonian Astrophysical Observation", "SAO 7327"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.29053690),
        dec: Angle.Degrees(+75.35317698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209841"},
        {"Hipparcos Number", "HIP 108783"},
        {"Geneva Identification System", "GEN# +1.00209841"},
        {"Smithsonian Astrophysical Observation", "SAO 10230"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.54523393),
        dec: Angle.Degrees(+75.35512625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29664"},
        {"Smithsonian Astrophysical Observation", "SAO 5781"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.74039883),
        dec: Angle.Degrees(+75.35598581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102855"},
        {"Hipparcos Number", "HIP 57781"},
        {"Geneva Identification System", "GEN# +1.00102855"},
        {"Smithsonian Astrophysical Observation", "SAO 7434"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.73214695),
        dec: Angle.Degrees(+75.35609436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110611"},
        {"Hipparcos Number", "HIP 61962"},
        {"Smithsonian Astrophysical Observation", "SAO 7635"},
        {"Wilson Evans Batten Catalogue", "WEB 11019"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.47263459),
        dec: Angle.Degrees(+75.35618323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24194"},
        {"Smithsonian Astrophysical Observation", "SAO 5449"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.91698038),
        dec: Angle.Degrees(+75.35945116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67018"},
        {"Smithsonian Astrophysical Observation", "SAO 7877"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.02033030),
        dec: Angle.Degrees(+75.36157984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214710"},
        {"Hipparcos Number", "HIP 111660"},
        {"Geneva Identification System", "GEN# +1.00214710"},
        {"Smithsonian Astrophysical Observation", "SAO 10440"},
        {"Wilson Evans Batten Catalogue", "WEB 19957"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.30359577),
        dec: Angle.Degrees(+75.37179180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153143"},
        {"Hipparcos Number", "HIP 82345"},
        {"Geneva Identification System", "GEN# +1.00153143"},
        {"Smithsonian Astrophysical Observation", "SAO 8636"},
        {"Wilson Evans Batten Catalogue", "WEB 13900"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.38239953),
        dec: Angle.Degrees(+75.37918520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15843"},
        {"Hipparcos Number", "HIP 12277"},
        {"Geneva Identification System", "GEN# +1.00015843"},
        {"Smithsonian Astrophysical Observation", "SAO 4692"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.54103316),
        dec: Angle.Degrees(+75.38140619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16538 AB"},
        {"Henry Draper", "HD 218658"},
        {"Hipparcos Number", "HIP 114222"},
        {"Geneva Identification System", "GEN# +1.00218658J"},
        {"Smithsonian Astrophysical Observation", "SAO 10629"},
        {"Wilson Evans Batten Catalogue", "WEB 20286"},
    },
    visualMagnitude: 4.41,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.97432546),
        dec: Angle.Degrees(+75.38758150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153720"},
        {"Hipparcos Number", "HIP 82580"},
        {"Fundamental Katalog 5th Edition", "FK5 5491"},
        {"Geneva Identification System", "GEN# +1.00153720"},
        {"Renson", "Renson 43405"},
        {"Smithsonian Astrophysical Observation", "SAO 8651"},
        {"Wilson Evans Batten Catalogue", "WEB 13943"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.22976653),
        dec: Angle.Degrees(+75.39283020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22155"},
        {"Hipparcos Number", "HIP 17213"},
        {"Geneva Identification System", "GEN# +1.00022155"},
        {"Smithsonian Astrophysical Observation", "SAO 4961"},
        {"Wilson Evans Batten Catalogue", "WEB 3258"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.30624105),
        dec: Angle.Degrees(+75.39936585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60764"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.83197943),
        dec: Angle.Degrees(+75.40353459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193591"},
        {"Hipparcos Number", "HIP 99707"},
        {"Smithsonian Astrophysical Observation", "SAO 9693"},
        {"Wilson Evans Batten Catalogue", "WEB 17889"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.49490252),
        dec: Angle.Degrees(+75.40383159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69561"},
        {"Smithsonian Astrophysical Observation", "SAO 7971"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58452523),
        dec: Angle.Degrees(+75.40809155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12959",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2087 A"},
        {"Henry Draper", "HD 16758"},
        {"Hipparcos Number", "HIP 12959"},
        {"Smithsonian Astrophysical Observation", "SAO 4723"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.66754270),
        dec: Angle.Degrees(+75.40809851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112371"},
        {"Hipparcos Number", "HIP 62975"},
        {"Smithsonian Astrophysical Observation", "SAO 7695"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.56047245),
        dec: Angle.Degrees(+75.40929477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51066"},
        {"Hipparcos Number", "HIP 34101"},
        {"Geneva Identification System", "GEN# +1.00051066"},
        {"Smithsonian Astrophysical Observation", "SAO 6053"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.06277974),
        dec: Angle.Degrees(+75.41129168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76115"},
        {"Hipparcos Number", "HIP 44235"},
        {"Geneva Identification System", "GEN# +1.00076115"},
        {"Smithsonian Astrophysical Observation", "SAO 6706"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13634658),
        dec: Angle.Degrees(+75.42914953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83035"},
        {"Hipparcos Number", "HIP 47492"},
        {"Smithsonian Astrophysical Observation", "SAO 6928"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.21632563),
        dec: Angle.Degrees(+75.43067455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175286"},
        {"Hipparcos Number", "HIP 92112"},
        {"Fundamental Katalog 5th Edition", "FK5 1494"},
        {"Geneva Identification System", "GEN# +1.00175286"},
        {"Smithsonian Astrophysical Observation", "SAO 9250"},
        {"Wilson Evans Batten Catalogue", "WEB 15877"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.59276611),
        dec: Angle.Degrees(+75.43379735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106503"},
        {"Smithsonian Astrophysical Observation", "SAO 10094"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.57681745),
        dec: Angle.Degrees(+75.43485823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112088"},
        {"Fundamental Katalog 5th Edition", "FK5 6000"},
        {"Smithsonian Astrophysical Observation", "SAO 10473"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.54278989),
        dec: Angle.Degrees(+75.43641463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95463"},
        {"Hipparcos Number", "HIP 54039"},
        {"Smithsonian Astrophysical Observation", "SAO 7271"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.86658262),
        dec: Angle.Degrees(+75.44118820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88529"},
        {"Hipparcos Number", "HIP 50326"},
        {"Smithsonian Astrophysical Observation", "SAO 7091"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16130069),
        dec: Angle.Degrees(+75.44560040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64487"},
        {"Hipparcos Number", "HIP 39273"},
        {"Geneva Identification System", "GEN# +1.00064487"},
        {"Smithsonian Astrophysical Observation", "SAO 6384"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.46413480),
        dec: Angle.Degrees(+75.45021406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27103"},
        {"Hipparcos Number", "HIP 20584"},
        {"Geneva Identification System", "GEN# +1.00027103"},
        {"Smithsonian Astrophysical Observation", "SAO 5184"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.13470582),
        dec: Angle.Degrees(+75.46505249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6899"},
        {"Hipparcos Number", "HIP 5615"},
        {"Smithsonian Astrophysical Observation", "SAO 4342"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.01503235),
        dec: Angle.Degrees(+75.46889855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136200"},
        {"Hipparcos Number", "HIP 74451"},
        {"Smithsonian Astrophysical Observation", "SAO 8196"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.21218166),
        dec: Angle.Degrees(+75.47114664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113049"},
        {"Hipparcos Number", "HIP 63340"},
        {"Fundamental Katalog 5th Edition", "FK5 3037"},
        {"Geneva Identification System", "GEN# +1.00113049"},
        {"Smithsonian Astrophysical Observation", "SAO 7714"},
        {"Wilson Evans Batten Catalogue", "WEB 11217"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.69709590),
        dec: Angle.Degrees(+75.47247502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57002"},
        {"Smithsonian Astrophysical Observation", "SAO 7413"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.28854705),
        dec: Angle.Degrees(+75.47265989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53732"},
        {"Smithsonian Astrophysical Observation", "SAO 7253"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.89583829),
        dec: Angle.Degrees(+75.47474713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32231"},
        {"Hipparcos Number", "HIP 24027"},
        {"Geneva Identification System", "GEN# +1.00032231"},
        {"Smithsonian Astrophysical Observation", "SAO 5439"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.45642870),
        dec: Angle.Degrees(+75.48097499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45906"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.40147969),
        dec: Angle.Degrees(+75.49022996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5407"},
        {"Hipparcos Number", "HIP 4519"},
        {"Smithsonian Astrophysical Observation", "SAO 4275"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47614531),
        dec: Angle.Degrees(+75.49389094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9494",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1588 AB"},
        {"Henry Draper", "HD 12013"},
        {"Hipparcos Number", "HIP 9494"},
        {"Smithsonian Astrophysical Observation", "SAO 4550"},
        {"Wilson Evans Batten Catalogue", "WEB 1989"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.53862187),
        dec: Angle.Degrees(+75.50219029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173269"},
        {"Hipparcos Number", "HIP 91175"},
        {"Geneva Identification System", "GEN# +1.00173269"},
        {"Smithsonian Astrophysical Observation", "SAO 9188"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.00494883),
        dec: Angle.Degrees(+75.50667894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118273"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.85245972),
        dec: Angle.Degrees(+75.50892310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37381"},
        {"Hipparcos Number", "HIP 27285"},
        {"Smithsonian Astrophysical Observation", "SAO 5642"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.73439151),
        dec: Angle.Degrees(+75.51277747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218219"},
        {"Hipparcos Number", "HIP 113928"},
        {"Geneva Identification System", "GEN# +1.00218219"},
        {"Smithsonian Astrophysical Observation", "SAO 10611"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.06619124),
        dec: Angle.Degrees(+75.51719822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15842"},
        {"Hipparcos Number", "HIP 12276"},
        {"Smithsonian Astrophysical Observation", "SAO 4691"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.54032272),
        dec: Angle.Degrees(+75.52797126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3199"},
        {"Hipparcos Number", "HIP 2882"},
        {"Smithsonian Astrophysical Observation", "SAO 4157"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.13534390),
        dec: Angle.Degrees(+75.53051581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47540"},
        {"Smithsonian Astrophysical Observation", "SAO 6930"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.39191940),
        dec: Angle.Degrees(+75.53521523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162465"},
        {"Hipparcos Number", "HIP 86680"},
        {"Smithsonian Astrophysical Observation", "SAO 8896"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.65693066),
        dec: Angle.Degrees(+75.53933246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17062 A"},
        {"Henry Draper", "HD 223778"},
        {"Hipparcos Number", "HIP 117712"},
        {"Geneva Identification System", "GEN# +1.00223778"},
        {"Smithsonian Astrophysical Observation", "SAO 10879"},
        {"Wilson Evans Batten Catalogue", "WEB 20714"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.10217080),
        dec: Angle.Degrees(+75.54448646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170507"},
        {"Hipparcos Number", "HIP 89958"},
        {"Fundamental Katalog 5th Edition", "FK5 5615"},
        {"Smithsonian Astrophysical Observation", "SAO 9095"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.31405571),
        dec: Angle.Degrees(+75.54881699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31272"},
        {"Smithsonian Astrophysical Observation", "SAO 5883"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36860808),
        dec: Angle.Degrees(+75.55149433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9909"},
        {"Hipparcos Number", "HIP 7795"},
        {"Geneva Identification System", "GEN# +1.00009909"},
        {"Smithsonian Astrophysical Observation", "SAO 4459"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.07833891),
        dec: Angle.Degrees(+75.55320560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66337"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.92831807),
        dec: Angle.Degrees(+75.55453372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60405"},
        {"Hipparcos Number", "HIP 37538"},
        {"Geneva Identification System", "GEN# +1.00060405"},
        {"Smithsonian Astrophysical Observation", "SAO 6273"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.56216223),
        dec: Angle.Degrees(+75.56440305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121128"},
        {"Hipparcos Number", "HIP 67467"},
        {"Geneva Identification System", "GEN# +1.00121128"},
        {"Renson", "Renson 34850"},
        {"Smithsonian Astrophysical Observation", "SAO 7888"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.38612026),
        dec: Angle.Degrees(+75.56702211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112558"},
        {"Hipparcos Number", "HIP 63094"},
        {"Smithsonian Astrophysical Observation", "SAO 7704"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.91180837),
        dec: Angle.Degrees(+75.56889258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143803"},
        {"Hipparcos Number", "HIP 77942"},
        {"Geneva Identification System", "GEN# +1.00143803"},
        {"Smithsonian Astrophysical Observation", "SAO 8376"},
        {"Wilson Evans Batten Catalogue", "WEB 13180"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.75441109),
        dec: Angle.Degrees(+75.57431593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115920"},
        {"Smithsonian Astrophysical Observation", "SAO 10756"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.29433999),
        dec: Angle.Degrees(+75.57451126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218466"},
        {"Hipparcos Number", "HIP 114078"},
        {"Geneva Identification System", "GEN# +1.00218466"},
        {"Smithsonian Astrophysical Observation", "SAO 10620"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.56936444),
        dec: Angle.Degrees(+75.58139673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222598"},
        {"Hipparcos Number", "HIP 116858"},
        {"Smithsonian Astrophysical Observation", "SAO 10836"},
        {"Wilson Evans Batten Catalogue", "WEB 20617"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.30636502),
        dec: Angle.Degrees(+75.58262162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120770"},
        {"Hipparcos Number", "HIP 67293"},
        {"Geneva Identification System", "GEN# +1.00120770"},
        {"Smithsonian Astrophysical Observation", "SAO 7882"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.86556847),
        dec: Angle.Degrees(+75.58553010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40055"},
        {"Hipparcos Number", "HIP 28831"},
        {"Fundamental Katalog 5th Edition", "FK5 2459"},
        {"Smithsonian Astrophysical Observation", "SAO 5730"},
        {"Wilson Evans Batten Catalogue", "WEB 5643"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.28883455),
        dec: Angle.Degrees(+75.58594336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108467"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.59989019),
        dec: Angle.Degrees(+75.58900273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10971"},
        {"Hipparcos Number", "HIP 8690"},
        {"Geneva Identification System", "GEN# +1.00010971"},
        {"Smithsonian Astrophysical Observation", "SAO 4503"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.94940577),
        dec: Angle.Degrees(+75.58970467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172710"},
        {"Hipparcos Number", "HIP 90952"},
        {"Smithsonian Astrophysical Observation", "SAO 9167"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.30590395),
        dec: Angle.Degrees(+75.59101941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197433"},
        {"Hipparcos Number", "HIP 101750"},
        {"Cincinnati Publication", "Ci 18 2685"},
        {"Cincinnati Publication 2", "Ci 20 1222"},
        {"Geneva Identification System", "GEN# +1.00197433"},
        {"Smithsonian Astrophysical Observation", "SAO 9828"},
        {"Wilson Evans Batten Catalogue", "WEB 18377"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.33674846),
        dec: Angle.Degrees(+75.59909315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 309.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 539.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4683"},
        {"Hipparcos Number", "HIP 3941"},
        {"Smithsonian Astrophysical Observation", "SAO 4246"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.64939897),
        dec: Angle.Degrees(+75.60228159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185779"},
        {"Hipparcos Number", "HIP 96149"},
        {"Smithsonian Astrophysical Observation", "SAO 9462"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.24292130),
        dec: Angle.Degrees(+75.60834842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77657"},
        {"Hipparcos Number", "HIP 45012"},
        {"Smithsonian Astrophysical Observation", "SAO 6761"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.52333926),
        dec: Angle.Degrees(+75.61090238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56863"},
        {"Hipparcos Number", "HIP 36159"},
        {"Smithsonian Astrophysical Observation", "SAO 6184"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.73984875),
        dec: Angle.Degrees(+75.61223741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201373"},
        {"Hipparcos Number", "HIP 103908"},
        {"Geneva Identification System", "GEN# +1.00201373"},
        {"Smithsonian Astrophysical Observation", "SAO 9946"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.80559577),
        dec: Angle.Degrees(+75.62070602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143684"},
        {"Hipparcos Number", "HIP 77889"},
        {"Geneva Identification System", "GEN# +1.00143684"},
        {"Smithsonian Astrophysical Observation", "SAO 8369"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60248787),
        dec: Angle.Degrees(+75.63228347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160076"},
        {"Hipparcos Number", "HIP 85585"},
        {"Geneva Identification System", "GEN# +1.00160076"},
        {"Smithsonian Astrophysical Observation", "SAO 8824"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.34264960),
        dec: Angle.Degrees(+75.63756012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43940"},
        {"Smithsonian Astrophysical Observation", "SAO 6686"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.24918039),
        dec: Angle.Degrees(+75.63967128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87997"},
        {"Smithsonian Astrophysical Observation", "SAO 8973"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.62063813),
        dec: Angle.Degrees(+75.64039457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17695"},
        {"Hipparcos Number", "HIP 13686"},
        {"Geneva Identification System", "GEN# +1.00017695"},
        {"Smithsonian Astrophysical Observation", "SAO 4767"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.06906776),
        dec: Angle.Degrees(+75.65205140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100234"},
        {"Hipparcos Number", "HIP 56358"},
        {"Smithsonian Astrophysical Observation", "SAO 7375"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.28925608),
        dec: Angle.Degrees(+75.65244087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43243"},
        {"Hipparcos Number", "HIP 30442"},
        {"Geneva Identification System", "GEN# +1.00043243"},
        {"Smithsonian Astrophysical Observation", "SAO 5827"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.99826751),
        dec: Angle.Degrees(+75.65606259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215038"},
        {"Hipparcos Number", "HIP 111849"},
        {"Geneva Identification System", "GEN# +1.00215038"},
        {"Renson", "Renson 59450"},
        {"Smithsonian Astrophysical Observation", "SAO 10449"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.84533066),
        dec: Angle.Degrees(+75.65762573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34148"},
        {"Smithsonian Astrophysical Observation", "SAO 6055"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.21235746),
        dec: Angle.Degrees(+75.66645072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126125"},
        {"Hipparcos Number", "HIP 69925"},
        {"Smithsonian Astrophysical Observation", "SAO 7991"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.65381251),
        dec: Angle.Degrees(+75.66887136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89704"},
        {"Hipparcos Number", "HIP 50980"},
        {"Smithsonian Astrophysical Observation", "SAO 7131"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.20343109),
        dec: Angle.Degrees(+75.67586703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79987"},
        {"Hipparcos Number", "HIP 45987"},
        {"Smithsonian Astrophysical Observation", "SAO 6831"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.68043442),
        dec: Angle.Degrees(+75.68129985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3681 A"},
        {"Henry Draper", "HD 32230"},
        {"Hipparcos Number", "HIP 24036"},
        {"Smithsonian Astrophysical Observation", "SAO 5442"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.50546844),
        dec: Angle.Degrees(+75.68194730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76703"},
        {"Hipparcos Number", "HIP 44514"},
        {"Geneva Identification System", "GEN# +1.00076703"},
        {"Smithsonian Astrophysical Observation", "SAO 6725"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.04952270),
        dec: Angle.Degrees(+75.68435012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9286 A"},
        {"Henry Draper", "HD 127700"},
        {"Hipparcos Number", "HIP 70692"},
        {"Fundamental Katalog 5th Edition", "FK5 1379"},
        {"Geneva Identification System", "GEN# +1.00127700"},
        {"Smithsonian Astrophysical Observation", "SAO 8024"},
        {"Wilson Evans Batten Catalogue", "WEB 12249"},
    },
    visualMagnitude: 4.25,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.88134383),
        dec: Angle.Degrees(+75.69593921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32123"},
        {"Smithsonian Astrophysical Observation", "SAO 5933"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64286389),
        dec: Angle.Degrees(+75.69838426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45875"},
        {"Hipparcos Number", "HIP 31783"},
        {"Geneva Identification System", "GEN# +1.00045875"},
        {"Smithsonian Astrophysical Observation", "SAO 5913"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.67966245),
        dec: Angle.Degrees(+75.70707706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30097"},
        {"Hipparcos Number", "HIP 22703"},
        {"Geneva Identification System", "GEN# +1.00030097"},
        {"Smithsonian Astrophysical Observation", "SAO 5335"},
        {"Wilson Evans Batten Catalogue", "WEB 4389"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.23241854),
        dec: Angle.Degrees(+75.71052058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91190"},
        {"Hipparcos Number", "HIP 51808"},
        {"Fundamental Katalog 5th Edition", "FK5 395"},
        {"Geneva Identification System", "GEN# +1.00091190"},
        {"Smithsonian Astrophysical Observation", "SAO 7164"},
        {"Wilson Evans Batten Catalogue", "WEB 9439"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.77328496),
        dec: Angle.Degrees(+75.71298403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190315"},
        {"Hipparcos Number", "HIP 98166"},
        {"Smithsonian Astrophysical Observation", "SAO 9586"},
        {"Wilson Evans Batten Catalogue", "WEB 17306"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.24386505),
        dec: Angle.Degrees(+75.71386077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37879"},
        {"Hipparcos Number", "HIP 27576"},
        {"Geneva Identification System", "GEN# +1.00037879"},
        {"Smithsonian Astrophysical Observation", "SAO 5665"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.61140094),
        dec: Angle.Degrees(+75.71468676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108379"},
        {"Hipparcos Number", "HIP 60685"},
        {"Smithsonian Astrophysical Observation", "SAO 7562"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.55346493),
        dec: Angle.Degrees(+75.71912971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200251"},
        {"Hipparcos Number", "HIP 103342"},
        {"Smithsonian Astrophysical Observation", "SAO 9917"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.04990641),
        dec: Angle.Degrees(+75.71972126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94791"},
        {"Hipparcos Number", "HIP 53683"},
        {"Geneva Identification System", "GEN# +1.00094791"},
        {"Smithsonian Astrophysical Observation", "SAO 7247"},
        {"Wilson Evans Batten Catalogue", "WEB 9726"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.75832203),
        dec: Angle.Degrees(+75.72132499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82496"},
        {"Smithsonian Astrophysical Observation", "SAO 8644"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.90102759),
        dec: Angle.Degrees(+75.72168003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71067"},
        {"Hipparcos Number", "HIP 41892"},
        {"Geneva Identification System", "GEN# +1.00071067"},
        {"Smithsonian Astrophysical Observation", "SAO 6565"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.13588522),
        dec: Angle.Degrees(+75.73875756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21970"},
        {"Hipparcos Number", "HIP 17056"},
        {"Geneva Identification System", "GEN# +1.00021970"},
        {"Smithsonian Astrophysical Observation", "SAO 4953"},
        {"Wilson Evans Batten Catalogue", "WEB 3241"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85456402),
        dec: Angle.Degrees(+75.73960152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11771"},
        {"Smithsonian Astrophysical Observation", "SAO 4664"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.97654974),
        dec: Angle.Degrees(+75.74050048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67707"},
        {"Hipparcos Number", "HIP 40549"},
        {"Geneva Identification System", "GEN# +1.00067707"},
        {"Smithsonian Astrophysical Observation", "SAO 6472"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.19990214),
        dec: Angle.Degrees(+75.74319380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21671"},
        {"Hipparcos Number", "HIP 16836"},
        {"Smithsonian Astrophysical Observation", "SAO 4939"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.17452111),
        dec: Angle.Degrees(+75.74341661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96429"},
        {"Smithsonian Astrophysical Observation", "SAO 9482"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.06706013),
        dec: Angle.Degrees(+75.74675155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222448"},
        {"Hipparcos Number", "HIP 116760"},
        {"Geneva Identification System", "GEN# +1.00222448"},
        {"Smithsonian Astrophysical Observation", "SAO 10822"},
        {"Wilson Evans Batten Catalogue", "WEB 20602"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.95341527),
        dec: Angle.Degrees(+75.75161628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148048"},
        {"Hipparcos Number", "HIP 79822"},
        {"Fundamental Katalog 5th Edition", "FK5 612"},
        {"Geneva Identification System", "GEN# +1.00148048"},
        {"Smithsonian Astrophysical Observation", "SAO 8470"},
        {"Wilson Evans Batten Catalogue", "WEB 13514"},
    },
    visualMagnitude: 4.95,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.37708768),
        dec: Angle.Degrees(+75.75470385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 257.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143703"},
        {"Hipparcos Number", "HIP 77885"},
        {"Smithsonian Astrophysical Observation", "SAO 8371"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.59659445),
        dec: Angle.Degrees(+75.75493188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199232"},
        {"Hipparcos Number", "HIP 102787"},
        {"Smithsonian Astrophysical Observation", "SAO 9892"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.36862648),
        dec: Angle.Degrees(+75.75603875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68375"},
        {"Hipparcos Number", "HIP 40793"},
        {"Fundamental Katalog 5th Edition", "FK5 310"},
        {"Geneva Identification System", "GEN# +1.00068375"},
        {"Smithsonian Astrophysical Observation", "SAO 6487"},
        {"Wilson Evans Batten Catalogue", "WEB 7916"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.88421821),
        dec: Angle.Degrees(+75.75686931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223484"},
        {"Hipparcos Number", "HIP 117490"},
        {"Smithsonian Astrophysical Observation", "SAO 10866"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.35985975),
        dec: Angle.Degrees(+75.76278974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127983"},
        {"Hipparcos Number", "HIP 70825"},
        {"Smithsonian Astrophysical Observation", "SAO 8029"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.25525631),
        dec: Angle.Degrees(+75.76608682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23037"},
        {"Hipparcos Number", "HIP 17849"},
        {"Geneva Identification System", "GEN# +1.00023037"},
        {"Smithsonian Astrophysical Observation", "SAO 4993"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.29399076),
        dec: Angle.Degrees(+75.76856744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72457"},
        {"Hipparcos Number", "HIP 42506"},
        {"Smithsonian Astrophysical Observation", "SAO 6603"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.99997318),
        dec: Angle.Degrees(+75.77465827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15901"},
        {"Smithsonian Astrophysical Observation", "SAO 4899"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.20401959),
        dec: Angle.Degrees(+75.77565400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78723"},
        {"Smithsonian Astrophysical Observation", "SAO 8419"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.06522071),
        dec: Angle.Degrees(+75.78647326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59641"},
        {"Hipparcos Number", "HIP 37252"},
        {"Geneva Identification System", "GEN# +1.00059641"},
        {"Smithsonian Astrophysical Observation", "SAO 6258"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.76069180),
        dec: Angle.Degrees(+75.78653343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2339 C"},
        {"Hipparcos Number", "HIP 14520"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.88057128),
        dec: Angle.Degrees(+75.78722689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176795"},
        {"Hipparcos Number", "HIP 92717"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.38831290),
        dec: Angle.Degrees(+75.78732295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220382"},
        {"Hipparcos Number", "HIP 115353"},
        {"Smithsonian Astrophysical Observation", "SAO 10719"},
        {"Wilson Evans Batten Catalogue", "WEB 20430"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.47118448),
        dec: Angle.Degrees(+75.78811021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88379",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11072 A"},
        {"Henry Draper", "HD 166655"},
        {"Hipparcos Number", "HIP 88379"},
        {"Smithsonian Astrophysical Observation", "SAO 8999"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.71223397),
        dec: Angle.Degrees(+75.79009298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6283 AB"},
        {"Henry Draper", "HD 61010"},
        {"Hipparcos Number", "HIP 37818"},
        {"Renson", "Renson 16660"},
        {"Smithsonian Astrophysical Observation", "SAO 6292"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.31202892),
        dec: Angle.Degrees(+75.79761619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118555"},
        {"Hipparcos Number", "HIP 66202"},
        {"Fundamental Katalog 5th Edition", "FK5 5196"},
        {"Smithsonian Astrophysical Observation", "SAO 7846"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.54167154),
        dec: Angle.Degrees(+75.79761788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14506",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2339 B"},
        {"Hipparcos Number", "HIP 14506"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83250659),
        dec: Angle.Degrees(+75.79812146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14526",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2339 A"},
        {"Henry Draper", "HD 18787"},
        {"Hipparcos Number", "HIP 14526"},
        {"Smithsonian Astrophysical Observation", "SAO 4824"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.89601840),
        dec: Angle.Degrees(+75.80371568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29128"},
        {"Hipparcos Number", "HIP 21970"},
        {"Smithsonian Astrophysical Observation", "SAO 5279"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.83553590),
        dec: Angle.Degrees(+75.80697532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2826"},
        {"Smithsonian Astrophysical Observation", "SAO 4154"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96807835),
        dec: Angle.Degrees(+75.81837395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84287"},
        {"Smithsonian Astrophysical Observation", "SAO 8743"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.46772231),
        dec: Angle.Degrees(+75.81915584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26047"},
        {"Hipparcos Number", "HIP 19844"},
        {"Smithsonian Astrophysical Observation", "SAO 5128"},
        {"Wilson Evans Batten Catalogue", "WEB 3789"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.81103729),
        dec: Angle.Degrees(+75.82020024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67201"},
        {"Hipparcos Number", "HIP 40356"},
        {"Geneva Identification System", "GEN# +1.00067201"},
        {"Renson", "Renson 18530"},
        {"Smithsonian Astrophysical Observation", "SAO 6457"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.59936145),
        dec: Angle.Degrees(+75.83486688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170709"},
        {"Hipparcos Number", "HIP 90017"},
        {"Geneva Identification System", "GEN# +1.00170709"},
        {"Smithsonian Astrophysical Observation", "SAO 9101"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.51917569),
        dec: Angle.Degrees(+75.86189687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10313"},
        {"Smithsonian Astrophysical Observation", "SAO 4596"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.21170007),
        dec: Angle.Degrees(+75.86501755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38228"},
        {"Hipparcos Number", "HIP 27815"},
        {"Smithsonian Astrophysical Observation", "SAO 5669"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28610909),
        dec: Angle.Degrees(+75.86881090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10344"},
        {"Hipparcos Number", "HIP 8145"},
        {"Geneva Identification System", "GEN# +1.00010344"},
        {"Smithsonian Astrophysical Observation", "SAO 4477"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.18630619),
        dec: Angle.Degrees(+75.87225281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71361"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.90245963),
        dec: Angle.Degrees(+75.87460523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146926"},
        {"Hipparcos Number", "HIP 79280"},
        {"Fundamental Katalog 5th Edition", "FK5 606"},
        {"Geneva Identification System", "GEN# +1.00146926"},
        {"Smithsonian Astrophysical Observation", "SAO 8446"},
        {"Wilson Evans Batten Catalogue", "WEB 13405"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.70636884),
        dec: Angle.Degrees(+75.87753079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174618"},
        {"Hipparcos Number", "HIP 91769"},
        {"Smithsonian Astrophysical Observation", "SAO 9228"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70152172),
        dec: Angle.Degrees(+75.88036345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32000"},
        {"Hipparcos Number", "HIP 23943"},
        {"Smithsonian Astrophysical Observation", "SAO 5429"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.18739518),
        dec: Angle.Degrees(+75.89309947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83505"},
        {"Hipparcos Number", "HIP 47742"},
        {"Smithsonian Astrophysical Observation", "SAO 6939"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.98529994),
        dec: Angle.Degrees(+75.89610476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53979"},
        {"Fundamental Katalog 5th Edition", "FK5 4974"},
        {"Smithsonian Astrophysical Observation", "SAO 7267"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.64074196),
        dec: Angle.Degrees(+75.90265417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110422"},
        {"Hipparcos Number", "HIP 61849"},
        {"Smithsonian Astrophysical Observation", "SAO 7629"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.13918790),
        dec: Angle.Degrees(+75.90586430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118936"},
        {"Hipparcos Number", "HIP 66386"},
        {"Geneva Identification System", "GEN# +1.00118936"},
        {"Smithsonian Astrophysical Observation", "SAO 7852"},
        {"Wilson Evans Batten Catalogue", "WEB 11721"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.16730898),
        dec: Angle.Degrees(+75.90900846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90106"},
        {"Hipparcos Number", "HIP 51229"},
        {"Geneva Identification System", "GEN# +1.00090106"},
        {"Smithsonian Astrophysical Observation", "SAO 7144"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.95040209),
        dec: Angle.Degrees(+75.91652025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200039"},
        {"Hipparcos Number", "HIP 103219"},
        {"Fundamental Katalog 5th Edition", "FK5 3672"},
        {"Geneva Identification System", "GEN# +1.00200039"},
        {"Smithsonian Astrophysical Observation", "SAO 9911"},
        {"Wilson Evans Batten Catalogue", "WEB 18752"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.68448128),
        dec: Angle.Degrees(+75.92546706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80768"},
        {"Hipparcos Number", "HIP 46343"},
        {"Geneva Identification System", "GEN# +1.00080768"},
        {"Smithsonian Astrophysical Observation", "SAO 6853"},
        {"Wilson Evans Batten Catalogue", "WEB 8763"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.72483448),
        dec: Angle.Degrees(+75.93449215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -347.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22495"},
        {"Smithsonian Astrophysical Observation", "SAO 5316"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.59007375),
        dec: Angle.Degrees(+75.93673897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4075"},
        {"Hipparcos Number", "HIP 3533"},
        {"Cincinnati Publication", "Ci 20 50"},
        {"Cincinnati Publication 2", "Ci 18 91"},
        {"Geneva Identification System", "GEN# +1.00004075"},
        {"Smithsonian Astrophysical Observation", "SAO 4208"},
        {"Wilson Evans Batten Catalogue", "WEB 621"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.26559075),
        dec: Angle.Degrees(+75.93802855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 389.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29678"},
        {"Hipparcos Number", "HIP 22361"},
        {"Fundamental Katalog 5th Edition", "FK5 173"},
        {"Geneva Identification System", "GEN# +1.00029678"},
        {"Smithsonian Astrophysical Observation", "SAO 5309"},
        {"Wilson Evans Batten Catalogue", "WEB 4310"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.20942983),
        dec: Angle.Degrees(+75.94154357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33363"},
        {"Hipparcos Number", "HIP 24760"},
        {"Geneva Identification System", "GEN# +1.00033363"},
        {"Smithsonian Astrophysical Observation", "SAO 5481"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.62949333),
        dec: Angle.Degrees(+75.94701226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11844"},
        {"Hipparcos Number", "HIP 9388"},
        {"Smithsonian Astrophysical Observation", "SAO 4541"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.16031337),
        dec: Angle.Degrees(+75.95285843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204624"},
        {"Hipparcos Number", "HIP 105694"},
        {"Smithsonian Astrophysical Observation", "SAO 10043"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.10199227),
        dec: Angle.Degrees(+75.97157363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91906"},
        {"Hipparcos Number 2", "HIP 91924"},
        {"Geneva Identification System", "GEN# +6.20030189"},
        {"Wilson Evans Batten Catalogue", "WEB 15817"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)44, 22.5700),
        dec: Angle.DegreesMinutesSeconds((int)+75, (int)58, 53.600)
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
    primaryId: "HIP 81139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81139"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.55302962),
        dec: Angle.Degrees(+75.98178893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8903 AB"},
        {"Henry Draper", "HD 117173"},
        {"Hipparcos Number", "HIP 65489"},
        {"Smithsonian Astrophysical Observation", "SAO 7811"},
        {"Wilson Evans Batten Catalogue", "WEB 11559"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.33702721),
        dec: Angle.Degrees(+75.98272415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135118"},
        {"Hipparcos Number", "HIP 73959"},
        {"Geneva Identification System", "GEN# +1.00135118"},
        {"Smithsonian Astrophysical Observation", "SAO 8171"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.72366194),
        dec: Angle.Degrees(+75.98526793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2012"},
        {"Smithsonian Astrophysical Observation", "SAO 4113"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.37470411),
        dec: Angle.Degrees(+75.98826952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35782"},
        {"Smithsonian Astrophysical Observation", "SAO 6158"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70670806),
        dec: Angle.Degrees(+75.98901651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91906"},
        {"Hipparcos Number 2", "HIP 91924"},
        {"Geneva Identification System", "GEN# +6.20030189"},
        {"Wilson Evans Batten Catalogue", "WEB 15817"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.04119258),
        dec: Angle.Degrees(+75.99056530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11058"},
        {"Smithsonian Astrophysical Observation", "SAO 4626"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.58160412),
        dec: Angle.Degrees(+75.99421635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15415"},
        {"Smithsonian Astrophysical Observation", "SAO 4869"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68035741),
        dec: Angle.Degrees(+75.99451745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76832"},
        {"Geneva Identification System", "GEN# +9.80257020"},
    },
    visualMagnitude: 12.22,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.31124781),
        dec: Angle.Degrees(+75.99463559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 777.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -759.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93635"},
        {"Hipparcos Number", "HIP 53062"},
        {"Fundamental Katalog 5th Edition", "FK5 2864"},
        {"Geneva Identification System", "GEN# +1.00093635"},
        {"Smithsonian Astrophysical Observation", "SAO 7218"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.84643175),
        dec: Angle.Degrees(+75.99486838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164445"},
        {"Hipparcos Number", "HIP 87470"},
        {"Geneva Identification System", "GEN# +1.00164445"},
        {"Smithsonian Astrophysical Observation", "SAO 8952"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.07972461),
        dec: Angle.Degrees(+76.00062616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7422"},
        {"Smithsonian Astrophysical Observation", "SAO 4438"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.90994293),
        dec: Angle.Degrees(+76.00159929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34288"},
        {"Hipparcos Number", "HIP 25334"},
        {"Geneva Identification System", "GEN# +1.00034288"},
        {"Smithsonian Astrophysical Observation", "SAO 5515"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.28043043),
        dec: Angle.Degrees(+76.00220065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23751"},
        {"Hipparcos Number", "HIP 18329"},
        {"Smithsonian Astrophysical Observation", "SAO 5027"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.77865502),
        dec: Angle.Degrees(+76.00369726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212237"},
        {"Hipparcos Number", "HIP 110183"},
        {"Smithsonian Astrophysical Observation", "SAO 10315"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.77338372),
        dec: Angle.Degrees(+76.01316488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16137"},
        {"Hipparcos Number", "HIP 12523"},
        {"Smithsonian Astrophysical Observation", "SAO 4704"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.29243062),
        dec: Angle.Degrees(+76.01771469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43884"},
        {"Hipparcos Number", "HIP 30740"},
        {"Geneva Identification System", "GEN# +1.00043884"},
        {"Smithsonian Astrophysical Observation", "SAO 5843"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.88585788),
        dec: Angle.Degrees(+76.02031471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222851"},
        {"Hipparcos Number", "HIP 117039"},
        {"Smithsonian Astrophysical Observation", "SAO 10843"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.88985782),
        dec: Angle.Degrees(+76.02132604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 947"},
        {"Hipparcos Number", "HIP 1150"},
        {"Smithsonian Astrophysical Observation", "SAO 4064"},
        {"Wilson Evans Batten Catalogue", "WEB 203"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.59327595),
        dec: Angle.Degrees(+76.02217572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20190"},
        {"Hipparcos Number", "HIP 15646"},
        {"Smithsonian Astrophysical Observation", "SAO 4881"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.35398435),
        dec: Angle.Degrees(+76.02417059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 919"},
        {"Hipparcos Number", "HIP 1124"},
        {"Smithsonian Astrophysical Observation", "SAO 4062"},
        {"Wilson Evans Batten Catalogue", "WEB 195"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.51062401),
        dec: Angle.Degrees(+76.02699728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112951"},
        {"Cincinnati Publication", "Ci 18 2995"},
        {"Smithsonian Astrophysical Observation", "SAO 10529"},
        {"Wilson Evans Batten Catalogue", "WEB 20113"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.13761518),
        dec: Angle.Degrees(+76.02763064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 288.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27967"},
        {"Hipparcos Number", "HIP 21212"},
        {"Smithsonian Astrophysical Observation", "SAO 5229"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.25560853),
        dec: Angle.Degrees(+76.02994410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69150"},
        {"Smithsonian Astrophysical Observation", "SAO 7959"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.33888656),
        dec: Angle.Degrees(+76.04210440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131358"},
        {"Hipparcos Number", "HIP 72307"},
        {"Smithsonian Astrophysical Observation", "SAO 8087"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.79266029),
        dec: Angle.Degrees(+76.04223900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14633"},
        {"Wilson Evans Batten Catalogue", "WEB 2843"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.26670225),
        dec: Angle.Degrees(+76.04234642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -487.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195191"},
        {"Hipparcos Number", "HIP 100504"},
        {"Smithsonian Astrophysical Observation", "SAO 9753"},
        {"Wilson Evans Batten Catalogue", "WEB 18153"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.69701098),
        dec: Angle.Degrees(+76.04340339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47981"},
        {"Cincinnati Publication", "Ci 20 545"},
        {"Geneva Identification System", "GEN# +9.80252044"},
        {"Wilson Evans Batten Catalogue", "WEB 8978"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70114708),
        dec: Angle.Degrees(+76.04634854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -997.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86056"},
        {"Hipparcos Number", "HIP 49057"},
        {"Smithsonian Astrophysical Observation", "SAO 7019"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.15267430),
        dec: Angle.Degrees(+76.04716614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12917"},
        {"Smithsonian Astrophysical Observation", "SAO 4721"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.52096269),
        dec: Angle.Degrees(+76.04904157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159048"},
        {"Hipparcos Number", "HIP 85103"},
        {"Smithsonian Astrophysical Observation", "SAO 8795"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.89397214),
        dec: Angle.Degrees(+76.05511655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53327"},
        {"Cincinnati Publication", "Ci 20 595"},
        {"Geneva Identification System", "GEN# +0.07600404"},
        {"Smithsonian Astrophysical Observation", "SAO 7232"},
        {"Wilson Evans Batten Catalogue", "WEB 9683"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.61482212),
        dec: Angle.Degrees(+76.06540631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -432.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104781"},
        {"Hipparcos Number", "HIP 58823"},
        {"Smithsonian Astrophysical Observation", "SAO 7494"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.96984970),
        dec: Angle.Degrees(+76.06678333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37440"},
        {"Wilson Evans Batten Catalogue", "WEB 7407"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.29582124),
        dec: Angle.Degrees(+76.07392785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60843"},
        {"Hipparcos Number", "HIP 37777"},
        {"Smithsonian Astrophysical Observation", "SAO 6288"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19237240),
        dec: Angle.Degrees(+76.07590042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209307"},
        {"Hipparcos Number", "HIP 108435"},
        {"Smithsonian Astrophysical Observation", "SAO 10210"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.49324750),
        dec: Angle.Degrees(+76.08985282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144344"},
        {"Hipparcos Number", "HIP 78155"},
        {"Geneva Identification System", "GEN# +1.00144344"},
        {"Smithsonian Astrophysical Observation", "SAO 8384"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.37584299),
        dec: Angle.Degrees(+76.09026438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19015"},
        {"Hipparcos Number", "HIP 14712"},
        {"Smithsonian Astrophysical Observation", "SAO 4834"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.51790753),
        dec: Angle.Degrees(+76.09776902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83098"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.71393689),
        dec: Angle.Degrees(+76.09918085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26684"},
        {"Hipparcos Number", "HIP 20330"},
        {"Fundamental Katalog 5th Edition", "FK5 2312"},
        {"Geneva Identification System", "GEN# +1.00026684"},
        {"Smithsonian Astrophysical Observation", "SAO 5164"},
        {"Wilson Evans Batten Catalogue", "WEB 3882"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.33161482),
        dec: Angle.Degrees(+76.10615009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83092"},
        {"Smithsonian Astrophysical Observation", "SAO 8679"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.68386206),
        dec: Angle.Degrees(+76.10912130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1625 A"},
        {"Henry Draper", "HD 12339"},
        {"Hipparcos Number", "HIP 9763"},
        {"Smithsonian Astrophysical Observation", "SAO 4565"},
        {"Wilson Evans Batten Catalogue", "WEB 2050"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.38157411),
        dec: Angle.Degrees(+76.11511028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36277"},
        {"Smithsonian Astrophysical Observation", "SAO 6193"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.02565540),
        dec: Angle.Degrees(+76.12228209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16454 AB"},
        {"Henry Draper", "HD 217810"},
        {"Hipparcos Number", "HIP 113648"},
        {"Smithsonian Astrophysical Observation", "SAO 10589"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.25409089),
        dec: Angle.Degrees(+76.12262516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212332"},
        {"Hipparcos Number", "HIP 110236"},
        {"Smithsonian Astrophysical Observation", "SAO 10323"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.94757311),
        dec: Angle.Degrees(+76.12390029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167407"},
        {"Hipparcos Number", "HIP 88658"},
        {"Geneva Identification System", "GEN# +1.00167407"},
        {"Smithsonian Astrophysical Observation", "SAO 9020"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.50951841),
        dec: Angle.Degrees(+76.13174136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14413"},
        {"Hipparcos Number", "HIP 11252"},
        {"Smithsonian Astrophysical Observation", "SAO 4640"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.21124696),
        dec: Angle.Degrees(+76.13221164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80271"},
        {"Hipparcos Number", "HIP 46139"},
        {"Smithsonian Astrophysical Observation", "SAO 6839"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.13275821),
        dec: Angle.Degrees(+76.13916800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39674"},
        {"Smithsonian Astrophysical Observation", "SAO 6412"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.61122716),
        dec: Angle.Degrees(+76.14027633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148432"},
        {"Hipparcos Number", "HIP 79998"},
        {"Geneva Identification System", "GEN# +1.00148432"},
        {"Smithsonian Astrophysical Observation", "SAO 8485"},
        {"Wilson Evans Batten Catalogue", "WEB 13541"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.95538349),
        dec: Angle.Degrees(+76.14310903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24800"},
        {"Hipparcos Number", "HIP 19017"},
        {"Smithsonian Astrophysical Observation", "SAO 5069"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.11196305),
        dec: Angle.Degrees(+76.14575260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23114"},
        {"Smithsonian Astrophysical Observation", "SAO 5363"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.59998733),
        dec: Angle.Degrees(+76.14775943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24451"},
        {"Hipparcos Number", "HIP 18774"},
        {"Cincinnati Publication", "Ci 20 272"},
        {"Geneva Identification System", "GEN# +1.00024451"},
        {"Smithsonian Astrophysical Observation", "SAO 5056"},
        {"Wilson Evans Batten Catalogue", "WEB 3614"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.32839099),
        dec: Angle.Degrees(+76.16070064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 332.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -547.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82539"},
        {"Hipparcos Number", "HIP 47268"},
        {"Smithsonian Astrophysical Observation", "SAO 6911"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.50964852),
        dec: Angle.Degrees(+76.16285316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27307"},
        {"Hipparcos Number", "HIP 20746"},
        {"Smithsonian Astrophysical Observation", "SAO 5192"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.68295198),
        dec: Angle.Degrees(+76.16374324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50063"},
        {"Smithsonian Astrophysical Observation", "SAO 7077"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.32184816),
        dec: Angle.Degrees(+76.16509986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98228"},
        {"Hipparcos Number", "HIP 55312"},
        {"Geneva Identification System", "GEN# +1.00098228"},
        {"Smithsonian Astrophysical Observation", "SAO 7336"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.91120584),
        dec: Angle.Degrees(+76.16559170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29005"},
        {"Smithsonian Astrophysical Observation", "SAO 5739"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.80011287),
        dec: Angle.Degrees(+76.16611372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81771"},
        {"Smithsonian Astrophysical Observation", "SAO 8605"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53465909),
        dec: Angle.Degrees(+76.17118275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51558"},
        {"Hipparcos Number", "HIP 34296"},
        {"Smithsonian Astrophysical Observation", "SAO 6072"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.64854905),
        dec: Angle.Degrees(+76.17167985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52063"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.57865729),
        dec: Angle.Degrees(+76.17252905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -444.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224917"},
        {"Hipparcos Number", "HIP 144"},
        {"Smithsonian Astrophysical Observation", "SAO 10935"},
        {"Wilson Evans Batten Catalogue", "WEB 22"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45508990),
        dec: Angle.Degrees(+76.17561121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180841"},
        {"Hipparcos Number", "HIP 94126"},
        {"Geneva Identification System", "GEN# +1.00180841"},
        {"Smithsonian Astrophysical Observation", "SAO 9344"},
        {"Wilson Evans Batten Catalogue", "WEB 16393"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.40785594),
        dec: Angle.Degrees(+76.18272043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135363"},
        {"Hipparcos Number", "HIP 74045"},
        {"Smithsonian Astrophysical Observation", "SAO 8175"},
        {"Wilson Evans Batten Catalogue", "WEB 12649"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98577154),
        dec: Angle.Degrees(+76.20033360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88268"},
        {"Hipparcos Number", "HIP 50201"},
        {"Geneva Identification System", "GEN# +1.00088268"},
        {"Smithsonian Astrophysical Observation", "SAO 7085"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.73054043),
        dec: Angle.Degrees(+76.20149215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86308"},
        {"Smithsonian Astrophysical Observation", "SAO 8871"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.52613504),
        dec: Angle.Degrees(+76.20546982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67869"},
        {"Hipparcos Number", "HIP 40634"},
        {"Smithsonian Astrophysical Observation", "SAO 6476"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.43046737),
        dec: Angle.Degrees(+76.21246220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8962",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1504 AB"},
        {"Henry Draper", "HD 11316"},
        {"Hipparcos Number", "HIP 8962"},
        {"Smithsonian Astrophysical Observation", "SAO 4512"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.86401362),
        dec: Angle.Degrees(+76.22455163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172114"},
        {"Hipparcos Number", "HIP 90615"},
        {"Smithsonian Astrophysical Observation", "SAO 9146"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.35435312),
        dec: Angle.Degrees(+76.22585283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214035"},
        {"Hipparcos Number", "HIP 111242"},
        {"Fundamental Katalog 5th Edition", "FK5 1594"},
        {"Geneva Identification System", "GEN# +1.00214035"},
        {"Smithsonian Astrophysical Observation", "SAO 10414"},
        {"Wilson Evans Batten Catalogue", "WEB 19903"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.06781235),
        dec: Angle.Degrees(+76.22646833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102373"},
        {"Hipparcos Number", "HIP 57545"},
        {"Smithsonian Astrophysical Observation", "SAO 7427"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.91502823),
        dec: Angle.Degrees(+76.23266861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149698"},
        {"Hipparcos Number", "HIP 80666"},
        {"Geneva Identification System", "GEN# +1.00149698"},
        {"Smithsonian Astrophysical Observation", "SAO 8535"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.03888073),
        dec: Angle.Degrees(+76.23350670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213556"},
        {"Hipparcos Number", "HIP 110949"},
        {"Smithsonian Astrophysical Observation", "SAO 10392"},
        {"Wilson Evans Batten Catalogue", "WEB 19865"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19033736),
        dec: Angle.Degrees(+76.23560890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43474"},
        {"Hipparcos Number", "HIP 30568"},
        {"Smithsonian Astrophysical Observation", "SAO 5831"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.37658707),
        dec: Angle.Degrees(+76.23600779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7925"},
        {"Hipparcos Number", "HIP 6378"},
        {"Fundamental Katalog 5th Edition", "FK5 2087"},
        {"Geneva Identification System", "GEN# +1.00007925"},
        {"Smithsonian Astrophysical Observation", "SAO 4387"},
        {"Wilson Evans Batten Catalogue", "WEB 1413"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.49558059),
        dec: Angle.Degrees(+76.23888764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192889"},
        {"Hipparcos Number", "HIP 99330"},
        {"Smithsonian Astrophysical Observation", "SAO 9669"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.41692222),
        dec: Angle.Degrees(+76.24515103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4300"},
        {"Smithsonian Astrophysical Observation", "SAO 4264"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.77426446),
        dec: Angle.Degrees(+76.25157034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122005"},
        {"Hipparcos Number", "HIP 67937"},
        {"Smithsonian Astrophysical Observation", "SAO 7907"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.68902879),
        dec: Angle.Degrees(+76.26431779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104149"},
        {"Smithsonian Astrophysical Observation", "SAO 9961"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.50556108),
        dec: Angle.Degrees(+76.26650343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1359"},
        {"Hipparcos Number", "HIP 1484"},
        {"Smithsonian Astrophysical Observation", "SAO 4080"},
        {"Wilson Evans Batten Catalogue", "WEB 272"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.61486604),
        dec: Angle.Degrees(+76.27654297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115180"},
        {"Hipparcos Number", "HIP 64452"},
        {"Smithsonian Astrophysical Observation", "SAO 7778"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.16614838),
        dec: Angle.Degrees(+76.28398658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 465"},
        {"Smithsonian Astrophysical Observation", "SAO 4033"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.39092668),
        dec: Angle.Degrees(+76.28582649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26018"},
        {"Hipparcos Number", "HIP 19841"},
        {"Geneva Identification System", "GEN# +1.00026018"},
        {"Smithsonian Astrophysical Observation", "SAO 5127"},
        {"Wilson Evans Batten Catalogue", "WEB 3788"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.80671344),
        dec: Angle.Degrees(+76.28859756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 455"},
    },
    visualMagnitude: 11.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36474708),
        dec: Angle.Degrees(+76.29156292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117060"},
        {"Hipparcos Number", "HIP 65415"},
        {"Smithsonian Astrophysical Observation", "SAO 7808"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.11566332),
        dec: Angle.Degrees(+76.29537592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118554"},
        {"Hipparcos Number", "HIP 66191"},
        {"Geneva Identification System", "GEN# +1.00118554"},
        {"Smithsonian Astrophysical Observation", "SAO 7845"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.51005135),
        dec: Angle.Degrees(+76.29586819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73047"},
        {"Smithsonian Astrophysical Observation", "SAO 8123"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.93273323),
        dec: Angle.Degrees(+76.30664572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41608"},
        {"Smithsonian Astrophysical Observation", "SAO 6544"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.23373167),
        dec: Angle.Degrees(+76.30783343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182126"},
        {"Hipparcos Number", "HIP 94554"},
        {"Smithsonian Astrophysical Observation", "SAO 9365"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66120855),
        dec: Angle.Degrees(+76.30938696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14782 A"},
        {"Henry Draper", "HD 202765"},
        {"Hipparcos Number", "HIP 104667"},
        {"Smithsonian Astrophysical Observation", "SAO 9990"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.01607870),
        dec: Angle.Degrees(+76.31015568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224402"},
        {"Hipparcos Number", "HIP 118102"},
        {"Geneva Identification System", "GEN# +1.00224402"},
        {"Smithsonian Astrophysical Observation", "SAO 10910"},
        {"Wilson Evans Batten Catalogue", "WEB 20764"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34669468),
        dec: Angle.Degrees(+76.31446506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63200"},
        {"Smithsonian Astrophysical Observation", "SAO 7710"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.22727620),
        dec: Angle.Degrees(+76.32107592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113096",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16371 AB"},
        {"Henry Draper", "HD 216886"},
        {"Hipparcos Number", "HIP 113096"},
        {"Geneva Identification System", "GEN# +1.00216886J"},
        {"Smithsonian Astrophysical Observation", "SAO 10541"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.56191244),
        dec: Angle.Degrees(+76.33810000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110153"},
        {"Smithsonian Astrophysical Observation", "SAO 10314"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.68861275),
        dec: Angle.Degrees(+76.34592985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36302"},
        {"Hipparcos Number", "HIP 26662"},
        {"Geneva Identification System", "GEN# +1.00036302"},
        {"Smithsonian Astrophysical Observation", "SAO 5592"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.99994788),
        dec: Angle.Degrees(+76.36408304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68769"},
        {"Hipparcos Number", "HIP 40969"},
        {"Geneva Identification System", "GEN# +1.00068769"},
        {"Smithsonian Astrophysical Observation", "SAO 6506"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.41090158),
        dec: Angle.Degrees(+76.36507900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11575"},
        {"Hipparcos Number", "HIP 9174"},
        {"Geneva Identification System", "GEN# +1.00011575"},
        {"Smithsonian Astrophysical Observation", "SAO 4526"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.52239159),
        dec: Angle.Degrees(+76.37013130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10992",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1775 AB"},
        {"Hipparcos Number", "HIP 10992"},
        {"Smithsonian Astrophysical Observation", "SAO 4623"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.41522071),
        dec: Angle.Degrees(+76.38019492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108448"},
        {"Hipparcos Number", "HIP 60716"},
        {"Geneva Identification System", "GEN# +1.00108448"},
        {"Smithsonian Astrophysical Observation", "SAO 7565"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.64616211),
        dec: Angle.Degrees(+76.38449962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201975"},
        {"Hipparcos Number", "HIP 104213"},
        {"Geneva Identification System", "GEN# +1.00201975"},
        {"Smithsonian Astrophysical Observation", "SAO 9964"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.70965107),
        dec: Angle.Degrees(+76.39484955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76539"},
        {"Hipparcos Number", "HIP 44463"},
        {"Geneva Identification System", "GEN# +1.00076539"},
        {"Smithsonian Astrophysical Observation", "SAO 6717"},
        {"Wilson Evans Batten Catalogue", "WEB 8520"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.87553656),
        dec: Angle.Degrees(+76.39815134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26097"},
        {"Smithsonian Astrophysical Observation", "SAO 5560"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.48564563),
        dec: Angle.Degrees(+76.39865279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205234"},
        {"Hipparcos Number", "HIP 106024"},
        {"Geneva Identification System", "GEN# +1.00205234"},
        {"Renson", "Renson 57180"},
        {"Smithsonian Astrophysical Observation", "SAO 10061"},
        {"Wilson Evans Batten Catalogue", "WEB 19218"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.11756685),
        dec: Angle.Degrees(+76.40352828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24978"},
        {"Hipparcos Number", "HIP 19145"},
        {"Geneva Identification System", "GEN# +1.00024978"},
        {"Smithsonian Astrophysical Observation", "SAO 5080"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.54769299),
        dec: Angle.Degrees(+76.41554624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186922"},
        {"Hipparcos Number", "HIP 96656"},
        {"Geneva Identification System", "GEN# +1.00186922J"},
        {"Smithsonian Astrophysical Observation", "SAO 9496"},
        {"Wilson Evans Batten Catalogue", "WEB 16957"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.77491770),
        dec: Angle.Degrees(+76.42167965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91809"},
        {"Hipparcos Number", "HIP 52152"},
        {"Smithsonian Astrophysical Observation", "SAO 7178"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.81992963),
        dec: Angle.Degrees(+76.44165051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148855"},
        {"Hipparcos Number", "HIP 80219"},
        {"Smithsonian Astrophysical Observation", "SAO 8506"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.64186073),
        dec: Angle.Degrees(+76.44500874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190251"},
        {"Hipparcos Number", "HIP 98095"},
        {"Smithsonian Astrophysical Observation", "SAO 9582"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.03691069),
        dec: Angle.Degrees(+76.45019592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140084"},
        {"Hipparcos Number", "HIP 76239"},
        {"Smithsonian Astrophysical Observation", "SAO 8283"},
        {"Wilson Evans Batten Catalogue", "WEB 12945"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.59681004),
        dec: Angle.Degrees(+76.45074393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211374"},
        {"Hipparcos Number", "HIP 109629"},
        {"Smithsonian Astrophysical Observation", "SAO 10285"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.12061706),
        dec: Angle.Degrees(+76.46181507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27909"},
        {"Smithsonian Astrophysical Observation", "SAO 5676"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.58204447),
        dec: Angle.Degrees(+76.46277299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36586"},
        {"Hipparcos Number", "HIP 26848"},
        {"Smithsonian Astrophysical Observation", "SAO 5609"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.50378636),
        dec: Angle.Degrees(+76.46514063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3738 AB"},
        {"Henry Draper", "HD 32781"},
        {"Hipparcos Number", "HIP 24440"},
        {"Geneva Identification System", "GEN# +1.00032781J"},
        {"Smithsonian Astrophysical Observation", "SAO 5464"},
        {"Wilson Evans Batten Catalogue", "WEB 4734"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.64809587),
        dec: Angle.Degrees(+76.47276909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207767"},
        {"Hipparcos Number", "HIP 107513"},
        {"Smithsonian Astrophysical Observation", "SAO 10155"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.62173185),
        dec: Angle.Degrees(+76.47299413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183076"},
        {"Hipparcos Number", "HIP 94945"},
        {"Geneva Identification System", "GEN# +1.00183076"},
        {"Smithsonian Astrophysical Observation", "SAO 9393"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.81512714),
        dec: Angle.Degrees(+76.48042753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13296 A"},
        {"Henry Draper", "HD 190960"},
        {"Hipparcos Number", "HIP 98401"},
        {"Fundamental Katalog 5th Edition", "FK5 3605"},
        {"Geneva Identification System", "GEN# +1.00190960"},
        {"Smithsonian Astrophysical Observation", "SAO 9606"},
        {"Wilson Evans Batten Catalogue", "WEB 17368"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.90289138),
        dec: Angle.Degrees(+76.48153707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28918"},
        {"Hipparcos Number", "HIP 21859"},
        {"Smithsonian Astrophysical Observation", "SAO 5273"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.51047657),
        dec: Angle.Degrees(+76.48417187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212150"},
        {"Hipparcos Number", "HIP 110116"},
        {"Fundamental Katalog 5th Edition", "FK5 3784"},
        {"Geneva Identification System", "GEN# +1.00212150"},
        {"Smithsonian Astrophysical Observation", "SAO 10312"},
        {"Wilson Evans Batten Catalogue", "WEB 19766"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.58499694),
        dec: Angle.Degrees(+76.48800754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24544"},
        {"Smithsonian Astrophysical Observation", "SAO 5469"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.98420972),
        dec: Angle.Degrees(+76.49099476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111549"},
        {"Smithsonian Astrophysical Observation", "SAO 10432"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.97151703),
        dec: Angle.Degrees(+76.49198576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122079"},
        {"Hipparcos Number", "HIP 67974"},
        {"Smithsonian Astrophysical Observation", "SAO 7909"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.80232945),
        dec: Angle.Degrees(+76.50094889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218028"},
        {"Hipparcos Number", "HIP 113786"},
        {"Smithsonian Astrophysical Observation", "SAO 10598"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.64630960),
        dec: Angle.Degrees(+76.50368688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4771 AB"},
        {"Henry Draper", "HD 41497"},
        {"Hipparcos Number", "HIP 29670"},
        {"Smithsonian Astrophysical Observation", "SAO 5779"},
        {"Wilson Evans Batten Catalogue", "WEB 5842"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.75581068),
        dec: Angle.Degrees(+76.50537863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81178"},
        {"Smithsonian Astrophysical Observation", "SAO 8564"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.71591887),
        dec: Angle.Degrees(+76.51095429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133541"},
        {"Hipparcos Number", "HIP 73299"},
        {"Smithsonian Astrophysical Observation", "SAO 8137"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.70067687),
        dec: Angle.Degrees(+76.52795310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2187 A"},
        {"Henry Draper", "HD 17580"},
        {"Hipparcos Number", "HIP 13634"},
        {"Smithsonian Astrophysical Observation", "SAO 4759"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88721226),
        dec: Angle.Degrees(+76.52894573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44069"},
        {"Smithsonian Astrophysical Observation", "SAO 6696"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.64659967),
        dec: Angle.Degrees(+76.53039984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88005"},
        {"Smithsonian Astrophysical Observation", "SAO 8977"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.65668230),
        dec: Angle.Degrees(+76.54307794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118686"},
        {"Hipparcos Number", "HIP 66251"},
        {"Smithsonian Astrophysical Observation", "SAO 7848"},
        {"Wilson Evans Batten Catalogue", "WEB 11710"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.67839412),
        dec: Angle.Degrees(+76.54670829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47098"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.97836806),
        dec: Angle.Degrees(+76.54798714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56204"},
        {"Smithsonian Astrophysical Observation", "SAO 7365"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.82887626),
        dec: Angle.Degrees(+76.55132073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64910"},
        {"Hipparcos Number", "HIP 39497"},
        {"Geneva Identification System", "GEN# +1.00064910"},
        {"Smithsonian Astrophysical Observation", "SAO 6400"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.10011428),
        dec: Angle.Degrees(+76.55337968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4381"},
        {"Hipparcos Number", "HIP 3744"},
        {"Smithsonian Astrophysical Observation", "SAO 4228"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.01095672),
        dec: Angle.Degrees(+76.55380617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204426"},
        {"Hipparcos Number", "HIP 105557"},
        {"Geneva Identification System", "GEN# +1.00204426"},
        {"Smithsonian Astrophysical Observation", "SAO 10037"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.67499941),
        dec: Angle.Degrees(+76.55472783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 135.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183556"},
        {"Hipparcos Number", "HIP 95154"},
        {"Smithsonian Astrophysical Observation", "SAO 9404"},
        {"Wilson Evans Batten Catalogue", "WEB 16622"},
    },
    visualMagnitude: 6.22,
    bvColour: 2.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.39806052),
        dec: Angle.Degrees(+76.55959765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96672",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12824 AB"},
        {"Henry Draper", "HD 186993"},
        {"Hipparcos Number", "HIP 96672"},
        {"Smithsonian Astrophysical Observation", "SAO 9500"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80927099),
        dec: Angle.Degrees(+76.56072572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180777"},
        {"Hipparcos Number", "HIP 94083"},
        {"Fundamental Katalog 5th Edition", "FK5 3536"},
        {"Geneva Identification System", "GEN# +1.00180777"},
        {"Smithsonian Astrophysical Observation", "SAO 9341"},
        {"Wilson Evans Batten Catalogue", "WEB 16382"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.29061868),
        dec: Angle.Degrees(+76.56079335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128421"},
        {"Hipparcos Number", "HIP 70985"},
        {"Smithsonian Astrophysical Observation", "SAO 8043"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.79335845),
        dec: Angle.Degrees(+76.56530089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28745"},
        {"Hipparcos Number", "HIP 21764"},
        {"Geneva Identification System", "GEN# +1.00028745"},
        {"Smithsonian Astrophysical Observation", "SAO 5270"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.11402695),
        dec: Angle.Degrees(+76.56716249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15228"},
        {"Smithsonian Astrophysical Observation", "SAO 4862"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.08317032),
        dec: Angle.Degrees(+76.57525709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223959"},
        {"Hipparcos Number", "HIP 117819"},
        {"Geneva Identification System", "GEN# +1.00223959"},
        {"Smithsonian Astrophysical Observation", "SAO 10888"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.42105122),
        dec: Angle.Degrees(+76.58261335)
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
    primaryId: "HIP 109039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210333"},
        {"Hipparcos Number", "HIP 109039"},
        {"Smithsonian Astrophysical Observation", "SAO 10244"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.33674121),
        dec: Angle.Degrees(+76.58564697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46758"},
        {"Hipparcos Number", "HIP 32293"},
        {"Geneva Identification System", "GEN# +1.00046758"},
        {"Smithsonian Astrophysical Observation", "SAO 5943"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.12005353),
        dec: Angle.Degrees(+76.58598485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9366"},
        {"Smithsonian Astrophysical Observation", "SAO 4540"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.08329383),
        dec: Angle.Degrees(+76.60765554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23371"},
        {"Hipparcos Number", "HIP 18118"},
        {"Smithsonian Astrophysical Observation", "SAO 5010"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.11324971),
        dec: Angle.Degrees(+76.60932495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113628"},
        {"Smithsonian Astrophysical Observation", "SAO 10587"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.19466983),
        dec: Angle.Degrees(+76.60981851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29329"},
        {"Hipparcos Number", "HIP 22152"},
        {"Geneva Identification System", "GEN# +1.00029329"},
        {"Smithsonian Astrophysical Observation", "SAO 5289"},
        {"Wilson Evans Batten Catalogue", "WEB 4261"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.50160938),
        dec: Angle.Degrees(+76.61137327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85582"},
        {"Hipparcos Number", "HIP 48854"},
        {"Geneva Identification System", "GEN# +1.00085582"},
        {"Smithsonian Astrophysical Observation", "SAO 7003"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.46715742),
        dec: Angle.Degrees(+76.61296037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221724"},
        {"Hipparcos Number", "HIP 116255"},
        {"Smithsonian Astrophysical Observation", "SAO 10781"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34583287),
        dec: Angle.Degrees(+76.61506964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21191"},
        {"Hipparcos Number", "HIP 16495"},
        {"Smithsonian Astrophysical Observation", "SAO 4923"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10340512),
        dec: Angle.Degrees(+76.61743519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182827"},
        {"Hipparcos Number", "HIP 94830"},
        {"Geneva Identification System", "GEN# +1.00182827"},
        {"Smithsonian Astrophysical Observation", "SAO 9386"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.44261092),
        dec: Angle.Degrees(+76.61908201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94946"},
        {"Hipparcos Number", "HIP 53775"},
        {"Smithsonian Astrophysical Observation", "SAO 7259"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.04573988),
        dec: Angle.Degrees(+76.63263795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31814"},
        {"Hipparcos Number", "HIP 23885"},
        {"Geneva Identification System", "GEN# +1.00031814"},
        {"Smithsonian Astrophysical Observation", "SAO 5423"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.98291057),
        dec: Angle.Degrees(+76.63638376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109836"},
        {"Hipparcos Number", "HIP 61543"},
        {"Smithsonian Astrophysical Observation", "SAO 7610"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.14577261),
        dec: Angle.Degrees(+76.63778836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134749"},
        {"Hipparcos Number", "HIP 73799"},
        {"Geneva Identification System", "GEN# +1.00134749"},
        {"Smithsonian Astrophysical Observation", "SAO 8164"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.24484658),
        dec: Angle.Degrees(+76.63985867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138020"},
        {"Hipparcos Number", "HIP 75214"},
        {"Smithsonian Astrophysical Observation", "SAO 8236"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55222029),
        dec: Angle.Degrees(+76.64050201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195526"},
        {"Hipparcos Number", "HIP 100646"},
        {"Smithsonian Astrophysical Observation", "SAO 9762"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.12258663),
        dec: Angle.Degrees(+76.65079711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56291"},
        {"Geneva Identification System", "GEN# +9.80254024"},
        {"Wilson Evans Batten Catalogue", "WEB 10123"},
    },
    visualMagnitude: 11.53,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.09592934),
        dec: Angle.Degrees(+76.65647785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -604.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185891"},
        {"Hipparcos Number", "HIP 96136"},
        {"Smithsonian Astrophysical Observation", "SAO 9464"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.21687766),
        dec: Angle.Degrees(+76.66085748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126892"},
        {"Hipparcos Number", "HIP 70295"},
        {"Fundamental Katalog 5th Edition", "FK5 5271"},
        {"Geneva Identification System", "GEN# +1.00126892"},
        {"Smithsonian Astrophysical Observation", "SAO 8008"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.74204493),
        dec: Angle.Degrees(+76.66367626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222992"},
        {"Hipparcos Number", "HIP 117157"},
        {"Smithsonian Astrophysical Observation", "SAO 10850"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.27003756),
        dec: Angle.Degrees(+76.66971651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216064"},
        {"Hipparcos Number", "HIP 112454"},
        {"Smithsonian Astrophysical Observation", "SAO 10497"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.69021438),
        dec: Angle.Degrees(+76.67210389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32174"},
        {"Smithsonian Astrophysical Observation", "SAO 5934"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77458004),
        dec: Angle.Degrees(+76.67868827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89372"},
    },
    visualMagnitude: 11.63,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.57963133),
        dec: Angle.Degrees(+76.68558627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109094"},
        {"Hipparcos Number", "HIP 61065"},
        {"Smithsonian Astrophysical Observation", "SAO 7576"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.73151305),
        dec: Angle.Degrees(+76.68693378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104000"},
        {"Hipparcos Number", "HIP 58429"},
        {"Smithsonian Astrophysical Observation", "SAO 7468"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.70894715),
        dec: Angle.Degrees(+76.68833320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9236 AB"},
        {"Henry Draper", "HD 126408"},
        {"Hipparcos Number", "HIP 70034"},
        {"Smithsonian Astrophysical Observation", "SAO 7994"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.95584956),
        dec: Angle.Degrees(+76.70058216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160011"},
        {"Hipparcos Number", "HIP 85495"},
        {"Geneva Identification System", "GEN# +1.00160011"},
        {"Smithsonian Astrophysical Observation", "SAO 8820"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.08123365),
        dec: Angle.Degrees(+76.70944514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7924"},
        {"Hipparcos Number", "HIP 6379"},
        {"Geneva Identification System", "GEN# +1.00007924"},
        {"Smithsonian Astrophysical Observation", "SAO 4386"},
        {"Wilson Evans Batten Catalogue", "WEB 1412"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.49667464),
        dec: Angle.Degrees(+76.71036810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7498 AB"},
        {"Henry Draper", "HD 83746"},
        {"Hipparcos Number", "HIP 47925"},
        {"Smithsonian Astrophysical Observation", "SAO 6953"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.50267677),
        dec: Angle.Degrees(+76.71076666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115777"},
        {"Smithsonian Astrophysical Observation", "SAO 10738"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.83305975),
        dec: Angle.Degrees(+76.71304968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15417"},
        {"Hipparcos Number", "HIP 11978"},
        {"Fundamental Katalog 5th Edition", "FK5 2174"},
        {"Geneva Identification System", "GEN# +1.00015417"},
        {"Smithsonian Astrophysical Observation", "SAO 4675"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.62715194),
        dec: Angle.Degrees(+76.71827440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7684",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1264 AB"},
        {"Henry Draper", "HD 9721"},
        {"Hipparcos Number", "HIP 7684"},
        {"Smithsonian Astrophysical Observation", "SAO 4452"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.73607611),
        dec: Angle.Degrees(+76.72363744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91103"},
        {"Hipparcos Number", "HIP 51779"},
        {"Geneva Identification System", "GEN# +1.00091103"},
        {"Smithsonian Astrophysical Observation", "SAO 7163"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70477474),
        dec: Angle.Degrees(+76.73186956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79407"},
        {"Hipparcos Number", "HIP 45785"},
        {"Smithsonian Astrophysical Observation", "SAO 6812"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.02684653),
        dec: Angle.Degrees(+76.73800530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34075"},
        {"Smithsonian Astrophysical Observation", "SAO 6047"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00640451),
        dec: Angle.Degrees(+76.74220102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156375"},
        {"Hipparcos Number", "HIP 83826"},
        {"Smithsonian Astrophysical Observation", "SAO 8722"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.98232746),
        dec: Angle.Degrees(+76.75288354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60404"},
        {"Hipparcos Number", "HIP 37613"},
        {"Geneva Identification System", "GEN# +1.00060404"},
        {"Smithsonian Astrophysical Observation", "SAO 6277"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.77127823),
        dec: Angle.Degrees(+76.76009823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104954"},
        {"Hipparcos Number", "HIP 58924"},
        {"Geneva Identification System", "GEN# +1.00104954"},
        {"Smithsonian Astrophysical Observation", "SAO 7497"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.24818369),
        dec: Angle.Degrees(+76.76241773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40847"},
        {"Hipparcos Number", "HIP 29320"},
        {"Geneva Identification System", "GEN# +1.00040847"},
        {"Smithsonian Astrophysical Observation", "SAO 5759"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.74210809),
        dec: Angle.Degrees(+76.76439146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36289"},
        {"Hipparcos Number", "HIP 26673"},
        {"Geneva Identification System", "GEN# +1.00036289"},
        {"Smithsonian Astrophysical Observation", "SAO 5591"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.02552387),
        dec: Angle.Degrees(+76.76668600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9712 AB"},
        {"Henry Draper", "HD 139797"},
        {"Hipparcos Number", "HIP 76097"},
        {"Smithsonian Astrophysical Observation", "SAO 8279"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.12560256),
        dec: Angle.Degrees(+76.77346608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219667"},
        {"Hipparcos Number", "HIP 114833"},
        {"Smithsonian Astrophysical Observation", "SAO 10674"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.91748322),
        dec: Angle.Degrees(+76.78725616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183051"},
        {"Hipparcos Number", "HIP 94915"},
        {"Smithsonian Astrophysical Observation", "SAO 9392"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.71859468),
        dec: Angle.Degrees(+76.79250728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9958"},
        {"Smithsonian Astrophysical Observation", "SAO 4578"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.04753824),
        dec: Angle.Degrees(+76.79251438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6522 AB"},
        {"Hipparcos Number", "HIP 39594"},
        {"Smithsonian Astrophysical Observation", "SAO 6404"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.36651968),
        dec: Angle.Degrees(+76.79350213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145622"},
        {"Hipparcos Number", "HIP 78661"},
        {"Geneva Identification System", "GEN# +1.00145622"},
        {"Smithsonian Astrophysical Observation", "SAO 8417"},
        {"Wilson Evans Batten Catalogue", "WEB 13298"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.88081682),
        dec: Angle.Degrees(+76.79388926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64992"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.82299687),
        dec: Angle.Degrees(+76.79393897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9225 AB"},
        {"Hipparcos Number", "HIP 69852"},
        {"Smithsonian Astrophysical Observation", "SAO 7987"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.43287802),
        dec: Angle.Degrees(+76.79644795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7623"},
        {"Hipparcos Number", "HIP 6175"},
        {"Smithsonian Astrophysical Observation", "SAO 4373"},
        {"Wilson Evans Batten Catalogue", "WEB 1385"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.79568491),
        dec: Angle.Degrees(+76.79659669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35216"},
        {"Smithsonian Astrophysical Observation", "SAO 6122"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.17392225),
        dec: Angle.Degrees(+76.81683493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72340"},
        {"Smithsonian Astrophysical Observation", "SAO 8092"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88740163),
        dec: Angle.Degrees(+76.82101392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31577"},
        {"Hipparcos Number", "HIP 23739"},
        {"Geneva Identification System", "GEN# +1.00031577"},
        {"Smithsonian Astrophysical Observation", "SAO 5409"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.54168921),
        dec: Angle.Degrees(+76.82376831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197665"},
        {"Hipparcos Number", "HIP 101824"},
        {"Geneva Identification System", "GEN# +1.00197665"},
        {"Smithsonian Astrophysical Observation", "SAO 9836"},
        {"Wilson Evans Batten Catalogue", "WEB 18398"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.52092794),
        dec: Angle.Degrees(+76.83301020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58777"},
        {"Hipparcos Number", "HIP 36978"},
        {"Smithsonian Astrophysical Observation", "SAO 6244"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.00911827),
        dec: Angle.Degrees(+76.83336004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21236"},
        {"Hipparcos Number", "HIP 16550"},
        {"Smithsonian Astrophysical Observation", "SAO 4927"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.28026252),
        dec: Angle.Degrees(+76.83633975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42947"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.31484887),
        dec: Angle.Degrees(+76.83804573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140341"},
        {"Hipparcos Number", "HIP 76309"},
        {"Geneva Identification System", "GEN# +1.00140341"},
        {"Smithsonian Astrophysical Observation", "SAO 8292"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81713731),
        dec: Angle.Degrees(+76.84281322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66728",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8997 A"},
        {"Henry Draper", "HD 119702"},
        {"Hipparcos Number", "HIP 66728"},
        {"Geneva Identification System", "GEN# +1.00119702"},
        {"Smithsonian Astrophysical Observation", "SAO 7867"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17056663),
        dec: Angle.Degrees(+76.84378490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9954"},
        {"Hipparcos Number", "HIP 7856"},
        {"Geneva Identification System", "GEN# +1.00009954"},
        {"Smithsonian Astrophysical Observation", "SAO 4462"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.26049145),
        dec: Angle.Degrees(+76.84413348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153845"},
        {"Hipparcos Number", "HIP 82571"},
        {"Geneva Identification System", "GEN# +1.00153845"},
        {"Smithsonian Astrophysical Observation", "SAO 8654"},
        {"Wilson Evans Batten Catalogue", "WEB 13941"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.18277931),
        dec: Angle.Degrees(+76.85258840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5714"},
        {"Hipparcos Number", "HIP 4757"},
        {"Geneva Identification System", "GEN# +1.00005714"},
        {"Smithsonian Astrophysical Observation", "SAO 4290"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.28156116),
        dec: Angle.Degrees(+76.85794889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93251"},
        {"Hipparcos Number", "HIP 52896"},
        {"Smithsonian Astrophysical Observation", "SAO 7209"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.28155662),
        dec: Angle.Degrees(+76.86431625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45161"},
        {"Hipparcos Number", "HIP 31473"},
        {"Geneva Identification System", "GEN# +1.00045161"},
        {"Smithsonian Astrophysical Observation", "SAO 5888"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89022681),
        dec: Angle.Degrees(+76.86650359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217832"},
        {"Hipparcos Number", "HIP 113656"},
        {"Smithsonian Astrophysical Observation", "SAO 10590"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.27995768),
        dec: Angle.Degrees(+76.86947659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38399"},
        {"Hipparcos Number", "HIP 27988"},
        {"Geneva Identification System", "GEN# +1.00038399"},
        {"Smithsonian Astrophysical Observation", "SAO 5682"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.79064542),
        dec: Angle.Degrees(+76.86957095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3553"},
        {"Hipparcos Number", "HIP 3145"},
        {"Smithsonian Astrophysical Observation", "SAO 4176"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.99780503),
        dec: Angle.Degrees(+76.87117021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201832"},
        {"Hipparcos Number", "HIP 104147"},
        {"Smithsonian Astrophysical Observation", "SAO 9962"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.50278776),
        dec: Angle.Degrees(+76.87294606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27996"},
    },
    visualMagnitude: 11.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.81265554),
        dec: Angle.Degrees(+76.87494161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58952",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tonatiuh"},
        {"Henry Draper", "HD 104985"},
        {"Hipparcos Number", "HIP 58952"},
        {"Fundamental Katalog 5th Edition", "FK5 451"},
        {"Geneva Identification System", "GEN# +1.00104985"},
        {"Smithsonian Astrophysical Observation", "SAO 7500"},
        {"Wilson Evans Batten Catalogue", "WEB 10496"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.31141141),
        dec: Angle.Degrees(+76.90595813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220159"},
        {"Hipparcos Number", "HIP 115202"},
        {"Smithsonian Astrophysical Observation", "SAO 10701"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.01080521),
        dec: Angle.Degrees(+76.90789959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76309"},
        {"Hipparcos Number", "HIP 44369"},
        {"Smithsonian Astrophysical Observation", "SAO 6710"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.53285519),
        dec: Angle.Degrees(+76.90824300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22463"},
        {"Hipparcos Number", "HIP 17471"},
        {"Smithsonian Astrophysical Observation", "SAO 4969"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.15507237),
        dec: Angle.Degrees(+76.91717179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36710"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.26553993),
        dec: Angle.Degrees(+76.92089675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28706"},
        {"Smithsonian Astrophysical Observation", "SAO 5715"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.94870765),
        dec: Angle.Degrees(+76.92724648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112336"},
        {"Hipparcos Number", "HIP 62929"},
        {"Smithsonian Astrophysical Observation", "SAO 7693"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.44545597),
        dec: Angle.Degrees(+76.93566312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 207 AB"},
        {"Henry Draper", "HD 1141"},
        {"Hipparcos Number", "HIP 1296"},
        {"Geneva Identification System", "GEN# +1.00001141J"},
        {"Smithsonian Astrophysical Observation", "SAO 4071"},
        {"Wilson Evans Batten Catalogue", "WEB 227"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.05785281),
        dec: Angle.Degrees(+76.95076267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57644"},
        {"Hipparcos Number", "HIP 36555"},
        {"Geneva Identification System", "GEN# +1.00057644"},
        {"Smithsonian Astrophysical Observation", "SAO 6207"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80038942),
        dec: Angle.Degrees(+76.95463276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13466"},
        {"Smithsonian Astrophysical Observation", "SAO 4749"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.35848459),
        dec: Angle.Degrees(+76.96111543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163989"},
        {"Hipparcos Number", "HIP 87234"},
        {"Fundamental Katalog 5th Edition", "FK5 675"},
        {"Geneva Identification System", "GEN# +1.00163989"},
        {"Smithsonian Astrophysical Observation", "SAO 8939"},
        {"Wilson Evans Batten Catalogue", "WEB 14719"},
    },
    visualMagnitude: 5.02,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.36223704),
        dec: Angle.Degrees(+76.96227797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 247.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69408"},
        {"Hipparcos Number", "HIP 41239"},
        {"Smithsonian Astrophysical Observation", "SAO 6523"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22169048),
        dec: Angle.Degrees(+76.96483811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35672"},
        {"Smithsonian Astrophysical Observation", "SAO 6153"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.41135863),
        dec: Angle.Degrees(+76.96716758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37028"},
        {"Hipparcos Number", "HIP 27130"},
        {"Geneva Identification System", "GEN# +1.00037028"},
        {"Smithsonian Astrophysical Observation", "SAO 5628"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.29820712),
        dec: Angle.Degrees(+76.96722017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28567"},
        {"Hipparcos Number", "HIP 21662"},
        {"Smithsonian Astrophysical Observation", "SAO 5259"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76615928),
        dec: Angle.Degrees(+76.97434981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49878"},
        {"Hipparcos Number", "HIP 33694"},
        {"Fundamental Katalog 5th Edition", "FK5 260"},
        {"Geneva Identification System", "GEN# +1.00049878"},
        {"Smithsonian Astrophysical Observation", "SAO 6022"},
        {"Wilson Evans Batten Catalogue", "WEB 6769"},
    },
    visualMagnitude: 4.55,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.01603320),
        dec: Angle.Degrees(+76.97744152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123897"},
        {"Hipparcos Number", "HIP 68816"},
        {"Smithsonian Astrophysical Observation", "SAO 7948"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.34119488),
        dec: Angle.Degrees(+76.98159874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79062"},
        {"Smithsonian Astrophysical Observation", "SAO 8440"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.08087604),
        dec: Angle.Degrees(+76.98572388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61496"},
        {"Hipparcos Number", "HIP 38097"},
        {"Geneva Identification System", "GEN# +1.00061496"},
        {"Smithsonian Astrophysical Observation", "SAO 6305"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.09804859),
        dec: Angle.Degrees(+76.98612600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57923"},
        {"Smithsonian Astrophysical Observation", "SAO 7441"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19736401),
        dec: Angle.Degrees(+76.98891886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47505"},
        {"Hipparcos Number", "HIP 32647"},
        {"Smithsonian Astrophysical Observation", "SAO 5969"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.15608149),
        dec: Angle.Degrees(+76.99011706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10790"},
        {"Hipparcos Number", "HIP 8525"},
        {"Smithsonian Astrophysical Observation", "SAO 4496"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.48463519),
        dec: Angle.Degrees(+76.99221841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25289"},
        {"Hipparcos Number", "HIP 19429"},
        {"Smithsonian Astrophysical Observation", "SAO 5102"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.41477034),
        dec: Angle.Degrees(+76.99436340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44028"},
        {"Hipparcos Number", "HIP 30892"},
        {"Fundamental Katalog 5th Edition", "FK5 4590"},
        {"Smithsonian Astrophysical Observation", "SAO 5854"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.27275493),
        dec: Angle.Degrees(+76.99626741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190768"},
        {"Hipparcos Number", "HIP 98299"},
        {"Geneva Identification System", "GEN# +1.00190768"},
        {"Smithsonian Astrophysical Observation", "SAO 9601"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.59088313),
        dec: Angle.Degrees(+77.00555989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203399"},
        {"Hipparcos Number", "HIP 104968"},
        {"Geneva Identification System", "GEN# +1.00203399"},
        {"Smithsonian Astrophysical Observation", "SAO 10007"},
        {"Wilson Evans Batten Catalogue", "WEB 19078"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92663197),
        dec: Angle.Degrees(+77.01226067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96590"},
        {"Hipparcos Number", "HIP 54560"},
        {"Smithsonian Astrophysical Observation", "SAO 7294"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47293230),
        dec: Angle.Degrees(+77.01806597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2589"},
        {"Hipparcos Number", "HIP 2422"},
        {"Fundamental Katalog 5th Edition", "FK5 2031"},
        {"Geneva Identification System", "GEN# +1.00002589"},
        {"Smithsonian Astrophysical Observation", "SAO 4130"},
        {"Wilson Evans Batten Catalogue", "WEB 442"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.72581643),
        dec: Angle.Degrees(+77.01948785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82111"},
        {"Smithsonian Astrophysical Observation", "SAO 8626"},
    },
    visualMagnitude: 10.00,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.59150083),
        dec: Angle.Degrees(+77.02155193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163767"},
        {"Hipparcos Number", "HIP 87157"},
        {"Geneva Identification System", "GEN# +1.00163767"},
        {"Smithsonian Astrophysical Observation", "SAO 8936"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.10293802),
        dec: Angle.Degrees(+77.02905350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44583"},
        {"Smithsonian Astrophysical Observation", "SAO 6727"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.24642050),
        dec: Angle.Degrees(+77.03192446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102326"},
        {"Hipparcos Number", "HIP 57532"},
        {"Geneva Identification System", "GEN# +1.00102326"},
        {"Smithsonian Astrophysical Observation", "SAO 7426"},
        {"Wilson Evans Batten Catalogue", "WEB 10331"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.87438610),
        dec: Angle.Degrees(+77.04013297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44555"},
        {"Hipparcos Number", "HIP 31145"},
        {"Geneva Identification System", "GEN# +1.00044555"},
        {"Smithsonian Astrophysical Observation", "SAO 5873"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.02329667),
        dec: Angle.Degrees(+77.04262142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71827"},
        {"Hipparcos Number", "HIP 42279"},
        {"Geneva Identification System", "GEN# +1.00071827"},
        {"Smithsonian Astrophysical Observation", "SAO 6590"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.30993007),
        dec: Angle.Degrees(+77.04662314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178089"},
        {"Hipparcos Number", "HIP 93097"},
        {"Geneva Identification System", "GEN# +1.00178089"},
        {"Smithsonian Astrophysical Observation", "SAO 9296"},
        {"Wilson Evans Batten Catalogue", "WEB 16128"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.48865324),
        dec: Angle.Degrees(+77.05098126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107328"},
        {"Smithsonian Astrophysical Observation", "SAO 10141"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.08602696),
        dec: Angle.Degrees(+77.05288691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70351"},
        {"Hipparcos Number", "HIP 41636"},
        {"Geneva Identification System", "GEN# +1.00070351"},
        {"Smithsonian Astrophysical Observation", "SAO 6545"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.35772905),
        dec: Angle.Degrees(+77.05957691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220237"},
        {"Hipparcos Number", "HIP 115262"},
        {"Geneva Identification System", "GEN# +1.00220237"},
        {"Smithsonian Astrophysical Observation", "SAO 10712"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.18807964),
        dec: Angle.Degrees(+77.06263798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20111"},
        {"Hipparcos Number", "HIP 15620"},
        {"Geneva Identification System", "GEN# +1.00020111"},
        {"Smithsonian Astrophysical Observation", "SAO 4879"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.28469176),
        dec: Angle.Degrees(+77.06740884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78846"},
        {"Hipparcos Number", "HIP 45550"},
        {"Smithsonian Astrophysical Observation", "SAO 6794"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.25583743),
        dec: Angle.Degrees(+77.07416567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81282"},
        {"Hipparcos Number", "HIP 46641"},
        {"Smithsonian Astrophysical Observation", "SAO 6874"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.65909993),
        dec: Angle.Degrees(+77.07817756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17889"},
        {"Hipparcos Number", "HIP 13897"},
        {"Geneva Identification System", "GEN# +1.00017889"},
        {"Smithsonian Astrophysical Observation", "SAO 4782"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.73680984),
        dec: Angle.Degrees(+77.08013994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25688"},
        {"Hipparcos Number", "HIP 19697"},
        {"Smithsonian Astrophysical Observation", "SAO 5120"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.29792635),
        dec: Angle.Degrees(+77.08325072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94190"},
        {"Hipparcos Number", "HIP 53389"},
        {"Geneva Identification System", "GEN# +1.00094190"},
        {"Smithsonian Astrophysical Observation", "SAO 7237"},
        {"Wilson Evans Batten Catalogue", "WEB 9690"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.80467356),
        dec: Angle.Degrees(+77.08755348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204408"},
        {"Hipparcos Number", "HIP 105526"},
        {"Fundamental Katalog 5th Edition", "FK5 3709"},
        {"Geneva Identification System", "GEN# +1.00204408"},
        {"Smithsonian Astrophysical Observation", "SAO 10034"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.58878832),
        dec: Angle.Degrees(+77.09032607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108074"},
        {"Hipparcos Number", "HIP 60494"},
        {"Smithsonian Astrophysical Observation", "SAO 7558"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.02575716),
        dec: Angle.Degrees(+77.10898323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88627"},
        {"Hipparcos Number", "HIP 50412"},
        {"Geneva Identification System", "GEN# +1.00088627"},
        {"Wilson Evans Batten Catalogue", "WEB 9251"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.40262182),
        dec: Angle.Degrees(+77.11212247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159606"},
        {"Hipparcos Number", "HIP 85309"},
        {"Geneva Identification System", "GEN# +1.00159606"},
        {"Smithsonian Astrophysical Observation", "SAO 8808"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.49649995),
        dec: Angle.Degrees(+77.11513076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36585"},
        {"Hipparcos Number", "HIP 26888"},
        {"Geneva Identification System", "GEN# +1.00036585"},
        {"Smithsonian Astrophysical Observation", "SAO 5612"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.62643612),
        dec: Angle.Degrees(+77.11621667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150962"},
        {"Hipparcos Number", "HIP 81212"},
        {"Geneva Identification System", "GEN# +1.00150962"},
        {"Smithsonian Astrophysical Observation", "SAO 8570"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.82565603),
        dec: Angle.Degrees(+77.12027027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183678"},
        {"Hipparcos Number", "HIP 95178"},
        {"Smithsonian Astrophysical Observation", "SAO 9407"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.43623339),
        dec: Angle.Degrees(+77.12727852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 384.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171826"},
        {"Hipparcos Number", "HIP 90449"},
        {"Smithsonian Astrophysical Observation", "SAO 9138"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.83809745),
        dec: Angle.Degrees(+77.13462160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75055"},
        {"Smithsonian Astrophysical Observation", "SAO 8225"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.05644337),
        dec: Angle.Degrees(+77.13866201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 257.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176623"},
        {"Hipparcos Number", "HIP 92571"},
        {"Smithsonian Astrophysical Observation", "SAO 9277"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.95325011),
        dec: Angle.Degrees(+77.14376634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142123"},
        {"Hipparcos Number", "HIP 77105"},
        {"Geneva Identification System", "GEN# +1.00142123"},
        {"Smithsonian Astrophysical Observation", "SAO 8332"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.16207267),
        dec: Angle.Degrees(+77.15035525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20857"},
        {"Hipparcos Number", "HIP 16233"},
        {"Geneva Identification System", "GEN# +1.00020857"},
        {"Smithsonian Astrophysical Observation", "SAO 4908"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.29757908),
        dec: Angle.Degrees(+77.15646922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22220"},
        {"Hipparcos Number", "HIP 17333"},
        {"Fundamental Katalog 5th Edition", "FK5 4337"},
        {"Smithsonian Astrophysical Observation", "SAO 4964"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.64987576),
        dec: Angle.Degrees(+77.17037468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23073"},
        {"Hipparcos Number", "HIP 17940"},
        {"Smithsonian Astrophysical Observation", "SAO 4996"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.54614795),
        dec: Angle.Degrees(+77.17931777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93779"},
        {"Smithsonian Astrophysical Observation", "SAO 9324"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.47533926),
        dec: Angle.Degrees(+77.18263155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137200"},
        {"Hipparcos Number", "HIP 74812"},
        {"Smithsonian Astrophysical Observation", "SAO 8214"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.33483463),
        dec: Angle.Degrees(+77.18597946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1860"},
        {"Geneva Identification System", "GEN# +9.80242051"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.87929684),
        dec: Angle.Degrees(+77.18918134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -840.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115179"},
        {"Hipparcos Number", "HIP 64434"},
        {"Smithsonian Astrophysical Observation", "SAO 7777"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.09754992),
        dec: Angle.Degrees(+77.19447085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 606 A"},
        {"Henry Draper", "HD 4012"},
        {"Hipparcos Number", "HIP 3472"},
        {"Smithsonian Astrophysical Observation", "SAO 4201"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.09097381),
        dec: Angle.Degrees(+77.20998501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 606 B"},
        {"Hipparcos Number", "HIP 3482"},
    },
    visualMagnitude: 8.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)44, 27.3800),
        dec: Angle.DegreesMinutesSeconds((int)+77, (int)12, 37.200)
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
    primaryId: "HIP 105032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105032"},
        {"Smithsonian Astrophysical Observation", "SAO 10013"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.11340247),
        dec: Angle.Degrees(+77.21082846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79886"},
        {"Hipparcos Number", "HIP 46005"},
        {"Smithsonian Astrophysical Observation", "SAO 6829"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.74189538),
        dec: Angle.Degrees(+77.21977845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83422"},
        {"Hipparcos Number", "HIP 47730"},
        {"Smithsonian Astrophysical Observation", "SAO 6937"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.94658135),
        dec: Angle.Degrees(+77.22190958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92093"},
        {"Hipparcos Number", "HIP 52312"},
        {"Smithsonian Astrophysical Observation", "SAO 7185"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.33104307),
        dec: Angle.Degrees(+77.22337972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48268"},
        {"Hipparcos Number", "HIP 32982"},
        {"Smithsonian Astrophysical Observation", "SAO 5987"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.05748751),
        dec: Angle.Degrees(+77.22518174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29831"},
        {"Hipparcos Number", "HIP 22561"},
        {"Smithsonian Astrophysical Observation", "SAO 5318"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.83466609),
        dec: Angle.Degrees(+77.22522222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216498"},
        {"Hipparcos Number", "HIP 112795"},
        {"Smithsonian Astrophysical Observation", "SAO 10519"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.62457107),
        dec: Angle.Degrees(+77.22803490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67052"},
        {"Geneva Identification System", "GEN# +0.07700521"},
        {"Smithsonian Astrophysical Observation", "SAO 7879"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.11500467),
        dec: Angle.Degrees(+77.23093028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101814"},
        {"Smithsonian Astrophysical Observation", "SAO 9839"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.49399248),
        dec: Angle.Degrees(+77.23441799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193202"},
        {"Hipparcos Number", "HIP 99427"},
        {"Cincinnati Publication", "Ci 18 2648"},
        {"Cincinnati Publication 2", "Ci 20 1200"},
        {"Geneva Identification System", "GEN# +1.00193202"},
        {"Smithsonian Astrophysical Observation", "SAO 9679"},
        {"Wilson Evans Batten Catalogue", "WEB 17761"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.71777449),
        dec: Angle.Degrees(+77.23772618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 512.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45593"},
        {"Cincinnati Publication", "Ci 20 515"},
        {"Geneva Identification System", "GEN# +0.07700361J"},
        {"Wilson Evans Batten Catalogue", "WEB 8667"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.38876461),
        dec: Angle.Degrees(+77.24470229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1067.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67965"},
        {"Smithsonian Astrophysical Observation", "SAO 7910"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.77358688),
        dec: Angle.Degrees(+77.25448039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224540"},
        {"Hipparcos Number", "HIP 118207"},
        {"Smithsonian Astrophysical Observation", "SAO 10918"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.66224752),
        dec: Angle.Degrees(+77.26211338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143252"},
        {"Hipparcos Number", "HIP 77629"},
        {"Geneva Identification System", "GEN# +1.00143252"},
        {"Smithsonian Astrophysical Observation", "SAO 8356"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.72824727),
        dec: Angle.Degrees(+77.26524473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85794"},
        {"Hipparcos Number", "HIP 48967"},
        {"Geneva Identification System", "GEN# +1.00085794"},
        {"Smithsonian Astrophysical Observation", "SAO 7011"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.83927451),
        dec: Angle.Degrees(+77.26836064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12230"},
        {"Hipparcos Number", "HIP 9727"},
        {"Fundamental Katalog 5th Edition", "FK5 2139"},
        {"Geneva Identification System", "GEN# +1.00012230"},
        {"Smithsonian Astrophysical Observation", "SAO 4562"},
        {"Wilson Evans Batten Catalogue", "WEB 2044"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.27938922),
        dec: Angle.Degrees(+77.28145654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41096"},
        {"Hipparcos Number", "HIP 29503"},
        {"Geneva Identification System", "GEN# +1.00041096"},
        {"Smithsonian Astrophysical Observation", "SAO 5770"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24325566),
        dec: Angle.Degrees(+77.28679675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97888"},
        {"Hipparcos Number", "HIP 55151"},
        {"Smithsonian Astrophysical Observation", "SAO 7328"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.36941640),
        dec: Angle.Degrees(+77.29130292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73510"},
        {"Smithsonian Astrophysical Observation", "SAO 8151"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.36950866),
        dec: Angle.Degrees(+77.30228052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209743"},
        {"Hipparcos Number", "HIP 108676"},
        {"Smithsonian Astrophysical Observation", "SAO 10226"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.23253405),
        dec: Angle.Degrees(+77.31622948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56286"},
        {"Smithsonian Astrophysical Observation", "SAO 7372"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.08061010),
        dec: Angle.Degrees(+77.31682593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15408"},
        {"Smithsonian Astrophysical Observation", "SAO 4867"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.66518089),
        dec: Angle.Degrees(+77.32322436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160758"},
        {"Hipparcos Number", "HIP 85795"},
        {"Geneva Identification System", "GEN# +1.00160758"},
        {"Smithsonian Astrophysical Observation", "SAO 8844"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.96445595),
        dec: Angle.Degrees(+77.34259373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70807"},
        {"Smithsonian Astrophysical Observation", "SAO 8031"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.21081569),
        dec: Angle.Degrees(+77.34329568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8885"},
    },
    visualMagnitude: 10.96,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.59832467),
        dec: Angle.Degrees(+77.34727400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139669"},
        {"Hipparcos Number", "HIP 76008"},
        {"Fundamental Katalog 5th Edition", "FK5 3229"},
        {"Geneva Identification System", "GEN# +1.00139669"},
        {"Smithsonian Astrophysical Observation", "SAO 8274"},
        {"Wilson Evans Batten Catalogue", "WEB 12921"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.85439245),
        dec: Angle.Degrees(+77.34933897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109596"},
        {"Smithsonian Astrophysical Observation", "SAO 10282"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.01712204),
        dec: Angle.Degrees(+77.35025210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157602"},
        {"Hipparcos Number", "HIP 84330"},
        {"Geneva Identification System", "GEN# +1.00157602"},
        {"Smithsonian Astrophysical Observation", "SAO 8745"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.60485255),
        dec: Angle.Degrees(+77.35091260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60732"},
        {"Smithsonian Astrophysical Observation", "SAO 7567"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.70885637),
        dec: Angle.Degrees(+77.35226021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25162"},
        {"Smithsonian Astrophysical Observation", "SAO 5504"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75730087),
        dec: Angle.Degrees(+77.36293231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116822"},
        {"Smithsonian Astrophysical Observation", "SAO 10830"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.16458623),
        dec: Angle.Degrees(+77.36766417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134678"},
        {"Hipparcos Number", "HIP 73715"},
        {"Geneva Identification System", "GEN# +1.00134678"},
        {"Smithsonian Astrophysical Observation", "SAO 8158"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.02632087),
        dec: Angle.Degrees(+77.37181090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98661"},
        {"Hipparcos Number", "HIP 55561"},
        {"Geneva Identification System", "GEN# +1.00098661"},
        {"Smithsonian Astrophysical Observation", "SAO 7348"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.70739967),
        dec: Angle.Degrees(+77.37342402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47428"},
        {"Hipparcos Number", "HIP 32635"},
        {"Smithsonian Astrophysical Observation", "SAO 5966"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.10886574),
        dec: Angle.Degrees(+77.37756920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82718"},
        {"Hipparcos Number", "HIP 47419"},
        {"Smithsonian Astrophysical Observation", "SAO 6919"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.93702416),
        dec: Angle.Degrees(+77.38367982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87541"},
        {"Smithsonian Astrophysical Observation", "SAO 8960"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.26701269),
        dec: Angle.Degrees(+77.38392394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105717"},
        {"Hipparcos Number", "HIP 59294"},
        {"Geneva Identification System", "GEN# +1.00105717"},
        {"Smithsonian Astrophysical Observation", "SAO 7513"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.45457883),
        dec: Angle.Degrees(+77.39029588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132294"},
        {"Hipparcos Number", "HIP 72695"},
        {"Geneva Identification System", "GEN# +1.00132294"},
        {"Smithsonian Astrophysical Observation", "SAO 8108"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.94302224),
        dec: Angle.Degrees(+77.41145040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92319"},
        {"Hipparcos Number", "HIP 52433"},
        {"Smithsonian Astrophysical Observation", "SAO 7191"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.78666969),
        dec: Angle.Degrees(+77.41176992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2836 AB"},
        {"Henry Draper", "HD 23944"},
        {"Hipparcos Number", "HIP 18510"},
        {"Smithsonian Astrophysical Observation", "SAO 5036"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.36584140),
        dec: Angle.Degrees(+77.41481763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213085"},
        {"Hipparcos Number", "HIP 110666"},
        {"Smithsonian Astrophysical Observation", "SAO 10364"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.28634604),
        dec: Angle.Degrees(+77.43241527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106053"},
        {"Hipparcos Number", "HIP 59463"},
        {"Geneva Identification System", "GEN# +1.00106053"},
        {"Smithsonian Astrophysical Observation", "SAO 7521"},
        {"Wilson Evans Batten Catalogue", "WEB 10572"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.95139612),
        dec: Angle.Degrees(+77.44077131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30643"},
        {"Hipparcos Number", "HIP 23175"},
        {"Smithsonian Astrophysical Observation", "SAO 5364"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.78496840),
        dec: Angle.Degrees(+77.44222413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113937"},
        {"Hipparcos Number", "HIP 63770"},
        {"Smithsonian Astrophysical Observation", "SAO 7740"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.07256190),
        dec: Angle.Degrees(+77.44236743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150275"},
        {"Hipparcos Number", "HIP 80850"},
        {"Fundamental Katalog 5th Edition", "FK5 623"},
        {"Geneva Identification System", "GEN# +1.00150275"},
        {"Smithsonian Astrophysical Observation", "SAO 8548"},
        {"Wilson Evans Batten Catalogue", "WEB 13674"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.66283125),
        dec: Angle.Degrees(+77.44585077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 272.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222314"},
        {"Hipparcos Number", "HIP 116666"},
        {"Smithsonian Astrophysical Observation", "SAO 10810"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.64034975),
        dec: Angle.Degrees(+77.45132494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200960"},
        {"Hipparcos Number", "HIP 103628"},
        {"Smithsonian Astrophysical Observation", "SAO 9931"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.94655081),
        dec: Angle.Degrees(+77.45591425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71087"},
        {"Hipparcos Number", "HIP 41988"},
        {"Smithsonian Astrophysical Observation", "SAO 6569"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.37744610),
        dec: Angle.Degrees(+77.45953477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88636"},
        {"Hipparcos Number", "HIP 50431"},
        {"Smithsonian Astrophysical Observation", "SAO 7095"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.45663210),
        dec: Angle.Degrees(+77.46586089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5500"},
        {"Hipparcos Number", "HIP 4615"},
        {"Smithsonian Astrophysical Observation", "SAO 4279"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.78079445),
        dec: Angle.Degrees(+77.46604760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5313"},
        {"Hipparcos Number", "HIP 4470"},
        {"Geneva Identification System", "GEN# +1.00005313"},
        {"Smithsonian Astrophysical Observation", "SAO 4269"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.32267065),
        dec: Angle.Degrees(+77.47098642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50960"},
        {"Smithsonian Astrophysical Observation", "SAO 7127"},
        {"Wilson Evans Batten Catalogue", "WEB 9323"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.10923202),
        dec: Angle.Degrees(+77.47132778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52029"},
        {"Smithsonian Astrophysical Observation", "SAO 7171"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.45739834),
        dec: Angle.Degrees(+77.48627861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167131"},
        {"Hipparcos Number", "HIP 88482"},
        {"Geneva Identification System", "GEN# +1.00167131"},
        {"Smithsonian Astrophysical Observation", "SAO 9010"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.00699878),
        dec: Angle.Degrees(+77.48678730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111877"},
        {"Hipparcos Number", "HIP 62644"},
        {"Smithsonian Astrophysical Observation", "SAO 7679"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54720893),
        dec: Angle.Degrees(+77.49018547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90645"},
        {"Hipparcos Number", "HIP 51573"},
        {"Geneva Identification System", "GEN# +1.00090645"},
        {"Smithsonian Astrophysical Observation", "SAO 7155"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00549734),
        dec: Angle.Degrees(+77.49801683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3036"},
        {"Hipparcos Number", "HIP 2749"},
        {"Geneva Identification System", "GEN# +1.00003036"},
        {"Renson", "Renson 800"},
        {"Smithsonian Astrophysical Observation", "SAO 4151"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.77017154),
        dec: Angle.Degrees(+77.50089827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217011"},
        {"Hipparcos Number", "HIP 113155"},
        {"Smithsonian Astrophysical Observation", "SAO 10549"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.70652945),
        dec: Angle.Degrees(+77.50570859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220636"},
        {"Henry Draper 2", "HD 220637"},
        {"Hipparcos Number", "HIP 115513"},
        {"Geneva Identification System", "GEN# +1.00220636"},
        {"Smithsonian Astrophysical Observation", "SAO 10727"},
        {"Wilson Evans Batten Catalogue", "WEB 20448"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.98473147),
        dec: Angle.Degrees(+77.51174222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81854",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10214 A"},
        {"Henry Draper", "HD 152303"},
        {"Hipparcos Number", "HIP 81854"},
        {"Geneva Identification System", "GEN# +1.00152303"},
        {"Smithsonian Astrophysical Observation", "SAO 8612"},
        {"Wilson Evans Batten Catalogue", "WEB 13829"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77557016),
        dec: Angle.Degrees(+77.51347098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187968"},
        {"Hipparcos Number", "HIP 97089"},
        {"Smithsonian Astrophysical Observation", "SAO 9528"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.97094910),
        dec: Angle.Degrees(+77.53343519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36383"},
        {"Hipparcos Number", "HIP 26790"},
        {"Geneva Identification System", "GEN# +1.00036383"},
        {"Smithsonian Astrophysical Observation", "SAO 5601"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.35298593),
        dec: Angle.Degrees(+77.53628697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13779"},
        {"Smithsonian Astrophysical Observation", "SAO 4777"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.33845828),
        dec: Angle.Degrees(+77.53760208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192419"},
        {"Hipparcos Number", "HIP 99033"},
        {"Smithsonian Astrophysical Observation", "SAO 9649"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.59840341),
        dec: Angle.Degrees(+77.53780265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172340"},
        {"Hipparcos Number", "HIP 90647"},
        {"Fundamental Katalog 5th Edition", "FK5 700"},
        {"Geneva Identification System", "GEN# +1.00172340"},
        {"Smithsonian Astrophysical Observation", "SAO 9151"},
        {"Wilson Evans Batten Catalogue", "WEB 15521"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.43734872),
        dec: Angle.Degrees(+77.54706964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124547"},
        {"Hipparcos Number", "HIP 69112"},
        {"Fundamental Katalog 5th Edition", "FK5 524"},
        {"Geneva Identification System", "GEN# +1.00124547"},
        {"Smithsonian Astrophysical Observation", "SAO 7958"},
        {"Wilson Evans Batten Catalogue", "WEB 12068"},
    },
    visualMagnitude: 4.80,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.21253759),
        dec: Angle.Degrees(+77.54743312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83140"},
        {"Hipparcos Number", "HIP 47593"},
        {"Smithsonian Astrophysical Observation", "SAO 6933"},
        {"Wilson Evans Batten Catalogue", "WEB 8921"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.56267542),
        dec: Angle.Degrees(+77.54771897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148386"},
        {"Hipparcos Number", "HIP 79900"},
        {"Smithsonian Astrophysical Observation", "SAO 8481"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.63605349),
        dec: Angle.Degrees(+77.54880756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61522"},
        {"Smithsonian Astrophysical Observation", "SAO 7606"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07219012),
        dec: Angle.Degrees(+77.55204443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171299"},
        {"Hipparcos Number", "HIP 90186"},
        {"Geneva Identification System", "GEN# +1.00171299"},
        {"Smithsonian Astrophysical Observation", "SAO 9123"},
        {"Wilson Evans Batten Catalogue", "WEB 15425"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.04332500),
        dec: Angle.Degrees(+77.56128829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30055"},
        {"Hipparcos Number", "HIP 22769"},
        {"Smithsonian Astrophysical Observation", "SAO 5336"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.47038567),
        dec: Angle.Degrees(+77.56599819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7732"},
        {"Hipparcos Number", "HIP 6261"},
        {"Geneva Identification System", "GEN# +1.00007732"},
        {"Smithsonian Astrophysical Observation", "SAO 4376"},
        {"Wilson Evans Batten Catalogue", "WEB 1397"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.08104611),
        dec: Angle.Degrees(+77.57046497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10125"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.55549494),
        dec: Angle.Degrees(+77.57136041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63383"},
        {"Hipparcos Number", "HIP 38900"},
        {"Fundamental Katalog 5th Edition", "FK5 2612"},
        {"Geneva Identification System", "GEN# +1.00063383"},
        {"Smithsonian Astrophysical Observation", "SAO 6357"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.41559451),
        dec: Angle.Degrees(+77.57647786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212438"},
        {"Hipparcos Number", "HIP 110270"},
        {"Geneva Identification System", "GEN# +1.00212438"},
        {"Smithsonian Astrophysical Observation", "SAO 10327"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.03799647),
        dec: Angle.Degrees(+77.57687274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213672"},
        {"Hipparcos Number", "HIP 111003"},
        {"Smithsonian Astrophysical Observation", "SAO 10398"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.33795331),
        dec: Angle.Degrees(+77.58238378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167963"},
        {"Hipparcos Number", "HIP 88780"},
        {"Smithsonian Astrophysical Observation", "SAO 9030"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.85455488),
        dec: Angle.Degrees(+77.59312212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100858"},
        {"Hipparcos Number", "HIP 56716"},
        {"Fundamental Katalog 5th Edition", "FK5 2928"},
        {"Geneva Identification System", "GEN# +1.00100858"},
        {"Smithsonian Astrophysical Observation", "SAO 7395"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.42630265),
        dec: Angle.Degrees(+77.59569368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223731"},
        {"Hipparcos Number", "HIP 117681"},
        {"Fundamental Katalog 5th Edition", "FK5 3919"},
        {"Geneva Identification System", "GEN# +1.00223731"},
        {"Smithsonian Astrophysical Observation", "SAO 10874"},
        {"Wilson Evans Batten Catalogue", "WEB 20708"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.98714802),
        dec: Angle.Degrees(+77.59959953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7402"},
        {"Smithsonian Astrophysical Observation", "SAO 4436"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85826030),
        dec: Angle.Degrees(+77.60322956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155247"},
        {"Hipparcos Number", "HIP 83225"},
        {"Geneva Identification System", "GEN# +1.00155247"},
        {"Smithsonian Astrophysical Observation", "SAO 8696"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.12559637),
        dec: Angle.Degrees(+77.61476271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215398"},
        {"Hipparcos Number", "HIP 112036"},
        {"Smithsonian Astrophysical Observation", "SAO 10469"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.38861493),
        dec: Angle.Degrees(+77.61521853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106112"},
        {"Hipparcos Number", "HIP 59504"},
        {"Fundamental Katalog 5th Edition", "FK5 454"},
        {"Geneva Identification System", "GEN# +1.00106112"},
        {"Renson", "Renson 30670"},
        {"Smithsonian Astrophysical Observation", "SAO 7522"},
        {"Wilson Evans Batten Catalogue", "WEB 10580"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.04963833),
        dec: Angle.Degrees(+77.61619242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27757"},
        {"Hipparcos Number", "HIP 21165"},
        {"Geneva Identification System", "GEN# +1.00027757"},
        {"Smithsonian Astrophysical Observation", "SAO 5221"},
        {"Wilson Evans Batten Catalogue", "WEB 4070"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.06422759),
        dec: Angle.Degrees(+77.62428684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97177"},
        {"Hipparcos Number", "HIP 54821"},
        {"Geneva Identification System", "GEN# +1.00097177"},
        {"Smithsonian Astrophysical Observation", "SAO 7310"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.33457802),
        dec: Angle.Degrees(+77.62501925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116727",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Errai"},
        {"Henry Draper", "HD 222404"},
        {"Hipparcos Number", "HIP 116727"},
        {"Fundamental Katalog 5th Edition", "FK5 893"},
        {"Geneva Identification System", "GEN# +1.00222404"},
        {"Smithsonian Astrophysical Observation", "SAO 10818"},
        {"Wilson Evans Batten Catalogue", "WEB 20599"},
    },
    visualMagnitude: 3.21,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.83742516),
        dec: Angle.Degrees(+77.63196681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16106"},
        {"Hipparcos Number", "HIP 12578"},
        {"Smithsonian Astrophysical Observation", "SAO 4705"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.43399299),
        dec: Angle.Degrees(+77.63870812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66170"},
        {"Hipparcos Number", "HIP 40055"},
        {"Geneva Identification System", "GEN# +1.00066170"},
        {"Smithsonian Astrophysical Observation", "SAO 6428"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.73760159),
        dec: Angle.Degrees(+77.64239934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63855"},
        {"Hipparcos Number", "HIP 39110"},
        {"Smithsonian Astrophysical Observation", "SAO 6373"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.02138167),
        dec: Angle.Degrees(+77.64597955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79856"},
        {"Smithsonian Astrophysical Observation", "SAO 8477"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.51544206),
        dec: Angle.Degrees(+77.64883558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154528"},
        {"Hipparcos Number", "HIP 82871"},
        {"Smithsonian Astrophysical Observation", "SAO 8674"},
        {"Wilson Evans Batten Catalogue", "WEB 14010"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.04230303),
        dec: Angle.Degrees(+77.65271094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150902"},
        {"Hipparcos Number", "HIP 81156"},
        {"Geneva Identification System", "GEN# +1.00150902"},
        {"Smithsonian Astrophysical Observation", "SAO 8566"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.62596503),
        dec: Angle.Degrees(+77.65397870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76017"},
    },
    visualMagnitude: 11.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.89097752),
        dec: Angle.Degrees(+77.65943554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
